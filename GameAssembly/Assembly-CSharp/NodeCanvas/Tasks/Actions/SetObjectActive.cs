/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018025DBF0-0x000000018025DC70
	[Description] // 0x000000018025DBF0-0x000000018025DC70
	[Name] // 0x000000018025DBF0-0x000000018025DC70
	public class SetObjectActive : ActionTask<Transform> // TypeDefIndex: 15378
	{
		// Fields
		public SetActiveMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807A6170-0x00000001807A61E0 
	
		// Nested types
		public enum SetActiveMode // TypeDefIndex: 15379
		{
			Deactivate = 0,
			Activate = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectActive(); // 0x00000001807A6130-0x00000001807A6170
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A6060-0x00000001807A6130
	}
}
