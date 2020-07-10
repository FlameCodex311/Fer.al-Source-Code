/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTDecorator : BTNode // TypeDefIndex: 14029
	{
		// Properties
		public sealed override int maxOutConnections { get; } // 0x000000018042E670-0x000000018042E680 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000180362180-0x0000000180362190 
		protected Connection decoratedConnection { get; } // 0x0000000181560050-0x00000001815600C0 
		protected Node decoratedNode { get; } // 0x00000001815600C0-0x0000000181560140 
	
		// Constructors
		protected BTDecorator(); // 0x000000018155E370-0x000000018155E380
	}
}
