/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800B36B0-0x00000001800B36C0
public class ActorBaseDataObject : ScriptableObject // TypeDefIndex: 10032
{
	// Fields
	public RuntimeAnimatorController animatorController; // 0x18
	public List<RuntimeAnimatorController> stanceOverrides; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private AudioActor _audioActor; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _flyingActor; // 0x30

	// Properties
	public AudioActor audioActor { get; } // 0x0000000180369B60-0x0000000180369B70 
	public bool flyingActor { get; } // 0x000000018048B840-0x000000018048B850 

	// Constructors
	public ActorBaseDataObject(); // 0x0000000181401370-0x00000001814013D0
}

