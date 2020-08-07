/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server.Fake
{
	public class FakeServerConnection : ServerConnection // TypeDefIndex: 14440
	{
		// Fields
		private FakeServer _fakeServer; // 0x40
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14441
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180405FC0-0x0000000180406020
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <Connect>b__3_0(); // 0x0000000180405960-0x00000001804059F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <DisconnectAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 14442
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder <>t__builder; // 0x08
			private TaskAwaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x00000001800029D0-0x00000001800029E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Login>d__5 : IAsyncStateMachine // TypeDefIndex: 14443
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder<ServerLoginResponse> <>t__builder; // 0x08
			public string username; // 0x20
			public FakeServerConnection <>4__this; // 0x28
			private ServerLoginResponse <loginMessage>5__2; // 0x30
			private TaskAwaiter <>u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x0000000180002AD0-0x0000000180002AE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002AE0-0x0000000180002B30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <Logout>d__6 : IAsyncStateMachine // TypeDefIndex: 14444
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncVoidMethodBuilder <>t__builder; // 0x08
			public FakeServerConnection <>4__this; // 0x28
			private TaskAwaiter <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000180002B30-0x0000000180002B40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
		}
	
		// Constructors
		public FakeServerConnection(FeralServerEnvironment env); // 0x00000001803F3FC0-0x00000001803F4000
	
		// Methods
		public override void Init(FeralServerEnvironment env); // 0x00000001803F3BC0-0x00000001803F3C20
		public override Task<bool> Connect(string host); // 0x00000001803F39F0-0x00000001803F3B00
		[AsyncStateMachine] // 0x000000018023A4F0-0x000000018023A540
		public override Task DisconnectAsync(); // 0x00000001803F3B00-0x00000001803F3BC0
		[AsyncStateMachine] // 0x000000018023A7F0-0x000000018023A840
		public override Task<ServerLoginResponse> Login(string username, string authToken, int sessionId); // 0x00000001803F3C20-0x00000001803F3D10
		[AsyncStateMachine] // 0x000000018023A9E0-0x000000018023AA30
		public override void Logout(); // 0x00000001803F3D10-0x00000001803F3DC0
		public override void Switching(); // 0x00000001803774A0-0x00000001803774B0
		public override void Send(INetMessageWriter message); // 0x00000001803F3DC0-0x00000001803F3FC0
		public override void ProcessEventQueue(); // 0x00000001803774A0-0x00000001803774B0
	}
}
