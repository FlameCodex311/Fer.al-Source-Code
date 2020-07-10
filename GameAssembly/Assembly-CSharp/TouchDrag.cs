/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TouchDrag : MonoBehaviour // TypeDefIndex: 12931
{
	// Fields
	public IngredientWheel wheel; // 0x20
	public Camera raycastCamera; // 0x28
	public float rotateSpeed; // 0x30
	public float snapSpeed; // 0x34
	public float clickTimeThreshold; // 0x38
	public float clickDragThreshold; // 0x3C
	public float clickCenterRadius; // 0x40
	private Plane _touchPlane; // 0x44
	private Rigidbody _connectedBody; // 0x58
	private Rigidbody _dragBody; // 0x60
	private Quaternion _startRotation; // 0x68
	private Quaternion _offsetRotation; // 0x78
	private bool _holding; // 0x88
	private float _holdingTimer; // 0x8C
	private Vector3 _initialTouchWorldPos; // 0x90
	private Vector3 _currentTouchWorldPos; // 0x9C
	private Vector3 _currentTouchPos; // 0xA8
	private float _targetSnapAngle; // 0xB4
	private float _snapAngle; // 0xB8
	private int _pausedCount; // 0xBC

	// Properties
	private bool Paused { get; } // 0x0000000180FA45D0-0x0000000180FA45E0 

	// Constructors
	public TouchDrag(); // 0x0000000180FA45A0-0x0000000180FA45D0

	// Methods
	private void Start(); // 0x0000000180FA38F0-0x0000000180FA3A40
	private void OnDestroy(); // 0x0000000180FA3730-0x0000000180FA37C0
	private void Update(); // 0x0000000180FA3CF0-0x0000000180FA45A0
	private void FixedUpdate(); // 0x0000000180FA30D0-0x0000000180FA3600
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x0000000180FA37C0-0x0000000180FA3860
	public bool Touching(out Vector3 projectedPoint, out Vector3 worldPoint); // 0x0000000180FA3A40-0x0000000180FA3CF0
	public void SetSnapAngle(int inBinCount); // 0x0000000180FA3860-0x0000000180FA38F0
	private float GetNearestSnapAngle(float inAngle); // 0x0000000180FA3600-0x0000000180FA3730
}

