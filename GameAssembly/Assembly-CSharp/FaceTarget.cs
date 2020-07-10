/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FaceTarget : ManagedBehaviour // TypeDefIndex: 12779
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
	public Transform Target { set; } // 0x00000001803A27E0-0x00000001803A27F0

	// Constructors
	public FaceTarget(); // 0x0000000181490070-0x00000001814900D0

	// Methods
	public override void MStart(); // 0x000000018148FDA0-0x000000018148FDF0
	public override void MUpdate(); // 0x000000018148FDF0-0x000000018148FF50
	public void LateUpdate(); // 0x000000018148FB60-0x000000018148FD00
	public void SetNewTarget(string newTarget); // 0x000000018148FF50-0x0000000181490070
	public void LookAtAradia(); // 0x000000018148FD20-0x000000018148FD40
	public void LookAtDelilah(); // 0x000000018148FD60-0x000000018148FD80
	public void LookAtWideCamera(); // 0x000000018148FD80-0x000000018148FDA0
	public void LookAtAradiaCamera(); // 0x000000018148FD00-0x000000018148FD20
	public void LookAtDelilahCamera(); // 0x000000018148FD40-0x000000018148FD60
}

