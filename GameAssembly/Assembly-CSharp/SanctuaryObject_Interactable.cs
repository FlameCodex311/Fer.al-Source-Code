/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SanctuaryObject_Interactable : Interactable // TypeDefIndex: 11832
{
	// Fields
	private SanctuaryObjectBase _sanctuaryObjectBase; // 0x1A0
	private Animator _animatorComponent; // 0x1A8
	[SerializeField] // 0x000000018012F7B0-0x000000018012F800
	[Tooltip] // 0x000000018012F7B0-0x000000018012F800
	private RuntimeAnimatorController _runtimeAnimatorController; // 0x1B0

	// Properties
	protected SanctuaryObjectBase sanctuaryObjectBase { get; } // 0x000000018136E7C0-0x000000018136E880 
	protected Animator animatorComponent { get; } // 0x000000018136E700-0x000000018136E7C0 

	// Constructors
	public SanctuaryObject_Interactable(); // 0x0000000180F5D120-0x0000000180F5D130

	// Methods
	public override void MStart(); // 0x000000018136E3D0-0x000000018136E3F0
	public override void MOnEnable(); // 0x000000018136E2C0-0x000000018136E3D0
	public void SetState(ESanctuaryStateInteract inState); // 0x000000018136E5F0-0x000000018136E600
	private void SetValidInteract(); // 0x000000018136E600-0x000000018136E700
	private void SetAnimatorController(); // 0x000000018136E4F0-0x000000018136E5F0
	public override void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x000000018136E3F0-0x000000018136E4F0
}

