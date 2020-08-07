/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Iss;
using LitJson;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class IssServerConnection : ServerConnection // TypeDefIndex: 12419
{
	// Fields
	public const int DEFAULT_ROOM_ID = 1; // Metadata: 0x007B9870
	public const string ZONE_SBI_LOGIN = "sbiLogin"; // Metadata: 0x007B9874
	public const string ZONE_SBI_ACCOUNT = "sbiAccountZone"; // Metadata: 0x007B9880
	public const string XT_NAME_ONE_XT_TO_RULE_THEM_ALL = "o"; // Metadata: 0x007B9892
	public const string XT_NAME_ACCOUNT = "a"; // Metadata: 0x007B9897
	private IssClient _iss; // 0x40
	private string _host; // 0x48
	private int _port; // 0x50
	private string _hashKey; // 0x58
	private LoginMode _loginMode; // 0x60
	private string _xtName; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Connect>d__13 : IAsyncStateMachine // TypeDefIndex: 12420
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public IssServerConnection <>4__this; // 0x20
		private DateTime <timeoutTime>5__2; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018001C6E0-0x000000018001C6F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C6F0-0x000000018001C740
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DisconnectAsync>d__14 : IAsyncStateMachine // TypeDefIndex: 12421
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public IssServerConnection <>4__this; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001C740-0x000000018001C750
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 12422
	{
		// Fields
		public bool haveResult; // 0x10
		public ServerLoginResponse result; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Login>b__0(ServerLoginResponse x); // 0x00000001804A0220-0x00000001804A0230
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Login>d__16 : IAsyncStateMachine // TypeDefIndex: 12423
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<ServerLoginResponse> <>t__builder; // 0x08
		public IssServerConnection <>4__this; // 0x20
		public string uuid; // 0x28
		public int sessionId; // 0x30
		public string authToken; // 0x38
		private <>c__DisplayClass16_0 <>8__1; // 0x40
		private TaskAwaiter <>u__1; // 0x48

		// Methods
		private void MoveNext(); // 0x000000018001C750-0x000000018001C760
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C760-0x000000018001C7B0
	}

	// Constructors
	public IssServerConnection(); // 0x00000001808780E0-0x0000000180878120

	// Methods
	public override void Init(FeralServerEnvironment environment); // 0x00000001808769A0-0x0000000180876DF0
	~IssServerConnection(); // 0x0000000180876690-0x0000000180876740
	[AsyncStateMachine] // 0x00000001801CFEF0-0x00000001801CFF40
	public override Task<bool> Connect(string address); // 0x00000001808764E0-0x00000001808765C0
	[AsyncStateMachine] // 0x00000001801D0060-0x00000001801D00B0
	public override Task DisconnectAsync(); // 0x00000001808765C0-0x0000000180876690
	public void GetKey(); // 0x0000000180876740-0x00000001808769A0
	[AsyncStateMachine] // 0x00000001801D0370-0x00000001801D03C0
	public override Task<ServerLoginResponse> Login(string uuid, string authToken, int sessionId); // 0x0000000180876E60-0x0000000180876F80
	public override void Logout(); // 0x0000000180876F80-0x0000000180876FA0
	public override void Switching(); // 0x00000001808780D0-0x00000001808780E0
	public override void ProcessEventQueue(); // 0x0000000180877BD0-0x0000000180877BF0
	public override void Send(INetMessageWriter data); // 0x0000000180877F90-0x00000001808780D0
	private void OnConnection(bool success, string error); // 0x0000000180877030-0x00000001808771C0
	private void OnConnectionLost(); // 0x0000000180876FA0-0x0000000180877030
	private void OnRandomKey(string key); // 0x0000000180877650-0x0000000180877700
	private void OnXtMessage(object inData, IssClient.XtMsgType inType); // 0x0000000180877700-0x0000000180877BD0
	private void ProcessLoginData(JsonData json); // 0x0000000180877BF0-0x0000000180877F90
	private void OnLogin(bool success, string name, string failureMsg); // 0x0000000180877320-0x0000000180877610
	private void OnLogout(); // 0x0000000180877610-0x0000000180877650
	private void OnDebugMessage(string message); // 0x00000001808771C0-0x0000000180877320
	private void Log(string message); // 0x00000001803774A0-0x00000001803774B0
	private void LogWarning(string message); // 0x00000001803774A0-0x00000001803774B0
	private void LogError(string message); // 0x0000000180876DF0-0x0000000180876E60
}

