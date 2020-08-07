/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x000000018020AB20-0x000000018020AB90
	[DocumentationSorting] // 0x000000018020AB20-0x000000018020AB90
	[ExecuteAlways] // 0x000000018020AB20-0x000000018020AB90
	[SaveDuringPlay] // 0x000000018020AB20-0x000000018020AB90
	public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 7446
	{
		// Fields
		[Tooltip] // 0x000000018028AAE0-0x000000018028AB10
		public float m_Width; // 0x28
		[Range] // 0x000000018028AE10-0x000000018028AE60
		[Tooltip] // 0x000000018028AE10-0x000000018028AE60
		public float m_Damping; // 0x2C
		[Range] // 0x000000018028AF40-0x000000018028AFA0
		[Tooltip] // 0x000000018028AF40-0x000000018028AFA0
		public float m_MinFOV; // 0x30
		[Range] // 0x000000018028B150-0x000000018028B1B0
		[Tooltip] // 0x000000018028B150-0x000000018028B1B0
		public float m_MaxFOV; // 0x34
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 7447
		{
			// Fields
			public float m_previousFrameZoom; // 0x10
	
			// Constructors
			public VcamExtraState(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public CinemachineFollowZoom(); // 0x00000001813600E0-0x0000000181360110
	
		// Methods
		private void OnValidate(); // 0x000000018135FCA0-0x000000018135FD50
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018135FD50-0x00000001813600E0
	}
}
