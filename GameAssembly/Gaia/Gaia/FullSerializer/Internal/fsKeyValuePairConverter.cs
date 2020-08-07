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
	public class fsKeyValuePairConverter : fsConverter // TypeDefIndex: 9313
	{
		// Constructors
		public fsKeyValuePairConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x000000018151D510-0x000000018151D5E0
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x000000018151D5E0-0x000000018151D9E0
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x000000018151D9E0-0x000000018151DE30
	}
}
