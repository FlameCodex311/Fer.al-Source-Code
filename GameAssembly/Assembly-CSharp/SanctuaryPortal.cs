/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryPortal : ManagedBehaviour // TypeDefIndex: 11847
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private SanctuaryIndoorRoom _sanctuaryIndoorRoom; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _teleportTo; // 0x58

	// Constructors
	public SanctuaryPortal(); // 0x000000018136EAB0-0x000000018136EB10

	// Methods
	public void Setup(Transform inTeleportTo); // 0x0000000180485C70-0x0000000180485C80
	private void OnTriggerEnter(Collider inCollider); // 0x000000018136E880-0x000000018136EAB0
}

