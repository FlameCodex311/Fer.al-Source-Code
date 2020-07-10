/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_RegistrationVerification : UI_Window // TypeDefIndex: 12554
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _codeInput; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_FieldStatusIndicator _codeStatusIndicator; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _codeErrorText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _submitBtn; // 0x120
	private Action<string> callback; // 0x128

	// Properties
	public string Code { get; set; } // 0x0000000180EA1FD0-0x0000000180EA2000 0x0000000180EA2000-0x0000000180EA2080

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12555
	{
		// Fields
		public Action<string> inCodeCallback; // 0x10
		public string inFailedCode; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_RegistrationVerification window); // 0x0000000180E9DA40-0x0000000180E9DA70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12556
	{
		// Fields
		public Action<string> inCodeCallback; // 0x10
		public string inFailedCode; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E670-0x0000000180E9E740
	}

	// Constructors
	public UI_Window_RegistrationVerification(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(Action<string> inCodeCallback, string inFailedCode = "" /* Metadata: 0x00782FB4 */); // 0x0000000180EA1CD0-0x0000000180EA1DA0
	public static void QueueWindow(Action<string> inCodeCallback, string inFailedCode = "" /* Metadata: 0x00782FB8 */); // 0x0000000180EA1DA0-0x0000000180EA1E70
	public static void CloseWindow(); // 0x0000000180EA19A0-0x0000000180EA19F0
	public void BtnClicked_Submit(); // 0x0000000180EA1900-0x0000000180EA19A0
	public void OnInputFieldChanged_Code(string inValue); // 0x0000000180EA1B00-0x0000000180EA1B90
	public void BtnClicked_Cancel(); // 0x0000000180EA18A0-0x0000000180EA1900
	private void Setup(Action<string> inCodeCallback, string inFailedCode = "" /* Metadata: 0x00782FBC */); // 0x0000000180EA1EC0-0x0000000180EA1FD0
	protected override void OnOpen(); // 0x0000000180EA1B90-0x0000000180EA1CD0
	protected override void OnClose(bool inAnimate); // 0x0000000180EA19F0-0x0000000180EA1B00
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void Refresh(); // 0x0000000180EA1E70-0x0000000180EA1EC0
	private void OnCodeSubmitted(string inCode); // 0x0000000180EA1900-0x0000000180EA19A0
}

