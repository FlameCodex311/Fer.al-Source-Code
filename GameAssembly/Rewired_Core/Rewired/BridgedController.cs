/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class BridgedController : BridgedControllerHWInfo // TypeDefIndex: 6388
	{
		// Fields
		public IInputManagerJoystickPublic sourceJoystick; // 0xB8
		public HardwareControllerMap_Game gameHardwareMap; // 0xC0
		public Guid controllerTypeGuid; // 0xC8
		public Controller.Extension controllerExtension; // 0xD8
		public string instanceName; // 0xE0
		public string productName; // 0xE8
		public bool isXInputDevice; // 0xF0
		public int axisCount; // 0xF4
		public int buttonCount; // 0xF8
		public bool[] isButtonPressureSensitive; // 0x100
		public UnknownControllerHat[] unknownControllerHats; // 0x108
		public CustomInputSource customInputSource; // 0x110
	
		// Properties
		public bool isUnknownController { get; } // 0x000000018142E730-0x000000018142E7C0 
	
		// Constructors
		public BridgedController(); // 0x000000018036B6C0-0x000000018036B6D0
	}
}
