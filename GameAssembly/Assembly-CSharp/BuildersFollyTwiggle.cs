/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyTwiggle : MonoBehaviour // TypeDefIndex: 12834
{
	// Fields
	public Transform twist; // 0x20
	[RootSelector] // 0x000000018012D9C0-0x000000018012DA20
	public string actorPrefabDefID; // 0x28
	[RootSelector] // 0x000000018012DAA0-0x000000018012DB00
	public string actorNPCDefID; // 0x30
	public Sprite image; // 0x38
	public float collectTime; // 0x40
	public float deliverTime; // 0x44
	public float deliverAudioWaitTime; // 0x48
	public float jumpAudioWaitTime; // 0x4C
	public float twiggleKOSpeed; // 0x50
	public float footstepDelay; // 0x54
	public float cutTime; // 0x58
	public float sewTime; // 0x5C
	public float buildTime; // 0x60
	public float kilnTime; // 0x64
	public float dyeTime; // 0x68
	public float deadEndTime; // 0x6C
	public float spawnTime; // 0x70
	public float turnTime; // 0x74
	public Vector3 upDir; // 0x78
	public Vector3 downDir; // 0x84
	public Vector3 leftDir; // 0x90
	public Vector3 rightDir; // 0x9C
	public GameObject fxSpawn; // 0xA8
	public GameObject fxFail; // 0xB0
	public GameObject fxSuccess; // 0xB8
	public GameObject fxConfetti; // 0xC0
	public GameObject fxMovement; // 0xC8
	internal int currentPathIndex; // 0xD0
	internal BuildersFollyData.BuildersFollyPath.PathPart pathPart; // 0xD8
	internal BuildersFollyData.Station inputStation; // 0xE0
	internal BuildersFollyData.Station outputStation; // 0xE8
	internal BuildersFollyTwiggleManager twiggleManager; // 0xF0
	internal BuildersFollyResource resource; // 0xF8
	internal EState state; // 0x100
	private ECelebrateType _celebrateType; // 0x104
	private Vector3 _startPos; // 0x108
	private Transform _headFXpoint; // 0x118
	private Vector3 _oldDir; // 0x120
	private Vector3 _currentDir; // 0x12C
	private Vector3 _desiredDir; // 0x138
	private BuildersFollyGame _game; // 0x148
	private static Vector3 _endScale; // 0x00
	private IEnumerator _playFootStep; // 0x150
	internal bool trapped; // 0x158
	private Animator _animator; // 0x160
	internal int stationMoveWaits; // 0x168

	// Properties
	private Animator animator { get; } // 0x00000001813CD2D0-0x00000001813CD3B0 

	// Nested types
	internal enum EState // TypeDefIndex: 12835
	{
		Collect = 0,
		GotoPathPartEnd = 1,
		Deliver = 2,
		WaitForOtherTwiggle = 3,
		OutputBuilding = 4,
		InputBuilding = 5,
		WaitAfterBuild = 6,
		Celebrate = 7,
		DeadEnd = 8,
		OutOfResources = 9,
		Trapped = 10
	}

	internal enum ECelebrateType // TypeDefIndex: 12836
	{
		Fail = 0,
		Success = 1,
		Goal = 2
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Spawn>d__51 : IEnumerator<object> // TypeDefIndex: 12837
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20
		private ActorBase <actorBase>5__2; // 0x28
		private float <t>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Spawn>d__51(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813DFE30-0x00000001813E0390
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813E0390-0x00000001813E03E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CollectWait>d__53 : IEnumerator<object> // TypeDefIndex: 12838
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CollectWait>d__53(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813DDD80-0x00000001813DE090
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813DE090-0x00000001813DE0E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayFootsteps>d__54 : IEnumerator<object> // TypeDefIndex: 12839
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayFootsteps>d__54(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813DEF00-0x00000001813DEFB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813DEFB0-0x00000001813DF000
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TwiggleKO>d__58 : IEnumerator<object> // TypeDefIndex: 12840
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20
		private Vector3 <endPos>5__2; // 0x28
		private float <_startDist>5__3; // 0x34
		private float <_currentDist>5__4; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TwiggleKO>d__58(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813E0850-0x00000001813E0DD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813E0DD0-0x00000001813E0E20
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12841
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__59_0; // 0x08
		public static Action <>9__59_1; // 0x10

		// Constructors
		static <>c(); // 0x00000001813E1010-0x00000001813E1070
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DeliverWait>b__59_0(); // 0x00000001813E0E20-0x00000001813E0E40
		internal void <DeliverWait>b__59_1(); // 0x00000001813E0E40-0x00000001813E0E50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DeliverWait>d__59 : IEnumerator<object> // TypeDefIndex: 12842
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DeliverWait>d__59(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813DE0E0-0x00000001813DE450
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813DE450-0x00000001813DE4A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetCurrentDirection>d__62 : IEnumerator<object> // TypeDefIndex: 12843
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetCurrentDirection>d__62(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813DFAC0-0x00000001813DFDE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813DFDE0-0x00000001813DFE30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TurnToDir>d__63 : IEnumerator<object> // TypeDefIndex: 12844
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20
		private Quaternion <startQ>5__2; // 0x28
		private Quaternion <endQ>5__3; // 0x38
		private float <t>5__4; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TurnToDir>d__63(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813E03E0-0x00000001813E0800
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813E0800-0x00000001813E0850
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UseStation>d__66 : IEnumerator<object> // TypeDefIndex: 12845
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UseStation>d__66(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813E1070-0x00000001813E1770
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813E1770-0x00000001813E25F0
	}

	// Constructors
	public BuildersFollyTwiggle(); // 0x00000001813CD140-0x00000001813CD2D0

	// Methods
	private void Start(); // 0x00000001813CC600-0x00000001813CC6C0
	internal void InstantiateActor(); // 0x00000001813CBC60-0x00000001813CBF90
	[IteratorStateMachine] // 0x000000018012DD60-0x000000018012DDB0
	internal IEnumerator Spawn(); // 0x00000001813CC5A0-0x00000001813CC600
	internal void Despawn(); // 0x00000001813CBB80-0x00000001813CBC60
	[IteratorStateMachine] // 0x000000018012DF80-0x000000018012DFD0
	internal IEnumerator CollectWait(); // 0x00000001813CB8F0-0x00000001813CB950
	[IteratorStateMachine] // 0x000000018012E200-0x000000018012E250
	private IEnumerator PlayFootsteps(); // 0x00000001813CBFB0-0x00000001813CC010
	private void OnDestroy(); // 0x00000001813CBF90-0x00000001813CBFB0
	internal void UpdateMove(); // 0x00000001813CC800-0x00000001813CC9B0
	internal void UpdateUnitMove(); // 0x00000001813CC9B0-0x00000001813CD0E0
	[IteratorStateMachine] // 0x000000018012E4E0-0x000000018012E530
	private IEnumerator TwiggleKO(); // 0x00000001813CC720-0x00000001813CC780
	[IteratorStateMachine] // 0x000000018012E6F0-0x000000018012E740
	private IEnumerator DeliverWait(); // 0x00000001813CBB20-0x00000001813CBB80
	private void SetCelebrateType(); // 0x00000001813CC010-0x00000001813CC290
	internal void SetInitialDirection(); // 0x00000001813CC2F0-0x00000001813CC5A0
	[IteratorStateMachine] // 0x000000018012E9B0-0x000000018012EA00
	private IEnumerator SetCurrentDirection(); // 0x00000001813CC290-0x00000001813CC2F0
	[IteratorStateMachine] // 0x000000018012ECD0-0x000000018012ED20
	private IEnumerator TurnToDir(); // 0x00000001813CC6C0-0x00000001813CC720
	internal void Celebrate(ECelebrateType inCelebrateType); // 0x00000001813CB750-0x00000001813CB8F0
	[IteratorStateMachine] // 0x000000018012EF80-0x000000018012EFD0
	internal IEnumerator UseStation(); // 0x00000001813CD0E0-0x00000001813CD140
	internal void SetPathPart(BuildersFollyData.BuildersFollyPath.PathPart inPathPart); // 0x00000001804BEA30-0x00000001804BEA40
	internal void CrossedSaw(BuildersFollyGridSpot[] inSawGridSpots); // 0x00000001813CB950-0x00000001813CBB20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InstantiateActor>b__50_0(GameObject inGameObject, ActorInfo inInfo); // 0x00000001813CC780-0x00000001813CC800
}

