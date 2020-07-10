/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct SoundGroup // TypeDefIndex: 9666
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x00000001803173B0-0x0000000180317450
		public RESULT getSystemObject(out System system); // 0x0000000180317160-0x0000000180317210
		public RESULT setMaxAudible(int maxaudible); // 0x0000000180317500-0x00000001803175B0
		public RESULT getMaxAudible(out int maxaudible); // 0x0000000180316DD0-0x0000000180316E80
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior); // 0x0000000180317450-0x0000000180317500
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior); // 0x0000000180316D20-0x0000000180316DD0
		public RESULT setMuteFadeSpeed(float speed); // 0x00000001803175B0-0x0000000180317660
		public RESULT getMuteFadeSpeed(out float speed); // 0x0000000180316E80-0x0000000180316F30
		public RESULT setVolume(float volume); // 0x0000000180317710-0x00000001803177C0
		public RESULT getVolume(out float volume); // 0x00000001803172C0-0x0000000180317370
		public RESULT stop(); // 0x00000001803177C0-0x0000000180317860
		public RESULT getName(out string name, int namelen); // 0x0000000180316F30-0x0000000180316F40
		public RESULT getNumSounds(out int numsounds); // 0x0000000180316FF0-0x00000001803170A0
		public RESULT getSound(int index, out Sound sound); // 0x00000001803170A0-0x0000000180317160
		public RESULT getNumPlaying(out int numplaying); // 0x0000000180316F40-0x0000000180316FF0
		public RESULT setUserData(IntPtr userdata); // 0x0000000180317660-0x0000000180317710
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180317210-0x00000001803172C0
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup); // 0x0000000181EF50E0-0x0000000181EF5180
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system); // 0x0000000181EF4ED0-0x0000000181EF4F80
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible); // 0x0000000181EF5230-0x0000000181EF52E0
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible); // 0x0000000181EF4AA0-0x0000000181EF4B50
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior); // 0x0000000181EF5180-0x0000000181EF5230
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior); // 0x0000000181EF49F0-0x0000000181EF4AA0
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed); // 0x0000000181EF52E0-0x0000000181EF5390
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed); // 0x0000000181EF4B50-0x0000000181EF4C00
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume); // 0x0000000181EF5440-0x0000000181EF54F0
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume); // 0x0000000181EF5030-0x0000000181EF50E0
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup); // 0x0000000181EF54F0-0x0000000181EF57B0
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen); // 0x0000000181EF4C00-0x0000000181EF4CC0
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds); // 0x0000000181EF4D70-0x0000000181EF4E20
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound); // 0x0000000181EF4E20-0x0000000181EF4ED0
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying); // 0x0000000181EF4CC0-0x0000000181EF4D70
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata); // 0x0000000181EF5390-0x0000000181EF5440
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata); // 0x0000000181EF4F80-0x0000000181EF5030
		public bool hasHandle(); // 0x0000000180317370-0x00000001803173B0
		public void clearHandle(); // 0x0000000180316CE0-0x0000000180316D20
	}
}
