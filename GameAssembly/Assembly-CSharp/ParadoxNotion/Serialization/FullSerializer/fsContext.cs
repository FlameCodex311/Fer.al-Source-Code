/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public sealed class fsContext // TypeDefIndex: 15303
	{
		// Fields
		private readonly Dictionary<Type, object> _contextObjects; // 0x10
	
		// Constructors
		public fsContext(); // 0x000000018138C1A0-0x000000018138C200
	
		// Methods
		public void Reset(); // 0x000000018138C150-0x000000018138C1A0
		public void Set<T>(T obj);
		public bool Has<T>();
		public T Get<T>();
	}
}
