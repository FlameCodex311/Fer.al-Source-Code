/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[SaveDuringPlay] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class CinemachineVirtualCameraBase : UnityEngine.MonoBehaviour, ICinemachineCamera // TypeDefIndex: 7532
	{
		// Fields
		[HideInInspector] // 0x00000001801FE900-0x00000001801FE940
		[NoSaveDuringPlay] // 0x00000001801FE900-0x00000001801FE940
		[SerializeField] // 0x00000001801FE900-0x00000001801FE940
		public string[] m_ExcludedPropertiesInInspector; // 0x18
		[HideInInspector] // 0x00000001801FEB70-0x00000001801FEBB0
		[NoSaveDuringPlay] // 0x00000001801FEB70-0x00000001801FEBB0
		[SerializeField] // 0x00000001801FEB70-0x00000001801FEBB0
		public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
		private int m_ValidatingStreamVersion; // 0x28
		private bool m_OnValidateCalled; // 0x2C
		[HideInInspector] // 0x00000001801FE900-0x00000001801FE940
		[NoSaveDuringPlay] // 0x00000001801FE900-0x00000001801FE940
		[SerializeField] // 0x00000001801FE900-0x00000001801FE940
		private int m_StreamingVersion; // 0x30
		[NoSaveDuringPlay] // 0x00000001801FF100-0x00000001801FF150
		[Tooltip] // 0x00000001801FF100-0x00000001801FF150
		public int m_Priority; // 0x34
		[Tooltip] // 0x00000001801FF380-0x00000001801FF3B0
		public StandbyUpdateMode m_StandbyUpdate; // 0x38
		private List<CinemachineExtension> mExtensions; // 0x40
		private bool m_previousStateIsValid; // 0x48
		private Transform m_previousLookAtTarget; // 0x50
		private Transform m_previousFollowTarget; // 0x58
		private bool mSlaveStatusUpdated; // 0x60
		private CinemachineVirtualCameraBase m_parentVcam; // 0x68
		private int m_QueuePriority; // 0x70
	
		// Properties
		public int ValidatingStreamVersion { get; private set; } // 0x0000000181FF5860-0x0000000181FF58D0 0x000000018041A3A0-0x000000018041A3B0
		public string Name { get; } // 0x00000001808A3EB0-0x00000001808A3EC0 
		public virtual string Description { get; } // 0x0000000181FF5690-0x0000000181FF56C0 
		public int Priority { get; set; } // 0x00000001804EF8F0-0x00000001804EF900 0x000000018041B180-0x000000018041B190
		public GameObject VirtualCameraGameObject { get; } // 0x0000000181FF58D0-0x0000000181FF5940 
		public bool IsValid { get; } // 0x0000000181FF56C0-0x0000000181FF5720 
		public abstract CameraState State { get; }
		public ICinemachineCamera ParentCamera { get; } // 0x0000000181FF5720-0x0000000181FF5750 
		public abstract Transform LookAt { get; set; }
		public abstract Transform Follow { get; set; }
		public bool PreviousStateIsValid { get; set; } // 0x0000000181FF5750-0x0000000181FF5860 0x00000001803C9DD0-0x00000001803C9DE0
	
		// Nested types
		public enum StandbyUpdateMode // TypeDefIndex: 7533
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}
	
		public enum BlendHint // TypeDefIndex: 7534
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}
	
		[Serializable]
		public struct TransitionParams // TypeDefIndex: 7535
		{
			// Fields
			[FormerlySerializedAs] // 0x00000001801FF4C0-0x00000001801FF520
			[Tooltip] // 0x00000001801FF4C0-0x00000001801FF520
			public BlendHint m_BlendHint; // 0x00
			[Tooltip] // 0x00000001801FF750-0x00000001801FF780
			public bool m_InheritPosition; // 0x04
			[Tooltip] // 0x00000001801FF8E0-0x00000001801FF910
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive; // 0x08
		}
	
		// Constructors
		protected CinemachineVirtualCameraBase(); // 0x0000000181FF55C0-0x0000000181FF5690
	
		// Methods
		public virtual void AddExtension(CinemachineExtension extension); // 0x0000000181FF4410-0x0000000181FF44B0
		public virtual void RemoveExtension(CinemachineExtension extension); // 0x0000000181FF5170-0x0000000181FF51C0
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime); // 0x0000000181FF4780-0x0000000181FF49A0
		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint); // 0x0000000181FF44B0-0x0000000181FF44E0
		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x00776621 */); // 0x0000000180380950-0x0000000180380960
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000181FF5360-0x0000000181FF5400
		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000181FF4E80-0x0000000181FF4EC0
		protected virtual void OnDestroy(); // 0x0000000181FF49B0-0x0000000181FF4A20
		protected virtual void OnTransformParentChanged(); // 0x0000000181FF4DE0-0x0000000181FF4E80
		protected virtual void Start(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnValidate(); // 0x0000000181FF4EC0-0x0000000181FF4F30
		protected virtual void OnEnable(); // 0x0000000181FF4AA0-0x0000000181FF4CF0
		protected virtual void OnDisable(); // 0x0000000181FF4A20-0x0000000181FF4AA0
		protected virtual void Update(); // 0x0000000181FF55B0-0x0000000181FF55C0
		private void UpdateSlaveStatus(); // 0x0000000181FF5400-0x0000000181FF54B0
		protected Transform ResolveLookAt(Transform localLookAt); // 0x0000000181FF5290-0x0000000181FF5360
		protected Transform ResolveFollow(Transform localFollow); // 0x0000000181FF51C0-0x0000000181FF5290
		private void UpdateVcamPoolStatus(); // 0x0000000181FF54B0-0x0000000181FF55B0
		public void MoveToTopOfPrioritySubqueue(); // 0x0000000181FF49A0-0x0000000181FF49B0
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000181FF4CF0-0x0000000181FF4DE0
		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend); // 0x0000000181FF44E0-0x0000000181FF4780
		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens); // 0x0000000181FF4F30-0x0000000181FF5170
	}
}
