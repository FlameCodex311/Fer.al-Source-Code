/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802788A0-0x0000000180278900
	[Description] // 0x00000001802788A0-0x0000000180278900
	public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner> // TypeDefIndex: 15447
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<BehaviourTree> behaviourTree; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807A9A50-0x00000001807A9A90 
	
		// Constructors
		public SwitchBehaviourTree(); // 0x00000001807A9A10-0x00000001807A9A50
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A9980-0x00000001807A9A10
	}
}
