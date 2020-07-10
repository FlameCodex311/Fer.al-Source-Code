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
	public class DefaultObjectPoolProvider : ObjectPoolProvider // TypeDefIndex: 7755
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <MaximumRetained>k__BackingField; // 0x10
	
		// Properties
		public int MaximumRetained { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
	
		// Constructors
		public DefaultObjectPoolProvider(); // 0x0000000180E06270-0x0000000180E062A0
	
		// Methods
		public override ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy);
	}
}
