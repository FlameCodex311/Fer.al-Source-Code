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
	public abstract class BTNode : Node // TypeDefIndex: 15141
	{
		// Properties
		public sealed override Type outConnectionType { get; } // 0x00000001807C4380-0x00000001807C43E0 
		public sealed override bool allowAsPrime { get; } // 0x0000000180380B60-0x0000000180380B70 
		public sealed override bool canSelfConnect { get; } // 0x0000000180380950-0x0000000180380960 
		public override Alignment2x2 commentsAlignment { get; } // 0x00000001806C4390-0x00000001806C43A0 
		public override Alignment2x2 iconAlignment { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int maxInConnections { get; } // 0x000000018058C710-0x000000018058C720 
		public override int maxOutConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		protected BTNode(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		public T AddChild<T>(int childIndex)
			where T : BTNode;
		public T AddChild<T>()
			where T : BTNode;
	}
}
