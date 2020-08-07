/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryStairs : ManagedBehaviour // TypeDefIndex: 13386
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _safeSpot; // 0x50
	private SanctuaryIndoorRoom _sanctuaryIndoorRoom; // 0x58
	private bool _upstairs; // 0x60

	// Properties
	public Transform safeSpot { get; } // 0x0000000180378320-0x0000000180378330 

	// Constructors
	public SanctuaryStairs(); // 0x00000001803F81E0-0x00000001803F8240

	// Methods
	public void Setup(SanctuaryIndoorRoom inSanctuaryIndoorRoom, bool inUpstairs); // 0x00000001803F80A0-0x00000001803F80B0
	private void OnTriggerEnter(Collider inCollider); // 0x00000001803F7EB0-0x00000001803F80A0
	private void Teleport(); // 0x00000001803F80B0-0x00000001803F81E0
}

