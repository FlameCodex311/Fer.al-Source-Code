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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_AccountCreation : UI_Window // TypeDefIndex: 12385
{
	// Fields
	[Header] // 0x0000000180159D00-0x0000000180159D50
	[SerializeField] // 0x0000000180159D00-0x0000000180159D50
	private UI_FieldStatusIndicator _birthdayStatusIndicator; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _monthInput; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _dayInput; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _yearInput; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _birthdayErrorText; // 0x128
	[Header] // 0x000000018015A690-0x000000018015A6E0
	[SerializeField] // 0x000000018015A690-0x000000018015A6E0
	private UI_FieldStatusIndicator _emailStatusIndicator; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _emailInput; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _emailErrorText; // 0x140
	[Header] // 0x000000018015ABF0-0x000000018015AC40
	[SerializeField] // 0x000000018015ABF0-0x000000018015AC40
	private UI_FieldStatusIndicator _passwordStatusIndicator; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _passwordInput; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _passwordErrorText; // 0x158
	[Header] // 0x000000018015B130-0x000000018015B180
	[SerializeField] // 0x000000018015B130-0x000000018015B180
	private UI_FieldStatusIndicator _usernameStatusIndicator; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _usernameInput; // 0x168
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _usernameErrorText; // 0x170
	[Header] // 0x000000018015B9B0-0x000000018015BA00
	[SerializeField] // 0x000000018015B9B0-0x000000018015BA00
	private FeralButton _agreeToTOSToggle; // 0x178
	[Header] // 0x000000018015BCB0-0x000000018015BD00
	[SerializeField] // 0x000000018015BCB0-0x000000018015BD00
	private CanvasGroup _formGroup; // 0x180
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _registrationBtn; // 0x188
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
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
	private string Month { get; set; } // 0x0000000180F9ECB0-0x0000000180F9ECD0 0x0000000180F9EE90-0x0000000180F9EF20
	private string Day { get; set; } // 0x0000000180F9EB70-0x0000000180F9EB90 0x0000000180F9ED70-0x0000000180F9EE00
	private string Year { get; set; } // 0x0000000180F9ED10-0x0000000180F9ED30 0x0000000180F9F040-0x0000000180F9F0D0
	private string Birthday { get; } // 0x0000000180F9EAE0-0x0000000180F9EB70 
	private string Email { get; set; } // 0x0000000180F9EB90-0x0000000180F9EBB0 0x0000000180F9EE00-0x0000000180F9EE90
	private string Password { get; set; } // 0x0000000180F9ECD0-0x0000000180F9ECF0 0x0000000180F9EF20-0x0000000180F9EFB0
	private string Username { get; set; } // 0x0000000180F9ECF0-0x0000000180F9ED10 0x0000000180F9EFB0-0x0000000180F9F040
	public bool AgreeToTOS { get; set; } // 0x0000000180F9EAB0-0x0000000180F9EAE0 0x0000000180F9ED30-0x0000000180F9ED70
	private bool IsValidBirthday { get; } // 0x0000000180F9EBB0-0x0000000180F9EBF0 
	private bool IsValidEmail { get; } // 0x0000000180F9EBF0-0x0000000180F9EC30 
	private bool IsValidPassword { get; } // 0x0000000180F9EC30-0x0000000180F9EC70 
	private bool IsValidUsername { get; } // 0x0000000180F9EC70-0x0000000180F9ECB0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12386
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_AccountCreation> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180F8F430-0x0000000180F8F490
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_AccountCreation window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180F8EA50-0x0000000180F8EAD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <CheckUsername>d__94 : IAsyncStateMachine // TypeDefIndex: 12387
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public UI_Window_AccountCreation <>4__this; // 0x20
		private TaskAwaiter<string> <>u__1; // 0x28
		private TaskAwaiter<WWWResponse<ValidateDisplayNameResponse>> <>u__2; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1800-0x00000001801F1810
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1810-0x00000001801F1860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass97_0 // TypeDefIndex: 12388
	{
		// Fields
		public UI_Window_AccountCreation <>4__this; // 0x10
		public DateTime inBirthday; // 0x18
		public string inUsername; // 0x20
		public string inEmail; // 0x28
		public string inPassword; // 0x30

		// Constructors
		public <>c__DisplayClass97_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <CreateAccount>b__0(string inCode); // 0x0000000180F8F370-0x0000000180F8F3D0
		internal void <CreateAccount>b__1(string inCode); // 0x0000000180F8F370-0x0000000180F8F3D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <CreateAccount>d__97 : IAsyncStateMachine // TypeDefIndex: 12389
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
		private void MoveNext(); // 0x00000001801F1860-0x00000001801F1870
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Login>d__98 : IAsyncStateMachine // TypeDefIndex: 12390
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inEmail; // 0x28
		public string inPassword; // 0x30
		public UI_Window_AccountCreation <>4__this; // 0x38
		private TaskAwaiter<LoginMessage> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F1870-0x00000001801F1880
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <<RefreshUsernameStatus>b__95_0>d : IAsyncStateMachine // TypeDefIndex: 12391
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_AccountCreation <>4__this; // 0x28
		private string <usernameToTest>5__2; // 0x30
		private TaskAwaiter<string> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1960-0x00000001801F1970
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_AccountCreation(); // 0x0000000180F9E9F0-0x0000000180F9EAB0

	// Methods
	public static void OpenWindow(); // 0x0000000180F9DB60-0x0000000180F9DC60
	public static void QueueWindow(); // 0x0000000180F9DC60-0x0000000180F9DD60
	public static void CloseWindow(); // 0x0000000180F9D320-0x0000000180F9D370
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180F9D8B0-0x0000000180F9DB60
	protected override void OnClose(bool inAnimate); // 0x0000000180F9D590-0x0000000180F9D640
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_CreateAccount(); // 0x0000000180F9CA10-0x0000000180F9CB40
	public void BtnClicked_Back(); // 0x0000000180F9C8F0-0x0000000180F9CA10
	public void BtnClicked_PrivacyPolicy(); // 0x0000000180F9CB40-0x0000000180F9CB80
	public void BtnClicked_TermsOfService(); // 0x0000000180F9CB80-0x0000000180F9CBC0
	public void BtnToggled_ShowPassword(bool inShowPassword); // 0x0000000180F9CBC0-0x0000000180F9CC60
	public void InputFieldValueChanged_Month(); // 0x0000000180F9D480-0x0000000180F9D490
	public void InputFieldValueChanged_Day(); // 0x0000000180F9D480-0x0000000180F9D490
	public void InputFieldValueChanged_Year(); // 0x0000000180F9D480-0x0000000180F9D490
	public void InputFieldValueChanged_Email(); // 0x0000000180F9D490-0x0000000180F9D4A0
	public void InputFieldValueChanged_Password(); // 0x0000000180F9D4A0-0x0000000180F9D4B0
	public void InputFieldValueChanged_Username(); // 0x0000000180F9D4B0-0x0000000180F9D4C0
	public void OnFieldDeslected_Birthday(); // 0x0000000180F9D6B0-0x0000000180F9D730
	public void OnFieldDeselected_Email(); // 0x0000000180F9D640-0x0000000180F9D660
	public void OnFieldDeselected_Password(); // 0x0000000180F9D660-0x0000000180F9D690
	public void OnFieldDeselected_Username(); // 0x0000000180F9D690-0x0000000180F9D6B0
	private void OnFieldSubmit(string inFieldText); // 0x0000000180F9D730-0x0000000180F9D8B0
	private string CheckBirthday(); // 0x0000000180F9CC60-0x0000000180F9CE90
	private void RefreshBirthdayStatus(); // 0x0000000180F9DD60-0x0000000180F9DF40
	private string CheckEmail(); // 0x0000000180F9CE90-0x0000000180F9D020
	private void RefreshEmailStatus(); // 0x0000000180F9DF40-0x0000000180F9E2A0
	private string CheckPassword(); // 0x0000000180F9D020-0x0000000180F9D240
	private void RefreshPasswordStatus(bool inShowError); // 0x0000000180F9E2A0-0x0000000180F9E540
	[AsyncStateMachine] // 0x000000018015C260-0x000000018015C2B0
	private Task<string> CheckUsername(); // 0x0000000180F9D240-0x0000000180F9D320
	private void RefreshUsernameStatus(); // 0x0000000180F9E680-0x0000000180F9E7C0
	private void RefreshRegistrationButton(); // 0x0000000180F9E540-0x0000000180F9E680
	[AsyncStateMachine] // 0x000000018015C600-0x000000018015C650
	private void CreateAccount(DateTime inBirthday, string inUsername, string inEmail, string inPassword, string inEmailVerificationCode); // 0x0000000180F9D370-0x0000000180F9D480
	[AsyncStateMachine] // 0x000000018015CAD0-0x000000018015CB20
	private void Login(string inEmail, string inPassword); // 0x0000000180F9D4C0-0x0000000180F9D590
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnFieldDeslected_Birthday>b__83_0(); // 0x0000000180F9E7C0-0x0000000180F9E940
	[AsyncStateMachine] // 0x000000018015CED0-0x000000018015CF40
	[CompilerGenerated] // 0x000000018015CED0-0x000000018015CF40
	private void <RefreshUsernameStatus>b__95_0(); // 0x0000000180F9E940-0x0000000180F9E9F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Login>b__98_0(); // 0x0000000180F9C8F0-0x0000000180F9CA10
}

