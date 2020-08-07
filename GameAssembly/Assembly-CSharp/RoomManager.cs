/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RoomManager : SingletonManagerBase<RoomManager> // TypeDefIndex: 11829
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LevelDefComponent <CurrentLevelDef>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LevelDefComponent <PreviousLevelDef>k__BackingField; // 0x68
	private bool _requestedRoomJoinFromServer; // 0x70
	public ELevelType debugFakeServerLevelType; // 0x74
	private bool _lastTeleportFromWorldMap; // 0x78
	public LevelDefComponent.WorldMapInfo worldMapInfo; // 0x80
	public Vector3? initCurrentLevelSpawnPosition; // 0x88
	public Quaternion? initCurrentLevelSpawnRotation; // 0x98
	private Coroutine _progressBarRoutine; // 0xB0
	private Coroutine _loadLevelRoutine; // 0xB8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsLevelFinishedLoading>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform <FailRoomJoinSpawnPoint>k__BackingField; // 0xC8
	private bool _ignoreNextRJ; // 0xD0
	private Coroutine _levelLoadServerTimeout; // 0xD8
	private AnalyticLevel _currentAnalyticLevel; // 0xE0

	// Properties
	public LevelDefComponent CurrentLevelDef { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
	public string CurrentLevelDefID { get; private set; } // 0x00000001804AF3B0-0x00000001804AF400 0x00000001804AF4A0-0x00000001804AF510
	public LevelDefComponent PreviousLevelDef { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
	public string PreviousLevelDefID { get; private set; } // 0x00000001804AF450-0x00000001804AF4A0 0x00000001804AF540-0x00000001804AF5B0
	public bool IsLevelFinishedLoading { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804AF410-0x00000001804AF420 0x00000001804AF530-0x00000001804AF540
	public bool IsWorld { get; } // 0x00000001804AF420-0x00000001804AF450 
	public Transform FailRoomJoinSpawnPoint { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530

	// Nested types
	private class AnalyticLevel // TypeDefIndex: 11830
	{
		// Fields
		public string defName; // 0x10
		public EValue value; // 0x18

		// Nested types
		public enum EValue // TypeDefIndex: 11831
		{
			WORLDMAP = 0,
			NAVIGATION = 1,
			LOGIN = 2,
			MINIGAME = 3
		}

		// Constructors
		public AnalyticLevel(); // 0x00000001804A9590-0x00000001804A95F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 11832
	{
		// Fields
		public bool? response; // 0x10

		// Constructors
		public <>c__DisplayClass17_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ConfirmLeaveLevel>b__0(bool inResponse); // 0x00000001804BC850-0x00000001804BC8B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <ConfirmLeaveLevel>d__17 : IAsyncStateMachine // TypeDefIndex: 11833
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		private <>c__DisplayClass17_0 <>8__1; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001800052A0-0x00000001800052B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800052B0-0x0000000180005300
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__36 : IEnumerator<object> // TypeDefIndex: 11834
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__36(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B8430-0x00000001804B8770
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B8770-0x00000001804B87C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass40_0 // TypeDefIndex: 11835
	{
		// Fields
		public UI_Window_Login window; // 0x10

		// Constructors
		public <>c__DisplayClass40_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DoDebugLogin>b__3(UI_Window_Login w); // 0x0000000180379F20-0x0000000180379F30
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11836
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<RoomJoinFailedMessage> <>9__40_2; // 0x08

		// Constructors
		static <>c(); // 0x00000001804BC940-0x00000001804BE160
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DoDebugLogin>b__40_2(RoomJoinFailedMessage fail); // 0x00000001803774A0-0x00000001803774B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoDebugLogin>d__40 : IAsyncStateMachine // TypeDefIndex: 11837
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private <>c__DisplayClass40_0 <>8__1; // 0x28
		public RoomManager <>4__this; // 0x30
		private TaskAwaiter<LoginMessage> <>u__1; // 0x38
		private TaskAwaiter <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180005300-0x0000000180005310
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForLoadingScreen>d__41 : IEnumerator<object> // TypeDefIndex: 11838
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public Action onComplete; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForLoadingScreen>d__41(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804BE3E0-0x00000001804BE490
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804BE490-0x00000001804BE4E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass42_0 // TypeDefIndex: 11839
	{
		// Fields
		public RoomManager <>4__this; // 0x10
		public RoomJoinSuccessMessage inMessage; // 0x18

		// Constructors
		public <>c__DisplayClass42_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnRoomJoinSuccessResponse>b__0(); // 0x00000001804BC8B0-0x00000001804BC8E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <TeleportToLevel>d__47 : IAsyncStateMachine // TypeDefIndex: 11840
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RoomManager <>4__this; // 0x28
		public LevelDefComponent.WorldMapInfo inWorldMapInfo; // 0x30
		public bool inFromWorldMap; // 0x38
		public string inDefID; // 0x40
		public bool inCheckAlreadyInLevel; // 0x48
		public bool inExpanse; // 0x49
		private TaskAwaiter<bool> <>u__1; // 0x50

		// Methods
		private void MoveNext(); // 0x0000000180005620-0x0000000180005630
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_LoadLevel>d__50 : IEnumerator<object> // TypeDefIndex: 11841
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public string inDefID; // 0x28
		private LevelDefComponent <levelDef>5__2; // 0x30
		private Task<LoginMessage> <loginWithTokenResultTask>5__3; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_LoadLevel>d__50(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804BE4E0-0x00000001804BEAD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804BEAD0-0x00000001804BEB20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadLevelAdditiveRoutine>d__54 : IEnumerator<object> // TypeDefIndex: 11842
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inDefID; // 0x20
		private LevelDefComponent <levelDef>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadLevelAdditiveRoutine>d__54(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B9220-0x00000001804B93A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B93A0-0x00000001804B93F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DownloadProgress>d__55 : IEnumerator<object> // TypeDefIndex: 11843
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DownloadProgress>d__55(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B7200-0x00000001804B8430
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ActuallyLoadLevel>d__56 : IEnumerator<object> // TypeDefIndex: 11844
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public LevelDefComponent inLevelDef; // 0x28
		public RoomJoinMessage roomJoinMessage; // 0x30
		private Transform <tSpawnPoint>5__2; // 0x38
		private string <jumpToUserId>5__3; // 0x40
		private int <ii>5__4; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ActuallyLoadLevel>d__56(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B47F0-0x00000001804B5820
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B5820-0x00000001804B5BB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadEmptyLevel>d__57 : IEnumerator<object> // TypeDefIndex: 11845
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadEmptyLevel>d__57(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B9020-0x00000001804B91D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B91D0-0x00000001804B9220
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoTimeoutServerResponseForLevelLoadCoroutine>d__61 : IEnumerator<object> // TypeDefIndex: 11846
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoTimeoutServerResponseForLevelLoadCoroutine>d__61(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B7080-0x00000001804B71B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B71B0-0x00000001804B7200
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCurrentLevelFromFakeServer>d__63 : IEnumerator<object> // TypeDefIndex: 11847
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private int <ii>5__2; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCurrentLevelFromFakeServer>d__63(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B87C0-0x00000001804B8C80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B8C80-0x00000001804B8CD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCurrentLevel>d__64 : IEnumerator<object> // TypeDefIndex: 11848
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public Transform tSpawnPoint; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCurrentLevel>d__64(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B8CD0-0x00000001804B8FD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B8FD0-0x00000001804B9020
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForCurrentLevelThingsToFinish>d__65 : IEnumerator<object> // TypeDefIndex: 11849
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForCurrentLevelThingsToFinish>d__65(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804BE160-0x00000001804BE390
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804BE390-0x00000001804BE3E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <<DoDebugLogin>g__waitForAvatar|40_0>d : IEnumerator<object> // TypeDefIndex: 11850
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <<DoDebugLogin>g__waitForAvatar|40_0>d(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804BC350-0x00000001804BC470
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804BC470-0x00000001804BC4C0
	}

	// Constructors
	public RoomManager(); // 0x00000001804AF370-0x00000001804AF3B0

	// Methods
	public static void LoadLevelSingle(string inLevelName); // 0x00000001804AE140-0x00000001804AE150
	public static void LoadLevelAdditive(string inLevelName); // 0x00000001804AE130-0x00000001804AE140
	[AsyncStateMachine] // 0x000000018027C490-0x000000018027C4E0
	public static Task<bool> ConfirmLeaveLevel(); // 0x00000001804ADD00-0x00000001804ADDD0
	public override bool HasInitCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	[IteratorStateMachine] // 0x000000018027CC50-0x000000018027CCA0
	public override IEnumerator InitCoroutine(); // 0x00000001804ADF50-0x00000001804ADFB0
	public override void Deinit(); // 0x00000001804ADDD0-0x00000001804ADDF0
	public override void MStart(); // 0x00000001804AE200-0x00000001804AE410
	[AsyncStateMachine] // 0x000000018027CED0-0x000000018027CF20
	public void DoDebugLogin(); // 0x00000001804ADDF0-0x00000001804ADEA0
	[IteratorStateMachine] // 0x000000018027D130-0x000000018027D180
	private IEnumerator WaitForLoadingScreen(Action onComplete); // 0x00000001804AF290-0x00000001804AF300
	private void OnRoomJoinSuccessResponse(RoomJoinSuccessMessage inMessage); // 0x00000001804AE520-0x00000001804AE650
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage message); // 0x00000001804AE650-0x00000001804AE8D0
	private void OnRoomJoinFailedResponse(RoomJoinFailedMessage inMessage); // 0x00000001804AE4C0-0x00000001804AE520
	private void Server_OnMinigameJoin(MinigameJoinMessage message); // 0x00000001804AECE0-0x00000001804AED50
	public void LoadPreviousLevel(); // 0x00000001804AE1F0-0x00000001804AE200
	[AsyncStateMachine] // 0x000000018027D460-0x000000018027D4B0
	public void TeleportToLevel(string inDefID, bool inFromWorldMap, bool inCheckAlreadyInLevel, bool inExpanse, LevelDefComponent.WorldMapInfo inWorldMapInfo); // 0x00000001804AF060-0x00000001804AF170
	[DebugButton] // 0x000000018027D740-0x000000018027D7A0
	public Coroutine LoadLevel(string inLevelDefID); // 0x00000001804AE150-0x00000001804AE1F0
	private void ShowLoadingScreen(); // 0x00000001804AEE80-0x00000001804AEF40
	[IteratorStateMachine] // 0x000000018027D970-0x000000018027D9C0
	private IEnumerator _LoadLevel(string inDefID); // 0x00000001804AF300-0x00000001804AF370
	private void RequestServerRoomJoin(LevelDefComponent inLevelDef); // 0x00000001804AE950-0x00000001804AEC10
	public Coroutine AddLevel(string inLevelDefID); // 0x00000001804ADC70-0x00000001804ADD00
	public void RemoveLevel(string inLevelDefID); // 0x00000001804AE8D0-0x00000001804AE950
	[IteratorStateMachine] // 0x000000018027DBC0-0x000000018027DC10
	private IEnumerator LoadLevelAdditiveRoutine(string inDefID); // 0x00000001804AE0D0-0x00000001804AE130
	[IteratorStateMachine] // 0x000000018027DED0-0x000000018027DF20
	private IEnumerator DownloadProgress(ManifestDef inManifestDef); // 0x00000001804ADF00-0x00000001804ADF50
	[IteratorStateMachine] // 0x000000018027E110-0x000000018027E160
	public IEnumerator ActuallyLoadLevel(LevelDefComponent inLevelDef, RoomJoinMessage roomJoinMessage); // 0x00000001804ADBF0-0x00000001804ADC70
	[IteratorStateMachine] // 0x000000018027F6C0-0x000000018027F710
	public IEnumerator LoadEmptyLevel(); // 0x00000001804AE070-0x00000001804AE0D0
	private void StartTimeoutForServerResponseOnLevelLoad(); // 0x00000001804AEF40-0x00000001804AF010
	private void StopTimeoutForServerResponseOnLevelLoad(); // 0x00000001804AF010-0x00000001804AF060
	[IteratorStateMachine] // 0x000000018027F880-0x000000018027F8D0
	private IEnumerator DoTimeoutServerResponseForLevelLoadCoroutine(); // 0x00000001804ADEA0-0x00000001804ADF00
	private void OnLoadLevelTimeoutClosed(); // 0x00000001804AE410-0x00000001804AE4C0
	[IteratorStateMachine] // 0x000000018027FDA0-0x000000018027FDF0
	public static IEnumerator InitCurrentLevelFromFakeServer(); // 0x00000001804ADFB0-0x00000001804AE000
	[IteratorStateMachine] // 0x000000018027FF00-0x000000018027FF50
	private IEnumerator InitCurrentLevel(Transform tSpawnPoint); // 0x00000001804AE000-0x00000001804AE070
	[IteratorStateMachine] // 0x00000001802800E0-0x0000000180280130
	private IEnumerator WaitForCurrentLevelThingsToFinish(); // 0x00000001804AF240-0x00000001804AF290
	private void ResetTouchableLayerMode(); // 0x00000001803774A0-0x00000001803774B0
	private void ResetPlayerCameraMode(); // 0x00000001804AEC10-0x00000001804AECE0
	private void SendCurrentAnalyticsLevel(); // 0x00000001803774A0-0x00000001803774B0
	private void SetCurrentAnalyticsLevel(); // 0x00000001804AED50-0x00000001804AEE80
	[CompilerGenerated] // 0x0000000180280240-0x00000001802802B0
	[IteratorStateMachine] // 0x0000000180280240-0x00000001802802B0
	internal static IEnumerator <DoDebugLogin>g__waitForAvatar|40_0(); // 0x00000001804AF1F0-0x00000001804AF240
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDebugLogin>b__40_1(RoomJoinSuccessMessage success); // 0x00000001804AF170-0x00000001804AF1F0
}

