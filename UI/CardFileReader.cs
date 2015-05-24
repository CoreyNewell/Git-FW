//using UnityEngine;
using System.Collections;

public class CardFileReader
{
	private List<string> readData = new List<string>();

	CardFileReader(string cardName){
		//Todo make file reader

		readData.Add("1");
		readData.Add("Hover Tank");
		readData.Add("solo");
	}
	
	public List<string> cardData() {
		return readData;
	}
}

