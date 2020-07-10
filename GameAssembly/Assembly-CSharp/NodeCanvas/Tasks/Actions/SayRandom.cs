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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800F3FA0-0x00000001800F4050
	[Description] // 0x00000001800F3FA0-0x00000001800F4050
	[Icon] // 0x00000001800F3FA0-0x00000001800F4050
	public class SayRandom : ActionTask<IDialogueActor> // TypeDefIndex: 14255
	{
		// Fields
		public List<Statement> statements; // 0x68
		public bool allowNextButton; // 0x70
	
		// Constructors
		public SayRandom(); // 0x000000018125CFA0-0x000000018125D010
	
		// Methods
		protected override void OnExecute(); // 0x000000018125CE00-0x000000018125CF90
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__2_0(int choice); // 0x000000018125CF90-0x000000018125CFA0
	}
}
