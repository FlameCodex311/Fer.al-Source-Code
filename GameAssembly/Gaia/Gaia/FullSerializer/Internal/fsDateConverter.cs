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
	public class fsDateConverter : fsConverter // TypeDefIndex: 9307
	{
		// Fields
		private const string DefaultDateTimeFormatString = "o"; // Metadata: 0x00778FE9
		private const string DateTimeOffsetFormatString = "o"; // Metadata: 0x00778FEE
	
		// Properties
		private string DateTimeFormatString { get; } // 0x0000000181514A60-0x0000000181514AD0 
	
		// Constructors
		public fsDateConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001815142B0-0x00000001815143C0
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181514820-0x0000000181514A60
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001815143C0-0x0000000181514820
	}
}
