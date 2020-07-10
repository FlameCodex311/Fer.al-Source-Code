/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x00000001801116B0-0x00000001801116E0
public class DynamicBoneCollider : DynamicBoneColliderBase // TypeDefIndex: 13792
{
	// Fields
	[Tooltip] // 0x0000000180111810-0x0000000180111840
	public float m_Radius; // 0x38
	[Tooltip] // 0x00000001801119A0-0x00000001801119D0
	public float m_Height; // 0x3C

	// Constructors
	public DynamicBoneCollider(); // 0x000000018118B370-0x000000018118B380

	// Methods
	private void OnValidate(); // 0x000000018118AC00-0x000000018118AC80
	public override bool Collide(ref Vector3 particlePosition, float particleRadius); // 0x0000000181189C00-0x000000018118A2C0
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius); // 0x000000018118B1A0-0x000000018118B370
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius); // 0x000000018118A780-0x000000018118A940
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius); // 0x000000018118AC80-0x000000018118B1A0
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius); // 0x000000018118A2C0-0x000000018118A780
	private void OnDrawGizmosSelected(); // 0x000000018118A940-0x000000018118AC00
}

