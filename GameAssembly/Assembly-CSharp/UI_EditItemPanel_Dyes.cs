/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_EditItemPanel_Dyes : MonoBehaviour // TypeDefIndex: 13888
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _colorChannelTabGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _notColorableChannelGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_ColorChannelTab> _colorChannelTabs; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_EditItemDye _itemList; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _colorableGroup; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _notColorableGroup; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _applyBtn; // 0x50
	private List<DyeAssignment> _dyeAssignments; // 0x58
	private DyeAssignment _selectedColorChannelTab; // 0x60
	private Item _selectedDyeItem; // 0x68
	private ColorDefComponent _selectedDye; // 0x70
	private Item _item; // 0x78
	private ColorableItemComponent _colorableItemComponent; // 0x80
	private bool _dyeHasBeenApplied; // 0x88

	// Properties
	public Item SelectedDyeItem { get; } // 0x00000001803765E0-0x00000001803765F0 
	private List<Renderer> _spawnedItemRenderers { get; } // 0x00000001803765F0-0x0000000180376640 

	// Nested types
	private class DyeAssignment // TypeDefIndex: 13889
	{
		// Fields
		public UI_ColorChannelTab channelTab; // 0x10
		public Item dye; // 0x18

		// Constructors
		public DyeAssignment(UI_ColorChannelTab channelTab, Item dye); // 0x0000000180372010-0x00000001803720F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 13890
	{
		// Fields
		[TupleElementNames] // 0x000000018022BAB0-0x000000018022BB30
		public List<ValueTuple<Item, int>> operations; // 0x10
		public UI_EditItemPanel_Dyes <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BtnClicked_Apply>b__0(bool inResult); // 0x0000000180373530-0x0000000180373820
	}

	// Constructors
	public UI_EditItemPanel_Dyes(); // 0x0000000180376560-0x00000001803765E0

	// Methods
	public bool IsColoringAllowed(); // 0x00000001803756C0-0x00000001803757B0
	public bool SelectedDyeIsPreviewed(); // 0x0000000180376230-0x0000000180376260
	public int GetAvailableDyeCount(Item inDye); // 0x00000001803751C0-0x00000001803753A0
	public void BtnClicked_Apply(); // 0x0000000180374D40-0x0000000180374F60
	public void BtnClicked_ClearColorChannel(int inChannelIndex); // 0x0000000180374F60-0x0000000180375060
	public void BtnClicked_UndyeColorChannel(int inChannelIndex); // 0x0000000180375060-0x00000001803751C0
	private void Start(); // 0x0000000180376260-0x0000000180376560
	private void OnDestroy(); // 0x00000001803758F0-0x00000001803759D0
	private void InitializeColorChannelTabs(); // 0x00000001803753A0-0x00000001803756C0
	private void OnChannelSelected(int inSelectedChannel); // 0x00000001803757B0-0x00000001803758F0
	private void OnDyeSelected(Item inSelectedDye); // 0x00000001803759D0-0x0000000180375A50
	private void PreviewSelectedDye(bool inPreview); // 0x0000000180375BD0-0x0000000180375D30
	private void ResetItemPreview(); // 0x00000001803760B0-0x0000000180376230
	private void RefreshItemPreview(); // 0x0000000180375D30-0x00000001803760B0
	private void OnEditItemWindowClosed(WindowClosedMessage inMessage); // 0x0000000180375A50-0x0000000180375BD0
}

