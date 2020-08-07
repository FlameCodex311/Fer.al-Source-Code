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

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x0000000180206250-0x0000000180206340
	[Color] // 0x0000000180206250-0x0000000180206340
	[Description] // 0x0000000180206250-0x0000000180206340
	[Icon] // 0x0000000180206250-0x0000000180206340
	[Name] // 0x0000000180206250-0x0000000180206340
	public class MultipleConditionNode : DTNode // TypeDefIndex: 15125
	{
		// Fields
		[AutoSortWithChildrenConnections] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<ConditionTask> conditions; // 0x98
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
	
		// Constructors
		public MultipleConditionNode(); // 0x00000001808B1380-0x00000001808B1410
	
		// Methods
		public override void OnChildConnected(int index); // 0x00000001808B10D0-0x00000001808B1150
		public override void OnChildDisconnected(int index); // 0x00000001808B1150-0x00000001808B11B0
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808B11B0-0x00000001808B1380
	}
}
