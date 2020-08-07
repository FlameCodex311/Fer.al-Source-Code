/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal abstract class HIDControllerElement // TypeDefIndex: 6554
	{
		// Fields
		public readonly byte reportId; // 0x10
		public readonly HIDInfo hidInfo; // 0x18
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		internal class HIDInfo // TypeDefIndex: 6555
		{
			// Fields
			public ushort usagePage; // 0x10
			public ushort usage; // 0x12
			public int dataIndex; // 0x14
			public int bitSize; // 0x18
			public int logicalMin; // 0x1C
			public int logicalMax; // 0x20
			public int physicalMin; // 0x24
			public int physicalMax; // 0x28
			public uint units; // 0x2C
			public uint unitsExp; // 0x30
	
			// Constructors
			public HIDInfo(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public HIDControllerElement(byte reportId, HIDInfo hidInfo); // 0x0000000180E5D660-0x0000000180E5D6C0
	
		// Methods
		public abstract void UpdateValue(NativeBuffer inputReport, float timestamp);
	}
}
