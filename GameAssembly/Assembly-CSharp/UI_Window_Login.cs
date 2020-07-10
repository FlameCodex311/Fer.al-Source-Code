/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Login : UI_Window // TypeDefIndex: 12514
{
	// Fields
	public CanvasGroup inputGroup; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _serverTierText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _emailAddressInput; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _passwordInput; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _loginBtn; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _rememberMeToggle; // 0x130
	private bool _isValidEmail; // 0x138
	private bool _isValidPassword; // 0x139
	private string _debugPrefsPrefix; // 0x140
	private Waiter _loginWaiter; // 0x148

	// Properties
	public string Email { get; set; } // 0x0000000180ED9B10-0x0000000180ED9B40 0x0000000180ED9BA0-0x0000000180ED9C30
	public string Password { get; set; } // 0x0000000180ED9B40-0x0000000180ED9B70 0x0000000180ED9C30-0x0000000180ED9CC0
	public bool RememberMe { get; set; } // 0x0000000180ED9B70-0x0000000180ED9BA0 0x0000000180ED9CC0-0x0000000180ED9CF0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12515
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__20_0; // 0x08
		public static Action<bool> <>9__27_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF810-0x0000000180ECF870
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <DoDelayedOpenAnimation>b__20_0(); // 0x0000000180ECD430-0x0000000180ECD4A0
		internal void <BtnClicked_Quit>b__27_0(bool inResult); // 0x0000000180E9CEE0-0x0000000180E9CEF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_Login>d__24 : IAsyncStateMachine // TypeDefIndex: 12516
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Login <>4__this; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0F90-0x00000001801F0FA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Login(); // 0x0000000180ED9AC0-0x0000000180ED9B10

	// Methods
	protected override void OnOpen(); // 0x0000000180ED9450-0x0000000180ED9950
	protected override void DoDelayedOpenAnimation(); // 0x0000000180ED8ED0-0x0000000180ED8FE0
	protected override void OnClose(bool inAnimate); // 0x0000000180ED9120-0x0000000180ED93D0
	public void InputFieldValueChanged_Email(); // 0x0000000180ED8FE0-0x0000000180ED9050
	public void InputFieldValueChanged_Password(); // 0x0000000180ED9050-0x0000000180ED90C0
	[AsyncStateMachine] // 0x00000001800D0730-0x00000001800D0780
	public void BtnClicked_Login(); // 0x0000000180ED8BB0-0x0000000180ED8C60
	public void BtnClicked_NewAccount(); // 0x0000000180ED8C60-0x0000000180ED8CD0
	public void BtnClicked_ForgotPassword(); // 0x0000000180ED8B80-0x0000000180ED8BB0
	public void BtnClicked_Quit(); // 0x0000000180ED8CD0-0x0000000180ED8E20
	public void BtnToggled_RememberMe(bool inIsOn); // 0x0000000180ED8E20-0x0000000180ED8ED0
	public void BtnClicked_Settings(); // 0x0000000180ED2760-0x0000000180ED2770
	private void OnEmailSubmit(string inEmail); // 0x0000000180ED93D0-0x0000000180ED9450
	private void OnPasswordSubmit(string inPassword); // 0x0000000180ED9950-0x0000000180ED99D0
	private void RefreshLoginButton(); // 0x0000000180ED99D0-0x0000000180ED9A10
	private void RefreshEmailStatus(); // 0x0000000180ED8FE0-0x0000000180ED9050
	private bool IsValidEmail(); // 0x0000000180ED90C0-0x0000000180ED90F0
	private void RefreshPasswordStatus(); // 0x0000000180ED9050-0x0000000180ED90C0
	private bool IsValidPassword(); // 0x0000000180ED90F0-0x0000000180ED9120
	private void OnSettingsWindowOpened(WindowOpenedMessage inMessage); // 0x0000000180ED5170-0x0000000180ED5180
	private void OnSettingsWindowClosed(WindowClosedMessage inMessage); // 0x0000000180ED5160-0x0000000180ED5170
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__20_1(); // 0x0000000180ED9A90-0x0000000180ED9AC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Login>b__24_0(); // 0x0000000180ED9A10-0x0000000180ED9A90
}

