/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public sealed class fsContext // TypeDefIndex: 9287
	{
		// Fields
		private readonly Dictionary<Type, object> _contextObjects; // 0x10
	
		// Constructors
		public fsContext(); // 0x0000000181512760-0x00000001815127C0
	
		// Methods
		public void Reset(); // 0x0000000181512710-0x0000000181512760
		public void Set<T>(T obj);
		public bool Has<T>();
		public T Get<T>();
	}
}
