/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Attributes
{
	[AttributeUsage] // 0x00000001801CE9A0-0x00000001801CEA10
	[CustomClassObfuscation] // 0x00000001801CE9A0-0x00000001801CEA10
	[CustomObfuscation] // 0x00000001801CE9A0-0x00000001801CEA10
	public class SerializationTypeAttribute : Attribute // TypeDefIndex: 5879
	{
		// Fields
		private SerializationType _serializationType; // 0x10
	
		// Properties
		public SerializationType serializationType { get; } // 0x0000000180387590-0x0000000180387930 
	
		// Nested types
		public enum SerializationType // TypeDefIndex: 5880
		{
			Default = 0,
			Object = 1
		}
	
		// Constructors
		public SerializationTypeAttribute(SerializationType serializationType); // 0x00000001805D0C50-0x00000001805D0C80
	}
}
