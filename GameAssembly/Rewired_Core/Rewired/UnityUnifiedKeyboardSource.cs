/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class UnityUnifiedKeyboardSource : IDisposable, IUnifiedKeyboardSource // TypeDefIndex: 6450
	{
		// Fields
		private const int dkbQwWEGdYvWqHgwDVFfqiIBuCI = 132; // Metadata: 0x0073010B
		private static HardwareControllerMap_Game qGQYerJXPeWtuzKISCxSYKrxjAn; // 0x00
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x10
	
		// Properties
		public InputSource inputSource { get; } // 0x00000001807B5410-0x00000001807B5420 
		public HardwareControllerMap_Game hardwareMap { get; } // 0x00000001807B53A0-0x00000001807B5410 
		public int buttonCount { get; } // 0x000000018035E110-0x000000018035E120 
	
		// Constructors
		public UnityUnifiedKeyboardSource(); // 0x00000001807B52E0-0x00000001807B53A0
	
		// Methods
		public void UpdateInputData(ControllerDataUpdater dataUpdater); // 0x00000001807B5200-0x00000001807B52E0
		public void Clear(); // 0x00000001803581E0-0x00000001803581F0
		private static HardwareControllerMap_Game ucxBBbNIZPrkEAlWZbXBqgYqHGL(); // 0x00000001807B5420-0x00000001807B5900
		public void Dispose(); // 0x00000001807B4FF0-0x00000001807B5060
		~UnityUnifiedKeyboardSource(); // 0x000000018035A660-0x000000018035A700
		protected virtual void Dispose(bool disposing); // 0x00000001807B5060-0x00000001807B5180
		public static ControllerElementType GetHardwareElementType(int elementIdentifierId); // 0x00000001807B5180-0x00000001807B5200
	}
}
