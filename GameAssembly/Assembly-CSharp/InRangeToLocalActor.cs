/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InRangeToLocalActor : ManagedBehaviour // TypeDefIndex: 10415
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _range; // 0x50
	private Transform _triggerer; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent OnOutOfRange; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent OnInRange; // 0x68
	private float? _rangeSq; // 0x70
	private EState _desiredState; // 0x78
	private EState _currentState; // 0x7C

	// Properties
	public Transform triggerer { get; } // 0x0000000180F5B170-0x0000000180F5B250 
	private float rangeSq { get; } // 0x0000000180F5B100-0x0000000180F5B170 
	private Vector3 _relativePosition { get; } // 0x0000000180F5AFE0-0x0000000180F5B100 

	// Nested types
	public enum EState // TypeDefIndex: 10416
	{
		OUTOFRANGE = 0,
		INRANGE = 1
	}

	// Constructors
	public InRangeToLocalActor(); // 0x0000000180F5AF80-0x0000000180F5AFE0

	// Methods
	public override void MUpdate(); // 0x0000000180F5AC50-0x0000000180F5AEC0
	private void InRange(); // 0x0000000180F5AC30-0x0000000180F5AC50
	private void OutOfRange(); // 0x0000000180F5AF60-0x0000000180F5AF80
	private void OnDrawGizmos(); // 0x0000000180F5AEC0-0x0000000180F5AF60
}

