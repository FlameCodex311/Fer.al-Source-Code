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
	[Description] // 0x00000001801EFBC0-0x00000001801EFC20
	[Name] // 0x00000001801EFBC0-0x00000001801EFC20
	public class ActionState : FSMState, ITaskAssignable // TypeDefIndex: 15082
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActionList _actionList; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _repeatStateActions; // 0x98
	
		// Properties
		public Task task { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x0000000180CBE7D0-0x0000000180CBE860
		public ActionList actionList { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
		public bool repeatStateActions { get; set; } // 0x00000001803D3E90-0x00000001803D3EA0 0x00000001803D3F20-0x00000001803D3F30
	
		// Constructors
		public ActionState(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		public override void OnValidate(Graph assignedGraph); // 0x0000000180CBE6D0-0x0000000180CBE7D0
		protected override void OnEnter(); // 0x0000000180CBE5E0-0x0000000180CBE600
		protected override void OnUpdate(); // 0x0000000180CBE660-0x0000000180CBE6D0
		protected override void OnExit(); // 0x0000000180CBE600-0x0000000180CBE630
		protected override void OnPause(); // 0x0000000180CBE630-0x0000000180CBE660
	}
}
