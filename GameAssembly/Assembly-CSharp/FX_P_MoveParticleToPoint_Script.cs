/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FX_P_MoveParticleToPoint_Script : MonoBehaviour // TypeDefIndex: 12774
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
	public FX_P_MoveParticleToPoint_Script(); // 0x0000000181196A70-0x0000000181196A80

	// Methods
	private void Start(); // 0x0000000181196310-0x0000000181196570
	private void Update(); // 0x0000000181196570-0x0000000181196A70
	private void newEmber(float emberSize1to20 = 1f /* Metadata: 0x00783084 */); // 0x0000000181196AF0-0x0000000181196BB0
	private void collectEmber(float X = 0f /* Metadata: 0x00783088 */, float Y = 0f /* Metadata: 0x0078308C */, float Z = 0f /* Metadata: 0x00783090 */); // 0x0000000181196A80-0x0000000181196AF0
	private void trailsOff(); // 0x0000000181196BB0-0x0000000181196BE0
}

