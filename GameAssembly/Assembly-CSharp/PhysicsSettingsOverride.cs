/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PhysicsSettingsOverride : MonoBehaviour // TypeDefIndex: 13176
{
	// Fields
	public OverrideValues physicsValueOverrides; // 0x20
	private OverrideValues _savedValues; // 0x28

	// Nested types
	[Serializable]
	public class OverrideValues // TypeDefIndex: 13177
	{
		// Fields
		public Vector3 gravity = 0; // 0x10
		public float timeStep; // 0x1C

		// Constructors
		public OverrideValues(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public PhysicsSettingsOverride(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000181158BC0-0x0000000181158C90
	private void SetValues(OverrideValues inValues); // 0x0000000181158B70-0x0000000181158BC0
	private void OnDestroy(); // 0x0000000181158B20-0x0000000181158B70
}

