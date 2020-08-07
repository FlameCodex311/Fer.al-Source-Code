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
	[Category] // 0x0000000180210B70-0x0000000180210C60
	[Color] // 0x0000000180210B70-0x0000000180210C60
	[Description] // 0x0000000180210B70-0x0000000180210C60
	[Icon] // 0x0000000180210B70-0x0000000180210C60
	[Name] // 0x0000000180210B70-0x0000000180210C60
	public class Parallel : BTComposite // TypeDefIndex: 15150
	{
		// Fields
		public ParallelPolicy policy; // 0x88
		[Name] // 0x0000000180210F60-0x0000000180210F90
		public bool dynamic; // 0x8C
		private readonly List<Connection> finishedConnections; // 0x90
	
		// Nested types
		public enum ParallelPolicy // TypeDefIndex: 15151
		{
			FirstFailure = 0,
			FirstSuccess = 1,
			FirstSuccessOrFailure = 2
		}
	
		// Constructors
		public Parallel(); // 0x00000001808B2900-0x00000001808B2970
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B2500-0x00000001808B2790
		protected override void OnReset(); // 0x00000001808B2790-0x00000001808B27E0
		private void ResetRunning(); // 0x00000001808B27E0-0x00000001808B2900
	}
}
