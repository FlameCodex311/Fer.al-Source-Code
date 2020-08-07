/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180289AB0-0x0000000180289B60
	[DisallowMultipleComponent] // 0x0000000180289AB0-0x0000000180289B60
	[DocumentationSorting] // 0x0000000180289AB0-0x0000000180289B60
	[ExecuteAlways] // 0x0000000180289AB0-0x0000000180289B60
	[RequireComponent] // 0x0000000180289AB0-0x0000000180289B60
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7445
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018028A0D0-0x000000018028A110
		[Tooltip] // 0x000000018028A0D0-0x000000018028A110
		public Transform m_LookAt; // 0x78
		private Camera m_Camera; // 0x80
		private CameraState m_State; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform <Follow>k__BackingField; // 0x168
		[FormerlySerializedAs] // 0x00000001801FF4C0-0x00000001801FF520
		[Tooltip] // 0x00000001801FF4C0-0x00000001801FF520
		public BlendHint m_BlendHint; // 0x170
	
		// Properties
		public override CameraState State { get; } // 0x000000018135F8B0-0x000000018135F940 
		public override Transform LookAt { get; set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
		public override Transform Follow { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018058C840-0x000000018058C850 0x0000000180652BD0-0x0000000180652BE0
	
		// Constructors
		public CinemachineExternalCamera(); // 0x000000018135F7C0-0x000000018135F8B0
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018135F140-0x000000018135F7C0
	}
}
