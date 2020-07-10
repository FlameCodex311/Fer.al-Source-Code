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
	[Category] // 0x00000001801631F0-0x00000001801632E0
	[Color] // 0x00000001801631F0-0x00000001801632E0
	[Description] // 0x00000001801631F0-0x00000001801632E0
	[Icon] // 0x00000001801631F0-0x00000001801632E0
	[Name] // 0x00000001801631F0-0x00000001801632E0
	public class Parallel : BTComposite // TypeDefIndex: 14032
	{
		// Fields
		public ParallelPolicy policy; // 0x78
		[Name] // 0x0000000180163610-0x0000000180163640
		public bool dynamic; // 0x7C
		private readonly List<Connection> finishedConnections; // 0x80
	
		// Nested types
		public enum ParallelPolicy // TypeDefIndex: 14033
		{
			FirstFailure = 0,
			FirstSuccess = 1,
			FirstSuccessOrFailure = 2
		}
	
		// Constructors
		public Parallel(); // 0x0000000181570870-0x00000001815708E0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815703F0-0x0000000181570720
		protected override void OnReset(); // 0x0000000181570720-0x0000000181570770
		private void ResetRunning(); // 0x0000000181570770-0x0000000181570870
	}
}
