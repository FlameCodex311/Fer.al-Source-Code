/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x0000000180205E70-0x0000000180205EC0
public class FirefliesTriggerVolume : ManagedBehaviour // TypeDefIndex: 14281
{
	// Fields
	public ParticleSystem lowPosition; // 0x50
	public ParticleSystem highPosition; // 0x58

	// Constructors
	public FirefliesTriggerVolume(); // 0x000000018069FA90-0x000000018069FAF0

	// Methods
	public override void MStart(); // 0x000000018069F740-0x000000018069F790
	private void Toggle(bool inNear); // 0x000000018069FA10-0x000000018069FA90
	private void OnTriggerEnter(Collider inCollider); // 0x000000018069F790-0x000000018069F8D0
	private void OnTriggerExit(Collider inCollider); // 0x000000018069F8D0-0x000000018069FA10
}

