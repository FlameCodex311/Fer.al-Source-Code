/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SanctuaryObject_Interactable : Interactable // TypeDefIndex: 13382
{
	// Fields
	private SanctuaryObjectBase _sanctuaryObjectBase; // 0x1A0
	private Animator _animatorComponent; // 0x1A8
	[SerializeField] // 0x000000018021ED60-0x000000018021EDB0
	[Tooltip] // 0x000000018021ED60-0x000000018021EDB0
	private RuntimeAnimatorController _runtimeAnimatorController; // 0x1B0

	// Properties
	protected SanctuaryObjectBase sanctuaryObjectBase { get; } // 0x0000000180BF6E10-0x0000000180BF6ED0 
	protected Animator animatorComponent { get; } // 0x0000000180BF6D50-0x0000000180BF6E10 

	// Constructors
	public SanctuaryObject_Interactable(); // 0x00000001804EF080-0x00000001804EF090

	// Methods
	public override void MStart(); // 0x0000000180BF6A20-0x0000000180BF6A40
	public override void MOnEnable(); // 0x0000000180BF6920-0x0000000180BF6A20
	public void SetState(ESanctuaryStateInteract inState); // 0x0000000180BF6C40-0x0000000180BF6C50
	private void SetValidInteract(); // 0x0000000180BF6C50-0x0000000180BF6D50
	private void SetAnimatorController(); // 0x0000000180BF6B40-0x0000000180BF6C40
	public override void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x0000000180BF6A40-0x0000000180BF6B40
}

