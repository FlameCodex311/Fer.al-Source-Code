/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180120270-0x00000001801202D0
	[Description] // 0x0000000180120270-0x00000001801202D0
	public class QuestObjectives : NetworkActionTask // TypeDefIndex: 14433
	{
		// Fields
		public EObjectiveAction objectiveAction; // 0x68
		[RootSelectorCompact] // 0x00000001800F27D0-0x00000001800F2850
		[Space] // 0x00000001800F27D0-0x00000001800F2850
		public string questChartID; // 0x70
		public int questObjectiveListIndex; // 0x78
		public int objectiveIndex; // 0x7C
		public int taskIndex; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018125A660-0x000000018125AA20 
	
		// Nested types
		public enum EObjectiveAction // TypeDefIndex: 14434
		{
			UpdateTask = 0,
			AddSecondaryQuest = 1
		}
	
		// Constructors
		public QuestObjectives(); // 0x000000018125A640-0x000000018125A660
	}
}
