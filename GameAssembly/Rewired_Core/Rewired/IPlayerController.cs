/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CE700-0x00000001801CE750
	[CustomObfuscation] // 0x00000001801CE700-0x00000001801CE750
	internal interface IPlayerController // TypeDefIndex: 6033
	{
		// Properties
		bool enabled { get; set; }
		int playerId { get; set; }
		IList<PlayerController.Button> buttons { get; }
		IList<PlayerController.Axis> axes { get; }
		IList<PlayerController.Element> elements { get; }
		int buttonCount { get; }
		int axisCount { get; }
		int elementCount { get; }
	
		// Events
		event Action<int, bool> ButtonStateChangedEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event Action<int, float> AxisValueChangedEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event Action<bool> EnabledStateChangedEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		bool GetButton(int index);
		bool GetButtonDown(int index);
		bool GetButtonUp(int index);
		float GetAxis(int index);
		float GetAxisRaw(int index);
		PlayerController.Element GetElement(int index);
		T GetElement<T>(int index)
			where T : PlayerController.Element;
	}
}
