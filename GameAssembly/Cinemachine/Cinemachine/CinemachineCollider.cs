/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180283F90-0x0000000180284000
	[DocumentationSorting] // 0x0000000180283F90-0x0000000180284000
	[ExecuteAlways] // 0x0000000180283F90-0x0000000180284000
	[SaveDuringPlay] // 0x0000000180283F90-0x0000000180284000
	public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 7437
	{
		// Fields
		[Header] // 0x00000001802841A0-0x0000000180284200
		[Tooltip] // 0x00000001802841A0-0x0000000180284200
		public LayerMask m_CollideAgainst; // 0x28
		[TagField] // 0x0000000180284330-0x0000000180284380
		[Tooltip] // 0x0000000180284330-0x0000000180284380
		public string m_IgnoreTag; // 0x30
		[Tooltip] // 0x0000000180284540-0x0000000180284570
		public LayerMask m_TransparentLayers; // 0x38
		[Tooltip] // 0x00000001802846A0-0x00000001802846D0
		public float m_MinimumDistanceFromTarget; // 0x3C
		[FormerlySerializedAs] // 0x0000000180284840-0x00000001802848B0
		[Space] // 0x0000000180284840-0x00000001802848B0
		[Tooltip] // 0x0000000180284840-0x00000001802848B0
		public bool m_AvoidObstacles; // 0x40
		[FormerlySerializedAs] // 0x0000000180284B70-0x0000000180284BD0
		[Tooltip] // 0x0000000180284B70-0x0000000180284BD0
		public float m_DistanceLimit; // 0x44
		[Tooltip] // 0x0000000180286180-0x00000001802861B0
		public float m_MinimumOcclusionTime; // 0x48
		[Tooltip] // 0x00000001802862A0-0x00000001802862D0
		public float m_CameraRadius; // 0x4C
		[Tooltip] // 0x0000000180286470-0x00000001802864A0
		public ResolutionStrategy m_Strategy; // 0x50
		[Range] // 0x00000001802865F0-0x0000000180286650
		[Tooltip] // 0x00000001802865F0-0x0000000180286650
		public int m_MaximumEffort; // 0x54
		[Range] // 0x0000000180286890-0x00000001802868F0
		[Tooltip] // 0x0000000180286890-0x00000001802868F0
		public float m_SmoothingTime; // 0x58
		[FormerlySerializedAs] // 0x0000000180286AD0-0x0000000180286B50
		[Range] // 0x0000000180286AD0-0x0000000180286B50
		[Tooltip] // 0x0000000180286AD0-0x0000000180286B50
		public float m_Damping; // 0x5C
		[Range] // 0x0000000180286DA0-0x0000000180286E00
		[Tooltip] // 0x0000000180286DA0-0x0000000180286E00
		public float m_DampingWhenOccluded; // 0x60
		[Header] // 0x0000000180286F90-0x0000000180286FF0
		[Tooltip] // 0x0000000180286F90-0x0000000180286FF0
		public float m_OptimalTargetDistance; // 0x64
		private const float PrecisionSlush = 0.001f; // Metadata: 0x007764A7
		private RaycastHit[] m_CornerBuffer; // 0x68
		private const float AngleThreshold = 0.1f; // Metadata: 0x007764AB
		private Collider[] mColliderBuffer; // 0x70
		private static SphereCollider mCameraCollider; // 0x00
		private static GameObject mCameraColliderGameObject; // 0x08
	
		// Properties
		public List<List<Vector3>> DebugPaths { get; } // 0x0000000181357850-0x00000001813579F0 
	
		// Nested types
		public enum ResolutionStrategy // TypeDefIndex: 7438
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}
	
		private class VcamExtraState // TypeDefIndex: 7439
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
			public VcamExtraState(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void AddPointToDebugPath(Vector3 p); // 0x00000001803774A0-0x00000001803774B0
			public float ApplyDistanceSmoothing(float distance, float smoothingTime); // 0x0000000181364BF0-0x0000000181364CA0
			public void UpdateDistanceSmoothing(float distance, float smoothingTime); // 0x0000000181364CE0-0x0000000181364D30
			public void ResetDistanceSmoothing(float smoothingTime); // 0x0000000181364CA0-0x0000000181364CE0
		}
	
		// Constructors
		public CinemachineCollider(); // 0x00000001813577A0-0x0000000181357850
	
		// Methods
		public bool IsTargetObscured(ICinemachineCamera vcam); // 0x0000000181354220-0x0000000181354280
		public bool CameraWasDisplaced(ICinemachineCamera vcam); // 0x0000000181352D10-0x0000000181352D80
		private void OnValidate(); // 0x00000001813546D0-0x00000001813547A0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001813547A0-0x0000000181355470
		private Vector3 PreserveLignOfSight(ref CameraState state, ref VcamExtraState extra); // 0x0000000181355470-0x0000000181355920
		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo); // 0x0000000181355920-0x0000000181355D30
		private bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask); // 0x0000000181356550-0x0000000181356890
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra); // 0x0000000181355D30-0x0000000181356550
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir); // 0x00000001813538F0-0x0000000181354220
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos); // 0x0000000181353680-0x00000001813538F0
		private float ClampRayToBounds(Ray ray, float distance, Bounds bounds); // 0x0000000181352FE0-0x0000000181353680
		private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state); // 0x0000000181356890-0x00000001813577A0
		private bool CheckForTargetObstructions(CameraState state); // 0x0000000181352D80-0x0000000181352FE0
		private bool IsTargetOffscreen(CameraState state); // 0x0000000181354280-0x00000001813546D0
	}
}
