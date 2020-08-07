/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_StageSubjectPositioner : UIBehaviour, IScrollHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 13831
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected Vector2 _centeredPosition; // 0x18
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected Vector2 _defaultRotation; // 0x20
	[Range] // 0x000000018020DDA0-0x000000018020DDE0
	[SerializeField] // 0x000000018020DDA0-0x000000018020DDE0
	protected float _defaultZoom; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected UI_SpinWithMouse _spinWithMouse; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected float _panSensitivity; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected float _scrollSpeed; // 0x3C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected Vector2 _offset; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
	public UI_Stage Stage { get; } // 0x00000001803A1580-0x00000001803A1590 
	public bool ContainsPointer { get; } // 0x00000001804CDB10-0x00000001804CDB20 

	// Constructors
	public UI_StageSubjectPositioner(); // 0x00000001804CDA00-0x00000001804CDB10

	// Methods
	public void Setup(Camera inUICamera, UI_Stage inStage); // 0x00000001804CD580-0x00000001804CD6A0
	public void SetZoomEnabled(bool inEnabled); // 0x00000001804CD490-0x00000001804CD580
	public void SetSpinEnabled(bool inEnabled, bool setRotationToDefault = false /* Metadata: 0x007BA512 */); // 0x00000001804CD2B0-0x00000001804CD490
	public void SetPanEnabled(bool inEnabled); // 0x00000001804CD1A0-0x00000001804CD2B0
	public void SetCentered(bool inCentered); // 0x00000001804CD0F0-0x00000001804CD1A0
	public void OnScroll(PointerEventData eventData); // 0x00000001804CD040-0x00000001804CD0F0
	public void OnInitializePotentialDrag(PointerEventData inEventData); // 0x00000001804CCE00-0x00000001804CD020
	public void OnBeginDrag(PointerEventData inEventData); // 0x00000001804CC830-0x00000001804CCA00
	public void OnDrag(PointerEventData inEventData); // 0x00000001804CCA00-0x00000001804CCCF0
	public void OnEndDrag(PointerEventData inEventData); // 0x00000001804CCCF0-0x00000001804CCE00
	public void OnPointerDown(PointerEventData eventData); // 0x00000001804CD020-0x00000001804CD030
	public void OnPointerExit(PointerEventData eventData); // 0x00000001804CD030-0x00000001804CD040
	public void OnPointerUp(PointerEventData eventData); // 0x00000001804CD030-0x00000001804CD040
	public Vector2 GetComposerCoordinates(); // 0x00000001804CC5F0-0x00000001804CC830
	private void Update(); // 0x00000001804CD9F0-0x00000001804CDA00
	private void UpdateVirtualCamera(); // 0x00000001804CD6F0-0x00000001804CD9F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <SetZoomEnabled>b__21_0(); // 0x00000001804CD6D0-0x00000001804CD6E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetZoomEnabled>b__21_1(float value); // 0x00000001804CD6E0-0x00000001804CD6F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 <SetPanEnabled>b__23_0(); // 0x00000001804CD6A0-0x00000001804CD6C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetPanEnabled>b__23_1(Vector2 value); // 0x00000001804CD6C0-0x00000001804CD6D0
}

