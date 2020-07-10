/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 7253
{
	// Fields
	[Tooltip] // 0x00000001801123D0-0x0000000180112400
	public Vector3 m_Offset; // 0x28
	[Tooltip] // 0x0000000180112540-0x0000000180112570
	public CinemachineCore.Stage m_ApplyAfter; // 0x34

	// Constructors
	public CinemachineCameraOffset(); // 0x00000001822C0F10-0x00000001822C0F90

	// Methods
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001822C0D80-0x00000001822C0F10
}

