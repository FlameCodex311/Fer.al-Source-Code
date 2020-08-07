/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Fish : ManagedBehaviour // TypeDefIndex: 11400
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _model; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _scale; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _amount; // 0x5C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _moveSpeed; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _turnSpeed; // 0x64
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _spawnRadius; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _runAwayRadius; // 0x6C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _stoppingDistance; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _scatterDistance; // 0x74
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _idleTimerMin; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _idleTimerMax; // 0x7C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Mesh _gizmoMesh; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _gizmoColor; // 0x88
	private EnableInRangeToLocalActor _enableInRangeToLocalActor; // 0x98
	private InteractableDefComponent _interactableDefComponent; // 0xA0
	public EPathType pathType; // 0xA8
	public List<FishInfo> fishInfos; // 0xB0

	// Properties
	public float runAwayRadius { get; } // 0x00000001804C5F30-0x00000001804C5F40 
	public InteractableDefComponent interactableDefComponent { get; } // 0x00000001806A0EE0-0x00000001806A1010 

	// Nested types
	[Serializable]
	public class FishInfo // TypeDefIndex: 11401
	{
		// Fields
		public GameObject gameObject; // 0x10
		public Vector3 spawnPosition; // 0x18
		public Vector3 spawnRotation; // 0x24
		public Vector3 moveTo; // 0x30
		public float idleTimer; // 0x3C
		public bool scattering; // 0x40

		// Constructors
		public FishInfo(); // 0x0000000180373240-0x0000000180373250
	}

	public enum EPathType // TypeDefIndex: 11402
	{
		SCATTER = 0,
		ROAM = 1
	}

	// Constructors
	public Fish(); // 0x00000001806A0E00-0x00000001806A0EE0

	// Methods
	public override void MStartAfterLocal(); // 0x000000018069FAF0-0x000000018069FD20
	public override void MUpdate(); // 0x000000018069FD20-0x00000001806A05E0
	private void SetRandomTimer(FishInfo inFishInfo); // 0x00000001806A0DC0-0x00000001806A0E00
	public void Scatter(); // 0x00000001806A0B70-0x00000001806A0DC0
	private void OnDrawGizmosSelected(); // 0x00000001806A05E0-0x00000001806A0B70
}

