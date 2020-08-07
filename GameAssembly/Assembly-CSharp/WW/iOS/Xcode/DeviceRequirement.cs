/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal class DeviceRequirement // TypeDefIndex: 16105
	{
		// Fields
		internal Dictionary<string, string> values; // 0x10
	
		// Constructors
		public DeviceRequirement(); // 0x000000018096EA80-0x000000018096EB40
	
		// Methods
		public DeviceRequirement AddDevice(string device); // 0x000000018096E780-0x000000018096E800
		public DeviceRequirement AddMemory(string memory); // 0x000000018096E900-0x000000018096E980
		public DeviceRequirement AddGraphics(string graphics); // 0x000000018096E800-0x000000018096E880
		public DeviceRequirement AddWidthClass(string sizeClass); // 0x000000018096EA00-0x000000018096EA80
		public DeviceRequirement AddHeightClass(string sizeClass); // 0x000000018096E880-0x000000018096E900
		public DeviceRequirement AddScale(string scale); // 0x000000018096E980-0x000000018096EA00
		public DeviceRequirement AddCustom(string key, string value); // 0x000000018096E6D0-0x000000018096E780
	}
}
