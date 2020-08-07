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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestMudMonster : MonoBehaviour // TypeDefIndex: 13191
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
	[Tooltip] // 0x00000001802955E0-0x0000000180295610
	public float farshootAngleCheck; // 0x68
	[Tooltip] // 0x0000000180295740-0x0000000180295770
	public float nearshootAngleCheck; // 0x6C
	public float grabTurnMultiplyer; // 0x70
	[Tooltip] // 0x0000000180295CA0-0x0000000180295CD0
	public float grabWaitTime_preFX; // 0x74
	[Tooltip] // 0x0000000180295E00-0x0000000180295E30
	public float grabWaitTime_postFX; // 0x78
	public float optimalGrabDistance; // 0x7C
	public float waypointDetectionDistance; // 0x80
	public float moveSpeed; // 0x84
	public float turnSpeed; // 0x88
	public int shotArchPoints; // 0x8C
	[Tooltip] // 0x0000000180295E60-0x0000000180295E90
	public float farArcHeight; // 0x90
	[Tooltip] // 0x0000000180295F10-0x0000000180295F40
	public float nearArcHeight; // 0x94
	[Tooltip] // 0x00000001802961C0-0x00000001802961F0
	public float yShotHitOffset; // 0x98
	public float shotScaleTime; // 0x9C
	public Vector3 throwLineOfSiteOffset; // 0xA0
	internal bool isAwareOfPlayer; // 0xAC
	public EWaypointType waypointType; // 0xB0
	[Header] // 0x0000000180296270-0x00000001802962A0
	public GameObject areaBlip; // 0xB8
	public GameObject progressUpdatingVolume; // 0xC0
	public GameObject hitPointFX; // 0xC8
	public GameObject explosionFX; // 0xD0
	[Tooltip] // 0x0000000180296370-0x00000001802963A0
	public float hitDelay; // 0xD8
	public float destroyDelay; // 0xDC
	private Transform _playerTransform; // 0xE0
	private float _archeight; // 0xE8
	private float _shootAngleCheck; // 0xEC
	private float _shootDistanceCheck; // 0xF0
	private float _shootWaitTime; // 0xF4
	private bool _waypointForward; // 0xF8
	private bool _throwLaunching; // 0xF9
	private int _currentWaypointIndex; // 0xFC
	private List<Vector3> _pointList; // 0x100
	private Vector3 _startPoint; // 0x108
	private Vector3 _hitPoint; // 0x114
	private Vector3 _midPoint; // 0x120
	private Vector3 _desiredFacingDir; // 0x12C
	private Transform _mudMonsterTransform; // 0x138
	private float speedUp; // 0x140
	private bool _controlsEnabled; // 0x144
	private CharacterController _characterController; // 0x148
	private Animator _animator; // 0x150
	private GameObject _grabFX; // 0x158
	private Collider _collider; // 0x160
	private QuestMudMonsterShot _npcShot; // 0x168
	private EMoveState _moveState; // 0x170
	internal static bool gameplayInterrupted; // 0x00
	internal static List<GameObject> groundHitFX; // 0x08
	private static bool _respawning; // 0x10
	private static List<QuestMudMonster> allMudMonsters; // 0x18
	private static QuestMudMonster _aMudMonster; // 0x20
	private bool trackSkin; // 0x174
	private bool findSpearHitPoint; // 0x175
	private int vertexCount; // 0x178
	private int closestIndex; // 0x17C
	private QuestSpear spear; // 0x180
	private Mesh mesh; // 0x188
	private SkinnedMeshRenderer skin; // 0x190
	private Vector3[] vertices; // 0x198
	private Matrix4x4[] boneMatrices; // 0x1A0
	private BoneWeight weight; // 0x1A8
	private Matrix4x4 bm0; // 0x1C8
	private Matrix4x4 bm1; // 0x208
	private Matrix4x4 bm2; // 0x248
	private Matrix4x4 bm3; // 0x288
	private Matrix4x4 vertexMatrix; // 0x2C8
	private Vector3 spearPosition; // 0x308

	// Properties
	internal Transform playerTransform { get; set; } // 0x0000000180652A60-0x0000000180652B40 0x000000018057C5E0-0x000000018057C5F0
	private QuestMudMonsterShot NpcShot { get; set; } // 0x000000018058C840-0x000000018058C850 0x0000000180652BD0-0x0000000180652BE0
	private EMoveState MoveState { get; set; } // 0x0000000180652A50-0x0000000180652A60 0x0000000180652B40-0x0000000180652BD0

	// Nested types
	public enum EWaypointType // TypeDefIndex: 13192
	{
		PingPong = 0,
		Circular = 1
	}

	private enum EMoveState // TypeDefIndex: 13193
	{
		None = 0,
		Moving = 1,
		ThrowWait = 2,
		Turning = 3,
		Capturing = 4,
		SpearHit = 5
	}

	private enum EReactionType // TypeDefIndex: 13194
	{
		None = 0,
		Throw = 1,
		Capture = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13195
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__88_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018065F640-0x000000018065F6A0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__88_0(); // 0x000000018065F1D0-0x000000018065F230
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpearHit>d__93 : IEnumerator<object> // TypeDefIndex: 13196
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		public QuestSpear inSpear; // 0x28
		public Vector3 inHitPoint; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpearHit>d__93(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065C9A0-0x000000018065D420
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065D420-0x000000018065D470
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ThrowLaunch>d__99 : IEnumerator<object> // TypeDefIndex: 13197
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		private Vector3 <endScale>5__2; // 0x28
		private float <t>5__3; // 0x34

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ThrowLaunch>d__99(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065DF50-0x000000018065E970
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065E970-0x000000018065F130
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartCapture>d__101 : IEnumerator<object> // TypeDefIndex: 13198
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		private Quaternion <rotation>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartCapture>d__101(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065D470-0x000000018065DA20
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065DA20-0x000000018065DA70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveToGrabSpot>d__102 : IEnumerator<object> // TypeDefIndex: 13199
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestMudMonster <>4__this; // 0x20
		private Vector3 <startGrabPosition>5__2; // 0x28
		private Vector3 <endGrabPosition>5__3; // 0x34
		private float <f>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveToGrabSpot>d__102(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180659AB0-0x000000018065A010
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065A010-0x000000018065A060
	}

	// Constructors
	public QuestMudMonster(); // 0x0000000180652900-0x0000000180652A50
	static QuestMudMonster(); // 0x0000000180652870-0x0000000180652900

	// Methods
	private void Start(); // 0x0000000180651100-0x0000000180651520
	private void Update(); // 0x0000000180652390-0x0000000180652870
	private void LateUpdate(); // 0x000000018064F420-0x0000000180650000
	internal static bool GameplayInterrupted(); // 0x000000018064F2A0-0x000000018064F420
	private void Move(); // 0x0000000180650060-0x00000001806505E0
	[IteratorStateMachine] // 0x00000001802965C0-0x0000000180296610
	internal IEnumerator SpearHit(QuestSpear inSpear, Vector3 inHitPoint); // 0x0000000180651010-0x00000001806510A0
	private void Turn(); // 0x0000000180652080-0x00000001806522C0
	private EReactionType TargetCheck(bool inForceLineOfSiteChq = false /* Metadata: 0x007BA210 */); // 0x0000000180651520-0x00000001806519E0
	private void Capture(); // 0x000000018064F040-0x000000018064F190
	private void DangerCheck(); // 0x000000018064F190-0x000000018064F2A0
	private void Throw(); // 0x0000000180651D00-0x0000000180651E30
	[IteratorStateMachine] // 0x00000001801CDBA0-0x00000001801CDBF0
	private IEnumerator ThrowLaunch(); // 0x0000000180651B40-0x0000000180651BA0
	private void ThrowWait(); // 0x0000000180651BA0-0x0000000180651D00
	[IteratorStateMachine] // 0x00000001801CDE80-0x00000001801CDED0
	private IEnumerator StartCapture(); // 0x00000001806510A0-0x0000000180651100
	[IteratorStateMachine] // 0x00000001801CE060-0x00000001801CE0B0
	private IEnumerator MoveToGrabSpot(); // 0x0000000180650000-0x0000000180650060
	private void RemoveHudAndControl(); // 0x0000000180650AA0-0x0000000180650BE0
	private void TrapPlayer(); // 0x0000000180651E30-0x0000000180652080
	public void TeleportFinished(); // 0x00000001806519E0-0x0000000180651A90
	public void RespawnFinished(); // 0x0000000180650DB0-0x0000000180651010
	private void ResetNow(); // 0x0000000180650BE0-0x0000000180650DB0
	internal void ThrowHitPlayer(); // 0x0000000180651A90-0x0000000180651B40
	private void OnControllerColliderHit(ControllerColliderHit inHit); // 0x00000001806505E0-0x0000000180650660
	private void OnTriggerEnter(Collider other); // 0x0000000180650990-0x0000000180650AA0
	private void OnDrawGizmosSelected(); // 0x0000000180650660-0x0000000180650990
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__88_1(); // 0x00000001806522C0-0x0000000180652390
}

