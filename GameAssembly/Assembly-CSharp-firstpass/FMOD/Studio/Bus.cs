/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD.Studio
{
	public struct Bus // TypeDefIndex: 9819
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x0000000180310C00-0x0000000180310CB0
		public RESULT getPath(out string path); // 0x0000000180310D70-0x0000000180310D80
		public RESULT getVolume(out float volume); // 0x0000000180310E40-0x0000000180310F00
		public RESULT getVolume(out float volume, out float finalvolume); // 0x0000000180310F00-0x0000000180310F10
		public RESULT setVolume(float volume); // 0x0000000180311230-0x00000001803112E0
		public RESULT getPaused(out bool paused); // 0x0000000180310D80-0x0000000180310E40
		public RESULT setPaused(bool paused); // 0x0000000180311180-0x0000000180311230
		public RESULT getMute(out bool mute); // 0x0000000180310CB0-0x0000000180310D70
		public RESULT setMute(bool mute); // 0x00000001803110D0-0x0000000180311180
		public RESULT stopAllEvents(STOP_MODE mode); // 0x00000001803112E0-0x0000000180311390
		public RESULT lockChannelGroup(); // 0x0000000180311030-0x00000001803110D0
		public RESULT unlockChannelGroup(); // 0x0000000180311390-0x0000000180311430
		public RESULT getChannelGroup(out ChannelGroup group); // 0x0000000180310B50-0x0000000180310C00
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus); // 0x0000000181EE7190-0x0000000181EE7230
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id); // 0x0000000181EE6DD0-0x0000000181EE6E80
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved); // 0x0000000181EE6F40-0x0000000181EE7010
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume); // 0x0000000181EE70D0-0x0000000181EE7190
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume); // 0x0000000181EE7430-0x0000000181EE74E0
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused); // 0x0000000181EE7010-0x0000000181EE70D0
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused); // 0x0000000181EE7380-0x0000000181EE7430
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute); // 0x0000000181EE6E80-0x0000000181EE6F40
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute); // 0x0000000181EE72D0-0x0000000181EE7380
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode); // 0x0000000181EE74E0-0x0000000181EE7590
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus); // 0x0000000181EE7230-0x0000000181EE72D0
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus); // 0x0000000181EE7590-0x0000000181EE7B00
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group); // 0x0000000181EE6D20-0x0000000181EE6DD0
		public bool hasHandle(); // 0x0000000180310F10-0x0000000180310F50
		public void clearHandle(); // 0x0000000180310B10-0x0000000180310B50
		public bool isValid(); // 0x0000000180310F50-0x0000000180311030
	}
}
