/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public abstract class fsBaseConverter // TypeDefIndex: 9112
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9113
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<fsDataType, string> <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001818E9720-0x00000001818E9780
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <FailExpectedType>b__6_0(fsDataType t); // 0x00000001818E9330-0x00000001818E93B0
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public virtual object CreateInstance(fsData data, Type storageType); // 0x00000001818EBFB0-0x00000001818EC160
		public virtual bool RequestCycleSupport(Type storageType); // 0x00000001818EC610-0x00000001818EC700
		public virtual bool RequestInheritanceSupport(Type storageType); // 0x00000001818EC700-0x00000001818EC770
		public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);
		protected fsResult FailExpectedType(fsData data, params /* 0x00000001800B36B0-0x00000001800B36C0 */ fsDataType[] types); // 0x00000001818EC160-0x00000001818EC610
		protected fsResult CheckType(fsData data, fsDataType type); // 0x00000001818EBB60-0x00000001818EBFB0
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x00000001818EB750-0x00000001818EB7F0
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x00000001818EB7F0-0x00000001818EBB60
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, string name, out T value);
	}
}
