// To the extent possible under law, Dag Robøle has waived all copyright and related or neighboring rights to this work.

function parseLine(lineNumber, line)
{
	if(lineNumber == 1)
		return false;
	
	var items = line.split("|");
		
	s = items[3].trim();
	date = s.substring(0, s.length - 5);
	latitude = items[4].trim();
	longitude = items[5].trim();
	altitude = items[6].trim();
	value = items[9].trim();		
	unit = items[10].trim();
	
	return true;
}
