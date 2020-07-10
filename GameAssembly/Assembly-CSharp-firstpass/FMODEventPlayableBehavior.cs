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

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public class FMODEventPlayableBehavior : PlayableBehaviour // TypeDefIndex: 9291
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
	public FMODEventPlayableBehavior(); // 0x0000000181B256E0-0x0000000181B25730

	// Methods
	protected void PlayEvent(); // 0x0000000181B25120-0x0000000181B25610
	public void OnEnter(); // 0x0000000181B24F40-0x0000000181B24F60
	public void OnExit(); // 0x0000000181B24F60-0x0000000181B24FC0
	public void UpdateBehaviour(float time); // 0x0000000181B25610-0x0000000181B256E0
	public override void OnGraphStop(Playable playable); // 0x0000000181B24FC0-0x0000000181B25120
}

