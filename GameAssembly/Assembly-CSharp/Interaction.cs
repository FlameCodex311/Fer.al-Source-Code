/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Interaction : Interactable // TypeDefIndex: 10486
{
	// Fields
	[RootSelector] // 0x00000001800E9180-0x00000001800E91E0
	public string dialogListDefId; // 0x1A0
	[Header] // 0x00000001801282E0-0x0000000180128310
	public BehaviourTreeOwner behaviourTreeOwner; // 0x1A8
	public DialogueTreeController dialogueTreeController; // 0x1B0

	// Constructors
	public Interaction(); // 0x0000000180F61D70-0x0000000180F61DC0

	// Methods
	public override void Interact(); // 0x0000000180F61B10-0x0000000180F61BF0
	public override void MStartAfterLocal(); // 0x0000000180F61BF0-0x0000000180F61D60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MStartAfterLocal>b__4_0(DialogueTreeController dtc); // 0x0000000180F61D60-0x0000000180F61D70
}

