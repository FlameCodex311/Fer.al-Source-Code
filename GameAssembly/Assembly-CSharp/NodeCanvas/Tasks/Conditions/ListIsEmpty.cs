﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180228A40-0x0000000180228A70
	public class ListIsEmpty : ConditionTask // TypeDefIndex: 15212
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180800080-0x00000001808000C0 
	
		// Constructors
		public ListIsEmpty(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180800010-0x0000000180800080
	}
}
