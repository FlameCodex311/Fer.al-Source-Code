/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x000000018011ED30-0x000000018011EDA0
	[DocumentationSorting] // 0x000000018011ED30-0x000000018011EDA0
	[ExecuteAlways] // 0x000000018011ED30-0x000000018011EDA0
	[SaveDuringPlay] // 0x000000018011ED30-0x000000018011EDA0
	public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 7274
	{
		// Fields
		[Tooltip] // 0x000000018011F130-0x000000018011F160
		public Mode m_ConfineMode; // 0x28
		[Tooltip] // 0x000000018011F300-0x000000018011F330
		public Collider m_BoundingVolume; // 0x30
		[Tooltip] // 0x000000018011F4A0-0x000000018011F4D0
		public Collider2D m_BoundingShape2D; // 0x38
		[Tooltip] // 0x000000018011F7D0-0x000000018011F800
		public bool m_ConfineScreenEdges; // 0x40
		[Range] // 0x000000018011F8F0-0x000000018011F940
		[Tooltip] // 0x000000018011F8F0-0x000000018011F940
		public float m_Damping; // 0x44
		private List<List<Vector2>> m_pathCache; // 0x48
		private int m_pathTotalPointCount; // 0x50
	
		// Properties
		public bool IsValid { get; } // 0x00000001818B69B0-0x00000001818B6A70 
	
		// Nested types
		public enum Mode // TypeDefIndex: 7275
		{
			Confine2D = 0,
			Confine3D = 1
		}
	
		private class VcamExtraState // TypeDefIndex: 7276
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float confinerDisplacement; // 0x1C
	
			// Constructors
			public VcamExtraState(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public CinemachineConfiner(); // 0x00000001818B69A0-0x00000001818B69B0
	
		// Methods
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam); // 0x00000001818B5460-0x00000001818B54D0
		private void OnValidate(); // 0x00000001818B6140-0x00000001818B61B0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001818B61B0-0x00000001818B6510
		public void InvalidatePathCache(); // 0x00000001818B6130-0x00000001818B6140
		private bool ValidatePathCache(); // 0x00000001818B6510-0x00000001818B69A0
		private Vector3 ConfinePoint(Vector3 camPos); // 0x00000001818B54D0-0x00000001818B5A60
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state); // 0x00000001818B5A60-0x00000001818B6130
	}
}
