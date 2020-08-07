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
	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 9315
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001815215E0-0x00000001815216E0
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		private static bool UseBool(Type type); // 0x00000001815224B0-0x0000000181522520
		private static bool UseInt64(Type type); // 0x0000000181522630-0x0000000181522850
		private static bool UseUInt64(Type type); // 0x0000000181522910-0x0000000181522980
		private static bool UseDouble(Type type); // 0x0000000181522520-0x0000000181522630
		private static bool UseString(Type type); // 0x0000000181522850-0x0000000181522910
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181521EA0-0x00000001815224B0
		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType); // 0x00000001815216E0-0x0000000181521EA0
	}
}
