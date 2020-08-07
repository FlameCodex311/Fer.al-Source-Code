/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802572D0-0x0000000180257370
	[Description] // 0x00000001802572D0-0x0000000180257370
	[Icon] // 0x00000001802572D0-0x0000000180257370
	public class StartDialogueTree : ActionTask<IDialogueActor> // TypeDefIndex: 15356
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<DialogueTreeController> dialogueTreeController; // 0x68
		public bool waitActionFinish; // 0x70
		public bool isPrefab; // 0x71
		private DialogueTreeController instance; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A8670-0x00000001807A86B0 
	
		// Constructors
		public StartDialogueTree(); // 0x00000001807A8630-0x00000001807A8670
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A8390-0x00000001807A8510
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__6_0(bool success); // 0x00000001807A8510-0x00000001807A85B0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__6_1(bool success); // 0x00000001807A85B0-0x00000001807A8630
	}
}
