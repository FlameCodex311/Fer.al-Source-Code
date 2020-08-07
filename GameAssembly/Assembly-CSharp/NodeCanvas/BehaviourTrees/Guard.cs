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
	[Category] // 0x0000000180216F50-0x0000000180217020
	[Description] // 0x0000000180216F50-0x0000000180217020
	[Icon] // 0x0000000180216F50-0x0000000180217020
	[Name] // 0x0000000180216F50-0x0000000180217020
	public class Guard : BTDecorator // TypeDefIndex: 15165
	{
		// Fields
		public BBParameter<string> token; // 0x88
		public GuardMode ifGuarded; // 0x90
		private bool isGuarding; // 0x94
		private static readonly Dictionary<GameObject, List<Guard>> guards; // 0x00
	
		// Nested types
		public enum GuardMode // TypeDefIndex: 15166
		{
			ReturnFailure = 0,
			WaitUntilReleased = 1
		}
	
		// Constructors
		public Guard(); // 0x00000001808A8120-0x00000001808A8130
		static Guard(); // 0x00000001808AF7C0-0x00000001808AF820
	
		// Methods
		private static List<Guard> AgentGuards(Component agent); // 0x00000001808AEED0-0x00000001808AEF70
		public override void OnGraphStarted(); // 0x00000001808AF260-0x00000001808AF290
		public override void OnGraphStoped(); // 0x00000001808AF290-0x00000001808AF530
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808AEF70-0x00000001808AF260
		protected override void OnReset(); // 0x00000001808AF530-0x00000001808AF540
		private void SetGuards(Component guardAgent); // 0x00000001808AF540-0x00000001808AF7C0
	}
}
