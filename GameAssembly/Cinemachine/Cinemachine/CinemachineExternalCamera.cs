/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180121CD0-0x0000000180121D80
	[DisallowMultipleComponent] // 0x0000000180121CD0-0x0000000180121D80
	[DocumentationSorting] // 0x0000000180121CD0-0x0000000180121D80
	[ExecuteAlways] // 0x0000000180121CD0-0x0000000180121D80
	[RequireComponent] // 0x0000000180121CD0-0x0000000180121D80
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7279
	{
		// Fields
		[NoSaveDuringPlay] // 0x0000000180122200-0x0000000180122240
		[Tooltip] // 0x0000000180122200-0x0000000180122240
		public Transform m_LookAt; // 0x78
		private Camera m_Camera; // 0x80
		private CameraState m_State; // 0x88
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform <Follow>k__BackingField; // 0x168
		[FormerlySerializedAs] // 0x00000001801225B0-0x0000000180122610
		[Tooltip] // 0x00000001801225B0-0x0000000180122610
		public BlendHint m_BlendHint; // 0x170
	
		// Properties
		public override CameraState State { get; } // 0x00000001818B95E0-0x00000001818B9670 
		public override Transform LookAt { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		public override Transform Follow { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001810E2310-0x00000001810E2320 0x00000001817D35D0-0x00000001817D35E0
	
		// Constructors
		public CinemachineExternalCamera(); // 0x00000001818B94F0-0x00000001818B95E0
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001818B8E60-0x00000001818B94F0
	}
}
