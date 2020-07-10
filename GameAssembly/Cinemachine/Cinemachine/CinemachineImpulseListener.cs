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
	public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 7392
	{
		// Fields
		[CinemachineImpulseChannelProperty] // 0x000000018016A9F0-0x000000018016AA40
		[Tooltip] // 0x000000018016A9F0-0x000000018016AA40
		public int m_ChannelMask; // 0x28
		[Tooltip] // 0x000000018016ABE0-0x000000018016AC10
		public float m_Gain; // 0x2C
		[Tooltip] // 0x000000018016AD90-0x000000018016ADC0
		public bool m_Use2DDistance; // 0x30
	
		// Constructors
		public CinemachineImpulseListener(); // 0x00000001817CF610-0x00000001817CF630
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001817CF390-0x00000001817CF610
	}
}
