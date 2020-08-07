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
	[DocumentationSorting] // 0x00000001801E4110-0x00000001801E4130
	public abstract class CinemachineComponentBase : UnityEngine.MonoBehaviour // TypeDefIndex: 7510
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x007765DC
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Transform mCachedFollowTarget; // 0x20
		private CinemachineVirtualCameraBase mCachedFollowTargetVcam; // 0x28
		private CinemachineTargetGroup mCachedFollowTargetGroup; // 0x30
		private Transform mCachedLookAtTarget; // 0x38
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x40
		private CinemachineTargetGroup mCachedLookAtTargetGroup; // 0x48
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x00000001813596C0-0x0000000181359800 
		public Transform FollowTarget { get; } // 0x0000000181358F20-0x0000000181358FB0 
		public Transform LookAtTarget { get; } // 0x00000001813594E0-0x0000000181359570 
		public CinemachineTargetGroup FollowTargetGroup { get; } // 0x0000000181358990-0x0000000181358A20 
		public Vector3 FollowTargetPosition { get; } // 0x0000000181358A20-0x0000000181358CB0 
		public Quaternion FollowTargetRotation { get; } // 0x0000000181358CB0-0x0000000181358F20 
		public CinemachineTargetGroup LookAtTargetGroup { get; } // 0x0000000181358FB0-0x0000000181359040 
		public Vector3 LookAtTargetPosition { get; } // 0x0000000181359040-0x00000001813592D0 
		public Quaternion LookAtTargetRotation { get; } // 0x00000001813592D0-0x00000001813594E0 
		public CameraState VcamState { get; } // 0x0000000181359570-0x00000001813596C0 
		public abstract bool IsValid { get; }
		public abstract CinemachineCore.Stage Stage { get; }
	
		// Constructors
		protected CinemachineComponentBase(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void UpdateFollowTargetCache(); // 0x0000000181358810-0x00000001813588D0
		private void UpdateLookAtTargetCache(); // 0x00000001813588D0-0x0000000181358990
		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001803774A0-0x00000001803774B0
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x0000000180380950-0x0000000180380960
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001803774A0-0x00000001803774B0
	}
}
