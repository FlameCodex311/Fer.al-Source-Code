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

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

[Serializable]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 9693
{
	// Fields
	public FMODEventPlayableBehavior template; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject <TrackTargetObject>k__BackingField; // 0x20
	public float eventLength; // 0x28
	private FMODEventPlayableBehavior behavior; // 0x30
	[EventRef] // 0x00000001801E59A0-0x00000001801E59D0
	[SerializeField] // 0x00000001801E59A0-0x00000001801E59D0
	public string eventName; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	public STOP_MODE stopType; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	public ParamRef[] parameters; // 0x48
	[NonSerialized]
	public bool cachedParameters; // 0x50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TimelineClip <OwningClip>k__BackingField; // 0x58

	// Properties
	public GameObject TrackTargetObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	public override double duration { get; } // 0x0000000180D22560-0x0000000180D22580 
	public ClipCaps clipCaps { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	public TimelineClip OwningClip { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750

	// Constructors
	public FMODEventPlayable(); // 0x0000000180D224C0-0x0000000180D22560

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000180D221D0-0x0000000180D224C0
}

