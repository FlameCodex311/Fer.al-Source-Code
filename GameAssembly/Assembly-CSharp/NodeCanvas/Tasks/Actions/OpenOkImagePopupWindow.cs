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
	[Category] // 0x0000000180289190-0x00000001802891F0
	[Description] // 0x0000000180289190-0x00000001802891F0
	public class OpenOkImagePopupWindow : ActionTask // TypeDefIndex: 15515
	{
		// Fields
		public Statement statementHeader; // 0x68
		public Statement statementMessageTitle; // 0x70
		public Statement statementMessageBody; // 0x78
		public Statement statementOkButton; // 0x80
		public string imageDefId; // 0x88
		public BBParameter<bool> waitToContinue; // 0x90
	
		// Properties
		protected override string info { get; } // 0x0000000180BBCB10-0x0000000180BBCB40 
	
		// Constructors
		public OpenOkImagePopupWindow(); // 0x0000000180BBCA10-0x0000000180BBCB10
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBC8B0-0x0000000180BBCA10
		public void OkClicked(); // 0x0000000180BBC850-0x0000000180BBC8B0
	}
}
