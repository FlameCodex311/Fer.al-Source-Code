/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public sealed class fsContext // TypeDefIndex: 9115
	{
		// Fields
		private readonly Dictionary<Type, object> _contextObjects; // 0x10
	
		// Constructors
		public fsContext(); // 0x00000001818ECBF0-0x00000001818ECC50
	
		// Methods
		public void Reset(); // 0x00000001818ECBA0-0x00000001818ECBF0
		public void Set<T>(T obj);
		public bool Has<T>();
		public T Get<T>();
	}
}
