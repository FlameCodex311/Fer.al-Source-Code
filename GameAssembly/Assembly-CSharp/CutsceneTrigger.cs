/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CutsceneTrigger : MonoBehaviour // TypeDefIndex: 10384
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Cutscene _cutsceneToPlay; // 0x20

	// Properties
	private CinematicManager CinematicManager { get; } // 0x0000000180F40E80-0x0000000180F40F20 

	// Constructors
	public CutsceneTrigger(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnTriggerEnter(Collider other); // 0x0000000180F40E00-0x0000000180F40E80
	protected virtual bool IsTriggerConditionMet(Collider other); // 0x00000001803C29F0-0x00000001803C2A00
}

