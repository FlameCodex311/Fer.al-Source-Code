/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItemDetailPanel_ClothingInfo : UI_LazyListItemDetailPanel<ColorableItemComponent> // TypeDefIndex: 12084
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Graphic> _searchModeOffGraphics; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _equipAudioInfo; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _removeAudioInfo; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _arrow; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _equipBtn; // 0x68
	private bool _clothingIsEquipped; // 0x70
	[Header] // 0x00000001800DF1C0-0x00000001800DF210
	[SerializeField] // 0x00000001800DF1C0-0x00000001800DF210
	private UI_Control_HSVSliders _clothingColorSliders; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _clothingColorTabGroup; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic _clothingColor1Icon; // 0x88
	private HSVColor _clothingColor1; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic _clothingColor2Icon; // 0xC8
	private HSVColor _clothingColor2; // 0xD0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic _clothingColor3Icon; // 0x108
	private HSVColor _clothingColor3; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic _clothingColor4Icon; // 0x148
	private HSVColor _clothingColor4; // 0x150
	private ActorInfoClothingItem _equippedClothingItem; // 0x188

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180E61E80-0x0000000180E61ED0 
	private HSVColor ClothingColor1 { get; set; } // 0x0000000180E61ED0-0x0000000180E61F10 0x0000000180E61FD0-0x0000000180E62190
	private HSVColor ClothingColor2 { get; set; } // 0x0000000180E61F10-0x0000000180E61F50 0x0000000180E62190-0x0000000180E62350
	private HSVColor ClothingColor3 { get; set; } // 0x0000000180E61F50-0x0000000180E61F90 0x0000000180E62350-0x0000000180E62520
	private HSVColor ClothingColor4 { get; set; } // 0x0000000180E61F90-0x0000000180E61FD0 0x0000000180E62520-0x0000000180E626F0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass35_0 // TypeDefIndex: 12085
	{
		// Fields
		public UI_LazyListItem<ColorableItemComponent> inDataSrc; // 0x10

		// Constructors
		public <>c__DisplayClass35_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__0(ActorInfoClothingItem item); // 0x0000000180E5AA10-0x0000000180E5AAA0
	}

	// Constructors
	public UI_LazyListItemDetailPanel_ClothingInfo(); // 0x0000000180E61C50-0x0000000180E61E80

	// Methods
	protected override void OnEnable(); // 0x0000000180E60FF0-0x0000000180E61170
	protected override void OnDisable(); // 0x0000000180E60E70-0x0000000180E60FF0
	public override void Setup(UI_LazyListItem<ColorableItemComponent> inDataSrc); // 0x0000000180E61550-0x0000000180E61B50
	public void BtnClicked_Equip(); // 0x0000000180E60BE0-0x0000000180E60D90
	private void RefreshEquipped(); // 0x0000000180E61520-0x0000000180E61550
	private void OnTabSelected_ClothingColor(int inSelectedTab); // 0x0000000180E61170-0x0000000180E61520
	private void OnClothingEquipped(ActorInfoClothingItem inClothingItem, bool inIsEquipped); // 0x0000000180E60D90-0x0000000180E60E70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTabSelected_ClothingColor>b__38_0(HSVColor inColor); // 0x0000000180E61B50-0x0000000180E61B90
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTabSelected_ClothingColor>b__38_1(HSVColor inColor); // 0x0000000180E61B90-0x0000000180E61BD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTabSelected_ClothingColor>b__38_2(HSVColor inColor); // 0x0000000180E61BD0-0x0000000180E61C10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTabSelected_ClothingColor>b__38_3(HSVColor inColor); // 0x0000000180E61C10-0x0000000180E61C50
}

