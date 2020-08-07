/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryCamera : ManagedBehaviour // TypeDefIndex: 13286
{
	// Fields
	[Header] // 0x00000001801EC790-0x00000001801EC7E0
	[SerializeField] // 0x00000001801EC790-0x00000001801EC7E0
	private Transform _cameraLocator; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _cameraRotator; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CinemachineVirtualCamera _virtualCamera; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CameraInfo _outdoorCamera; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CameraInfo _indoorCamera; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CameraInfo _greenhouseOutdoorCamera; // 0x78
	private CameraInfo _currentCamera; // 0x80
	private static float _defaultZoom; // 0x00
	private float _desiredZoom; // 0x88
	private Vector3 _initialRotation; // 0x8C
	private Vector3 _desiredRotation; // 0x98
	private Vector3 _initialPosition; // 0xA4
	private Vector3 _desiredPosition; // 0xB0
	private Vector3 _indoorPosition; // 0xBC
	private Vector3 _initialRotationMessage; // 0xC8
	private bool _flipRotation; // 0xD4
	private bool _override; // 0xD5
	private SanctuaryController.EState _priorState; // 0xD8

	// Properties
	public Vector3 DesiredRotation { get; } // 0x000000018045BE90-0x000000018045BEB0 
	private bool _indoors { get; } // 0x000000018045BEB0-0x000000018045BFB0 
	public float zoomPercentage { get; } // 0x000000018045BFB0-0x000000018045BFF0 

	// Nested types
	[Serializable]
	public class CameraInfo // TypeDefIndex: 13287
	{
		// Fields
		[Header] // 0x00000001801ED1B0-0x00000001801ED1E0
		public float minZoom; // 0x10
		public float maxZoom; // 0x14
		public float zoomAmount; // 0x18
		[Header] // 0x00000001801ED410-0x00000001801ED440
		public bool allowCameraZ; // 0x1C
		public float minPositionX; // 0x20
		public float maxPositionX; // 0x24
		public float minPositionZ; // 0x28
		public float maxPositionZ; // 0x2C
		[Header] // 0x00000001801ED5B0-0x00000001801ED5E0
		public float moveSpeed; // 0x30
		public float rotationSpeed; // 0x34
		public float zoomSpeed; // 0x38
		[Header] // 0x00000001801ED7A0-0x00000001801ED7D0
		public float mouseWheelMultiplier; // 0x3C
		public float mousePositionMultiplier; // 0x40
		public float mouseRotationMultiplier; // 0x44
		[Header] // 0x00000001801ED910-0x00000001801ED940
		public float minPitch; // 0x48
		public float maxPitch; // 0x4C

		// Constructors
		public CameraInfo(); // 0x00000001804556E0-0x0000000180455760
	}

	// Constructors
	public SanctuaryCamera(); // 0x000000018045BCB0-0x000000018045BE90
	static SanctuaryCamera(); // 0x000000018045BC70-0x000000018045BCB0

	// Methods
	public override void MStart(); // 0x000000018045A920-0x000000018045AB60
	private void UpdateCameraInfo(); // 0x00000001803774A0-0x00000001803774B0
	public void EnableSanctuaryCamera(bool inActive); // 0x000000018045A4A0-0x000000018045A4C0
	public override void MUpdate(); // 0x000000018045AB60-0x000000018045ADE0
	private void LateUpdate(); // 0x000000018045A700-0x000000018045A790
	private void OnSanctuaryGreenhouseCameraPositionMessage(SanctuaryGreenhouseCameraPositionMessage inMessage); // 0x000000018045B370-0x000000018045B3A0
	private void OnSanctuaryGreenhouseCameraRotationMessage(SanctuaryGreenhouseCameraRotationMessage inMessage); // 0x000000018045B3A0-0x000000018045B3D0
	public void OnSanctuaryPositionMessage(SanctuaryPositionMessage inMessage); // 0x000000018045B430-0x000000018045B6C0
	public void OnSanctuaryInitialRotationMessage(SanctuaryInitialRotationMessage inMessage); // 0x000000018045B3D0-0x000000018045B430
	public void OnSanctuaryRotationMessage(SanctuaryRotationMessage inMessage); // 0x000000018045B6C0-0x000000018045B930
	public override void MOnDestroy(); // 0x000000018045A790-0x000000018045A920
	public void ZoomIn(); // 0x000000018045BBA0-0x000000018045BBD0
	public void ZoomOut(); // 0x000000018045BBD0-0x000000018045BC00
	public void ResetPosition(); // 0x000000018045B9C0-0x000000018045BA30
	public void ResetRotation(); // 0x000000018045BA30-0x000000018045BAA0
	public void Rotate(); // 0x00000001803774A0-0x00000001803774B0
	public void GoToInterior(); // 0x000000018045A630-0x000000018045A700
	public void GoToExterior(); // 0x000000018045A530-0x000000018045A630
	private void MoveAndRotate(); // 0x000000018045ADE0-0x000000018045B370
	public void ClearOverride(); // 0x000000018045A480-0x000000018045A4A0
	public void OverridePositionAndRotation(Vector3 inPosition, Vector3 inRotation); // 0x000000018045B930-0x000000018045B9C0
	private void Zoom(); // 0x000000018045BC00-0x000000018045BC70
	private void ZoomCamera(float inZoomAmount); // 0x000000018045BAA0-0x000000018045BBA0
	public void FocusOnRoom(SanctuaryIndoorRoom inRoom); // 0x000000018045A4C0-0x000000018045A530
}

