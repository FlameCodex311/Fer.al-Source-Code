/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerTutorialStep : MonoBehaviour // TypeDefIndex: 12910
{
	// Fields
	public GameObject dimmer; // 0x20
	public Vector3 dimmerOffset; // 0x28
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public bool allowInteraction; // 0x34
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public List<GameObject> layerHighlightObjects; // 0x38
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public List<GameObject> toggleObjects; // 0x40
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public Camera tutorialCamera; // 0x48
	public List<string> additionalCameraLayers; // 0x50
	[Header] // 0x0000000180146C10-0x0000000180146C40
	public CodeBreakerDialogPopup tutorialDialog; // 0x58
	[RootSelectorCompact] // 0x0000000180146D90-0x0000000180146DF0
	public string tutorialDialogTextId; // 0x60
	public int dialogEmoteIndex; // 0x68
	private Vector3 _originalLocalPos; // 0x6C
	private List<int> _originalLayers; // 0x78

	// Constructors
	public CodeBreakerTutorialStep(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000181275650-0x0000000181275C90
	private void OnDisable(); // 0x00000001812751D0-0x0000000181275650
}

