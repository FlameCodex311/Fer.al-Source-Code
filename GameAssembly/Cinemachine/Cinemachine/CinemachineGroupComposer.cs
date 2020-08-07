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
	[AddComponentMenu] // 0x00000001801D39C0-0x00000001801D3A20
	[DocumentationSorting] // 0x00000001801D39C0-0x00000001801D3A20
	[SaveDuringPlay] // 0x00000001801D39C0-0x00000001801D3A20
	public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 7480
	{
		// Fields
		[Space] // 0x00000001801DD190-0x00000001801DD1D0
		[Tooltip] // 0x00000001801DD190-0x00000001801DD1D0
		public float m_GroupFramingSize; // 0x128
		[Tooltip] // 0x00000001801DD400-0x00000001801DD430
		public FramingMode m_FramingMode; // 0x12C
		[Range] // 0x00000001801DD5B0-0x00000001801DD610
		[Tooltip] // 0x00000001801DD5B0-0x00000001801DD610
		public float m_FrameDamping; // 0x130
		[Tooltip] // 0x00000001801D9AD0-0x00000001801D9B00
		public AdjustmentMode m_AdjustmentMode; // 0x134
		[Tooltip] // 0x00000001801D9CE0-0x00000001801D9D10
		public float m_MaxDollyIn; // 0x138
		[Tooltip] // 0x00000001801D9F80-0x00000001801D9FB0
		public float m_MaxDollyOut; // 0x13C
		[Tooltip] // 0x00000001801DA060-0x00000001801DA090
		public float m_MinimumDistance; // 0x140
		[Tooltip] // 0x00000001801DA2B0-0x00000001801DA2E0
		public float m_MaximumDistance; // 0x144
		[Range] // 0x00000001801DA400-0x00000001801DA460
		[Tooltip] // 0x00000001801DA400-0x00000001801DA460
		public float m_MinimumFOV; // 0x148
		[Range] // 0x00000001801DE320-0x00000001801DE370
		[Tooltip] // 0x00000001801DE320-0x00000001801DE370
		public float m_MaximumFOV; // 0x14C
		[Tooltip] // 0x00000001801DAB10-0x00000001801DAB40
		public float m_MinimumOrthoSize; // 0x150
		[Tooltip] // 0x00000001801DADA0-0x00000001801DADD0
		public float m_MaximumOrthoSize; // 0x154
		private float m_prevFramingDistance; // 0x158
		private float m_prevFOV; // 0x15C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Bounds <LastBounds>k__BackingField; // 0x160
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178
	
		// Properties
		public Bounds LastBounds { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018138ABC0-0x000000018138ABE0 0x000000018138AC10-0x000000018138AC30
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018138AB90-0x000000018138ABC0 0x000000018138ABE0-0x000000018138AC10
	
		// Nested types
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum FramingMode // TypeDefIndex: 7481
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum AdjustmentMode // TypeDefIndex: 7482
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineGroupComposer(); // 0x000000018138AB10-0x000000018138AB90
	
		// Methods
		private void OnValidate(); // 0x000000018138A9B0-0x000000018138AB10
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001813897C0-0x000000018138A9B0
		private float GetTargetHeight(Vector2 boundsSize); // 0x00000001813894E0-0x00000001813897C0
		private static Bounds GetScreenSpaceGroupBoundingBox(CinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd); // 0x0000000181389120-0x00000001813894E0
	}
}
