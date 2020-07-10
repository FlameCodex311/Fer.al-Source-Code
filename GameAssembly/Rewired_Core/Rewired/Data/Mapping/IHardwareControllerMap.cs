/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
	public interface IHardwareControllerMap // TypeDefIndex: 6056
	{
		// Methods
		string[] GetElementIdentifierNames();
		int[] GetElementIdentifierIds();
		bool ContainsElementIdentifier(int id);
		int GetMappableElementIdentifierInfo(out string[] names, out int[] ids);
	}
}
