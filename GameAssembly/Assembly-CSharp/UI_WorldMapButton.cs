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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_WorldMapButton : MonoBehaviour // TypeDefIndex: 12630
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _cameraPosition; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_WorldMapButton> _subButtons; // 0x30
	[DeComment] // 0x00000001800F9EF0-0x00000001800F9F40
	[SerializeField] // 0x00000001800F9EF0-0x00000001800F9F40
	private bool _forceSelectionBeforeNavigation; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic _colliderGraphic; // 0x40

	// Properties
	public Vector3 CameraPosition { get; } // 0x0000000180F86DA0-0x0000000180F86DC0 
	public List<UI_WorldMapButton> SubButtons { get; } // 0x0000000180397720-0x0000000180397730 
	public bool ForceSelectionBeforeNavigation { get; } // 0x00000001804AEAD0-0x00000001804AEAE0 
	protected float scrollWheel { get; } // 0x0000000180F86DC0-0x0000000180F86E00 

	// Constructors
	public UI_WorldMapButton(); // 0x0000000180F86D00-0x0000000180F86DA0

	// Methods
	public void BtnClicked(); // 0x0000000180F86840-0x0000000180F868E0
	public void SetSelected(bool inSelected); // 0x0000000180F86930-0x0000000180F86C00
	public virtual void Scroll(BaseEventData inBaseEventData); // 0x0000000180F868E0-0x0000000180F86930
	public void Show(bool inShow); // 0x0000000180F86C00-0x0000000180F86D00
	public virtual void GoToLevel(); // 0x00000001803581E0-0x00000001803581F0
}

