/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryStairs : ManagedBehaviour // TypeDefIndex: 11850
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _safeSpot; // 0x50
	private SanctuaryIndoorRoom _sanctuaryIndoorRoom; // 0x58
	private bool _upstairs; // 0x60

	// Properties
	public Transform safeSpot { get; } // 0x00000001803A27A0-0x00000001803A27B0 

	// Constructors
	public SanctuaryStairs(); // 0x000000018136F510-0x000000018136F570

	// Methods
	public void Setup(SanctuaryIndoorRoom inSanctuaryIndoorRoom, bool inUpstairs); // 0x000000018136F3D0-0x000000018136F3E0
	private void OnTriggerEnter(Collider inCollider); // 0x000000018136F1D0-0x000000018136F3D0
	private void Teleport(); // 0x000000018136F3E0-0x000000018136F510
}

