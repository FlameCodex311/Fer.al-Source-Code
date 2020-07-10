/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_InteractButton : MonoBehaviour // TypeDefIndex: 12319
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Image _iconImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _interactIcon; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _sleepIcon; // 0x30

	// Constructors
	public UI_InteractButton(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180E43AB0-0x0000000180E43B40
	private void OnDisable(); // 0x0000000180E43A20-0x0000000180E43AB0
	public void DownloadAndAssign(string inImageDefId); // 0x0000000180E43910-0x0000000180E43A20
	private void OnPrimaryInteractableUpdated(PrimaryInteractableUpdatedMessage inMessage); // 0x0000000180E43B40-0x0000000180E43D80
}

