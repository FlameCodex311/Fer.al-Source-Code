/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ScreenSpaceTransform : ManagedBehaviour // TypeDefIndex: 13933
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected AnimationCurve _alphaByDistance; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected AnimationCurve _scaleByDistance; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _showAlways; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _ignoreCollision; // 0x61
	private VisibilityState _currentVisibilityState; // 0x64
	private float _destAlpha; // 0x68
	private float _destAlphaSpeed; // 0x6C
	private Camera _targetCamera; // 0x70
	private Transform _targetTransform; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _worldOffset; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _anchoredPositionOffset; // 0x8C
	private RectTransform _rectTransform; // 0x98
	private UI_ScreenSpaceTransformCanvas _parentCanvas; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0xA8
	protected float _lastDistance; // 0xB0
	private RaycastHit[] _visibilityHitsNoAlloc; // 0xB8

	// Properties
	public bool ShowAlways { get; set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018045A0C0-0x000000018045A0D0
	public bool IgnoreCollision { get; set; } // 0x0000000180459DB0-0x0000000180459DC0 0x000000018045A0B0-0x000000018045A0C0
	public VisibilityState CurrentVisibilityState { get; set; } // 0x00000001804C5F20-0x00000001804C5F30 0x00000001804C6160-0x00000001804C6180
	public float DestAlpha { get; set; } // 0x00000001804C5F40-0x00000001804C5F50 0x00000001804C6190-0x00000001804C61A0
	public float DestAlphaSpeed { get; set; } // 0x00000001804C5F30-0x00000001804C5F40 0x00000001804C6180-0x00000001804C6190
	public Camera TargetCamera { get; set; } // 0x00000001804C6090-0x00000001804C6140 0x00000001804C61A0-0x00000001804C61B0
	public Transform TargetTransform { get; set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
	public Vector3 WorldOffset { get; set; } // 0x00000001804C6140-0x00000001804C6160 0x00000001804C61B0-0x00000001804C61D0
	public RectTransform RectTransform { get; } // 0x00000001804C5FE0-0x00000001804C6090 
	public UI_ScreenSpaceTransformCanvas ParentCanvas { get; } // 0x00000001804C5F50-0x00000001804C5FE0 
	public CanvasGroup CanvasGroup { get; } // 0x00000001804C5E30-0x00000001804C5F20 

	// Nested types
	public enum VisibilityState // TypeDefIndex: 13934
	{
		Off = 0,
		HiddenFromDistance = 1,
		HiddenFromDirection = 2,
		HiddenFromGeometry = 3,
		Visible = 4
	}

	// Constructors
	public UI_ScreenSpaceTransform(); // 0x00000001804C5B10-0x00000001804C5E30

	// Methods
	public override void MOnEnable(); // 0x00000001804C4BC0-0x00000001804C4DA0
	public override void MOnDisable(); // 0x00000001804C4B50-0x00000001804C4BC0
	protected virtual void UpdateVisibilityAndAlpha(); // 0x00000001804C55C0-0x00000001804C5B10
	protected virtual void OnDistanceFromCameraChanged(float inDistance); // 0x00000001804C4DA0-0x00000001804C4EE0
	protected Transform RaycastToCameraHitSomething(); // 0x00000001804C4EE0-0x00000001804C5200
	private void UpdatePosition(); // 0x00000001804C5370-0x00000001804C55C0
	public virtual void SSTUpdate(); // 0x00000001804C5200-0x00000001804C5370
}

