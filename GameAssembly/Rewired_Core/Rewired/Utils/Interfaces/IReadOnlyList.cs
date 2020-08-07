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

namespace Rewired.Utils.Interfaces
{
	[CustomClassObfuscation] // 0x00000001801D2C60-0x00000001801D2CD0
	[CustomObfuscation] // 0x00000001801D2C60-0x00000001801D2CD0
	internal interface IReadOnlyList // TypeDefIndex: 6532
	{
		// Properties
		int Count { get; }
		object this[int index] { get => default; }
	
		// Methods
		int IndexOf(object value);
		bool Contains(object value);
	}
}
