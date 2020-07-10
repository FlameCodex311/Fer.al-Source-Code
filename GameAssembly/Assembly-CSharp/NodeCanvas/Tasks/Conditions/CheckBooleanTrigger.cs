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
	[Category] // 0x00000001800C3CD0-0x00000001800C3D30
	[Description] // 0x00000001800C3CD0-0x00000001800C3D30
	public class CheckBooleanTrigger : ConditionTask // TypeDefIndex: 14120
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<bool> trigger; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018124E850-0x000000018124E890 
	
		// Constructors
		public CheckBooleanTrigger(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124E7E0-0x000000018124E850
	}
}
