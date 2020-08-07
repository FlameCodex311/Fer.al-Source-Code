/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[Color] // 0x00000001801F0810-0x00000001801F0890
	[Description] // 0x00000001801F0810-0x00000001801F0890
	[Name] // 0x00000001801F0810-0x00000001801F0890
	public class ConcurrentState : FSMNode, IUpdatable // TypeDefIndex: 15084
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionList _conditionList; // 0x88
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActionList _actionList; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _repeatStateActions; // 0x98
		private bool accessed; // 0x99
	
		// Properties
		public ConditionList conditionList { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
		public ActionList actionList { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
		public bool repeatStateActions { get; set; } // 0x00000001803D3E90-0x00000001803D3EA0 0x00000001803D3F20-0x00000001803D3F30
		public override string name { get; } // 0x00000001807C41C0-0x00000001807C41F0 
		public override int maxInConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int maxOutConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override bool allowAsPrime { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public ConcurrentState(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		public override void OnValidate(Graph assignedGraph); // 0x0000000180CC0430-0x0000000180CC05F0
		public override void OnGraphStarted(); // 0x0000000180CC0380-0x0000000180CC03E0
		public override void OnGraphStoped(); // 0x0000000180CC03E0-0x0000000180CC0430
		public override void OnGraphPaused(); // 0x0000000180CBE630-0x0000000180CBE660
		void IUpdatable.Update(); // 0x0000000180CC0280-0x0000000180CC0380
	}
}
