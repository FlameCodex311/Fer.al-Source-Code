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

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview // TypeDefIndex: 7257
{
	// Fields
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x18

	// Constructors
	public CinemachineShot(); // 0x00000001805E3F50-0x00000001805E3F60

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x00000001822C16E0-0x00000001822C1800
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x00000001822C1800-0x00000001822C1900
}

