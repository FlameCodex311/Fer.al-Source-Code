/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class TimelineEventClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 13439
{
	// Fields
	public TimelineEventBehaviour template; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject <TrackTargetObject>k__BackingField; // 0x20

	// Properties
	public GameObject TrackTargetObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	public ClipCaps clipCaps { get; } // 0x000000018037DDC0-0x000000018037DDD0 

	// Constructors
	public TimelineEventClip(); // 0x0000000180F8E9F0-0x0000000180F8EA50

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000180F8E8F0-0x0000000180F8E9F0
}

