/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_WorldMapButton : MonoBehaviour // TypeDefIndex: 14232
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _cameraPosition; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_WorldMapButton> _subButtons; // 0x30
	[DeComment] // 0x00000001801EDE00-0x00000001801EDE50
	[SerializeField] // 0x00000001801EDE00-0x00000001801EDE50
	private bool _forceSelectionBeforeNavigation; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic _colliderGraphic; // 0x40

	// Properties
	public Vector3 CameraPosition { get; } // 0x0000000180452C20-0x0000000180452C40 
	public List<UI_WorldMapButton> SubButtons { get; } // 0x00000001803745C0-0x00000001803745D0 
	public bool ForceSelectionBeforeNavigation { get; } // 0x0000000180379B20-0x0000000180379B30 
	protected float scrollWheel { get; } // 0x0000000180452C40-0x0000000180452C80 

	// Constructors
	public UI_WorldMapButton(); // 0x0000000180452B80-0x0000000180452C20

	// Methods
	public void BtnClicked(); // 0x00000001804526C0-0x0000000180452760
	public void SetSelected(bool inSelected); // 0x00000001804527B0-0x0000000180452A80
	public virtual void Scroll(BaseEventData inBaseEventData); // 0x0000000180452760-0x00000001804527B0
	public void Show(bool inShow); // 0x0000000180452A80-0x0000000180452B80
	public virtual void GoToLevel(); // 0x00000001803774A0-0x00000001803774B0
}

