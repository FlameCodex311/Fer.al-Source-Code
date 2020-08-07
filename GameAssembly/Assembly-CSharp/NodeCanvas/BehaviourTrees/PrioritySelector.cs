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
	[Category] // 0x0000000180211070-0x0000000180211140
	[Color] // 0x0000000180211070-0x0000000180211140
	[Description] // 0x0000000180211070-0x0000000180211140
	[Icon] // 0x0000000180211070-0x0000000180211140
	public class PrioritySelector : BTComposite // TypeDefIndex: 15152
	{
		// Fields
		[AutoSortWithChildrenConnections] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<BBParameter<float>> priorities; // 0x88
		private Connection[] orderedConnections; // 0x90
		private int current; // 0x98
	
		// Constructors
		public PrioritySelector(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		public override void OnChildConnected(int index); // 0x00000001808B2970-0x00000001808B2B10
		public override void OnChildDisconnected(int index); // 0x00000001808B2B10-0x00000001808B2B70
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B2B70-0x00000001808B2CF0
		protected override void OnReset(); // 0x00000001808B2CF0-0x00000001808B2D00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <OnExecute>b__5_0(Connection c); // 0x00000001808B2D00-0x00000001808B2DA0
	}
}
