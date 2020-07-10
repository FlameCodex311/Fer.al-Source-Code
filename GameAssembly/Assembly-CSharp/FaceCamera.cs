/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FaceCamera : ManagedBehaviour // TypeDefIndex: 10433
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _reverse; // 0x50
	[DeComment] // 0x000000018010FF60-0x000000018010FFB0
	[SerializeField] // 0x000000018010FF60-0x000000018010FFB0
	private Camera _mainCamera; // 0x58

	// Properties
	private Camera MainCamera { get; } // 0x000000018148E940-0x000000018148E9C0 

	// Constructors
	public FaceCamera(); // 0x000000018148E8E0-0x000000018148E940

	// Methods
	public override void MOnEnable(); // 0x000000018148E4E0-0x000000018148E5B0
	public override void MUpdate(); // 0x000000018148E5B0-0x000000018148E8E0
}

