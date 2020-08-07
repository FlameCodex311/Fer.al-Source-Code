/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LoginHelper : MonoBehaviour // TypeDefIndex: 12441
{
	// Fields
	private static LoginHelper instance; // 0x00
	private string username; // 0x20
	private string passwordOrToken; // 0x28
	private LoginType loginType; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LoginResult <result>k__BackingField; // 0x34
	private string _loginAuthTokenFromServer; // 0x38
	private string _refreshToken; // 0x40
	private string _uuid; // 0x48
	private SystemLanguage _language; // 0x50

	// Properties
	public LoginResult result { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804EF8F0-0x00000001804EF900 0x000000018041B180-0x000000018041B190
	public string AuthToken { get; } // 0x00000001803743D0-0x00000001803743E0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Login>d__14 : IAsyncStateMachine // TypeDefIndex: 12442
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public string username; // 0x20
		public string password; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006060-0x0000000180006070
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006070-0x00000001800060C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <LoginWithToken>d__15 : IAsyncStateMachine // TypeDefIndex: 12443
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public string username; // 0x20
		public string longLiveToken; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006120-0x0000000180006130
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006130-0x0000000180006180
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <LoginForNodeHop>d__16 : IAsyncStateMachine // TypeDefIndex: 12444
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public string username; // 0x20
		public string longLiveToken; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180005FA0-0x0000000180005FB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005FB0-0x0000000180006000
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Login>d__18 : IAsyncStateMachine // TypeDefIndex: 12445
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public string username; // 0x20
		public string passwordOrToken; // 0x28
		public LoginType loginType; // 0x30
		public bool forNodeHop; // 0x34
		private TaskAwaiter<LoginMessage> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800060C0-0x00000001800060D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800060D0-0x0000000180006120
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 12446
	{
		// Fields
		public bool loginComplete; // 0x10

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DoLogin>b__0(LoginCompleteResponse x); // 0x00000001804059F0-0x0000000180405A00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoLogin>d__19 : IAsyncStateMachine // TypeDefIndex: 12447
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public LoginHelper <>4__this; // 0x20
		public bool forNodeHop; // 0x28
		private <>c__DisplayClass19_0 <>8__1; // 0x30
		private ServerLoginResponse <loginResponse>5__2; // 0x38
		private TaskAwaiter<WebLoginResponse> <>u__1; // 0x40
		private TaskAwaiter<bool> <>u__2; // 0x48
		private TaskAwaiter<ServerLoginResponse> <>u__3; // 0x50
		private TaskAwaiter <>u__4; // 0x58

		// Methods
		private void MoveNext(); // 0x0000000180005F40-0x0000000180005F50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005F50-0x0000000180005FA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <LoginToWebServices>d__22 : IAsyncStateMachine // TypeDefIndex: 12448
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WebLoginResponse> <>t__builder; // 0x08
		public LoginHelper <>4__this; // 0x20
		private WebLoginResponse <response>5__2; // 0x28
		private TaskAwaiter<string> <>u__1; // 0x60
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__2; // 0x68
		private FeralServerEnvironment <env>5__3; // 0x70
		private TaskAwaiter<WWWResponse<GetBestGameServerResponse>> <>u__3; // 0x78

		// Methods
		private void MoveNext(); // 0x0000000180006000-0x0000000180006010
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006010-0x0000000180006060
	}

	// Constructors
	public LoginHelper(); // 0x00000001804EF8E0-0x00000001804EF8F0
	static LoginHelper(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	[AsyncStateMachine] // 0x00000001801D1B20-0x00000001801D1B70
	public static Task<LoginMessage> Login(string username, string password); // 0x00000001804EF770-0x00000001804EF860
	[AsyncStateMachine] // 0x00000001801D1E70-0x00000001801D1EC0
	public static Task<LoginMessage> LoginWithToken(string username, string longLiveToken); // 0x00000001804EF560-0x00000001804EF650
	[AsyncStateMachine] // 0x00000001801D2190-0x00000001801D21E0
	public static Task<LoginMessage> LoginForNodeHop(string username, string longLiveToken); // 0x00000001804EF320-0x00000001804EF410
	public static void LoginToDeveloperMode(string username, string password); // 0x00000001804EF410-0x00000001804EF460
	[AsyncStateMachine] // 0x00000001801D24C0-0x00000001801D2510
	private static Task<LoginMessage> Login(string username, string passwordOrToken, LoginType loginType, bool forNodeHop = false /* Metadata: 0x007B98F0 */); // 0x00000001804EF650-0x00000001804EF770
	[AsyncStateMachine] // 0x00000001801D28A0-0x00000001801D28F0
	public Task<LoginMessage> DoLogin(bool forNodeHop = false /* Metadata: 0x007B98F1 */); // 0x00000001804EF0A0-0x00000001804EF1B0
	public static void OnNormalLogin(); // 0x00000001804EF860-0x00000001804EF8E0
	public static string GetLoginStatusErrorMessage(LoginStatus inStatus); // 0x00000001804EF1B0-0x00000001804EF320
	[AsyncStateMachine] // 0x00000001801D2DF0-0x00000001801D2E40
	public Task<WebLoginResponse> LoginToWebServices(); // 0x00000001804EF460-0x00000001804EF560
}

