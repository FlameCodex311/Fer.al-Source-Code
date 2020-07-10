/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class LoginHelper : MonoBehaviour // TypeDefIndex: 10918
{
	// Fields
	private static LoginHelper instance; // 0x00
	private string username; // 0x20
	private string passwordOrToken; // 0x28
	private LoginType loginType; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private LoginResult <result>k__BackingField; // 0x34
	private string _loginAuthTokenFromServer; // 0x38
	private string _refreshToken; // 0x40
	private string _uuid; // 0x48
	private SystemLanguage _language; // 0x50

	// Properties
	public LoginResult result { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018043E170-0x000000018043E180 0x000000018036C610-0x000000018036C620
	public string AuthToken { get; } // 0x0000000180369BB0-0x0000000180369BC0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Login>d__14 : IAsyncStateMachine // TypeDefIndex: 10919
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public string username; // 0x20
		public string password; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020E740-0x000000018020E750
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020E750-0x000000018020E7A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <LoginWithToken>d__15 : IAsyncStateMachine // TypeDefIndex: 10920
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public string username; // 0x20
		public string longLiveToken; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020E800-0x000000018020E810
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020E810-0x000000018020E860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <LoginForNodeHop>d__16 : IAsyncStateMachine // TypeDefIndex: 10921
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder; // 0x08
		public string username; // 0x20
		public string longLiveToken; // 0x28
		private TaskAwaiter<LoginMessage> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020E680-0x000000018020E690
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020E690-0x000000018020E6E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Login>d__18 : IAsyncStateMachine // TypeDefIndex: 10922
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
		private void MoveNext(); // 0x000000018020E7A0-0x000000018020E7B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020E7B0-0x000000018020E800
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 10923
	{
		// Fields
		public bool loginComplete; // 0x10

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DoLogin>b__0(LoginCompleteResponse x); // 0x0000000180976970-0x0000000180976980
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DoLogin>d__19 : IAsyncStateMachine // TypeDefIndex: 10924
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
		private void MoveNext(); // 0x000000018020E620-0x000000018020E630
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020E630-0x000000018020E680
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <LoginToWebServices>d__22 : IAsyncStateMachine // TypeDefIndex: 10925
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WebLoginResponse> <>t__builder; // 0x08
		public LoginHelper <>4__this; // 0x20
		private WebLoginResponse <response>5__2; // 0x28
		private TaskAwaiter<string> <>u__1; // 0x50
		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__2; // 0x58
		private FeralServerEnvironment <env>5__3; // 0x60
		private TaskAwaiter<WWWResponse<GetBestGameServerResponse>> <>u__3; // 0x68

		// Methods
		private void MoveNext(); // 0x000000018020E6E0-0x000000018020E6F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020E6F0-0x000000018020E740
	}

	// Constructors
	public LoginHelper(); // 0x00000001811E8D00-0x00000001811E8D10
	static LoginHelper(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	[AsyncStateMachine] // 0x00000001800F7F70-0x00000001800F7FC0
	public static Task<LoginMessage> Login(string username, string password); // 0x00000001811E8B90-0x00000001811E8C80
	[AsyncStateMachine] // 0x00000001800F80F0-0x00000001800F8140
	public static Task<LoginMessage> LoginWithToken(string username, string longLiveToken); // 0x00000001811E8980-0x00000001811E8A70
	[AsyncStateMachine] // 0x00000001800F82D0-0x00000001800F8320
	public static Task<LoginMessage> LoginForNodeHop(string username, string longLiveToken); // 0x00000001811E8740-0x00000001811E8830
	public static void LoginToDeveloperMode(string username, string password); // 0x00000001811E8830-0x00000001811E8880
	[AsyncStateMachine] // 0x00000001800F8560-0x00000001800F85B0
	private static Task<LoginMessage> Login(string username, string passwordOrToken, LoginType loginType, bool forNodeHop = false /* Metadata: 0x007821A8 */); // 0x00000001811E8A70-0x00000001811E8B90
	[AsyncStateMachine] // 0x00000001800F8790-0x00000001800F87E0
	public Task<LoginMessage> DoLogin(bool forNodeHop = false /* Metadata: 0x007821A9 */); // 0x00000001811E84C0-0x00000001811E85D0
	public static void OnNormalLogin(); // 0x00000001811E8C80-0x00000001811E8D00
	public static string GetLoginStatusErrorMessage(LoginStatus inStatus); // 0x00000001811E85D0-0x00000001811E8740
	[AsyncStateMachine] // 0x00000001800F8AF0-0x00000001800F8B40
	public Task<WebLoginResponse> LoginToWebServices(); // 0x00000001811E8880-0x00000001811E8980
}

