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
	[Description] // 0x00000001801F7670-0x00000001801F76D0
	[Name] // 0x00000001801F7670-0x00000001801F76D0
	public class SuperActionState : FSMState // TypeDefIndex: 15094
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActionList _onEnterList; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActionList _onUpdateList; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActionList _onExitList; // 0xA0
		private bool enterListFinished; // 0xA8
	
		// Constructors
		public SuperActionState(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		public override void OnValidate(Graph assignedGraph); // 0x0000000180CCEE40-0x0000000180CCF0C0
		protected override void OnEnter(); // 0x0000000180CCEC10-0x0000000180CCEC30
		protected override void OnUpdate(); // 0x0000000180CCED40-0x0000000180CCEE40
		protected override void OnExit(); // 0x0000000180CCEC30-0x0000000180CCED00
		protected override void OnPause(); // 0x0000000180CCED00-0x0000000180CCED40
	}
}
