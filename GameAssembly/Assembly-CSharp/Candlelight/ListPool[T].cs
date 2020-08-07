/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight
{
	public static class ListPool<T> // TypeDefIndex: 14489
	{
		// Fields
		private static readonly ObjectPool<List<T>> s_Pool;
	
		// Nested types
		public struct Scope : IDisposable // TypeDefIndex: 14490
		{
			// Fields
			private List<T> m_List;
	
			// Properties
			public List<T> List { get; }
	
			// Methods
			public void Dispose();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14491
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
