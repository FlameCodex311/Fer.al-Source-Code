/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FX_P_MoveParticleToPoint_Script : MonoBehaviour // TypeDefIndex: 10432
{
	// Fields
	public float speed; // 0x20
	public Transform target; // 0x28
	public ParticleSystem burstEffect; // 0x30
	public bool includeChildren; // 0x38
	public GameObject collectible; // 0x40
	public GameObject trailSystem; // 0x48
	private bool onSwitch; // 0x50

	// Constructors
	public FX_P_MoveParticleToPoint_Script(); // 0x0000000180863D60-0x0000000180863D70

	// Methods
	private void Start(); // 0x0000000180863630-0x0000000180863870
	private void Update(); // 0x0000000180863870-0x0000000180863D60
	private void newEmber(float emberSize1to20 = 1f /* Metadata: 0x0077BB2F */); // 0x0000000180863DE0-0x0000000180863EA0
	private void collectEmber(float X = 0f /* Metadata: 0x0077BB33 */, float Y = 0f /* Metadata: 0x0077BB37 */, float Z = 0f /* Metadata: 0x0077BB3B */); // 0x0000000180863D70-0x0000000180863DE0
	private void trailsOff(); // 0x0000000180863EA0-0x0000000180863ED0
}

