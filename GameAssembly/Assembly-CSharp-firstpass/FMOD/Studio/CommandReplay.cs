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
	public struct CommandReplay // TypeDefIndex: 10276
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getSystem(out System system); // 0x000000018011E5C0-0x000000018011E650
		public RESULT getLength(out float length); // 0x000000018011E400-0x000000018011E490
		public RESULT getCommandCount(out int count); // 0x000000018011E220-0x000000018011E2B0
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info); // 0x000000018011E2B0-0x000000018011E350
		public RESULT getCommandString(int commandIndex, out string buffer); // 0x000000018011E350-0x000000018011E360
		public RESULT getCommandAtTime(float time, out int commandIndex); // 0x000000018011E180-0x000000018011E220
		public RESULT setBankPath(string bankPath); // 0x000000018011E980-0x000000018011E990
		public RESULT start(); // 0x000000018011EC90-0x000000018011ED10
		public RESULT stop(); // 0x000000018011ED10-0x000000018011EE60
		public RESULT seekToTime(float time); // 0x000000018011E8F0-0x000000018011E980
		public RESULT seekToCommand(int commandIndex); // 0x000000018011E860-0x000000018011E8F0
		public RESULT getPaused(out bool paused); // 0x000000018011E490-0x000000018011E530
		public RESULT setPaused(bool paused); // 0x000000018011EB70-0x000000018011EC00
		public RESULT getPlaybackState(out PLAYBACK_STATE state); // 0x000000018011E530-0x000000018011E5C0
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime); // 0x000000018011E360-0x000000018011E400
		public RESULT release(); // 0x000000018011E7E0-0x000000018011E860
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback); // 0x000000018011EA30-0x000000018011EAD0
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback); // 0x000000018011EAD0-0x000000018011EB70
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback); // 0x000000018011E990-0x000000018011EA30
		public RESULT getUserData(out IntPtr userdata); // 0x000000018011E650-0x000000018011E6E0
		public RESULT setUserData(IntPtr userdata); // 0x000000018011EC00-0x000000018011EC90
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay); // 0x0000000181BDAA90-0x0000000181BDAB10
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system); // 0x0000000181BDA970-0x0000000181BDAA00
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length); // 0x0000000181BDA7B0-0x0000000181BDA840
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count); // 0x0000000181BDA540-0x0000000181BDA5D0
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info); // 0x0000000181BDA5D0-0x0000000181BDA670
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length); // 0x0000000181BDA670-0x0000000181BDA710
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex); // 0x0000000181BDA4A0-0x0000000181BDA540
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath); // 0x0000000181BDACB0-0x0000000181BDAD50
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay); // 0x0000000181BDB050-0x0000000181BDB0D0
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay); // 0x0000000181BDB0D0-0x0000000181BDB4F0
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time); // 0x0000000181BDAC20-0x0000000181BDACB0
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex); // 0x0000000181BDAB90-0x0000000181BDAC20
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused); // 0x0000000181BDA840-0x0000000181BDA8E0
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused); // 0x0000000181BDAF30-0x0000000181BDAFC0
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state); // 0x0000000181BDA8E0-0x0000000181BDA970
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime); // 0x0000000181BDA710-0x0000000181BDA7B0
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay); // 0x0000000181BDAB10-0x0000000181BDAB90
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback); // 0x0000000181BDADF0-0x0000000181BDAE90
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback); // 0x0000000181BDAE90-0x0000000181BDAF30
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback); // 0x0000000181BDAD50-0x0000000181BDADF0
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata); // 0x0000000181BDAA00-0x0000000181BDAA90
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata); // 0x0000000181BDAFC0-0x0000000181BDB050
		public bool hasHandle(); // 0x000000018011E6E0-0x000000018011E720
		public void clearHandle(); // 0x000000018011E140-0x000000018011E180
		public bool isValid(); // 0x000000018011E720-0x000000018011E7E0
	}
}
