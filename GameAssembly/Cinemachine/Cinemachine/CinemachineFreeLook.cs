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
	[AddComponentMenu] // 0x00000001801249A0-0x0000000180124A10
	[DisallowMultipleComponent] // 0x00000001801249A0-0x0000000180124A10
	[DocumentationSorting] // 0x00000001801249A0-0x0000000180124A10
	[ExecuteAlways] // 0x00000001801249A0-0x0000000180124A10
	public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 7282
	{
		// Fields
		[NoSaveDuringPlay] // 0x0000000180124D00-0x0000000180124D40
		[Tooltip] // 0x0000000180124D00-0x0000000180124D40
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x00000001801250D0-0x0000000180125110
		[Tooltip] // 0x00000001801250D0-0x0000000180125110
		public Transform m_Follow; // 0x80
		[FormerlySerializedAs] // 0x0000000180125310-0x0000000180125370
		[Tooltip] // 0x0000000180125310-0x0000000180125370
		public bool m_CommonLens; // 0x88
		[FormerlySerializedAs] // 0x0000000180125610-0x0000000180125680
		[LensSettingsProperty] // 0x0000000180125610-0x0000000180125680
		[Tooltip] // 0x0000000180125610-0x0000000180125680
		public LensSettings m_Lens; // 0x8C
		public TransitionParams m_Transitions; // 0xB8
		[FormerlySerializedAs] // 0x00000001801259C0-0x0000000180125A40
		[FormerlySerializedAs] // 0x00000001801259C0-0x0000000180125A40
		[HideInInspector] // 0x00000001801259C0-0x0000000180125A40
		[SerializeField] // 0x00000001801259C0-0x0000000180125A40
		private BlendHint m_LegacyBlendHint; // 0xC8
		[AxisStateProperty] // 0x0000000180126DB0-0x0000000180126E20
		[Header] // 0x0000000180126DB0-0x0000000180126E20
		[Tooltip] // 0x0000000180126DB0-0x0000000180126E20
		public AxisState m_YAxis; // 0xD0
		[Tooltip] // 0x0000000180127050-0x0000000180127080
		public AxisState.Recentering m_YAxisRecentering; // 0x120
		[AxisStateProperty] // 0x0000000180127260-0x00000001801272A0
		[Tooltip] // 0x0000000180127260-0x00000001801272A0
		public AxisState m_XAxis; // 0x140
		[OrbitalTransposerHeadingProperty] // 0x0000000180127560-0x00000001801275B0
		[Tooltip] // 0x0000000180127560-0x00000001801275B0
		public CinemachineOrbitalTransposer.Heading m_Heading; // 0x190
		[Tooltip] // 0x00000001801277B0-0x00000001801277E0
		public AxisState.Recentering m_RecenterToTargetHeading; // 0x19C
		[Header] // 0x0000000180127910-0x0000000180127970
		[Tooltip] // 0x0000000180127910-0x0000000180127970
		public CinemachineTransposer.BindingMode m_BindingMode; // 0x1B8
		[FormerlySerializedAs] // 0x0000000180127BC0-0x0000000180127C40
		[Range] // 0x0000000180127BC0-0x0000000180127C40
		[Tooltip] // 0x0000000180127BC0-0x0000000180127C40
		public float m_SplineCurvature; // 0x1BC
		[Tooltip] // 0x0000000180127F90-0x0000000180127FC0
		public Orbit[] m_Orbits; // 0x1C0
		[FormerlySerializedAs] // 0x0000000180128080-0x00000001801280D0
		[HideInInspector] // 0x0000000180128080-0x00000001801280D0
		[SerializeField] // 0x0000000180128080-0x00000001801280D0
		private float m_LegacyHeadingBias; // 0x1C8
		private bool mUseLegacyRigDefinitions; // 0x1CC
		private bool mIsDestroyed; // 0x1CD
		private CameraState m_State; // 0x1D0
		[HideInInspector] // 0x000000018011A9F0-0x000000018011AA30
		[NoSaveDuringPlay] // 0x000000018011A9F0-0x000000018011AA30
		[SerializeField] // 0x000000018011A9F0-0x000000018011AA30
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
		public static string[] RigNames { get; } // 0x00000001818C2120-0x00000001818C2280 
		public override CameraState State { get; } // 0x00000001818C2280-0x00000001818C2C30 
		public override Transform LookAt { get; set; } // 0x00000001817DA950-0x00000001817DA960 0x00000001803D8EF0-0x00000001803D8F00
		public override Transform Follow { get; set; } // 0x00000001817DA930-0x00000001817DA940 0x00000001803D8ED0-0x00000001803D8EE0
	
		// Nested types
		[Serializable]
		public struct Orbit // TypeDefIndex: 7283
		{
			// Fields
			public float m_Height; // 0x00
			public float m_Radius; // 0x04
	
			// Constructors
			public Orbit(float h, float r); // 0x00000001800103E0-0x00000001800103F0
		}
	
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom); // TypeDefIndex: 7284; 0x00000001817E5420-0x00000001817E58E0
	
		public delegate void DestroyRigDelegate(GameObject rig); // TypeDefIndex: 7285; 0x000000018055D3E0-0x000000018055D680
	
		// Constructors
		public CinemachineFreeLook(); // 0x00000001818C1B60-0x00000001818C2120
	
		// Methods
		protected override void OnValidate(); // 0x00000001818BFF50-0x00000001818C0030
		public CinemachineVirtualCamera GetRig(int i); // 0x00000001818BE310-0x00000001818BE380
		protected override void OnEnable(); // 0x00000001818BF970-0x00000001818BF9A0
		protected override void OnDestroy(); // 0x00000001818BF800-0x00000001818BF970
		private void OnTransformChildrenChanged(); // 0x00000001818BEFC0-0x00000001818BEFD0
		private void Reset(); // 0x00000001818C0B00-0x00000001818C0B10
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007417E1 */); // 0x00000001818BEFD0-0x00000001818BF160
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001818BF9A0-0x00000001818BFA80
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001818BE910-0x00000001818BEFC0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001818BFA80-0x00000001818BFF50
		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x00000001818BE380-0x00000001818BE8E0
		private void InvalidateRigCache(); // 0x00000001818BEFC0-0x00000001818BEFD0
		private void DestroyRigs(); // 0x00000001818BDB70-0x00000001818BDFE0
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom); // 0x00000001818BD5C0-0x00000001818BDB70
		private void UpdateRigCache(); // 0x00000001818C11E0-0x00000001818C1AE0
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital); // 0x00000001818BF160-0x00000001818BF800
		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x00000001818C1AE0-0x00000001818C1B60
		private void PushSettingsToRigs(); // 0x00000001818C0030-0x00000001818C0B00
		private float GetYAxisValue(); // 0x00000001818BE8E0-0x00000001818BE910
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x00000001818BD2F0-0x00000001818BD5C0
		public Vector3 GetLocalPositionForCameraFromInput(float t); // 0x00000001818BDFE0-0x00000001818BE310
		private void UpdateCachedSpline(); // 0x00000001818C0B10-0x00000001818C11E0
	}
}
