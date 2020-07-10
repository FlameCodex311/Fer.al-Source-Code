/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_EditItemPanel_Dyes : MonoBehaviour // TypeDefIndex: 12304
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _colorChannelTabGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _notColorableChannelGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_ColorChannelTab> _colorChannelTabs; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_EditItemDye _itemList; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _colorableGroup; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _notColorableGroup; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _applyBtn; // 0x50
	private List<DyeAssignment> _dyeAssignments; // 0x58
	private DyeAssignment _selectedColorChannelTab; // 0x60
	private Item _selectedDyeItem; // 0x68
	private ColorDefComponent _selectedDye; // 0x70
	private Item _item; // 0x78
	private ColorableItemComponent _colorableItemComponent; // 0x80
	private bool _dyeHasBeenApplied; // 0x88

	// Properties
	public Item SelectedDyeItem { get; } // 0x0000000180358970-0x0000000180358980 
	private List<Renderer> _spawnedItemRenderers { get; } // 0x0000000180F354E0-0x0000000180F35530 

	// Nested types
	private class DyeAssignment // TypeDefIndex: 12305
	{
		// Fields
		public UI_ColorChannelTab channelTab; // 0x10
		public Item dye; // 0x18

		// Constructors
		public DyeAssignment(UI_ColorChannelTab channelTab, Item dye); // 0x00000001803DA900-0x00000001803DA940
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 12306
	{
		// Fields
		[TupleElementNames] // 0x0000000180131C50-0x0000000180131CD0
		public List<ValueTuple<Item, int>> operations; // 0x10
		public UI_EditItemPanel_Dyes <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass21_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BtnClicked_Apply>b__0(bool inResult); // 0x0000000180E3E380-0x0000000180E3E680
	}

	// Constructors
	public UI_EditItemPanel_Dyes(); // 0x0000000180F35460-0x0000000180F354E0

	// Methods
	public bool IsColoringAllowed(); // 0x0000000180F34590-0x0000000180F34690
	public bool SelectedDyeIsPreviewed(); // 0x0000000180F35130-0x0000000180F35160
	public int GetAvailableDyeCount(Item inDye); // 0x0000000180F33E60-0x0000000180F34050
	public void BtnClicked_Apply(); // 0x0000000180F339C0-0x0000000180F33BF0
	public void BtnClicked_ClearColorChannel(int inChannelIndex); // 0x0000000180F33BF0-0x0000000180F33CF0
	public void BtnClicked_UndyeColorChannel(int inChannelIndex); // 0x0000000180F33CF0-0x0000000180F33E60
	private void Start(); // 0x0000000180F35160-0x0000000180F35460
	private void OnDestroy(); // 0x0000000180F347D0-0x0000000180F348B0
	private void InitializeColorChannelTabs(); // 0x0000000180F34050-0x0000000180F34590
	private void OnChannelSelected(int inSelectedChannel); // 0x0000000180F34690-0x0000000180F347D0
	private void OnDyeSelected(Item inSelectedDye); // 0x0000000180F348B0-0x0000000180F34930
	private void PreviewSelectedDye(bool inPreview); // 0x0000000180F34AC0-0x0000000180F34C20
	private void ResetItemPreview(); // 0x0000000180F34FB0-0x0000000180F35130
	private void RefreshItemPreview(); // 0x0000000180F34C20-0x0000000180F34FB0
	private void OnEditItemWindowClosed(WindowClosedMessage inMessage); // 0x0000000180F34930-0x0000000180F34AC0
}

