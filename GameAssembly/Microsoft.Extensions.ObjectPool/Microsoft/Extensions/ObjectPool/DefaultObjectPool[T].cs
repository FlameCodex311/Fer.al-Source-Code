/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 64: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7751-7763

namespace Microsoft.Extensions.ObjectPool
{
	public class DefaultObjectPool<T> : ObjectPool<T> // TypeDefIndex: 7752
		where T : class
	{
		// Fields
		private protected readonly ObjectWrapper[] _items;
		private protected readonly IPooledObjectPolicy<T> _policy;
		private protected readonly bool _isDefaultPolicy;
		private protected T _firstItem;
		private protected readonly PooledObjectPolicy<T> _fastPolicy;
	
		// Nested types
		[DebuggerDisplay] // 0x00000001800E6690-0x00000001800E66C0
		private protected struct ObjectWrapper // TypeDefIndex: 7753
		{
			// Fields
			public T Element;
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <>c__DisplayClass6_0 // TypeDefIndex: 7754
		{
			// Fields
			public IPooledObjectPolicy<T> policy;
		}
	
		// Constructors
		public DefaultObjectPool(IPooledObjectPolicy<T> policy, int maximumRetained);
	
		// Methods
		public override T Get();
		private T Create();
		public override void Return(T obj);
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		internal static bool <.ctor>g__IsDefaultPolicy|6_0(ref <>c__DisplayClass6_0 param_0001037c);
	}
}
