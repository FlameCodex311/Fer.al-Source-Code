/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD.Studio
{
	[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
	public enum EVENT_CALLBACK_TYPE : uint // TypeDefIndex: 10262
	{
		CREATED = 1,
		DESTROYED = 2,
		STARTING = 4,
		STARTED = 8,
		RESTARTED = 16,
		STOPPED = 32,
		START_FAILED = 64,
		CREATE_PROGRAMMER_SOUND = 128,
		DESTROY_PROGRAMMER_SOUND = 256,
		PLUGIN_CREATED = 512,
		PLUGIN_DESTROYED = 1024,
		TIMELINE_MARKER = 2048,
		TIMELINE_BEAT = 4096,
		SOUND_PLAYED = 8192,
		SOUND_STOPPED = 16384,
		REAL_TO_VIRTUAL = 32768,
		VIRTUAL_TO_REAL = 65536,
		ALL = 4294967295
	}
}
