// Default script for data formatting
var comm_handler = new Array(0);
//Outputs various code quality values
function onResult (decodeResults, readerProperties, output)
{
	
	// single code read?
	if(decodeResults[0].decoded && decodeResults.length == 1)
	{
		if( decodeResults[0].symbology.name == "Data Matrix" || decodeResults[0].symbology.name == "Direct Mark QR")
		{
			// 2-D code?
			output.content = decodeResults[0].content +
				" SC: " + decodeResults[0].metrics.symbolContrast.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.symbolContrast.grade + ")" +
				" ANU: " + decodeResults[0].metrics.axialNonUniformity.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.axialNonUniformity.grade + ")" +
				" PG: " + decodeResults[0].metrics.printGrowth.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.printGrowth.grade + ")" +
				" UEC: " + decodeResults[0].metrics.UEC.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.UEC.grade + ")" +
				" MOD: " + decodeResults[0].metrics.modulation.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.modulation.grade + ")" +
				" FPD: " + decodeResults[0].metrics.fixedPatternDamage.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.fixedPatternDamage.grade + ")" +
				" MR: " + decodeResults[0].metrics.reflectMin.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.reflectMin.grade + ")" +
				" GNU: " + decodeResults[0].metrics.gridNonUniformity.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.gridNonUniformity.grade + ")";
			if(decodeResults[0].metrics.symbolContrast.grade == "A" ||
				decodeResults[0].metrics.symbolContrast.grade == "B" ||
				decodeResults[0].metrics.symbolContrast.grade == "C")
			{output.events.user1 = true;output.events.user2 = false;}
			else
			{output.events.user1 = false;output.events.user2 = true;}
		}
		else
		{
			// 1-D code?
			output.content = decodeResults[0].content +
				"SC: " + decodeResults[0].metrics.symbolContrast.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.symbolContrast.grade + ")" +
				" PG: " + decodeResults[0].metrics.printGrowth.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.printGrowth.grade + ")" +
				" SSI: " + decodeResults[0].metrics.singleScanInt.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.singleScanInt.grade + ")" +
				" MSI: " + decodeResults[0].metrics.multiScanInt.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.multiScanInt.grade + ")" +
				" MR: " + decodeResults[0].metrics.reflectMin.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.reflectMin.grade + ")" +
				" MEC: " + decodeResults[0].metrics.edgeContrastMin.raw.toFixed(2) +
				"(" + decodeResults[0].metrics.edgeContrastMin.grade + ")";
			if(decodeResults[0].metrics.symbolContrast.grade == "A" ||
				decodeResults[0].metrics.symbolContrast.grade == "B" ||
				decodeResults[0].metrics.symbolContrast.grade == "C")
			{output.events.user1 = true;output.events.user2 = false;}
			else
			{output.events.user1 = false;output.events.user2 = true;}
		}
		for(var i = 0;i < comm_handler.length;i++){comm_handler[i].resetHeartBeat();}
	}
	else
	{output.content = "error";output.events.user1 = false;output.events.user2 = true;}
	
}
