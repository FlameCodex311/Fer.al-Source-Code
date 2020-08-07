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
	public class DefaultObjectPoolProvider : ObjectPoolProvider // TypeDefIndex: 7921
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <MaximumRetained>k__BackingField; // 0x10
	
		// Properties
		public int MaximumRetained { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180387590-0x0000000180387930 
	
		// Constructors
		public DefaultObjectPoolProvider(); // 0x00000001820EA460-0x00000001820EA490
	
		// Methods
		public override ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy);
	}
}
