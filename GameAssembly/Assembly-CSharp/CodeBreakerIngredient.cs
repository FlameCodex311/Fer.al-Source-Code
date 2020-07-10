/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerIngredient : MonoBehaviour // TypeDefIndex: 12890
{
	// Fields
	public CodeColor color; // 0x20
	private const float kDestroyFallHeight = -20f; // Metadata: 0x00783300
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Rigidbody <RigidBody>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Collider <Collider>k__BackingField; // 0x30

	// Properties
	public Rigidbody RigidBody { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	public Collider Collider { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810

	// Constructors
	public CodeBreakerIngredient(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000181270EA0-0x0000000181270EF0
	private void Update(); // 0x0000000181271100-0x00000001812711A0
	public void SetPhysics(bool inKinematic, bool inColliderEnabled); // 0x0000000181271010-0x0000000181271100
	public void Push(Vector3 force); // 0x0000000181270F60-0x0000000181271010
	private void OnCollisionEnter(Collision collision); // 0x0000000181270EF0-0x0000000181270F60
}

