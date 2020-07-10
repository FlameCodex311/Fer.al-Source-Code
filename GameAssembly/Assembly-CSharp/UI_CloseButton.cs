/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x00000001800E89E0-0x00000001800E8A30
public class UI_CloseButton : MonoBehaviour // TypeDefIndex: 13645
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CloseButtonType _closeButtonType; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWButton _button; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Window _window; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<string> _windowIDs; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _includeWindowLayer; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _includeOverlayLayer; // 0x41
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _includePopupLayer; // 0x42

	// Nested types
	public enum CloseButtonType // TypeDefIndex: 13646
	{
		ParentWindow = 0,
		SpecificWindows = 1,
		AllWindows = 2
	}

	// Constructors
	public UI_CloseButton(); // 0x0000000180F28060-0x0000000180F280D0

	// Methods
	private void Start(); // 0x0000000180F27CC0-0x0000000180F27EF0
	private void Reset(); // 0x0000000180F27BD0-0x0000000180F27CC0
	private void OnCloseButtonTypeModified(); // 0x0000000180F27B10-0x0000000180F27BD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__8_0(); // 0x0000000180F27EF0-0x0000000180F27F20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__8_1(); // 0x0000000180F27F20-0x0000000180F27FD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__8_2(); // 0x0000000180F27FD0-0x0000000180F28060
}

