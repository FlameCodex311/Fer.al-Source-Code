/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Interaction : Interactable // TypeDefIndex: 11974
{
	// Fields
	[RootSelector] // 0x00000001801FCC70-0x00000001801FCCD0
	public string dialogListDefId; // 0x1A0
	[Header] // 0x00000001801FD070-0x00000001801FD0A0
	public BehaviourTreeOwner behaviourTreeOwner; // 0x1A8
	public DialogueTreeController dialogueTreeController; // 0x1B0

	// Constructors
	public Interaction(); // 0x000000018062B170-0x000000018062B1C0

	// Methods
	public override void Interact(); // 0x000000018062AF10-0x000000018062AFF0
	public override void MStartAfterLocal(); // 0x000000018062AFF0-0x000000018062B160
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MStartAfterLocal>b__4_0(DialogueTreeController dtc); // 0x000000018062B160-0x000000018062B170
}

