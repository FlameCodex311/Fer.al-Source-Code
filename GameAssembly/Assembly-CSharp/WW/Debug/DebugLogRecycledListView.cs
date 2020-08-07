/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugLogRecycledListView : MonoBehaviour // TypeDefIndex: 16269
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RectTransform transformComponent; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RectTransform viewportTransform; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugLogPanel _logPanel; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color logItemNormalColor1; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color logItemNormalColor2; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public float ItemHeight { get; } // 0x000000018096DED0-0x000000018096DEE0 
		public float SelectedItemHeight { get; } // 0x000000018096DEE0-0x000000018096DEF0 
	
		// Constructors
		public DebugLogRecycledListView(); // 0x000000018096DE10-0x000000018096DED0
	
		// Methods
		private void Awake(); // 0x000000018096CCE0-0x000000018096CD30
		public void Initialize(DebugPanel panel, List<DebugLogEntry> collapsedLogEntries, DebugLogIndexList indicesOfEntriesToShow, float logItemHeight); // 0x000000018096D6A0-0x000000018096D6D0
		public void SetCollapseMode(bool collapse); // 0x0000000180421050-0x0000000180421060
		public void OnLogItemClicked(DebugLogItem item); // 0x000000018096D7F0-0x000000018096D9B0
		public void DeselectSelectedLogItem(); // 0x000000018096D410-0x000000018096D540
		public void OnLogEntriesUpdated(bool updateAllVisibleItemContents); // 0x000000018096D750-0x000000018096D7F0
		public void OnCollapsedLogEntryAtIndexUpdated(int index); // 0x000000018096D6D0-0x000000018096D750
		public void OnViewportDimensionsChanged(); // 0x000000018096D9B0-0x000000018096DA10
		private void HardResetItems(); // 0x000000018096D660-0x000000018096D6A0
		private void CalculateContentHeight(); // 0x000000018096CD30-0x000000018096CE10
		public void UpdateItemsInTheList(bool updateAllVisibleItemContents); // 0x000000018096DA10-0x000000018096DCA0
		private void CreateLogItemsBetweenIndices(int topIndex, int bottomIndex); // 0x000000018096D140-0x000000018096D410
		private void CreateLogItemAtIndex(int index); // 0x000000018096CEC0-0x000000018096D140
		private void DestroyLogItemsBetweenIndices(int topIndex, int bottomIndex); // 0x000000018096D540-0x000000018096D660
		private void UpdateLogItemContentsBetweenIndices(int topIndex, int bottomIndex); // 0x000000018096DCA0-0x000000018096DE10
		private void ColorLogItem(DebugLogItem logItem, int index); // 0x000000018096CE10-0x000000018096CEC0
	}
}
