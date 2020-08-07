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
	[Category] // 0x0000000180279590-0x00000001802795C0
	public class OpenOkPopupWindow : ActionTask // TypeDefIndex: 15516
	{
		// Fields
		public Statement statementTitle; // 0x68
		public Statement statementMessage; // 0x70
		public Statement statementOkButton; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BBCD80-0x0000000180BBCE50 
	
		// Constructors
		public OpenOkPopupWindow(); // 0x0000000180BBCCC0-0x0000000180BBCD80
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBCBA0-0x0000000180BBCCC0
		public void OkClicked(); // 0x0000000180BBCB40-0x0000000180BBCBA0
	}
}
