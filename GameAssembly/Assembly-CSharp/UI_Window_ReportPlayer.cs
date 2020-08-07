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

public class UI_Window_ReportPlayer : UI_Window // TypeDefIndex: 14159
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _input; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _submitButton; // 0x110
	private ReportCategory _category; // 0x118
	private UserInfo _userInfo; // 0x120

	// Properties
	public ReportCategory Category { get; set; } // 0x00000001803B7C30-0x00000001803B7C40 0x00000001803B7A20-0x00000001803B7A30

	// Nested types
	public enum ReportCategory // TypeDefIndex: 14160
	{
		BadUsername = 0,
		Harassment = 1,
		Spamming = 2,
		TermsOfService = 3,
		Other = 4
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14161
	{
		// Fields
		public UserInfo inUser; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ReportPlayer window); // 0x00000001803B2C80-0x00000001803B2CA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14162
	{
		// Fields
		public UserInfo inUser; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3260-0x00000001803B3320
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_ReportPlayer>d__14 : IAsyncStateMachine // TypeDefIndex: 14163
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_ReportPlayer <>4__this; // 0x28
		private TaskAwaiter<FacilitatorReportUserMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002350-0x0000000180002360
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_ReportPlayer(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(UserInfo inUser); // 0x00000001803B7AA0-0x00000001803B7B60
	public static void QueueWindow(UserInfo inUser); // 0x00000001803B7B60-0x00000001803B7C20
	public static void CloseWindow(); // 0x00000001803B79D0-0x00000001803B7A20
	private void Setup(UserInfo inUser); // 0x00000001803B7C20-0x00000001803B7C30
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[AsyncStateMachine] // 0x00000001801D1AD0-0x00000001801D1B20
	public void BtnClicked_ReportPlayer(); // 0x00000001803B7920-0x00000001803B79D0
	public void OnDropDownItemSelected_Category(int inCategory); // 0x00000001803B7A20-0x00000001803B7A30
	public void OnFeedbackTextUpdated(string inText); // 0x00000001803B7A30-0x00000001803B7AA0
}

