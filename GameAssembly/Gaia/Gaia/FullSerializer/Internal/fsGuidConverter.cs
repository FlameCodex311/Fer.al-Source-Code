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
	public class fsGuidConverter : fsConverter // TypeDefIndex: 9311
	{
		// Constructors
		public fsGuidConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181517EA0-0x0000000181517F10
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001815180C0-0x00000001815181C0
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181517F50-0x00000001815180C0
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181517F10-0x0000000181517F50
	}
}
