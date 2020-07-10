/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800B82D0-0x00000001800B8320
	[CustomObfuscation] // 0x00000001800B82D0-0x00000001800B8320
	internal interface IControllerTemplateElement_Internal // TypeDefIndex: 5952
	{
		// Properties
		IControllerTemplate parent { get; }
		int elementCount { get; }
	
		// Methods
		IControllerTemplateElement GetElement(int index);
		int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
	}
}
