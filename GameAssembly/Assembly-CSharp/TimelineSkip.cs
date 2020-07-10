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
public class TimelineSkip : ManagedBehaviour // TypeDefIndex: 11910
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private PlayableDirector playableDirector; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float[] skipTimes; // 0x58

	// Constructors
	public TimelineSkip(); // 0x0000000180FA24E0-0x0000000180FA2540

	// Methods
	public void Skip(); // 0x0000000180FA2330-0x0000000180FA24E0
	public void SkipAll(); // 0x0000000180FA2230-0x0000000180FA2330
}

