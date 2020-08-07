/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CutsceneTrigger : MonoBehaviour // TypeDefIndex: 11875
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Cutscene _cutsceneToPlay; // 0x20

	// Properties
	private CinematicManager CinematicManager { get; } // 0x0000000180553590-0x0000000180553630 

	// Constructors
	public CutsceneTrigger(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnTriggerEnter(Collider other); // 0x0000000180553510-0x0000000180553590
	protected virtual bool IsTriggerConditionMet(Collider other); // 0x0000000180380B60-0x0000000180380B70
}

