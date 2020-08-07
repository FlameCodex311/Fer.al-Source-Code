/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 8017
	{
		// Fields
		private readonly object _lock;
		private Dictionary<TKey, TValue> _store;
		private readonly Func<TKey, TValue> _creator;
	
		// Constructors
		[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ThreadSafeStore(Func<TKey, TValue> creator);
	
		// Methods
		[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
		public TValue Get(TKey key);
		[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TValue AddValue(TKey key);
	}
}
