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
	public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 7558
	{
		// Fields
		[CinemachineImpulseChannelProperty] // 0x000000018020AE50-0x000000018020AEA0
		[Tooltip] // 0x000000018020AE50-0x000000018020AEA0
		public int m_ChannelMask; // 0x28
		[Tooltip] // 0x000000018020B1C0-0x000000018020B1F0
		public float m_Gain; // 0x2C
		[Tooltip] // 0x000000018020B2C0-0x000000018020B2F0
		public bool m_Use2DDistance; // 0x30
	
		// Constructors
		public CinemachineImpulseListener(); // 0x000000018138B700-0x000000018138B720
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018138B480-0x000000018138B700
	}
}
