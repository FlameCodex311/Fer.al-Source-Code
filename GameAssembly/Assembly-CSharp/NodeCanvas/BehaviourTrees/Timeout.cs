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

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018016F100-0x000000018016F1A0
	[Description] // 0x000000018016F100-0x000000018016F1A0
	[Icon] // 0x000000018016F100-0x000000018016F1A0
	public class Timeout : BTDecorator // TypeDefIndex: 14063
	{
		// Fields
		public BBParameter<float> timeout; // 0x78
		private float timer; // 0x80
	
		// Constructors
		public Timeout(); // 0x00000001815749D0-0x0000000181574A20
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181574840-0x00000001815749C0
		protected override void OnReset(); // 0x00000001815749C0-0x00000001815749D0
	}
}
