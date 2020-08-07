/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_AccountCreation : UI_Window // TypeDefIndex: 13970
{
	// Fields
	[Header] // 0x000000018024F7A0-0x000000018024F7F0
	[SerializeField] // 0x000000018024F7A0-0x000000018024F7F0
	private UI_FieldStatusIndicator _birthdayStatusIndicator; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _monthInput; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _dayInput; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _yearInput; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _birthdayErrorText; // 0x128
	[Header] // 0x0000000180251590-0x00000001802515E0
	[SerializeField] // 0x0000000180251590-0x00000001802515E0
	private UI_FieldStatusIndicator _emailStatusIndicator; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _emailInput; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _emailErrorText; // 0x140
	[Header] // 0x0000000180251CC0-0x0000000180251D10
	[SerializeField] // 0x0000000180251CC0-0x0000000180251D10
	private UI_FieldStatusIndicator _passwordStatusIndicator; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _passwordInput; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _passwordErrorText; // 0x158
	[Header] // 0x0000000180252300-0x0000000180252350
	[SerializeField] // 0x0000000180252300-0x0000000180252350
	private UI_FieldStatusIndicator _usernameStatusIndicator; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _usernameInput; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _usernameErrorText; // 0x170
	[Header] // 0x0000000180252B60-0x0000000180252BB0
	[SerializeField] // 0x0000000180252B60-0x0000000180252BB0
	private FeralButton _agreeToTOSToggle; // 0x178
	[Header] // 0x0000000180252DD0-0x0000000180252E20
	[SerializeField] // 0x0000000180252DD0-0x0000000180252E20
	private CanvasGroup _formGroup; // 0x180
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _registrationBtn; // 0x188
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField[] _submitFields; // 0x190
	private bool _birthdayIsDirty; // 0x198
	private Waiter _birthdayValidationWaiter; // 0x1A0
	private string _birthdayStatus; // 0x1A8
	private bool _emailIsDirty; // 0x1B0
	private Waiter _emailValidationWaiter; // 0x1B8
	private string _emailStatus; // 0x1C0
	private Dictionary<string, string> _cachedEmailValidations; // 0x1C8
	private bool _passwordIsDirty; // 0x1D0
	private Waiter _passwordValidationWaiter; // 0x1D8
	private List<string> _passwordBlacklist; // 0x1E0
	private string _passwordStatus; // 0x1E8
	private bool _usernameIsDirty; // 0x1F0
	private Waiter _usernameValidationWaiter; // 0x1F8
	private string _usernameStatus; // 0x200
	private bool _accountBeingCreated; // 0x208
	private Waiter _postSubmissionWaiter; // 0x210

	// Properties
	private string Month { get; set; } // 0x000000018063F550-0x000000018063F570 0x000000018063F730-0x000000018063F7C0
	private string Day { get; set; } // 0x0000000180480F50-0x0000000180480F70 0x000000018063F610-0x000000018063F6A0
	private string Year { get; set; } // 0x000000018063F5B0-0x000000018063F5D0 0x000000018063F8E0-0x000000018063F970
	private string Birthday { get; } // 0x000000018063F3A0-0x000000018063F430 
	private string Email { get; set; } // 0x000000018063F430-0x000000018063F450 0x000000018063F6A0-0x000000018063F730
	private string Password { get; set; } // 0x000000018063F570-0x000000018063F590 0x000000018063F7C0-0x000000018063F850
	private string Username { get; set; } // 0x000000018063F590-0x000000018063F5B0 0x000000018063F850-0x000000018063F8E0
	public bool AgreeToTOS { get; set; } // 0x000000018063F370-0x000000018063F3A0 0x000000018063F5D0-0x000000018063F610
	private bool IsValidBirthday { get; } // 0x000000018063F450-0x000000018063F490 
	private bool IsValidEmail { get; } // 0x000000018063F490-0x000000018063F4D0 
	private bool IsValidPassword { get; } // 0x000000018063F4D0-0x000000018063F510 
	private bool IsValidUsername { get; } // 0x000000018063F510-0x000000018063F550 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13971
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_AccountCreation> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001806355E0-0x0000000180635640
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_AccountCreation window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180634AF0-0x0000000180634B70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <CheckUsername>d__94 : IAsyncStateMachine // TypeDefIndex: 13972
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public UI_Window_AccountCreation <>4__this; // 0x20
		private TaskAwaiter<string> <>u__1; // 0x28
		private TaskAwaiter<WWWResponse<ValidateDisplayNameResponse>> <>u__2; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180009F20-0x0000000180009F30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009F30-0x0000000180009F80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass97_0 // TypeDefIndex: 13973
	{
		// Fields
		public UI_Window_AccountCreation <>4__this; // 0x10
		public DateTime inBirthday; // 0x18
		public string inUsername; // 0x20
		public string inEmail; // 0x28
		public string inPassword; // 0x30

		// Constructors
		public <>c__DisplayClass97_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <CreateAccount>b__0(string inCode); // 0x0000000180635460-0x00000001806354C0
		internal void <CreateAccount>b__1(string inCode); // 0x0000000180635460-0x00000001806354C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <CreateAccount>d__97 : IAsyncStateMachine // TypeDefIndex: 13974
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_AccountCreation <>4__this; // 0x28
		public DateTime inBirthday; // 0x30
		public string inUsername; // 0x38
		public string inEmail; // 0x40
		public string inPassword; // 0x48
		private <>c__DisplayClass97_0 <>8__1; // 0x50
		public string inEmailVerificationCode; // 0x58
		private TaskAwaiter<string> <>u__1; // 0x60
		private TaskAwaiter<WWWResponse<RegisterUserResponse>> <>u__2; // 0x68

		// Methods
		private void MoveNext(); // 0x0000000180009F80-0x0000000180009F90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Login>d__98 : IAsyncStateMachine // TypeDefIndex: 13975
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inEmail; // 0x28
		public string inPassword; // 0x30
		public UI_Window_AccountCreation <>4__this; // 0x38
		private TaskAwaiter<LoginMessage> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180009FA0-0x0000000180009FB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <<RefreshUsernameStatus>b__95_0>d : IAsyncStateMachine // TypeDefIndex: 13976
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_AccountCreation <>4__this; // 0x28
		private string <usernameToTest>5__2; // 0x30
		private TaskAwaiter<string> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180009FD0-0x000000018000A180
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_AccountCreation(); // 0x000000018063F2B0-0x000000018063F370

	// Methods
	public static void OpenWindow(); // 0x000000018063E440-0x000000018063E540
	public static void QueueWindow(); // 0x000000018063E540-0x000000018063E640
	public static void CloseWindow(); // 0x000000018063DBB0-0x000000018063DC00
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x000000018063E1A0-0x000000018063E440
	protected override void OnClose(bool inAnimate); // 0x000000018063DE90-0x000000018063DF30
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_CreateAccount(); // 0x000000018063D2C0-0x000000018063D3F0
	public void BtnClicked_Back(); // 0x000000018063D1B0-0x000000018063D2C0
	public void BtnClicked_PrivacyPolicy(); // 0x000000018063D3F0-0x000000018063D430
	public void BtnClicked_TermsOfService(); // 0x000000018063D430-0x000000018063D470
	public void BtnToggled_ShowPassword(bool inShowPassword); // 0x000000018063D470-0x000000018063D510
	public void InputFieldValueChanged_Month(); // 0x000000018063DD10-0x000000018063DD20
	public void InputFieldValueChanged_Day(); // 0x000000018063DD10-0x000000018063DD20
	public void InputFieldValueChanged_Year(); // 0x000000018063DD10-0x000000018063DD20
	public void InputFieldValueChanged_Email(); // 0x000000018063DD20-0x000000018063DD30
	public void InputFieldValueChanged_Password(); // 0x000000018063DD30-0x000000018063DDB0
	public void InputFieldValueChanged_Username(); // 0x000000018063DDB0-0x000000018063DDC0
	public void OnFieldDeslected_Birthday(); // 0x000000018063DFA0-0x000000018063E020
	public void OnFieldDeselected_Email(); // 0x000000018063DF30-0x000000018063DF50
	public void OnFieldDeselected_Password(); // 0x000000018063DF50-0x000000018063DF80
	public void OnFieldDeselected_Username(); // 0x000000018063DF80-0x000000018063DFA0
	private void OnFieldSubmit(string inFieldText); // 0x000000018063E020-0x000000018063E1A0
	private string CheckBirthday(); // 0x000000018063D510-0x000000018063D730
	private void RefreshBirthdayStatus(); // 0x000000018063E640-0x000000018063E820
	private string CheckEmail(); // 0x000000018063D730-0x000000018063D8C0
	private void RefreshEmailStatus(); // 0x000000018063E820-0x000000018063EB70
	private string CheckPassword(); // 0x000000018063D8C0-0x000000018063DAD0
	private void RefreshPasswordStatus(bool inShowError); // 0x000000018063EB70-0x000000018063EE10
	[AsyncStateMachine] // 0x00000001802533E0-0x0000000180253430
	private Task<string> CheckUsername(); // 0x000000018063DAD0-0x000000018063DBB0
	private void RefreshUsernameStatus(); // 0x000000018063EF50-0x000000018063F090
	private void RefreshRegistrationButton(); // 0x000000018063EE10-0x000000018063EF50
	[AsyncStateMachine] // 0x00000001802536F0-0x0000000180253740
	private void CreateAccount(DateTime inBirthday, string inUsername, string inEmail, string inPassword, string inEmailVerificationCode); // 0x000000018063DC00-0x000000018063DD10
	[AsyncStateMachine] // 0x0000000180253800-0x0000000180253850
	private void Login(string inEmail, string inPassword); // 0x000000018063DDC0-0x000000018063DE90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnFieldDeslected_Birthday>b__83_0(); // 0x000000018063F090-0x000000018063F200
	[AsyncStateMachine] // 0x0000000180253DA0-0x0000000180253E10
	[CompilerGenerated] // 0x0000000180253DA0-0x0000000180253E10
	private void <RefreshUsernameStatus>b__95_0(); // 0x000000018063F200-0x000000018063F2B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Login>b__98_0(); // 0x000000018063D1B0-0x000000018063D2C0
}

