/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180128440-0x00000001801284B0
	[DisallowMultipleComponent] // 0x0000000180128440-0x00000001801284B0
	[DocumentationSorting] // 0x0000000180128440-0x00000001801284B0
	[ExecuteAlways] // 0x0000000180128440-0x00000001801284B0
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7286
	{
		// Fields
		public const int MaxCameras = 8; // Metadata: 0x007417E3
		[Tooltip] // 0x00000001801286B0-0x00000001801286E0
		public float m_Weight0; // 0x78
		[Tooltip] // 0x0000000180128870-0x00000001801288A0
		public float m_Weight1; // 0x7C
		[Tooltip] // 0x0000000180128AA0-0x0000000180128AD0
		public float m_Weight2; // 0x80
		[Tooltip] // 0x0000000180128E40-0x0000000180128E70
		public float m_Weight3; // 0x84
		[Tooltip] // 0x0000000180128F80-0x0000000180128FB0
		public float m_Weight4; // 0x88
		[Tooltip] // 0x0000000180129200-0x0000000180129230
		public float m_Weight5; // 0x8C
		[Tooltip] // 0x00000001801293F0-0x0000000180129420
		public float m_Weight6; // 0x90
		[Tooltip] // 0x00000001801294E0-0x0000000180129510
		public float m_Weight7; // 0x94
		private CameraState m_State; // 0x98
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0x178
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform <LookAt>k__BackingField; // 0x180
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform <Follow>k__BackingField; // 0x188
		private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x190
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x198
	
		// Properties
		private ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018081E150-0x000000018081E160 0x00000001807E5570-0x00000001807E5580
		public override CameraState State { get; } // 0x00000001817D13B0-0x00000001817D1440 
		public override Transform LookAt { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018081E0E0-0x000000018081E0F0 0x000000018139CF90-0x000000018139CFA0
		public override Transform Follow { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001810E2330-0x00000001810E2340 0x00000001817D1440-0x00000001817D1450
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x00000001817D1390-0x00000001817D13B0 
	
		// Constructors
		public CinemachineMixingCamera(); // 0x00000001817D1260-0x00000001817D1390
	
		// Methods
		public float GetWeight(int index); // 0x00000001817D00F0-0x00000001817D0250
		public void SetWeight(int index, float w); // 0x00000001817D0C60-0x00000001817D0DF0
		public float GetWeight(CinemachineVirtualCameraBase vcam); // 0x00000001817CFEC0-0x00000001817D00F0
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w); // 0x00000001817D0DF0-0x00000001817D1050
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001817D08E0-0x00000001817D09D0
		protected override void OnEnable(); // 0x00000001817D08B0-0x00000001817D08E0
		public void OnTransformChildrenChanged(); // 0x00000001817D07C0-0x00000001817D07E0
		protected override void OnValidate(); // 0x00000001817D0B60-0x00000001817D0C60
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007417E2 */); // 0x00000001817D07E0-0x00000001817D08B0
		protected void InvalidateListOfChildren(); // 0x00000001817D07C0-0x00000001817D07E0
		protected void ValidateListOfChildren(); // 0x00000001817D1050-0x00000001817D1260
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001817D09D0-0x00000001817D0B60
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001817D0250-0x00000001817D07C0
	}
}
