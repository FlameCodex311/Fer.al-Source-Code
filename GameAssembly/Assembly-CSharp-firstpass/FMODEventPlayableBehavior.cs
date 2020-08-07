/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

public class FMODEventPlayableBehavior : PlayableBehaviour // TypeDefIndex: 9695
{
	// Fields
	public string eventName; // 0x10
	public STOP_MODE stopType; // 0x18
	public ParamRef[] parameters; // 0x20
	public GameObject TrackTargetObject; // 0x28
	public TimelineClip OwningClip; // 0x30
	private bool isPlayheadInside; // 0x38
	private EventInstance eventInstance; // 0x40

	// Constructors
	public FMODEventPlayableBehavior(); // 0x0000000180D22180-0x0000000180D221D0

	// Methods
	protected void PlayEvent(); // 0x0000000180D21DB0-0x0000000180D220B0
	public void OnEnter(); // 0x0000000180D21C40-0x0000000180D21C60
	public void OnExit(); // 0x0000000180D21C60-0x0000000180D21CC0
	public void UpdateBehaviour(float time); // 0x0000000180D220B0-0x0000000180D22180
	public override void OnGraphStop(Playable playable); // 0x0000000180D21CC0-0x0000000180D21DB0
}

