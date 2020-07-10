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
	public class fsDateConverter : fsConverter // TypeDefIndex: 9141
	{
		// Fields
		private const string DefaultDateTimeFormatString = "o"; // Metadata: 0x007442FB
		private const string DateTimeOffsetFormatString = "o"; // Metadata: 0x00744300
	
		// Properties
		private string DateTimeFormatString { get; } // 0x00000001818EEF70-0x00000001818EEFE0 
	
		// Constructors
		public fsDateConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818EE770-0x00000001818EE880
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001818EED30-0x00000001818EEF70
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001818EE880-0x00000001818EED30
	}
}
