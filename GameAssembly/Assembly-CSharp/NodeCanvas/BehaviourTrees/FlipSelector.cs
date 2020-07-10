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
	[Category] // 0x0000000180162D90-0x0000000180162E60
	[Color] // 0x0000000180162D90-0x0000000180162E60
	[Description] // 0x0000000180162D90-0x0000000180162E60
	[Icon] // 0x0000000180162D90-0x0000000180162E60
	public class FlipSelector : BTComposite // TypeDefIndex: 14031
	{
		// Fields
		private int current; // 0x78
	
		// Constructors
		public FlipSelector(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815678A0-0x00000001815679A0
		private void SendToBack(int i); // 0x00000001815679B0-0x0000000181567A50
		protected override void OnReset(); // 0x00000001815679A0-0x00000001815679B0
	}
}
