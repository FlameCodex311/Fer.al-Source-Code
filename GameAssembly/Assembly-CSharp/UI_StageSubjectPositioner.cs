/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_StageSubjectPositioner : UIBehaviour, IScrollHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 12667
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected Vector2 _centeredPosition; // 0x18
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected Vector2 _defaultRotation; // 0x20
	[Range] // 0x00000001800DC820-0x00000001800DC860
	[SerializeField] // 0x00000001800DC820-0x00000001800DC860
	protected float _defaultZoom; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected UI_SpinWithMouse _spinWithMouse; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected float _panSensitivity; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected float _scrollSpeed; // 0x3C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected Vector2 _offset; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected AnimationCurve _panClampCurve; // 0x48
	protected Camera _uiCamera; // 0x50
	private UI_Stage _stage; // 0x58
	protected float _normalizedZoom; // 0x60
	private bool _containsPointer; // 0x64
	protected bool _zoomEnabled; // 0x65
	protected bool _spinEnabled; // 0x66
	protected bool _panEnabled; // 0x67
	protected Vector2 _defaultPos; // 0x68

	// Properties
	public UI_Stage Stage { get; } // 0x0000000180357120-0x0000000180357130 
	public bool ContainsPointer { get; } // 0x0000000180EF8A10-0x0000000180EF8A20 

	// Constructors
	public UI_StageSubjectPositioner(); // 0x0000000180EF8900-0x0000000180EF8A10

	// Methods
	public void Setup(Camera inUICamera, UI_Stage inStage); // 0x0000000180EF8490-0x0000000180EF85B0
	public void SetZoomEnabled(bool inEnabled); // 0x0000000180EF83A0-0x0000000180EF8490
	public void SetSpinEnabled(bool inEnabled, bool setRotationToDefault = false /* Metadata: 0x00782FE8 */); // 0x0000000180EF81B0-0x0000000180EF83A0
	public void SetPanEnabled(bool inEnabled); // 0x0000000180EF80A0-0x0000000180EF81B0
	public void SetCentered(bool inCentered); // 0x0000000180EF7FF0-0x0000000180EF80A0
	public void OnScroll(PointerEventData eventData); // 0x0000000180EF7F40-0x0000000180EF7FF0
	public void OnInitializePotentialDrag(PointerEventData inEventData); // 0x0000000180EF7D00-0x0000000180EF7F20
	public void OnBeginDrag(PointerEventData inEventData); // 0x0000000180EF7780-0x0000000180EF7960
	public void OnDrag(PointerEventData inEventData); // 0x0000000180EF7960-0x0000000180EF7C50
	public void OnEndDrag(PointerEventData inEventData); // 0x0000000180EF7C50-0x0000000180EF7D00
	public void OnPointerDown(PointerEventData eventData); // 0x0000000180EF7F20-0x0000000180EF7F30
	public void OnPointerExit(PointerEventData eventData); // 0x0000000180EF7F30-0x0000000180EF7F40
	public void OnPointerUp(PointerEventData eventData); // 0x0000000180EF7F30-0x0000000180EF7F40
	public Vector2 GetComposerCoordinates(); // 0x0000000180EF7540-0x0000000180EF7780
	private void Update(); // 0x0000000180EF88F0-0x0000000180EF8900
	private void UpdateVirtualCamera(); // 0x0000000180EF85E0-0x0000000180EF88F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <SetZoomEnabled>b__21_0(); // 0x0000000180487CD0-0x0000000180487CE0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetZoomEnabled>b__21_1(float value); // 0x0000000180EF85D0-0x0000000180EF85E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 <SetPanEnabled>b__23_0(); // 0x0000000180EF85B0-0x0000000180EF85D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetPanEnabled>b__23_1(Vector2 value); // 0x00000001803A2810-0x00000001803A2820
}

