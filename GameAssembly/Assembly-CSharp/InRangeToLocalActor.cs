/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InRangeToLocalActor : ManagedBehaviour // TypeDefIndex: 11903
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _range; // 0x50
	private Transform _triggerer; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent OnOutOfRange; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent OnInRange; // 0x68
	private float? _rangeSq; // 0x70
	private EState _desiredState; // 0x78
	private EState _currentState; // 0x7C

	// Properties
	public Transform triggerer { get; } // 0x0000000180624630-0x0000000180624710 
	private float rangeSq { get; } // 0x00000001806245C0-0x0000000180624630 
	private Vector3 _relativePosition { get; } // 0x00000001806244A0-0x00000001806245C0 

	// Nested types
	public enum EState // TypeDefIndex: 11904
	{
		OUTOFRANGE = 0,
		INRANGE = 1
	}

	// Constructors
	public InRangeToLocalActor(); // 0x0000000180624440-0x00000001806244A0

	// Methods
	public override void MUpdate(); // 0x0000000180624120-0x0000000180624380
	private void InRange(); // 0x0000000180624100-0x0000000180624120
	private void OutOfRange(); // 0x0000000180624420-0x0000000180624440
	private void OnDrawGizmos(); // 0x0000000180624380-0x0000000180624420
}

