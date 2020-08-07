/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001801EEC00-0x00000001801EEC30
public class DynamicBoneCollider : DynamicBoneColliderBase // TypeDefIndex: 11465
{
	// Fields
	[Tooltip] // 0x00000001801EED20-0x00000001801EED50
	public float m_Radius; // 0x38
	[Tooltip] // 0x00000001801EEF50-0x00000001801EEF80
	public float m_Height; // 0x3C

	// Constructors
	public DynamicBoneCollider(); // 0x0000000180858040-0x0000000180858050

	// Methods
	private void OnValidate(); // 0x00000001808578D0-0x0000000180857950
	public override bool Collide(ref Vector3 particlePosition, float particleRadius); // 0x00000001808568E0-0x0000000180856FA0
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius); // 0x0000000180857E70-0x0000000180858040
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius); // 0x0000000180857460-0x0000000180857620
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius); // 0x0000000180857950-0x0000000180857E70
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius); // 0x0000000180856FA0-0x0000000180857460
	private void OnDrawGizmosSelected(); // 0x0000000180857620-0x00000001808578D0
}

