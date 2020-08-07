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
	public sealed class CinemachineCore // TypeDefIndex: 7511
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static int <FixedFrameCount>k__BackingField; // 0x3C
		private static Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UpdateFilter <CurrentUpdateFilter>k__BackingField; // 0x30
	
		// Properties
		public static CinemachineCore Instance { get; } // 0x000000018135EA30-0x000000018135EBB0 
		public int BrainCount { get; } // 0x000000018135E930-0x000000018135E970 
		public int VirtualCameraCount { get; } // 0x000000018135EBB0-0x000000018135EBF0 
		private static int FixedFrameCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018135E970-0x000000018135EA30 0x000000018135EBF0-0x000000018135EC50
		internal UpdateFilter CurrentUpdateFilter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018041A3B0-0x000000018041A400
	
		// Nested types
		public enum Stage // TypeDefIndex: 7512
		{
			Body = 0,
			Aim = 1,
			Noise = 2,
			Finalize = 3
		}
	
		public delegate float AxisInputDelegate(string axisName); // TypeDefIndex: 7513; 0x00000001813478F0-0x00000001813484A0
	
		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, UnityEngine.MonoBehaviour owner); // TypeDefIndex: 7514; 0x0000000181363F90-0x00000001813649C0
	
		private class UpdateStatus // TypeDefIndex: 7515
		{
			// Fields
			public int lastUpdateFrame; // 0x10
			public int lastUpdateFixedFrame; // 0x14
			public UpdateTracker.UpdateClock lastUpdateMode; // 0x18
	
			// Constructors
			public UpdateStatus(); // 0x0000000181364B80-0x0000000181364BB0
		}
	
		internal enum UpdateFilter // TypeDefIndex: 7516
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}
	
		// Constructors
		public CinemachineCore(); // 0x000000018135E880-0x000000018135E930
		static CinemachineCore(); // 0x000000018135E780-0x000000018135E880
	
		// Methods
		public CinemachineBrain GetActiveBrain(int index); // 0x000000018135D820-0x000000018135D880
		internal void AddActiveBrain(CinemachineBrain brain); // 0x000000018135CDC0-0x000000018135CE50
		internal void RemoveActiveBrain(CinemachineBrain brain); // 0x000000018135DD00-0x000000018135DD60
		public CinemachineVirtualCameraBase GetVirtualCamera(int index); // 0x000000018135DAC0-0x000000018135DB20
		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam); // 0x000000018135CE50-0x000000018135CF90
		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam); // 0x000000018135DD60-0x000000018135DDC0
		internal void CameraAwakened(CinemachineVirtualCameraBase vcam); // 0x000000018135CF90-0x000000018135D150
		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam); // 0x000000018135D150-0x000000018135D220
		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime); // 0x000000018135DDC0-0x000000018135E290
		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime); // 0x000000018135E290-0x000000018135E780
		[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
		private static void InitializeModule(); // 0x000000018135DB20-0x000000018135DBB0
		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam); // 0x000000018135D880-0x000000018135D9F0
		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam); // 0x000000018135D9F0-0x000000018135DAC0
		public bool IsLive(ICinemachineCamera vcam); // 0x000000018135DBB0-0x000000018135DD00
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom); // 0x000000018135D560-0x000000018135D6C0
		public void GenerateCameraCutEvent(ICinemachineCamera vcam); // 0x000000018135D6C0-0x000000018135D820
		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam); // 0x000000018135D220-0x000000018135D560
	}
}
