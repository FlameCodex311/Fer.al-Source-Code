/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	[Color] // 0x000000018015E6C0-0x000000018015E740
	[Description] // 0x000000018015E6C0-0x000000018015E740
	[Name] // 0x000000018015E6C0-0x000000018015E740
	public class ConcurrentState : FSMState, IUpdatable, ISubTasksContainer // TypeDefIndex: 14014
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConditionList _conditionList; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionList _actionList; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _repeatStateActions; // 0x98
		private bool accessed; // 0x99
	
		// Properties
		public ConditionList conditionList { get; set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
		public ActionList actionList { get; set; } // 0x0000000180382A80-0x0000000180382A90 0x000000018049D4D0-0x000000018049D4E0
		public bool repeatStateActions { get; set; } // 0x000000018081DF30-0x000000018081DF40 0x000000018081F000-0x000000018081F010
		public override string name { get; } // 0x000000018174B8F0-0x000000018174BA30 
		public override int maxInConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override int maxOutConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override bool allowAsPrime { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public ConcurrentState(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public Task[] GetSubTasks(); // 0x000000018174B370-0x000000018174B480
		public override void OnValidate(Graph assignedGraph); // 0x000000018174B650-0x000000018174B810
		protected override void OnEnter(); // 0x000000018174B480-0x000000018174B5C0
		public new void Update(); // 0x000000018174B810-0x000000018174B8F0
		protected override void OnExit(); // 0x000000018174B5C0-0x000000018174B620
		protected override void OnPause(); // 0x000000018174B620-0x000000018174B650
	}
}
