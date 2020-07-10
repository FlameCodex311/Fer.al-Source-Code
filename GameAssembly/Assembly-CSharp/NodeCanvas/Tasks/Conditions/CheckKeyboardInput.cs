/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800CBE00-0x00000001800CBE30
	public class CheckKeyboardInput : ConditionTask // TypeDefIndex: 14141
	{
		// Fields
		public PressTypes pressType; // 0x68
		public KeyCode key; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x0000000181252520-0x0000000181252610 
	
		// Constructors
		public CheckKeyboardInput(); // 0x0000000181252510-0x0000000181252520
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812524D0-0x0000000181252510
	}
}
