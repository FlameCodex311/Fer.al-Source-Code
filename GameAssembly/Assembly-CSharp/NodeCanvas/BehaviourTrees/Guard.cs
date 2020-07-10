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
	[Category] // 0x0000000180168EF0-0x0000000180168FC0
	[Description] // 0x0000000180168EF0-0x0000000180168FC0
	[Icon] // 0x0000000180168EF0-0x0000000180168FC0
	[Name] // 0x0000000180168EF0-0x0000000180168FC0
	public class Guard : BTDecorator // TypeDefIndex: 14047
	{
		// Fields
		public BBParameter<string> token; // 0x78
		public GuardMode ifGuarded; // 0x80
		private bool isGuarding; // 0x84
		private static readonly Dictionary<GameObject, List<Guard>> guards; // 0x00
	
		// Nested types
		public enum GuardMode // TypeDefIndex: 14048
		{
			ReturnFailure = 0,
			WaitUntilReleased = 1
		}
	
		// Constructors
		public Guard(); // 0x000000018155E370-0x000000018155E380
		static Guard(); // 0x00000001815681C0-0x0000000181568220
	
		// Methods
		private static List<Guard> AgentGuards(Component agent); // 0x0000000181567B40-0x0000000181567BE0
		public override void OnGraphStarted(); // 0x0000000181567EF0-0x0000000181567F20
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181567BE0-0x0000000181567EF0
		protected override void OnReset(); // 0x0000000181567F20-0x0000000181567F30
		private void SetGuards(Component guardAgent); // 0x0000000181567F30-0x00000001815681C0
	}
}
