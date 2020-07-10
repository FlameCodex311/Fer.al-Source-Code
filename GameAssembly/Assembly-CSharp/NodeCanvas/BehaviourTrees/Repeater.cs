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
	[Category] // 0x000000018016E510-0x000000018016E5D0
	[Description] // 0x000000018016E510-0x000000018016E5D0
	[Icon] // 0x000000018016E510-0x000000018016E5D0
	[Name] // 0x000000018016E510-0x000000018016E5D0
	public class Repeater : BTDecorator // TypeDefIndex: 14059
	{
		// Fields
		public RepeaterMode repeaterMode; // 0x78
		[ShowIf] // 0x000000018016E8F0-0x000000018016E920
		public BBParameter<int> repeatTimes; // 0x80
		[ShowIf] // 0x000000018016EAA0-0x000000018016EAD0
		public RepeatUntilStatus repeatUntilStatus; // 0x88
		private int currentIteration; // 0x8C
	
		// Nested types
		public enum RepeaterMode // TypeDefIndex: 14060
		{
			RepeatTimes = 0,
			RepeatUntil = 1,
			RepeatForever = 2
		}
	
		public enum RepeatUntilStatus // TypeDefIndex: 14061
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Repeater(); // 0x0000000181571760-0x00000001815717C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181571590-0x0000000181571750
		protected override void OnReset(); // 0x0000000181571750-0x0000000181571760
	}
}
