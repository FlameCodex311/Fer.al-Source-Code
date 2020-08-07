/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerIngredient : MonoBehaviour // TypeDefIndex: 10555
{
	// Fields
	public CodeColor color; // 0x20
	private const float kDestroyFallHeight = -20f; // Metadata: 0x0077BDAB
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rigidbody <RigidBody>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Collider <Collider>k__BackingField; // 0x30

	// Properties
	public Rigidbody RigidBody { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	public Collider Collider { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0

	// Constructors
	public CodeBreakerIngredient(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001805294C0-0x0000000180529510
	private void Update(); // 0x0000000180529720-0x00000001805297C0
	public void SetPhysics(bool inKinematic, bool inColliderEnabled); // 0x0000000180529630-0x0000000180529720
	public void Push(Vector3 force); // 0x0000000180529580-0x0000000180529630
	private void OnCollisionEnter(Collision collision); // 0x0000000180529510-0x0000000180529580
}

