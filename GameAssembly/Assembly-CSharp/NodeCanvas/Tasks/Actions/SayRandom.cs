/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180256EA0-0x0000000180256F50
	[Description] // 0x0000000180256EA0-0x0000000180256F50
	[Icon] // 0x0000000180256EA0-0x0000000180256F50
	public class SayRandom : ActionTask<IDialogueActor> // TypeDefIndex: 15355
	{
		// Fields
		public List<Statement> statements; // 0x68
		public bool allowNextButton; // 0x70
	
		// Constructors
		public SayRandom(); // 0x00000001807A1BD0-0x00000001807A1C40
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A1A30-0x00000001807A1BC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__2_0(int choice); // 0x00000001807A1BC0-0x00000001807A1BD0
	}
}
