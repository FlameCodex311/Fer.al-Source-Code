/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ActorInfoClothingItem // TypeDefIndex: 10882
{
	// Fields
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string itemInvID; // 0x10
	[ChartDef] // 0x00000001800ED120-0x00000001800ED1C0
	public string clothingItemDefID; // 0x18
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool attached; // 0x20
	[ChartHSV] // 0x00000001800ED580-0x00000001800ED5B0
	[SerializeField] // 0x00000001800ED580-0x00000001800ED5B0
	private HSVColor _clothingColor1HSV; // 0x28
	[ChartHSV] // 0x00000001800ED580-0x00000001800ED5B0
	[SerializeField] // 0x00000001800ED580-0x00000001800ED5B0
	private HSVColor _clothingColor2HSV; // 0x60
	[ChartHSV] // 0x00000001800ED580-0x00000001800ED5B0
	[SerializeField] // 0x00000001800ED580-0x00000001800ED5B0
	private HSVColor _clothingColor3HSV; // 0x98
	[ChartHSV] // 0x00000001800ED580-0x00000001800ED5B0
	[SerializeField] // 0x00000001800ED580-0x00000001800ED5B0
	private HSVColor _clothingColor4HSV; // 0xD0
	[NonSerialized]
	private ActorClothingDefComponent _clothingDefComponent; // 0x108

	// Properties
	public HSVColor ClothingColor1HSV { get; set; } // 0x0000000181406AE0-0x0000000181406B10 0x0000000181406C20-0x0000000181406CC0
	public HSVColor ClothingColor2HSV { get; set; } // 0x0000000181406B10-0x0000000181406B40 0x0000000181406CC0-0x0000000181406D70
	public HSVColor ClothingColor3HSV { get; set; } // 0x0000000181406B40-0x0000000181406B80 0x0000000181406D70-0x0000000181406E30
	public HSVColor ClothingColor4HSV { get; set; } // 0x0000000180E61F10-0x0000000180E61F50 0x0000000181406E30-0x0000000181406EF0
	public ActorClothingDefComponent ClothingDefComponent { get; } // 0x0000000181406B80-0x0000000181406C20 

	// Constructors
	public ActorInfoClothingItem(); // 0x0000000181406900-0x0000000181406AE0
	public ActorInfoClothingItem(ColorableItemComponent inItem); // 0x0000000181406610-0x0000000181406900

	// Methods
	public void ResetCaches(); // 0x0000000181406600-0x0000000181406610
}

