/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Interfaces
{
	[CustomClassObfuscation] // 0x00000001801CE700-0x00000001801CE750
	[CustomObfuscation] // 0x00000001801CE700-0x00000001801CE750
	internal interface IUnifiedMouseSource // TypeDefIndex: 6522
	{
		// Properties
		InputSource inputSource { get; }
		HardwareControllerMap_Game hardwareMap { get; }
		int axisCount { get; }
		int buttonCount { get; }
		Vector2 mousePosition { get; }
	
		// Methods
		void UpdateInputData(ControllerDataUpdater dataUpdater);
		void Clear();
	}
}
