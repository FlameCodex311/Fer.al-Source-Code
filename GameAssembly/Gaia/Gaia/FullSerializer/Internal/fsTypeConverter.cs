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
	public class fsTypeConverter : fsConverter // TypeDefIndex: 9317
	{
		// Constructors
		public fsTypeConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181523970-0x0000000181523A00
		public override bool RequestCycleSupport(Type type); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type type); // 0x0000000180380950-0x0000000180380960
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181523D20-0x0000000181523E40
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181523A00-0x0000000181523D20
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000180766BD0-0x0000000180766BE0
	}
}
