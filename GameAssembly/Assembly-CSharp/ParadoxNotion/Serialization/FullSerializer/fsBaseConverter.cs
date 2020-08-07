/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public abstract class fsBaseConverter // TypeDefIndex: 15905
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15906
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<fsDataType, string> <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001811AC030-0x00000001811AC090
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <FailExpectedType>b__6_0(fsDataType t); // 0x00000001811ABA90-0x00000001811ABB10
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public virtual object CreateInstance(fsData data, Type storageType); // 0x00000001811AC900-0x00000001811ACAA0
		public virtual bool RequestCycleSupport(Type storageType); // 0x00000001811ACF20-0x00000001811ACFD0
		public virtual bool RequestInheritanceSupport(Type storageType); // 0x00000001811ACFD0-0x00000001811AD000
		public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);
		protected fsResult FailExpectedType(fsData data, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ fsDataType[] types); // 0x00000001811ACAA0-0x00000001811ACF20
		protected fsResult CheckType(fsData data, fsDataType type); // 0x00000001811AC4E0-0x00000001811AC900
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x00000001811AC440-0x00000001811AC4E0
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x00000001811AC0F0-0x00000001811AC440
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value);
	}
}
