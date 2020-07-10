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

public class UI_Window_ResetPassword : UI_Window // TypeDefIndex: 12562
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _resetBtn; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _emailInput; // 0x110

	// Properties
	private string Email { get; } // 0x0000000180EA28A0-0x0000000180EA28D0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12563
	{
		// Fields
		public string inEmail; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ResetPassword window); // 0x0000000180E9D920-0x0000000180E9D950
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12564
	{
		// Fields
		public string inEmail; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E4D0-0x0000000180E9E5A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_ResetPassword>d__12 : IAsyncStateMachine // TypeDefIndex: 12565
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_ResetPassword <>4__this; // 0x28
		private TaskAwaiter<string> <>u__1; // 0x30
		private TaskAwaiter<WWWResponse<PasswordResetResponse>> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F0760-0x00000001801F0770
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_ResetPassword(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(string inEmail); // 0x0000000180EA2620-0x0000000180EA26E0
	public static void QueueWindow(string inEmail); // 0x0000000180EA26E0-0x0000000180EA27A0
	public static void CloseWindow(); // 0x0000000180EA2440-0x0000000180EA2490
	private void Setup(string inEmail); // 0x0000000180EA27A0-0x0000000180EA28A0
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void OnEmailChanged(); // 0x0000000180EA2540-0x0000000180EA2620
	[AsyncStateMachine] // 0x00000001800E3510-0x00000001800E3560
	public void BtnClicked_ResetPassword(); // 0x0000000180EA2390-0x0000000180EA2440
	private bool IsValidEmail(); // 0x0000000180EA2490-0x0000000180EA2540
}

