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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180228A40-0x0000000180228A70
	public class GetListCount : ActionTask // TypeDefIndex: 15324
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<IList> targetList; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<int> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAFBB0-0x0000000180BAFBF0 
	
		// Constructors
		public GetListCount(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAFAA0-0x0000000180BAFBB0
	}
}
