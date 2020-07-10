/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine.Utility;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180135F10-0x0000000180135F70
	[DocumentationSorting] // 0x0000000180135F10-0x0000000180135F70
	[SaveDuringPlay] // 0x0000000180135F10-0x0000000180135F70
	public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 7309
	{
		// Fields
		[Tooltip] // 0x0000000180136160-0x0000000180136190
		public Vector3 m_TrackedObjectOffset; // 0x50
		[Range] // 0x00000001801362A0-0x0000000180136310
		[Space] // 0x00000001801362A0-0x0000000180136310
		[Tooltip] // 0x00000001801362A0-0x0000000180136310
		public float m_LookaheadTime; // 0x5C
		[Range] // 0x00000001801364B0-0x0000000180136510
		[Tooltip] // 0x00000001801364B0-0x0000000180136510
		public float m_LookaheadSmoothing; // 0x60
		[Tooltip] // 0x0000000180136590-0x00000001801365C0
		public bool m_LookaheadIgnoreY; // 0x64
		[Range] // 0x0000000180136670-0x00000001801366E0
		[Space] // 0x0000000180136670-0x00000001801366E0
		[Tooltip] // 0x0000000180136670-0x00000001801366E0
		public float m_HorizontalDamping; // 0x68
		[Range] // 0x0000000180136880-0x00000001801368E0
		[Tooltip] // 0x0000000180136880-0x00000001801368E0
		public float m_VerticalDamping; // 0x6C
		[Range] // 0x0000000180136A70-0x0000000180136AD0
		[Space] // 0x0000000180136A70-0x0000000180136AD0
		[Tooltip] // 0x0000000180136A70-0x0000000180136AD0
		public float m_ScreenX; // 0x70
		[Range] // 0x0000000180136D60-0x0000000180136DC0
		[Tooltip] // 0x0000000180136D60-0x0000000180136DC0
		public float m_ScreenY; // 0x74
		[Range] // 0x0000000180136F20-0x0000000180136F70
		[Tooltip] // 0x0000000180136F20-0x0000000180136F70
		public float m_DeadZoneWidth; // 0x78
		[Range] // 0x00000001801371C0-0x0000000180137210
		[Tooltip] // 0x00000001801371C0-0x0000000180137210
		public float m_DeadZoneHeight; // 0x7C
		[Range] // 0x0000000180137230-0x0000000180137280
		[Tooltip] // 0x0000000180137230-0x0000000180137280
		public float m_SoftZoneWidth; // 0x80
		[Range] // 0x00000001801373F0-0x0000000180137450
		[Tooltip] // 0x00000001801373F0-0x0000000180137450
		public float m_SoftZoneHeight; // 0x84
		[Range] // 0x0000000180137840-0x00000001801378A0
		[Tooltip] // 0x0000000180137840-0x00000001801378A0
		public float m_BiasX; // 0x88
		[Range] // 0x0000000180137AD0-0x0000000180137B30
		[Tooltip] // 0x0000000180137AD0-0x0000000180137B30
		public float m_BiasY; // 0x8C
		[Tooltip] // 0x0000000180137BB0-0x0000000180137BE0
		public bool m_CenterOnActivate; // 0x90
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <TrackedPoint>k__BackingField; // 0x94
		private Vector3 m_CameraPosPrevFrame; // 0xA0
		private Vector3 m_LookAtPrevFrame; // 0xAC
		private Vector2 m_ScreenOffsetPrevFrame; // 0xB8
		private Quaternion m_CameraOrientationPrevFrame; // 0xC0
		internal PositionPredictor m_Predictor; // 0xD0
		private FovCache mCache; // 0xD8
	
		// Properties
		public override bool IsValid { get; } // 0x00000001818B4F90-0x00000001818B5010 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018042E670-0x000000018042E680 
		public Vector3 TrackedPoint { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001818B5080-0x00000001818B50A0 0x00000001818B5440-0x00000001818B5460
		internal Rect SoftGuideRect { get; set; } // 0x00000001818B5010-0x00000001818B5080 0x00000001818B5320-0x00000001818B5440
		internal Rect HardGuideRect { get; set; } // 0x00000001818B4E60-0x00000001818B4F90 0x00000001818B50A0-0x00000001818B5320
	
		// Nested types
		private struct FovCache // TypeDefIndex: 7310
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
			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance); // 0x00000001802A34E0-0x00000001802A3560
			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect); // 0x00000001802A3480-0x00000001802A34E0
		}
	
		// Constructors
		public CinemachineComposer(); // 0x00000001818B4CD0-0x00000001818B4E60
	
		// Methods
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime); // 0x00000001818B3660-0x00000001818B3B50
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001818B47D0-0x00000001818B4970
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001818B4970-0x00000001818B4A20
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001818B3B50-0x00000001818B47D0
		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime); // 0x00000001818B4A20-0x00000001818B4CD0
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov); // 0x00000001818B3470-0x00000001818B3660
	}
}
