/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine.PostFX
{
	[AddComponentMenu] // 0x0000000180210210-0x0000000180210280
	[DocumentationSorting] // 0x0000000180210210-0x0000000180210280
	[ExecuteAlways] // 0x0000000180210210-0x0000000180210280
	[SaveDuringPlay] // 0x0000000180210210-0x0000000180210280
	public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 7567
	{
		// Fields
		[Tooltip] // 0x0000000180210760-0x0000000180210790
		public bool m_FocusTracksTarget; // 0x28
		[Tooltip] // 0x0000000180210A10-0x0000000180210A40
		public float m_FocusOffset; // 0x2C
		[Tooltip] // 0x0000000180210B40-0x0000000180210B70
		public PostProcessProfile m_Profile; // 0x30
		private bool mCachedProfileIsInvalid; // 0x38
		private PostProcessProfile mProfileCopy; // 0x40
		private static string sVolumeOwnerName; // 0x00
		private static List<PostProcessVolume> sVolumes; // 0x08
		private static Dictionary<CinemachineBrain, PostProcessLayer> mBrainToLayer; // 0x10
	
		// Properties
		public PostProcessProfile Profile { get; } // 0x0000000181FF3AC0-0x0000000181FF3B40 
		public bool IsValid { get; } // 0x0000000181FF3A20-0x0000000181FF3AC0 
	
		// Constructors
		public CinemachinePostProcessing(); // 0x0000000180863D60-0x0000000180863D70
		static CinemachinePostProcessing(); // 0x0000000181FF3980-0x0000000181FF3A20
	
		// Methods
		public void InvalidateCachedProfile(); // 0x00000001803F2D40-0x00000001803F2D50
		private void CreateProfileCopy(); // 0x0000000181FF2BF0-0x0000000181FF2DF0
		private void DestroyProfileCopy(); // 0x0000000181FF2DF0-0x0000000181FF2EE0
		protected override void OnDestroy(); // 0x0000000181FF3670-0x0000000181FF3690
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000181FF3690-0x0000000181FF3980
		private static void OnCameraCut(CinemachineBrain brain); // 0x0000000181FF35D0-0x0000000181FF3670
		private static void ApplyPostFX(CinemachineBrain brain); // 0x0000000181FF2790-0x0000000181FF2BF0
		private static List<PostProcessVolume> GetDynamicBrainVolumes(CinemachineBrain brain, PostProcessLayer ppLayer, int minVolumes); // 0x0000000181FF2EE0-0x0000000181FF32E0
		private static PostProcessLayer GetPPLayer(CinemachineBrain brain); // 0x0000000181FF32E0-0x0000000181FF34D0
		[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
		private static void InitializeModule(); // 0x0000000181FF34D0-0x0000000181FF35D0
	}
}
