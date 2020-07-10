/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_GamepadInputFieldHelper : MonoBehaviour // TypeDefIndex: 12309
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _targetInputField; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private SubmitEvent OnSubmit; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CancelEvent OnCancel; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _restoreOnCancel; // 0x38
	private bool _justSubmitted; // 0x39
	private string _originalText; // 0x40

	// Nested types
	[Serializable]
	public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 12310
	{
		// Constructors
		public SubmitEvent(); // 0x0000000180E3CEB0-0x0000000180E3CEF0
	}

	[Serializable]
	public class CancelEvent : UnityEvent // TypeDefIndex: 12311
	{
		// Constructors
		public CancelEvent(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
	}

	// Constructors
	public UI_GamepadInputFieldHelper(); // 0x0000000180E40080-0x0000000180E400D0

	// Methods
	private void BtnClicked_Back(); // 0x0000000180E3FC70-0x0000000180E3FD10
	private void BtnClicked_Submit(); // 0x0000000180E3FD10-0x0000000180E3FDF0
	public void OnClick(); // 0x0000000180E3FDF0-0x0000000180E3FE70
	public void OnInputSelected(); // 0x0000000180E3FF60-0x0000000180E40070
	public void OnInputDeselected(); // 0x0000000180E3FE70-0x0000000180E3FF60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Submit>b__9_0(); // 0x0000000180E40070-0x0000000180E40080
}

