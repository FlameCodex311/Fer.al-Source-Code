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
	public class fsReflectedConverter : fsConverter // TypeDefIndex: 9316
	{
		// Constructors
		public fsReflectedConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181522980-0x0000000181522A50
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181522DE0-0x0000000181523070
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181522AC0-0x0000000181522DE0
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181522A50-0x0000000181522AC0
	}
}
