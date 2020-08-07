/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018028D950-0x000000018028D9B0
	[Description] // 0x000000018028D950-0x000000018028D9B0
	public class QuestObjectives : NetworkActionTask // TypeDefIndex: 15538
	{
		// Fields
		public EObjectiveAction objectiveAction; // 0x68
		[RootSelectorCompact] // 0x00000001801DA110-0x00000001801DA190
		[Space] // 0x00000001801DA110-0x00000001801DA190
		public string questChartID; // 0x70
		public int questObjectiveListIndex; // 0x78
		public int objectiveIndex; // 0x7C
		public int taskIndex; // 0x80
		public QuestManager.EGiveObjectiveResetMode resetMode; // 0x84
	
		// Properties
		protected override string info { get; } // 0x000000018079F190-0x000000018079F790 
	
		// Nested types
		public enum EObjectiveAction // TypeDefIndex: 15539
		{
			UpdateTask = 0,
			GiveObjective = 1
		}
	
		// Constructors
		public QuestObjectives(); // 0x000000018079F170-0x000000018079F190
	}
}
