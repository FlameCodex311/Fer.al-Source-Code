/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine.Utility;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801D39C0-0x00000001801D3A20
	[DocumentationSorting] // 0x00000001801D39C0-0x00000001801D3A20
	[SaveDuringPlay] // 0x00000001801D39C0-0x00000001801D3A20
	public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 7475
	{
		// Fields
		[Tooltip] // 0x00000001801D3C60-0x00000001801D3C90
		public Vector3 m_TrackedObjectOffset; // 0x50
		[Range] // 0x00000001801D3DB0-0x00000001801D3E20
		[Space] // 0x00000001801D3DB0-0x00000001801D3E20
		[Tooltip] // 0x00000001801D3DB0-0x00000001801D3E20
		public float m_LookaheadTime; // 0x5C
		[Range] // 0x00000001801D4350-0x00000001801D43B0
		[Tooltip] // 0x00000001801D4350-0x00000001801D43B0
		public float m_LookaheadSmoothing; // 0x60
		[Tooltip] // 0x00000001801D4710-0x00000001801D4740
		public bool m_LookaheadIgnoreY; // 0x64
		[Range] // 0x00000001801D49C0-0x00000001801D4A30
		[Space] // 0x00000001801D49C0-0x00000001801D4A30
		[Tooltip] // 0x00000001801D49C0-0x00000001801D4A30
		public float m_HorizontalDamping; // 0x68
		[Range] // 0x00000001801D4D30-0x00000001801D4D90
		[Tooltip] // 0x00000001801D4D30-0x00000001801D4D90
		public float m_VerticalDamping; // 0x6C
		[Range] // 0x00000001801D5050-0x00000001801D50B0
		[Space] // 0x00000001801D5050-0x00000001801D50B0
		[Tooltip] // 0x00000001801D5050-0x00000001801D50B0
		public float m_ScreenX; // 0x70
		[Range] // 0x00000001801D5490-0x00000001801D54F0
		[Tooltip] // 0x00000001801D5490-0x00000001801D54F0
		public float m_ScreenY; // 0x74
		[Range] // 0x00000001801D55C0-0x00000001801D5610
		[Tooltip] // 0x00000001801D55C0-0x00000001801D5610
		public float m_DeadZoneWidth; // 0x78
		[Range] // 0x00000001801D5860-0x00000001801D58B0
		[Tooltip] // 0x00000001801D5860-0x00000001801D58B0
		public float m_DeadZoneHeight; // 0x7C
		[Range] // 0x00000001801D5A60-0x00000001801D5AB0
		[Tooltip] // 0x00000001801D5A60-0x00000001801D5AB0
		public float m_SoftZoneWidth; // 0x80
		[Range] // 0x00000001801D5BC0-0x00000001801D5C20
		[Tooltip] // 0x00000001801D5BC0-0x00000001801D5C20
		public float m_SoftZoneHeight; // 0x84
		[Range] // 0x00000001801D5E80-0x00000001801D5EE0
		[Tooltip] // 0x00000001801D5E80-0x00000001801D5EE0
		public float m_BiasX; // 0x88
		[Range] // 0x00000001801D61B0-0x00000001801D6210
		[Tooltip] // 0x00000001801D61B0-0x00000001801D6210
		public float m_BiasY; // 0x8C
		[Tooltip] // 0x00000001801D62B0-0x00000001801D62E0
		public bool m_CenterOnActivate; // 0x90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <TrackedPoint>k__BackingField; // 0x94
		private Vector3 m_CameraPosPrevFrame; // 0xA0
		private Vector3 m_LookAtPrevFrame; // 0xAC
		private Vector2 m_ScreenOffsetPrevFrame; // 0xB8
		private Quaternion m_CameraOrientationPrevFrame; // 0xC0
		internal PositionPredictor m_Predictor; // 0xD0
		private FovCache mCache; // 0xD8
	
		// Properties
		public override bool IsValid { get; } // 0x000000018135B320-0x000000018135B3A0 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018058C710-0x000000018058C720 
		public Vector3 TrackedPoint { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018135B410-0x000000018135B430 0x000000018135B7D0-0x000000018135B7F0
		internal Rect SoftGuideRect { get; set; } // 0x000000018135B3A0-0x000000018135B410 0x000000018135B6B0-0x000000018135B7D0
		internal Rect HardGuideRect { get; set; } // 0x000000018135B1F0-0x000000018135B320 0x000000018135B430-0x000000018135B6B0
	
		// Nested types
		private struct FovCache // TypeDefIndex: 7476
		{
			// Fields
			public Rect mFovSoftGuideRect; // 0x00
			public Rect mFovHardGuideRect; // 0x10
			public float mFovH; // 0x20
			public float mFov; // 0x24
			private float mOrthoSizeOverDistance; // 0x28
			private float mAspect; // 0x2C
			private Rect mSoftGuideRect; // 0x30
			private Rect mHardGuideRect; // 0x40
	
			// Methods
			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance); // 0x00000001800C0E50-0x00000001800C0EF0
			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect); // 0x00000001800C0DF0-0x00000001800C0E50
		}
	
		// Constructors
		public CinemachineComposer(); // 0x000000018135B060-0x000000018135B1F0
	
		// Methods
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime); // 0x00000001813599F0-0x0000000181359EE0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018135AB60-0x000000018135AD00
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018135AD00-0x000000018135ADB0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000181359EE0-0x000000018135AB60
		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime); // 0x000000018135ADB0-0x000000018135B060
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov); // 0x0000000181359800-0x00000001813599F0
	}
}
