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
	[DocumentationSorting] // 0x00000001801E4110-0x00000001801E4130
	public abstract class CinemachineExtension : UnityEngine.MonoBehaviour // TypeDefIndex: 7517
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x00776604
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x000000018135F0C0-0x000000018135F140 
	
		// Constructors
		protected CinemachineExtension(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		protected virtual void Awake(); // 0x0000000180F78F80-0x0000000180F78FA0
		protected virtual void OnDestroy(); // 0x000000018135F0A0-0x000000018135F0C0
		protected virtual void ConnectToVcam(bool connect); // 0x000000018135EF30-0x000000018135F080
		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018135F080-0x000000018135F0A0
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001803774A0-0x00000001803774B0
		protected T GetExtraState<T>(ICinemachineCamera vcam)
			where T : class, new();
		protected List<T> GetAllExtraStates<T>()
			where T : class, new();
	}
}
