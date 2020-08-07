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
	public class fsNullableConverter : fsConverter // TypeDefIndex: 9314
	{
		// Constructors
		public fsNullableConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001815200B0-0x0000000181520180
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181520200-0x0000000181520280
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181520180-0x0000000181520200
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000180766BD0-0x0000000180766BE0
	}
}
