/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[Serializable]
	public class FeralCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13908
	{
		// Fields
		[NonSerialized]
		public FeralCameraStateSettings StateSettingsOverride; // 0x10
		public float overrideBlend; // 0x18
		[Header] // 0x0000000180143CF0-0x0000000180143D60
		[SerializeField] // 0x0000000180143CF0-0x0000000180143D60
		[Tooltip] // 0x0000000180143CF0-0x0000000180143D60
		private float _cameraFov; // 0x1C
		[SerializeField] // 0x0000000180144040-0x0000000180144080
		[Tooltip] // 0x0000000180144040-0x0000000180144080
		private Vector2 _cameraClippingLowQuality; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 _cameraClippingMediumQuality; // 0x28
		[FormerlySerializedAs] // 0x00000001801456D0-0x0000000180145710
		[SerializeField] // 0x00000001801456D0-0x0000000180145710
		private Vector2 _cameraClippingHighQuality; // 0x30
		[Header] // 0x0000000180145880-0x00000001801458F0
		[SerializeField] // 0x0000000180145880-0x00000001801458F0
		[Tooltip] // 0x0000000180145880-0x00000001801458F0
		private CameraModeOverride _overrideCameraMode; // 0x38
		[SerializeField] // 0x0000000180145B30-0x0000000180145B70
		[Tooltip] // 0x0000000180145B30-0x0000000180145B70
		private CursorModeOverride _overrideCursorMode; // 0x3C
		[Header] // 0x0000000180145DC0-0x0000000180145E30
		[SerializeField] // 0x0000000180145DC0-0x0000000180145E30
		[Tooltip] // 0x0000000180145DC0-0x0000000180145E30
		private bool _useRecentering; // 0x40
		[Range] // 0x0000000180146160-0x00000001801461C0
		[SerializeField] // 0x0000000180146160-0x00000001801461C0
		[Tooltip] // 0x0000000180146160-0x00000001801461C0
		private float _recenterSmoothingSpeed; // 0x44
		[SerializeField] // 0x0000000180146470-0x00000001801464B0
		[Tooltip] // 0x0000000180146470-0x00000001801464B0
		private bool _recenteringOnlyOnMove; // 0x48
		[Range] // 0x00000001801466D0-0x0000000180146740
		[SerializeField] // 0x00000001801466D0-0x0000000180146740
		[Tooltip] // 0x00000001801466D0-0x0000000180146740
		private float _recenteringAtVelocity; // 0x4C
		[SerializeField] // 0x0000000180146900-0x0000000180146940
		[Tooltip] // 0x0000000180146900-0x0000000180146940
		private bool _recenterReversed; // 0x50
		[Header] // 0x0000000180146BA0-0x0000000180146C10
		[SerializeField] // 0x0000000180146BA0-0x0000000180146C10
		[Tooltip] // 0x0000000180146BA0-0x0000000180146C10
		private bool _allowPanning; // 0x51
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _panSpeed; // 0x54
		[Header] // 0x0000000180147090-0x0000000180147100
		[SerializeField] // 0x0000000180147090-0x0000000180147100
		[Tooltip] // 0x0000000180147090-0x0000000180147100
		private bool _useMouseOrbiting; // 0x58
		[SerializeField] // 0x0000000180147480-0x00000001801474C0
		[Tooltip] // 0x0000000180147480-0x00000001801474C0
		private float _mouseOrbitingDistance; // 0x5C
		[SerializeField] // 0x00000001801204A0-0x00000001801204E0
		[Tooltip] // 0x00000001801204A0-0x00000001801204E0
		private Vector2 _mouseOrbitingPitchRange; // 0x60
		[SerializeField] // 0x00000001801206D0-0x0000000180120710
		[Tooltip] // 0x00000001801206D0-0x0000000180120710
		private Vector2 _mouseOrbitingSensitivity; // 0x68
		[SerializeField] // 0x0000000180127300-0x0000000180127340
		[Tooltip] // 0x0000000180127300-0x0000000180127340
		private bool _mouseOrbitingInvertY; // 0x70
		[Range] // 0x0000000180147F40-0x0000000180147FA0
		[SerializeField] // 0x0000000180147F40-0x0000000180147FA0
		[Tooltip] // 0x0000000180147F40-0x0000000180147FA0
		private float _mouseOrbitingSmoothingSpeed; // 0x74
		[Header] // 0x00000001801483A0-0x0000000180148410
		[SerializeField] // 0x00000001801483A0-0x0000000180148410
		[Tooltip] // 0x00000001801483A0-0x0000000180148410
		private bool _useMouseZooming; // 0x78
		[SerializeField] // 0x00000001801488F0-0x0000000180148930
		[Tooltip] // 0x00000001801488F0-0x0000000180148930
		private float _mouseZoomingInitialPercentage; // 0x7C
		[SerializeField] // 0x0000000180126D70-0x0000000180126DB0
		[Tooltip] // 0x0000000180126D70-0x0000000180126DB0
		private Vector2 _mouseZoomingDistance; // 0x80
		[SerializeField] // 0x0000000180148D80-0x0000000180148DC0
		[Tooltip] // 0x0000000180148D80-0x0000000180148DC0
		private Vector2 _mouseZoomingPitch; // 0x88
		[SerializeField] // 0x0000000180149050-0x0000000180149090
		[Tooltip] // 0x0000000180149050-0x0000000180149090
		private Vector3 _mouseZoomingOffsetMin; // 0x90
		[SerializeField] // 0x0000000180149050-0x0000000180149090
		[Tooltip] // 0x0000000180149050-0x0000000180149090
		private Vector3 _mouseZoomingOffsetMax; // 0x9C
		[Header] // 0x00000001801495B0-0x0000000180149620
		[SerializeField] // 0x00000001801495B0-0x0000000180149620
		[Tooltip] // 0x00000001801495B0-0x0000000180149620
		private bool _useLookAheadPitchAdjustment; // 0xA8
		[Range] // 0x0000000180149B40-0x0000000180149BA0
		[SerializeField] // 0x0000000180149B40-0x0000000180149BA0
		[Tooltip] // 0x0000000180149B40-0x0000000180149BA0
		private float _pitchAdjustmentSmoothingSpeed; // 0xAC
		[Header] // 0x0000000180149F20-0x0000000180149F90
		[SerializeField] // 0x0000000180149F20-0x0000000180149F90
		[Tooltip] // 0x0000000180149F20-0x0000000180149F90
		private bool _useCameraCollision; // 0xB0
	
		// Properties
		public float CameraFov { get; } // 0x0000000181353EA0-0x0000000181353F40 
		public Vector2 CameraClipping { get; } // 0x0000000181353D50-0x0000000181353EA0 
		public CameraModeOverride OverrideCameraMode { get; } // 0x00000001813546F0-0x0000000181354710 
		public CursorModeOverride OverrideCursorMode { get; } // 0x0000000181354710-0x0000000181354730 
		public bool UseRecentering { get; } // 0x0000000181354AE0-0x0000000181354B10 
		public float RecenterSmoothingSpeed { get; } // 0x00000001813548B0-0x0000000181354950 
		public bool RecenteringOnlyOnMove { get; } // 0x00000001813549F0-0x0000000181354A20 
		public float RecenteringAtVelocity { get; } // 0x0000000181354950-0x00000001813549F0 
		public bool RecenterReversed { get; } // 0x0000000181354880-0x00000001813548B0 
		public bool AllowPanning { get; } // 0x0000000181353D20-0x0000000181353D50 
		public float PanSpeed { get; } // 0x0000000181354730-0x00000001813547D0 
		public bool UseMouseOrbiting { get; } // 0x0000000181354A80-0x0000000181354AB0 
		public float MouseOrbitingDistance { get; } // 0x0000000181353F40-0x0000000181353FE0 
		public Vector2 MouseOrbitingPitchRange { get; } // 0x0000000181354010-0x00000001813540D0 
		public Vector2 MouseOrbitingSensitivity { get; } // 0x00000001813540D0-0x0000000181354190 
		public bool MouseOrbitingInvertY { get; } // 0x0000000181353FE0-0x0000000181354010 
		public float MouseOrbitingSmoothingSpeed { get; } // 0x0000000181354190-0x0000000181354230 
		public bool UseMouseZooming { get; } // 0x0000000181354AB0-0x0000000181354AE0 
		public float MouseZoomingInitialPercentage { get; } // 0x0000000181354300-0x00000001813543A0 
		public Vector2 MouseZoomingDistance { get; } // 0x0000000181354230-0x0000000181354300 
		public Vector2 MouseZoomingPitch { get; } // 0x0000000181354620-0x00000001813546F0 
		public Vector2 MouseZoomingOffsetMin { get; } // 0x00000001813544E0-0x0000000181354620 
		public Vector2 MouseZoomingOffsetMax { get; } // 0x00000001813543A0-0x00000001813544E0 
		public bool UseLookAheadPitchAdjustment { get; } // 0x0000000181354A50-0x0000000181354A80 
		public float PitchAdjustmentSmoothingSpeed { get; } // 0x00000001813547D0-0x0000000181354880 
		public bool UseCameraCollision { get; } // 0x0000000181354A20-0x0000000181354A50 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x00000001806A5520-0x00000001806A5530 
	
		// Nested types
		public enum CameraModeOverride // TypeDefIndex: 13909
		{
			None = 0,
			ThirdPerson = 1,
			FirstPerson = 2
		}
	
		public enum CursorModeOverride // TypeDefIndex: 13910
		{
			None = 0,
			HideCursor = 1,
			ShowCursor = 2
		}
	
		// Constructors
		public FeralCameraStateSettings(); // 0x0000000181353B20-0x0000000181353D20
		public FeralCameraStateSettings(FeralCameraStateSettings inSettings); // 0x0000000181353900-0x0000000181353B20
	
		// Methods
		public void Overwrite(FeralCameraStateSettings inSettings); // 0x00000001813537E0-0x0000000181353900
	}
}
