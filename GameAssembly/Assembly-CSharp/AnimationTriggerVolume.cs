/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x0000000180113020-0x0000000180113070
public class AnimationTriggerVolume : ManagedBehaviour // TypeDefIndex: 12707
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Animator _animator; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _triggerEnterAnimVar; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _triggerExitAnimVar; // 0x60

	// Constructors
	public AnimationTriggerVolume(); // 0x000000018103C9B0-0x000000018103CA20

	// Methods
	private void OnTriggerEnter(Collider inCollider); // 0x000000018103C7B0-0x000000018103C880
	private void OnTriggerExit(Collider inCollider); // 0x000000018103C880-0x000000018103C950
	private void TriggerEnter(); // 0x000000018103C950-0x000000018103C980
	private void TriggerExit(); // 0x000000018103C980-0x000000018103C9B0
}

