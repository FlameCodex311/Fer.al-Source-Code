/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public class FastAction // TypeDefIndex: 8743
	{
		// Fields
		private LinkedList<Action> delegates; // 0x10
		private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18
	
		// Constructors
		public FastAction(); // 0x00000001810BE5B0-0x00000001810BE630
	
		// Methods
		public void Add(Action rhs); // 0x00000001810BE3D0-0x00000001810BE480
		public void Remove(Action rhs); // 0x00000001810BE500-0x00000001810BE5B0
		public void Call(); // 0x00000001810BE480-0x00000001810BE500
	}
}
