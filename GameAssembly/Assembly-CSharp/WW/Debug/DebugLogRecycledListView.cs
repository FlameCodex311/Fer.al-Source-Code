/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugLogRecycledListView : MonoBehaviour // TypeDefIndex: 15717
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RectTransform transformComponent; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RectTransform viewportTransform; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugLogPanel _logPanel; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color logItemNormalColor1; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color logItemNormalColor2; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color logItemSelectedColor; // 0x58
		private DebugPanel panel; // 0x68
		private float logItemHeight; // 0x70
		private float _1OverLogItemHeight; // 0x74
		private float viewportHeight; // 0x78
		private List<DebugLogEntry> collapsedLogEntries; // 0x80
		private DebugLogIndexList indicesOfEntriesToShow; // 0x88
		private int indexOfSelectedLogEntry; // 0x90
		private float positionOfSelectedLogEntry; // 0x94
		private float heightOfSelectedLogEntry; // 0x98
		private float deltaHeightOfSelectedLogEntry; // 0x9C
		private Dictionary<int, DebugLogItem> logItemsAtIndices; // 0xA0
		private bool isCollapseOn; // 0xA8
		private int currentTopIndex; // 0xAC
		private int currentBottomIndex; // 0xB0
	
		// Properties
		public float ItemHeight { get; } // 0x0000000181128C90-0x0000000181128CA0 
		public float SelectedItemHeight { get; } // 0x0000000181128CA0-0x0000000181128CB0 
	
		// Constructors
		public DebugLogRecycledListView(); // 0x0000000181128BD0-0x0000000181128C90
	
		// Methods
		private void Awake(); // 0x0000000181127A70-0x0000000181127AC0
		public void Initialize(DebugPanel panel, List<DebugLogEntry> collapsedLogEntries, DebugLogIndexList indicesOfEntriesToShow, float logItemHeight); // 0x0000000181128450-0x0000000181128480
		public void SetCollapseMode(bool collapse); // 0x0000000180371FA0-0x0000000180371FB0
		public void OnLogItemClicked(DebugLogItem item); // 0x00000001811285A0-0x0000000181128760
		public void DeselectSelectedLogItem(); // 0x00000001811281C0-0x00000001811282F0
		public void OnLogEntriesUpdated(bool updateAllVisibleItemContents); // 0x0000000181128500-0x00000001811285A0
		public void OnCollapsedLogEntryAtIndexUpdated(int index); // 0x0000000181128480-0x0000000181128500
		public void OnViewportDimensionsChanged(); // 0x0000000181128760-0x00000001811287C0
		private void HardResetItems(); // 0x0000000181128410-0x0000000181128450
		private void CalculateContentHeight(); // 0x0000000181127AC0-0x0000000181127BB0
		public void UpdateItemsInTheList(bool updateAllVisibleItemContents); // 0x00000001811287C0-0x0000000181128A50
		private void CreateLogItemsBetweenIndices(int topIndex, int bottomIndex); // 0x0000000181127EE0-0x00000001811281C0
		private void CreateLogItemAtIndex(int index); // 0x0000000181127C60-0x0000000181127EE0
		private void DestroyLogItemsBetweenIndices(int topIndex, int bottomIndex); // 0x00000001811282F0-0x0000000181128410
		private void UpdateLogItemContentsBetweenIndices(int topIndex, int bottomIndex); // 0x0000000181128A50-0x0000000181128BD0
		private void ColorLogItem(DebugLogItem logItem, int index); // 0x0000000181127BB0-0x0000000181127C60
	}
}
