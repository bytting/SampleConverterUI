using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SampleConverterUI
{
    public partial class FormMain : Form
    {
        bool Initalized = false;
        public string InstallDir, PluginDirectory, SampleConverter;     

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Load             
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            // Paint
            if(!Initalized)
            {
                try
                {
                    Initalized = true;
                    InstallDir = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory + "\\";
                    SampleConverter = InstallDir + "SampleConverter.exe";
                    if (!File.Exists(SampleConverter))
                    {
                        MessageBox.Show("Unable to find SampleConverter.exe in " + InstallDir);
                        Close();
                    }

                    PluginDirectory = GetPluginDirectory();
                    if (!Directory.Exists(PluginDirectory))
                        Directory.CreateDirectory(PluginDirectory);

                    CopyPlugin("colibri.js");
                    CopyPlugin("colibri-internal.js");
                    CopyPlugin("sam940.js");
                    CopyPlugin("colibri-internal.js");
                    CopyPlugin("sampleregistration.js");
                    CopyPlugin("sampleregistration-activity.js");

                    lblPluginFolder.Text = PluginDirectory;
                    cboxPlugins.Items.Clear();
                    cboxPlugins.Items.AddRange(GetPluginList());

                    cboxFormat.Items.Clear();
                    cboxFormat.Items.AddRange(GetFormatList());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CopyPlugin(string pluginName)
        {
            try
            {
                string src = InstallDir + Path.DirectorySeparatorChar + "plugins" + Path.DirectorySeparatorChar + pluginName;
                string dest = PluginDirectory + Path.DirectorySeparatorChar + pluginName;

                if (!File.Exists(dest))
                    File.Copy(src, dest, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closing            
        }

        private void menuItemSetPluginFolder_Click(object sender, EventArgs e)
        {
            folderDialog.Description = "Select a plugin directory";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                PluginDirectory = folderDialog.SelectedPath;
                lblPluginFolder.Text = PluginDirectory;
                SetPluginDirectory(PluginDirectory);                
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void btnClearFiles_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            if (fileDialog.ShowDialog() == DialogResult.OK)            
                lbFiles.Items.AddRange(fileDialog.FileNames);                            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (lbFiles.Items.Count < 1)
            {
                MessageBox.Show("You must choose at least one file to convert");
                return;
            }

            if(String.IsNullOrEmpty(cboxPlugins.Text))
            {
                MessageBox.Show("You must choose a plugin first");
                return;
            }

            if (String.IsNullOrEmpty(cboxFormat.Text))
            {
                MessageBox.Show("You must choose a format first");
                return;
            }

            string plugin = cboxPlugins.Text;
            string format = cboxFormat.Text;
            bool useLabels = cbUseLabels.Checked;
            bool useScientific = cbUseScientific.Checked;
            
            List<string> lines = new List<string>();
            foreach (string s in lbFiles.Items)
                lines.Add(s);

            ExecutePlugin(plugin, format, useLabels, useScientific, lines.ToArray());
            lbLog.TopIndex = lbLog.Items.Count - 1;
        }

        private Process NewProcess()
        {
            Process p = new Process();
            p.StartInfo.FileName = SampleConverter;            
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            return p;
        }

        private void SetPluginDirectory(string dir)
        {
            Process p = NewProcess();            
            p.StartInfo.Arguments = "-set-plugin-directory=\"" + dir + "\"";
            p.Start();

            string s;
            while ((s = p.StandardOutput.ReadLine()) != null)
                lbLog.Items.Add(s);

            while ((s = p.StandardError.ReadLine()) != null)
                lbLog.Items.Add(s);

            p.WaitForExit();
        }        

        private string GetPluginDirectory()
        {
            Process p = NewProcess();            
            p.StartInfo.Arguments = "-show-plugin-directory";            
            p.Start();

            string s, dir = p.StandardOutput.ReadLine();

            while ((s = p.StandardError.ReadLine()) != null)
                lbLog.Items.Add(s);

            p.WaitForExit();
            return dir;
        }

        private string[] GetPluginList()
        {
            List<string> list = new List<string>();

            Process p = NewProcess();            
            p.StartInfo.Arguments = "-list-plugins";                        
            p.Start();

            string s;
            while ((s = p.StandardOutput.ReadLine()) != null)
                list.Add(s);

            while ((s = p.StandardError.ReadLine()) != null)
                lbLog.Items.Add(s);

            p.WaitForExit();

            /*if (p.ExitCode != 0)
            {
                statusLabel.Text = specsoft + " failed while running script";
                return;
            }
            else statusLabel.Text = specsoft + " finished successfully";*/

            return list.ToArray();
        }

        private string[] GetFormatList()
        {
            List<string> list = new List<string>();

            Process p = NewProcess();
            p.StartInfo.Arguments = "-list-formats";
            p.Start();

            string s;
            while ((s = p.StandardOutput.ReadLine()) != null)
                list.Add(s);

            while ((s = p.StandardError.ReadLine()) != null)
                lbLog.Items.Add(s);

            p.WaitForExit();

            /*if (p.ExitCode != 0)
            {
                statusLabel.Text = specsoft + " failed while running script";
                return;
            }
            else statusLabel.Text = specsoft + " finished successfully";*/

            return list.ToArray();
        }

        private void ExecutePlugin(string plugin, string format, bool useLabels, bool useScientific, string[] files)
        {            
            Process p = NewProcess();                        

            p.StartInfo.Arguments = "-use-plugin=\"" + plugin + "\" -use-format=" + format;

            if (useLabels)
                p.StartInfo.Arguments += " -use-labels";

            if (useScientific)
                p.StartInfo.Arguments += " -use-scientific";

            foreach (string f in files)            
                p.StartInfo.Arguments += " \"" + f + "\"";            

            p.Start();

            string s;
            while ((s = p.StandardOutput.ReadLine()) != null)
            {                
                lbLog.Items.Add(s);
                Application.DoEvents();
            }

            while ((s = p.StandardError.ReadLine()) != null)
            {
                lbLog.Items.Add(s);
                Application.DoEvents();
            }

            p.WaitForExit();        
        }
    }
}
