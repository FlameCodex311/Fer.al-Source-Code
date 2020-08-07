/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryPortal : ManagedBehaviour // TypeDefIndex: 13383
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SanctuaryIndoorRoom _sanctuaryIndoorRoom; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _teleportTo; // 0x58

	// Constructors
	public SanctuaryPortal(); // 0x00000001803F76A0-0x00000001803F7700

	// Methods
	public void Setup(Transform inTeleportTo); // 0x00000001803A1740-0x00000001803A1750
	private void OnTriggerEnter(Collider inCollider); // 0x00000001803F7480-0x00000001803F76A0
}

