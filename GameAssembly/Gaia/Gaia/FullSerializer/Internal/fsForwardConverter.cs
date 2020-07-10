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
	public class fsForwardConverter : fsConverter // TypeDefIndex: 9144
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x000000018138FE30-0x000000018138FE70
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818F21E0-0x00000001818F2240
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x00000001818F22B0-0x00000001818F2510
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001818F2780-0x00000001818F2990
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001818F2510-0x00000001818F2780
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818F2240-0x00000001818F22B0
	}
}
