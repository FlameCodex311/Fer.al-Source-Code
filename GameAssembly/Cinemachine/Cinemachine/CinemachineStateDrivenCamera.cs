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
	[AddComponentMenu] // 0x000000018012CE20-0x000000018012CE90
	[DisallowMultipleComponent] // 0x000000018012CE20-0x000000018012CE90
	[DocumentationSorting] // 0x000000018012CE20-0x000000018012CE90
	[ExecuteAlways] // 0x000000018012CE20-0x000000018012CE90
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7292
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018012D150-0x000000018012D190
		[Tooltip] // 0x000000018012D150-0x000000018012D190
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000180112E40-0x0000000180112E80
		[Tooltip] // 0x0000000180112E40-0x0000000180112E80
		public Transform m_Follow; // 0x80
		[NoSaveDuringPlay] // 0x000000018012D550-0x000000018012D5B0
		[Space] // 0x000000018012D550-0x000000018012D5B0
		[Tooltip] // 0x000000018012D550-0x000000018012D5B0
		public Animator m_AnimatedTarget; // 0x88
		[NoSaveDuringPlay] // 0x000000018012D8F0-0x000000018012D930
		[Tooltip] // 0x000000018012D8F0-0x000000018012D930
		public int m_LayerIndex; // 0x90
		[Tooltip] // 0x0000000180113150-0x0000000180113180
		public bool m_ShowDebugText; // 0x94
		[HideInInspector] // 0x000000018012DCD0-0x000000018012DD10
		[NoSaveDuringPlay] // 0x000000018012DCD0-0x000000018012DD10
		[SerializeField] // 0x000000018012DCD0-0x000000018012DD10
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x98
		[Tooltip] // 0x000000018012DFD0-0x000000018012E000
		public Instruction[] m_Instructions; // 0xA0
		[CinemachineBlendDefinitionProperty] // 0x000000018012E160-0x000000018012E1A0
		[Tooltip] // 0x000000018012E160-0x000000018012E1A0
		public CinemachineBlendDefinition m_DefaultBlend; // 0xA8
		[Tooltip] // 0x000000018012E450-0x000000018012E480
		public CinemachineBlenderSettings m_CustomBlends; // 0xB8
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		internal ParentHash[] m_ParentHash; // 0xC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0xC8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0xD0
		private CameraState m_State; // 0xD8
		private Dictionary<AnimationClip, List<HashPair>> mHashCache; // 0x1B8
		private float mActivationTime; // 0x1C0
		private Instruction mActiveInstruction; // 0x1C8
		private float mPendingActivationTime; // 0x1E0
		private Instruction mPendingInstruction; // 0x1E8
		private CinemachineBlend mActiveBlend; // 0x200
		private Dictionary<int, int> mInstructionDictionary; // 0x208
		private Dictionary<int, int> mStateParentLookup; // 0x210
		private List<AnimatorClipInfo> m_clipInfoList; // 0x218
	
		// Properties
		public override string Description { get; } // 0x00000001817DA840-0x00000001817DA930 
		public ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
		public override CameraState State { get; } // 0x00000001817DA960-0x00000001817DA9F0 
		public override Transform LookAt { get; set; } // 0x00000001817DA950-0x00000001817DA960 0x00000001803D8EF0-0x00000001803D8F00
		public override Transform Follow { get; set; } // 0x00000001817DA930-0x00000001817DA940 0x00000001803D8ED0-0x00000001803D8EE0
		private ICinemachineCamera TransitioningFrom { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x00000001817DA820-0x00000001817DA840 
		public bool IsBlending { get; } // 0x00000001817DA940-0x00000001817DA950 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 7293
		{
			// Fields
			[Tooltip] // 0x000000018012F110-0x000000018012F140
			public int m_FullHash; // 0x00
			[Tooltip] // 0x000000018012F2A0-0x000000018012F2D0
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x08
			[Tooltip] // 0x000000018012F4E0-0x000000018012F510
			public float m_ActivateAfter; // 0x10
			[Tooltip] // 0x000000018012F680-0x000000018012F6B0
			public float m_MinDuration; // 0x14
		}
	
		[Serializable]
		[DocumentationSorting] // 0x000000018012F850-0x000000018012F870
		internal struct ParentHash // TypeDefIndex: 7294
		{
			// Fields
			public int m_Hash; // 0x00
			public int m_ParentHash; // 0x04
		}
	
		private struct HashPair // TypeDefIndex: 7295
		{
			// Fields
			public int parentHash; // 0x00
			public int hash; // 0x04
		}
	
		// Constructors
		public CinemachineStateDrivenCamera(); // 0x00000001817DA6D0-0x00000001817DA820
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007417E7 */); // 0x00000001817D9790-0x00000001817D97C0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001817DA040-0x00000001817DA130
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001817DA130-0x00000001817DA1C0
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001817D9030-0x00000001817D9770
		protected override void OnEnable(); // 0x00000001817D9CF0-0x00000001817D9E50
		protected override void OnDisable(); // 0x00000001817D9BD0-0x00000001817D9CF0
		public void OnTransformChildrenChanged(); // 0x00000001817D9770-0x00000001817D9790
		private void OnGuiHandler(); // 0x00000001817D9E50-0x00000001817DA040
		public static int CreateFakeHash(int parentHash, AnimationClip clip); // 0x00000001817D8E60-0x00000001817D8EE0
		private int LookupFakeHash(int parentHash, AnimationClip clip); // 0x00000001817D99A0-0x00000001817D9BD0
		private void InvalidateListOfChildren(); // 0x00000001817D9770-0x00000001817D9790
		private void UpdateListOfChildren(); // 0x00000001817DA1C0-0x00000001817DA390
		internal void ValidateInstructions(); // 0x00000001817DA390-0x00000001817DA6D0
		private CinemachineVirtualCameraBase ChooseCurrentCamera(float deltaTime); // 0x00000001817D8750-0x00000001817D8E60
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips); // 0x00000001817D8EE0-0x00000001817D9030
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x00000001817D97C0-0x00000001817D99A0
	}
}
