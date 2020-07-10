/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

[Serializable]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 9289
{
	// Fields
	public FMODEventPlayableBehavior template; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject <TrackTargetObject>k__BackingField; // 0x20
	public float eventLength; // 0x28
	private FMODEventPlayableBehavior behavior; // 0x30
	[EventRef] // 0x00000001800E5D10-0x00000001800E5D40
	[SerializeField] // 0x00000001800E5D10-0x00000001800E5D40
	public string eventName; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public STOP_MODE stopType; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public ParamRef[] parameters; // 0x48
	[NonSerialized]
	public bool cachedParameters; // 0x50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private TimelineClip <OwningClip>k__BackingField; // 0x58

	// Properties
	public GameObject TrackTargetObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	public override double duration { get; } // 0x0000000181B25AC0-0x0000000181B25AE0 
	public ClipCaps clipCaps { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	public TimelineClip OwningClip { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80

	// Constructors
	public FMODEventPlayable(); // 0x0000000181B25A20-0x0000000181B25AC0

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000181B25730-0x0000000181B25A20
}

