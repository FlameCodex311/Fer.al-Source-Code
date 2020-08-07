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

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018021C0C0-0x000000018021C180
	[Description] // 0x000000018021C0C0-0x000000018021C180
	[Icon] // 0x000000018021C0C0-0x000000018021C180
	[Name] // 0x000000018021C0C0-0x000000018021C180
	public class Repeater : BTDecorator // TypeDefIndex: 15178
	{
		// Fields
		public RepeaterMode repeaterMode; // 0x88
		[ShowIf] // 0x000000018021C3D0-0x000000018021C400
		public BBParameter<int> repeatTimes; // 0x90
		[ShowIf] // 0x000000018021C580-0x000000018021C5B0
		public RepeatUntilStatus repeatUntilStatus; // 0x98
		private int currentIteration; // 0x9C
	
		// Nested types
		public enum RepeaterMode // TypeDefIndex: 15179
		{
			RepeatTimes = 0,
			RepeatUntil = 1,
			RepeatForever = 2
		}
	
		public enum RepeatUntilStatus // TypeDefIndex: 15180
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Repeater(); // 0x00000001808B3FB0-0x00000001808B4010
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B3DE0-0x00000001808B3FA0
		protected override void OnReset(); // 0x00000001808B3FA0-0x00000001808B3FB0
	}
}
