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
	[AddComponentMenu] // 0x0000000180119C50-0x0000000180119CC0
	[DisallowMultipleComponent] // 0x0000000180119C50-0x0000000180119CC0
	[DocumentationSorting] // 0x0000000180119C50-0x0000000180119CC0
	[ExecuteAlways] // 0x0000000180119C50-0x0000000180119CC0
	public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 7268
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018011A040-0x000000018011A090
		[Tooltip] // 0x000000018011A040-0x000000018011A090
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x000000018011A260-0x000000018011A2A0
		[Tooltip] // 0x000000018011A260-0x000000018011A2A0
		public Transform m_Follow; // 0x80
		[NoSaveDuringPlay] // 0x000000018011A7A0-0x000000018011A7E0
		[Tooltip] // 0x000000018011A7A0-0x000000018011A7E0
		public bool m_ShowDebugText; // 0x88
		[HideInInspector] // 0x000000018011A9F0-0x000000018011AA30
		[NoSaveDuringPlay] // 0x000000018011A9F0-0x000000018011AA30
		[SerializeField] // 0x000000018011A9F0-0x000000018011AA30
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x90
		[Tooltip] // 0x000000018011ABF0-0x000000018011AC20
		public float m_ActivateAfter; // 0x98
		[Tooltip] // 0x000000018011ADA0-0x000000018011ADD0
		public float m_MinDuration; // 0x9C
		[Tooltip] // 0x000000018011AE80-0x000000018011AEB0
		public bool m_RandomizeChoice; // 0xA0
		[CinemachineBlendDefinitionProperty] // 0x000000018011B0B0-0x000000018011B100
		[Tooltip] // 0x000000018011B0B0-0x000000018011B100
		public CinemachineBlendDefinition m_DefaultBlend; // 0xA8
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public CinemachineBlenderSettings m_CustomBlends; // 0xB8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0xC0
		private CameraState m_State; // 0xC8
		private float mActivationTime; // 0x1A8
		private float mPendingActivationTime; // 0x1AC
		private ICinemachineCamera mPendingCamera; // 0x1B0
		private CinemachineBlend mActiveBlend; // 0x1B8
		private bool mRandomizeNow; // 0x1C0
		private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x1C8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0x1D0
	
		// Properties
		public override string Description { get; } // 0x00000001818AC7E0-0x00000001818AC8D0 
		public ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A1050-0x00000001804A1060 0x00000001804A0A80-0x00000001804A0A90
		public override CameraState State { get; } // 0x00000001817E5390-0x00000001817E5420 
		public override Transform LookAt { get; set; } // 0x00000001817DA950-0x00000001817DA960 0x00000001803D8EF0-0x00000001803D8F00
		public override Transform Follow { get; set; } // 0x00000001817DA930-0x00000001817DA940 0x00000001803D8ED0-0x00000001803D8EE0
		public bool IsBlending { get; } // 0x0000000180CB7760-0x0000000180CB7770 
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x00000001818AC7C0-0x00000001818AC7E0 
		private ICinemachineCamera TransitioningFrom { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180F0A730-0x0000000180F0A740 0x00000001818AC8D0-0x00000001818AC8E0
	
		// Nested types
		private struct Pair // TypeDefIndex: 7269
		{
			// Fields
			public int a; // 0x00
			public float b; // 0x04
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7270
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<Pair> <>9__46_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001818C37D0-0x00000001818C3830
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <Randomize>b__46_0(Pair p1, Pair p2); // 0x00000001818C37B0-0x00000001818C37D0
		}
	
		// Constructors
		public CinemachineClearShot(); // 0x00000001818AC6B0-0x00000001818AC7C0
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007417B8 */); // 0x00000001818ABAA0-0x00000001818ABAD0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001818AC070-0x00000001818AC160
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001818AB520-0x00000001818ABA80
		protected override void OnEnable(); // 0x00000001818ABD80-0x00000001818ABEF0
		protected override void OnDisable(); // 0x00000001818ABCB0-0x00000001818ABD80
		public void OnTransformChildrenChanged(); // 0x00000001818ABA80-0x00000001818ABAA0
		private void OnGuiHandler(); // 0x00000001818ABEF0-0x00000001818AC070
		private void InvalidateListOfChildren(); // 0x00000001818ABA80-0x00000001818ABAA0
		public void ResetRandomization(); // 0x00000001818AC4A0-0x00000001818AC4C0
		private void UpdateListOfChildren(); // 0x00000001818AC4C0-0x00000001818AC6B0
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp, float deltaTime); // 0x00000001818AAD80-0x00000001818AB520
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src); // 0x00000001818AC220-0x00000001818AC4A0
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x00000001818ABAD0-0x00000001818ABCB0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001818AC160-0x00000001818AC220
	}
}
