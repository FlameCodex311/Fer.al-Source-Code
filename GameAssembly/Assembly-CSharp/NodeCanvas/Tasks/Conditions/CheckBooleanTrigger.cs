﻿/*
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
	[Category] // 0x00000001802238F0-0x0000000180223950
	[Description] // 0x00000001802238F0-0x0000000180223950
	public class CheckBooleanTrigger : ConditionTask // TypeDefIndex: 15202
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<bool> trigger; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180796510-0x0000000180796550 
	
		// Constructors
		public CheckBooleanTrigger(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807964A0-0x0000000180796510
	}
}
