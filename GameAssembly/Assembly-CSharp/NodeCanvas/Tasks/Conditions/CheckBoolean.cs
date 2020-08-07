/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802236C0-0x00000001802236F0
	public class CheckBoolean : ConditionTask // TypeDefIndex: 15201
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<bool> valueA; // 0x68
		public BBParameter<bool> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180796620-0x0000000180796660 
	
		// Constructors
		public CheckBoolean(); // 0x00000001807965D0-0x0000000180796620
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180796550-0x00000001807965D0
	}
}
