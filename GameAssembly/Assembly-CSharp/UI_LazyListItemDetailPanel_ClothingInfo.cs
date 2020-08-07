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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItemDetailPanel_ClothingInfo : UI_LazyListItemDetailPanel<ColorableItemComponent> // TypeDefIndex: 13626
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Graphic> _searchModeOffGraphics; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _equipAudioInfo; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _removeAudioInfo; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _arrow; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _equipBtn; // 0x68
	private bool _clothingIsEquipped; // 0x70
	[Header] // 0x00000001801E2B10-0x00000001801E2B60
	[SerializeField] // 0x00000001801E2B10-0x00000001801E2B60
	private UI_Control_HSVSliders _clothingColorSliders; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _clothingColorTabGroup; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic _clothingColor1Icon; // 0x88
	private HSVColor _clothingColor1; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic _clothingColor2Icon; // 0xC8
	private HSVColor _clothingColor2; // 0xD0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic _clothingColor3Icon; // 0x108
	private HSVColor _clothingColor3; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic _clothingColor4Icon; // 0x148
	private HSVColor _clothingColor4; // 0x150
	private ActorInfoClothingItem _equippedClothingItem; // 0x188

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180393A00-0x0000000180393A50 
	private HSVColor ClothingColor1 { get; set; } // 0x0000000180393A50-0x0000000180393A90 0x0000000180393B50-0x0000000180393D00
	private HSVColor ClothingColor2 { get; set; } // 0x0000000180393A90-0x0000000180393AD0 0x0000000180393D00-0x0000000180393EB0
	private HSVColor ClothingColor3 { get; set; } // 0x0000000180393AD0-0x0000000180393B10 0x0000000180393EB0-0x0000000180394070
	private HSVColor ClothingColor4 { get; set; } // 0x0000000180393B10-0x0000000180393B50 0x0000000180394070-0x0000000180394230

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass35_0 // TypeDefIndex: 13627
	{
		// Fields
		public UI_LazyListItem<ColorableItemComponent> inDataSrc; // 0x10

		// Constructors
		public <>c__DisplayClass35_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__0(ActorInfoClothingItem item); // 0x0000000180387E10-0x0000000180387E90
	}

	// Constructors
	public UI_LazyListItemDetailPanel_ClothingInfo(); // 0x00000001803937D0-0x0000000180393A00

	// Methods
	protected override void OnEnable(); // 0x0000000180392BC0-0x0000000180392D30
	protected override void OnDisable(); // 0x0000000180392A50-0x0000000180392BC0
	public override void Setup(UI_LazyListItem<ColorableItemComponent> inDataSrc); // 0x0000000180393100-0x00000001803936D0
	public void BtnClicked_Equip(); // 0x00000001803927E0-0x0000000180392980
	private void RefreshEquipped(); // 0x00000001803930D0-0x0000000180393100
	private void OnTabSelected_ClothingColor(int inSelectedTab); // 0x0000000180392D30-0x00000001803930D0
	private void OnClothingEquipped(ActorInfoClothingItem inClothingItem, bool inIsEquipped); // 0x0000000180392980-0x0000000180392A50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTabSelected_ClothingColor>b__38_0(HSVColor inColor); // 0x00000001803936D0-0x0000000180393710
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTabSelected_ClothingColor>b__38_1(HSVColor inColor); // 0x0000000180393710-0x0000000180393750
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTabSelected_ClothingColor>b__38_2(HSVColor inColor); // 0x0000000180393750-0x0000000180393790
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTabSelected_ClothingColor>b__38_3(HSVColor inColor); // 0x0000000180393790-0x00000001803937D0
}

