/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class TimelineEventClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 11903
{
	// Fields
	public TimelineEventBehaviour template; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject <TrackTargetObject>k__BackingField; // 0x20

	// Properties
	public GameObject TrackTargetObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	public ClipCaps clipCaps { get; } // 0x000000018035FCC0-0x000000018035FCD0 

	// Constructors
	public TimelineEventClip(); // 0x0000000181A0D5C0-0x0000000181A0D620

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000181A0D4B0-0x0000000181A0D5C0
}

