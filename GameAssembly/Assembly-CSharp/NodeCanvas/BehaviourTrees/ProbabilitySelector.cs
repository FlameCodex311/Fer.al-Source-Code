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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x00000001802116B0-0x0000000180211780
	[Color] // 0x00000001802116B0-0x0000000180211780
	[Description] // 0x00000001802116B0-0x0000000180211780
	[Icon] // 0x00000001802116B0-0x0000000180211780
	public class ProbabilitySelector : BTComposite // TypeDefIndex: 15153
	{
		// Fields
		[AutoSortWithChildrenConnections] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<BBParameter<float>> childWeights; // 0x88
		public BBParameter<float> failChance; // 0x90
		private float probability; // 0x98
		private float currentProbability; // 0x9C
		private List<int> failedIndeces; // 0xA0
	
		// Constructors
		public ProbabilitySelector(); // 0x00000001808B3B90-0x00000001808B3C00
	
		// Methods
		public override void OnChildConnected(int index); // 0x00000001808B3020-0x00000001808B31C0
		public override void OnChildDisconnected(int index); // 0x00000001808B33E0-0x00000001808B3440
		public override void OnGraphStarted(); // 0x00000001808B3AF0-0x00000001808B3B10
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B37F0-0x00000001808B3AF0
		protected override void OnReset(); // 0x00000001808B3B20-0x00000001808B3B90
		private float GetTotal(); // 0x00000001808B2EA0-0x00000001808B3020
	}
}
