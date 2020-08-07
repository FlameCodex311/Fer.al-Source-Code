/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct Sound // TypeDefIndex: 10116
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x000000018011C960-0x000000018011C9E0
		public RESULT getSystemObject(out System system); // 0x000000018011C670-0x000000018011C700
		public RESULT lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2); // 0x000000018011C7E0-0x000000018011C8B0
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2); // 0x000000018011D130-0x000000018011D300
		public RESULT setDefaults(float frequency, int priority); // 0x000000018011CC70-0x000000018011CD10
		public RESULT getDefaults(out float frequency, out int priority); // 0x000000018011BB20-0x000000018011BBC0
		public RESULT set3DMinMaxDistance(float min, float max); // 0x000000018011CBD0-0x000000018011CC70
		public RESULT get3DMinMaxDistance(out float min, out float max); // 0x000000018011BA80-0x000000018011BB20
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume); // 0x000000018011CA70-0x000000018011CB30
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x000000018011B930-0x000000018011B9E0
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints); // 0x000000018011CB30-0x000000018011CBD0
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints); // 0x000000018011B9E0-0x000000018011BA80
		public RESULT getSubSound(int index, out Sound subsound); // 0x000000018011C4A0-0x000000018011C540
		public RESULT getSubSoundParent(out Sound parentsound); // 0x000000018011C410-0x000000018011C4A0
		public RESULT getName(out string name, int namelen); // 0x000000018011C0C0-0x000000018011C0D0
		public RESULT getLength(out uint length, TIMEUNIT lengthtype); // 0x000000018011BC80-0x000000018011BD20
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits); // 0x000000018011BBC0-0x000000018011BC80
		public RESULT getNumSubSounds(out int numsubsounds); // 0x000000018011C0D0-0x000000018011C160
		public RESULT getNumTags(out int numtags, out int numtagsupdated); // 0x000000018011C1F0-0x000000018011C290
		public RESULT getTag(string name, int index, out TAG tag); // 0x000000018011C700-0x000000018011C710
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy); // 0x000000018011C290-0x000000018011C380
		public RESULT readData(IntPtr buffer, uint length, out uint read); // 0x000000018011C8B0-0x000000018011C960
		public RESULT seekData(uint pcm); // 0x000000018011C9E0-0x000000018011CA70
		public RESULT setSoundGroup(SoundGroup soundgroup); // 0x000000018011D010-0x000000018011D0A0
		public RESULT getSoundGroup(out SoundGroup soundgroup); // 0x000000018011C380-0x000000018011C410
		public RESULT getNumSyncPoints(out int numsyncpoints); // 0x000000018011C160-0x000000018011C1F0
		public RESULT getSyncPoint(int index, out IntPtr point); // 0x000000018011C5D0-0x000000018011C670
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype); // 0x000000018011C5C0-0x000000018011C5D0
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype); // 0x000000018011C540-0x000000018011C5C0
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point); // 0x000000018011B850-0x000000018011B860
		public RESULT deleteSyncPoint(IntPtr point); // 0x000000018011B8A0-0x000000018011B930
		public RESULT setMode(MODE mode); // 0x000000018011CE50-0x000000018011CEE0
		public RESULT getMode(out MODE mode); // 0x000000018011BE70-0x000000018011BF00
		public RESULT setLoopCount(int loopcount); // 0x000000018011CD10-0x000000018011CDA0
		public RESULT getLoopCount(out int loopcount); // 0x000000018011BD20-0x000000018011BDB0
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x000000018011CDA0-0x000000018011CE50
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x000000018011BDB0-0x000000018011BE70
		public RESULT getMusicNumChannels(out int numchannels); // 0x000000018011BFA0-0x000000018011C030
		public RESULT setMusicChannelVolume(int channel, float volume); // 0x000000018011CEE0-0x000000018011CF80
		public RESULT getMusicChannelVolume(int channel, out float volume); // 0x000000018011BF00-0x000000018011BFA0
		public RESULT setMusicSpeed(float speed); // 0x000000018011CF80-0x000000018011D010
		public RESULT getMusicSpeed(out float speed); // 0x000000018011C030-0x000000018011C0C0
		public RESULT setUserData(IntPtr userdata); // 0x000000018011D0A0-0x000000018011D130
		public RESULT getUserData(out IntPtr userdata); // 0x000000018011C710-0x000000018011C7A0
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound); // 0x0000000181BA3210-0x0000000181BA3290
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system); // 0x0000000181BA2E60-0x0000000181BA2EF0
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2); // 0x0000000181BA3090-0x0000000181BA3160
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2); // 0x0000000181BA39E0-0x0000000181BA4200
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority); // 0x0000000181BA3520-0x0000000181BA35C0
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority); // 0x0000000181BA2260-0x0000000181BA2300
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max); // 0x0000000181BA3480-0x0000000181BA3520
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max); // 0x0000000181BA21C0-0x0000000181BA2260
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume); // 0x0000000181BA3320-0x0000000181BA33E0
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x0000000181BA2070-0x0000000181BA2120
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints); // 0x0000000181BA33E0-0x0000000181BA3480
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints); // 0x0000000181BA2120-0x0000000181BA21C0
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound); // 0x0000000181BA2C60-0x0000000181BA2D00
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound); // 0x0000000181BA2BD0-0x0000000181BA2C60
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen); // 0x0000000181BA27F0-0x0000000181BA2890
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype); // 0x0000000181BA23C0-0x0000000181BA2460
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits); // 0x0000000181BA2300-0x0000000181BA23C0
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds); // 0x0000000181BA2890-0x0000000181BA2920
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated); // 0x0000000181BA29B0-0x0000000181BA2A50
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag); // 0x0000000181BA2EF0-0x0000000181BA3000
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy); // 0x0000000181BA2A50-0x0000000181BA2B40
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read); // 0x0000000181BA3160-0x0000000181BA3210
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm); // 0x0000000181BA3290-0x0000000181BA3320
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup); // 0x0000000181BA38C0-0x0000000181BA3950
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup); // 0x0000000181BA2B40-0x0000000181BA2BD0
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints); // 0x0000000181BA2920-0x0000000181BA29B0
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point); // 0x0000000181BA2DC0-0x0000000181BA2E60
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype); // 0x0000000181BA2D00-0x0000000181BA2DC0
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point); // 0x0000000181BA1F20-0x0000000181BA1FE0
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point); // 0x0000000181BA1FE0-0x0000000181BA2070
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode); // 0x0000000181BA3700-0x0000000181BA3790
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode); // 0x0000000181BA25A0-0x0000000181BA2630
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount); // 0x0000000181BA35C0-0x0000000181BA3650
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount); // 0x0000000181BA2460-0x0000000181BA24F0
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x0000000181BA3650-0x0000000181BA3700
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x0000000181BA24F0-0x0000000181BA25A0
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels); // 0x0000000181BA26D0-0x0000000181BA2760
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume); // 0x0000000181BA3790-0x0000000181BA3830
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume); // 0x0000000181BA2630-0x0000000181BA26D0
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed); // 0x0000000181BA3830-0x0000000181BA38C0
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed); // 0x0000000181BA2760-0x0000000181BA27F0
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata); // 0x0000000181BA3950-0x0000000181BA39E0
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata); // 0x0000000181BA3000-0x0000000181BA3090
		public bool hasHandle(); // 0x000000018011C7A0-0x000000018011C7E0
		public void clearHandle(); // 0x000000018011B860-0x000000018011B8A0
	}
}
