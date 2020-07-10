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
	[Category] // 0x000000018011CC70-0x000000018011CCD0
	[Description] // 0x000000018011CC70-0x000000018011CCD0
	public class OpenOkImagePopupWindow : ActionTask // TypeDefIndex: 14410
	{
		// Fields
		public Statement statementHeader; // 0x68
		public Statement statementMessageTitle; // 0x70
		public Statement statementMessageBody; // 0x78
		public Statement statementOkButton; // 0x80
		public string imageDefId; // 0x88
		public BBParameter<bool> waitToContinue; // 0x90
	
		// Properties
		protected override string info { get; } // 0x0000000181556660-0x0000000181556690 
	
		// Constructors
		public OpenOkImagePopupWindow(); // 0x0000000181556560-0x0000000181556660
	
		// Methods
		protected override void OnExecute(); // 0x0000000181556400-0x0000000181556560
		public void OkClicked(); // 0x00000001815563A0-0x0000000181556400
	}
}
