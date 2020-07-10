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
	[Category] // 0x00000001800F3A90-0x00000001800F3B30
	[Description] // 0x00000001800F3A90-0x00000001800F3B30
	[Icon] // 0x00000001800F3A90-0x00000001800F3B30
	public class Say : ActionTask<IDialogueActor> // TypeDefIndex: 14254
	{
		// Fields
		public Statement statement; // 0x68
		public bool allowNextButton; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018125D1D0-0x000000018125D2B0 
	
		// Constructors
		public Say(); // 0x000000018125D160-0x000000018125D1D0
	
		// Methods
		protected override void OnExecute(); // 0x000000018125D010-0x000000018125D160
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__4_0(int choice); // 0x000000018125CF90-0x000000018125CFA0
	}
}
