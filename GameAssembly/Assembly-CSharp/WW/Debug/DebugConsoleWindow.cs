/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugConsoleWindow : MonoBehaviour // TypeDefIndex: 15707
	{
		// Fields
		public static DebugConsoleWindow instance; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float minimumHeight; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool startInPopupMode; // 0x24
		[Header] // 0x000000018015EB00-0x000000018015EB50
		[SerializeField] // 0x000000018015EB00-0x000000018015EB50
		private RectTransform logWindowTR; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CanvasGroup _debugWindowCanvasGroup; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CanvasGroup _consoleCanvasGroup; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CanvasGroup _commandLineCanvasGroup; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CanvasGroup _buttonPanelCanvasGrup; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CanvasGroup _customPanelCanvasGroup; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugLogPopup _debugLogPopup; // 0x58
		private const string LAST_PANEL_KEY = "Debug_LastPanel"; // Metadata: 0x00784E7A
		private const string LAST_PANEL_CONSOLE = "console"; // Metadata: 0x00784E8D
		private const string LAST_PANEL_CMDLINE = "commandline"; // Metadata: 0x00784E98
		private const string LAST_PANEL_BUTTON = "button"; // Metadata: 0x00784EA7
		private const string LAST_PANEL_CUSTOM = "custom"; // Metadata: 0x00784EB1
		public Action OnShown; // 0x60
		public Action OnHidden; // 0x68
		private RectTransform _canvasTR; // 0x70
		private bool _sidePanelOpen; // 0x78
		private bool _isInPopupMode; // 0x79
		private bool _screenDimensionsChanged; // 0x7A
	
		// Properties
		public DebugLogPopup DebugLogPopup { get; } // 0x0000000180357120-0x0000000180357130 
		public bool IsInPopupMode { get; } // 0x00000001804A24F0-0x00000001804A2500 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass37_0 // TypeDefIndex: 15708
		{
			// Fields
			public CanvasGroup inCanvasGroup; // 0x10
			public bool inIsEnabled; // 0x18
	
			// Constructors
			public <>c__DisplayClass37_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <EnableTab>b__0(); // 0x000000018112C5A0-0x000000018112C5F0
		}
	
		// Constructors
		public DebugConsoleWindow(); // 0x00000001811207B0-0x00000001811207D0
	
		// Methods
		private void Awake(); // 0x000000018111FA00-0x000000018111FA60
		private void OnEnable(); // 0x0000000181120090-0x0000000181120100
		private void Start(); // 0x0000000181120680-0x0000000181120730
		private void OnRectTransformDimensionsChange(); // 0x0000000181120100-0x0000000181120110
		private void LateUpdate(); // 0x0000000181120050-0x0000000181120090
		public void Show(); // 0x0000000181120380-0x0000000181120680
		public void Hide(); // 0x000000018111FFB0-0x0000000181120050
		public void ToggleSidePanel(); // 0x0000000181120730-0x00000001811207B0
		public void ConsoleTabButtonPressed(); // 0x000000018111FBA0-0x000000018111FC40
		public void CommandLineTabButtonPressed(); // 0x000000018111FB00-0x000000018111FBA0
		public void ButtonPanelTabButtonPressed(); // 0x000000018111FA60-0x000000018111FB00
		public void CustomTabButtonPressed(); // 0x000000018111FC40-0x000000018111FCE0
		private void EnableTab(CanvasGroup inCanvasGroup, bool inIsEnabled); // 0x000000018111FCE0-0x000000018111FDC0
		public void HideButtonPressed(); // 0x000000018111FDC0-0x000000018111FFB0
		public void Resize(BaseEventData dat); // 0x0000000181120110-0x0000000181120380
	}
}
