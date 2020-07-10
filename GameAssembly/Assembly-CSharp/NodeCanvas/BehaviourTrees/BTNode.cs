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
	public abstract class BTNode : Node // TypeDefIndex: 14027
	{
		// Properties
		public sealed override Type outConnectionType { get; } // 0x0000000181560140-0x00000001815601A0 
		public override int maxInConnections { get; } // 0x000000018042E670-0x000000018042E680 
		public override int maxOutConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override bool allowAsPrime { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override Alignment2x2 commentsAlignment { get; } // 0x000000018043D4B0-0x000000018043D4C0 
		public override Alignment2x2 iconAlignment { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		protected BTNode(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public T AddChild<T>(int childIndex)
			where T : BTNode;
		public T AddChild<T>()
			where T : BTNode;
	}
}
