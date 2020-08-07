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
	[Category] // 0x0000000180256A00-0x0000000180256AA0
	[Description] // 0x0000000180256A00-0x0000000180256AA0
	[Icon] // 0x0000000180256A00-0x0000000180256AA0
	public class Say : ActionTask<IDialogueActor> // TypeDefIndex: 15354
	{
		// Fields
		public Statement statement; // 0x68
		public bool allowNextButton; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A1E00-0x00000001807A1E90 
	
		// Constructors
		public Say(); // 0x00000001807A1D90-0x00000001807A1E00
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A1C40-0x00000001807A1D90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__4_0(int choice); // 0x00000001807A1BC0-0x00000001807A1BD0
	}
}
