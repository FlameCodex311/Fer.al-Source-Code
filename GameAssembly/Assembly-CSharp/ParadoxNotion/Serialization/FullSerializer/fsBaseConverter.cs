/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public abstract class fsBaseConverter // TypeDefIndex: 15299
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15300
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<fsDataType, string> <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018138A860-0x000000018138A8C0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <FailExpectedType>b__6_0(fsDataType t); // 0x000000018138A610-0x000000018138A690
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public virtual object CreateInstance(fsData data, Type storageType); // 0x000000018138B810-0x000000018138B9C0
		public virtual bool RequestCycleSupport(Type storageType); // 0x000000018138BE10-0x000000018138BED0
		public virtual bool RequestInheritanceSupport(Type storageType); // 0x000000018138BED0-0x000000018138BF00
		public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);
		protected fsResult FailExpectedType(fsData data, params /* 0x00000001800B36B0-0x00000001800B36C0 */ fsDataType[] types); // 0x000000018138B9C0-0x000000018138BE10
		protected fsResult CheckType(fsData data, fsDataType type); // 0x000000018138B420-0x000000018138B810
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x000000018138B380-0x000000018138B420
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x000000018138B070-0x000000018138B380
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value);
	}
}
