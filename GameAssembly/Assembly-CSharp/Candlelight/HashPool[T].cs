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
	public static class HashPool<T> // TypeDefIndex: 13816
	{
		// Fields
		private static readonly ObjectPool<HashSet<T>> s_Pool;
	
		// Nested types
		public struct Scope : IDisposable // TypeDefIndex: 13817
		{
			// Fields
			private HashSet<T> m_HashSet;
	
			// Properties
			public HashSet<T> HashSet { get; }
	
			// Methods
			public void Dispose();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13818
		{
			// Fields
			public static readonly <>c<T> <>9;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal void <.cctor>b__4_0(HashSet<T> h);
		}
	
		// Constructors
		static HashPool();
	
		// Methods
		public static HashSet<T> Get();
		public static void Release(HashSet<T> hashSet);
	}
}
