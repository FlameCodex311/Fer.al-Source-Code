/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801D39C0-0x00000001801D3A20
	[DocumentationSorting] // 0x00000001801D39C0-0x00000001801D3A20
	[SaveDuringPlay] // 0x00000001801D39C0-0x00000001801D3A20
	public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 7477
	{
		// Fields
		[Range] // 0x00000001801D6980-0x00000001801D69D0
		[Tooltip] // 0x00000001801D6980-0x00000001801D69D0
		public float m_LookaheadTime; // 0x50
		[Range] // 0x00000001801D4350-0x00000001801D43B0
		[Tooltip] // 0x00000001801D4350-0x00000001801D43B0
		public float m_LookaheadSmoothing; // 0x54
		[Tooltip] // 0x00000001801D4710-0x00000001801D4740
		public bool m_LookaheadIgnoreY; // 0x58
		[Range] // 0x00000001801D6E60-0x00000001801D6ED0
		[Space] // 0x00000001801D6E60-0x00000001801D6ED0
		[Tooltip] // 0x00000001801D6E60-0x00000001801D6ED0
		public float m_XDamping; // 0x5C
		[Range] // 0x00000001801D7110-0x00000001801D7170
		[Tooltip] // 0x00000001801D7110-0x00000001801D7170
		public float m_YDamping; // 0x60
		[Range] // 0x00000001801D7260-0x00000001801D72C0
		[Tooltip] // 0x00000001801D7260-0x00000001801D72C0
		public float m_ZDamping; // 0x64
		[Range] // 0x00000001801D7620-0x00000001801D7680
		[Space] // 0x00000001801D7620-0x00000001801D7680
		[Tooltip] // 0x00000001801D7620-0x00000001801D7680
		public float m_ScreenX; // 0x68
		[Range] // 0x00000001801D78D0-0x00000001801D7920
		[Tooltip] // 0x00000001801D78D0-0x00000001801D7920
		public float m_ScreenY; // 0x6C
		[Tooltip] // 0x00000001801D7C70-0x00000001801D7CA0
		public float m_CameraDistance; // 0x70
		[Range] // 0x00000001801D7EE0-0x00000001801D7F50
		[Space] // 0x00000001801D7EE0-0x00000001801D7F50
		[Tooltip] // 0x00000001801D7EE0-0x00000001801D7F50
		public float m_DeadZoneWidth; // 0x74
		[Range] // 0x00000001801D8220-0x00000001801D8280
		[Tooltip] // 0x00000001801D8220-0x00000001801D8280
		public float m_DeadZoneHeight; // 0x78
		[FormerlySerializedAs] // 0x00000001801D8670-0x00000001801D86D0
		[Tooltip] // 0x00000001801D8670-0x00000001801D86D0
		public float m_DeadZoneDepth; // 0x7C
		[Space] // 0x00000001801D89F0-0x00000001801D8A40
		[Tooltip] // 0x00000001801D89F0-0x00000001801D8A40
		public bool m_UnlimitedSoftZone; // 0x80
		[Range] // 0x00000001801D8C90-0x00000001801D8CE0
		[Tooltip] // 0x00000001801D8C90-0x00000001801D8CE0
		public float m_SoftZoneWidth; // 0x84
		[Range] // 0x00000001801D8F30-0x00000001801D8F80
		[Tooltip] // 0x00000001801D8F30-0x00000001801D8F80
		public float m_SoftZoneHeight; // 0x88
		[Range] // 0x00000001801D9110-0x00000001801D9160
		[Tooltip] // 0x00000001801D9110-0x00000001801D9160
		public float m_BiasX; // 0x8C
		[Range] // 0x00000001801D61B0-0x00000001801D6210
		[Tooltip] // 0x00000001801D61B0-0x00000001801D6210
		public float m_BiasY; // 0x90
		[Tooltip] // 0x00000001801D62B0-0x00000001801D62E0
		public bool m_CenterOnActivate; // 0x94
		[FormerlySerializedAs] // 0x00000001801D9750-0x00000001801D97C0
		[Space] // 0x00000001801D9750-0x00000001801D97C0
		[Tooltip] // 0x00000001801D9750-0x00000001801D97C0
		public FramingMode m_GroupFramingMode; // 0x98
		[Tooltip] // 0x00000001801D9AD0-0x00000001801D9B00
		public AdjustmentMode m_AdjustmentMode; // 0x9C
		[Tooltip] // 0x00000001801D9BD0-0x00000001801D9C00
		public float m_GroupFramingSize; // 0xA0
		[Tooltip] // 0x00000001801D9CE0-0x00000001801D9D10
		public float m_MaxDollyIn; // 0xA4
		[Tooltip] // 0x00000001801D9F80-0x00000001801D9FB0
		public float m_MaxDollyOut; // 0xA8
		[Tooltip] // 0x00000001801DA060-0x00000001801DA090
		public float m_MinimumDistance; // 0xAC
		[Tooltip] // 0x00000001801DA2B0-0x00000001801DA2E0
		public float m_MaximumDistance; // 0xB0
		[Range] // 0x00000001801DA400-0x00000001801DA460
		[Tooltip] // 0x00000001801DA400-0x00000001801DA460
		public float m_MinimumFOV; // 0xB4
		[Range] // 0x00000001801DA610-0x00000001801DA670
		[Tooltip] // 0x00000001801DA610-0x00000001801DA670
		public float m_MaximumFOV; // 0xB8
		[Tooltip] // 0x00000001801DAB10-0x00000001801DAB40
		public float m_MinimumOrthoSize; // 0xBC
		[Tooltip] // 0x00000001801DADA0-0x00000001801DADD0
		public float m_MaximumOrthoSize; // 0xC0
		private const float kMinimumCameraDistance = 0.01f; // Metadata: 0x00776504
		private Vector3 m_PreviousCameraPosition; // 0xC4
		private PositionPredictor m_Predictor; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <TrackedPoint>k__BackingField; // 0xD8
		private float m_prevFOV; // 0xE4
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Bounds <LastBounds>k__BackingField; // 0xE8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x100
	
		// Properties
		internal Rect SoftGuideRect { get; set; } // 0x0000000181363120-0x0000000181363190 0x0000000181363480-0x00000001813635A0
		internal Rect HardGuideRect { get; set; } // 0x0000000181362F20-0x0000000181363050 0x00000001813631B0-0x0000000181363430
		public override bool IsValid { get; } // 0x0000000181363050-0x00000001813630D0 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public Vector3 TrackedPoint { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181363190-0x00000001813631B0 0x00000001813635A0-0x0000000181363EE0
		public Bounds LastBounds { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181363100-0x0000000181363120 0x0000000181363460-0x0000000181363480
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001813630D0-0x0000000181363100 0x0000000181363430-0x0000000181363460
	
		// Nested types
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum FramingMode // TypeDefIndex: 7478
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}
	
		public enum AdjustmentMode // TypeDefIndex: 7479
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineFramingTransposer(); // 0x0000000181362DC0-0x0000000181362F20
	
		// Methods
		private void OnValidate(); // 0x00000001813629C0-0x0000000181362B50
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000181362880-0x00000001813629C0
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect); // 0x0000000181362CC0-0x0000000181362DC0
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect); // 0x0000000181362B50-0x0000000181362CC0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001813610C0-0x0000000181362880
		private float GetTargetHeight(Vector2 boundsSize); // 0x0000000181360E50-0x00000001813610C0
		private Vector3 ComputeGroupBounds(CinemachineTargetGroup group, ref CameraState curState); // 0x0000000181360110-0x0000000181360750
		private static Bounds GetScreenSpaceGroupBoundingBox(CinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation); // 0x0000000181360750-0x0000000181360E50
	}
}
