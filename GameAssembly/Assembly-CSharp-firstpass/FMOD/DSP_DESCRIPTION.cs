/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct DSP_DESCRIPTION // TypeDefIndex: 10185
	{
		// Fields
		public uint pluginsdkversion; // 0x00
		public char[] name; // 0x08
		public uint version; // 0x10
		public int numinputbuffers; // 0x14
		public int numoutputbuffers; // 0x18
		public DSP_CREATECALLBACK create; // 0x20
		public DSP_RELEASECALLBACK release; // 0x28
		public DSP_RESETCALLBACK reset; // 0x30
		public DSP_READCALLBACK read; // 0x38
		public DSP_PROCESS_CALLBACK process; // 0x40
		public DSP_SETPOSITIONCALLBACK setposition; // 0x48
		public int numparameters; // 0x50
		public IntPtr paramdesc; // 0x58
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat; // 0x60
		public DSP_SETPARAM_INT_CALLBACK setparameterint; // 0x68
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool; // 0x70
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata; // 0x78
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat; // 0x80
		public DSP_GETPARAM_INT_CALLBACK getparameterint; // 0x88
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool; // 0x90
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata; // 0x98
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess; // 0xA0
		public IntPtr userdata; // 0xA8
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register; // 0xB0
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister; // 0xB8
		public DSP_SYSTEM_MIX_CALLBACK sys_mix; // 0xC0
	}
}
