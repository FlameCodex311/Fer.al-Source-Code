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

// Image 64: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7751-7763

namespace Microsoft.Extensions.ObjectPool
{
	public class StringBuilderPooledObjectPolicy : PooledObjectPolicy<StringBuilder> // TypeDefIndex: 7763
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <InitialCapacity>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <MaximumRetainedCapacity>k__BackingField; // 0x14
	
		// Properties
		public int InitialCapacity { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
		public int MaximumRetainedCapacity { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180372360-0x0000000180372370 
	
		// Constructors
		public StringBuilderPooledObjectPolicy(); // 0x0000000180E06410-0x0000000180E06460
	
		// Methods
		public override StringBuilder Create(); // 0x0000000180E06360-0x0000000180E063C0
		public override bool Return(StringBuilder obj); // 0x0000000180E063C0-0x0000000180E06410
	}
}
