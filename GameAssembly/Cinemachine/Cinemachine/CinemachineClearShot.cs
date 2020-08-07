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
	[AddComponentMenu] // 0x0000000180282260-0x00000001802822D0
	[DisallowMultipleComponent] // 0x0000000180282260-0x00000001802822D0
	[DocumentationSorting] // 0x0000000180282260-0x00000001802822D0
	[ExecuteAlways] // 0x0000000180282260-0x00000001802822D0
	public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 7434
	{
		// Fields
		[NoSaveDuringPlay] // 0x00000001802824E0-0x0000000180282530
		[Tooltip] // 0x00000001802824E0-0x0000000180282530
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000180282790-0x00000001802827D0
		[Tooltip] // 0x0000000180282790-0x00000001802827D0
		public Transform m_Follow; // 0x80
		[NoSaveDuringPlay] // 0x0000000180282980-0x00000001802829C0
		[Tooltip] // 0x0000000180282980-0x00000001802829C0
		public bool m_ShowDebugText; // 0x88
		[HideInInspector] // 0x00000001801FEB70-0x00000001801FEBB0
		[NoSaveDuringPlay] // 0x00000001801FEB70-0x00000001801FEBB0
		[SerializeField] // 0x00000001801FEB70-0x00000001801FEBB0
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x90
		[Tooltip] // 0x0000000180282DB0-0x0000000180282DE0
		public float m_ActivateAfter; // 0x98
		[Tooltip] // 0x0000000180282EA0-0x0000000180282ED0
		public float m_MinDuration; // 0x9C
		[Tooltip] // 0x0000000180283030-0x0000000180283060
		public bool m_RandomizeChoice; // 0xA0
		[CinemachineBlendDefinitionProperty] // 0x00000001802832D0-0x0000000180283320
		[Tooltip] // 0x00000001802832D0-0x0000000180283320
		public CinemachineBlendDefinition m_DefaultBlend; // 0xA8
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public CinemachineBlenderSettings m_CustomBlends; // 0xB8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <LiveChild>k__BackingField; // 0xC0
		private CameraState m_State; // 0xC8
		private float mActivationTime; // 0x1A8
		private float mPendingActivationTime; // 0x1AC
		private ICinemachineCamera mPendingCamera; // 0x1B0
		private CinemachineBlend mActiveBlend; // 0x1B8
		private bool mRandomizeNow; // 0x1C0
		private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x1C8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0x1D0
	
		// Properties
		public override string Description { get; } // 0x0000000181352B70-0x0000000181352C60 
		public ICinemachineCamera LiveChild { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180529360-0x0000000180529370 0x0000000180529410-0x0000000180529420
		public override CameraState State { get; } // 0x0000000181352C70-0x0000000181352D00 
		public override Transform LookAt { get; set; } // 0x000000018134D070-0x000000018134D080 0x00000001804B47D0-0x00000001804B47E0
		public override Transform Follow { get; set; } // 0x000000018134D050-0x000000018134D060 0x00000001804793A0-0x00000001804793B0
		public bool IsBlending { get; } // 0x0000000181352C60-0x0000000181352C70 
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000181352B50-0x0000000181352B70 
		private ICinemachineCamera TransitioningFrom { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180488910-0x0000000180488920 0x0000000181352D00-0x0000000181352D10
	
		// Nested types
		private struct Pair // TypeDefIndex: 7435
		{
			// Fields
			public int a; // 0x00
			public float b; // 0x04
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 7436
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<Pair> <>9__46_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181364B20-0x0000000181364B80
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <Randomize>b__46_0(Pair p1, Pair p2); // 0x0000000181364B00-0x0000000181364B20
		}
	
		// Constructors
		public CinemachineClearShot(); // 0x0000000181352A40-0x0000000181352B50
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007764A6 */); // 0x0000000181351E50-0x0000000181351E80
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000181352420-0x0000000181352510
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001813518D0-0x0000000181351E30
		protected override void OnEnable(); // 0x0000000181352130-0x00000001813522A0
		protected override void OnDisable(); // 0x0000000181352060-0x0000000181352130
		public void OnTransformChildrenChanged(); // 0x0000000181351E30-0x0000000181351E50
		private void OnGuiHandler(); // 0x00000001813522A0-0x0000000181352420
		private void InvalidateListOfChildren(); // 0x0000000181351E30-0x0000000181351E50
		public void ResetRandomization(); // 0x0000000181352840-0x0000000181352860
		private void UpdateListOfChildren(); // 0x0000000181352860-0x0000000181352A40
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp, float deltaTime); // 0x0000000181351130-0x00000001813518D0
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src); // 0x00000001813525D0-0x0000000181352840
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x0000000181351E80-0x0000000181352060
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000181352510-0x00000001813525D0
	}
}
