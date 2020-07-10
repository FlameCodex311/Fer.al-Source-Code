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

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801435D0-0x0000000180143620
	public abstract class CustomControllerElementTargetSet // TypeDefIndex: 5805
	{
		// Properties
		internal abstract int targetCount { get; }
		internal abstract CustomControllerElementTarget this[int index] { get => default; }
	
		// Constructors
		protected CustomControllerElementTargetSet(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		internal abstract void ClearElementCaches();
	}
}
