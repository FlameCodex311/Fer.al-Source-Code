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
	[AddComponentMenu] // 0x000000018028B2F0-0x000000018028B360
	[DisallowMultipleComponent] // 0x000000018028B2F0-0x000000018028B360
	[DocumentationSorting] // 0x000000018028B2F0-0x000000018028B360
	[ExecuteAlways] // 0x000000018028B2F0-0x000000018028B360
	public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 7448
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018028C810-0x000000018028C850
		[Tooltip] // 0x000000018028C810-0x000000018028C850
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x000000018028C9C0-0x000000018028CA00
		[Tooltip] // 0x000000018028C9C0-0x000000018028CA00
		public Transform m_Follow; // 0x80
		[FormerlySerializedAs] // 0x000000018028CB30-0x000000018028CB90
		[Tooltip] // 0x000000018028CB30-0x000000018028CB90
		public bool m_CommonLens; // 0x88
		[FormerlySerializedAs] // 0x000000018028CC80-0x000000018028CCF0
		[LensSettingsProperty] // 0x000000018028CC80-0x000000018028CCF0
		[Tooltip] // 0x000000018028CC80-0x000000018028CCF0
		public LensSettings m_Lens; // 0x8C
		public TransitionParams m_Transitions; // 0xB8
		[FormerlySerializedAs] // 0x000000018028CEF0-0x000000018028CF70
		[FormerlySerializedAs] // 0x000000018028CEF0-0x000000018028CF70
		[HideInInspector] // 0x000000018028CEF0-0x000000018028CF70
		[SerializeField] // 0x000000018028CEF0-0x000000018028CF70
		private BlendHint m_LegacyBlendHint; // 0xC8
		[AxisStateProperty] // 0x000000018028D3B0-0x000000018028D420
		[Header] // 0x000000018028D3B0-0x000000018028D420
		[Tooltip] // 0x000000018028D3B0-0x000000018028D420
		public AxisState m_YAxis; // 0xD0
		[Tooltip] // 0x000000018028D5F0-0x000000018028D620
		public AxisState.Recentering m_YAxisRecentering; // 0x120
		[AxisStateProperty] // 0x000000018028D760-0x000000018028D7A0
		[Tooltip] // 0x000000018028D760-0x000000018028D7A0
		public AxisState m_XAxis; // 0x140
		[OrbitalTransposerHeadingProperty] // 0x000000018028D800-0x000000018028D850
		[Tooltip] // 0x000000018028D800-0x000000018028D850
		public CinemachineOrbitalTransposer.Heading m_Heading; // 0x190
		[Tooltip] // 0x000000018028D9B0-0x000000018028D9E0
		public AxisState.Recentering m_RecenterToTargetHeading; // 0x19C
		[Header] // 0x000000018028DAB0-0x000000018028DB10
		[Tooltip] // 0x000000018028DAB0-0x000000018028DB10
		public CinemachineTransposer.BindingMode m_BindingMode; // 0x1B8
		[FormerlySerializedAs] // 0x000000018028DC60-0x000000018028DCE0
		[Range] // 0x000000018028DC60-0x000000018028DCE0
		[Tooltip] // 0x000000018028DC60-0x000000018028DCE0
		public float m_SplineCurvature; // 0x1BC
		[Tooltip] // 0x000000018028DF80-0x000000018028DFB0
		public Orbit[] m_Orbits; // 0x1C0
		[FormerlySerializedAs] // 0x000000018028E0D0-0x000000018028E120
		[HideInInspector] // 0x000000018028E0D0-0x000000018028E120
		[SerializeField] // 0x000000018028E0D0-0x000000018028E120
		private float m_LegacyHeadingBias; // 0x1C8
		private bool mUseLegacyRigDefinitions; // 0x1CC
		private bool mIsDestroyed; // 0x1CD
		private CameraState m_State; // 0x1D0
		[HideInInspector] // 0x00000001801FEB70-0x00000001801FEBB0
		[NoSaveDuringPlay] // 0x00000001801FEB70-0x00000001801FEBB0
		[SerializeField] // 0x00000001801FEB70-0x00000001801FEBB0
		private CinemachineVirtualCamera[] m_Rigs; // 0x2B0
		private CinemachineOrbitalTransposer[] mOrbitals; // 0x2B8
		private CinemachineBlend mBlendA; // 0x2C0
		private CinemachineBlend mBlendB; // 0x2C8
		public static CreateRigDelegate CreateRigOverride; // 0x00
		public static DestroyRigDelegate DestroyRigOverride; // 0x08
		private Orbit[] m_CachedOrbits; // 0x2D0
		private float m_CachedTension; // 0x2D8
		private Vector4[] m_CachedKnots; // 0x2E0
		private Vector4[] m_CachedCtrl1; // 0x2E8
		private Vector4[] m_CachedCtrl2; // 0x2F0
	
		// Properties
		public static string[] RigNames { get; } // 0x0000000181388F40-0x0000000181389090 
		public override CameraState State { get; } // 0x0000000181389090-0x0000000181389120 
		public override Transform LookAt { get; set; } // 0x000000018134D070-0x000000018134D080 0x00000001804B47D0-0x00000001804B47E0
		public override Transform Follow { get; set; } // 0x000000018134D050-0x000000018134D060 0x00000001804793A0-0x00000001804793B0
	
		// Nested types
		[Serializable]
		public struct Orbit // TypeDefIndex: 7449
		{
			// Fields
			public float m_Height; // 0x00
			public float m_Radius; // 0x04
	
			// Constructors
			public Orbit(float h, float r); // 0x00000001800A1C30-0x00000001800A1C40
		}
	
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom); // TypeDefIndex: 7450; 0x000000018139E0B0-0x000000018139E5C0
	
		public delegate void DestroyRigDelegate(GameObject rig); // TypeDefIndex: 7451; 0x00000001805D0030-0x00000001805D0300
	
		// Constructors
		public CinemachineFreeLook(); // 0x0000000181388AF0-0x0000000181388F40
	
		// Methods
		protected override void OnValidate(); // 0x0000000181387030-0x0000000181387120
		public CinemachineVirtualCamera GetRig(int i); // 0x0000000181385240-0x00000001813852A0
		protected override void OnEnable(); // 0x0000000181386A60-0x0000000181386A90
		protected override void OnDestroy(); // 0x0000000181386900-0x0000000181386A60
		private void OnTransformChildrenChanged(); // 0x0000000181386110-0x0000000181386120
		private void Reset(); // 0x0000000181387B40-0x0000000181387B50
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007764CF */); // 0x0000000181386120-0x00000001813862A0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000181386A90-0x0000000181386B70
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000181385830-0x0000000181386110
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000181386B70-0x0000000181387030
		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x00000001813852A0-0x0000000181385800
		private void InvalidateRigCache(); // 0x0000000181386110-0x0000000181386120
		private void DestroyRigs(); // 0x0000000181384AD0-0x0000000181384F20
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom); // 0x0000000181384560-0x0000000181384AD0
		private void UpdateRigCache(); // 0x00000001813881C0-0x0000000181388A70
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital); // 0x00000001813862A0-0x0000000181386900
		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x0000000181388A70-0x0000000181388AF0
		private void PushSettingsToRigs(); // 0x0000000181387120-0x0000000181387B40
		private float GetYAxisValue(); // 0x0000000181385800-0x0000000181385830
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x00000001813842A0-0x0000000181384560
		public Vector3 GetLocalPositionForCameraFromInput(float t); // 0x0000000181384F20-0x0000000181385240
		private void UpdateCachedSpline(); // 0x0000000181387B50-0x00000001813881C0
	}
}
