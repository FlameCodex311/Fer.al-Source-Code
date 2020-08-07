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
	[AddComponentMenu] // 0x0000000180292740-0x00000001802927B0
	[DisallowMultipleComponent] // 0x0000000180292740-0x00000001802927B0
	[DocumentationSorting] // 0x0000000180292740-0x00000001802927B0
	[ExecuteAlways] // 0x0000000180292740-0x00000001802927B0
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7458
	{
		// Fields
		[NoSaveDuringPlay] // 0x00000001802929C0-0x0000000180292A00
		[Tooltip] // 0x00000001802929C0-0x0000000180292A00
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x000000018027D280-0x000000018027D2C0
		[Tooltip] // 0x000000018027D280-0x000000018027D2C0
		public Transform m_Follow; // 0x80
		[NoSaveDuringPlay] // 0x0000000180294050-0x00000001802940B0
		[Space] // 0x0000000180294050-0x00000001802940B0
		[Tooltip] // 0x0000000180294050-0x00000001802940B0
		public Animator m_AnimatedTarget; // 0x88
		[NoSaveDuringPlay] // 0x0000000180294460-0x00000001802944A0
		[Tooltip] // 0x0000000180294460-0x00000001802944A0
		public int m_LayerIndex; // 0x90
		[Tooltip] // 0x000000018027D5B0-0x000000018027D5E0
		public bool m_ShowDebugText; // 0x94
		[HideInInspector] // 0x00000001802948D0-0x0000000180294910
		[NoSaveDuringPlay] // 0x00000001802948D0-0x0000000180294910
		[SerializeField] // 0x00000001802948D0-0x0000000180294910
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x98
		[Tooltip] // 0x0000000180294DF0-0x0000000180294E20
		public Instruction[] m_Instructions; // 0xA0
		[CinemachineBlendDefinitionProperty] // 0x0000000180295060-0x00000001802950A0
		[Tooltip] // 0x0000000180295060-0x00000001802950A0
		public CinemachineBlendDefinition m_DefaultBlend; // 0xA8
		[Tooltip] // 0x0000000180295290-0x00000001802952C0
		public CinemachineBlenderSettings m_CustomBlends; // 0xB8
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		internal ParentHash[] m_ParentHash; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0xC8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public override string Description { get; } // 0x0000000181394EA0-0x0000000181394F90 
		public ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530
		public override CameraState State { get; } // 0x0000000181394FA0-0x0000000181395030 
		public override Transform LookAt { get; set; } // 0x000000018134D070-0x000000018134D080 0x00000001804B47D0-0x00000001804B47E0
		public override Transform Follow { get; set; } // 0x000000018134D050-0x000000018134D060 0x00000001804793A0-0x00000001804793B0
		private ICinemachineCamera TransitioningFrom { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000181394E80-0x0000000181394EA0 
		public bool IsBlending { get; } // 0x0000000181394F90-0x0000000181394FA0 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 7459
		{
			// Fields
			[Tooltip] // 0x0000000180295F40-0x0000000180295F70
			public int m_FullHash; // 0x00
			[Tooltip] // 0x00000001802961F0-0x0000000180296220
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x08
			[Tooltip] // 0x00000001802962A0-0x00000001802962D0
			public float m_ActivateAfter; // 0x10
			[Tooltip] // 0x00000001802964A0-0x00000001802964D0
			public float m_MinDuration; // 0x14
		}
	
		[Serializable]
		[DocumentationSorting] // 0x00000001801FE1B0-0x00000001801FE1D0
		internal struct ParentHash // TypeDefIndex: 7460
		{
			// Fields
			public int m_Hash; // 0x00
			public int m_ParentHash; // 0x04
		}
	
		private struct HashPair // TypeDefIndex: 7461
		{
			// Fields
			public int parentHash; // 0x00
			public int hash; // 0x04
		}
	
		// Constructors
		public CinemachineStateDrivenCamera(); // 0x0000000181394D30-0x0000000181394E80
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007764D5 */); // 0x0000000181393EE0-0x0000000181393F10
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001813946C0-0x00000001813947B0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001813947B0-0x0000000181394840
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001813938D0-0x0000000181393EC0
		protected override void OnEnable(); // 0x00000001813943E0-0x0000000181394540
		protected override void OnDisable(); // 0x0000000181394310-0x00000001813943E0
		public void OnTransformChildrenChanged(); // 0x0000000181393EC0-0x0000000181393EE0
		private void OnGuiHandler(); // 0x0000000181394540-0x00000001813946C0
		public static int CreateFakeHash(int parentHash, AnimationClip clip); // 0x0000000181393700-0x0000000181393780
		private int LookupFakeHash(int parentHash, AnimationClip clip); // 0x00000001813940F0-0x0000000181394310
		private void InvalidateListOfChildren(); // 0x0000000181393EC0-0x0000000181393EE0
		private void UpdateListOfChildren(); // 0x0000000181394840-0x0000000181394A00
		internal void ValidateInstructions(); // 0x0000000181394A00-0x0000000181394D30
		private CinemachineVirtualCameraBase ChooseCurrentCamera(float deltaTime); // 0x0000000181393000-0x0000000181393700
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips); // 0x0000000181393780-0x00000001813938D0
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x0000000181393F10-0x00000001813940F0
	}
}
