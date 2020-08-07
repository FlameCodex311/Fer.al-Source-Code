/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018022FCD0-0x000000018022FD00
	public class CheckButtonInput : ConditionTask // TypeDefIndex: 15231
	{
		// Fields
		public PressTypes pressType; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> buttonName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180796770-0x0000000180796830 
	
		// Constructors
		public CheckButtonInput(); // 0x0000000180796720-0x0000000180796770
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180796660-0x0000000180796720
	}
}
