/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyTwiggle : MonoBehaviour // TypeDefIndex: 10492
{
	// Fields
	public Transform twist; // 0x20
	[RootSelector] // 0x0000000180202990-0x00000001802029F0
	public string actorPrefabDefID; // 0x28
	[RootSelector] // 0x0000000180202CF0-0x0000000180202D50
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
	private Animator animator { get; } // 0x0000000180ABD220-0x0000000180ABD300 

	// Nested types
	internal enum EState // TypeDefIndex: 10493
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

	internal enum ECelebrateType // TypeDefIndex: 10494
	{
		Fail = 0,
		Success = 1,
		Goal = 2
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Spawn>d__51 : IEnumerator<object> // TypeDefIndex: 10495
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20
		private ActorBase <actorBase>5__2; // 0x28
		private float <t>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Spawn>d__51(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACB590-0x0000000180ACBAD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACBAD0-0x0000000180ACBB20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CollectWait>d__53 : IEnumerator<object> // TypeDefIndex: 10496
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CollectWait>d__53(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AC9AA0-0x0000000180AC9DA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AC9DA0-0x0000000180AC9DF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayFootsteps>d__54 : IEnumerator<object> // TypeDefIndex: 10497
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayFootsteps>d__54(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACAA80-0x0000000180ACAB30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACAB30-0x0000000180ACAB80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TwiggleKO>d__58 : IEnumerator<object> // TypeDefIndex: 10498
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20
		private Vector3 <endPos>5__2; // 0x28
		private float <_startDist>5__3; // 0x34
		private float <_currentDist>5__4; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TwiggleKO>d__58(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACBF80-0x0000000180ACC4F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACC4F0-0x0000000180ACC540
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10499
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__59_0; // 0x08
		public static Action <>9__59_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ACC5E0-0x0000000180ACC640
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DeliverWait>b__59_0(); // 0x0000000180ACC550-0x0000000180ACC570
		internal void <DeliverWait>b__59_1(); // 0x0000000180ACC570-0x0000000180ACC580
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DeliverWait>d__59 : IEnumerator<object> // TypeDefIndex: 10500
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DeliverWait>d__59(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AC9DF0-0x0000000180ACA150
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACA150-0x0000000180ACA1A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetCurrentDirection>d__62 : IEnumerator<object> // TypeDefIndex: 10501
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetCurrentDirection>d__62(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACB230-0x0000000180ACB540
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACB540-0x0000000180ACB590
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TurnToDir>d__63 : IEnumerator<object> // TypeDefIndex: 10502
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20
		private Quaternion <startQ>5__2; // 0x28
		private Quaternion <endQ>5__3; // 0x38
		private float <t>5__4; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TurnToDir>d__63(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACBB20-0x0000000180ACBF30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACBF30-0x0000000180ACBF80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UseStation>d__66 : IEnumerator<object> // TypeDefIndex: 10503
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyTwiggle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UseStation>d__66(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180ACC640-0x0000000180ACCD10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180ACCD10-0x0000000180ACCD60
	}

	// Constructors
	public BuildersFollyTwiggle(); // 0x0000000180ABD090-0x0000000180ABD220

	// Methods
	private void Start(); // 0x0000000180ABC570-0x0000000180ABC630
	internal void InstantiateActor(); // 0x0000000180ABBC10-0x0000000180ABBF30
	[IteratorStateMachine] // 0x0000000180202F70-0x0000000180202FC0
	internal IEnumerator Spawn(); // 0x0000000180ABC510-0x0000000180ABC570
	internal void Despawn(); // 0x0000000180ABBB40-0x0000000180ABBC10
	[IteratorStateMachine] // 0x00000001802031E0-0x0000000180203230
	internal IEnumerator CollectWait(); // 0x0000000180ABB8C0-0x0000000180ABB920
	[IteratorStateMachine] // 0x00000001802036D0-0x0000000180203720
	private IEnumerator PlayFootsteps(); // 0x0000000180ABBF50-0x0000000180ABBFB0
	private void OnDestroy(); // 0x0000000180ABBF30-0x0000000180ABBF50
	internal void UpdateMove(); // 0x0000000180ABC770-0x0000000180ABC920
	internal void UpdateUnitMove(); // 0x0000000180ABC920-0x0000000180ABD030
	[IteratorStateMachine] // 0x0000000180203950-0x00000001802039A0
	private IEnumerator TwiggleKO(); // 0x0000000180ABC690-0x0000000180ABC6F0
	[IteratorStateMachine] // 0x0000000180203D50-0x0000000180203DA0
	private IEnumerator DeliverWait(); // 0x0000000180ABBAE0-0x0000000180ABBB40
	private void SetCelebrateType(); // 0x0000000180ABBFB0-0x0000000180ABC210
	internal void SetInitialDirection(); // 0x0000000180ABC270-0x0000000180ABC510
	[IteratorStateMachine] // 0x00000001802053E0-0x0000000180205430
	private IEnumerator SetCurrentDirection(); // 0x0000000180ABC210-0x0000000180ABC270
	[IteratorStateMachine] // 0x00000001802055F0-0x0000000180205640
	private IEnumerator TurnToDir(); // 0x0000000180ABC630-0x0000000180ABC690
	internal void Celebrate(ECelebrateType inCelebrateType); // 0x0000000180ABB720-0x0000000180ABB8C0
	[IteratorStateMachine] // 0x0000000180205950-0x00000001802059A0
	internal IEnumerator UseStation(); // 0x0000000180ABD030-0x0000000180ABD090
	internal void SetPathPart(BuildersFollyData.BuildersFollyPath.PathPart inPathPart); // 0x00000001809E2CC0-0x00000001809E4880
	internal void CrossedSaw(BuildersFollyGridSpot[] inSawGridSpots); // 0x0000000180ABB920-0x0000000180ABBAE0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InstantiateActor>b__50_0(GameObject inGameObject, ActorInfo inInfo); // 0x0000000180ABC6F0-0x0000000180ABC770
}

