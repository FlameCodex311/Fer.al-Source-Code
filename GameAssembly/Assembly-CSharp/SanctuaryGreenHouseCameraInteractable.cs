/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SanctuaryGreenHouseCameraInteractable : Interactable // TypeDefIndex: 13267
{
	// Fields
	public CinemachineVirtualCamera virtualCamera; // 0x1A0

	// Constructors
	public SanctuaryGreenHouseCameraInteractable(); // 0x00000001804EF080-0x00000001804EF090

	// Methods
	public static SanctuaryGreenHouseCameraInteractable Create(Transform inParent, string inInteractableDefId); // 0x00000001807AFA90-0x00000001807AFBE0
	public void Setup(string inInteractableDefId); // 0x00000001807AFC70-0x00000001807AFCF0
	private void SetValidInteract(); // 0x00000001807AFC60-0x00000001807AFC70
	public override void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x00000001807AFBE0-0x00000001807AFC60
}

