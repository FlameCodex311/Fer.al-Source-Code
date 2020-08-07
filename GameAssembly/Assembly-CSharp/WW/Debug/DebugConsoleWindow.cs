/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugConsoleWindow : MonoBehaviour // TypeDefIndex: 16259
	{
		// Fields
		public static DebugConsoleWindow instance; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float minimumHeight; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool startInPopupMode; // 0x24
		[Header] // 0x00000001801D18D0-0x00000001801D1920
		[SerializeField] // 0x00000001801D18D0-0x00000001801D1920
		private RectTransform logWindowTR; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CanvasGroup _debugWindowCanvasGroup; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CanvasGroup _consoleCanvasGroup; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CanvasGroup _commandLineCanvasGroup; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CanvasGroup _buttonPanelCanvasGrup; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CanvasGroup _customPanelCanvasGroup; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugLogPopup _debugLogPopup; // 0x58
		private const string LAST_PANEL_KEY = "Debug_LastPanel"; // Metadata: 0x007BBA62
		private const string LAST_PANEL_CONSOLE = "console"; // Metadata: 0x007BBA75
		private const string LAST_PANEL_CMDLINE = "commandline"; // Metadata: 0x007BBA80
		private const string LAST_PANEL_BUTTON = "button"; // Metadata: 0x007BBA8F
		private const string LAST_PANEL_CUSTOM = "custom"; // Metadata: 0x007BBA99
		public Action OnShown; // 0x60
		public Action OnHidden; // 0x68
		private RectTransform _canvasTR; // 0x70
		private bool _sidePanelOpen; // 0x78
		private bool _isInPopupMode; // 0x79
		private bool _screenDimensionsChanged; // 0x7A
	
		// Properties
		public CanvasGroup CommandLineCanvasGroup { get; } // 0x00000001803C7290-0x00000001803C72A0 
		public DebugLogPopup DebugLogPopup { get; } // 0x00000001803A1580-0x00000001803A1590 
		public bool IsInPopupMode { get; } // 0x0000000180968EF0-0x0000000180968F00 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 16260
		{
			// Fields
			public CanvasGroup inCanvasGroup; // 0x10
			public bool inIsEnabled; // 0x18
	
			// Constructors
			public <>c__DisplayClass39_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <EnableTab>b__0(); // 0x000000018097C180-0x000000018097C1D0
		}
	
		// Constructors
		public DebugConsoleWindow(); // 0x0000000180968ED0-0x0000000180968EF0
	
		// Methods
		private void Awake(); // 0x0000000180968040-0x00000001809680A0
		private void OnEnable(); // 0x00000001809687D0-0x0000000180968840
		private void Start(); // 0x0000000180968E10-0x0000000180968E50
		private void OnRectTransformDimensionsChange(); // 0x0000000180968840-0x0000000180968850
		private void LateUpdate(); // 0x0000000180968720-0x00000001809687D0
		public void Show(); // 0x0000000180968AC0-0x0000000180968E10
		public void Hide(); // 0x0000000180968650-0x0000000180968720
		public void ToggleSidePanel(); // 0x0000000180968E50-0x0000000180968ED0
		public void ConsoleTabButtonPressed(); // 0x0000000180968210-0x00000001809682B0
		public void CommandLineTabButtonPressed(); // 0x0000000180968140-0x0000000180968210
		public void ButtonPanelTabButtonPressed(); // 0x00000001809680A0-0x0000000180968140
		public void CustomTabButtonPressed(); // 0x00000001809682B0-0x0000000180968350
		private void EnableTab(CanvasGroup inCanvasGroup, bool inIsEnabled); // 0x0000000180968350-0x0000000180968430
		public void HideButtonPressed(); // 0x0000000180968430-0x0000000180968650
		public void Resize(BaseEventData dat); // 0x0000000180968850-0x0000000180968AC0
	}
}
