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
	[AddComponentMenu] // 0x0000000180145B70-0x0000000180145BD0
	[DocumentationSorting] // 0x0000000180145B70-0x0000000180145BD0
	[SaveDuringPlay] // 0x0000000180145B70-0x0000000180145BD0
	public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 7324
	{
		// Fields
		[AxisStateProperty] // 0x0000000180145EE0-0x0000000180145F30
		[Tooltip] // 0x0000000180145EE0-0x0000000180145F30
		public AxisState m_VerticalAxis; // 0x50
		[Tooltip] // 0x00000001801460E0-0x0000000180146110
		public AxisState.Recentering m_VerticalRecentering; // 0xA0
		[AxisStateProperty] // 0x0000000180146230-0x0000000180146280
		[Tooltip] // 0x0000000180146230-0x0000000180146280
		public AxisState m_HorizontalAxis; // 0xC0
		[Tooltip] // 0x0000000180146560-0x0000000180146590
		public AxisState.Recentering m_HorizontalRecentering; // 0x110
	
		// Properties
		public override bool IsValid { get; } // 0x00000001817D4210-0x00000001817D4220 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018042E670-0x000000018042E680 
	
		// Constructors
		public CinemachinePOV(); // 0x00000001817D3FC0-0x00000001817D4210
	
		// Methods
		private void OnValidate(); // 0x00000001817D3F70-0x00000001817D3FC0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001817D35E0-0x00000001817D3930
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x00000001817D3930-0x00000001817D3F70
	}
}
