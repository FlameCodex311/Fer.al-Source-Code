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
	[Category] // 0x00000001802139D0-0x0000000180213AC0
	[Color] // 0x00000001802139D0-0x0000000180213AC0
	[Description] // 0x00000001802139D0-0x0000000180213AC0
	[Icon] // 0x00000001802139D0-0x0000000180213AC0
	[Name] // 0x00000001802139D0-0x0000000180213AC0
	public class StepIterator : BTComposite // TypeDefIndex: 15156
	{
		// Fields
		private int current; // 0x88
	
		// Constructors
		public StepIterator(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		public override void OnGraphStarted(); // 0x00000001808A8070-0x00000001808A8080
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B4F60-0x00000001808B5040
		protected override void OnReset(); // 0x00000001808B5040-0x00000001808B5050
	}
}
