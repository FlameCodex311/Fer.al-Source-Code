/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralCamera : ICameraState // TypeDefIndex: 11457
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 <Position>k__BackingField; // 0x1C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
	public float OrbitDistance { get; } // 0x000000018069AFE0-0x000000018069B040 
	private static float CurrentLookAheadPitch { get; } // 0x000000018069A7F0-0x000000018069A8C0 
	private static float CurrentZoomPitch { get; } // 0x000000018069A8C0-0x000000018069AA70 
	public ICameraStateSettings StateSettings { get; } // 0x000000018069B060-0x000000018069B0C0 
	public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018069B0C0-0x000000018069B0D0 
	public bool AllowsModifiers { get; } // 0x0000000180380B60-0x0000000180380B70 
	public Vector3 Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018069B040-0x000000018069B060 0x000000018069B2C0-0x000000018069B2D0
	public Quaternion Rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379E90-0x0000000180379EA0 0x000000018041B740-0x000000018041B750
	public static bool MouseOrbitingActive { get; set; } // 0x000000018069AEE0-0x000000018069AF40 0x000000018069B260-0x000000018069B2C0
	public static bool FirstPersonModeOrForced { get; } // 0x000000018069AB60-0x000000018069ABE0 
	public static bool FirstPersonModeOrForcedAndDoneTransitioning { get; } // 0x000000018069AAD0-0x000000018069AB60 
	public static bool ForceThirdPersonMode { get; } // 0x000000018069ADB0-0x000000018069AEE0 
	public static bool ForceFirstPersonMode { get; } // 0x0000000180380950-0x0000000180380960 
	private static bool ForceCursorMode { get; } // 0x000000018069ABE0-0x000000018069ADB0 
	public static bool ThirdPersonCursorMode { get; set; } // 0x000000018069B0D0-0x000000018069B130 0x000000018069B2D0-0x000000018069B390
	public static bool FirstPersonCursorMode { get; set; } // 0x000000018069AA70-0x000000018069AAD0 0x000000018069B1A0-0x000000018069B260
	public static CameraMode CurrentCameraMode { get; } // 0x0000000180699E10-0x000000018069A7F0 
	private bool AllowPanning { get; } // 0x0000000180699DA0-0x0000000180699E10 
	private bool UseMouseZooming { get; } // 0x000000018069B130-0x000000018069B1A0 
	private float MouseOrbitingDistance { get; } // 0x000000018069AF40-0x000000018069AFE0 

	// Nested types
	public enum CameraMode // TypeDefIndex: 11458
	{
		None = 0,
		ThirdPersonNoCursor = 1,
		ThirdPersonCursor = 2,
		FirstPersonNoCursor = 3,
		FirstPersonCursor = 4
	}

	// Constructors
	public FeralCamera(ICameraStateSettings stateSettings); // 0x0000000180699A70-0x0000000180699DA0
	static FeralCamera(); // 0x0000000180699760-0x0000000180699A70

	// Methods
	public void Cleanup(); // 0x00000001803774A0-0x00000001803774B0
	public void SnapToCenter(); // 0x0000000180697100-0x00000001806972F0
	public static void ForceSnapRecenter(); // 0x0000000180696040-0x00000001806960A0
	public static bool GetMousePanningButton(bool inDown, bool inRejectOverUI); // 0x0000000180696300-0x00000001806965A0
	public static bool GetMouseOrbitingButton(bool inDown, bool inRejectOverUI); // 0x00000001806960A0-0x0000000180696300
	public static float ClampAngle(float angle, float min, float max); // 0x0000000180695FA0-0x0000000180696040
	public static float LookAheadAdjustment(); // 0x00000001806965A0-0x0000000180697100
	public void UpdateCamera(float deltaTime); // 0x00000001806972F0-0x0000000180698B60
	private void UpdateMouseOrbit(); // 0x0000000180698E30-0x00000001806992B0
	private bool UpdateKeyboardOrbit(); // 0x0000000180698B60-0x0000000180698E30
	private bool UpdateMousePanning(); // 0x00000001806992B0-0x0000000180699760
}

