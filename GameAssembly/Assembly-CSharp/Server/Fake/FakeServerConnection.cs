/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server.Fake
{
	public class FakeServerConnection : ServerConnection // TypeDefIndex: 16053
	{
		// Fields
		private FakeServer _fakeServer; // 0x40
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 16054
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180EC90D0-0x0000000180EC9130
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <Connect>b__3_0(); // 0x0000000180EC8910-0x0000000180EC89A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <DisconnectAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 16055
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder <>t__builder; // 0x08
			private TaskAwaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x00000001801F08F0-0x00000001801F0900
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Login>d__5 : IAsyncStateMachine // TypeDefIndex: 16056
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder<ServerLoginResponse> <>t__builder; // 0x08
			public string username; // 0x20
			public FakeServerConnection <>4__this; // 0x28
			private ServerLoginResponse <loginMessage>5__2; // 0x30
			private TaskAwaiter <>u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x00000001801F0990-0x00000001801F09A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F09A0-0x00000001801F09F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <Logout>d__6 : IAsyncStateMachine // TypeDefIndex: 16057
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncVoidMethodBuilder <>t__builder; // 0x08
			public FakeServerConnection <>4__this; // 0x28
			private TaskAwaiter <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001801F09F0-0x00000001801F0A00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
		}
	
		// Constructors
		public FakeServerConnection(FeralServerEnvironment env); // 0x0000000180EB5510-0x0000000180EB5550
	
		// Methods
		public override void Init(FeralServerEnvironment env); // 0x0000000180EB5100-0x0000000180EB5160
		public override Task<bool> Connect(string host); // 0x0000000180EB4F30-0x0000000180EB5040
		[AsyncStateMachine] // 0x00000001800F64C0-0x00000001800F6510
		public override Task DisconnectAsync(); // 0x0000000180EB5040-0x0000000180EB5100
		[AsyncStateMachine] // 0x00000001800F68F0-0x00000001800F6940
		public override Task<ServerLoginResponse> Login(string username, string authToken, int sessionId); // 0x0000000180EB5160-0x0000000180EB5250
		[AsyncStateMachine] // 0x00000001800F6B50-0x00000001800F6BA0
		public override void Logout(); // 0x0000000180EB5250-0x0000000180EB5300
		public override void Switching(); // 0x00000001803581E0-0x00000001803581F0
		public override void Send(INetMessageWriter message); // 0x0000000180EB5300-0x0000000180EB5510
		public override void ProcessEventQueue(); // 0x00000001803581E0-0x00000001803581F0
	}
}
