/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Candlelight;
using Cinemachine;
using StrayTech;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PlayerCamera : ManagedBehaviour // TypeDefIndex: 12989
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static PlayerCamera <instance>k__BackingField; // 0x00
	[Header] // 0x000000018025CD70-0x000000018025CDC0
	[SerializeField] // 0x000000018025CD70-0x000000018025CDC0
	private Camera _camera; // 0x50
	[EnumList] // 0x000000018025CFC0-0x000000018025D030
	[SerializeField] // 0x000000018025CFC0-0x000000018025D030
	private List<CinemachineVirtualCameraBase> virtualCameras; // 0x58
	[EnumList] // 0x000000018025D220-0x000000018025D290
	[SerializeField] // 0x000000018025D220-0x000000018025D290
	private List<CameraStateDefinition> cameraStates; // 0x60
	[Header] // 0x000000018025D4B0-0x000000018025D4E0
	public Transform targetPlayerTransform; // 0x68
	public Transform targetPlayerCameraPositionTransform; // 0x70
	private Transform _targetTransform; // 0x78
	[Header] // 0x000000018025D5E0-0x000000018025D630
	[SerializeField] // 0x000000018025D5E0-0x000000018025D630
	private ScreenShotHandler _screenShotHandler; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<CameraStateModifierBase> _selfieCameraModifiers; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _selfieTargetTransform; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Camera _selfieCam; // 0x98
	private bool _inSelfieMode; // 0xA0
	private Transform _savedCameraTarget; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RuntimePlatform[] _disabledPostProcessOnPlatforms; // 0xB0
	[SerializeField] // 0x000000018025DC70-0x000000018025DCB0
	[Space] // 0x000000018025DC70-0x000000018025DCB0
	private CameraSystem _cachedCameraSystem; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CinemachineBrain _cachedBrain; // 0xC0
	[PropertyBackingField] // 0x000000018025DF10-0x000000018025DF50
	[SerializeField] // 0x000000018025DF10-0x000000018025DF50
	private PlayerCameraMode _mode; // 0xC8

	// Properties
	public static PlayerCamera instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804E4DE0-0x00000001804E4E20 0x00000001804E4F30-0x00000001804E4F70
	public Camera CachedCamera { get; } // 0x00000001804E4D50-0x00000001804E4DD0 
	public Transform targetTransform { get; set; } // 0x00000001804E4E20-0x00000001804E4EC0 0x00000001804E4F70-0x00000001804E4FF0
	public Camera SelfieCam { get; } // 0x0000000180418990-0x00000001804189A0 
	public bool SelfieModeActive { get; } // 0x0000000180418A20-0x0000000180418A30 
	public CameraSystem CachedCameraSystem { get; } // 0x00000001804E4CC0-0x00000001804E4D50 
	public CinemachineBrain CachedBrain { get; } // 0x00000001804E4C30-0x00000001804E4CC0 
	public PlayerCameraMode Mode { get; set; } // 0x00000001804E4DD0-0x00000001804E4DE0 0x00000001804E4EC0-0x00000001804E4F30

	// Constructors
	public PlayerCamera(); // 0x00000001804E4BD0-0x00000001804E4C30

	// Methods
	private void OnSanctuaryCameraMessage(SanctuaryCameraMessage inMessage); // 0x00000001804E43B0-0x00000001804E43F0
	private void OnPlayerCameraMessage(PlayerCameraMessage inMessage); // 0x00000001804E4330-0x00000001804E43B0
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n); // 0x00000001804E47B0-0x00000001804E4900
	public void UpdateTargetPlayerTransform(); // 0x00000001804E4A80-0x00000001804E4BD0
	public void EnableSelfieMode(); // 0x00000001804E3AA0-0x00000001804E3D00
	public void DisableSelfieMode(); // 0x00000001804E38B0-0x00000001804E3AA0
	public void TakeSelfie(Action<Texture2D> inCallback); // 0x00000001804E4970-0x00000001804E4A80
	public void SetSelfieModeFov(float inFov); // 0x00000001804E45C0-0x00000001804E47B0
	public void ResetSeflieTargetPosition(); // 0x00000001804E43F0-0x00000001804E45C0
	public override void MAwake(); // 0x00000001804E4010-0x00000001804E4220
	public override void MOnDestroy(); // 0x00000001804E4220-0x00000001804E4330
	public void LateUpdate(); // 0x00000001804E3D90-0x00000001804E4010
	private void SwitchedModes(); // 0x00000001804E4900-0x00000001804E4970
	public void ActivateVirtualCameraOrState(PlayerCameraMode inMode); // 0x00000001804E34D0-0x00000001804E3700
	public void DeactivateAllVirtualCamerasAndStates(); // 0x00000001804E3700-0x00000001804E38B0
	public CameraStateDefinition GetCameraStateByMode(PlayerCameraMode inMode); // 0x00000001804E3D00-0x00000001804E3D90
	public T GetVirtualCameraByMode<T>(PlayerCameraMode inMode)
		where T : CinemachineVirtualCameraBase;
}

