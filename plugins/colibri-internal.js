// To the extent possible under law, Dag Robøle has waived all copyright and related or neighboring rights to this work.

function parseLine(lineNumber, line)
{
	if(lineNumber == 1)
		return false;
	
	var items = line.split(";");	
	
	var t1 = parseFloat(items[0])
	var t2 = parseFloat(items[1])
	if(t1 == 0.0 || t2 == 0.0)
		return false;
	
	// Convert "2014/10/20 13h:54m:27s" To "2014-10-20T13:54:27"
	var s = items[2].trim();
	s = s.replace(/\//g, "-");
	s = s.replace(" ", "T");
	s = s.replace("h", "");
	s = s.replace("m", "");
	date = s.replace("s", "");		
	latitude = items[0].trim();
	longitude = items[1].trim();
	altitude = 0;
	value = items[5].trim();
	unit = "Sv/h";
	
	return true;
}
