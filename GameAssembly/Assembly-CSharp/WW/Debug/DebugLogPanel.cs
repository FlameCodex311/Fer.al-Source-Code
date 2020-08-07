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

namespace WW.Debug
{
	public class DebugLogPanel : DebugPanel // TypeDefIndex: 16266
	{
		// Fields
		[Header] // 0x00000001801D4190-0x00000001801D41E0
		[SerializeField] // 0x00000001801D4190-0x00000001801D41E0
		private DebugLogItem logItemPrefab; // 0x50
		[Header] // 0x00000001801D18D0-0x00000001801D1920
		[SerializeField] // 0x00000001801D18D0-0x00000001801D1920
		private RectTransform logItemsContainer; // 0x58
		[Header] // 0x00000001801D4940-0x00000001801D4990
		[SerializeField] // 0x00000001801D4940-0x00000001801D4990
		private bool receiveLogcatLogsInAndroid; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string logcatArguments; // 0x68
		private bool screenDimensionsChanged; // 0x70
		[Header] // 0x00000001801D4190-0x00000001801D41E0
		[SerializeField] // 0x00000001801D4190-0x00000001801D41E0
		private Sprite infoLog; // 0x78
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Sprite warningLog; // 0x80
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Sprite errorLog; // 0x88
		private Dictionary<LogType, Sprite> logSpriteRepresentations; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color collapseButtonNormalColor; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color collapseButtonSelectedColor; // 0xA8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color filterButtonsNormalColor; // 0xB8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color filterButtonsSelectedColor; // 0xC8
		[Header] // 0x00000001801D18D0-0x00000001801D1920
		[SerializeField] // 0x00000001801D18D0-0x00000001801D1920
		private Image collapseButton; // 0xD8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image filterInfoButton; // 0xE0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image filterWarningButton; // 0xE8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image filterErrorButton; // 0xF0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text infoEntryCountText; // 0xF8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text warningEntryCountText; // 0x100
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text errorEntryCountText; // 0x108
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public DebugLogPanel(); // 0x000000018096BD30-0x000000018096BDE0
	
		// Methods
		protected override void OnEnable(); // 0x000000018096ADD0-0x000000018096B310
		protected override void OnDisable(); // 0x000000018096AC60-0x000000018096ADD0
		protected override void OnConsoleShown(); // 0x000000018096AB90-0x000000018096AC60
		protected override void LateUpdate(); // 0x000000018096A9F0-0x000000018096AB90
		private void OnRectTransformDimensionsChange(); // 0x000000018096B310-0x000000018096B320
		private void OnSearchUpdated(string inText); // 0x000000018096B320-0x000000018096B380
		private void ReceivedLog(string logString, string stackTrace, LogType logType); // 0x000000018096B550-0x000000018096BD30
		public override void BtnClicked_Clear(); // 0x0000000180969BC0-0x0000000180969DC0
		public void PoolLogItem(DebugLogItem logItem); // 0x000000018096B380-0x000000018096B410
		public DebugLogItem PopLogItem(); // 0x000000018096B410-0x000000018096B550
		public void CollapseButtonPressed(); // 0x0000000180969DC0-0x0000000180969E50
		public void FilterLogButtonPressed(); // 0x0000000180969EC0-0x0000000180969F30
		public void FilterWarningButtonPressed(); // 0x000000018096A980-0x000000018096A9F0
		public void FilterErrorButtonPressed(); // 0x0000000180969E50-0x0000000180969EC0
		private void FilterLogs(); // 0x0000000180969F30-0x000000018096A980
	}
}
