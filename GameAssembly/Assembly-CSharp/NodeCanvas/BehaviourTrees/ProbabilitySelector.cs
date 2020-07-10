/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180163DC0-0x0000000180163E90
	[Color] // 0x0000000180163DC0-0x0000000180163E90
	[Description] // 0x0000000180163DC0-0x0000000180163E90
	[Icon] // 0x0000000180163DC0-0x0000000180163E90
	public class ProbabilitySelector : BTComposite // TypeDefIndex: 14035
	{
		// Fields
		public List<BBParameter<float>> childWeights; // 0x78
		public BBParameter<float> failChance; // 0x80
		private float probability; // 0x88
		private float currentProbability; // 0x8C
		private List<int> failedIndeces; // 0x90
	
		// Constructors
		public ProbabilitySelector(); // 0x0000000181571350-0x0000000181571400
	
		// Methods
		public override void OnChildConnected(int index); // 0x0000000181570E80-0x0000000181570F90
		public override void OnChildDisconnected(int index); // 0x0000000181570F90-0x0000000181570FF0
		public override void OnGraphStarted(); // 0x00000001815712C0-0x00000001815712E0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181570FF0-0x00000001815712C0
		protected override void OnReset(); // 0x00000001815712E0-0x0000000181571350
		private float GetTotal(); // 0x0000000181570D00-0x0000000181570E80
	}
}
