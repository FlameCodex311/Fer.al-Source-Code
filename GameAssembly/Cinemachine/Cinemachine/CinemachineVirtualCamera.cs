/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180132E10-0x0000000180132E80
	[DisallowMultipleComponent] // 0x0000000180132E10-0x0000000180132E80
	[DocumentationSorting] // 0x0000000180132E10-0x0000000180132E80
	[ExecuteAlways] // 0x0000000180132E10-0x0000000180132E80
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7304
	{
		// Fields
		[NoSaveDuringPlay] // 0x0000000180133220-0x0000000180133270
		[Tooltip] // 0x0000000180133220-0x0000000180133270
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000180133650-0x00000001801336A0
		[Tooltip] // 0x0000000180133650-0x00000001801336A0
		public Transform m_Follow; // 0x80
		[FormerlySerializedAs] // 0x00000001801338A0-0x0000000180133910
		[LensSettingsProperty] // 0x00000001801338A0-0x0000000180133910
		[Tooltip] // 0x00000001801338A0-0x0000000180133910
		public LensSettings m_Lens; // 0x88
		public TransitionParams m_Transitions; // 0xB0
		[FormerlySerializedAs] // 0x0000000180133BF0-0x0000000180133C70
		[FormerlySerializedAs] // 0x0000000180133BF0-0x0000000180133C70
		[HideInInspector] // 0x0000000180133BF0-0x0000000180133C70
		[SerializeField] // 0x0000000180133BF0-0x0000000180133C70
		private BlendHint m_LegacyBlendHint; // 0xC0
		public const string PipelineName = "cm"; // Metadata: 0x00741810
		public static CreatePipelineDelegate CreatePipelineOverride; // 0x00
		public static DestroyPipelineDelegate DestroyPipelineOverride; // 0x08
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <UserIsDragging>k__BackingField; // 0xC4
		private CameraState m_State; // 0xC8
		private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A8
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private Transform m_ComponentOwner; // 0x1B0
		private Transform mCachedLookAtTarget; // 0x1B8
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1C0
	
		// Properties
		public override CameraState State { get; } // 0x00000001817E5390-0x00000001817E5420 
		public override Transform LookAt { get; set; } // 0x00000001817DA950-0x00000001817DA960 0x00000001803D8EF0-0x00000001803D8F00
		public override Transform Follow { get; set; } // 0x00000001817DA930-0x00000001817DA940 0x00000001803D8ED0-0x00000001803D8EE0
		public bool UserIsDragging { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181270D60-0x0000000181270D70 0x0000000181270E50-0x0000000181270E60
	
		// Nested types
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom); // TypeDefIndex: 7305; 0x00000001817E5420-0x00000001817E58E0
	
		public delegate void DestroyPipelineDelegate(GameObject pipeline); // TypeDefIndex: 7306; 0x000000018055D3E0-0x000000018055D680
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7307
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<CinemachineComponentBase> <>9__40_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001817E9420-0x00000001817E9480
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <UpdateComponentPipeline>b__40_0(CinemachineComponentBase c1, CinemachineComponentBase c2); // 0x00000001817E91C0-0x00000001817E9230
		}
	
		// Constructors
		public CinemachineVirtualCamera(); // 0x00000001817E5250-0x00000001817E5390
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001817E3AA0-0x00000001817E3E40
		protected override void OnEnable(); // 0x00000001817E40E0-0x00000001817E4390
		protected override void OnDestroy(); // 0x00000001817E3E50-0x00000001817E40E0
		protected override void OnValidate(); // 0x00000001817E4960-0x00000001817E49F0
		private void OnTransformChildrenChanged(); // 0x00000001817E3E40-0x00000001817E3E50
		private void Reset(); // 0x00000001817E49F0-0x00000001817E4A00
		private void DestroyPipeline(); // 0x00000001817E35C0-0x00000001817E39C0
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom); // 0x00000001817E3470-0x00000001817E35C0
		public void InvalidateComponentPipeline(); // 0x00000001817E3E40-0x00000001817E3E50
		public Transform GetComponentOwner(); // 0x00000001817E3A60-0x00000001817E3A80
		public CinemachineComponentBase[] GetComponentPipeline(); // 0x00000001817E3A80-0x00000001817E3AA0
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage); // 0x00000001817E39C0-0x00000001817E3A60
		public T GetCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public T AddCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public void DestroyCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		private void UpdateComponentPipeline(); // 0x00000001817E4B10-0x00000001817E5250
		internal static void SetFlagsForHiddenChild(GameObject child); // 0x00000001817E4A00-0x00000001817E4AF0
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x00000001817E2DE0-0x00000001817E3470
		private CinemachineCore.Stage AdvancePipelineStage(ref CameraState state, float deltaTime, CinemachineCore.Stage curStage, int maxStage, bool hasAim); // 0x00000001817E2D40-0x00000001817E2DE0
		internal void SetStateRawPosition(Vector3 pos); // 0x00000001817E4AF0-0x00000001817E4B10
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001817E4390-0x00000001817E4600
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001817E4600-0x00000001817E4960
	}
}
