/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 65: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7917-7929

namespace Microsoft.Extensions.ObjectPool
{
	public abstract class ObjectPoolProvider // TypeDefIndex: 7926
	{
		// Constructors
		protected ObjectPoolProvider(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy)
			where T : class;
	}
}
