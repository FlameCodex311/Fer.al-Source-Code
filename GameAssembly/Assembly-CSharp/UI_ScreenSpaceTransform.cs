/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ScreenSpaceTransform : ManagedBehaviour // TypeDefIndex: 12349
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected AnimationCurve _alphaByDistance; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected AnimationCurve _scaleByDistance; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _showAlways; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _ignoreCollision; // 0x61
	private VisibilityState _currentVisibilityState; // 0x64
	private float _destAlpha; // 0x68
	private float _destAlphaSpeed; // 0x6C
	private Camera _targetCamera; // 0x70
	private Transform _targetTransform; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _worldOffset; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _anchoredPositionOffset; // 0x8C
	private RectTransform _rectTransform; // 0x98
	private UI_ScreenSpaceTransformCanvas _parentCanvas; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0xA8
	protected float _lastDistance; // 0xB0
	private RaycastHit[] _visibilityHitsNoAlloc; // 0xB8

	// Properties
	public bool ShowAlways { get; set; } // 0x00000001804785B0-0x00000001804785C0 0x000000018062BA40-0x000000018062BA50
	public bool IgnoreCollision { get; set; } // 0x0000000180478640-0x0000000180478650 0x000000018042EE00-0x000000018042EE10
	public VisibilityState CurrentVisibilityState { get; set; } // 0x00000001804D0650-0x00000001804D0660 0x0000000180EF1870-0x0000000180EF1890
	public float DestAlpha { get; set; } // 0x0000000180487D00-0x0000000180487D10 0x0000000180EF18A0-0x0000000180EF18B0
	public float DestAlphaSpeed { get; set; } // 0x0000000180EF1650-0x0000000180EF1660 0x0000000180EF1890-0x0000000180EF18A0
	public Camera TargetCamera { get; set; } // 0x0000000180EF17A0-0x0000000180EF1850 0x00000001803C87F0-0x00000001803C8800
	public Transform TargetTransform { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
	public Vector3 WorldOffset { get; set; } // 0x0000000180EF1850-0x0000000180EF1870 0x0000000180EF18B0-0x0000000180EF18D0
	public RectTransform RectTransform { get; } // 0x0000000180EF16F0-0x0000000180EF17A0 
	public UI_ScreenSpaceTransformCanvas ParentCanvas { get; } // 0x0000000180EF1660-0x0000000180EF16F0 
	public CanvasGroup CanvasGroup { get; } // 0x0000000180EF1560-0x0000000180EF1650 

	// Nested types
	public enum VisibilityState // TypeDefIndex: 12350
	{
		Off = 0,
		HiddenFromDistance = 1,
		HiddenFromDirection = 2,
		HiddenFromGeometry = 3,
		Visible = 4
	}

	// Constructors
	public UI_ScreenSpaceTransform(); // 0x0000000180EF1230-0x0000000180EF1560

	// Methods
	public override void MOnEnable(); // 0x0000000180EF0280-0x0000000180EF0470
	public override void MOnDisable(); // 0x0000000180EF0210-0x0000000180EF0280
	protected virtual void UpdateVisibilityAndAlpha(); // 0x0000000180EF0CC0-0x0000000180EF1230
	protected virtual void OnDistanceFromCameraChanged(float inDistance); // 0x0000000180EF0470-0x0000000180EF05B0
	protected Transform RaycastToCameraHitSomething(); // 0x0000000180EF05B0-0x0000000180EF08E0
	private void UpdatePosition(); // 0x0000000180EF0A60-0x0000000180EF0CC0
	public virtual void SSTUpdate(); // 0x0000000180EF08E0-0x0000000180EF0A60
}

