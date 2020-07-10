/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryDoor : ManagedBehaviour // TypeDefIndex: 11787
{
	// Fields
	private List<DoorPivot> _doorPivots; // 0x50
	private float _openDistance; // 0x58
	private float _forceOpenDistance; // 0x5C
	private float _openCloseTime; // 0x60
	private float _dot; // 0x64
	private Transform _cachedPlayerTransform; // 0x68

	// Properties
	private Transform cachedPlayerTransform { get; } // 0x0000000181286940-0x0000000181286A20 

	// Nested types
	public class DoorPivot // TypeDefIndex: 11788
	{
		// Fields
		public Transform pivot; // 0x10
		public bool isOpen; // 0x18
		public Vector3 openRotation; // 0x1C
		public Vector3 closeRotation; // 0x28

		// Constructors
		public DoorPivot(); // 0x00000001812857F0-0x0000000181285880
	}

	// Constructors
	public SanctuaryDoor(); // 0x00000001812868A0-0x0000000181286940

	// Methods
	public override void MStart(); // 0x0000000181285D70-0x0000000181286070
	private DoorPivot SetupDoorPivot(Transform inTransform); // 0x0000000181286770-0x00000001812868A0
	public override void MUpdate(); // 0x0000000181286070-0x0000000181286770
}

