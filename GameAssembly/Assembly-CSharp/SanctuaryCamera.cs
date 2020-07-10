/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryCamera : ManagedBehaviour // TypeDefIndex: 11751
{
	// Fields
	[Header] // 0x000000018010C7F0-0x000000018010C840
	[SerializeField] // 0x000000018010C7F0-0x000000018010C840
	private Transform _cameraLocator; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _cameraRotator; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CinemachineVirtualCamera _virtualCamera; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CameraInfo _outdoorCamera; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CameraInfo _indoorCamera; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CameraInfo _greenhouseCamera; // 0x78
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
	public Vector3 DesiredRotation { get; } // 0x0000000180E1E4B0-0x0000000180E1E4D0 
	private bool _greenhouse { get; } // 0x0000000180E1E4D0-0x0000000180E1E510 
	private bool _indoors { get; } // 0x0000000180E1E510-0x0000000180E1E610 
	public float zoomPercentage { get; } // 0x0000000180E1E610-0x0000000180E1E650 

	// Nested types
	[Serializable]
	public class CameraInfo // TypeDefIndex: 11752
	{
		// Fields
		[Header] // 0x000000018010CC10-0x000000018010CC40
		public float minZoom; // 0x10
		public float maxZoom; // 0x14
		public float zoomAmount; // 0x18
		[Header] // 0x000000018010CD30-0x000000018010CD60
		public bool allowCameraZ; // 0x1C
		public float minPositionX; // 0x20
		public float maxPositionX; // 0x24
		public float minPositionZ; // 0x28
		public float maxPositionZ; // 0x2C
		[Header] // 0x000000018010CD90-0x000000018010CDC0
		public float moveSpeed; // 0x30
		public float rotationSpeed; // 0x34
		public float zoomSpeed; // 0x38
		[Header] // 0x000000018010CF00-0x000000018010CF30
		public float mouseWheelMultiplier; // 0x3C
		public float mousePositionMultiplier; // 0x40
		public float mouseRotationMultiplier; // 0x44
		[Header] // 0x000000018010CFC0-0x000000018010CFF0
		public float minPitch; // 0x48
		public float maxPitch; // 0x4C

		// Constructors
		public CameraInfo(); // 0x0000000180E069C0-0x0000000180E06A40
	}

	// Constructors
	public SanctuaryCamera(); // 0x0000000180E1E2D0-0x0000000180E1E4B0
	static SanctuaryCamera(); // 0x0000000180E1E290-0x0000000180E1E2D0

	// Methods
	public override void MStart(); // 0x0000000180E1CE30-0x0000000180E1D080
	private void UpdateCameraInfo(); // 0x00000001803581E0-0x00000001803581F0
	public override void MUpdate(); // 0x0000000180E1D080-0x0000000180E1D3F0
	private void LateUpdate(); // 0x0000000180E1CC10-0x0000000180E1CCA0
	private void OnSanctuaryGreenhouseCameraPositionMessage(SanctuaryGreenhouseCameraPositionMessage inMessage); // 0x0000000180E1D9D0-0x0000000180E1DA00
	private void OnSanctuaryGreenhouseCameraRotationMessage(SanctuaryGreenhouseCameraRotationMessage inMessage); // 0x0000000180E1DA00-0x0000000180E1DA30
	public void OnSanctuaryPositionMessage(SanctuaryPositionMessage inMessage); // 0x0000000180E1DA90-0x0000000180E1DD30
	public void OnSanctuaryInitialRotationMessage(SanctuaryInitialRotationMessage inMessage); // 0x0000000180E1DA30-0x0000000180E1DA90
	public void OnSanctuaryRotationMessage(SanctuaryRotationMessage inMessage); // 0x0000000180E1DD30-0x0000000180E1DF50
	public override void MOnDestroy(); // 0x0000000180E1CCA0-0x0000000180E1CE30
	public void ZoomIn(); // 0x0000000180E1E1C0-0x0000000180E1E1F0
	public void ZoomOut(); // 0x0000000180E1E1F0-0x0000000180E1E220
	public void ResetPosition(); // 0x0000000180E1DFE0-0x0000000180E1E050
	public void ResetRotation(); // 0x0000000180E1E050-0x0000000180E1E0C0
	public void Rotate(); // 0x00000001803581E0-0x00000001803581F0
	public void GoToInterior(); // 0x0000000180E1CB40-0x0000000180E1CC10
	public void GoToExterior(); // 0x0000000180E1CA30-0x0000000180E1CB40
	private void MoveAndRotate(); // 0x0000000180E1D3F0-0x0000000180E1D9D0
	public void ClearOverride(); // 0x0000000180E1C9A0-0x0000000180E1C9C0
	public void OverridePositionAndRotation(Vector3 inPosition, Vector3 inRotation); // 0x0000000180E1DF50-0x0000000180E1DFE0
	private void Zoom(); // 0x0000000180E1E220-0x0000000180E1E290
	private void ZoomCamera(float inZoomAmount); // 0x0000000180E1E0C0-0x0000000180E1E1C0
	public void FocusOnRoom(SanctuaryIndoorRoom inRoom); // 0x0000000180E1C9C0-0x0000000180E1CA30
}

