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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018022FCD0-0x000000018022FD00
	public class CheckKeyboardInput : ConditionTask // TypeDefIndex: 15232
	{
		// Fields
		public PressTypes pressType; // 0x68
		public KeyCode key; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x00000001807F23F0-0x00000001807F24E0 
	
		// Constructors
		public CheckKeyboardInput(); // 0x00000001807F23E0-0x00000001807F23F0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807F23A0-0x00000001807F23E0
	}
}
