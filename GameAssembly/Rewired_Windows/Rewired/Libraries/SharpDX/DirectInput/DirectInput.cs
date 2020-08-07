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

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

namespace Rewired.Libraries.SharpDX.DirectInput
{
	[Guid] // 0x0000000180223890-0x00000001802238C0
	internal class DirectInput : DcpKHDPHjqjOAJSikkknHeBBaZZo // TypeDefIndex: 8396
	{
		// Nested types
		private static class GetDeviceCountHelper // TypeDefIndex: 8397
		{
			// Fields
			private static DirectInputEnumDevicesDelegate _callback; // 0x00
			private static IntPtr _callbackPointer; // 0x08
			private static int _count; // 0x10
	
			// Properties
			public static IntPtr callbackPointer { get; } // 0x0000000180825230-0x0000000180825290 
	
			// Nested types
			[UnmanagedFunctionPointer] // 0x0000000180205E50-0x0000000180205E70
			private unsafe delegate int DirectInputEnumDevicesDelegate(void* deviceInstance, IntPtr data); // TypeDefIndex: 8398; 0x0000000180821D80-0x0000000180822090
	
			// Constructors
			static GetDeviceCountHelper(); // 0x0000000180825180-0x0000000180825230
	
			// Methods
			public static int GetCountAndClear(); // 0x00000001808250D0-0x0000000180825180
			public static void Clear(); // 0x0000000180825010-0x0000000180825070
			[MonoPInvokeCallback] // 0x0000000180223A40-0x0000000180223A90
			private static unsafe int DirectInputEnumDevicesImpl(void* deviceInstance, IntPtr data); // 0x0000000180825070-0x00000001808250D0
		}
	
		// Constructors
		public DirectInput(); // 0x0000000180824EE0-0x0000000180824FE0
	
		// Methods
		public IList<AWARuLKFrIKzIKknTkXdungFUra> GetDevices(); // 0x0000000180824D50-0x0000000180824D60
		public IList<AWARuLKFrIKzIKknTkXdungFUra> GetDevices(irBeUaHArjzfFdeYfFNDILPfamaU deviceClass, EijBMMkCKwdFsvoVbRtrqhSAufV deviceEnumFlags); // 0x0000000180824D60-0x0000000180824EE0
		public int GetDeviceCount(irBeUaHArjzfFdeYfFNDILPfamaU deviceClass, EijBMMkCKwdFsvoVbRtrqhSAufV deviceEnumFlags); // 0x0000000180824B80-0x0000000180824D50
		private static unsafe extern int CreateDevice_(void* pIDirectInput8, void* rguid, void* lplpDirectInputDevice, void* pUnkOuter); // 0x0000000180824760-0x0000000180824810
		private static unsafe extern int EnumDevices_(void* pIDirectInput8, int dwDevType, void* lpCallback, void* pvRef, int dwFlags); // 0x0000000180824970-0x0000000180824A20
		internal void CreateDevice(Guid arg0, out IntPtr arg1, DcpKHDPHjqjOAJSikkknHeBBaZZo arg2); // 0x0000000180824810-0x0000000180824970
		internal void EnumDevices(int arg0, lKGBmPQbRLXnhufbAfVpasHaJVkz arg1, IntPtr arg2, EijBMMkCKwdFsvoVbRtrqhSAufV arg3); // 0x0000000180824A20-0x0000000180824B80
	}
}
