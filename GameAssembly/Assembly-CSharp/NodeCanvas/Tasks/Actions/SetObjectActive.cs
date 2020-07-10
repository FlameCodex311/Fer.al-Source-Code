/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800F9A00-0x00000001800F9A60
	[Name] // 0x00000001800F9A00-0x00000001800F9A60
	public class SetObjectActive : ActionTask<Transform> // TypeDefIndex: 14277
	{
		// Fields
		public SetActiveMode setTo; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181261440-0x00000001812614B0 
	
		// Nested types
		public enum SetActiveMode // TypeDefIndex: 14278
		{
			Deactivate = 0,
			Activate = 1,
			Toggle = 2
		}
	
		// Constructors
		public SetObjectActive(); // 0x0000000181261400-0x0000000181261440
	
		// Methods
		protected override void OnExecute(); // 0x0000000181261330-0x0000000181261400
	}
}
