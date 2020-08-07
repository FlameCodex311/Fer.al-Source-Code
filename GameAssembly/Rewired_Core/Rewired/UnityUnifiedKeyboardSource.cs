/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class UnityUnifiedKeyboardSource : IDisposable, IUnifiedKeyboardSource // TypeDefIndex: 6609
	{
		// Fields
		private const int dkbQwWEGdYvWqHgwDVFfqiIBuCI = 132; // Metadata: 0x00764DA8
		private static HardwareControllerMap_Game qGQYerJXPeWtuzKISCxSYKrxjAn; // 0x00
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x10
	
		// Properties
		public InputSource inputSource { get; } // 0x00000001810AA060-0x00000001810AA070 
		public HardwareControllerMap_Game hardwareMap { get; } // 0x00000001810A9FF0-0x00000001810AA060 
		public int buttonCount { get; } // 0x000000018040D5D0-0x000000018040D5E0 
	
		// Constructors
		public UnityUnifiedKeyboardSource(); // 0x00000001810A9F30-0x00000001810A9FF0
	
		// Methods
		public void UpdateInputData(ControllerDataUpdater dataUpdater); // 0x00000001810A9E50-0x00000001810A9F30
		public void Clear(); // 0x00000001803774A0-0x00000001803774B0
		private static HardwareControllerMap_Game ucxBBbNIZPrkEAlWZbXBqgYqHGL(); // 0x00000001810AA070-0x00000001810AA530
		public void Dispose(); // 0x00000001810A9C40-0x00000001810A9CB0
		~UnityUnifiedKeyboardSource(); // 0x0000000180409B40-0x0000000180409BE0
		protected virtual void Dispose(bool disposing); // 0x00000001810A9CB0-0x00000001810A9DD0
		public static ControllerElementType GetHardwareElementType(int elementIdentifierId); // 0x00000001810A9DD0-0x00000001810A9E50
	}
}
