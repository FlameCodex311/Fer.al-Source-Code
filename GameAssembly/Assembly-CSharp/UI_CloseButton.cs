/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x00000001802845D0-0x0000000180284620
public class UI_CloseButton : MonoBehaviour // TypeDefIndex: 11312
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CloseButtonType _closeButtonType; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWButton _button; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Window _window; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<string> _windowIDs; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _includeWindowLayer; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _includeOverlayLayer; // 0x41
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _includePopupLayer; // 0x42

	// Nested types
	public enum CloseButtonType // TypeDefIndex: 11313
	{
		ParentWindow = 0,
		SpecificWindows = 1,
		AllWindows = 2
	}

	// Constructors
	public UI_CloseButton(); // 0x0000000180545A70-0x0000000180545AE0

	// Methods
	private void Start(); // 0x00000001805456E0-0x0000000180545900
	private void Reset(); // 0x00000001805455F0-0x00000001805456E0
	private void OnCloseButtonTypeModified(); // 0x0000000180545530-0x00000001805455F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__8_0(); // 0x0000000180545900-0x0000000180545930
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__8_1(); // 0x0000000180545930-0x00000001805459E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__8_2(); // 0x00000001805459E0-0x0000000180545A70
}

