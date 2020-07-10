/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Candlelight
{
	public static class DictPool<TKey, TValue> // TypeDefIndex: 13813
	{
		// Fields
		private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool;
	
		// Nested types
		public struct Scope : IDisposable // TypeDefIndex: 13814
		{
			// Fields
			private Dictionary<TKey, TValue> m_Dict;
	
			// Properties
			public Dictionary<TKey, TValue> Dict { get; }
	
			// Methods
			public void Dispose();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13815
		{
			// Fields
			public static readonly <>c<TKey, TValue> <>9;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal void <.cctor>b__4_0(Dictionary<TKey, TValue> d);
		}
	
		// Constructors
		static DictPool();
	
		// Methods
		public static Dictionary<TKey, TValue> Get();
		public static void Release(Dictionary<TKey, TValue> dictionary);
	}
}
