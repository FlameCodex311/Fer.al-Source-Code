/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180122410-0x0000000180122470
	[Description] // 0x0000000180122410-0x0000000180122470
	public class QuestUpdateResults : NetworkActionTask // TypeDefIndex: 14439
	{
		// Fields
		public EResultVariable resultVariable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018125AEC0-0x000000018125AF60 
	
		// Nested types
		public enum EResultVariable // TypeDefIndex: 14440
		{
			SideQuest = 0,
			Cinders = 1,
			Secrets = 2,
			Treasures = 3,
			Puzzles = 4
		}
	
		// Constructors
		public QuestUpdateResults(); // 0x000000018125AE80-0x000000018125AE90
	}
}
