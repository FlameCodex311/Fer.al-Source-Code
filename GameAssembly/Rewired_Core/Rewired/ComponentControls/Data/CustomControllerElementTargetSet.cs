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

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801DF110-0x00000001801DF160
	public abstract class CustomControllerElementTargetSet // TypeDefIndex: 5964
	{
		// Properties
		internal abstract int targetCount { get; }
		internal abstract CustomControllerElementTarget this[int index] { get => default; }
	
		// Constructors
		protected CustomControllerElementTargetSet(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		internal abstract void ClearElementCaches();
	}
}
