/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801D0DE0-0x00000001801D0E50
	[DisallowMultipleComponent] // 0x00000001801D0DE0-0x00000001801D0E50
	[DocumentationSorting] // 0x00000001801D0DE0-0x00000001801D0E50
	[ExecuteAlways] // 0x00000001801D0DE0-0x00000001801D0E50
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 7470
	{
		// Fields
		[NoSaveDuringPlay] // 0x00000001801D10E0-0x00000001801D1130
		[Tooltip] // 0x00000001801D10E0-0x00000001801D1130
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x00000001801D1330-0x00000001801D1380
		[Tooltip] // 0x00000001801D1330-0x00000001801D1380
		public Transform m_Follow; // 0x80
		[FormerlySerializedAs] // 0x00000001801D1460-0x00000001801D14D0
		[LensSettingsProperty] // 0x00000001801D1460-0x00000001801D14D0
		[Tooltip] // 0x00000001801D1460-0x00000001801D14D0
		public LensSettings m_Lens; // 0x88
		public TransitionParams m_Transitions; // 0xB0
		[FormerlySerializedAs] // 0x00000001801D17F0-0x00000001801D1870
		[FormerlySerializedAs] // 0x00000001801D17F0-0x00000001801D1870
		[HideInInspector] // 0x00000001801D17F0-0x00000001801D1870
		[SerializeField] // 0x00000001801D17F0-0x00000001801D1870
		private BlendHint m_LegacyBlendHint; // 0xC0
		public const string PipelineName = "cm"; // Metadata: 0x007764FE
		public static CreatePipelineDelegate CreatePipelineOverride; // 0x00
		public static DestroyPipelineDelegate DestroyPipelineOverride; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <UserIsDragging>k__BackingField; // 0xC4
		private CameraState m_State; // 0xC8
		private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A8
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Transform m_ComponentOwner; // 0x1B0
		private Transform mCachedLookAtTarget; // 0x1B8
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1C0
	
		// Properties
		public override CameraState State { get; } // 0x0000000181352C70-0x0000000181352D00 
		public override Transform LookAt { get; set; } // 0x000000018134D070-0x000000018134D080 0x00000001804B47D0-0x00000001804B47E0
		public override Transform Follow { get; set; } // 0x000000018134D050-0x000000018134D060 0x00000001804793A0-0x00000001804793B0
		public bool UserIsDragging { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018139E090-0x000000018139E0A0 0x000000018139E0A0-0x000000018139E0B0
	
		// Nested types
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom); // TypeDefIndex: 7471; 0x000000018139E0B0-0x000000018139E5C0
	
		public delegate void DestroyPipelineDelegate(GameObject pipeline); // TypeDefIndex: 7472; 0x00000001805D0030-0x00000001805D0300
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 7473
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<CinemachineComponentBase> <>9__40_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018139F640-0x000000018139F6A0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <UpdateComponentPipeline>b__40_0(CinemachineComponentBase c1, CinemachineComponentBase c2); // 0x000000018139F530-0x000000018139F590
		}
	
		// Constructors
		public CinemachineVirtualCamera(); // 0x000000018139DF50-0x000000018139E090
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018139CA40-0x000000018139CDC0
		protected override void OnEnable(); // 0x000000018139D000-0x000000018139D270
		protected override void OnDestroy(); // 0x000000018139CDD0-0x000000018139D000
		protected override void OnValidate(); // 0x000000018139D7A0-0x000000018139D7E0
		private void OnTransformChildrenChanged(); // 0x000000018139CDC0-0x000000018139CDD0
		private void Reset(); // 0x000000018139D7E0-0x000000018139D7F0
		private void DestroyPipeline(); // 0x000000018139C570-0x000000018139C960
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom); // 0x000000018139C420-0x000000018139C570
		public void InvalidateComponentPipeline(); // 0x000000018139CDC0-0x000000018139CDD0
		public Transform GetComponentOwner(); // 0x000000018139CA00-0x000000018139CA20
		public CinemachineComponentBase[] GetComponentPipeline(); // 0x000000018139CA20-0x000000018139CA40
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage); // 0x000000018139C960-0x000000018139CA00
		public T GetCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public T AddCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public void DestroyCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		private void UpdateComponentPipeline(); // 0x000000018139D900-0x000000018139DF50
		internal static void SetFlagsForHiddenChild(GameObject child); // 0x000000018139D7F0-0x000000018139D8E0
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x000000018139BDB0-0x000000018139C420
		private CinemachineCore.Stage AdvancePipelineStage(ref CameraState state, float deltaTime, CinemachineCore.Stage curStage, int maxStage, bool hasAim); // 0x000000018139BD10-0x000000018139BDB0
		internal void SetStateRawPosition(Vector3 pos); // 0x000000018139D8E0-0x000000018139D900
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018139D270-0x000000018139D4D0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x000000018139D4D0-0x000000018139D7A0
	}
}
