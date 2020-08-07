/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180287290-0x0000000180287300
	[DocumentationSorting] // 0x0000000180287290-0x0000000180287300
	[ExecuteAlways] // 0x0000000180287290-0x0000000180287300
	[SaveDuringPlay] // 0x0000000180287290-0x0000000180287300
	public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 7440
	{
		// Fields
		[Tooltip] // 0x00000001802887E0-0x0000000180288810
		public Mode m_ConfineMode; // 0x28
		[Tooltip] // 0x0000000180288A00-0x0000000180288A30
		public Collider m_BoundingVolume; // 0x30
		[Tooltip] // 0x0000000180288A90-0x0000000180288AC0
		public Collider2D m_BoundingShape2D; // 0x38
		[Tooltip] // 0x0000000180288B70-0x0000000180288BA0
		public bool m_ConfineScreenEdges; // 0x40
		[Range] // 0x0000000180288D30-0x0000000180288D80
		[Tooltip] // 0x0000000180288D30-0x0000000180288D80
		public float m_Damping; // 0x44
		private List<List<Vector2>> m_pathCache; // 0x48
		private int m_pathTotalPointCount; // 0x50
	
		// Properties
		public bool IsValid { get; } // 0x000000018135CD00-0x000000018135CDC0 
	
		// Nested types
		public enum Mode // TypeDefIndex: 7441
		{
			Confine2D = 0,
			Confine3D = 1
		}
	
		private class VcamExtraState // TypeDefIndex: 7442
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float confinerDisplacement; // 0x1C
	
			// Constructors
			public VcamExtraState(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public CinemachineConfiner(); // 0x000000018135CCF0-0x000000018135CD00
	
		// Methods
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam); // 0x000000018135B7F0-0x000000018135B860
		private void OnValidate(); // 0x000000018135C4C0-0x000000018135C530
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018135C530-0x000000018135C880
		public void InvalidatePathCache(); // 0x000000018135C4B0-0x000000018135C4C0
		private bool ValidatePathCache(); // 0x000000018135C880-0x000000018135CCF0
		private Vector3 ConfinePoint(Vector3 camPos); // 0x000000018135B860-0x000000018135BDE0
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state); // 0x000000018135BDE0-0x000000018135C4B0
	}
}
