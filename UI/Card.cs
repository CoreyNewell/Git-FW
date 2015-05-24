using UnityEngine;
using System;
using System.Collections;

public abstract class Card
{
	private int id = -1;
	private string name = "";
	private int rarity = -1;
	private string model = "";
	private int tier = -1;
	enum category {HQ, STRUCTURE, TOWER, RESOURCE, SOLO, SQUAD, AIR, ARMOR, LIGHTWEAPON, MEDIUMWEAPON,
		HEAVYWEAPON, ARTILLERY, AMMO, UPGRADE, UTILITY};
	private float manpowerCost = -1;
	private float energyCost = -1;
	private float materialsCost = -1;
	List<string> abilities = new List<string>(); //List<action>?

	public int Id { get;set; }
	public string Name { get;set; }
	public int Rarity { get;set; }
	public string Model { get;set; }
	public int Tier { get;set; }
	public float ManpowerCost { get;set; }
	public float EnergyCost { get;set; }

	Card(){
		
	}
}

public abstract class BuildableCard : Card
{
	enum domain {LIVING, MECHANICAL, UNDEAD, MYSTICAL, PHAZED};
	private float buildSpeed = -1;
	private float sightRange = -1;
	private float health = -1;
	private int armorClass = -1;
	private float armorHealth = -1;
	List<Vector3> hardpoints = new List<Vector3>();

	public float BuildSpeed { get;set; }
	public float SightRange { get;set; }
	public float Health { get;set; }
	public int ArmorClass { get;set; }
	public float ArmorHealth { get;set; }
	
	BuildableCard(){
		
	}
	
}

public class StructureCard : BuildableCard
{
	private Vector3 orientation = null;
	public Vector3 Orientation { get;set; }

	public StructureCard(){
		
	}
}

public class MobileCard : BuildableCard
{
	private float evasion = -1;
	List<string> criticalEvents = new List<string>(); //List<action>?

	public float Evasion { get;set; }

	public MobileCard(){
		
	}
}

public class HQCard : StructureCard
{
	private float manpowerSupplied = -1;
	private float energySupplied = -1;
	private float materialsSupplied = -1;
	private float tierSpeed = -1;

	public float ManpowerSupplied { get;set; }
	public float EnergySupplied { get;set; }
	public float MaterialsSupplied { get;set; }
	public float TierSpeed { get;set; }

	public HQCard(){
		
	}
}

public class SquadCard : MobileCard
{
	private int memberCount = -1;

	public int MemberCount { get;set; }

	public SquadCard(){
		
	}
}

public class EnhancementCard : Card
{
	public EnhancementCard(){
		
	}
}

public class DepletableCard : EnhancementCard
{
	private int uses = -1;

	public int Uses { get;set; }

	public DepletableCard(){
		
	}
}

public class ResourceCard : EnhancementCard
{
	private float manpowerSupplied = -1;
	private float energySupplied = -1;
	private float materialsSupplied = -1;

	public float ManpowerSupplied { get; set; }
	public float EnergySupplied { get;set; }
	public float MaterialsSupplied { get;set; }

	public ResourceCard(){
		
	}
}

public class WeaponCard : EnhancementCard
{
	private Vector3 connector = null;
	private float accuracy = -1;
	private float baseDamage = -1;
	private float falloff = -1:
	enum attackType{DIRECT, BALLISTIC, BOUNCE, GUIDED, CHAIN, DROPPED};

	public Vector3 Connector { get;set; }
	public float Accuracy { get;set; }
	public float BaseDamage { get;set; }
	public float Falloff { get;set; }

	public WeaponCard(){
		
	}
}