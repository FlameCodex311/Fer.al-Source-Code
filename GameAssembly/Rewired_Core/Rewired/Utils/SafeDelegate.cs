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

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal abstract class SafeDelegate : ICloneable // TypeDefIndex: 7024
	{
		// Fields
		private static Action<Exception> OwiIYqXnLNGRcScGBdiepSAYgjUD; // 0x00
	
		// Properties
		internal abstract int Count { get; }
		internal abstract Action<Exception> ExceptionHandler { get; set; }
		internal static Action<Exception> S_ExceptionHandler { get; set; } // 0x0000000181461A40-0x0000000181461A80 0x0000000181461A80-0x0000000181461AC0
	
		// Constructors
		protected SafeDelegate(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		internal abstract void RemoveDelegateOrAllDelegatesFromAnObject(object obj);
		internal abstract void Clear();
		public abstract object Clone();
	}
}
