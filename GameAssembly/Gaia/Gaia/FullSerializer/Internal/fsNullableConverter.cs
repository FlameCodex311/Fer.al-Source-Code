/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsNullableConverter : fsConverter // TypeDefIndex: 9148
	{
		// Constructors
		public fsNullableConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818FB310-0x00000001818FB3E0
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001818FB460-0x00000001818FB4E0
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001818FB3E0-0x00000001818FB460
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000180BCE250-0x0000000180BCE260
	}
}
