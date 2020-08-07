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
	[CustomClassObfuscation] // 0x00000001801CE320-0x00000001801CE390
	[CustomObfuscation] // 0x00000001801CE320-0x00000001801CE390
	internal interface IReadOnlyList<T> : IReadOnlyList // TypeDefIndex: 6533
	{
		// Properties
		T this[int index] { get => default; }
	
		// Methods
		int IndexOf(T value);
		bool Contains(T value);
	}
}
