/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_InteractButton : MonoBehaviour // TypeDefIndex: 13903
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Image _iconImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _interactIcon; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _sleepIcon; // 0x30

	// Constructors
	public UI_InteractButton(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x000000018037B2F0-0x000000018037B380
	private void OnDisable(); // 0x000000018037B260-0x000000018037B2F0
	public void DownloadAndAssign(string inImageDefId); // 0x000000018037B150-0x000000018037B260
	private void OnPrimaryInteractableUpdated(PrimaryInteractableUpdatedMessage inMessage); // 0x000000018037B380-0x000000018037B5C0
}

