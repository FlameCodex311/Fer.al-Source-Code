/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801CDAD0-0x00000001801CDAE0
public class ActorBaseDataObject : ScriptableObject // TypeDefIndex: 11523
{
	// Fields
	public RuntimeAnimatorController animatorController; // 0x18
	public List<RuntimeAnimatorController> stanceOverrides; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private AudioActor _audioActor; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _flyingActor; // 0x30

	// Properties
	public AudioActor audioActor { get; } // 0x00000001803745B0-0x00000001803745C0 
	public bool flyingActor { get; } // 0x0000000180455B90-0x0000000180455BA0 

	// Constructors
	public ActorBaseDataObject(); // 0x00000001821D3220-0x00000001821D3280
}

