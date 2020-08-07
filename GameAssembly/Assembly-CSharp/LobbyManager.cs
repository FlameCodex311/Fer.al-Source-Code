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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LobbyManager : SingletonManagerBase<LobbyManager> // TypeDefIndex: 11806
{
	// Nested types
	public enum ELobbyType // TypeDefIndex: 11807
	{
		MINIGAME_JOIN = 1,
		QUEST_ROOM_JOIN = 2
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_LobbyCreate>d__5 : IEnumerator<object> // TypeDefIndex: 11808
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28
		public string inAssocDefID; // 0x30
		public Action onCompleteCallback; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_LobbyCreate>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5D980-0x0000000180C5DAA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5DAA0-0x0000000180C5DAF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerLobbyCreate>d__6 : IAsyncStateMachine // TypeDefIndex: 11809
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
		private void MoveNext(); // 0x0000000180064140-0x0000000180064150
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_LobbyJoin>d__8 : IEnumerator<object> // TypeDefIndex: 11810
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28
		public string inHostUUID; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_LobbyJoin>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5DAF0-0x0000000180C5DC00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5DC00-0x0000000180C5DC50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerLobbyJoin>d__9 : IAsyncStateMachine // TypeDefIndex: 11811
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ELobbyType inType; // 0x28
		public string inHostUUID; // 0x30
		public LobbyManager <>4__this; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180064150-0x0000000180064160
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_LobbyLeave>d__11 : IEnumerator<object> // TypeDefIndex: 11812
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_LobbyLeave>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5DC50-0x0000000180C5DD50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5DD50-0x0000000180C5DDA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerLobbyLeave>d__12 : IAsyncStateMachine // TypeDefIndex: 11813
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ELobbyType inType; // 0x28
		public LobbyManager <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180064160-0x0000000180064170
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_LobbyStart>d__14 : IEnumerator<object> // TypeDefIndex: 11814
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LobbyManager <>4__this; // 0x20
		public ELobbyType inType; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_LobbyStart>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5DDA0-0x0000000180C5DEA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5DEA0-0x0000000180C5DEF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerLobbyStart>d__15 : IAsyncStateMachine // TypeDefIndex: 11815
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ELobbyType inType; // 0x28
		public LobbyManager <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180064170-0x0000000180064290
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public LobbyManager(); // 0x0000000180C59940-0x0000000180C59980

	// Methods
	public override void MStart(); // 0x0000000180C593B0-0x0000000180C59420
	public override void MOnDestroy(); // 0x0000000180C59340-0x0000000180C593B0
	private void SceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode); // 0x00000001803774A0-0x00000001803774B0
	public Coroutine LobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback); // 0x0000000180C590A0-0x0000000180C59150
	[IteratorStateMachine] // 0x00000001802719A0-0x00000001802719F0
	private IEnumerator _LobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback); // 0x0000000180C59750-0x0000000180C597E0
	[AsyncStateMachine] // 0x0000000180271C40-0x0000000180271C90
	private void RequestServerLobbyCreate(ELobbyType inType, string inAssocDefID, Action onCompleteCallback); // 0x0000000180C59420-0x0000000180C59500
	public Coroutine LobbyJoin(ELobbyType inType, string inHostUUID); // 0x0000000180C59150-0x0000000180C59200
	[IteratorStateMachine] // 0x0000000180271F90-0x0000000180271FE0
	private IEnumerator _LobbyJoin(ELobbyType inType, string inHostUUID); // 0x0000000180C597E0-0x0000000180C59860
	[AsyncStateMachine] // 0x00000001802722D0-0x0000000180272320
	private void RequestServerLobbyJoin(ELobbyType inType, string inHostUUID); // 0x0000000180C59500-0x0000000180C595D0
	public Coroutine LobbyLeave(ELobbyType inType); // 0x0000000180C59200-0x0000000180C592A0
	[IteratorStateMachine] // 0x0000000180272600-0x0000000180272650
	private IEnumerator _LobbyLeave(ELobbyType inType); // 0x0000000180C59860-0x0000000180C598D0
	[AsyncStateMachine] // 0x00000001802728C0-0x0000000180272910
	private void RequestServerLobbyLeave(ELobbyType inType); // 0x0000000180C595D0-0x0000000180C59690
	public Coroutine LobbyStart(ELobbyType inType); // 0x0000000180C592A0-0x0000000180C59340
	[IteratorStateMachine] // 0x0000000180273E30-0x0000000180273E80
	private IEnumerator _LobbyStart(ELobbyType inType); // 0x0000000180C598D0-0x0000000180C59940
	[AsyncStateMachine] // 0x0000000180274000-0x0000000180274050
	private void RequestServerLobbyStart(ELobbyType inType); // 0x0000000180C59690-0x0000000180C59750
	private void OnLobbyCreateSuccessResponse(RequestLobbyCreateSuccessMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnLobbyCreateFailureResponse(RequestLobbyCreateFailedMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnLobbyJoinSuccessResponse(RequestLobbyJoinSuccessMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnLobbyJoinFailureResponse(RequestLobbyJoinFailedMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnLobbyLeaveSuccessResponse(RequestLobbyLeaveSuccessMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnLobbyLeaveFailureResponse(RequestLobbyLeaveFailedMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnLobbyStartFailureResponse(RequestLobbyStartFailedMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	internal static void HandleLobbyJoinResponse(XtReader data); // 0x0000000180C58FE0-0x0000000180C590A0
}

