/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x000000018011B970-0x000000018011B9E0
	[DocumentationSorting] // 0x000000018011B970-0x000000018011B9E0
	[ExecuteAlways] // 0x000000018011B970-0x000000018011B9E0
	[SaveDuringPlay] // 0x000000018011B970-0x000000018011B9E0
	public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 7271
	{
		// Fields
		[Header] // 0x000000018011CEA0-0x000000018011CF00
		[Tooltip] // 0x000000018011CEA0-0x000000018011CF00
		public LayerMask m_CollideAgainst; // 0x28
		[TagField] // 0x000000018011D080-0x000000018011D0D0
		[Tooltip] // 0x000000018011D080-0x000000018011D0D0
		public string m_IgnoreTag; // 0x30
		[Tooltip] // 0x000000018011D2D0-0x000000018011D300
		public LayerMask m_TransparentLayers; // 0x38
		[Tooltip] // 0x000000018011D400-0x000000018011D430
		public float m_MinimumDistanceFromTarget; // 0x3C
		[FormerlySerializedAs] // 0x000000018011D550-0x000000018011D5C0
		[Space] // 0x000000018011D550-0x000000018011D5C0
		[Tooltip] // 0x000000018011D550-0x000000018011D5C0
		public bool m_AvoidObstacles; // 0x40
		[FormerlySerializedAs] // 0x000000018011D800-0x000000018011D860
		[Tooltip] // 0x000000018011D800-0x000000018011D860
		public float m_DistanceLimit; // 0x44
		[Tooltip] // 0x000000018011DA50-0x000000018011DA80
		public float m_MinimumOcclusionTime; // 0x48
		[Tooltip] // 0x000000018011DC00-0x000000018011DC30
		public float m_CameraRadius; // 0x4C
		[Tooltip] // 0x000000018011DDA0-0x000000018011DDD0
		public ResolutionStrategy m_Strategy; // 0x50
		[Range] // 0x000000018011DF70-0x000000018011DFD0
		[Tooltip] // 0x000000018011DF70-0x000000018011DFD0
		public int m_MaximumEffort; // 0x54
		[Range] // 0x000000018011E250-0x000000018011E2B0
		[Tooltip] // 0x000000018011E250-0x000000018011E2B0
		public float m_SmoothingTime; // 0x58
		[FormerlySerializedAs] // 0x000000018011E4C0-0x000000018011E540
		[Range] // 0x000000018011E4C0-0x000000018011E540
		[Tooltip] // 0x000000018011E4C0-0x000000018011E540
		public float m_Damping; // 0x5C
		[Range] // 0x000000018011E7E0-0x000000018011E840
		[Tooltip] // 0x000000018011E7E0-0x000000018011E840
		public float m_DampingWhenOccluded; // 0x60
		[Header] // 0x000000018011EB00-0x000000018011EB60
		[Tooltip] // 0x000000018011EB00-0x000000018011EB60
		public float m_OptimalTargetDistance; // 0x64
		private const float PrecisionSlush = 0.001f; // Metadata: 0x007417B9
		private RaycastHit[] m_CornerBuffer; // 0x68
		private const float AngleThreshold = 0.1f; // Metadata: 0x007417BD
		private Collider[] mColliderBuffer; // 0x70
		private static SphereCollider mCameraCollider; // 0x00
		private static GameObject mCameraColliderGameObject; // 0x08
	
		// Properties
		public List<List<Vector3>> DebugPaths { get; } // 0x00000001818B1490-0x00000001818B1630 
	
		// Nested types
		public enum ResolutionStrategy // TypeDefIndex: 7272
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}
	
		private class VcamExtraState // TypeDefIndex: 7273
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public Vector3 m_previousDisplacementCorrection; // 0x1C
			public float colliderDisplacement; // 0x28
			public bool targetObscured; // 0x2C
			public float occlusionStartTime; // 0x30
			public List<Vector3> debugResolutionPath; // 0x38
			private float m_SmoothedDistance; // 0x40
			private float m_SmoothedTime; // 0x44
	
			// Constructors
			public VcamExtraState(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void AddPointToDebugPath(Vector3 p); // 0x00000001803581E0-0x00000001803581F0
			public float ApplyDistanceSmoothing(float distance, float smoothingTime); // 0x00000001818C38A0-0x00000001818C3950
			public void UpdateDistanceSmoothing(float distance, float smoothingTime); // 0x00000001818C3990-0x00000001818C39E0
			public void ResetDistanceSmoothing(float smoothingTime); // 0x00000001818C3950-0x00000001818C3990
		}
	
		// Constructors
		public CinemachineCollider(); // 0x00000001818B13E0-0x00000001818B1490
	
		// Methods
		public bool IsTargetObscured(ICinemachineCamera vcam); // 0x00000001818ADE20-0x00000001818ADE80
		public bool CameraWasDisplaced(ICinemachineCamera vcam); // 0x00000001818AC8E0-0x00000001818AC950
		private void OnValidate(); // 0x00000001818AE2D0-0x00000001818AE3A0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001818AE3A0-0x00000001818AF080
		private Vector3 PreserveLignOfSight(ref CameraState state, ref VcamExtraState extra); // 0x00000001818AF080-0x00000001818AF530
		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo); // 0x00000001818AF530-0x00000001818AF940
		private bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask); // 0x00000001818B0170-0x00000001818B04B0
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra); // 0x00000001818AF940-0x00000001818B0170
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir); // 0x00000001818AD4C0-0x00000001818ADE20
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos); // 0x00000001818AD250-0x00000001818AD4C0
		private float ClampRayToBounds(Ray ray, float distance, Bounds bounds); // 0x00000001818ACBB0-0x00000001818AD250
		private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state); // 0x00000001818B04B0-0x00000001818B13E0
		private bool CheckForTargetObstructions(CameraState state); // 0x00000001818AC950-0x00000001818ACBB0
		private bool IsTargetOffscreen(CameraState state); // 0x00000001818ADE80-0x00000001818AE2D0
	}
}
