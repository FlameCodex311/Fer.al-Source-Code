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

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine.PostFX
{
	[AddComponentMenu] // 0x000000018016E2D0-0x000000018016E340
	[DocumentationSorting] // 0x000000018016E2D0-0x000000018016E340
	[ExecuteAlways] // 0x000000018016E2D0-0x000000018016E340
	[SaveDuringPlay] // 0x000000018016E2D0-0x000000018016E340
	public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 7401
	{
		// Fields
		[Tooltip] // 0x000000018016E600-0x000000018016E630
		public bool m_FocusTracksTarget; // 0x28
		[Tooltip] // 0x000000018016E8C0-0x000000018016E8F0
		public float m_FocusOffset; // 0x2C
		[Tooltip] // 0x000000018016E980-0x000000018016E9B0
		public PostProcessProfile m_Profile; // 0x30
		private bool mCachedProfileIsInvalid; // 0x38
		private PostProcessProfile mProfileCopy; // 0x40
		private static string sVolumeOwnerName; // 0x00
		private static List<PostProcessVolume> sVolumes; // 0x08
		private static Dictionary<CinemachineBrain, PostProcessLayer> mBrainToLayer; // 0x10
	
		// Properties
		public PostProcessProfile Profile { get; } // 0x00000001817D7590-0x00000001817D7610 
		public bool IsValid { get; } // 0x00000001817D74F0-0x00000001817D7590 
	
		// Constructors
		public CinemachinePostProcessing(); // 0x0000000181196A70-0x0000000181196A80
		static CinemachinePostProcessing(); // 0x00000001817D7450-0x00000001817D74F0
	
		// Methods
		public void InvalidateCachedProfile(); // 0x0000000180EB2E80-0x0000000180EB2E90
		private void CreateProfileCopy(); // 0x00000001817D66F0-0x00000001817D6900
		private void DestroyProfileCopy(); // 0x00000001817D6900-0x00000001817D6980
		protected override void OnDestroy(); // 0x00000001817D7130-0x00000001817D7150
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001817D7150-0x00000001817D7450
		private static void OnCameraCut(CinemachineBrain brain); // 0x00000001817D7090-0x00000001817D7130
		private static void ApplyPostFX(CinemachineBrain brain); // 0x00000001817D6280-0x00000001817D66F0
		private static List<PostProcessVolume> GetDynamicBrainVolumes(CinemachineBrain brain, PostProcessLayer ppLayer, int minVolumes); // 0x00000001817D6980-0x00000001817D6D90
		private static PostProcessLayer GetPPLayer(CinemachineBrain brain); // 0x00000001817D6D90-0x00000001817D6F90
		[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
		private static void InitializeModule(); // 0x00000001817D6F90-0x00000001817D7090
	}
}
