/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Reset : MonoBehaviour // TypeDefIndex: 11304
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static UI_Reset <instance>k__BackingField; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _canvas; // 0x20
	private Camera _camera; // 0x28
	public GameObject groupError; // 0x30
	public GameObject groupButton; // 0x38
	public UnityEngine.UI.Text labelMessage; // 0x40
	public WWTextMeshProUGUI tmpLabelMessage; // 0x48
	public UnityEngine.UI.Text labelButton; // 0x50
	public WWTextMeshProUGUI tmpLabelButton; // 0x58
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static bool <resetPopup>k__BackingField; // 0x08
	private SplashError _resetError; // 0x60
	private ErrorCode _resetErrorCode; // 0x68

	// Properties
	public static UI_Reset instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803DA1D0-0x00000001803DA250 0x00000001803DA290-0x00000001803DA2D0
	public Canvas canvas { get; } // 0x00000001803DA150-0x00000001803DA1D0 
	public Camera Camera { get; } // 0x00000001803DA030-0x00000001803DA0B0 
	public static bool resetPopup { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803DA250-0x00000001803DA290 0x00000001803DA2D0-0x00000001803DA310
	private SystemLanguage GetLanguage { get; } // 0x00000001803DA0B0-0x00000001803DA150 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ResetCamera>d__23 : IEnumerator<object> // TypeDefIndex: 11305
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ResetCamera>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001803C5B00-0x00000001803C5B50
	}

	// Constructors
	public UI_Reset(); // 0x00000001803D9FD0-0x00000001803DA030

	// Methods
	public void Reset(SplashError inResetError, ErrorCode inErrorCode); // 0x00000001803D9A60-0x00000001803D9D00
	[IteratorStateMachine] // 0x0000000180282080-0x00000001802820D0
	private IEnumerator ResetCamera(); // 0x00000001803D9460-0x00000001803D94B0
	private void ResetCheck(); // 0x00000001803D94B0-0x00000001803D9590
	private void ResetInCallback(); // 0x00000001803D9590-0x00000001803D9A60
	private void Show(); // 0x00000001803D9DA0-0x00000001803D9EB0
	private void Hide(); // 0x00000001803D87C0-0x00000001803D8900
	private void Awake(); // 0x00000001803D7980-0x00000001803D7AC0
	private void OnDestroy(); // 0x00000001803D93A0-0x00000001803D9460
	public void BtnClicked_Button(); // 0x00000001803D7AC0-0x00000001803D7D60
	private bool ShowQuitButton(SplashError inSplashError); // 0x00000001803D9D00-0x00000001803D9DA0
	private void FeralErrors(SplashError inSplashError, ErrorCode errorCode, out string outError, out string outButton); // 0x00000001803D7D60-0x00000001803D8700
	private string Localization_ChartError(); // 0x00000001803D89F0-0x00000001803D8A90
	private string Localization_SlowInternet(); // 0x00000001803D8FF0-0x00000001803D9030
	private string Localization_BundleIncompatible(); // 0x00000001803D8900-0x00000001803D89F0
	private string Localization_Timeout(); // 0x00000001803D9030-0x00000001803D90F0
	private string Localization_NoCharts(); // 0x00000001803D8C90-0x00000001803D8D30
	private string Localization_OutOfSpace(); // 0x00000001803D8E10-0x00000001803D8EB0
	private string Localization_UnencryptedCharts(); // 0x00000001803D90F0-0x00000001803D9190
	private string Localization_ErrorUpating(); // 0x00000001803D8AD0-0x00000001803D8B70
	private string Localization_WrongVersion(); // 0x00000001803D92C0-0x00000001803D93A0
	private string Localization_ReloadAllCharts(); // 0x00000001803D8EB0-0x00000001803D8F50
	private string Localization_UnsupportedDevice(); // 0x00000001803D9190-0x00000001803D9230
	private string Localization_CurrentUnityVersion(); // 0x00000001803D8A90-0x00000001803D8AD0
	private string Localization_Ok(); // 0x00000001803D8DD0-0x00000001803D8E10
	private string Localization_Retry(); // 0x00000001803D8F50-0x00000001803D8FF0
	private string Localization_Update(); // 0x00000001803D9230-0x00000001803D92C0
	private string Localization_NoInternet(); // 0x00000001803D8D30-0x00000001803D8DD0
	private string Localization_LostServerConnection(); // 0x00000001803D8B70-0x00000001803D8C90
	private string GetLoc(string inDefId); // 0x00000001803D8700-0x00000001803D87C0
	private bool ValidLoc(string inDefId); // 0x00000001803D9F50-0x00000001803D9FD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ResetCheck>b__24_0(bool cbConnected); // 0x00000001803D9EB0-0x00000001803D9F50
}

