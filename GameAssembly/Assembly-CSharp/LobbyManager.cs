/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class LobbyManager : SingletonManagerBase<LobbyManager> // TypeDefIndex: 10316
{
	// Nested types
	public enum ELobbyType // TypeDefIndex: 10317
	{
		MINIGAME_JOIN = 1,
		QUEST_ROOM_JOIN = 2
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_LobbyCreate>d__5 : IEnumerator<object> // TypeDefIndex: 10318
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28
		public string inAssocDefID; // 0x30
		public Action onCompleteCallback; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_LobbyCreate>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F6AA0-0x00000001811F6BD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F6BD0-0x00000001811F6C20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerLobbyCreate>d__6 : IAsyncStateMachine // TypeDefIndex: 10319
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ELobbyType inType; // 0x28
		public string inAssocDefID; // 0x30
		public LobbyManager <>4__this; // 0x38
		public Action onCompleteCallback; // 0x40
		private TaskAwaiter <>u__1; // 0x48

		// Methods
		private void MoveNext(); // 0x000000018020E940-0x000000018020E950
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_LobbyJoin>d__8 : IEnumerator<object> // TypeDefIndex: 10320
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28
		public string inHostUUID; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_LobbyJoin>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F6C20-0x00000001811F6D30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F6D30-0x00000001811F6D80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerLobbyJoin>d__9 : IAsyncStateMachine // TypeDefIndex: 10321
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ELobbyType inType; // 0x28
		public string inHostUUID; // 0x30
		public LobbyManager <>4__this; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018020E950-0x000000018020E960
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_LobbyLeave>d__11 : IEnumerator<object> // TypeDefIndex: 10322
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_LobbyLeave>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F6D80-0x00000001811F6E80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F6E80-0x00000001811F6ED0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerLobbyLeave>d__12 : IAsyncStateMachine // TypeDefIndex: 10323
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ELobbyType inType; // 0x28
		public LobbyManager <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020E960-0x000000018020E970
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_LobbyStart>d__14 : IEnumerator<object> // TypeDefIndex: 10324
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_LobbyStart>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F6ED0-0x00000001811F6FD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F6FD0-0x00000001811F7020
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerLobbyStart>d__15 : IAsyncStateMachine // TypeDefIndex: 10325
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ELobbyType inType; // 0x28
		public LobbyManager <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020E970-0x000000018020EA00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public LobbyManager(); // 0x00000001811E60E0-0x00000001811E6120

	// Methods
	public override void MStart(); // 0x00000001811E5B50-0x00000001811E5BC0
	public override void MOnDestroy(); // 0x00000001811E5AE0-0x00000001811E5B50
	private void SceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode); // 0x00000001803581E0-0x00000001803581F0
	public Coroutine LobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback); // 0x00000001811E5840-0x00000001811E58F0
	[IteratorStateMachine] // 0x00000001800DED20-0x00000001800DED70
	private IEnumerator _LobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback); // 0x00000001811E5EF0-0x00000001811E5F80
	[AsyncStateMachine] // 0x00000001800DF010-0x00000001800DF060
	private void RequestServerLobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback); // 0x00000001811E5BC0-0x00000001811E5CA0
	public Coroutine LobbyJoin(ELobbyType inType, string inHostUUID); // 0x00000001811E58F0-0x00000001811E59A0
	[IteratorStateMachine] // 0x00000001800DF310-0x00000001800DF360
	private IEnumerator _LobbyJoin(ELobbyType inType, string inHostUUID); // 0x00000001811E5F80-0x00000001811E6000
	[AsyncStateMachine] // 0x00000001800DF6A0-0x00000001800DF6F0
	private void RequestServerLobbyJoin(ELobbyType inType, string inHostUUID); // 0x00000001811E5CA0-0x00000001811E5D70
	public Coroutine LobbyLeave(ELobbyType inType); // 0x00000001811E59A0-0x00000001811E5A40
	[IteratorStateMachine] // 0x00000001800DFA80-0x00000001800DFAD0
	private IEnumerator _LobbyLeave(ELobbyType inType); // 0x00000001811E6000-0x00000001811E6070
	[AsyncStateMachine] // 0x00000001800DFCB0-0x00000001800DFD00
	private void RequestServerLobbyLeave(ELobbyType inType); // 0x00000001811E5D70-0x00000001811E5E30
	public Coroutine LobbyStart(ELobbyType inType); // 0x00000001811E5A40-0x00000001811E5AE0
	[IteratorStateMachine] // 0x00000001800DFEB0-0x00000001800DFF00
	private IEnumerator _LobbyStart(ELobbyType inType); // 0x00000001811E6070-0x00000001811E60E0
	[AsyncStateMachine] // 0x00000001800E0070-0x00000001800E00C0
	private void RequestServerLobbyStart(ELobbyType inType); // 0x00000001811E5E30-0x00000001811E5EF0
	private void OnLobbyCreateSuccessResponse(RequestLobbyCreateSuccessMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnLobbyCreateFailureResponse(RequestLobbyCreateFailedMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnLobbyJoinSuccessResponse(RequestLobbyJoinSuccessMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnLobbyJoinFailureResponse(RequestLobbyJoinFailedMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnLobbyLeaveSuccessResponse(RequestLobbyLeaveSuccessMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnLobbyLeaveFailureResponse(RequestLobbyLeaveFailedMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnLobbyStartFailureResponse(RequestLobbyStartFailedMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	internal static void HandleLobbyJoinResponse(XtReader data); // 0x00000001811E5780-0x00000001811E5840
}

