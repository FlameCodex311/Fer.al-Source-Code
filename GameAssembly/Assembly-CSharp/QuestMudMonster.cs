/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestMudMonster : MonoBehaviour // TypeDefIndex: 11665
{
	// Fields
	public GraphOwner respawnGraphOwner; // 0x20
	public Transform mudMonster; // 0x28
	public Transform mudMonsterHandL; // 0x30
	public Transform mudMonsterHandR; // 0x38
	public Transform exclamationIcon; // 0x40
	public QuestMudMonsterShot npcShot; // 0x48
	public GameObject grabFX; // 0x50
	public Transform[] waypoints; // 0x58
	public float shootWaitTime; // 0x60
	public float shootDistanceCheck; // 0x64
	[Tooltip] // 0x00000001800F3220-0x00000001800F3250
	public float farshootAngleCheck; // 0x68
	[Tooltip] // 0x00000001800F33E0-0x00000001800F3410
	public float nearshootAngleCheck; // 0x6C
	public float grabTurnMultiplyer; // 0x70
	[Tooltip] // 0x00000001800F3530-0x00000001800F3560
	public float grabWaitTime_preFX; // 0x74
	[Tooltip] // 0x00000001800F3780-0x00000001800F37B0
	public float grabWaitTime_postFX; // 0x78
	public float optimalGrabDistance; // 0x7C
	public float waypointDetectionDistance; // 0x80
	public float moveSpeed; // 0x84
	public float turnSpeed; // 0x88
	public int shotArchPoints; // 0x8C
	[Tooltip] // 0x00000001800F39D0-0x00000001800F3A00
	public float farArcHeight; // 0x90
	[Tooltip] // 0x00000001800F3C10-0x00000001800F3C40
	public float nearArcHeight; // 0x94
	[Tooltip] // 0x00000001800F3DA0-0x00000001800F3DD0
	public float yShotHitOffset; // 0x98
	public float shotScaleTime; // 0x9C
	public Vector3 throwLineOfSiteOffset; // 0xA0
	internal bool isAwareOfPlayer; // 0xAC
	public EWaypointType waypointType; // 0xB0
	private Transform _playerTransform; // 0xB8
	private float _archeight; // 0xC0
	private float _shootAngleCheck; // 0xC4
	private float _shootDistanceCheck; // 0xC8
	private float _shootWaitTime; // 0xCC
	private bool _waypointForward; // 0xD0
	private bool _throwLaunching; // 0xD1
	private int _currentWaypointIndex; // 0xD4
	private List<Vector3> _pointList; // 0xD8
	private Vector3 _startPoint; // 0xE0
	private Vector3 _hitPoint; // 0xEC
	private Vector3 _midPoint; // 0xF8
	private Vector3 _desiredFacingDir; // 0x104
	private Transform _mudMonsterTransform; // 0x110
	private QuestMudMonsterShot __npcShot; // 0x118
	private bool _controlsEnabled; // 0x120
	private CharacterController _characterController; // 0x128
	private Animator _animator; // 0x130
	private GameObject _grabFX; // 0x138
	private Collider _collider; // 0x140
	private EMoveState _moveState; // 0x148
	internal static bool gameplayInterrupted; // 0x00
	internal static List<GameObject> groundHitFX; // 0x08
	private static bool _respawning; // 0x10
	private static List<QuestMudMonster> allMudMonsters; // 0x18
	private static QuestMudMonster _aMudMonster; // 0x20

	// Properties
	internal Transform playerTransform { get; set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x00000001803D8F00-0x00000001803D8F10
	private QuestMudMonsterShot NpcShot { get; set; } // 0x00000001803BD3A0-0x00000001803BD3B0 0x00000001803BE5C0-0x00000001803BE5D0
	private EMoveState MoveState { get; set; } // 0x0000000180A98E90-0x0000000180A98EA0 0x000000018100E120-0x000000018100E1B0

	// Nested types
	public enum EWaypointType // TypeDefIndex: 11666
	{
		PingPong = 0,
		Circular = 1
	}

	private enum EMoveState // TypeDefIndex: 11667
	{
		None = 0,
		Moving = 1,
		ThrowWait = 2,
		Turning = 3,
		Capturing = 4,
		SpearHit = 5
	}

	private enum EReactionType // TypeDefIndex: 11668
	{
		None = 0,
		Throw = 1,
		Capture = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11669
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__65_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018101BAD0-0x000000018101CE10
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__65_0(); // 0x000000018101B6B0-0x000000018101B710
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpearHit>d__69 : IEnumerator<object> // TypeDefIndex: 11670
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		public QuestSpear inSpear; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpearHit>d__69(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181019790-0x0000000181019A00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181019A00-0x0000000181019A50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ThrowLaunch>d__75 : IEnumerator<object> // TypeDefIndex: 11671
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		private Vector3 <endScale>5__2; // 0x28
		private float <t>5__3; // 0x34

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ThrowLaunch>d__75(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018101A450-0x000000018101AE10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018101AE10-0x000000018101B6B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartCapture>d__77 : IEnumerator<object> // TypeDefIndex: 11672
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		private Quaternion <rotation>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartCapture>d__77(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181019A50-0x000000018101A010
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018101A010-0x000000018101A450
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveToGrabSpot>d__78 : IEnumerator<object> // TypeDefIndex: 11673
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		private Vector3 <startGrabPosition>5__2; // 0x28
		private Vector3 <endGrabPosition>5__3; // 0x34
		private float <f>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveToGrabSpot>d__78(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181016510-0x0000000181016A80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181016A80-0x0000000181016AD0
	}

	// Constructors
	public QuestMudMonster(); // 0x000000018100E030-0x000000018100E120
	static QuestMudMonster(); // 0x000000018100DFA0-0x000000018100E030

	// Methods
	private void Start(); // 0x000000018100C8E0-0x000000018100CC40
	private void Update(); // 0x000000018100DAC0-0x000000018100DFA0
	internal static bool GameplayInterrupted(); // 0x000000018100B6E0-0x000000018100B860
	private void Move(); // 0x000000018100B8C0-0x000000018100BE10
	[IteratorStateMachine] // 0x00000001800F4050-0x00000001800F40A0
	internal IEnumerator SpearHit(QuestSpear inSpear); // 0x000000018100C810-0x000000018100C880
	private void Turn(); // 0x000000018100D7B0-0x000000018100D9F0
	private EReactionType TargetCheck(bool inForceLineOfSiteChq = false /* Metadata: 0x00782B03 */); // 0x000000018100CC40-0x000000018100D100
	private void Capture(); // 0x000000018100B470-0x000000018100B5C0
	private void DangerCheck(); // 0x000000018100B5C0-0x000000018100B6E0
	private void Throw(); // 0x000000018100D420-0x000000018100D550
	[IteratorStateMachine] // 0x00000001800F4250-0x00000001800F42A0
	private IEnumerator ThrowLaunch(); // 0x000000018100D260-0x000000018100D2C0
	private void ThrowWait(); // 0x000000018100D2C0-0x000000018100D420
	[IteratorStateMachine] // 0x00000001800F44B0-0x00000001800F4500
	private IEnumerator StartCapture(); // 0x000000018100C880-0x000000018100C8E0
	[IteratorStateMachine] // 0x00000001800F4690-0x00000001800F46E0
	private IEnumerator MoveToGrabSpot(); // 0x000000018100B860-0x000000018100B8C0
	private void RemoveHudAndControl(); // 0x000000018100C2A0-0x000000018100C3E0
	private void TrapPlayer(); // 0x000000018100D550-0x000000018100D7B0
	public void TeleportFinished(); // 0x000000018100D100-0x000000018100D1B0
	public void RespawnFinished(); // 0x000000018100C5B0-0x000000018100C810
	private void ResetNow(); // 0x000000018100C3E0-0x000000018100C5B0
	internal void ThrowHitPlayer(); // 0x000000018100D1B0-0x000000018100D260
	private void OnControllerColliderHit(ControllerColliderHit inHit); // 0x000000018100BE10-0x000000018100BE90
	private void OnTriggerEnter(Collider other); // 0x000000018100C1D0-0x000000018100C2A0
	private void OnDrawGizmosSelected(); // 0x000000018100BE90-0x000000018100C1D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__65_1(); // 0x000000018100D9F0-0x000000018100DAC0
}

