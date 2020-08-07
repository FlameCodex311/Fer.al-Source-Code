/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 7419
{
	// Fields
	[Tooltip] // 0x000000018027C610-0x000000018027C640
	public Vector3 m_Offset; // 0x28
	[Tooltip] // 0x000000018027C780-0x000000018027C7B0
	public CinemachineCore.Stage m_ApplyAfter; // 0x34

	// Constructors
	public CinemachineCameraOffset(); // 0x0000000181FF1B30-0x0000000181FF1BB0

	// Methods
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000181FF19A0-0x0000000181FF1B30
}

