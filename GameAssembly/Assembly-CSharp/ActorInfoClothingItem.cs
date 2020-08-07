/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ActorInfoClothingItem // TypeDefIndex: 12405
{
	// Fields
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string itemInvID; // 0x10
	[ChartDef] // 0x000000018028EAF0-0x000000018028EB90
	public string clothingItemDefID; // 0x18
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool attached; // 0x20
	[ChartHSV] // 0x000000018028EE90-0x000000018028EEC0
	[SerializeField] // 0x000000018028EE90-0x000000018028EEC0
	private HSVColor _clothingColor1HSV; // 0x28
	[ChartHSV] // 0x000000018028EE90-0x000000018028EEC0
	[SerializeField] // 0x000000018028EE90-0x000000018028EEC0
	private HSVColor _clothingColor2HSV; // 0x60
	[ChartHSV] // 0x000000018028EE90-0x000000018028EEC0
	[SerializeField] // 0x000000018028EE90-0x000000018028EEC0
	private HSVColor _clothingColor3HSV; // 0x98
	[ChartHSV] // 0x000000018028EE90-0x000000018028EEC0
	[SerializeField] // 0x000000018028EE90-0x000000018028EEC0
	private HSVColor _clothingColor4HSV; // 0xD0
	[NonSerialized]
	private ActorClothingDefComponent _clothingDefComponent; // 0x108

	// Properties
	public HSVColor ClothingColor1HSV { get; set; } // 0x00000001821D87F0-0x00000001821D8820 0x00000001821D8930-0x00000001821D89D0
	public HSVColor ClothingColor2HSV { get; set; } // 0x00000001821D8820-0x00000001821D8850 0x00000001821D89D0-0x00000001821D8A80
	public HSVColor ClothingColor3HSV { get; set; } // 0x00000001821D8850-0x00000001821D8890 0x00000001821D8A80-0x00000001821D8B40
	public HSVColor ClothingColor4HSV { get; set; } // 0x0000000180393A90-0x0000000180393AD0 0x00000001821D8B40-0x00000001821D8C00
	public ActorClothingDefComponent ClothingDefComponent { get; } // 0x00000001821D8890-0x00000001821D8930 

	// Constructors
	public ActorInfoClothingItem(); // 0x00000001821D8610-0x00000001821D87F0
	public ActorInfoClothingItem(ColorableItemComponent inItem); // 0x00000001821D8320-0x00000001821D8610

	// Methods
	public void ResetCaches(); // 0x000000018156CBB0-0x000000018156CBC0
}

