/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180258820-0x0000000180258880
	[Description] // 0x0000000180258820-0x0000000180258880
	public class FindAllWithName : ActionTask // TypeDefIndex: 15361
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> searchName; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAB070-0x0000000180BAB230 
	
		// Constructors
		public FindAllWithName(); // 0x0000000180BAB020-0x0000000180BAB070
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAAEA0-0x0000000180BAB020
	}
}
