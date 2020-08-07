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
	[AddComponentMenu] // 0x00000001801E3AB0-0x00000001801E3B10
	[DocumentationSorting] // 0x00000001801E3AB0-0x00000001801E3B10
	[SaveDuringPlay] // 0x00000001801E3AB0-0x00000001801E3B10
	public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 7490
	{
		// Fields
		[AxisStateProperty] // 0x00000001801E3E20-0x00000001801E3E70
		[Tooltip] // 0x00000001801E3E20-0x00000001801E3E70
		public AxisState m_VerticalAxis; // 0x50
		[Tooltip] // 0x00000001801E4130-0x00000001801E4160
		public AxisState.Recentering m_VerticalRecentering; // 0xA0
		[AxisStateProperty] // 0x00000001801E4300-0x00000001801E4350
		[Tooltip] // 0x00000001801E4300-0x00000001801E4350
		public AxisState m_HorizontalAxis; // 0xC0
		[Tooltip] // 0x00000001801E4640-0x00000001801E4670
		public AxisState.Recentering m_HorizontalRecentering; // 0x110
	
		// Properties
		public override bool IsValid { get; } // 0x00000001810AE5B0-0x00000001810AE5C0 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018058C710-0x000000018058C720 
	
		// Constructors
		public CinemachinePOV(); // 0x000000018138FD00-0x000000018138FF50
	
		// Methods
		private void OnValidate(); // 0x000000018138FCB0-0x000000018138FD00
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018138F320-0x000000018138F670
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x000000018138F670-0x000000018138FCB0
	}
}
