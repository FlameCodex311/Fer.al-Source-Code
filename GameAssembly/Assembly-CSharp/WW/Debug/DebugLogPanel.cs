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

namespace WW.Debug
{
	public class DebugLogPanel : DebugPanel // TypeDefIndex: 15714
	{
		// Fields
		[Header] // 0x0000000180161BC0-0x0000000180161C10
		[SerializeField] // 0x0000000180161BC0-0x0000000180161C10
		private DebugLogItem logItemPrefab; // 0x50
		[Header] // 0x000000018015EB00-0x000000018015EB50
		[SerializeField] // 0x000000018015EB00-0x000000018015EB50
		private RectTransform logItemsContainer; // 0x58
		[Header] // 0x0000000180161F00-0x0000000180161F50
		[SerializeField] // 0x0000000180161F00-0x0000000180161F50
		private bool receiveLogcatLogsInAndroid; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string logcatArguments; // 0x68
		private bool screenDimensionsChanged; // 0x70
		[Header] // 0x0000000180161BC0-0x0000000180161C10
		[SerializeField] // 0x0000000180161BC0-0x0000000180161C10
		private Sprite infoLog; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Sprite warningLog; // 0x80
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Sprite errorLog; // 0x88
		private Dictionary<LogType, Sprite> logSpriteRepresentations; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color collapseButtonNormalColor; // 0x98
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color collapseButtonSelectedColor; // 0xA8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color filterButtonsNormalColor; // 0xB8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color filterButtonsSelectedColor; // 0xC8
		[Header] // 0x000000018015EB00-0x000000018015EB50
		[SerializeField] // 0x000000018015EB00-0x000000018015EB50
		private Image collapseButton; // 0xD8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image filterInfoButton; // 0xE0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image filterWarningButton; // 0xE8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image filterErrorButton; // 0xF0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text infoEntryCountText; // 0xF8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text warningEntryCountText; // 0x100
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text errorEntryCountText; // 0x108
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugLogRecycledListView recycledListView; // 0x110
		private DebugLogFilter logFilter; // 0x118
		private List<DebugLogEntry> collapsedLogEntries; // 0x120
		private Dictionary<DebugLogEntry, int> collapsedLogEntriesMap; // 0x128
		private DebugLogIndexList uncollapsedLogEntriesIndices; // 0x130
		private DebugLogIndexList indicesOfListEntriesToShow; // 0x138
		private List<DebugLogItem> pooledLogItems; // 0x140
		private int infoEntryCount; // 0x148
		private int warningEntryCount; // 0x14C
		private int errorEntryCount; // 0x150
		private string _searchString; // 0x158
		private bool _searchHasResults; // 0x160
		private bool isCollapseOn; // 0x161
	
		// Constructors
		public DebugLogPanel(); // 0x0000000181126AD0-0x0000000181126B80
	
		// Methods
		protected override void OnEnable(); // 0x0000000181125BE0-0x0000000181126070
		protected override void OnDisable(); // 0x0000000181125B00-0x0000000181125BE0
		protected override void OnConsoleShown(); // 0x0000000181125A30-0x0000000181125B00
		protected override void LateUpdate(); // 0x0000000181125980-0x0000000181125A30
		private void OnRectTransformDimensionsChange(); // 0x0000000181126070-0x0000000181126080
		private void OnSearchUpdated(string inText); // 0x0000000181126080-0x00000001811260E0
		private void ReceivedLog(string logString, string stackTrace, LogType logType); // 0x00000001811262C0-0x0000000181126AD0
		public override void BtnClicked_Clear(); // 0x0000000181124B90-0x0000000181124D90
		public void PoolLogItem(DebugLogItem logItem); // 0x00000001811260E0-0x0000000181126170
		public DebugLogItem PopLogItem(); // 0x0000000181126170-0x00000001811262C0
		public void CollapseButtonPressed(); // 0x0000000181124D90-0x0000000181124E20
		public void FilterLogButtonPressed(); // 0x0000000181124E90-0x0000000181124F00
		public void FilterWarningButtonPressed(); // 0x0000000181125910-0x0000000181125980
		public void FilterErrorButtonPressed(); // 0x0000000181124E20-0x0000000181124E90
		private void FilterLogs(); // 0x0000000181124F00-0x0000000181125910
	}
}
