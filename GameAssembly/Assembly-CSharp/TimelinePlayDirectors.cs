/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180153E00-0x0000000180153E30
public class TimelinePlayDirectors : ManagedBehaviour // TypeDefIndex: 11907
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool playOnStart; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private PlayableDirector[] playableDirectors; // 0x58

	// Constructors
	public TimelinePlayDirectors(); // 0x0000000180FA2080-0x0000000180FA20E0

	// Methods
	public override void MStart(); // 0x0000000180FA1E30-0x0000000180FA1F60
	public void Play(); // 0x0000000180FA1F60-0x0000000180FA2080
}

