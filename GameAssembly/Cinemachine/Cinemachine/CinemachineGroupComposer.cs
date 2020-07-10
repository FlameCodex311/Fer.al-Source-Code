/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180135F10-0x0000000180135F70
	[DocumentationSorting] // 0x0000000180135F10-0x0000000180135F70
	[SaveDuringPlay] // 0x0000000180135F10-0x0000000180135F70
	public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 7314
	{
		// Fields
		[Space] // 0x000000018013F230-0x000000018013F270
		[Tooltip] // 0x000000018013F230-0x000000018013F270
		public float m_GroupFramingSize; // 0x128
		[Tooltip] // 0x000000018013F4E0-0x000000018013F510
		public FramingMode m_FramingMode; // 0x12C
		[Range] // 0x000000018013F6A0-0x000000018013F700
		[Tooltip] // 0x000000018013F6A0-0x000000018013F700
		public float m_FrameDamping; // 0x130
		[Tooltip] // 0x000000018013C750-0x000000018013C780
		public AdjustmentMode m_AdjustmentMode; // 0x134
		[Tooltip] // 0x000000018013CA10-0x000000018013CA40
		public float m_MaxDollyIn; // 0x138
		[Tooltip] // 0x000000018013CBC0-0x000000018013CBF0
		public float m_MaxDollyOut; // 0x13C
		[Tooltip] // 0x000000018013CCC0-0x000000018013CCF0
		public float m_MinimumDistance; // 0x140
		[Tooltip] // 0x000000018013DFA0-0x000000018013DFD0
		public float m_MaximumDistance; // 0x144
		[Range] // 0x000000018013E0A0-0x000000018013E100
		[Tooltip] // 0x000000018013E0A0-0x000000018013E100
		public float m_MinimumFOV; // 0x148
		[Range] // 0x000000018013FD60-0x000000018013FDB0
		[Tooltip] // 0x000000018013FD60-0x000000018013FDB0
		public float m_MaximumFOV; // 0x14C
		[Tooltip] // 0x000000018013E3B0-0x000000018013E3E0
		public float m_MinimumOrthoSize; // 0x150
		[Tooltip] // 0x000000018013E4F0-0x000000018013E520
		public float m_MaximumOrthoSize; // 0x154
		private float m_prevFramingDistance; // 0x158
		private float m_prevFOV; // 0x15C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Bounds <LastBounds>k__BackingField; // 0x160
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178
	
		// Properties
		public Bounds LastBounds { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001817CEAC0-0x00000001817CEAE0 0x00000001817CEB10-0x00000001817CEB30
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001817CEA90-0x00000001817CEAC0 0x00000001817CEAE0-0x00000001817CEB10
	
		// Nested types
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum FramingMode // TypeDefIndex: 7315
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum AdjustmentMode // TypeDefIndex: 7316
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineGroupComposer(); // 0x00000001817CEA10-0x00000001817CEA90
	
		// Methods
		private void OnValidate(); // 0x00000001817CE8B0-0x00000001817CEA10
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001817CD6F0-0x00000001817CE8B0
		private float GetTargetHeight(Vector2 boundsSize); // 0x00000001817CD430-0x00000001817CD6F0
		private static Bounds GetScreenSpaceGroupBoundingBox(CinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd); // 0x00000001817CD070-0x00000001817CD430
	}
}
