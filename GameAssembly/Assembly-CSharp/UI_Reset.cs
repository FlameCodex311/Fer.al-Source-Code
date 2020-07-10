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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Reset : MonoBehaviour // TypeDefIndex: 13637
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static UI_Reset <instance>k__BackingField; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _canvas; // 0x20
	private Camera _camera; // 0x28
	public GameObject groupError; // 0x30
	public GameObject groupButton; // 0x38
	public UnityEngine.UI.Text labelMessage; // 0x40
	public WWTextMeshProUGUI tmpLabelMessage; // 0x48
	public UnityEngine.UI.Text labelButton; // 0x50
	public WWTextMeshProUGUI tmpLabelButton; // 0x58
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static bool <resetPopup>k__BackingField; // 0x08
	private SplashError _resetError; // 0x60
	private ErrorCode _resetErrorCode; // 0x68

	// Properties
	public static UI_Reset instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EEAF40-0x0000000180EEAFC0 0x0000000180EEB000-0x0000000180EEB040
	public Canvas canvas { get; } // 0x0000000180EEAEC0-0x0000000180EEAF40 
	public Camera Camera { get; } // 0x0000000180EEADA0-0x0000000180EEAE20 
	public static bool resetPopup { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EEAFC0-0x0000000180EEB000 0x0000000180EEB040-0x0000000180EEB080
	private SystemLanguage GetLanguage { get; } // 0x0000000180EEAE20-0x0000000180EEAEC0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ResetCamera>d__23 : IEnumerator<object> // TypeDefIndex: 13638
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ResetCamera>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EE0640-0x0000000180EE0690
	}

	// Constructors
	public UI_Reset(); // 0x0000000180EEAD40-0x0000000180EEADA0

	// Methods
	public void Reset(SplashError inResetError, ErrorCode inErrorCode); // 0x0000000180EEA7C0-0x0000000180EEAA70
	[IteratorStateMachine] // 0x00000001800E4980-0x00000001800E49D0
	private IEnumerator ResetCamera(); // 0x0000000180EEA1B0-0x0000000180EEA200
	private void ResetCheck(); // 0x0000000180EEA200-0x0000000180EEA2E0
	private void ResetInCallback(); // 0x0000000180EEA2E0-0x0000000180EEA7C0
	private void Show(); // 0x0000000180EEAB10-0x0000000180EEAC20
	private void Hide(); // 0x0000000180EE9510-0x0000000180EE9650
	private void Awake(); // 0x0000000180EE86D0-0x0000000180EE8810
	private void OnDestroy(); // 0x0000000180EEA0F0-0x0000000180EEA1B0
	public void BtnClicked_Button(); // 0x0000000180EE8810-0x0000000180EE8AB0
	private bool ShowQuitButton(SplashError inSplashError); // 0x0000000180EEAA70-0x0000000180EEAB10
	private void FeralErrors(SplashError inSplashError, ErrorCode errorCode, out string outError, out string outButton); // 0x0000000180EE8AB0-0x0000000180EE9450
	private string Localization_ChartError(); // 0x0000000180EE9740-0x0000000180EE97E0
	private string Localization_SlowInternet(); // 0x0000000180EE9D40-0x0000000180EE9D80
	private string Localization_BundleIncompatible(); // 0x0000000180EE9650-0x0000000180EE9740
	private string Localization_Timeout(); // 0x0000000180EE9D80-0x0000000180EE9E40
	private string Localization_NoCharts(); // 0x0000000180EE99E0-0x0000000180EE9A80
	private string Localization_OutOfSpace(); // 0x0000000180EE9B60-0x0000000180EE9C00
	private string Localization_UnencryptedCharts(); // 0x0000000180EE9E40-0x0000000180EE9EE0
	private string Localization_ErrorUpating(); // 0x0000000180EE9820-0x0000000180EE98C0
	private string Localization_WrongVersion(); // 0x0000000180EEA010-0x0000000180EEA0F0
	private string Localization_ReloadAllCharts(); // 0x0000000180EE9C00-0x0000000180EE9CA0
	private string Localization_UnsupportedDevice(); // 0x0000000180EE9EE0-0x0000000180EE9F80
	private string Localization_CurrentUnityVersion(); // 0x0000000180EE97E0-0x0000000180EE9820
	private string Localization_Ok(); // 0x0000000180EE9B20-0x0000000180EE9B60
	private string Localization_Retry(); // 0x0000000180EE9CA0-0x0000000180EE9D40
	private string Localization_Update(); // 0x0000000180EE9F80-0x0000000180EEA010
	private string Localization_NoInternet(); // 0x0000000180EE9A80-0x0000000180EE9B20
	private string Localization_LostServerConnection(); // 0x0000000180EE98C0-0x0000000180EE99E0
	private string GetLoc(string inDefId); // 0x0000000180EE9450-0x0000000180EE9510
	private bool ValidLoc(string inDefId); // 0x0000000180EEACC0-0x0000000180EEAD40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ResetCheck>b__24_0(bool cbConnected); // 0x0000000180EEAC20-0x0000000180EEACC0
}

