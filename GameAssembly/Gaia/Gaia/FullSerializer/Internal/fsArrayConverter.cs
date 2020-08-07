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
	public class fsArrayConverter : fsConverter // TypeDefIndex: 9306
	{
		// Constructors
		public fsArrayConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001806DA5F0-0x00000001806DA610
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181511120-0x0000000181511490
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181510DB0-0x0000000181511120
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181510D40-0x0000000181510DB0
	}
}
