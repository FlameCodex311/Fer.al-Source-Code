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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Login : UI_Window // TypeDefIndex: 14116
{
	// Fields
	public CanvasGroup inputGroup; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _serverTierText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _emailAddressInput; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _passwordInput; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _loginBtn; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _rememberMeToggle; // 0x130
	private bool _isValidEmail; // 0x138
	private bool _isValidPassword; // 0x139
	private string _debugPrefsPrefix; // 0x140
	private Waiter _loginWaiter; // 0x148

	// Properties
	public string Email { get; set; } // 0x00000001803ED240-0x00000001803ED270 0x00000001803ED2D0-0x00000001803ED360
	public string Password { get; set; } // 0x00000001803ED270-0x00000001803ED2A0 0x00000001803ED360-0x00000001803ED3F0
	public bool RememberMe { get; set; } // 0x00000001803ED2A0-0x00000001803ED2D0 0x00000001803ED3F0-0x00000001803ED420

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14117
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__20_0; // 0x08
		public static Action<bool> <>9__27_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2B50-0x00000001803E2BB0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <DoDelayedOpenAnimation>b__20_0(); // 0x00000001803E0970-0x00000001803E09E0
		internal void <BtnClicked_Quit>b__27_0(bool inResult); // 0x00000001803B2300-0x00000001803B2310
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_Login>d__24 : IAsyncStateMachine // TypeDefIndex: 14118
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Login <>4__this; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002640-0x0000000180002650
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Login(); // 0x00000001803ED1F0-0x00000001803ED240

	// Methods
	protected override void OnOpen(); // 0x00000001803ECBA0-0x00000001803ED080
	protected override void DoDelayedOpenAnimation(); // 0x00000001803EC630-0x00000001803EC740
	protected override void OnClose(bool inAnimate); // 0x00000001803EC880-0x00000001803ECB20
	public void InputFieldValueChanged_Email(); // 0x00000001803EC740-0x00000001803EC7B0
	public void InputFieldValueChanged_Password(); // 0x00000001803EC7B0-0x00000001803EC820
	[AsyncStateMachine] // 0x0000000180288F40-0x0000000180288F90
	public void BtnClicked_Login(); // 0x00000001803EC1D0-0x00000001803EC280
	public void BtnClicked_NewAccount(); // 0x00000001803EC280-0x00000001803EC430
	public void BtnClicked_ForgotPassword(); // 0x00000001803EC1A0-0x00000001803EC1D0
	public void BtnClicked_Quit(); // 0x00000001803EC430-0x00000001803EC580
	public void BtnToggled_RememberMe(bool inIsOn); // 0x00000001803EC580-0x00000001803EC630
	public void BtnClicked_Settings(); // 0x00000001803E5A50-0x00000001803E5A60
	private void OnEmailSubmit(string inEmail); // 0x00000001803ECB20-0x00000001803ECBA0
	private void OnPasswordSubmit(string inPassword); // 0x00000001803ED080-0x00000001803ED100
	private void RefreshLoginButton(); // 0x00000001803ED100-0x00000001803ED140
	private void RefreshEmailStatus(); // 0x00000001803EC740-0x00000001803EC7B0
	private bool IsValidEmail(); // 0x00000001803EC820-0x00000001803EC850
	private void RefreshPasswordStatus(); // 0x00000001803EC7B0-0x00000001803EC820
	private bool IsValidPassword(); // 0x00000001803EC850-0x00000001803EC880
	private void OnSettingsWindowOpened(WindowOpenedMessage inMessage); // 0x00000001803E83B0-0x00000001803E83C0
	private void OnSettingsWindowClosed(WindowClosedMessage inMessage); // 0x00000001803E83A0-0x00000001803E83B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__20_1(); // 0x00000001803ED1C0-0x00000001803ED1F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Login>b__24_0(); // 0x00000001803EC1D0-0x00000001803EC280
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Login>b__24_1(); // 0x00000001803ED140-0x00000001803ED1C0
}

