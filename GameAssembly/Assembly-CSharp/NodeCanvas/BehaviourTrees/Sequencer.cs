﻿/*
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
	[Category] // 0x0000000180213350-0x0000000180213440
	[Color] // 0x0000000180213350-0x0000000180213440
	[Description] // 0x0000000180213350-0x0000000180213440
	[Icon] // 0x0000000180213350-0x0000000180213440
	[Name] // 0x0000000180213350-0x0000000180213440
	public class Sequencer : BTComposite // TypeDefIndex: 15155
	{
		// Fields
		public bool dynamic; // 0x88
		public bool random; // 0x89
		private int lastRunningNodeIndex; // 0x8C
	
		// Constructors
		public Sequencer(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B43B0-0x00000001808B45F0
		protected override void OnReset(); // 0x00000001808B45F0-0x00000001808B4650
		public override void OnChildDisconnected(int index); // 0x00000001808B40F0-0x00000001808B4110
		public override void OnGraphStarted(); // 0x00000001808B3AF0-0x00000001808B3B10
	}
}
