/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800C38F0-0x00000001800C3920
	public class CheckBoolean : ConditionTask // TypeDefIndex: 14119
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<bool> valueA; // 0x68
		public BBParameter<bool> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018124E960-0x000000018124E9A0 
	
		// Constructors
		public CheckBoolean(); // 0x000000018124E910-0x000000018124E960
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124E890-0x000000018124E910
	}
}
