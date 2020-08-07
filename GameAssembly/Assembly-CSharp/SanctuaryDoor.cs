/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryDoor : ManagedBehaviour // TypeDefIndex: 13321
{
	// Fields
	private List<DoorPivot> _doorPivots; // 0x50
	private float _openDistance; // 0x58
	private float _forceOpenDistance; // 0x5C
	private float _openCloseTime; // 0x60
	private float _dot; // 0x64
	private Transform _cachedPlayerTransform; // 0x68

	// Properties
	private Transform cachedPlayerTransform { get; } // 0x00000001807AEFA0-0x00000001807AF080 

	// Nested types
	public class DoorPivot // TypeDefIndex: 13322
	{
		// Fields
		public Transform pivot; // 0x10
		public bool isOpen; // 0x18
		public Vector3 openRotation; // 0x1C
		public Vector3 closeRotation; // 0x28

		// Constructors
		public DoorPivot(); // 0x00000001807ADE80-0x00000001807ADF10
	}

	// Constructors
	public SanctuaryDoor(); // 0x00000001807AEF00-0x00000001807AEFA0

	// Methods
	public override void MStart(); // 0x00000001807AE410-0x00000001807AE700
	private DoorPivot SetupDoorPivot(Transform inTransform); // 0x00000001807AEDE0-0x00000001807AEF00
	public override void MUpdate(); // 0x00000001807AE700-0x00000001807AEDE0
}

