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
	public class fsForwardConverter : fsConverter // TypeDefIndex: 9310
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x00000001811AFBB0-0x00000001811AFBF0
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181517850-0x00000001815178B0
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x0000000181517920-0x0000000181517B20
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181517CF0-0x0000000181517EA0
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181517B20-0x0000000181517CF0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001815178B0-0x0000000181517920
	}
}
