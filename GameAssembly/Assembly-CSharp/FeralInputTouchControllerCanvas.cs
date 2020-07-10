/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralInputTouchControllerCanvas : MonoBehaviour // TypeDefIndex: 10466
{
	// Fields
	public static FeralInputTouchControllerCanvas instance; // 0x00
	public GameObject controlModeContainer_ButtonToInteract; // 0x20
	public GameObject controlModeContainer_TouchToInteract; // 0x28
	private Canvas _controllerCanvas; // 0x30
	[DebugField] // 0x0000000180120340-0x00000001801203A0
	private int _disableRequests; // 0x38

	// Properties
	public Canvas ControllerCanvas { get; } // 0x0000000181108080-0x0000000181108100 

	// Constructors
	public FeralInputTouchControllerCanvas(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000181107A20-0x0000000181107BA0
	private void LateUpdate(); // 0x0000000181107C10-0x0000000181107E50
	private void OnDestroy(); // 0x0000000181107E50-0x0000000181107EF0
	private void SetControlsEnabled(SetControlsEnabledCommand inCommand); // 0x0000000181107EF0-0x0000000181107F70
	[DebugButton] // 0x00000001801205E0-0x0000000180120640
	public void EnableCanvas(); // 0x0000000181107BF0-0x0000000181107C10
	[DebugButton] // 0x0000000180120740-0x00000001801207A0
	public void DisableCanvas(); // 0x0000000181107BA0-0x0000000181107BF0
	[DebugButton] // 0x0000000180121C10-0x0000000180121C70
	public void ToggleTouchContolMode(); // 0x0000000181107F70-0x0000000181108080
}

