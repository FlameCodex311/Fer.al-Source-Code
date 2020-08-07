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

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
	public interface IHardwareControllerMap // TypeDefIndex: 6215
	{
		// Methods
		string[] GetElementIdentifierNames();
		int[] GetElementIdentifierIds();
		bool ContainsElementIdentifier(int id);
		int GetMappableElementIdentifierInfo(out string[] names, out int[] ids);
	}
}
