/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public class NetworkManager : SingletonManagerBase<NetworkManager> // TypeDefIndex: 12250
{
	// Fields
	public const string WebRegion = "US"; // Metadata: 0x007B96CE
	public bool LogMovementCommands; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<string> _ignoreLoggingXtCmds; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ServerDeployState _serverDeployState; // 0x70
	public static AutoLoginState AutoLogin; // 0x00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static string <AutoLoginRoomName>k__BackingField; // 0x08
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static string <AutoLoginBuddyName>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private DateTime <LastMaintenanceMode>k__BackingField; // 0x78
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static DisconnectReason <DisconnectReason>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static string <Username>k__BackingField; // 0x20
	public static readonly DateTimeOffset ServerEpoch; // 0x28
	public static string autoLoginDisplayName; // 0x38
	public static string autoLoginEmailUsername; // 0x40
	public static string autoLoginPassword; // 0x48
	public static string autoLoginAuthToken; // 0x50
	public static string autoLoginRefreshToken; // 0x58
	public static int nodeHopSessionId; // 0x60
	public static string nodeHopNewHost; // 0x68
	public static string nodeHopUUID; // 0x70
	private string _jwt; // 0x80
	private string _uuid; // 0x88
	private ServerConnection _serverConnection; // 0x90
	private ChatServiceConnection _chatServiceConnection; // 0x98
	private MessageRouter _router; // 0xA0
	private FeralServerEnvironment _serverEnvironment; // 0xA8
	private DateTimeOffset _serverTimeAtLogin; // 0xB0
	private float _clientTmeAtLogin; // 0xC0

	// Properties
	public static ServerConnection ServerConnection { get; private set; } // 0x00000001807CC810-0x00000001807CC860 0x00000001807CCFA0-0x00000001807CCFF0
	public static bool IsConnected { get; } // 0x00000001807CC210-0x00000001807CC2B0 
	public static bool IsLoggedIn { get; } // 0x00000001807CC410-0x00000001807CC4B0 
	public static bool IsFakeServer { get; } // 0x00000001807CC340-0x00000001807CC410 
	public static ChatServiceConnection ChatServiceConnection { get; private set; } // 0x00000001807CBF60-0x00000001807CBFB0 0x00000001807CCC30-0x00000001807CCC80
	public static bool IsDev { get; } // 0x00000001807CC2B0-0x00000001807CC340 
	public static bool IsStage { get; } // 0x00000001807CC540-0x00000001807CC5D0 
	public static bool IsProd { get; } // 0x00000001807CC4B0-0x00000001807CC540 
	public static string AutoLoginRoomName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001807CBF00-0x00000001807CBF60 0x00000001807CCBD0-0x00000001807CCC30
	public static string AutoLoginBuddyName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001807CBEA0-0x00000001807CBF00 0x00000001807CCB70-0x00000001807CCBD0
	public DateTime LastMaintenanceMode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
	public static DisconnectReason DisconnectReason { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001807CC050-0x00000001807CC110 0x00000001807CCCD0-0x00000001807CCD30
	public static int UserID { get; } // 0x00000001807CCA90-0x00000001807CCB10 
	public static string Username { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001807CCB10-0x00000001807CCB70 0x00000001807CD040-0x00000001807CD0A0
	public static int RoomID { get; set; } // 0x00000001807CC6B0-0x00000001807CC7C0 0x00000001807CCE90-0x00000001807CCFA0
	public static string RoomDefID { get; set; } // 0x00000001807CC620-0x00000001807CC6B0 0x00000001807CCD80-0x00000001807CCE90
	public static MessageRouter Router { get; } // 0x00000001807CC7C0-0x00000001807CC810 
	public static FeralServerEnvironment Environment { get; } // 0x00000001807CC110-0x00000001807CC160 
	public static ServerDeployState DeployState { get; set; } // 0x00000001807CC000-0x00000001807CC050 0x00000001807CCC80-0x00000001807CCCD0
	private static DateTimeOffset ServerTimeAtLogin { get; } // 0x00000001807CC860-0x00000001807CC8F0 
	private static float ClientTimeAtLogin { get; } // 0x00000001807CBFB0-0x00000001807CC000 
	public static DateTimeOffset ServerTime { get; } // 0x00000001807CC8F0-0x00000001807CCA40 
	public static string JWT { get; set; } // 0x00000001807CC5D0-0x00000001807CC620 0x00000001807CCD30-0x00000001807CCD80
	public static string UUID { get; set; } // 0x00000001807CCA40-0x00000001807CCA90 0x00000001807CCFF0-0x00000001807CD040
	public static bool InternetIsReachable { get; } // 0x00000001807CC160-0x00000001807CC210 

	// Nested types
	public enum AutoLoginState // TypeDefIndex: 12251
	{
		NoAutoLogin = 0,
		DoAutoLogin = 1,
		NodeHopAutoLogin = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12252
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__95_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001807DB270-0x00000001807DB2D0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <FocusChange>b__95_0(bool connected); // 0x00000001807DB210-0x00000001807DB270
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <InitFakeServer>d__96 : IAsyncStateMachine // TypeDefIndex: 12253
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x20
		private TaskAwaiter<LoginMessage> <>u__2; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001B5A0-0x000000018001B670
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Disconnect>d__99 : IAsyncStateMachine // TypeDefIndex: 12254
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public DisconnectReason reason; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018001B590-0x000000018001B5A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DisconnectAsync>d__100 : IAsyncStateMachine // TypeDefIndex: 12255
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public DisconnectReason reason; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001B580-0x000000018001B590
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ServerConnectionLostLogic>d__108 : IEnumerator<object> // TypeDefIndex: 12256
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public NetworkManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ServerConnectionLostLogic>d__108(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D96A0-0x00000001807D9A90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D9A90-0x00000001807D9AE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CanReachInternet>d__111 : IEnumerator<object> // TypeDefIndex: 12257
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> callback; // 0x20
		private WWW <www>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CanReachInternet>d__111(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D79C0-0x00000001807D7BE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D7BE0-0x00000001807D8050
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CanPhoneHome>d__112 : IEnumerator<object> // TypeDefIndex: 12258
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> callback; // 0x20
		public bool socketCheck; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CanPhoneHome>d__112(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D77F0-0x00000001807D7970
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D7970-0x00000001807D79C0
	}

	// Constructors
	public NetworkManager(); // 0x00000001807CBE60-0x00000001807CBEA0
	static NetworkManager(); // 0x00000001807CBD60-0x00000001807CBE60

	// Methods
	public static bool ShouldIgnoreLogginForXtCommand(string xtCmd); // 0x00000001807CBC90-0x00000001807CBD00
	public override void Init(); // 0x00000001807CAF00-0x00000001807CB1B0
	private void InstantiateServices(); // 0x00000001803774A0-0x00000001803774B0
	public override void MOnDestroy(); // 0x00000001807CB550-0x00000001807CB630
	public override void MUpdate(); // 0x00000001807CB630-0x00000001807CB690
	public void External_OnApplicationPause(bool inPaused); // 0x00000001807CA720-0x00000001807CA8B0
	public void OnApplicationPause(bool inPaused); // 0x00000001807CB690-0x00000001807CB6A0
	private void FocusChange(bool inPaused); // 0x00000001807CA8B0-0x00000001807CAB60
	[AsyncStateMachine] // 0x0000000180264AD0-0x0000000180264B20
	public static Task InitFakeServer(); // 0x00000001807CAE40-0x00000001807CAF00
	public static void InitializeConnections(); // 0x00000001807CB1B0-0x00000001807CB3E0
	public static void ConnectConnections(); // 0x00000001807CA3E0-0x00000001807CA480
	[AsyncStateMachine] // 0x0000000180264D40-0x0000000180264D90
	public static void Disconnect(DisconnectReason reason); // 0x00000001807CA5B0-0x00000001807CA660
	[AsyncStateMachine] // 0x0000000180266250-0x00000001802662A0
	public static Task DisconnectAsync(DisconnectReason reason); // 0x00000001807CA4E0-0x00000001807CA5B0
	public static void Logout(bool clearToken = false /* Metadata: 0x007B96CC */); // 0x00000001807CB3E0-0x00000001807CB550
	public static void SwitchServer(string newHost); // 0x00000001807CBD00-0x00000001807CBD60
	public static INetMessageWriter CreateOutgoingMessage(XtCmd cmd); // 0x00000001807CA480-0x00000001807CA4E0
	public static void SendServerMessage(XtCmd cmd); // 0x00000001807CB900-0x00000001807CB9E0
	public static void SendServerMessage(INetMessageWriter message); // 0x00000001807CB9E0-0x00000001807CBA90
	public static void SendChatServiceRequest(PersistentServiceRequest req); // 0x00000001807CB820-0x00000001807CB900
	private void OnServerConnectionLost(ServerConnectionLostMessage m); // 0x00000001807CB6A0-0x00000001807CB820
	[IteratorStateMachine] // 0x00000001802665C0-0x0000000180266610
	private IEnumerator ServerConnectionLostLogic(); // 0x00000001807CBA90-0x00000001807CBAF0
	[IteratorStateMachine] // 0x00000001802666F0-0x0000000180266740
	public static IEnumerator CanReachInternet(Action<bool> callback); // 0x00000001807CA1F0-0x00000001807CA250
	[IteratorStateMachine] // 0x0000000180266860-0x00000001802668B0
	public static IEnumerator CanPhoneHome(Action<bool> callback, bool socketCheck = true /* Metadata: 0x007B96CD */); // 0x00000001807CA180-0x00000001807CA1F0
	public static string EncryptPassword(string inPassword, bool encrypt); // 0x00000001807CA660-0x00000001807CA720
	public static string HashDeveloperPassword(string inPassword, bool hash); // 0x00000001807CACD0-0x00000001807CAE40
	public void SetEnvironment(FeralServerEnvironment env); // 0x00000001807CBAF0-0x00000001807CBBE0
	public static string GetIPAddress(); // 0x00000001807CAB60-0x00000001807CACD0
	public static void ClearSavedToken(); // 0x00000001803774A0-0x00000001803774B0
	public static void ClearSavedLoginInfo(); // 0x00000001803774A0-0x00000001803774B0
	public void SetLoginTime(long inServerTime); // 0x00000001807CBBE0-0x00000001807CBC90
	private static bool CheckDeviceConnection(Action<bool> callback); // 0x00000001807CA250-0x00000001807CA3E0
}

