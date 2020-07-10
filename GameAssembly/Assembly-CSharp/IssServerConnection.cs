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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class IssServerConnection : ServerConnection // TypeDefIndex: 10896
{
	// Fields
	public const int DEFAULT_ROOM_ID = 1; // Metadata: 0x0078212C
	public const string ZONE_SBI_LOGIN = "sbiLogin"; // Metadata: 0x00782130
	public const string ZONE_SBI_ACCOUNT = "sbiAccountZone"; // Metadata: 0x0078213C
	public const string XT_NAME_ONE_XT_TO_RULE_THEM_ALL = "o"; // Metadata: 0x0078214E
	public const string XT_NAME_ACCOUNT = "a"; // Metadata: 0x00782153
	private IssClient _iss; // 0x40
	private string _host; // 0x48
	private int _port; // 0x50
	private string _hashKey; // 0x58
	private LoginMode _loginMode; // 0x60
	private string _xtName; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Connect>d__13 : IAsyncStateMachine // TypeDefIndex: 10897
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public IssServerConnection <>4__this; // 0x20
		private DateTime <timeoutTime>5__2; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180212F80-0x0000000180212F90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180212F90-0x0000000180212FE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DisconnectAsync>d__14 : IAsyncStateMachine // TypeDefIndex: 10898
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public IssServerConnection <>4__this; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180212FE0-0x0000000180212FF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 10899
	{
		// Fields
		public bool haveResult; // 0x10
		public ServerLoginResponse result; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Login>b__0(ServerLoginResponse x); // 0x0000000180FF5DC0-0x0000000180FF5DD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Login>d__16 : IAsyncStateMachine // TypeDefIndex: 10900
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
		private void MoveNext(); // 0x0000000180212FF0-0x0000000180213000
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180213000-0x0000000180213050
	}

	// Constructors
	public IssServerConnection(); // 0x00000001812BE650-0x00000001812BE690

	// Methods
	public override void Init(FeralServerEnvironment environment); // 0x00000001812BCE00-0x00000001812BD260
	~IssServerConnection(); // 0x00000001812BCB90-0x00000001812BCC40
	[AsyncStateMachine] // 0x00000001800F5E20-0x00000001800F5E70
	public override Task<bool> Connect(string address); // 0x00000001812BC9E0-0x00000001812BCAC0
	[AsyncStateMachine] // 0x00000001800F6090-0x00000001800F60E0
	public override Task DisconnectAsync(); // 0x00000001812BCAC0-0x00000001812BCB90
	public void GetKey(); // 0x00000001812BCC40-0x00000001812BCE00
	[AsyncStateMachine] // 0x00000001800F6470-0x00000001800F64C0
	public override Task<ServerLoginResponse> Login(string uuid, string authToken, int sessionId); // 0x00000001812BD2D0-0x00000001812BD3F0
	public override void Logout(); // 0x0000000180B4E4C0-0x0000000180B4E4E0
	public override void Switching(); // 0x00000001812BE640-0x00000001812BE650
	public override void ProcessEventQueue(); // 0x00000001812BE080-0x00000001812BE0A0
	public override void Send(INetMessageWriter data); // 0x00000001812BE510-0x00000001812BE640
	private void OnConnection(bool success, string error); // 0x00000001812BD480-0x00000001812BD610
	private void OnConnectionLost(); // 0x00000001812BD3F0-0x00000001812BD480
	private void OnRandomKey(string key); // 0x00000001812BDAD0-0x00000001812BDB80
	private void OnXtMessage(object inData, IssClient.XtMsgType inType); // 0x00000001812BDB80-0x00000001812BE080
	private void ProcessLoginData(JsonData json); // 0x00000001812BE0A0-0x00000001812BE510
	private void OnLogin(bool success, string name, string failureMsg); // 0x00000001812BD780-0x00000001812BDA90
	private void OnLogout(); // 0x00000001812BDA90-0x00000001812BDAD0
	private void OnDebugMessage(string message); // 0x00000001812BD610-0x00000001812BD780
	private void Log(string message); // 0x00000001803581E0-0x00000001803581F0
	private void LogWarning(string message); // 0x00000001803581E0-0x00000001803581F0
	private void LogError(string message); // 0x00000001812BD260-0x00000001812BD2D0
}

