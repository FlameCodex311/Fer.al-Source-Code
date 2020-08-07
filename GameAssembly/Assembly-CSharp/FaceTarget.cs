/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FaceTarget : ManagedBehaviour // TypeDefIndex: 10437
{
	// Fields
	private float _rotationSpeed; // 0x50
	public Transform _headNode; // 0x58
	private Transform _target; // 0x60
	public Transform initialTarget; // 0x68
	public Transform aradiaTarget; // 0x70
	public Transform delilahTarget; // 0x78
	public Transform wideCameraTarget; // 0x80
	public Transform aradiaCameraTarget; // 0x88
	public Transform delilahCameraTarget; // 0x90
	private Quaternion _initialHeadRotation; // 0x98
	private Quaternion _desiredHeadRotation; // 0xA8
	private float time; // 0xB8

	// Properties
	public Transform Target { set; } // 0x00000001804AF510-0x00000001804AF520

	// Constructors
	public FaceTarget(); // 0x0000000180867A10-0x0000000180867A70

	// Methods
	public override void MStart(); // 0x0000000180867750-0x00000001808677A0
	public override void MUpdate(); // 0x00000001808677A0-0x00000001808678F0
	public void LateUpdate(); // 0x0000000180867510-0x00000001808676B0
	public void SetNewTarget(string newTarget); // 0x00000001808678F0-0x0000000180867A10
	public void LookAtAradia(); // 0x00000001808676D0-0x00000001808676F0
	public void LookAtDelilah(); // 0x0000000180867710-0x0000000180867730
	public void LookAtWideCamera(); // 0x0000000180867730-0x0000000180867750
	public void LookAtAradiaCamera(); // 0x00000001808676B0-0x00000001808676D0
	public void LookAtDelilahCamera(); // 0x00000001808676F0-0x0000000180867710
}

