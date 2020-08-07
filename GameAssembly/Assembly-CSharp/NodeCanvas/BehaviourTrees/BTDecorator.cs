/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTDecorator : BTNode // TypeDefIndex: 15147
	{
		// Properties
		public sealed override int maxOutConnections { get; } // 0x000000018058C710-0x000000018058C720 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000180411150-0x0000000180411160 
		protected Connection decoratedConnection { get; } // 0x00000001807C42A0-0x00000001807C4310 
		protected Node decoratedNode { get; } // 0x00000001807C4310-0x00000001807C4380 
	
		// Constructors
		protected BTDecorator(); // 0x00000001807C41B0-0x00000001807C41C0
	}
}
