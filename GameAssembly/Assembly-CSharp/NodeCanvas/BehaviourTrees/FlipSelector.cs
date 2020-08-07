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
	[Category] // 0x0000000180210670-0x0000000180210740
	[Color] // 0x0000000180210670-0x0000000180210740
	[Description] // 0x0000000180210670-0x0000000180210740
	[Icon] // 0x0000000180210670-0x0000000180210740
	public class FlipSelector : BTComposite // TypeDefIndex: 15149
	{
		// Fields
		private int current; // 0x88
	
		// Constructors
		public FlipSelector(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808A7F30-0x00000001808A8070
		private void SendToBack(int i); // 0x00000001808A8080-0x00000001808A8120
		protected override void OnReset(); // 0x00000001808A8070-0x00000001808A8080
	}
}
