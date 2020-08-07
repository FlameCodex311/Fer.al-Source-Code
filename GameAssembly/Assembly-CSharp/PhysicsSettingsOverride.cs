/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PhysicsSettingsOverride : MonoBehaviour // TypeDefIndex: 10841
{
	// Fields
	public OverrideValues physicsValueOverrides; // 0x20
	private OverrideValues _savedValues; // 0x28

	// Nested types
	[Serializable]
	public class OverrideValues // TypeDefIndex: 10842
	{
		// Fields
		public Vector3 gravity; // 0x10
		public float timeStep; // 0x1C

		// Constructors
		public OverrideValues(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public PhysicsSettingsOverride(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804E1E30-0x00000001804E1F00
	private void SetValues(OverrideValues inValues); // 0x00000001804E1DE0-0x00000001804E1E30
	private void OnDestroy(); // 0x00000001804E1D90-0x00000001804E1DE0
}

