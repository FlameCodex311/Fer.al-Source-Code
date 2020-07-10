/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralCamera : ICameraState // TypeDefIndex: 13784
{
	// Fields
	private static FeralCameraStateSettings _stateSettings; // 0x00
	private Transform _cameraLookAtTransform; // 0x10
	private static float _orbitDistance; // 0x08
	private float _mouseZoomingValue; // 0x18
	private static float _lastFeralCameraMouseZoomingValue; // 0x0C
	private static float _initialOrbitGetAxisMouseX; // 0x10
	private static float _initialOrbitGetAxisMouseY; // 0x14
	private static Quaternion _currentOrbitRotation; // 0x18
	private static float _mouseOrbitingX; // 0x28
	private static float _mouseOrbitingY; // 0x2C
	private static float _mouseOrbitingDestX; // 0x30
	private static float _mouseOrbitingDestY; // 0x34
	private static bool _mouseOrbitingFirstInputX; // 0x38
	private static bool _mouseOrbitingFirstInputY; // 0x39
	private static bool _forceSnapRecenter; // 0x3A
	private static float _zoomPitch; // 0x3C
	private static float _lookAheadDistance; // 0x40
	private static int _lookAheadSamples; // 0x44
	private static float _lookAheadPitch; // 0x48
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 <Position>k__BackingField; // 0x1C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Quaternion <Rotation>k__BackingField; // 0x28
	private static int _mouseOrbitingActiveFrames; // 0x4C
	private static bool _mouseOrbitingActive; // 0x50
	private static bool _thirdPersonCursorMode; // 0x51
	private static bool _firstPersonCursorMode; // 0x52
	private static Dictionary<ValueTuple<bool, bool>, CameraMode> _cameraModeDict; // 0x58
	private static CameraMode _lastCameraMode; // 0x60
	private static List<Ray> _rays; // 0x68
	private static List<RaycastHit?> _hits; // 0x70

	// Properties
	public float OrbitDistance { get; } // 0x0000000181105730-0x0000000181105790 
	private static float CurrentLookAheadPitch { get; } // 0x0000000181104F40-0x0000000181105010 
	private static float CurrentZoomPitch { get; } // 0x0000000181105010-0x00000001811051C0 
	public ICameraStateSettings StateSettings { get; } // 0x00000001811057B0-0x0000000181105810 
	public CameraSystem.CameraStateEnum StateType { get; } // 0x00000001806A5520-0x00000001806A5530 
	public bool AllowsModifiers { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	public Vector3 Position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181105790-0x00000001811057B0 0x0000000181105A00-0x0000000181105A10
	public Quaternion Rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036CB50-0x000000018036CB60 0x000000018036CC20-0x000000018036CC30
	public static bool MouseOrbitingActive { get; set; } // 0x0000000181105630-0x0000000181105690 0x00000001811059A0-0x0000000181105A00
	public static bool FirstPersonModeOrForced { get; } // 0x00000001811052B0-0x0000000181105330 
	public static bool FirstPersonModeOrForcedAndDoneTransitioning { get; } // 0x0000000181105220-0x00000001811052B0 
	public static bool ForceThirdPersonMode { get; } // 0x0000000181105500-0x0000000181105630 
	public static bool ForceFirstPersonMode { get; } // 0x00000001803C28F0-0x00000001803C2900 
	private static bool ForceCursorMode { get; } // 0x0000000181105330-0x0000000181105500 
	public static bool ThirdPersonCursorMode { get; set; } // 0x0000000181105810-0x0000000181105870 0x0000000181105A10-0x0000000181105AD0
	public static bool FirstPersonCursorMode { get; set; } // 0x00000001811051C0-0x0000000181105220 0x00000001811058E0-0x00000001811059A0
	public static CameraMode CurrentCameraMode { get; } // 0x0000000181104560-0x0000000181104F40 
	private bool AllowPanning { get; } // 0x00000001811044F0-0x0000000181104560 
	private bool UseMouseZooming { get; } // 0x0000000181105870-0x00000001811058E0 
	private float MouseOrbitingDistance { get; } // 0x0000000181105690-0x0000000181105730 

	// Nested types
	public enum CameraMode // TypeDefIndex: 13785
	{
		None = 0,
		ThirdPersonNoCursor = 1,
		ThirdPersonCursor = 2,
		FirstPersonNoCursor = 3,
		FirstPersonCursor = 4
	}

	// Constructors
	public FeralCamera(ICameraStateSettings stateSettings); // 0x00000001811041B0-0x00000001811044F0
	static FeralCamera(); // 0x0000000181103EA0-0x00000001811041B0

	// Methods
	public void Cleanup(); // 0x00000001803581E0-0x00000001803581F0
	public void SnapToCenter(); // 0x00000001811019E0-0x0000000181101BD0
	public static void ForceSnapRecenter(); // 0x0000000181100900-0x0000000181100960
	public static bool GetMousePanningButton(bool inDown, bool inRejectOverUI); // 0x0000000181100BC0-0x0000000181100E60
	public static bool GetMouseOrbitingButton(bool inDown, bool inRejectOverUI); // 0x0000000181100960-0x0000000181100BC0
	public static float ClampAngle(float angle, float min, float max); // 0x0000000181100860-0x0000000181100900
	public static float LookAheadAdjustment(); // 0x0000000181100E60-0x00000001811019E0
	public void UpdateCamera(float deltaTime); // 0x0000000181101BD0-0x0000000181103370
	private void UpdateMouseOrbit(); // 0x0000000181103640-0x00000001811039E0
	private bool UpdateKeyboardOrbit(); // 0x0000000181103370-0x0000000181103640
	private bool UpdateMousePanning(); // 0x00000001811039E0-0x0000000181103EA0
}

