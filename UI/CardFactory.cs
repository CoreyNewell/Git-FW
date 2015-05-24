using UnityEngine;
using System;
using System.Collections;

public class CardFactory
{
	private List<string> cardData;

	public CardFactory(string cardName){
		CardFileReader f = new CardFileReader(cardName);
		cardData = f.cardData();
	}

	public static Card Get(List<string> cardData)
	{
		switch (cardData[2])
		{
		case "enhacement":
			return new EnhancementCard(cardData);
		case "lightweapon":
		case "mediumweapon":
		case "heavytweapon":
		case "artillery":
			return new WeaponCard(cardData);
		case "resource":
			return new ResourceCard(cardData);
		case "ammo":
		case "armor":
			return new DepletableCard(cardData);
		case "structure":
		case "tower":
			return new StructureCard(cardData);
		case "hq":
			return new HQCard(cardData);
		case "solo":
		case "air":
			return new MobileCard(cardData);
		case "squad":
			return new SquadCard(cardData);
		default:
			return null; //Card not found error
		}
	}

}

