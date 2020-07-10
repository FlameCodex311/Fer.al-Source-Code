/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 64: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7751-7763

namespace Microsoft.Extensions.ObjectPool
{
	public abstract class ObjectPoolProvider // TypeDefIndex: 7760
	{
		// Constructors
		protected ObjectPoolProvider(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public abstract ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy)
			where T : class;
	}
}
