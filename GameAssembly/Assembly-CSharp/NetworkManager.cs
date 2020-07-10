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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public class NetworkManager : SingletonManagerBase<NetworkManager> // TypeDefIndex: 10740
{
	// Fields
	public const string WebRegion = "US"; // Metadata: 0x0078200F
	public bool LogMovementCommands; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<string> _ignoreLoggingXtCmds; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ServerDeployState _serverDeployState; // 0x70
	public static AutoLoginState AutoLogin; // 0x00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static string <AutoLoginRoomName>k__BackingField; // 0x08
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static string <AutoLoginBuddyName>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private DateTime <LastMaintenanceMode>k__BackingField; // 0x78
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static DisconnectReason <DisconnectReason>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
	public static ServerConnection ServerConnection { get; private set; } // 0x00000001812E6D90-0x00000001812E6DE0 0x00000001812E7530-0x00000001812E7580
	public static bool IsConnected { get; } // 0x00000001812E6770-0x00000001812E6810 
	public static bool IsLoggedIn { get; } // 0x00000001812E6970-0x00000001812E6A10 
	public static bool IsFakeServer { get; } // 0x00000001812E68A0-0x00000001812E6970 
	public static ChatServiceConnection ChatServiceConnection { get; private set; } // 0x00000001812E64C0-0x00000001812E6510 0x00000001812E71B0-0x00000001812E7200
	public static bool IsDev { get; } // 0x00000001812E6810-0x00000001812E68A0 
	public static bool IsStage { get; } // 0x00000001812E6AA0-0x00000001812E6B30 
	public static bool IsProd { get; } // 0x00000001812E6A10-0x00000001812E6AA0 
	public static string AutoLoginRoomName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001812E6460-0x00000001812E64C0 0x00000001812E7150-0x00000001812E71B0
	public static string AutoLoginBuddyName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001812E6400-0x00000001812E6460 0x00000001812E70F0-0x00000001812E7150
	public DateTime LastMaintenanceMode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
	public static DisconnectReason DisconnectReason { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001812E65B0-0x00000001812E6670 0x00000001812E7250-0x00000001812E72B0
	public static int UserID { get; } // 0x00000001812E7010-0x00000001812E7090 
	public static string Username { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001812E7090-0x00000001812E70F0 0x00000001812E75D0-0x00000001812E7630
	public static int RoomID { get; set; } // 0x00000001812E6C20-0x00000001812E6D40 0x00000001812E7420-0x00000001812E7530
	public static string RoomDefID { get; set; } // 0x00000001812E6B80-0x00000001812E6C20 0x00000001812E7300-0x00000001812E7420
	public static MessageRouter Router { get; } // 0x00000001812E6D40-0x00000001812E6D90 
	public static FeralServerEnvironment Environment { get; } // 0x00000001812E6670-0x00000001812E66C0 
	public static ServerDeployState DeployState { get; set; } // 0x00000001812E6560-0x00000001812E65B0 0x00000001812E7200-0x00000001812E7250
	private static DateTimeOffset ServerTimeAtLogin { get; } // 0x00000001812E6DE0-0x00000001812E6E70 
	private static float ClientTimeAtLogin { get; } // 0x00000001812E6510-0x00000001812E6560 
	public static DateTimeOffset ServerTime { get; } // 0x00000001812E6E70-0x00000001812E6FC0 
	public static string JWT { get; set; } // 0x00000001812E6B30-0x00000001812E6B80 0x00000001812E72B0-0x00000001812E7300
	public static string UUID { get; set; } // 0x00000001812E6FC0-0x00000001812E7010 0x00000001812E7580-0x00000001812E75D0
	public static bool InternetIsReachable { get; } // 0x00000001812E66C0-0x00000001812E6770 

	// Nested types
	public enum AutoLoginState // TypeDefIndex: 10741
	{
		NoAutoLogin = 0,
		DoAutoLogin = 1,
		NodeHopAutoLogin = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10742
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__95_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001812F2F60-0x00000001812F2FC0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FocusChange>b__95_0(bool connected); // 0x00000001812F2F00-0x00000001812F2F60
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <InitFakeServer>d__96 : IAsyncStateMachine // TypeDefIndex: 10743
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x20
		private TaskAwaiter<LoginMessage> <>u__2; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180213070-0x0000000180213080
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Disconnect>d__99 : IAsyncStateMachine // TypeDefIndex: 10744
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public DisconnectReason reason; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180213060-0x0000000180213070
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DisconnectAsync>d__100 : IAsyncStateMachine // TypeDefIndex: 10745
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public DisconnectReason reason; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180213050-0x0000000180213060
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ServerConnectionLostLogic>d__108 : IEnumerator<object> // TypeDefIndex: 10746
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public NetworkManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ServerConnectionLostLogic>d__108(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F0D70-0x00000001812F1170
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F1170-0x00000001812F11C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CanReachInternet>d__111 : IEnumerator<object> // TypeDefIndex: 10747
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> callback; // 0x20
		private WWW <www>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CanReachInternet>d__111(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EC050-0x00000001812EC270
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EC270-0x00000001812EC2C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CanPhoneHome>d__112 : IEnumerator<object> // TypeDefIndex: 10748
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> callback; // 0x20
		public bool socketCheck; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CanPhoneHome>d__112(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EBE70-0x00000001812EC000
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EC000-0x00000001812EC050
	}

	// Constructors
	public NetworkManager(); // 0x00000001812E63C0-0x00000001812E6400
	static NetworkManager(); // 0x00000001812E62C0-0x00000001812E63C0

	// Methods
	public static bool ShouldIgnoreLogginForXtCommand(string xtCmd); // 0x00000001812E61F0-0x00000001812E6260
	public override void Init(); // 0x00000001812E5420-0x00000001812E56E0
	private void InstantiateServices(); // 0x00000001803581E0-0x00000001803581F0
	public override void MOnDestroy(); // 0x00000001812E5A90-0x00000001812E5B70
	public override void MUpdate(); // 0x00000001812E5B70-0x00000001812E5BD0
	public void External_OnApplicationPause(bool inPaused); // 0x00000001812E4C30-0x00000001812E4DC0
	public void OnApplicationPause(bool inPaused); // 0x00000001812E5BD0-0x00000001812E5BE0
	private void FocusChange(bool inPaused); // 0x00000001812E4DC0-0x00000001812E5070
	[AsyncStateMachine] // 0x00000001800C73C0-0x00000001800C7410
	public static Task InitFakeServer(); // 0x00000001812E5360-0x00000001812E5420
	public static void InitializeConnections(); // 0x00000001812E56E0-0x00000001812E5920
	public static void ConnectConnections(); // 0x00000001812E48E0-0x00000001812E4980
	[AsyncStateMachine] // 0x00000001800C7710-0x00000001800C7760
	public static void Disconnect(DisconnectReason reason); // 0x00000001812E4AB0-0x00000001812E4B60
	[AsyncStateMachine] // 0x00000001800C7AF0-0x00000001800C7B40
	public static Task DisconnectAsync(DisconnectReason reason); // 0x00000001812E49E0-0x00000001812E4AB0
	public static void Logout(bool clearToken = false /* Metadata: 0x0078200D */); // 0x00000001812E5920-0x00000001812E5A90
	public static void SwitchServer(string newHost); // 0x00000001812E6260-0x00000001812E62C0
	public static INetMessageWriter CreateOutgoingMessage(XtCmd cmd); // 0x00000001812E4980-0x00000001812E49E0
	public static void SendServerMessage(XtCmd cmd); // 0x00000001812E5E60-0x00000001812E5F40
	public static void SendServerMessage(INetMessageWriter message); // 0x00000001812E5F40-0x00000001812E5FF0
	public static void SendChatServiceRequest(PersistentServiceRequest req); // 0x00000001812E5D70-0x00000001812E5E60
	private void OnServerConnectionLost(ServerConnectionLostMessage m); // 0x00000001812E5BE0-0x00000001812E5D70
	[IteratorStateMachine] // 0x00000001800C7E90-0x00000001800C7EE0
	private IEnumerator ServerConnectionLostLogic(); // 0x00000001812E5FF0-0x00000001812E6050
	[IteratorStateMachine] // 0x00000001800C8340-0x00000001800C8390
	public static IEnumerator CanReachInternet(Action<bool> callback); // 0x00000001812E46F0-0x00000001812E4750
	[IteratorStateMachine] // 0x00000001800C86E0-0x00000001800C8730
	public static IEnumerator CanPhoneHome(Action<bool> callback, bool socketCheck = true /* Metadata: 0x0078200E */); // 0x00000001812E4680-0x00000001812E46F0
	public static string EncryptPassword(string inPassword, bool encrypt); // 0x00000001812E4B60-0x00000001812E4C30
	public static string HashDeveloperPassword(string inPassword, bool hash); // 0x00000001812E51F0-0x00000001812E5360
	public void SetEnvironment(FeralServerEnvironment env); // 0x00000001812E6050-0x00000001812E6140
	public static string GetIPAddress(); // 0x00000001812E5070-0x00000001812E51F0
	public static void ClearSavedToken(); // 0x00000001803581E0-0x00000001803581F0
	public static void ClearSavedLoginInfo(); // 0x00000001803581E0-0x00000001803581F0
	public void SetLoginTime(long inServerTime); // 0x00000001812E6140-0x00000001812E61F0
	private static bool CheckDeviceConnection(Action<bool> callback); // 0x00000001812E4750-0x00000001812E48E0
}

