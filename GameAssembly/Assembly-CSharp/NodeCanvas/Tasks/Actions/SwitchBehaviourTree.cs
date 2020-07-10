/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010C910-0x000000018010C970
	[Description] // 0x000000018010C910-0x000000018010C970
	public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner> // TypeDefIndex: 14344
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<BehaviourTree> behaviourTree; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001812653B0-0x00000001812653F0 
	
		// Constructors
		public SwitchBehaviourTree(); // 0x0000000181265370-0x00000001812653B0
	
		// Methods
		protected override void OnExecute(); // 0x00000001812652E0-0x0000000181265370
	}
}
