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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RoomManager : SingletonManagerBase<RoomManager> // TypeDefIndex: 10338
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private LevelDefComponent <CurrentLevelDef>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private LevelDefComponent <PreviousLevelDef>k__BackingField; // 0x68
	private bool _requestedRoomJoinFromServer; // 0x70
	public ELevelType debugFakeServerLevelType; // 0x74
	private bool _lastTeleportFromWorldMap; // 0x78
	public LevelDefComponent.WorldMapInfo worldMapInfo; // 0x80
	public Vector3? initCurrentLevelSpawnPosition; // 0x88
	public Quaternion? initCurrentLevelSpawnRotation; // 0x98
	private Coroutine _progressBarRoutine; // 0xB0
	private Coroutine _loadLevelRoutine; // 0xB8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsLevelFinishedLoading>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform <FailRoomJoinSpawnPoint>k__BackingField; // 0xC8
	private bool _ignoreNextRJ; // 0xD0
	private Coroutine _levelLoadServerTimeout; // 0xD8
	private AnalyticLevel _currentAnalyticLevel; // 0xE0

	// Properties
	public LevelDefComponent CurrentLevelDef { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
	public string CurrentLevelDefID { get; private set; } // 0x0000000180FCDF70-0x0000000180FCDFC0 0x0000000180FCE050-0x0000000180FCE0C0
	public LevelDefComponent PreviousLevelDef { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
	public string PreviousLevelDefID { get; private set; } // 0x0000000180FCE000-0x0000000180FCE050 0x0000000180FCE0D0-0x0000000180FCE140
	public bool IsLevelFinishedLoading { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180FCDFC0-0x0000000180FCDFD0 0x0000000180FCE0C0-0x0000000180FCE0D0
	public bool IsWorld { get; } // 0x0000000180FCDFD0-0x0000000180FCE000 
	public Transform FailRoomJoinSpawnPoint { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0

	// Nested types
	private class AnalyticLevel // TypeDefIndex: 10339
	{
		// Fields
		public string defName; // 0x10
		public EValue value; // 0x18

		// Nested types
		public enum EValue // TypeDefIndex: 10340
		{
			WORLDMAP = 0,
			NAVIGATION = 1,
			LOGIN = 2,
			MINIGAME = 3
		}

		// Constructors
		public AnalyticLevel(); // 0x0000000180FC8D80-0x0000000180FC8DC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 10341
	{
		// Fields
		public bool? response; // 0x10

		// Constructors
		public <>c__DisplayClass17_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ConfirmLeaveLevel>b__0(bool inResponse); // 0x0000000180FE3F80-0x0000000180FE3FE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <ConfirmLeaveLevel>d__17 : IAsyncStateMachine // TypeDefIndex: 10342
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		private <>c__DisplayClass17_0 <>8__1; // 0x20
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F6780-0x00000001801F6790
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6790-0x00000001801F67E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__36 : IEnumerator<object> // TypeDefIndex: 10343
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE0F70-0x0000000180FE12B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE12B0-0x0000000180FE1300
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass40_0 // TypeDefIndex: 10344
	{
		// Fields
		public UI_Window_Login window; // 0x10

		// Constructors
		public <>c__DisplayClass40_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DoDebugLogin>b__3(UI_Window_Login w); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10345
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<RoomJoinSuccessMessage> <>9__40_1; // 0x08
		public static Action<RoomJoinFailedMessage> <>9__40_2; // 0x10

		// Constructors
		static <>c(); // 0x0000000180FE4300-0x0000000180FE4360
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DoDebugLogin>b__40_1(RoomJoinSuccessMessage success); // 0x0000000180FE3AE0-0x0000000180FE3AF0
		internal void <DoDebugLogin>b__40_2(RoomJoinFailedMessage fail); // 0x00000001803581E0-0x00000001803581F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DoDebugLogin>d__40 : IAsyncStateMachine // TypeDefIndex: 10346
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private <>c__DisplayClass40_0 <>8__1; // 0x28
		public RoomManager <>4__this; // 0x30
		private TaskAwaiter<LoginMessage> <>u__1; // 0x38
		private TaskAwaiter <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F67E0-0x00000001801F67F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForLoadingScreen>d__41 : IEnumerator<object> // TypeDefIndex: 10347
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public Action onComplete; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForLoadingScreen>d__41(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE4C00-0x0000000180FE4CB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE4CB0-0x0000000180FE4D00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass42_0 // TypeDefIndex: 10348
	{
		// Fields
		public RoomManager <>4__this; // 0x10
		public RoomJoinSuccessMessage inMessage; // 0x18

		// Constructors
		public <>c__DisplayClass42_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnRoomJoinSuccessResponse>b__0(); // 0x0000000180FE4270-0x0000000180FE42A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <TeleportToLevel>d__47 : IAsyncStateMachine // TypeDefIndex: 10349
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
		private void MoveNext(); // 0x00000001801F6970-0x00000001801F6980
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_LoadLevel>d__50 : IEnumerator<object> // TypeDefIndex: 10350
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public string inDefID; // 0x28
		private LevelDefComponent <levelDef>5__2; // 0x30
		private Task<LoginMessage> <loginWithTokenResultTask>5__3; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_LoadLevel>d__50(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE4D00-0x0000000180FE5300
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE5300-0x0000000180FE5350
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadLevelAdditiveRoutine>d__54 : IEnumerator<object> // TypeDefIndex: 10351
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inDefID; // 0x20
		private LevelDefComponent <levelDef>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadLevelAdditiveRoutine>d__54(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE1CD0-0x0000000180FE1E50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE1E50-0x0000000180FE1EA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DownloadProgress>d__55 : IEnumerator<object> // TypeDefIndex: 10352
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DownloadProgress>d__55(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE0C60-0x0000000180FE0F70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ActuallyLoadLevel>d__56 : IEnumerator<object> // TypeDefIndex: 10353
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public LevelDefComponent inLevelDef; // 0x28
		public RoomJoinMessage roomJoinMessage; // 0x30
		private int <ii>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ActuallyLoadLevel>d__56(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FDEA50-0x0000000180FDF280
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FDF280-0x0000000180FDF580
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadEmptyLevel>d__57 : IEnumerator<object> // TypeDefIndex: 10354
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadEmptyLevel>d__57(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE1AD0-0x0000000180FE1C80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE1C80-0x0000000180FE1CD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoTimeoutServerResponseForLevelLoadCoroutine>d__61 : IEnumerator<object> // TypeDefIndex: 10355
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoTimeoutServerResponseForLevelLoadCoroutine>d__61(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE0AE0-0x0000000180FE0C10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE0C10-0x0000000180FE0C60
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCurrentLevelFromFakeServer>d__63 : IEnumerator<object> // TypeDefIndex: 10356
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private int <ii>5__2; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCurrentLevelFromFakeServer>d__63(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE1300-0x0000000180FE16E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE16E0-0x0000000180FE1730
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCurrentLevel>d__64 : IEnumerator<object> // TypeDefIndex: 10357
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RoomManager <>4__this; // 0x20
		public RoomJoinMessage joinMessage; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCurrentLevel>d__64(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE1730-0x0000000180FE1A80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE1A80-0x0000000180FE1AD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForCurrentLevelThingsToFinish>d__65 : IEnumerator<object> // TypeDefIndex: 10358
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForCurrentLevelThingsToFinish>d__65(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE47B0-0x0000000180FE49E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE49E0-0x0000000180FE4A30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <<DoDebugLogin>g__waitForAvatar|40_0>d : IEnumerator<object> // TypeDefIndex: 10359
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <<DoDebugLogin>g__waitForAvatar|40_0>d(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE3970-0x0000000180FE3A90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE3A90-0x0000000180FE3AE0
	}

	// Constructors
	public RoomManager(); // 0x0000000180FCDF30-0x0000000180FCDF70

	// Methods
	public static void LoadLevelSingle(string inLevelName); // 0x0000000180FCCD60-0x0000000180FCCD70
	public static void LoadLevelAdditive(string inLevelName); // 0x0000000180FCCD50-0x0000000180FCCD60
	[AsyncStateMachine] // 0x00000001800E6310-0x00000001800E6360
	public static Task<bool> ConfirmLeaveLevel(); // 0x0000000180FCC940-0x0000000180FCCA10
	public override bool HasInitCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	[IteratorStateMachine] // 0x00000001800E69F0-0x00000001800E6A40
	public override IEnumerator InitCoroutine(); // 0x0000000180FCCB70-0x0000000180FCCBD0
	public override void Deinit(); // 0x0000000180E95D40-0x0000000180E95D60
	public override void MStart(); // 0x0000000180FCCE20-0x0000000180FCD030
	[AsyncStateMachine] // 0x00000001800E6BB0-0x00000001800E6C00
	public void DoDebugLogin(); // 0x0000000180FCCA10-0x0000000180FCCAC0
	[IteratorStateMachine] // 0x00000001800E6D50-0x00000001800E6DA0
	private IEnumerator WaitForLoadingScreen(Action onComplete); // 0x0000000180FCDE50-0x0000000180FCDEC0
	private void OnRoomJoinSuccessResponse(RoomJoinSuccessMessage inMessage); // 0x0000000180FCD140-0x0000000180FCD270
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage message); // 0x0000000180FCD270-0x0000000180FCD500
	private void OnRoomJoinFailedResponse(RoomJoinFailedMessage inMessage); // 0x0000000180FCD0E0-0x0000000180FCD140
	private void Server_OnMinigameJoin(MinigameJoinMessage message); // 0x0000000180FCD920-0x0000000180FCD990
	public void LoadPreviousLevel(); // 0x0000000180FCCE10-0x0000000180FCCE20
	[AsyncStateMachine] // 0x00000001800E6F10-0x00000001800E6F60
	public void TeleportToLevel(string inDefID, bool inFromWorldMap, bool inCheckAlreadyInLevel, bool inExpanse, LevelDefComponent.WorldMapInfo inWorldMapInfo); // 0x0000000180FCDCA0-0x0000000180FCDDB0
	[DebugButton] // 0x00000001800E8320-0x00000001800E8380
	public Coroutine LoadLevel(string inLevelDefID); // 0x0000000180FCCD70-0x0000000180FCCE10
	private void ShowLoadingScreen(); // 0x0000000180FCDAC0-0x0000000180FCDB80
	[IteratorStateMachine] // 0x00000001800E8810-0x00000001800E8860
	private IEnumerator _LoadLevel(string inDefID); // 0x0000000180FCDEC0-0x0000000180FCDF30
	private void RequestServerRoomJoin(LevelDefComponent inLevelDef); // 0x0000000180FCD580-0x0000000180FCD850
	public Coroutine AddLevel(string inLevelDefID); // 0x0000000180FCC8B0-0x0000000180FCC940
	public void RemoveLevel(string inLevelDefID); // 0x0000000180FCD500-0x0000000180FCD580
	[IteratorStateMachine] // 0x00000001800E8990-0x00000001800E89E0
	private IEnumerator LoadLevelAdditiveRoutine(string inDefID); // 0x0000000180FCCCF0-0x0000000180FCCD50
	[IteratorStateMachine] // 0x00000001800E8B70-0x00000001800E8BC0
	private IEnumerator DownloadProgress(ManifestDef inManifestDef); // 0x0000000180FCCB20-0x0000000180FCCB70
	[IteratorStateMachine] // 0x00000001800E8CC0-0x00000001800E8D10
	public IEnumerator ActuallyLoadLevel(LevelDefComponent inLevelDef, RoomJoinMessage roomJoinMessage); // 0x0000000180FCC830-0x0000000180FCC8B0
	[IteratorStateMachine] // 0x00000001800E8FB0-0x00000001800E9000
	public IEnumerator LoadEmptyLevel(); // 0x0000000180FCCC90-0x0000000180FCCCF0
	private void StartTimeoutForServerResponseOnLevelLoad(); // 0x0000000180FCDB80-0x0000000180FCDC50
	private void StopTimeoutForServerResponseOnLevelLoad(); // 0x0000000180FCDC50-0x0000000180FCDCA0
	[IteratorStateMachine] // 0x00000001800E9260-0x00000001800E92B0
	private IEnumerator DoTimeoutServerResponseForLevelLoadCoroutine(); // 0x0000000180FCCAC0-0x0000000180FCCB20
	private void OnLoadLevelTimeoutClosed(); // 0x0000000180FCD030-0x0000000180FCD0E0
	[IteratorStateMachine] // 0x00000001800E93D0-0x00000001800E9420
	public static IEnumerator InitCurrentLevelFromFakeServer(); // 0x0000000180FCCBD0-0x0000000180FCCC20
	[IteratorStateMachine] // 0x00000001800E95A0-0x00000001800E95F0
	private IEnumerator InitCurrentLevel(RoomJoinMessage joinMessage = null); // 0x0000000180FCCC20-0x0000000180FCCC90
	[IteratorStateMachine] // 0x00000001800E9780-0x00000001800E97D0
	private IEnumerator WaitForCurrentLevelThingsToFinish(); // 0x0000000180FCDE00-0x0000000180FCDE50
	private void ResetTouchableLayerMode(); // 0x00000001803581E0-0x00000001803581F0
	private void ResetPlayerCameraMode(); // 0x0000000180FCD850-0x0000000180FCD920
	private void SendCurrentAnalyticsLevel(); // 0x00000001803581E0-0x00000001803581F0
	private void SetCurrentAnalyticsLevel(); // 0x0000000180FCD990-0x0000000180FCDAC0
	[CompilerGenerated] // 0x00000001800E9A50-0x00000001800E9AC0
	[IteratorStateMachine] // 0x00000001800E9A50-0x00000001800E9AC0
	internal static IEnumerator <DoDebugLogin>g__waitForAvatar|40_0(); // 0x0000000180FCDDB0-0x0000000180FCDE00
}

