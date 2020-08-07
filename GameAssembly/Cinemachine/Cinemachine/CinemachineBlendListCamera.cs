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
	[AddComponentMenu] // 0x000000018027CCA0-0x000000018027CD10
	[DisallowMultipleComponent] // 0x000000018027CCA0-0x000000018027CD10
	[DocumentationSorting] // 0x000000018027CCA0-0x000000018027CD10
	[ExecuteAlways] // 0x000000018027CCA0-0x000000018027CD10
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7426
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018027CFB0-0x000000018027D000
		[Tooltip] // 0x000000018027CFB0-0x000000018027D000
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x000000018027D280-0x000000018027D2C0
		[Tooltip] // 0x000000018027D280-0x000000018027D2C0
		public Transform m_Follow; // 0x80
		[Tooltip] // 0x000000018027D5B0-0x000000018027D5E0
		public bool m_ShowDebugText; // 0x88
		[Tooltip] // 0x000000018027D8A0-0x000000018027D8D0
		public bool m_Loop; // 0x89
		[HideInInspector] // 0x00000001801FE900-0x00000001801FE940
		[NoSaveDuringPlay] // 0x00000001801FE900-0x00000001801FE940
		[SerializeField] // 0x00000001801FE900-0x00000001801FE940
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x90
		[Tooltip] // 0x000000018027DC40-0x000000018027DC70
		public Instruction[] m_Instructions; // 0x98
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0xA8
		private CameraState m_State; // 0xB0
		private float mActivationTime; // 0x190
		private int mCurrentInstruction; // 0x194
		private CinemachineBlend mActiveBlend; // 0x198
	
		// Properties
		public override string Description { get; } // 0x000000018134CF60-0x000000018134D050 
		public ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460
		public override CameraState State { get; } // 0x000000018134D080-0x000000018134D110 
		public override Transform LookAt { get; set; } // 0x000000018134D070-0x000000018134D080 0x00000001804B47D0-0x00000001804B47E0
		public override Transform Follow { get; set; } // 0x000000018134D050-0x000000018134D060 0x00000001804793A0-0x00000001804793B0
		private ICinemachineCamera TransitioningFrom { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x000000018134CF40-0x000000018134CF60 
		public bool IsBlending { get; } // 0x000000018134D060-0x000000018134D070 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 7427
		{
			// Fields
			[Tooltip] // 0x000000018027FD70-0x000000018027FDA0
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x00
			[Tooltip] // 0x000000018027FE30-0x000000018027FE60
			public float m_Hold; // 0x08
			[CinemachineBlendDefinitionProperty] // 0x000000018027FFF0-0x0000000180280040
			[Tooltip] // 0x000000018027FFF0-0x0000000180280040
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlendListCamera(); // 0x000000018134CE50-0x000000018134CF40
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x00776498 */); // 0x000000018134C500-0x000000018134C530
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018134C8E0-0x000000018134C9D0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x000000018134C9D0-0x000000018134CA90
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018134BFE0-0x000000018134C4E0
		protected override void OnEnable(); // 0x000000018134C600-0x000000018134C760
		protected override void OnDisable(); // 0x000000018134C530-0x000000018134C600
		private void OnTransformChildrenChanged(); // 0x000000018134C4E0-0x000000018134C500
		private void OnGuiHandler(); // 0x000000018134C760-0x000000018134C8E0
		private void InvalidateListOfChildren(); // 0x000000018134C4E0-0x000000018134C500
		private void UpdateListOfChildren(); // 0x000000018134CA90-0x000000018134CC40
		internal void ValidateInstructions(); // 0x000000018134CC40-0x000000018134CE50
		private void AdvanceCurrentInstruction(float deltaTime); // 0x000000018134BDA0-0x000000018134BFE0
	}
}
