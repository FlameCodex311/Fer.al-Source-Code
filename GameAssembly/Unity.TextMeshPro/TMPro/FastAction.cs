/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public class FastAction // TypeDefIndex: 8909
	{
		// Fields
		private LinkedList<Action> delegates; // 0x10
		private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18
	
		// Constructors
		public FastAction(); // 0x0000000180569200-0x0000000180569280
	
		// Methods
		public void Add(Action rhs); // 0x0000000180569020-0x00000001805690D0
		public void Remove(Action rhs); // 0x0000000180569150-0x0000000180569200
		public void Call(); // 0x00000001805690D0-0x0000000180569150
	}
}
