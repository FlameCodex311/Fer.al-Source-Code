/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsEnumConverter : fsConverter // TypeDefIndex: 15929
	{
		// Constructors
		public fsEnumConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001811AE780-0x00000001811AE7B0
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001811AE7B0-0x00000001811AE830
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001811AEEA0-0x00000001811AF340
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001811AE830-0x00000001811AEEA0
		private static bool ArrayContains<T>(T[] values, T value);
	}
}
