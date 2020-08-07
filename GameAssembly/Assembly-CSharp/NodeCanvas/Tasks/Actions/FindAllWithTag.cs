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
	[Category] // 0x00000001802581D0-0x0000000180258230
	[Description] // 0x00000001802581D0-0x0000000180258230
	public class FindAllWithTag : ActionTask // TypeDefIndex: 15362
	{
		// Fields
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		[TagField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<string> searchTag; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAB340-0x0000000180BAB500 
	
		// Constructors
		public FindAllWithTag(); // 0x0000000180BAB2F0-0x0000000180BAB340
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAB230-0x0000000180BAB2F0
	}
}
