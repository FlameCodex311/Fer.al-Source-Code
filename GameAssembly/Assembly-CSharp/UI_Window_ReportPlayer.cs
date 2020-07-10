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

public class UI_Window_ReportPlayer : UI_Window // TypeDefIndex: 12557
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _input; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _submitButton; // 0x110
	private ReportCategory _category; // 0x118
	private UserInfo _userInfo; // 0x120

	// Properties
	public ReportCategory Category { get; set; } // 0x0000000180EA2380-0x0000000180EA2390 0x0000000180EA2180-0x0000000180EA2190

	// Nested types
	public enum ReportCategory // TypeDefIndex: 12558
	{
		BadUsername = 0,
		Harassment = 1,
		Spamming = 2,
		TermsOfService = 3,
		Other = 4
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12559
	{
		// Fields
		public UserInfo inUser; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ReportPlayer window); // 0x0000000180E9D860-0x0000000180E9D890
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12560
	{
		// Fields
		public UserInfo inUser; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E100-0x0000000180E9E1D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_ReportPlayer>d__14 : IAsyncStateMachine // TypeDefIndex: 12561
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_ReportPlayer <>4__this; // 0x28
		private TaskAwaiter<FacilitatorReportUserMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0750-0x00000001801F0760
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_ReportPlayer(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(UserInfo inUser); // 0x0000000180EA2200-0x0000000180EA22C0
	public static void QueueWindow(UserInfo inUser); // 0x0000000180EA22C0-0x0000000180EA2380
	public static void CloseWindow(); // 0x0000000180EA2130-0x0000000180EA2180
	private void Setup(UserInfo inUser); // 0x00000001803BE5F0-0x00000001803BE600
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[AsyncStateMachine] // 0x00000001800E2BE0-0x00000001800E2C30
	public void BtnClicked_ReportPlayer(); // 0x0000000180EA2080-0x0000000180EA2130
	public void OnDropDownItemSelected_Category(int inCategory); // 0x0000000180EA2180-0x0000000180EA2190
	public void OnFeedbackTextUpdated(string inText); // 0x0000000180EA2190-0x0000000180EA2200
}

