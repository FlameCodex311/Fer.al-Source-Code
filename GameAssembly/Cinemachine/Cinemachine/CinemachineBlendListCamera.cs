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
	[AddComponentMenu] // 0x0000000180112A40-0x0000000180112AB0
	[DisallowMultipleComponent] // 0x0000000180112A40-0x0000000180112AB0
	[DocumentationSorting] // 0x0000000180112A40-0x0000000180112AB0
	[ExecuteAlways] // 0x0000000180112A40-0x0000000180112AB0
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7260
	{
		// Fields
		[NoSaveDuringPlay] // 0x0000000180112D20-0x0000000180112D70
		[Tooltip] // 0x0000000180112D20-0x0000000180112D70
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000180112E40-0x0000000180112E80
		[Tooltip] // 0x0000000180112E40-0x0000000180112E80
		public Transform m_Follow; // 0x80
		[Tooltip] // 0x0000000180113150-0x0000000180113180
		public bool m_ShowDebugText; // 0x88
		[Tooltip] // 0x00000001801131E0-0x0000000180113210
		public bool m_Loop; // 0x89
		[HideInInspector] // 0x00000001801132D0-0x0000000180113310
		[NoSaveDuringPlay] // 0x00000001801132D0-0x0000000180113310
		[SerializeField] // 0x00000001801132D0-0x0000000180113310
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x90
		[Tooltip] // 0x00000001801134C0-0x00000001801134F0
		public Instruction[] m_Instructions; // 0x98
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0xA8
		private CameraState m_State; // 0xB0
		private float mActivationTime; // 0x190
		private int mCurrentInstruction; // 0x194
		private CinemachineBlend mActiveBlend; // 0x198
	
		// Properties
		public override string Description { get; } // 0x00000001818A6AC0-0x00000001818A6BB0 
		public ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0
		public override CameraState State { get; } // 0x00000001818A6BC0-0x00000001818A6C50 
		public override Transform LookAt { get; set; } // 0x00000001817DA950-0x00000001817DA960 0x00000001803D8EF0-0x00000001803D8F00
		public override Transform Follow { get; set; } // 0x00000001817DA930-0x00000001817DA940 0x00000001803D8ED0-0x00000001803D8EE0
		private ICinemachineCamera TransitioningFrom { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180382A90-0x0000000180382AA0 0x00000001804A1230-0x00000001804A1240
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x00000001818A6AA0-0x00000001818A6AC0 
		public bool IsBlending { get; } // 0x00000001818A6BB0-0x00000001818A6BC0 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 7261
		{
			// Fields
			[Tooltip] // 0x0000000180114EF0-0x0000000180114F20
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x00
			[Tooltip] // 0x00000001801150F0-0x0000000180115120
			public float m_Hold; // 0x08
			[CinemachineBlendDefinitionProperty] // 0x0000000180115220-0x0000000180115270
			[Tooltip] // 0x0000000180115220-0x0000000180115270
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlendListCamera(); // 0x00000001818A69B0-0x00000001818A6AA0
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007417AA */); // 0x00000001818A6050-0x00000001818A6080
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001818A6430-0x00000001818A6520
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001818A6520-0x00000001818A65E0
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001818A5B10-0x00000001818A6030
		protected override void OnEnable(); // 0x00000001818A6150-0x00000001818A62B0
		protected override void OnDisable(); // 0x00000001818A6080-0x00000001818A6150
		private void OnTransformChildrenChanged(); // 0x00000001818A6030-0x00000001818A6050
		private void OnGuiHandler(); // 0x00000001818A62B0-0x00000001818A6430
		private void InvalidateListOfChildren(); // 0x00000001818A6030-0x00000001818A6050
		private void UpdateListOfChildren(); // 0x00000001818A65E0-0x00000001818A67A0
		internal void ValidateInstructions(); // 0x00000001818A67A0-0x00000001818A69B0
		private void AdvanceCurrentInstruction(float deltaTime); // 0x00000001818A58D0-0x00000001818A5B10
	}
}
