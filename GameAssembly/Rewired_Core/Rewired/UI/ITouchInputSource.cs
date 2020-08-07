/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.UI
{
	public interface ITouchInputSource // TypeDefIndex: 6545
	{
		// Properties
		int playerId { get; }
		bool touchSupported { get; }
		int touchCount { get; }
	
		// Methods
		Touch GetTouch(int index);
	}
}
