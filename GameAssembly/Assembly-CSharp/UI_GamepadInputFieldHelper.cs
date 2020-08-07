/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_GamepadInputFieldHelper : MonoBehaviour // TypeDefIndex: 13893
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _targetInputField; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SubmitEvent OnSubmit; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CancelEvent OnCancel; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _restoreOnCancel; // 0x38
	private bool _justSubmitted; // 0x39
	private string _originalText; // 0x40

	// Nested types
	[Serializable]
	public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 13894
	{
		// Constructors
		public SubmitEvent(); // 0x00000001803720F0-0x0000000180372130
	}

	[Serializable]
	public class CancelEvent : UnityEvent // TypeDefIndex: 13895
	{
		// Constructors
		public CancelEvent(); // 0x0000000180372000-0x0000000180372010
	}

	// Constructors
	public UI_GamepadInputFieldHelper(); // 0x00000001803778A0-0x00000001803778F0

	// Methods
	private void BtnClicked_Back(); // 0x00000001803774B0-0x0000000180377550
	private void BtnClicked_Submit(); // 0x0000000180377550-0x0000000180377630
	public void OnClick(); // 0x0000000180377630-0x00000001803776B0
	public void OnInputSelected(); // 0x0000000180377790-0x0000000180377890
	public void OnInputDeselected(); // 0x00000001803776B0-0x0000000180377790
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Submit>b__9_0(); // 0x0000000180377890-0x00000001803778A0
}

