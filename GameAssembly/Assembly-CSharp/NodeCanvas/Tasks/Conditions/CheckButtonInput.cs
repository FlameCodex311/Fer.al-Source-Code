/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800CBE00-0x00000001800CBE30
	public class CheckButtonInput : ConditionTask // TypeDefIndex: 14140
	{
		// Fields
		public PressTypes pressType; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> buttonName; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018124EAB0-0x000000018124EB70 
	
		// Constructors
		public CheckButtonInput(); // 0x000000018124EA60-0x000000018124EAB0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124E9A0-0x000000018124EA60
	}
}
