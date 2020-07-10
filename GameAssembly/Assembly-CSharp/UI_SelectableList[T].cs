/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class UI_SelectableList<T> : MonoBehaviour // TypeDefIndex: 12190
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWSmoothLayout _layout;
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _allowMultiSelect;
	public Action<T> OnItemSelected;
	public Action<List<T>> OnMultiSelectedItemsChanged;
	public Action<bool> OnMultiSelectModeChanged;
	protected List<UI_SelectableListItem<T>> _listItems;
	private UI_SelectableListItem<T> _currentlySelectedItem;
	private List<UI_SelectableListItem<T>> _multiSelectedItems;
	private bool _multiSelectMode;

	// Properties
	protected abstract UI_SelectableListItem<T> ListItemPrefab { get; }
	public bool MultiSelectMode { get; set; }

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 12191
	{
		// Fields
		public T inItemData;

		// Constructors
		public <>c__DisplayClass14_0();

		// Methods
		internal bool <AddItem>b__0(UI_SelectableListItem<T> inItem);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 12192
	{
		// Fields
		public T inItemData;

		// Constructors
		public <>c__DisplayClass18_0();

		// Methods
		internal bool <RemoveItem>b__0(UI_SelectableListItem<T> inItem);
	}

	// Constructors
	protected UI_SelectableList();

	// Methods
	public void AddItem(T inItemData, int inDesiredIndex = -1 /* Metadata: 0x00782DFC */);
	public T RemoveSelected();
	public List<T> RemoveMultiSelected();
	public List<T> RemoveAll();
	public T RemoveItem(T inItemData);
	public T RemoveItem(UI_SelectableListItem<T> inItem);
	public void CancelMultiSelect();
	private void ItemClicked(UI_SelectableListItem<T> inItem);
	private void ItemLongPressed(UI_SelectableListItem<T> inItem);
}

