/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	[CustomObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	internal interface IHardwareControllerMap_Internal // TypeDefIndex: 6216
	{
		// Properties
		IEnumerable<IControllerElementIdentifierCommon_Internal> ElementIdentifiers { get; }
	
		// Methods
		IControllerElementIdentifierCommon_Internal GetElementIdentifier(int id);
	}
}
