/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD.Studio
{
	public struct Bus // TypeDefIndex: 10273
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x000000018011DA70-0x000000018011DB00
		public RESULT getPath(out string path); // 0x000000018011DBA0-0x000000018011DBB0
		public RESULT getVolume(out float volume); // 0x000000018011DC50-0x000000018011DCF0
		public RESULT getVolume(out float volume, out float finalvolume); // 0x000000018011DCF0-0x000000018011DD00
		public RESULT setVolume(float volume); // 0x000000018011DFA0-0x000000018011E030
		public RESULT getPaused(out bool paused); // 0x000000018011DBB0-0x000000018011DC50
		public RESULT setPaused(bool paused); // 0x000000018011DF10-0x000000018011DFA0
		public RESULT getMute(out bool mute); // 0x000000018011DB00-0x000000018011DBA0
		public RESULT setMute(bool mute); // 0x000000018011DE80-0x000000018011DF10
		public RESULT stopAllEvents(STOP_MODE mode); // 0x000000018011E030-0x000000018011E0C0
		public RESULT lockChannelGroup(); // 0x000000018011DE00-0x000000018011DE80
		public RESULT unlockChannelGroup(); // 0x000000018011E0C0-0x000000018011E140
		public RESULT getChannelGroup(out ChannelGroup group); // 0x000000018011D9E0-0x000000018011DA70
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus); // 0x0000000181BD8D60-0x0000000181BD8DE0
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id); // 0x0000000181BD8A40-0x0000000181BD8AD0
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved); // 0x0000000181BD8B70-0x0000000181BD8C20
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume); // 0x0000000181BD8CC0-0x0000000181BD8D60
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume); // 0x0000000181BD8F80-0x0000000181BD9010
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused); // 0x0000000181BD8C20-0x0000000181BD8CC0
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused); // 0x0000000181BD8EF0-0x0000000181BD8F80
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute); // 0x0000000181BD8AD0-0x0000000181BD8B70
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute); // 0x0000000181BD8E60-0x0000000181BD8EF0
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode); // 0x0000000181BD9010-0x0000000181BD90A0
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus); // 0x0000000181BD8DE0-0x0000000181BD8E60
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus); // 0x0000000181BD90A0-0x0000000181BD9630
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group); // 0x0000000181BD89B0-0x0000000181BD8A40
		public bool hasHandle(); // 0x000000018011DD00-0x000000018011DD40
		public void clearHandle(); // 0x000000018011D9A0-0x000000018011D9E0
		public bool isValid(); // 0x000000018011DD40-0x000000018011DE00
	}
}
