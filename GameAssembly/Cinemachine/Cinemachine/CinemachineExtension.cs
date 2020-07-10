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
	[DocumentationSorting] // 0x00000001800B6700-0x00000001800B6720
	public abstract class CinemachineExtension : UnityEngine.MonoBehaviour // TypeDefIndex: 7351
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x00741916
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x00000001818B8DE0-0x00000001818B8E60 
	
		// Constructors
		protected CinemachineExtension(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		protected virtual void Awake(); // 0x0000000180709860-0x0000000180709880
		protected virtual void OnDestroy(); // 0x00000001818B8DC0-0x00000001818B8DE0
		protected virtual void ConnectToVcam(bool connect); // 0x00000001818B8C50-0x00000001818B8DA0
		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001818B8DA0-0x00000001818B8DC0
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001803581E0-0x00000001803581F0
		protected T GetExtraState<T>(ICinemachineCamera vcam)
			where T : class, new();
		protected List<T> GetAllExtraStates<T>()
			where T : class, new();
	}
}
