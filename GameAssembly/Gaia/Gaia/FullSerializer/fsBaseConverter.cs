/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public abstract class fsBaseConverter // TypeDefIndex: 9284
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9285
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<fsDataType, string> <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018150F820-0x000000018150F880
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <FailExpectedType>b__6_0(fsDataType t); // 0x000000018150F590-0x000000018150F610
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public virtual object CreateInstance(fsData data, Type storageType); // 0x0000000181511BE0-0x0000000181511D80
		public virtual bool RequestCycleSupport(Type storageType); // 0x00000001815121A0-0x0000000181512290
		public virtual bool RequestInheritanceSupport(Type storageType); // 0x0000000181512290-0x0000000181512300
		public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);
		protected fsResult FailExpectedType(fsData data, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ fsDataType[] types); // 0x0000000181511D80-0x00000001815121A0
		protected fsResult CheckType(fsData data, fsDataType type); // 0x0000000181511820-0x0000000181511BE0
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x0000000181511490-0x0000000181511530
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x0000000181511530-0x0000000181511820
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, string name, out T value);
	}
}
