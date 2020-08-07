/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
	public enum SYSTEM_CALLBACK_TYPE : uint // TypeDefIndex: 10082
	{
		DEVICELISTCHANGED = 1,
		DEVICELOST = 2,
		MEMORYALLOCATIONFAILED = 4,
		THREADCREATED = 8,
		BADDSPCONNECTION = 16,
		PREMIX = 32,
		POSTMIX = 64,
		ERROR = 128,
		MIDMIX = 256,
		THREADDESTROYED = 512,
		PREUPDATE = 1024,
		POSTUPDATE = 2048,
		RECORDLISTCHANGED = 4096,
		ALL = 4294967295
	}
}
