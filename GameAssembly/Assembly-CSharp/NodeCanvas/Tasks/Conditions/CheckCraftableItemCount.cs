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
	[Category] // 0x00000001800DDEB0-0x00000001800DDF10
	[Description] // 0x00000001800DDEB0-0x00000001800DDF10
	public class CheckCraftableItemCount : ConditionTask // TypeDefIndex: 14175
	{
		// Fields
		public BBParameter<string> craftableItemDefId; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		private int valueA { get; } // 0x000000018124F7E0-0x000000018124F880 
		protected override string info { get; } // 0x000000018124F6E0-0x000000018124F7E0 
	
		// Constructors
		public CheckCraftableItemCount(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124F670-0x000000018124F6E0
	}
}
