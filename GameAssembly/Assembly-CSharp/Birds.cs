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

public class Birds : ManagedBehaviour // TypeDefIndex: 13714
{
	// Fields
	[Header] // 0x00000001800F7540-0x00000001800F7590
	[SerializeField] // 0x00000001800F7540-0x00000001800F7590
	private GameObject[] _model; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RuntimeAnimatorController _controller; // 0x58
	private List<Transform> _path; // 0x60
	private int _randomMax; // 0x68
	private List<float> _possibleRandom; // 0x70
	[Header] // 0x00000001800F7B40-0x00000001800F7BB0
	[SerializeField] // 0x00000001800F7B40-0x00000001800F7BB0
	[Tooltip] // 0x00000001800F7B40-0x00000001800F7BB0
	private string _parameterRandom; // 0x78
	[SerializeField] // 0x00000001800F7E10-0x00000001800F7E50
	[Tooltip] // 0x00000001800F7E10-0x00000001800F7E50
	private string _parameterRandomMax; // 0x80
	[Header] // 0x00000001800F7F20-0x00000001800F7F70
	[SerializeField] // 0x00000001800F7F20-0x00000001800F7F70
	private float _moveAccel; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moveSpeed; // 0x8C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _catchupMoveSpeed; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _turnSpeed; // 0x94
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _catchupTurnSpeed; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _spawnCount; // 0x9C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _modelScale; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _followDistance; // 0xA4
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _formationOffsetSide; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _formationOffsetSideRandom; // 0xAC
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _formationOffsetBack; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _formationOffsetBackRandom; // 0xB4
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _pathDetection; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _pathDetectionScalar; // 0xBC
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EFormation _formation; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EPathOrder _pathOrder; // 0xC4
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EFollowOrder _followOrder; // 0xC8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _attachBirds; // 0xCC
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useTrigger; // 0xCD
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _killAtEndOfLinearPath; // 0xCE
	private bool _birdsActive; // 0xCF
	[Header] // 0x00000001800F9C90-0x00000001800F9D20
	[Range] // 0x00000001800F9C90-0x00000001800F9D20
	[SerializeField] // 0x00000001800F9C90-0x00000001800F9D20
	[Tooltip] // 0x00000001800F9C90-0x00000001800F9D20
	private float _randomAnimChangeMin; // 0xD0
	[Range] // 0x00000001800FA020-0x00000001800FA080
	[SerializeField] // 0x00000001800FA020-0x00000001800FA080
	[Tooltip] // 0x00000001800FA020-0x00000001800FA080
	private float _randomAnimChangeMax; // 0xD4
	[Header] // 0x00000001800FA3C0-0x00000001800FA410
	[SerializeField] // 0x00000001800FA3C0-0x00000001800FA410
	private Mesh _gizmoMesh; // 0xD8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _gizmoColor; // 0xE0
	private int _birdIndex; // 0xF0
	public List<BirdInfo> _birdInfos; // 0xF8

	// Nested types
	public enum EFormation // TypeDefIndex: 13715
	{
		V = 0,
		LINE = 1
	}

	public enum EPathOrder // TypeDefIndex: 13716
	{
		RANDOM = 0,
		LINEAR = 1
	}

	public enum EFollowOrder // TypeDefIndex: 13717
	{
		LEADER = 0,
		ORDERED = 1,
		INDIVIDUAL = 2
	}

	[Serializable]
	public class BirdInfo // TypeDefIndex: 13718
	{
		// Fields
		public Transform followTarget; // 0x10
		public GameObject spawnedModel; // 0x18
		public Animator animator; // 0x20
		public float animTimer; // 0x28
		public float moveSpeed; // 0x2C
		public float turnSpeed; // 0x30
		public Vector3 formationOffset; // 0x34
		public int pathIdx; // 0x40
		public float pathDetection; // 0x44

		// Constructors
		public BirdInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Setup>d__41 : IEnumerator<object> // TypeDefIndex: 13719
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Birds <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Setup>d__41(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814EDC40-0x00000001814EE540
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814EE540-0x00000001814EE590
	}

	// Constructors
	public Birds(); // 0x00000001810499A0-0x0000000181049B60

	// Methods
	public override void MStart(); // 0x0000000181047B80-0x0000000181047C00
	private void OnTriggerEnter(Collider inCollider); // 0x00000001810495A0-0x00000001810496B0
	private void SetBirdsActive(bool inActive); // 0x00000001810496B0-0x00000001810497C0
	[IteratorStateMachine] // 0x00000001800FA720-0x00000001800FA770
	private IEnumerator Setup(); // 0x0000000181049930-0x00000001810499A0
	private int GetRandomPathIdx(int inCurrentIdx); // 0x0000000181047A00-0x0000000181047A70
	public override void MUpdate(); // 0x0000000181047C00-0x0000000181048DF0
	private void KillAtEndOfLinearPath(); // 0x0000000181047A70-0x0000000181047B80
	private void SetupPath(); // 0x00000001810497C0-0x0000000181049930
	private void OnDrawGizmosSelected(); // 0x0000000181048DF0-0x00000001810495A0
}

