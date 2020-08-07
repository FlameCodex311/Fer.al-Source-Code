/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerTutorialStep : MonoBehaviour // TypeDefIndex: 10575
{
	// Fields
	public GameObject dimmer; // 0x20
	public Vector3 dimmerOffset; // 0x28
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public bool allowInteraction; // 0x34
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public List<GameObject> layerHighlightObjects; // 0x38
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public List<GameObject> toggleObjects; // 0x40
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public Camera tutorialCamera; // 0x48
	public List<string> additionalCameraLayers; // 0x50
	[Header] // 0x00000001802264D0-0x0000000180226500
	public CodeBreakerDialogPopup tutorialDialog; // 0x58
	[RootSelectorCompact] // 0x00000001802265A0-0x0000000180226600
	public string tutorialDialogTextId; // 0x60
	public int dialogEmoteIndex; // 0x68
	private Vector3 _originalLocalPos; // 0x6C
	private List<int> _originalLayers; // 0x78

	// Constructors
	public CodeBreakerTutorialStep(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x000000018052DDC0-0x000000018052E3E0
	private void OnDisable(); // 0x000000018052D950-0x000000018052DDC0
}

