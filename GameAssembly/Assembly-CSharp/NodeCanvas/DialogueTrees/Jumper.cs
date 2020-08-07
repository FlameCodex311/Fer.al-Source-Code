/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x0000000180203BB0-0x0000000180203CA0
	[Color] // 0x0000000180203BB0-0x0000000180203CA0
	[Description] // 0x0000000180203BB0-0x0000000180203CA0
	[Icon] // 0x0000000180203BB0-0x0000000180203CA0
	[Name] // 0x0000000180203BB0-0x0000000180203CA0
	public class Jumper : DTNode, IHaveNodeReference // TypeDefIndex: 15120
	{
		// Fields
		[fsSerializeAs] // 0x00000001802054D0-0x0000000180205500
		public NodeReference<DTNode> _targetNode; // 0x98
	
		// Properties
		INodeReference IHaveNodeReference.targetReference { get; } // 0x0000000180418990-0x00000001804189A0 
		private DTNode target { get; } // 0x00000001808B0380-0x00000001808B03D0 
		public override int maxOutConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override bool requireActorSelection { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public Jumper(); // 0x000000018089EA60-0x000000018089EAB0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808B0230-0x00000001808B0380
	}
}
