/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview // TypeDefIndex: 7423
{
	// Fields
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x18

	// Constructors
	public CinemachineShot(); // 0x000000018069E0F0-0x000000018069E100

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000181FF3BA0-0x0000000181FF3CC0
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x0000000181FF3CC0-0x0000000181FF3DC0
}

