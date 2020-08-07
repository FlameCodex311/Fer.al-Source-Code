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
	public class DebugButtonPanel : MonoBehaviour // TypeDefIndex: 16242
	{
		// Fields
		private const string DEBUG_BUTTON_PANEL_FAVORITES_KEY = "DebugButtonPanel_Favorites"; // Metadata: 0x007BBA0F
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugConsoleWindow _console; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayoutGroup _contentParent; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugButtonGroup _buttonGroupPrefab; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Toggle _editFavoritesToggle; // 0x38
		public Action<bool> OnEditFavoritesChanged; // 0x40
		private bool _rebuildPanel; // 0x48
		private List<DebugMethodGroup> _methodGroups; // 0x50
		private List<DebugButtonGroup> _buttonGroups; // 0x58
		private DebugMethodGroup _favoriteGroup; // 0x60
		private List<string> _favorites; // 0x68
		private string _currentPath; // 0x70
		private Stack<string> _pathHistory; // 0x78
		private bool _layoutRebuildNeeded; // 0x80
	
		// Properties
		public bool EditFavorites { get; } // 0x0000000180662680-0x00000001806626A0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 16243
		{
			// Fields
			public string[] groupPath; // 0x10
	
			// Constructors
			public <>c__DisplayClass23_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <SetupButtonGroups>b__0(DebugMethodGroup groupToFind); // 0x000000018066A6D0-0x000000018066A720
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass23_1 // TypeDefIndex: 16244
		{
			// Fields
			public string[] groupPath; // 0x10
	
			// Constructors
			public <>c__DisplayClass23_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <SetupButtonGroups>b__1(DebugMethodGroup groupToFind); // 0x000000018066A6D0-0x000000018066A720
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass27_0 // TypeDefIndex: 16245
		{
			// Fields
			public string[] splitPath; // 0x10
	
			// Constructors
			public <>c__DisplayClass27_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <DrawButtonGroups>b__0(DebugMethodGroup group); // 0x000000018066A6D0-0x000000018066A720
		}
	
		// Constructors
		public DebugButtonPanel(); // 0x0000000180662580-0x0000000180662680
	
		// Methods
		private void OnEnable(); // 0x0000000180661130-0x0000000180661440
		private void OnDisable(); // 0x0000000180660F10-0x0000000180661130
		private void LateUpdate(); // 0x0000000180660D30-0x0000000180660DE0
		private void OnShown(); // 0x0000000180661530-0x0000000180661620
		private void OnHidden(); // 0x0000000180661440-0x0000000180661530
		private void OnButtonMethodsChanged(); // 0x0000000180660F00-0x0000000180660F10
		private void DestroyButtonGroups(); // 0x00000001806606A0-0x0000000180660830
		private void SetupButtonGroups(); // 0x0000000180661970-0x0000000180662520
		private void LoadFavorites(); // 0x0000000180660DE0-0x0000000180660F00
		private void SaveFavorites(); // 0x0000000180661890-0x0000000180661970
		[ContextMenu] // 0x00000001801CE000-0x00000001801CE030
		public void ReportFieldUpdated(); // 0x0000000180661880-0x0000000180661890
		public void DrawButtonGroups(string inPath = "root" /* Metadata: 0x007BBA07 */); // 0x0000000180660830-0x0000000180660C30
		public void BtnClicked_Back(); // 0x0000000180660610-0x00000001806606A0
		public void ValueChanged_EditFavorites(); // 0x0000000180662520-0x0000000180662580
		public bool IsFavorite(ConsoleMethodInfo methodInfo); // 0x0000000180660CB0-0x0000000180660D30
		public void AddFavorite(ConsoleMethodInfo methodInfo); // 0x00000001806603B0-0x00000001806604E0
		public void RemoveFavorite(ConsoleMethodInfo methodInfo); // 0x0000000180661620-0x0000000180661750
		public bool IsFavorite(ConsoleFieldInfo fieldInfo); // 0x0000000180660C30-0x0000000180660CB0
		public void AddFavorite(ConsoleFieldInfo fieldInfo); // 0x00000001806604E0-0x0000000180660610
		public void RemoveFavorite(ConsoleFieldInfo fieldInfo); // 0x0000000180661750-0x0000000180661880
	}
}
