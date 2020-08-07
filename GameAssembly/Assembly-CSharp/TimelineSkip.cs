/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x0000000180239FC0-0x0000000180239FF0
public class TimelineSkip : ManagedBehaviour // TypeDefIndex: 13446
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private PlayableDirector playableDirector; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float[] skipTimes; // 0x58

	// Constructors
	public TimelineSkip(); // 0x0000000180F903A0-0x0000000180F90400

	// Methods
	public void Skip(); // 0x0000000180F90200-0x0000000180F903A0
	public void SkipAll(); // 0x0000000180F90100-0x0000000180F90200
}

