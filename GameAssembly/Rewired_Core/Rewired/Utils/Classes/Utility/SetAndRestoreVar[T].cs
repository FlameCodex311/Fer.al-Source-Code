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

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal struct SetAndRestoreVar<T> : IDisposable // TypeDefIndex: 7073
	{
		// Fields
		private readonly Action<T> ZQjINDOgbIHAIdHFjBVXkNjagCLR;
		private readonly T PewPHQRLoLUCouPbqVNooCsBpZx;
	
		// Constructors
		public SetAndRestoreVar(T oldValue, T newValue, Action<T> setValueDelegate);
	
		// Methods
		public void Dispose();
	}
}
