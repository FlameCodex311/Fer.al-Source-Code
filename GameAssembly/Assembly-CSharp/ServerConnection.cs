/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class ServerConnection // TypeDefIndex: 12490
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ConnectionState <State>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <UserId>k__BackingField; // 0x14
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <Cipher>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <RemoteAddress>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralServerEnvironment <Environment>k__BackingField; // 0x28
	public int RoomId; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <RoomDefId>k__BackingField; // 0x38

	// Properties
	public ConnectionState State { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
	public virtual bool IsConnected { get; } // 0x00000001803FEB40-0x00000001803FEB50 
	public virtual bool IsLoggedIn { get; } // 0x00000001803FEB50-0x00000001803FEB60 
	public int UserId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
	public string Cipher { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	public string RemoteAddress { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	public FeralServerEnvironment Environment { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	public string RoomDefId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70

	// Nested types
	public enum ConnectionState // TypeDefIndex: 12491
	{
		None = 0,
		Disconnecting = 1,
		Connecting = 2,
		Connected = 3,
		LoggingIn = 4,
		LoggedIn = 5,
		Switching = 6
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Disconnect>d__38 : IAsyncStateMachine // TypeDefIndex: 12492
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ServerConnection <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800029E0-0x00000001800029F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	protected ServerConnection(); // 0x00000001803FEB30-0x00000001803FEB40

	// Methods
	public abstract void Init(FeralServerEnvironment environment);
	public abstract Task<bool> Connect(string remoteAddress);
	public abstract Task DisconnectAsync();
	public abstract Task<ServerLoginResponse> Login(string username, string loginToken, int sessionId);
	public abstract void Logout();
	public abstract void Switching();
	public abstract void ProcessEventQueue();
	public abstract void Send(INetMessageWriter data);
	[AsyncStateMachine] // 0x00000001801D6F90-0x00000001801D6FE0
	public virtual void Disconnect(); // 0x00000001803FEA80-0x00000001803FEB30
}

