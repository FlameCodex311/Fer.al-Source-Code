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
	public class DebugButtonPanel : MonoBehaviour // TypeDefIndex: 15695
	{
		// Fields
		private const string DEBUG_BUTTON_PANEL_FAVORITES_KEY = "DebugButtonPanel_Favorites"; // Metadata: 0x00784E3F
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugConsoleWindow _console; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayoutGroup _contentParent; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugButtonGroup _buttonGroupPrefab; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
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
		public bool EditFavorites { get; } // 0x000000018111CA40-0x000000018111CA70 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 15696
		{
			// Fields
			public string[] groupPath; // 0x10
	
			// Constructors
			public <>c__DisplayClass23_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <SetupButtonGroups>b__0(DebugMethodGroup groupToFind); // 0x000000018112C540-0x000000018112C5A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass23_1 // TypeDefIndex: 15697
		{
			// Fields
			public string[] groupPath; // 0x10
	
			// Constructors
			public <>c__DisplayClass23_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <SetupButtonGroups>b__1(DebugMethodGroup groupToFind); // 0x000000018112C540-0x000000018112C5A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass27_0 // TypeDefIndex: 15698
		{
			// Fields
			public string[] splitPath; // 0x10
	
			// Constructors
			public <>c__DisplayClass27_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <DrawButtonGroups>b__0(DebugMethodGroup group); // 0x000000018112C540-0x000000018112C5A0
		}
	
		// Constructors
		public DebugButtonPanel(); // 0x000000018111C940-0x000000018111CA40
	
		// Methods
		private void OnEnable(); // 0x000000018111B490-0x000000018111B7B0
		private void OnDisable(); // 0x000000018111B260-0x000000018111B490
		private void LateUpdate(); // 0x000000018111B070-0x000000018111B120
		private void OnShown(); // 0x000000018111B8A0-0x000000018111B990
		private void OnHidden(); // 0x000000018111B7B0-0x000000018111B8A0
		private void OnButtonMethodsChanged(); // 0x000000018111B250-0x000000018111B260
		private void DestroyButtonGroups(); // 0x000000018111A9C0-0x000000018111AB50
		private void SetupButtonGroups(); // 0x000000018111BCE0-0x000000018111C8E0
		private void LoadFavorites(); // 0x000000018111B120-0x000000018111B250
		private void SaveFavorites(); // 0x000000018111BC00-0x000000018111BCE0
		[ContextMenu] // 0x000000018015CD30-0x000000018015CD60
		public void ReportFieldUpdated(); // 0x000000018111BBF0-0x000000018111BC00
		public void DrawButtonGroups(string inPath = "root" /* Metadata: 0x00784E37 */); // 0x000000018111AB50-0x000000018111AF70
		public void BtnClicked_Back(); // 0x000000018111A930-0x000000018111A9C0
		public void ValueChanged_EditFavorites(); // 0x000000018111C8E0-0x000000018111C940
		public bool IsFavorite(ConsoleMethodInfo methodInfo); // 0x000000018111AFF0-0x000000018111B070
		public void AddFavorite(ConsoleMethodInfo methodInfo); // 0x000000018111A6D0-0x000000018111A800
		public void RemoveFavorite(ConsoleMethodInfo methodInfo); // 0x000000018111B990-0x000000018111BAC0
		public bool IsFavorite(ConsoleFieldInfo fieldInfo); // 0x000000018111AF70-0x000000018111AFF0
		public void AddFavorite(ConsoleFieldInfo fieldInfo); // 0x000000018111A800-0x000000018111A930
		public void RemoveFavorite(ConsoleFieldInfo fieldInfo); // 0x000000018111BAC0-0x000000018111BBF0
	}
}
