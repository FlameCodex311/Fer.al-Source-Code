/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CharmSlotCallout : MonoBehaviour // TypeDefIndex: 13871
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _boundingRect; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UICalloutTail _calloutTail; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _charmSlotA; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _charmSlotB; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _target; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _moveSpeed; // 0x48
	private Camera _uiCamera; // 0x50
	private Vector2 _targetDirection; // 0x58
	private Vector2 _smoothedDirection; // 0x60

	// Properties
	public Transform Target { get; } // 0x00000001803C7290-0x00000001803C72A0 

	// Constructors
	public UI_CharmSlotCallout(); // 0x000000018053F580-0x000000018053F620

	// Methods
	public void SetTarget(Transform inTarget, Camera inTargetCamera); // 0x000000018053E450-0x000000018053E660
	public void SetTargetDirection(Vector2 inTargetDirection); // 0x00000001803A1740-0x00000001803A1750
	private void Update(); // 0x000000018053E660-0x000000018053F580
}

