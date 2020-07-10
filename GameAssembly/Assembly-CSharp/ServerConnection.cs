/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class ServerConnection // TypeDefIndex: 10967
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ConnectionState <State>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <UserId>k__BackingField; // 0x14
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <Cipher>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <RemoteAddress>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralServerEnvironment <Environment>k__BackingField; // 0x28
	public int RoomId; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <RoomDefId>k__BackingField; // 0x38

	// Properties
	public ConnectionState State { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
	public virtual bool IsConnected { get; } // 0x0000000180EBFE20-0x0000000180EBFE30 
	public virtual bool IsLoggedIn { get; } // 0x0000000180EBFE30-0x0000000180EBFE40 
	public int UserId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
	public string Cipher { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public string RemoteAddress { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	public FeralServerEnvironment Environment { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	public string RoomDefId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830

	// Nested types
	public enum ConnectionState // TypeDefIndex: 10968
	{
		None = 0,
		Disconnecting = 1,
		Connecting = 2,
		Connected = 3,
		LoggingIn = 4,
		LoggedIn = 5,
		Switching = 6
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Disconnect>d__38 : IAsyncStateMachine // TypeDefIndex: 10969
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ServerConnection <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0900-0x00000001801F0910
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	protected ServerConnection(); // 0x0000000180EBFE10-0x0000000180EBFE20

	// Methods
	public abstract void Init(FeralServerEnvironment environment);
	public abstract Task<bool> Connect(string remoteAddress);
	public abstract Task DisconnectAsync();
	public abstract Task<ServerLoginResponse> Login(string username, string loginToken, int sessionId);
	public abstract void Logout();
	public abstract void Switching();
	public abstract void ProcessEventQueue();
	public abstract void Send(INetMessageWriter data);
	[AsyncStateMachine] // 0x00000001800FDD50-0x00000001800FDDA0
	public virtual void Disconnect(); // 0x0000000180EBFD60-0x0000000180EBFE10
}

