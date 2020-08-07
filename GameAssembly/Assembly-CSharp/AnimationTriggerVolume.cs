/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x0000000180202890-0x00000001802028E0
public class AnimationTriggerVolume : ManagedBehaviour // TypeDefIndex: 14276
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Animator _animator; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _triggerEnterAnimVar; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _triggerExitAnimVar; // 0x60

	// Constructors
	public AnimationTriggerVolume(); // 0x0000000182155BB0-0x0000000182155C20

	// Methods
	private void OnTriggerEnter(Collider inCollider); // 0x00000001821559B0-0x0000000182155A80
	private void OnTriggerExit(Collider inCollider); // 0x0000000182155A80-0x0000000182155B50
	private void TriggerEnter(); // 0x0000000182155B50-0x0000000182155B80
	private void TriggerExit(); // 0x0000000182155B80-0x0000000182155BB0
}

