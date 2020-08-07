/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180244D40-0x0000000180244DA0
	[Description] // 0x0000000180244D40-0x0000000180244DA0
	public class QuestInventoryCheck : ConditionTask // TypeDefIndex: 15292
	{
		// Fields
		public EQuestStatus questStatus; // 0x68
		public string questName; // 0x70
		public string questID; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180805F00-0x0000000180805FB0 
	
		// Nested types
		public enum EQuestStatus // TypeDefIndex: 15293
		{
			Owned = 0,
			Active = 1,
			Complete = 2
		}
	
		// Constructors
		public QuestInventoryCheck(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180805E40-0x0000000180805F00
	}
}
