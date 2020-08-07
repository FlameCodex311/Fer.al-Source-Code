/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 65: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7917-7929

namespace Microsoft.Extensions.ObjectPool
{
	public class DefaultObjectPool<T> : ObjectPool<T> // TypeDefIndex: 7918
		where T : class
	{
		// Fields
		private protected readonly ObjectWrapper[] _items;
		private protected readonly IPooledObjectPolicy<T> _policy;
		private protected readonly bool _isDefaultPolicy;
		private protected T _firstItem;
		private protected readonly PooledObjectPolicy<T> _fastPolicy;
	
		// Nested types
		[DebuggerDisplay] // 0x0000000180247B40-0x0000000180247B70
		private protected struct ObjectWrapper // TypeDefIndex: 7919
		{
			// Fields
			public T Element;
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <>c__DisplayClass6_0 // TypeDefIndex: 7920
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal static bool <.ctor>g__IsDefaultPolicy|6_0(ref <>c__DisplayClass6_0 param_0001064c);
	}
}
