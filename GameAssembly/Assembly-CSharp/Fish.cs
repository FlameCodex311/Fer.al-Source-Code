/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Fish : ManagedBehaviour // TypeDefIndex: 13721
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _model; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _scale; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _amount; // 0x5C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moveSpeed; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _turnSpeed; // 0x64
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _spawnRadius; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _runAwayRadius; // 0x6C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _stoppingDistance; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _scatterDistance; // 0x74
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _idleTimerMin; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _idleTimerMax; // 0x7C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Mesh _gizmoMesh; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _gizmoColor; // 0x88
	private EnableInRangeToLocalActor _enableInRangeToLocalActor; // 0x98
	private int _idx; // 0xA0
	private Interactable _interactable; // 0xA8
	private InteractableDefComponent _interactableDefComponent; // 0xB0
	public EPathType pathType; // 0xB8
	public List<FishInfo> fishInfos; // 0xC0

	// Properties
	public InteractableDefComponent interactableDefComponent { get; } // 0x000000018110AF30-0x000000018110B090 

	// Nested types
	[Serializable]
	public class FishInfo // TypeDefIndex: 13722
	{
		// Fields
		public GameObject gameObject; // 0x10
		public Vector3 spawnPosition; // 0x18
		public Vector3 spawnRotation; // 0x24
		public Vector3 moveTo; // 0x30
		public float idleTimer; // 0x3C
		public bool scattering; // 0x40

		// Constructors
		public FishInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	public enum EPathType // TypeDefIndex: 13723
	{
		SCATTER = 0,
		ROAM = 1
	}

	// Constructors
	public Fish(); // 0x000000018110AE50-0x000000018110AF30

	// Methods
	public override void MStartAfterLocal(); // 0x0000000181109B60-0x0000000181109C40
	public override void MUpdate(); // 0x0000000181109C40-0x000000018110A6A0
	private void SetRandomTimer(FishInfo inFishInfo); // 0x000000018110AE10-0x000000018110AE50
	public void GetRadii(out float outSpawnRadius, out float outRunAwayRadius); // 0x0000000181109B50-0x0000000181109B60
	public void Scatter(); // 0x000000018110ABF0-0x000000018110AE10
	private void OnDrawGizmosSelected(); // 0x000000018110A6A0-0x000000018110ABF0
}

