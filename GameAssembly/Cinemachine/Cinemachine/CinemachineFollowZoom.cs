/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180122B40-0x0000000180122BB0
	[DocumentationSorting] // 0x0000000180122B40-0x0000000180122BB0
	[ExecuteAlways] // 0x0000000180122B40-0x0000000180122BB0
	[SaveDuringPlay] // 0x0000000180122B40-0x0000000180122BB0
	public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 7280
	{
		// Fields
		[Tooltip] // 0x0000000180122E70-0x0000000180122EA0
		public float m_Width; // 0x28
		[Range] // 0x0000000180124410-0x0000000180124460
		[Tooltip] // 0x0000000180124410-0x0000000180124460
		public float m_Damping; // 0x2C
		[Range] // 0x00000001801246A0-0x0000000180124700
		[Tooltip] // 0x00000001801246A0-0x0000000180124700
		public float m_MinFOV; // 0x30
		[Range] // 0x0000000180124800-0x0000000180124860
		[Tooltip] // 0x0000000180124800-0x0000000180124860
		public float m_MaxFOV; // 0x34
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 7281
		{
			// Fields
			public float m_previousFrameZoom; // 0x10
	
			// Constructors
			public VcamExtraState(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public CinemachineFollowZoom(); // 0x00000001818B9E10-0x00000001818B9E40
	
		// Methods
		private void OnValidate(); // 0x00000001818B99D0-0x00000001818B9A80
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001818B9A80-0x00000001818B9E10
	}
}
