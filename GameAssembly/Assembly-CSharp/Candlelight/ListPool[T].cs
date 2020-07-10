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
	public static class ListPool<T> // TypeDefIndex: 13822
	{
		// Fields
		private static readonly ObjectPool<List<T>> s_Pool;
	
		// Nested types
		public struct Scope : IDisposable // TypeDefIndex: 13823
		{
			// Fields
			private List<T> m_List;
	
			// Properties
			public List<T> List { get; }
	
			// Methods
			public void Dispose();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13824
		{
			// Fields
			public static readonly <>c<T> <>9;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal void <.cctor>b__4_0(List<T> l);
		}
	
		// Constructors
		static ListPool();
	
		// Methods
		public static List<T> Get();
		public static void Release(List<T> list);
	}
}
