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
	[Category] // 0x000000018010CED0-0x000000018010CF00
	public class OpenOkPopupWindow : ActionTask // TypeDefIndex: 14411
	{
		// Fields
		public Statement statementTitle; // 0x68
		public Statement statementMessage; // 0x70
		public Statement statementOkButton; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001815568D0-0x00000001815569B0 
	
		// Constructors
		public OpenOkPopupWindow(); // 0x0000000181556810-0x00000001815568D0
	
		// Methods
		protected override void OnExecute(); // 0x00000001815566F0-0x0000000181556810
		public void OkClicked(); // 0x0000000181556690-0x00000001815566F0
	}
}
