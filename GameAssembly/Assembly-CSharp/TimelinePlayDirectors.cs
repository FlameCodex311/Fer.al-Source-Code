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
public class TimelinePlayDirectors : ManagedBehaviour // TypeDefIndex: 13443
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool playOnStart; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private PlayableDirector[] playableDirectors; // 0x58

	// Constructors
	public TimelinePlayDirectors(); // 0x0000000180F8FF50-0x0000000180F8FFB0

	// Methods
	public override void MStart(); // 0x0000000180F8FD00-0x0000000180F8FE30
	public void Play(); // 0x0000000180F8FE30-0x0000000180F8FF50
}

