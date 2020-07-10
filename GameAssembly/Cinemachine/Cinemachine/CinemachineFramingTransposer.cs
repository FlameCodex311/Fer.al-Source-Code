/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180135F10-0x0000000180135F70
	[DocumentationSorting] // 0x0000000180135F10-0x0000000180135F70
	[SaveDuringPlay] // 0x0000000180135F10-0x0000000180135F70
	public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 7311
	{
		// Fields
		[Range] // 0x0000000180137F90-0x0000000180137FE0
		[Tooltip] // 0x0000000180137F90-0x0000000180137FE0
		public float m_LookaheadTime; // 0x50
		[Range] // 0x00000001801364B0-0x0000000180136510
		[Tooltip] // 0x00000001801364B0-0x0000000180136510
		public float m_LookaheadSmoothing; // 0x54
		[Tooltip] // 0x0000000180136590-0x00000001801365C0
		public bool m_LookaheadIgnoreY; // 0x58
		[Range] // 0x0000000180138440-0x00000001801384B0
		[Space] // 0x0000000180138440-0x00000001801384B0
		[Tooltip] // 0x0000000180138440-0x00000001801384B0
		public float m_XDamping; // 0x5C
		[Range] // 0x0000000180139990-0x00000001801399F0
		[Tooltip] // 0x0000000180139990-0x00000001801399F0
		public float m_YDamping; // 0x60
		[Range] // 0x0000000180139C20-0x0000000180139C80
		[Tooltip] // 0x0000000180139C20-0x0000000180139C80
		public float m_ZDamping; // 0x64
		[Range] // 0x0000000180139DC0-0x0000000180139E20
		[Space] // 0x0000000180139DC0-0x0000000180139E20
		[Tooltip] // 0x0000000180139DC0-0x0000000180139E20
		public float m_ScreenX; // 0x68
		[Range] // 0x0000000180139FD0-0x000000018013A020
		[Tooltip] // 0x0000000180139FD0-0x000000018013A020
		public float m_ScreenY; // 0x6C
		[Tooltip] // 0x000000018013A1D0-0x000000018013A200
		public float m_CameraDistance; // 0x70
		[Range] // 0x000000018013A330-0x000000018013A3A0
		[Space] // 0x000000018013A330-0x000000018013A3A0
		[Tooltip] // 0x000000018013A330-0x000000018013A3A0
		public float m_DeadZoneWidth; // 0x74
		[Range] // 0x000000018013A4A0-0x000000018013A500
		[Tooltip] // 0x000000018013A4A0-0x000000018013A500
		public float m_DeadZoneHeight; // 0x78
		[FormerlySerializedAs] // 0x000000018013A790-0x000000018013A7F0
		[Tooltip] // 0x000000018013A790-0x000000018013A7F0
		public float m_DeadZoneDepth; // 0x7C
		[Space] // 0x000000018013A8D0-0x000000018013A920
		[Tooltip] // 0x000000018013A8D0-0x000000018013A920
		public bool m_UnlimitedSoftZone; // 0x80
		[Range] // 0x000000018013AAE0-0x000000018013AB30
		[Tooltip] // 0x000000018013AAE0-0x000000018013AB30
		public float m_SoftZoneWidth; // 0x84
		[Range] // 0x000000018013AB60-0x000000018013ABB0
		[Tooltip] // 0x000000018013AB60-0x000000018013ABB0
		public float m_SoftZoneHeight; // 0x88
		[Range] // 0x000000018013ACC0-0x000000018013AD10
		[Tooltip] // 0x000000018013ACC0-0x000000018013AD10
		public float m_BiasX; // 0x8C
		[Range] // 0x0000000180137AD0-0x0000000180137B30
		[Tooltip] // 0x0000000180137AD0-0x0000000180137B30
		public float m_BiasY; // 0x90
		[Tooltip] // 0x0000000180137BB0-0x0000000180137BE0
		public bool m_CenterOnActivate; // 0x94
		[FormerlySerializedAs] // 0x000000018013C570-0x000000018013C5E0
		[Space] // 0x000000018013C570-0x000000018013C5E0
		[Tooltip] // 0x000000018013C570-0x000000018013C5E0
		public FramingMode m_GroupFramingMode; // 0x98
		[Tooltip] // 0x000000018013C750-0x000000018013C780
		public AdjustmentMode m_AdjustmentMode; // 0x9C
		[Tooltip] // 0x000000018013C8B0-0x000000018013C8E0
		public float m_GroupFramingSize; // 0xA0
		[Tooltip] // 0x000000018013CA10-0x000000018013CA40
		public float m_MaxDollyIn; // 0xA4
		[Tooltip] // 0x000000018013CBC0-0x000000018013CBF0
		public float m_MaxDollyOut; // 0xA8
		[Tooltip] // 0x000000018013CCC0-0x000000018013CCF0
		public float m_MinimumDistance; // 0xAC
		[Tooltip] // 0x000000018013DFA0-0x000000018013DFD0
		public float m_MaximumDistance; // 0xB0
		[Range] // 0x000000018013E0A0-0x000000018013E100
		[Tooltip] // 0x000000018013E0A0-0x000000018013E100
		public float m_MinimumFOV; // 0xB4
		[Range] // 0x000000018013E230-0x000000018013E290
		[Tooltip] // 0x000000018013E230-0x000000018013E290
		public float m_MaximumFOV; // 0xB8
		[Tooltip] // 0x000000018013E3B0-0x000000018013E3E0
		public float m_MinimumOrthoSize; // 0xBC
		[Tooltip] // 0x000000018013E4F0-0x000000018013E520
		public float m_MaximumOrthoSize; // 0xC0
		private const float kMinimumCameraDistance = 0.01f; // Metadata: 0x00741816
		private Vector3 m_PreviousCameraPosition; // 0xC4
		private PositionPredictor m_Predictor; // 0xD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <TrackedPoint>k__BackingField; // 0xD8
		private float m_prevFOV; // 0xE4
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Bounds <LastBounds>k__BackingField; // 0xE8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x100
	
		// Properties
		internal Rect SoftGuideRect { get; set; } // 0x00000001818BCE50-0x00000001818BCEC0 0x00000001818BD1B0-0x00000001818BD2D0
		internal Rect HardGuideRect { get; set; } // 0x00000001818BCC50-0x00000001818BCD80 0x00000001818BCEE0-0x00000001818BD160
		public override bool IsValid { get; } // 0x00000001818BCD80-0x00000001818BCE00 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public Vector3 TrackedPoint { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001818BCEC0-0x00000001818BCEE0 0x00000001818BD2D0-0x00000001818BD2F0
		public Bounds LastBounds { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001818BCE30-0x00000001818BCE50 0x00000001818BD190-0x00000001818BD1B0
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001818BCE00-0x00000001818BCE30 0x00000001818BD160-0x00000001818BD190
	
		// Nested types
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum FramingMode // TypeDefIndex: 7312
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}
	
		public enum AdjustmentMode // TypeDefIndex: 7313
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineFramingTransposer(); // 0x00000001818BCAF0-0x00000001818BCC50
	
		// Methods
		private void OnValidate(); // 0x00000001818BC6F0-0x00000001818BC880
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001818BC5B0-0x00000001818BC6F0
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect); // 0x00000001818BC9F0-0x00000001818BCAF0
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect); // 0x00000001818BC880-0x00000001818BC9F0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001818BADF0-0x00000001818BC5B0
		private float GetTargetHeight(Vector2 boundsSize); // 0x00000001818BAB80-0x00000001818BADF0
		private Vector3 ComputeGroupBounds(CinemachineTargetGroup group, ref CameraState curState); // 0x00000001818B9E40-0x00000001818BA480
		private static Bounds GetScreenSpaceGroupBoundingBox(CinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation); // 0x00000001818BA480-0x00000001818BAB80
	}
}
