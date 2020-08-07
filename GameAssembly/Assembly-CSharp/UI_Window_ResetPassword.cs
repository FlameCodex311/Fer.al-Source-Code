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

public class UI_Window_ResetPassword : UI_Window // TypeDefIndex: 14164
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _resetBtn; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _emailInput; // 0x110

	// Properties
	private string Email { get; } // 0x00000001803B8150-0x00000001803B8180 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14165
	{
		// Fields
		public string inEmail; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ResetPassword window); // 0x00000001803B2D20-0x00000001803B2D50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14166
	{
		// Fields
		public string inEmail; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3610-0x00000001803B36E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_ResetPassword>d__12 : IAsyncStateMachine // TypeDefIndex: 14167
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_ResetPassword <>4__this; // 0x28
		private TaskAwaiter<string> <>u__1; // 0x30
		private TaskAwaiter<WWWResponse<PasswordResetResponse>> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002360-0x0000000180002370
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_ResetPassword(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(string inEmail); // 0x00000001803B7ED0-0x00000001803B7F90
	public static void QueueWindow(string inEmail); // 0x00000001803B7F90-0x00000001803B8050
	public static void CloseWindow(); // 0x00000001803B7CF0-0x00000001803B7D40
	private void Setup(string inEmail); // 0x00000001803B8050-0x00000001803B8150
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void OnEmailChanged(); // 0x00000001803B7DF0-0x00000001803B7ED0
	[AsyncStateMachine] // 0x00000001801D2B20-0x00000001801D2B70
	public void BtnClicked_ResetPassword(); // 0x00000001803B7C40-0x00000001803B7CF0
	private bool IsValidEmail(); // 0x00000001803B7D40-0x00000001803B7DF0
}

