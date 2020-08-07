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

public class Birds : ManagedBehaviour // TypeDefIndex: 11387
{
	// Fields
	[Header] // 0x00000001801CF100-0x00000001801CF150
	[SerializeField] // 0x00000001801CF100-0x00000001801CF150
	private GameObject[] _model; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RuntimeAnimatorController _controller; // 0x58
	private List<Transform> _path; // 0x60
	private int _randomMax; // 0x68
	private List<float> _possibleRandom; // 0x70
	[Header] // 0x00000001801CF470-0x00000001801CF4E0
	[SerializeField] // 0x00000001801CF470-0x00000001801CF4E0
	[Tooltip] // 0x00000001801CF470-0x00000001801CF4E0
	private string _parameterRandom; // 0x78
	[SerializeField] // 0x00000001801CF780-0x00000001801CF7C0
	[Tooltip] // 0x00000001801CF780-0x00000001801CF7C0
	private string _parameterRandomMax; // 0x80
	[Header] // 0x00000001801CF900-0x00000001801CF950
	[SerializeField] // 0x00000001801CF900-0x00000001801CF950
	private float _moveAccel; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _moveSpeed; // 0x8C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _catchupMoveSpeed; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _turnSpeed; // 0x94
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _catchupTurnSpeed; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _spawnCount; // 0x9C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _modelScale; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _followDistance; // 0xA4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _formationOffsetSide; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _formationOffsetSideRandom; // 0xAC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _formationOffsetBack; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _formationOffsetBackRandom; // 0xB4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _pathDetection; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _pathDetectionScalar; // 0xBC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EFormation _formation; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EPathOrder _pathOrder; // 0xC4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EFollowOrder _followOrder; // 0xC8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _attachBirds; // 0xCC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useTrigger; // 0xCD
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _killAtEndOfLinearPath; // 0xCE
	private bool _birdsActive; // 0xCF
	[Header] // 0x00000001801D16C0-0x00000001801D1750
	[Range] // 0x00000001801D16C0-0x00000001801D1750
	[SerializeField] // 0x00000001801D16C0-0x00000001801D1750
	[Tooltip] // 0x00000001801D16C0-0x00000001801D1750
	private float _randomAnimChangeMin; // 0xD0
	[Range] // 0x00000001801D1CD0-0x00000001801D1D30
	[SerializeField] // 0x00000001801D1CD0-0x00000001801D1D30
	[Tooltip] // 0x00000001801D1CD0-0x00000001801D1D30
	private float _randomAnimChangeMax; // 0xD4
	[Header] // 0x00000001801D2040-0x00000001801D2090
	[SerializeField] // 0x00000001801D2040-0x00000001801D2090
	private Mesh _gizmoMesh; // 0xD8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _gizmoColor; // 0xE0
	private int _birdIndex; // 0xF0
	public List<BirdInfo> _birdInfos; // 0xF8

	// Nested types
	public enum EFormation // TypeDefIndex: 11388
	{
		V = 0,
		LINE = 1
	}

	public enum EPathOrder // TypeDefIndex: 11389
	{
		RANDOM = 0,
		LINEAR = 1
	}

	public enum EFollowOrder // TypeDefIndex: 11390
	{
		LEADER = 0,
		ORDERED = 1,
		INDIVIDUAL = 2
	}

	[Serializable]
	public class BirdInfo // TypeDefIndex: 11391
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
		public BirdInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Setup>d__41 : IEnumerator<object> // TypeDefIndex: 11392
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Birds <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Setup>d__41(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018214B010-0x000000018214B8F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018214B8F0-0x000000018214B940
	}

	// Constructors
	public Birds(); // 0x0000000182130850-0x0000000182130A10

	// Methods
	public override void MStart(); // 0x000000018212ED10-0x000000018212ED80
	private void OnTriggerEnter(Collider inCollider); // 0x0000000182130550-0x0000000182130570
	private void SetBirdsActive(bool inActive); // 0x0000000182130570-0x0000000182130680
	[IteratorStateMachine] // 0x00000001801D25C0-0x00000001801D2610
	private IEnumerator Setup(); // 0x00000001821307F0-0x0000000182130850
	private int GetRandomPathIdx(int inCurrentIdx); // 0x000000018212EB90-0x000000018212EC00
	public override void MUpdate(); // 0x000000018212ED80-0x000000018212FF10
	private void KillAtEndOfLinearPath(); // 0x000000018212EC00-0x000000018212ED10
	private void SetupPath(); // 0x0000000182130680-0x00000001821307F0
	private void OnDrawGizmosSelected(); // 0x000000018212FF10-0x0000000182130550
}

