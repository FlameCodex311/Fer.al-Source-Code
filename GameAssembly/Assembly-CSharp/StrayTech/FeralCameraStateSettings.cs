/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[Serializable]
	public class FeralCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14575
	{
		// Fields
		[NonSerialized]
		public FeralCameraStateSettings StateSettingsOverride; // 0x10
		public float overrideBlend; // 0x18
		[Header] // 0x0000000180270820-0x0000000180270890
		[SerializeField] // 0x0000000180270820-0x0000000180270890
		[Tooltip] // 0x0000000180270820-0x0000000180270890
		private float _cameraFov; // 0x1C
		[SerializeField] // 0x0000000180270B30-0x0000000180270B70
		[Tooltip] // 0x0000000180270B30-0x0000000180270B70
		private Vector2 _cameraClippingLowQuality; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 _cameraClippingMediumQuality; // 0x28
		[FormerlySerializedAs] // 0x0000000180270E80-0x0000000180270EC0
		[SerializeField] // 0x0000000180270E80-0x0000000180270EC0
		private Vector2 _cameraClippingHighQuality; // 0x30
		[Header] // 0x0000000180270FF0-0x0000000180271060
		[SerializeField] // 0x0000000180270FF0-0x0000000180271060
		[Tooltip] // 0x0000000180270FF0-0x0000000180271060
		private CameraModeOverride _overrideCameraMode; // 0x38
		[SerializeField] // 0x0000000180271370-0x00000001802713B0
		[Tooltip] // 0x0000000180271370-0x00000001802713B0
		private CursorModeOverride _overrideCursorMode; // 0x3C
		[Header] // 0x00000001802715E0-0x0000000180271650
		[SerializeField] // 0x00000001802715E0-0x0000000180271650
		[Tooltip] // 0x00000001802715E0-0x0000000180271650
		private bool _useRecentering; // 0x40
		[Range] // 0x0000000180271870-0x00000001802718D0
		[SerializeField] // 0x0000000180271870-0x00000001802718D0
		[Tooltip] // 0x0000000180271870-0x00000001802718D0
		private float _recenterSmoothingSpeed; // 0x44
		[SerializeField] // 0x0000000180271C00-0x0000000180271C40
		[Tooltip] // 0x0000000180271C00-0x0000000180271C40
		private bool _recenteringOnlyOnMove; // 0x48
		[Range] // 0x0000000180271DC0-0x0000000180271E30
		[SerializeField] // 0x0000000180271DC0-0x0000000180271E30
		[Tooltip] // 0x0000000180271DC0-0x0000000180271E30
		private float _recenteringAtVelocity; // 0x4C
		[SerializeField] // 0x0000000180272470-0x00000001802724B0
		[Tooltip] // 0x0000000180272470-0x00000001802724B0
		private bool _recenterReversed; // 0x50
		[Header] // 0x0000000180272690-0x0000000180272700
		[SerializeField] // 0x0000000180272690-0x0000000180272700
		[Tooltip] // 0x0000000180272690-0x0000000180272700
		private bool _allowPanning; // 0x51
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _panSpeed; // 0x54
		[Header] // 0x0000000180273DC0-0x0000000180273E30
		[SerializeField] // 0x0000000180273DC0-0x0000000180273E30
		[Tooltip] // 0x0000000180273DC0-0x0000000180273E30
		private bool _useMouseOrbiting; // 0x58
		[SerializeField] // 0x0000000180274090-0x00000001802740D0
		[Tooltip] // 0x0000000180274090-0x00000001802740D0
		private float _mouseOrbitingDistance; // 0x5C
		[SerializeField] // 0x000000018024C700-0x000000018024C740
		[Tooltip] // 0x000000018024C700-0x000000018024C740
		private Vector2 _mouseOrbitingPitchRange; // 0x60
		[SerializeField] // 0x000000018024C950-0x000000018024C990
		[Tooltip] // 0x000000018024C950-0x000000018024C990
		private Vector2 _mouseOrbitingSensitivity; // 0x68
		[SerializeField] // 0x00000001802519F0-0x0000000180251A30
		[Tooltip] // 0x00000001802519F0-0x0000000180251A30
		private bool _mouseOrbitingInvertY; // 0x70
		[Range] // 0x00000001802749C0-0x0000000180274A20
		[SerializeField] // 0x00000001802749C0-0x0000000180274A20
		[Tooltip] // 0x00000001802749C0-0x0000000180274A20
		private float _mouseOrbitingSmoothingSpeed; // 0x74
		[Header] // 0x0000000180274D30-0x0000000180274DA0
		[SerializeField] // 0x0000000180274D30-0x0000000180274DA0
		[Tooltip] // 0x0000000180274D30-0x0000000180274DA0
		private bool _useMouseZooming; // 0x78
		[SerializeField] // 0x0000000180276520-0x0000000180276560
		[Tooltip] // 0x0000000180276520-0x0000000180276560
		private float _mouseZoomingInitialPercentage; // 0x7C
		[SerializeField] // 0x0000000180251050-0x0000000180251090
		[Tooltip] // 0x0000000180251050-0x0000000180251090
		private Vector2 _mouseZoomingDistance; // 0x80
		[SerializeField] // 0x0000000180276960-0x00000001802769A0
		[Tooltip] // 0x0000000180276960-0x00000001802769A0
		private Vector2 _mouseZoomingPitch; // 0x88
		[SerializeField] // 0x0000000180276E60-0x0000000180276EA0
		[Tooltip] // 0x0000000180276E60-0x0000000180276EA0
		private Vector3 _mouseZoomingOffsetMin; // 0x90
		[SerializeField] // 0x0000000180276E60-0x0000000180276EA0
		[Tooltip] // 0x0000000180276E60-0x0000000180276EA0
		private Vector3 _mouseZoomingOffsetMax; // 0x9C
		[Header] // 0x0000000180277260-0x00000001802772D0
		[SerializeField] // 0x0000000180277260-0x00000001802772D0
		[Tooltip] // 0x0000000180277260-0x00000001802772D0
		private bool _useLookAheadPitchAdjustment; // 0xA8
		[Range] // 0x00000001802776F0-0x0000000180277750
		[SerializeField] // 0x00000001802776F0-0x0000000180277750
		[Tooltip] // 0x00000001802776F0-0x0000000180277750
		private float _pitchAdjustmentSmoothingSpeed; // 0xAC
		[Header] // 0x0000000180277A70-0x0000000180277AE0
		[SerializeField] // 0x0000000180277A70-0x0000000180277AE0
		[Tooltip] // 0x0000000180277A70-0x0000000180277AE0
		private bool _useCameraCollision; // 0xB0
	
		// Properties
		public float CameraFov { get; } // 0x0000000180CB2790-0x0000000180CB2830 
		public Vector2 CameraClipping { get; } // 0x0000000180CB2640-0x0000000180CB2790 
		public CameraModeOverride OverrideCameraMode { get; } // 0x0000000180CB2FE0-0x0000000180CB3000 
		public CursorModeOverride OverrideCursorMode { get; } // 0x0000000180CB3000-0x0000000180CB3020 
		public bool UseRecentering { get; } // 0x0000000180CB33D0-0x0000000180CB3400 
		public float RecenterSmoothingSpeed { get; } // 0x0000000180CB31A0-0x0000000180CB3240 
		public bool RecenteringOnlyOnMove { get; } // 0x0000000180CB32E0-0x0000000180CB3310 
		public float RecenteringAtVelocity { get; } // 0x0000000180CB3240-0x0000000180CB32E0 
		public bool RecenterReversed { get; } // 0x0000000180CB3170-0x0000000180CB31A0 
		public bool AllowPanning { get; } // 0x0000000180CB2610-0x0000000180CB2640 
		public float PanSpeed { get; } // 0x0000000180CB3020-0x0000000180CB30C0 
		public bool UseMouseOrbiting { get; } // 0x0000000180CB3370-0x0000000180CB33A0 
		public float MouseOrbitingDistance { get; } // 0x0000000180CB2830-0x0000000180CB28D0 
		public Vector2 MouseOrbitingPitchRange { get; } // 0x0000000180CB2900-0x0000000180CB29C0 
		public Vector2 MouseOrbitingSensitivity { get; } // 0x0000000180CB29C0-0x0000000180CB2A80 
		public bool MouseOrbitingInvertY { get; } // 0x0000000180CB28D0-0x0000000180CB2900 
		public float MouseOrbitingSmoothingSpeed { get; } // 0x0000000180CB2A80-0x0000000180CB2B20 
		public bool UseMouseZooming { get; } // 0x0000000180CB33A0-0x0000000180CB33D0 
		public float MouseZoomingInitialPercentage { get; } // 0x0000000180CB2BF0-0x0000000180CB2C90 
		public Vector2 MouseZoomingDistance { get; } // 0x0000000180CB2B20-0x0000000180CB2BF0 
		public Vector2 MouseZoomingPitch { get; } // 0x0000000180CB2F10-0x0000000180CB2FE0 
		public Vector2 MouseZoomingOffsetMin { get; } // 0x0000000180CB2DD0-0x0000000180CB2F10 
		public Vector2 MouseZoomingOffsetMax { get; } // 0x0000000180CB2C90-0x0000000180CB2DD0 
		public bool UseLookAheadPitchAdjustment { get; } // 0x0000000180CB3340-0x0000000180CB3370 
		public float PitchAdjustmentSmoothingSpeed { get; } // 0x0000000180CB30C0-0x0000000180CB3170 
		public bool UseCameraCollision { get; } // 0x0000000180CB3310-0x0000000180CB3340 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018069B0C0-0x000000018069B0D0 
	
		// Nested types
		public enum CameraModeOverride // TypeDefIndex: 14576
		{
			None = 0,
			ThirdPerson = 1,
			FirstPerson = 2
		}
	
		public enum CursorModeOverride // TypeDefIndex: 14577
		{
			None = 0,
			HideCursor = 1,
			ShowCursor = 2
		}
	
		// Constructors
		public FeralCameraStateSettings(); // 0x0000000180CB2410-0x0000000180CB2610
		public FeralCameraStateSettings(FeralCameraStateSettings inSettings); // 0x0000000180CB21F0-0x0000000180CB2410
	
		// Methods
		public void Overwrite(FeralCameraStateSettings inSettings); // 0x0000000180CB20D0-0x0000000180CB21F0
	}
}
