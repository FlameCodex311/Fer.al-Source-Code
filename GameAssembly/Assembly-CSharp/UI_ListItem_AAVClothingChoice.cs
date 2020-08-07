/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ListItem_AAVClothingChoice : MonoBehaviour // TypeDefIndex: 13461
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _clothingNameText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _clothingItemImage; // 0x28
	private ActorClothingDefComponent _def; // 0x30

	// Properties
	public string AttachNode { get; } // 0x00000001803C8970-0x00000001803C8990 
	public ActorClothingDefComponent ClothingDef { get; } // 0x00000001803745C0-0x00000001803745D0 

	// Constructors
	public UI_ListItem_AAVClothingChoice(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(ActorClothingDefComponent inDef); // 0x00000001803C87D0-0x00000001803C8970
	public void BtnClicked_Remove(); // 0x00000001803C86F0-0x00000001803C8760
	public void BtnClicked_ReplaceItem(); // 0x00000001803C8760-0x00000001803C87D0
	public void BtnClicked_Prev(); // 0x00000001803C8680-0x00000001803C86F0
	public void BtnClicked_Next(); // 0x00000001803C8610-0x00000001803C8680
}

