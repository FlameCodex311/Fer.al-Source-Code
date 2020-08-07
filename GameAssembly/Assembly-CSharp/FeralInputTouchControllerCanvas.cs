/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralInputTouchControllerCanvas : MonoBehaviour // TypeDefIndex: 11954
{
	// Fields
	public static FeralInputTouchControllerCanvas instance; // 0x00
	public GameObject controlModeContainer_ButtonToInteract; // 0x20
	public GameObject controlModeContainer_TouchToInteract; // 0x28
	private Canvas _controllerCanvas; // 0x30
	[DebugField] // 0x00000001801F3610-0x00000001801F3670
	private int _disableRequests; // 0x38

	// Properties
	public Canvas ControllerCanvas { get; } // 0x000000018069DC90-0x000000018069DD10 

	// Constructors
	public FeralInputTouchControllerCanvas(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x000000018069D650-0x000000018069D7C0
	private void LateUpdate(); // 0x000000018069D830-0x000000018069DA60
	private void OnDestroy(); // 0x000000018069DA60-0x000000018069DB00
	private void SetControlsEnabled(SetControlsEnabledCommand inCommand); // 0x000000018069DB00-0x000000018069DB80
	[DebugButton] // 0x00000001801F3940-0x00000001801F39A0
	public void EnableCanvas(); // 0x000000018069D810-0x000000018069D830
	[DebugButton] // 0x00000001801F3C10-0x00000001801F3C70
	public void DisableCanvas(); // 0x000000018069D7C0-0x000000018069D810
	[DebugButton] // 0x00000001801F3FC0-0x00000001801F4020
	public void ToggleTouchContolMode(); // 0x000000018069DB80-0x000000018069DC90
}

