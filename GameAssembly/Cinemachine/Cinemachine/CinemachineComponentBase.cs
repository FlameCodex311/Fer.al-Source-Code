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
	[DocumentationSorting] // 0x00000001800B6700-0x00000001800B6720
	public abstract class CinemachineComponentBase : UnityEngine.MonoBehaviour // TypeDefIndex: 7344
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x007418EE
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Transform mCachedFollowTarget; // 0x20
		private CinemachineVirtualCameraBase mCachedFollowTargetVcam; // 0x28
		private CinemachineTargetGroup mCachedFollowTargetGroup; // 0x30
		private Transform mCachedLookAtTarget; // 0x38
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x40
		private CinemachineTargetGroup mCachedLookAtTargetGroup; // 0x48
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x00000001818B3320-0x00000001818B3470 
		public Transform FollowTarget { get; } // 0x00000001818B2B70-0x00000001818B2C00 
		public Transform LookAtTarget { get; } // 0x00000001818B3140-0x00000001818B31D0 
		public CinemachineTargetGroup FollowTargetGroup { get; } // 0x00000001818B25E0-0x00000001818B2670 
		public Vector3 FollowTargetPosition { get; } // 0x00000001818B2670-0x00000001818B2900 
		public Quaternion FollowTargetRotation { get; } // 0x00000001818B2900-0x00000001818B2B70 
		public CinemachineTargetGroup LookAtTargetGroup { get; } // 0x00000001818B2C00-0x00000001818B2C90 
		public Vector3 LookAtTargetPosition { get; } // 0x00000001818B2C90-0x00000001818B2F20 
		public Quaternion LookAtTargetRotation { get; } // 0x00000001818B2F20-0x00000001818B3140 
		public CameraState VcamState { get; } // 0x00000001818B31D0-0x00000001818B3320 
		public abstract bool IsValid { get; }
		public abstract CinemachineCore.Stage Stage { get; }
	
		// Constructors
		protected CinemachineComponentBase(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void UpdateFollowTargetCache(); // 0x00000001818B2460-0x00000001818B2520
		private void UpdateLookAtTargetCache(); // 0x00000001818B2520-0x00000001818B25E0
		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001803581E0-0x00000001803581F0
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x00000001803C28F0-0x00000001803C2900
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001803581E0-0x00000001803581F0
	}
}
