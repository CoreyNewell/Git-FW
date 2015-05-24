using UnityEngine;
using System;
using System.Collections;

//Todo Add file reader
public abstract class CardData
{
	int id = -1;
	string name = "";
	int rarity = -1;
	string model = "";
	int tier = -1;
	enum category {HQ, STRUCTURE, TOWER, RESOURCE, SOLO, SQUAD, AIR, ARMOR, LIGHTWEAPON, MEDIUMWEAPON,
		HEAVYWEAPON, ARTILLERY, AMMO, UPGRADE, UTILITY};
	float manpowerCost = -1;
	float energyCost = -1;
	float materialsCost = -1;
	List<string> abilities = new List<string>(); //List<action>?

	CardData(){

	}

}

public abstract class Buildable : CardData
{
	enum domain {LIVING, MECHANICAL, UNDEAD, MYSTICAL, PHAZED};
	float buildSpeed = -1;
	float sightRange = -1;
	float health = -1;
	int armorClass = -1;
	float armorHealth = -1;
	
	Buildable(){
		
	}
	
}

public class Structure : Buildable
{
	Vector3 orientation = null;

	public Structure(){

	}
}

public class Mobile : Buildable
{
	float evasion = -1;
	List<string> criticalEvents = new List<string>(); //List<action>?

	public Mobile(){

	}
}

public class HQ : Structure
{
	float manpowerSupplied = -1;
	float energySupplied = -1;
	float materialsSupplied = -1;
	float tierSpeed = -1;

	public HQ(){

	}
}

public class Squad : Mobile
{
	int memberCount = -1;

	public Squad(){

	}
}

public class Enhancement : CardData
{
	public Enhancement(){
		
	}
}

public class Depletable : Enhancement
{
	int uses = -1:
	public Depletable(){
		
	}
}

public class Resource : Enhancement
{
	float manpowerSupplied = -1;
	float energySupplied = -1;
	float materialsSupplied = -1;

	public Resource(){
		
	}
}

public class Weapon : Enhancement
{
	enum weaponClass {LIGHT, MEDIUM, HEAVY, ARTILLERY};

	public Weapon(){
		
	}
}