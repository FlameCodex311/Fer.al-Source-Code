/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

namespace Rewired.Libraries.SharpDX.DirectInput
{
	[Guid] // 0x00000001800C35D0-0x00000001800C3600
	internal class DirectInput : DcpKHDPHjqjOAJSikkknHeBBaZZo // TypeDefIndex: 8230
	{
		// Nested types
		private static class GetDeviceCountHelper // TypeDefIndex: 8231
		{
			// Fields
			private static DirectInputEnumDevicesDelegate _callback; // 0x00
			private static IntPtr _callbackPointer; // 0x08
			private static int _count; // 0x10
	
			// Properties
			public static IntPtr callbackPointer { get; } // 0x0000000180419450-0x00000001804194B0 
	
			// Nested types
			[UnmanagedFunctionPointer] // 0x00000001800C38D0-0x00000001800C38F0
			private unsafe delegate int DirectInputEnumDevicesDelegate(void* deviceInstance, IntPtr data); // TypeDefIndex: 8232; 0x0000000180415DA0-0x0000000180416080
	
			// Constructors
			static GetDeviceCountHelper(); // 0x00000001804193A0-0x0000000180419450
	
			// Methods
			public static int GetCountAndClear(); // 0x00000001804192F0-0x00000001804193A0
			public static void Clear(); // 0x0000000180419230-0x0000000180419290
			[MonoPInvokeCallback] // 0x00000001800C3700-0x00000001800C3750
			private static unsafe int DirectInputEnumDevicesImpl(void* deviceInstance, IntPtr data); // 0x0000000180419290-0x00000001804192F0
		}
	
		// Constructors
		public DirectInput(); // 0x0000000180419100-0x0000000180419200
	
		// Methods
		public IList<AWARuLKFrIKzIKknTkXdungFUra> GetDevices(); // 0x0000000180418F60-0x0000000180418F70
		public IList<AWARuLKFrIKzIKknTkXdungFUra> GetDevices(irBeUaHArjzfFdeYfFNDILPfamaU deviceClass, EijBMMkCKwdFsvoVbRtrqhSAufV deviceEnumFlags); // 0x0000000180418F70-0x0000000180419100
		public int GetDeviceCount(irBeUaHArjzfFdeYfFNDILPfamaU deviceClass, EijBMMkCKwdFsvoVbRtrqhSAufV deviceEnumFlags); // 0x0000000180418D90-0x0000000180418F60
		private static unsafe extern int CreateDevice_(void* pIDirectInput8, void* rguid, void* lplpDirectInputDevice, void* pUnkOuter); // 0x00000001804188E0-0x00000001804189B0
		private static unsafe extern int EnumDevices_(void* pIDirectInput8, int dwDevType, void* lpCallback, void* pvRef, int dwFlags); // 0x0000000180418B30-0x0000000180418C10
		internal void CreateDevice(Guid arg0, out IntPtr arg1, DcpKHDPHjqjOAJSikkknHeBBaZZo arg2); // 0x00000001804189B0-0x0000000180418B30
		internal void EnumDevices(int arg0, lKGBmPQbRLXnhufbAfVpasHaJVkz arg1, IntPtr arg2, EijBMMkCKwdFsvoVbRtrqhSAufV arg3); // 0x0000000180418C10-0x0000000180418D90
	}
}
