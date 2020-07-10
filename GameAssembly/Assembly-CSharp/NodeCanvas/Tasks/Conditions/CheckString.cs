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
	public class CheckString : ConditionTask // TypeDefIndex: 14124
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> valueA; // 0x68
		public BBParameter<string> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812553F0-0x0000000181255430 
	
		// Constructors
		public CheckString(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181255370-0x00000001812553F0
	}
}
