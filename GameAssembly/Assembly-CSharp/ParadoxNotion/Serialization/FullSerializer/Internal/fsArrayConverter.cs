/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 15324
	{
		// Constructors
		public fsArrayConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x000000018138A8C0-0x000000018138A8F0
		public override bool RequestCycleSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override bool RequestInheritanceSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x000000018138ACF0-0x000000018138B070
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x000000018138A980-0x000000018138ACF0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018138A8F0-0x000000018138A980
	}
}
