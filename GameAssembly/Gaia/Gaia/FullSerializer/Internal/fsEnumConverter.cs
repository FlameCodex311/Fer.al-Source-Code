/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public class fsEnumConverter : fsConverter // TypeDefIndex: 9309
	{
		// Constructors
		public fsEnumConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181516BE0-0x0000000181516C50
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181516C50-0x0000000181516CD0
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001815173B0-0x0000000181517850
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181516CD0-0x00000001815173B0
		private static bool ArrayContains<T>(T[] values, T value);
	}
}
