/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;

// Image 65: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7917-7929

namespace Microsoft.Extensions.ObjectPool
{
	public class StringBuilderPooledObjectPolicy : PooledObjectPolicy<StringBuilder> // TypeDefIndex: 7929
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <InitialCapacity>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <MaximumRetainedCapacity>k__BackingField; // 0x14
	
		// Properties
		public int InitialCapacity { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180387590-0x0000000180387930 
		public int MaximumRetainedCapacity { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FD2F0-0x00000001803FD300 
	
		// Constructors
		public StringBuilderPooledObjectPolicy(); // 0x00000001820EA600-0x00000001820EA650
	
		// Methods
		public override StringBuilder Create(); // 0x00000001820EA550-0x00000001820EA5B0
		public override bool Return(StringBuilder obj); // 0x00000001820EA5B0-0x00000001820EA600
	}
}
