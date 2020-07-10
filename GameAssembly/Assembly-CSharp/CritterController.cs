/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CritterController : ManagedBehaviour // TypeDefIndex: 10367
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _model; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useChildPrefab; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private AnimationInfo[] _animationInfos; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _requireServerValidation; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _scale; // 0x6C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _amount; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moveSpeed; // 0x74
	private float _turnSpeed; // 0x78
	private float _acceleration; // 0x7C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _spawnRadius; // 0x80
	[SerializeField] // 0x00000001800F5760-0x00000001800F57B0
	[Tooltip] // 0x00000001800F5760-0x00000001800F57B0
	private float _moveRadius; // 0x84
	[SerializeField] // 0x00000001800F59F0-0x00000001800F5A40
	[Tooltip] // 0x00000001800F59F0-0x00000001800F5A40
	private float _stoppingDistance; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _baseOffset; // 0x8C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _idleTimerMin; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _idleTimerMax; // 0x94
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _gizmoColor; // 0x98
	[SerializeField] // 0x00000001800F65B0-0x00000001800F6600
	[Tooltip] // 0x00000001800F65B0-0x00000001800F6600
	private float _distanceFromPlayerToMove; // 0xA8
	public List<CritterInfo> critterInfos; // 0xB0
	private float _timeDelta; // 0xB8
	private int _index; // 0xBC

	// Nested types
	[Serializable]
	public class CritterInfo // TypeDefIndex: 10368
	{
		// Fields
		public GameObject gameObject; // 0x10
		public Vector3 priorLocation; // 0x18
		public Vector3 spawnOffset; // 0x24
		public Vector3 spawnEuler; // 0x30
		public Animation animation; // 0x40
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Vector3? moveTo; // 0x48
		public float idleTimer; // 0x58
		public bool requireServerValidation; // 0x5C
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Vector3? moveToDir; // 0x60
		private bool _agentChecked; // 0x70
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float speedCheck; // 0x74
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public float speed; // 0x78
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public bool idle; // 0x7C
		private NavMeshAgent _agent; // 0x80
		private InteractableDefComponent _interactableDefComponent; // 0x88

		// Properties
		public NavMeshAgent agent { get; } // 0x0000000180F400B0-0x0000000180F401F0 
		public InteractableDefComponent interactableDefComponent { get; } // 0x0000000180F40250-0x0000000180F40380 
		public float allowedInteractRange { get; } // 0x0000000180F401F0-0x0000000180F40250 

		// Constructors
		public CritterInfo(); // 0x0000000180F3FED0-0x0000000180F3FF90
		public CritterInfo(GameObject inModel, float inSpawnRadius, bool inRequireServerValidation); // 0x0000000180F3FF90-0x0000000180F400B0
	}

	[Serializable]
	public class AnimationInfo // TypeDefIndex: 10369
	{
		// Fields
		public AnimationClip clip; // 0x10
		public float minSpeedToUse; // 0x18
		public float fadeLength; // 0x1C

		// Constructors
		public AnimationInfo(); // 0x0000000180F35530-0x0000000180F355A0
	}

	// Constructors
	public CritterController(); // 0x0000000180F3FDD0-0x0000000180F3FED0

	// Methods
	public override void MUpdate(); // 0x0000000180F3E950-0x0000000180F3F630
	private Vector3 GetNewMoveTo(CritterInfo inCritterInfo); // 0x0000000180F3E540-0x0000000180F3E7A0
	private void SetAnimation(CritterInfo inCritterInfo); // 0x0000000180F3F8E0-0x0000000180F3FD90
	private void SetRandomTimer(CritterInfo inCritterInfo); // 0x0000000180F3FD90-0x0000000180F3FDD0
	private void OnDrawGizmosSelected(); // 0x0000000180F3F630-0x0000000180F3F8E0
	public void GetRadii(out float outSpawnRadius, out float outMoveRadius); // 0x0000000180F3E7A0-0x0000000180F3E950
}

