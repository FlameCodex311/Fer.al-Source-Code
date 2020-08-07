/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FaceCamera : ManagedBehaviour // TypeDefIndex: 11943
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _reverse; // 0x50
	[DeComment] // 0x00000001801ECB00-0x00000001801ECB50
	[SerializeField] // 0x00000001801ECB00-0x00000001801ECB50
	private Camera _mainCamera; // 0x58

	// Properties
	private Camera MainCamera { get; } // 0x0000000180866300-0x0000000180866380 

	// Constructors
	public FaceCamera(); // 0x00000001808662A0-0x0000000180866300

	// Methods
	public override void MOnEnable(); // 0x0000000180865EC0-0x0000000180865F80
	public override void MUpdate(); // 0x0000000180865F80-0x00000001808662A0
}

