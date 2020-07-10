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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PlayerCamera : ManagedBehaviour // TypeDefIndex: 11468
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static PlayerCamera <instance>k__BackingField; // 0x00
	[Header] // 0x00000001800BD610-0x00000001800BD660
	[SerializeField] // 0x00000001800BD610-0x00000001800BD660
	private Camera _camera; // 0x50
	[EnumList] // 0x00000001800BD830-0x00000001800BD8A0
	[SerializeField] // 0x00000001800BD830-0x00000001800BD8A0
	private List<CinemachineVirtualCameraBase> virtualCameras; // 0x58
	[EnumList] // 0x00000001800BDB60-0x00000001800BDBD0
	[SerializeField] // 0x00000001800BDB60-0x00000001800BDBD0
	private List<CameraStateDefinition> cameraStates; // 0x60
	[Header] // 0x00000001800BDEE0-0x00000001800BDF10
	public Transform targetPlayerTransform; // 0x68
	public Transform targetPlayerCameraPositionTransform; // 0x70
	private Transform _targetTransform; // 0x78
	[Header] // 0x00000001800BF2D0-0x00000001800BF320
	[SerializeField] // 0x00000001800BF2D0-0x00000001800BF320
	private ScreenShotHandler _screenShotHandler; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<CameraStateModifierBase> _selfieCameraModifiers; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _selfieTargetTransform; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Camera _selfieCam; // 0x98
	private bool _inSelfieMode; // 0xA0
	private Transform _savedCameraTarget; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RuntimePlatform[] _disabledPostProcessOnPlatforms; // 0xB0
	[SerializeField] // 0x00000001800BFD50-0x00000001800BFD90
	[Space] // 0x00000001800BFD50-0x00000001800BFD90
	private CameraSystem _cachedCameraSystem; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CinemachineBrain _cachedBrain; // 0xC0
	[PropertyBackingField] // 0x00000001800C0110-0x00000001800C0150
	[SerializeField] // 0x00000001800C0110-0x00000001800C0150
	private PlayerCameraMode _mode; // 0xC8

	// Properties
	public static PlayerCamera instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018115BB10-0x000000018115BB50 0x000000018115BC60-0x000000018115BCA0
	public Camera CachedCamera { get; } // 0x000000018115BA90-0x000000018115BB10 
	public Transform targetTransform { get; set; } // 0x000000018115BB50-0x000000018115BBF0 0x000000018115BCA0-0x000000018115BD20
	public Camera SelfieCam { get; } // 0x0000000180369B70-0x0000000180369B80 
	public CameraSystem CachedCameraSystem { get; } // 0x000000018115BA00-0x000000018115BA90 
	public CinemachineBrain CachedBrain { get; } // 0x000000018115B970-0x000000018115BA00 
	public PlayerCameraMode Mode { get; set; } // 0x0000000180424140-0x0000000180424150 0x000000018115BBF0-0x000000018115BC60

	// Constructors
	public PlayerCamera(); // 0x000000018115B910-0x000000018115B970

	// Methods
	private void OnSanctuaryCameraMessage(SanctuaryCameraMessage inMessage); // 0x000000018115B0D0-0x000000018115B110
	private void OnPlayerCameraMessage(PlayerCameraMessage inMessage); // 0x000000018115B050-0x000000018115B0D0
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 n); // 0x000000018115B4E0-0x000000018115B630
	public void UpdateTargetPlayerTransform(); // 0x000000018115B7B0-0x000000018115B910
	public void EnableSelfieMode(); // 0x000000018115A850-0x000000018115AAC0
	public void DisableSelfieMode(); // 0x000000018115A660-0x000000018115A850
	public void TakeSelfie(Action<Texture2D> inCallback); // 0x000000018115B6A0-0x000000018115B7B0
	public void SetSelfieModeFov(float inFov); // 0x000000018115B2F0-0x000000018115B4E0
	public void ResetSeflieTargetPosition(); // 0x000000018115B110-0x000000018115B2F0
	public override void MAwake(); // 0x000000018115AD50-0x000000018115AF40
	public override void MOnDestroy(); // 0x000000018115AF40-0x000000018115B050
	public void LateUpdate(); // 0x000000018115AAC0-0x000000018115AD50
	private void SwitchedModes(); // 0x000000018115B630-0x000000018115B6A0
	public void ActivateVirtualCameraOrState(PlayerCameraMode inMode); // 0x000000018115A270-0x000000018115A4B0
	public void DeactivateAllVirtualCamerasAndStates(); // 0x000000018115A4B0-0x000000018115A660
	public T GetVirtualCameraByMode<T>(PlayerCameraMode inMode)
		where T : CinemachineVirtualCameraBase;
}

