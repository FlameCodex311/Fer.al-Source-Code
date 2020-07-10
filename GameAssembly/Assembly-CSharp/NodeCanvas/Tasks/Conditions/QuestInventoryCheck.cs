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
	[Category] // 0x00000001800E0300-0x00000001800E0360
	[Description] // 0x00000001800E0300-0x00000001800E0360
	public class QuestInventoryCheck : ConditionTask // TypeDefIndex: 14189
	{
		// Fields
		public EQuestStatus questStatus; // 0x68
		public string questName; // 0x70
		public string questID; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018125A540-0x000000018125A5F0 
	
		// Nested types
		public enum EQuestStatus // TypeDefIndex: 14190
		{
			Owned = 0,
			Active = 1,
			Complete = 2
		}
	
		// Constructors
		public QuestInventoryCheck(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x000000018125A480-0x000000018125A540
	}
}
