/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x000000018028E680-0x000000018028E6F0
	[DisallowMultipleComponent] // 0x000000018028E680-0x000000018028E6F0
	[DocumentationSorting] // 0x000000018028E680-0x000000018028E6F0
	[ExecuteAlways] // 0x000000018028E680-0x000000018028E6F0
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7452
	{
		// Fields
		public const int MaxCameras = 8; // Metadata: 0x007764D1
		[Tooltip] // 0x000000018028EB90-0x000000018028EBC0
		public float m_Weight0; // 0x78
		[Tooltip] // 0x000000018028EC90-0x000000018028ECC0
		public float m_Weight1; // 0x7C
		[Tooltip] // 0x000000018028ECC0-0x000000018028ECF0
		public float m_Weight2; // 0x80
		[Tooltip] // 0x000000018028EEC0-0x000000018028EEF0
		public float m_Weight3; // 0x84
		[Tooltip] // 0x000000018028F010-0x000000018028F040
		public float m_Weight4; // 0x88
		[Tooltip] // 0x000000018028F120-0x000000018028F150
		public float m_Weight5; // 0x8C
		[Tooltip] // 0x000000018028F380-0x000000018028F3B0
		public float m_Weight6; // 0x90
		[Tooltip] // 0x000000018028F4E0-0x000000018028F510
		public float m_Weight7; // 0x94
		private CameraState m_State; // 0x98
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0x178
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform <LookAt>k__BackingField; // 0x180
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform <Follow>k__BackingField; // 0x188
		private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x190
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x198
	
		// Properties
		private ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803EF200-0x00000001803EF210 0x0000000180BF61B0-0x0000000180BF61C0
		public override CameraState State { get; } // 0x000000018138D410-0x000000018138D4A0 
		public override Transform LookAt { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803EF210-0x00000001803EF220 0x0000000180AD4130-0x0000000180AD4140
		public override Transform Follow { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018058C810-0x000000018058C820 0x000000018138D4A0-0x000000018138D4B0
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x000000018138D3F0-0x000000018138D410 
	
		// Constructors
		public CinemachineMixingCamera(); // 0x000000018138D2C0-0x000000018138D3F0
	
		// Methods
		public float GetWeight(int index); // 0x000000018138C1E0-0x000000018138C340
		public void SetWeight(int index, float w); // 0x000000018138CCD0-0x000000018138CE60
		public float GetWeight(CinemachineVirtualCameraBase vcam); // 0x000000018138BFB0-0x000000018138C1E0
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w); // 0x000000018138CE60-0x000000018138D0C0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018138C9C0-0x000000018138CAB0
		protected override void OnEnable(); // 0x000000018138C990-0x000000018138C9C0
		public void OnTransformChildrenChanged(); // 0x000000018138C8A0-0x000000018138C8C0
		protected override void OnValidate(); // 0x000000018138CC20-0x000000018138CCD0
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007764D0 */); // 0x000000018138C8C0-0x000000018138C990
		protected void InvalidateListOfChildren(); // 0x000000018138C8A0-0x000000018138C8C0
		protected void ValidateListOfChildren(); // 0x000000018138D0C0-0x000000018138D2C0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x000000018138CAB0-0x000000018138CC20
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018138C340-0x000000018138C8A0
	}
}
