/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_RegistrationVerification : UI_Window // TypeDefIndex: 14156
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _codeInput; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_FieldStatusIndicator _codeStatusIndicator; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _codeErrorText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _submitBtn; // 0x120
	private Action<string> callback; // 0x128

	// Properties
	public string Code { get; set; } // 0x00000001803B7870-0x00000001803B78A0 0x00000001803B78A0-0x00000001803B7920

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14157
	{
		// Fields
		public Action<string> inCodeCallback; // 0x10
		public string inFailedCode; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_RegistrationVerification window); // 0x00000001803B2E30-0x00000001803B2E60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14158
	{
		// Fields
		public Action<string> inCodeCallback; // 0x10
		public string inFailedCode; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B37B0-0x00000001803B3880
	}

	// Constructors
	public UI_Window_RegistrationVerification(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Action<string> inCodeCallback, string inFailedCode = "" /* Metadata: 0x007BA6CC */); // 0x00000001803B7570-0x00000001803B7640
	public static void QueueWindow(Action<string> inCodeCallback, string inFailedCode = "" /* Metadata: 0x007BA6D0 */); // 0x00000001803B7640-0x00000001803B7710
	public static void CloseWindow(); // 0x00000001803B7250-0x00000001803B72A0
	public void BtnClicked_Submit(); // 0x00000001803B71B0-0x00000001803B7250
	public void OnInputFieldChanged_Code(string inValue); // 0x00000001803B73A0-0x00000001803B7430
	public void BtnClicked_Cancel(); // 0x00000001803B7150-0x00000001803B71B0
	private void Setup(Action<string> inCodeCallback, string inFailedCode = "" /* Metadata: 0x007BA6D4 */); // 0x00000001803B7760-0x00000001803B7870
	protected override void OnOpen(); // 0x00000001803B7430-0x00000001803B7570
	protected override void OnClose(bool inAnimate); // 0x00000001803B72A0-0x00000001803B73A0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void Refresh(); // 0x00000001803B7710-0x00000001803B7760
	private void OnCodeSubmitted(string inCode); // 0x00000001803B71B0-0x00000001803B7250
}

