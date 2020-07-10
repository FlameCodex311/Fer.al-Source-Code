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
	public sealed class CinemachineCore // TypeDefIndex: 7345
	{
		// Fields
		public static readonly int kStreamingVersion; // 0x00
		public static readonly string kVersionString; // 0x08
		private static CinemachineCore sInstance; // 0x10
		public static bool sShowHiddenObjects; // 0x18
		public static AxisInputDelegate GetInputAxis; // 0x20
		public static GetBlendOverrideDelegate GetBlendOverride; // 0x28
		public static CinemachineBrain.BrainEvent CameraUpdatedEvent; // 0x30
		private List<CinemachineBrain> mActiveBrains; // 0x10
		private List<CinemachineVirtualCameraBase> mActiveCameras; // 0x18
		private List<List<CinemachineVirtualCameraBase>> mAllCameras; // 0x20
		private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; // 0x28
		private static float mLastUpdateTime; // 0x38
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static int <FixedFrameCount>k__BackingField; // 0x3C
		private static Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private UpdateFilter <CurrentUpdateFilter>k__BackingField; // 0x30
	
		// Properties
		public static CinemachineCore Instance { get; } // 0x00000001818B8740-0x00000001818B88C0 
		public int BrainCount { get; } // 0x00000001818B8640-0x00000001818B8680 
		public int VirtualCameraCount { get; } // 0x00000001818B88C0-0x00000001818B8900 
		private static int FixedFrameCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001818B8680-0x00000001818B8740 0x00000001818B8900-0x00000001818B8960
		internal UpdateFilter CurrentUpdateFilter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018043DDC0-0x000000018043DDD0 0x000000018036B7A0-0x000000018036B7F0
	
		// Nested types
		public enum Stage // TypeDefIndex: 7346
		{
			Body = 0,
			Aim = 1,
			Noise = 2,
			Finalize = 3
		}
	
		public delegate float AxisInputDelegate(string axisName); // TypeDefIndex: 7347; 0x00000001818A14D0-0x00000001818A2060
	
		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, UnityEngine.MonoBehaviour owner); // TypeDefIndex: 7348; 0x00000001818C2CE0-0x00000001818C3660
	
		private class UpdateStatus // TypeDefIndex: 7349
		{
			// Fields
			public int lastUpdateFrame; // 0x10
			public int lastUpdateFixedFrame; // 0x14
			public UpdateTracker.UpdateClock lastUpdateMode; // 0x18
	
			// Constructors
			public UpdateStatus(); // 0x00000001818C3830-0x00000001818C3860
		}
	
		internal enum UpdateFilter // TypeDefIndex: 7350
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}
	
		// Constructors
		public CinemachineCore(); // 0x00000001818B8590-0x00000001818B8640
		static CinemachineCore(); // 0x00000001818B8490-0x00000001818B8590
	
		// Methods
		public CinemachineBrain GetActiveBrain(int index); // 0x00000001818B7510-0x00000001818B7570
		internal void AddActiveBrain(CinemachineBrain brain); // 0x00000001818B6A70-0x00000001818B6B00
		internal void RemoveActiveBrain(CinemachineBrain brain); // 0x00000001818B7A00-0x00000001818B7A60
		public CinemachineVirtualCameraBase GetVirtualCamera(int index); // 0x00000001818B77C0-0x00000001818B7820
		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam); // 0x00000001818B6B00-0x00000001818B6C40
		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam); // 0x00000001818B7A60-0x00000001818B7AC0
		internal void CameraAwakened(CinemachineVirtualCameraBase vcam); // 0x00000001818B6C40-0x00000001818B6E10
		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam); // 0x00000001818B6E10-0x00000001818B6EE0
		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime); // 0x00000001818B7AC0-0x00000001818B7F90
		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime); // 0x00000001818B7F90-0x00000001818B8490
		[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
		private static void InitializeModule(); // 0x00000001818B7820-0x00000001818B78B0
		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam); // 0x00000001818B7570-0x00000001818B76E0
		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam); // 0x00000001818B76E0-0x00000001818B77C0
		public bool IsLive(ICinemachineCamera vcam); // 0x00000001818B78B0-0x00000001818B7A00
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom); // 0x00000001818B7230-0x00000001818B73A0
		public void GenerateCameraCutEvent(ICinemachineCamera vcam); // 0x00000001818B73A0-0x00000001818B7510
		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam); // 0x00000001818B6EE0-0x00000001818B7230
	}
}
