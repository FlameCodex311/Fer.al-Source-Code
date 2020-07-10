/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800F4410-0x00000001800F44B0
	[Description] // 0x00000001800F4410-0x00000001800F44B0
	[Icon] // 0x00000001800F4410-0x00000001800F44B0
	public class StartDialogueTree : ActionTask<IDialogueActor> // TypeDefIndex: 14256
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<DialogueTreeController> dialogueTreeController; // 0x68
		public bool waitActionFinish; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181263E50-0x0000000181263E90 
	
		// Constructors
		public StartDialogueTree(); // 0x0000000181263E10-0x0000000181263E50
	
		// Methods
		protected override void OnExecute(); // 0x0000000181263CE0-0x0000000181263E10
	}
}
