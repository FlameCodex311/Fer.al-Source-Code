/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	internal class DeviceRequirement // TypeDefIndex: 15725
	{
		// Fields
		internal Dictionary<string, string> values; // 0x10
	
		// Constructors
		public DeviceRequirement(); // 0x0000000181675840-0x0000000181675900
	
		// Methods
		public DeviceRequirement AddDevice(string device); // 0x0000000181675540-0x00000001816755C0
		public DeviceRequirement AddMemory(string memory); // 0x00000001816756C0-0x0000000181675740
		public DeviceRequirement AddGraphics(string graphics); // 0x00000001816755C0-0x0000000181675640
		public DeviceRequirement AddWidthClass(string sizeClass); // 0x00000001816757C0-0x0000000181675840
		public DeviceRequirement AddHeightClass(string sizeClass); // 0x0000000181675640-0x00000001816756C0
		public DeviceRequirement AddScale(string scale); // 0x0000000181675740-0x00000001816757C0
		public DeviceRequirement AddCustom(string key, string value); // 0x0000000181675490-0x0000000181675540
	}
}
