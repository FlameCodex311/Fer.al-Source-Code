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
	[Description] // 0x000000018015DAD0-0x000000018015DB30
	[Name] // 0x000000018015DAD0-0x000000018015DB30
	public class ActionState : FSMState, ITaskAssignable // TypeDefIndex: 14012
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionList _actionList; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _repeatStateActions; // 0x90
	
		// Properties
		public Task task { get; set; } // 0x0000000180424200-0x0000000180424210 0x0000000181749140-0x00000001817491D0
		public ActionList actionList { get; set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
		public bool repeatStateActions { get; set; } // 0x0000000180369C50-0x0000000180369C60 0x00000001806FA350-0x00000001806FA360
	
		// Constructors
		public ActionState(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public override void OnValidate(Graph assignedGraph); // 0x0000000181749040-0x0000000181749140
		protected override void OnEnter(); // 0x0000000181748F40-0x0000000181748F60
		protected override void OnUpdate(); // 0x0000000181748FC0-0x0000000181749040
		protected override void OnExit(); // 0x0000000181748F60-0x0000000181748F90
		protected override void OnPause(); // 0x0000000181748F90-0x0000000181748FC0
	}
}
