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

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x00000001802069D0-0x0000000180206AA0
	[Color] // 0x00000001802069D0-0x0000000180206AA0
	[Description] // 0x00000001802069D0-0x0000000180206AA0
	[Icon] // 0x00000001802069D0-0x0000000180206AA0
	public class ProbabilitySelector : DTNode // TypeDefIndex: 15126
	{
		// Fields
		[AutoSortWithChildrenConnections] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<Option> childOptions; // 0x98
		private List<int> successIndeces; // 0xA0
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
	
		// Nested types
		public class Option // TypeDefIndex: 15127
		{
			// Fields
			public BBParameter<float> weight; // 0x10
			public ConditionTask condition; // 0x18
	
			// Constructors
			public Option(float weightValue, IBlackboard bbValue); // 0x00000001808B22E0-0x00000001808B2400
		}
	
		// Constructors
		public ProbabilitySelector(); // 0x00000001808B3C00-0x00000001808B3C90
	
		// Methods
		public override void OnChildConnected(int index); // 0x00000001808B31C0-0x00000001808B3380
		public override void OnChildDisconnected(int index); // 0x00000001808B3380-0x00000001808B33E0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B3440-0x00000001808B37F0
		private float GetTotal(); // 0x00000001808B2DA0-0x00000001808B2EA0
		protected override void OnReset(); // 0x00000001808B3B10-0x00000001808B3B20
	}
}
