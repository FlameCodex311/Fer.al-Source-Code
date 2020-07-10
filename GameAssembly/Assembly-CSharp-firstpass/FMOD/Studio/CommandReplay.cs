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
	public struct CommandReplay // TypeDefIndex: 9822
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getSystem(out System system); // 0x0000000180311990-0x0000000180311A40
		public RESULT getLength(out float length); // 0x0000000180311770-0x0000000180311820
		public RESULT getCommandCount(out int count); // 0x0000000180311530-0x00000001803115E0
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info); // 0x00000001803115E0-0x00000001803116A0
		public RESULT getCommandString(int commandIndex, out string buffer); // 0x00000001803116A0-0x00000001803116B0
		public RESULT getCommandAtTime(float time, out int commandIndex); // 0x0000000180311470-0x0000000180311530
		public RESULT setBankPath(string bankPath); // 0x0000000180311E10-0x0000000180311E20
		public RESULT start(); // 0x00000001803121C0-0x0000000180312260
		public RESULT stop(); // 0x0000000180312260-0x0000000180312300
		public RESULT seekToTime(float time); // 0x0000000180311D60-0x0000000180311E10
		public RESULT seekToCommand(int commandIndex); // 0x0000000180311CB0-0x0000000180311D60
		public RESULT getPaused(out bool paused); // 0x0000000180311820-0x00000001803118E0
		public RESULT setPaused(bool paused); // 0x0000000180312060-0x0000000180312110
		public RESULT getPlaybackState(out PLAYBACK_STATE state); // 0x00000001803118E0-0x0000000180311990
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime); // 0x00000001803116B0-0x0000000180311770
		public RESULT release(); // 0x0000000180311C10-0x0000000180311CB0
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback); // 0x0000000180311EE0-0x0000000180311FA0
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback); // 0x0000000180311FA0-0x0000000180312060
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback); // 0x0000000180311E20-0x0000000180311EE0
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180311A40-0x0000000180311AF0
		public RESULT setUserData(IntPtr userdata); // 0x0000000180312110-0x00000001803121C0
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay); // 0x0000000181EE9000-0x0000000181EE90A0
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system); // 0x0000000181EE8EA0-0x0000000181EE8F50
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length); // 0x0000000181EE8C80-0x0000000181EE8D30
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count); // 0x0000000181EE89A0-0x0000000181EE8A50
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info); // 0x0000000181EE8A50-0x0000000181EE8B00
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length); // 0x0000000181EE8B00-0x0000000181EE8BC0
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex); // 0x0000000181EE88E0-0x0000000181EE89A0
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath); // 0x0000000181EE92A0-0x0000000181EE9360
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay); // 0x0000000181EE96D0-0x0000000181EE9770
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay); // 0x0000000181EE9770-0x0000000181EE9BE0
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time); // 0x0000000181EE91F0-0x0000000181EE92A0
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex); // 0x0000000181EE9140-0x0000000181EE91F0
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused); // 0x0000000181EE8D30-0x0000000181EE8DF0
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused); // 0x0000000181EE9570-0x0000000181EE9620
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state); // 0x0000000181EE8DF0-0x0000000181EE8EA0
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime); // 0x0000000181EE8BC0-0x0000000181EE8C80
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay); // 0x0000000181EE90A0-0x0000000181EE9140
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback); // 0x0000000181EE9410-0x0000000181EE94C0
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback); // 0x0000000181EE94C0-0x0000000181EE9570
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback); // 0x0000000181EE9360-0x0000000181EE9410
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata); // 0x0000000181EE8F50-0x0000000181EE9000
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata); // 0x0000000181EE9620-0x0000000181EE96D0
		public bool hasHandle(); // 0x0000000180311AF0-0x0000000180311B30
		public void clearHandle(); // 0x0000000180311430-0x0000000180311470
		public bool isValid(); // 0x0000000180311B30-0x0000000180311C10
	}
}
