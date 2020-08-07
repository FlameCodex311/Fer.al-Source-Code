/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct SoundGroup // TypeDefIndex: 10120
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x00000001801218B0-0x0000000180121930
		public RESULT getSystemObject(out System system); // 0x00000001801216C0-0x0000000180121750
		public RESULT setMaxAudible(int maxaudible); // 0x00000001801219C0-0x0000000180121A50
		public RESULT getMaxAudible(out int maxaudible); // 0x00000001801213D0-0x0000000180121460
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior); // 0x0000000180121930-0x00000001801219C0
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior); // 0x0000000180121340-0x00000001801213D0
		public RESULT setMuteFadeSpeed(float speed); // 0x0000000180121A50-0x0000000180121AE0
		public RESULT getMuteFadeSpeed(out float speed); // 0x0000000180121460-0x00000001801214F0
		public RESULT setVolume(float volume); // 0x0000000180121B70-0x0000000180121C00
		public RESULT getVolume(out float volume); // 0x00000001801217E0-0x0000000180121870
		public RESULT stop(); // 0x0000000180121C00-0x0000000180121C80
		public RESULT getName(out string name, int namelen); // 0x00000001801214F0-0x0000000180121500
		public RESULT getNumSounds(out int numsounds); // 0x0000000180121590-0x0000000180121620
		public RESULT getSound(int index, out Sound sound); // 0x0000000180121620-0x00000001801216C0
		public RESULT getNumPlaying(out int numplaying); // 0x0000000180121500-0x0000000180121590
		public RESULT setUserData(IntPtr userdata); // 0x0000000180121AE0-0x0000000180121B70
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180121750-0x00000001801217E0
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup); // 0x0000000181BDFDB0-0x0000000181BDFE30
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system); // 0x0000000181BDFC00-0x0000000181BDFC90
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible); // 0x0000000181BDFEC0-0x0000000181BDFF50
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible); // 0x0000000181BDF880-0x0000000181BDF910
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior); // 0x0000000181BDFE30-0x0000000181BDFEC0
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior); // 0x0000000181BDF7F0-0x0000000181BDF880
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed); // 0x0000000181BDFF50-0x0000000181BDFFE0
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed); // 0x0000000181BDF910-0x0000000181BDF9A0
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume); // 0x0000000181BE0070-0x0000000181BE0100
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume); // 0x0000000181BDFD20-0x0000000181BDFDB0
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup); // 0x0000000181BE0100-0x0000000181BE0380
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen); // 0x0000000181BDF9A0-0x0000000181BDFA40
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds); // 0x0000000181BDFAD0-0x0000000181BDFB60
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound); // 0x0000000181BDFB60-0x0000000181BDFC00
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying); // 0x0000000181BDFA40-0x0000000181BDFAD0
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata); // 0x0000000181BDFFE0-0x0000000181BE0070
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata); // 0x0000000181BDFC90-0x0000000181BDFD20
		public bool hasHandle(); // 0x0000000180121870-0x00000001801218B0
		public void clearHandle(); // 0x0000000180121300-0x0000000180121340
	}
}
