// To the extent possible under law, Dag Robøle has waived all copyright and related or neighboring rights to this work.

function parseLine(lineNumber, line)
{
	if(lineNumber == 1)
		return false;
	
	var items = line.split(",");
	
	if(items[2] == 'NoData' || items[3] == 'NoData')
		return false
		
	s = items[0].trim();
	date = s.substring(0, s.length - 5);
	latitude = items[2].trim().substring(1);
	longitude = items[3].trim().substring(1);
	altitude = 0;
	value = items[1].trim();
	unit = "CPS";
	
	return true;
}
