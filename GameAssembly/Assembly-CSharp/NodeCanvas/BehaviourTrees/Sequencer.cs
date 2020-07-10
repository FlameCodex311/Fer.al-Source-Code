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
	[Category] // 0x00000001801648A0-0x0000000180164990
	[Color] // 0x00000001801648A0-0x0000000180164990
	[Description] // 0x00000001801648A0-0x0000000180164990
	[Icon] // 0x00000001801648A0-0x0000000180164990
	[Name] // 0x00000001801648A0-0x0000000180164990
	public class Sequencer : BTComposite // TypeDefIndex: 14037
	{
		// Fields
		public bool dynamic; // 0x78
		public bool random; // 0x79
		private int lastRunningNodeIndex; // 0x7C
	
		// Constructors
		public Sequencer(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181571CB0-0x0000000181571E60
		protected override void OnReset(); // 0x0000000181571E60-0x0000000181571FA0
		public override void OnChildDisconnected(int index); // 0x0000000181571880-0x00000001815718A0
		public override void OnGraphStarted(); // 0x00000001815712C0-0x00000001815712E0
		private List<Connection> Shuffle(List<Connection> list); // 0x0000000181571FA0-0x00000001815720C0
	}
}
