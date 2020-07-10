/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[SaveDuringPlay] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class CinemachineVirtualCameraBase : UnityEngine.MonoBehaviour, ICinemachineCamera // TypeDefIndex: 7366
	{
		// Fields
		[HideInInspector] // 0x00000001801132D0-0x0000000180113310
		[NoSaveDuringPlay] // 0x00000001801132D0-0x0000000180113310
		[SerializeField] // 0x00000001801132D0-0x0000000180113310
		public string[] m_ExcludedPropertiesInInspector; // 0x18
		[HideInInspector] // 0x000000018011A9F0-0x000000018011AA30
		[NoSaveDuringPlay] // 0x000000018011A9F0-0x000000018011AA30
		[SerializeField] // 0x000000018011A9F0-0x000000018011AA30
		public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
		private int m_ValidatingStreamVersion; // 0x28
		private bool m_OnValidateCalled; // 0x2C
		[HideInInspector] // 0x00000001801132D0-0x0000000180113310
		[NoSaveDuringPlay] // 0x00000001801132D0-0x0000000180113310
		[SerializeField] // 0x00000001801132D0-0x0000000180113310
		private int m_StreamingVersion; // 0x30
		[NoSaveDuringPlay] // 0x000000018015D720-0x000000018015D770
		[Tooltip] // 0x000000018015D720-0x000000018015D770
		public int m_Priority; // 0x34
		[Tooltip] // 0x000000018015D9B0-0x000000018015D9E0
		public StandbyUpdateMode m_StandbyUpdate; // 0x38
		private List<CinemachineExtension> mExtensions; // 0x40
		private bool m_previousStateIsValid; // 0x48
		private Transform m_previousLookAtTarget; // 0x50
		private Transform m_previousFollowTarget; // 0x58
		private bool mSlaveStatusUpdated; // 0x60
		private CinemachineVirtualCameraBase m_parentVcam; // 0x68
		private int m_QueuePriority; // 0x70
	
		// Properties
		public int ValidatingStreamVersion { get; private set; } // 0x00000001817E2C60-0x00000001817E2CD0 0x000000018036B790-0x000000018036B7A0
		public string Name { get; } // 0x000000018123D3C0-0x000000018123D3D0 
		public virtual string Description { get; } // 0x00000001817E2A90-0x00000001817E2AC0 
		public int Priority { get; set; } // 0x000000018043E170-0x000000018043E180 0x000000018036C610-0x000000018036C620
		public GameObject VirtualCameraGameObject { get; } // 0x00000001817E2CD0-0x00000001817E2D40 
		public bool IsValid { get; } // 0x00000001817E2AC0-0x00000001817E2B20 
		public abstract CameraState State { get; }
		public ICinemachineCamera ParentCamera { get; } // 0x00000001817E2B20-0x00000001817E2B50 
		public abstract Transform LookAt { get; set; }
		public abstract Transform Follow { get; set; }
		public bool PreviousStateIsValid { get; set; } // 0x00000001817E2B50-0x00000001817E2C60 0x000000018082AC70-0x000000018082AC80
	
		// Nested types
		public enum StandbyUpdateMode // TypeDefIndex: 7367
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}
	
		public enum BlendHint // TypeDefIndex: 7368
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}
	
		[Serializable]
		public struct TransitionParams // TypeDefIndex: 7369
		{
			// Fields
			[FormerlySerializedAs] // 0x00000001801225B0-0x0000000180122610
			[Tooltip] // 0x00000001801225B0-0x0000000180122610
			public BlendHint m_BlendHint; // 0x00
			[Tooltip] // 0x000000018015DF30-0x000000018015DF60
			public bool m_InheritPosition; // 0x04
			[Tooltip] // 0x000000018015E170-0x000000018015E1A0
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive; // 0x08
		}
	
		// Constructors
		protected CinemachineVirtualCameraBase(); // 0x00000001817E29C0-0x00000001817E2A90
	
		// Methods
		public virtual void AddExtension(CinemachineExtension extension); // 0x00000001817E17D0-0x00000001817E1870
		public virtual void RemoveExtension(CinemachineExtension extension); // 0x00000001817E2550-0x00000001817E25A0
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime); // 0x00000001817E1B40-0x00000001817E1D70
		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint); // 0x00000001817E1870-0x00000001817E18A0
		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x00741933 */); // 0x00000001803C28F0-0x00000001803C2900
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001817E2740-0x00000001817E27F0
		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001817E2260-0x00000001817E22A0
		protected virtual void OnDestroy(); // 0x00000001817E1D80-0x00000001817E1DF0
		protected virtual void OnTransformParentChanged(); // 0x00000001817E21C0-0x00000001817E2260
		protected virtual void Start(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnValidate(); // 0x00000001817E22A0-0x00000001817E2310
		protected virtual void OnEnable(); // 0x00000001817E1E70-0x00000001817E20D0
		protected virtual void OnDisable(); // 0x00000001817E1DF0-0x00000001817E1E70
		protected virtual void Update(); // 0x00000001817E29B0-0x00000001817E29C0
		private void UpdateSlaveStatus(); // 0x00000001817E27F0-0x00000001817E28B0
		protected Transform ResolveLookAt(Transform localLookAt); // 0x00000001817E2670-0x00000001817E2740
		protected Transform ResolveFollow(Transform localFollow); // 0x00000001817E25A0-0x00000001817E2670
		private void UpdateVcamPoolStatus(); // 0x00000001817E28B0-0x00000001817E29B0
		public void MoveToTopOfPrioritySubqueue(); // 0x00000001817E1D70-0x00000001817E1D80
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001817E20D0-0x00000001817E21C0
		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend); // 0x00000001817E18A0-0x00000001817E1B40
		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens); // 0x00000001817E2310-0x00000001817E2550
	}
}
