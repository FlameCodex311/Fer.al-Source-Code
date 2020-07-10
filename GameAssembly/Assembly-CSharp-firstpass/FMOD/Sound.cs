/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct Sound // TypeDefIndex: 9662
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x0000000180318C90-0x0000000180318D30
		public RESULT getSystemObject(out System system); // 0x0000000180318920-0x00000001803189D0
		public RESULT lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2); // 0x0000000180318AD0-0x0000000180318BC0
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2); // 0x0000000180319600-0x00000001803196E0
		public RESULT setDefaults(float frequency, int priority); // 0x0000000180319040-0x0000000180319100
		public RESULT getDefaults(out float frequency, out int priority); // 0x0000000180317BB0-0x0000000180317C70
		public RESULT set3DMinMaxDistance(float min, float max); // 0x0000000180318F80-0x0000000180319040
		public RESULT get3DMinMaxDistance(out float min, out float max); // 0x0000000180317AF0-0x0000000180317BB0
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume); // 0x0000000180318DE0-0x0000000180318EC0
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x0000000180317960-0x0000000180317A30
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints); // 0x0000000180318EC0-0x0000000180318F80
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints); // 0x0000000180317A30-0x0000000180317AF0
		public RESULT getSubSound(int index, out Sound subsound); // 0x0000000180318710-0x00000001803187D0
		public RESULT getSubSoundParent(out Sound parentsound); // 0x0000000180318660-0x0000000180318710
		public RESULT getName(out string name, int namelen); // 0x0000000180318270-0x0000000180318280
		public RESULT getLength(out uint length, TIMEUNIT lengthtype); // 0x0000000180317D50-0x0000000180317E10
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits); // 0x0000000180317C70-0x0000000180317D50
		public RESULT getNumSubSounds(out int numsubsounds); // 0x0000000180318280-0x0000000180318330
		public RESULT getNumTags(out int numtags, out int numtagsupdated); // 0x00000001803183E0-0x00000001803184A0
		public RESULT getTag(string name, int index, out TAG tag); // 0x00000001803189D0-0x00000001803189E0
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy); // 0x00000001803184A0-0x00000001803185B0
		public RESULT readData(IntPtr buffer, uint length, out uint read); // 0x0000000180318BC0-0x0000000180318C90
		public RESULT seekData(uint pcm); // 0x0000000180318D30-0x0000000180318DE0
		public RESULT setSoundGroup(SoundGroup soundgroup); // 0x00000001803194A0-0x0000000180319550
		public RESULT getSoundGroup(out SoundGroup soundgroup); // 0x00000001803185B0-0x0000000180318660
		public RESULT getNumSyncPoints(out int numsyncpoints); // 0x0000000180318330-0x00000001803183E0
		public RESULT getSyncPoint(int index, out IntPtr point); // 0x0000000180318860-0x0000000180318920
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype); // 0x0000000180318850-0x0000000180318860
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype); // 0x00000001803187D0-0x0000000180318850
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point); // 0x0000000180317860-0x0000000180317870
		public RESULT deleteSyncPoint(IntPtr point); // 0x00000001803178B0-0x0000000180317960
		public RESULT setMode(MODE mode); // 0x0000000180319280-0x0000000180319330
		public RESULT getMode(out MODE mode); // 0x0000000180317FA0-0x0000000180318050
		public RESULT setLoopCount(int loopcount); // 0x0000000180319100-0x00000001803191B0
		public RESULT getLoopCount(out int loopcount); // 0x0000000180317E10-0x0000000180317EC0
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x00000001803191B0-0x0000000180319280
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x0000000180317EC0-0x0000000180317FA0
		public RESULT getMusicNumChannels(out int numchannels); // 0x0000000180318110-0x00000001803181C0
		public RESULT setMusicChannelVolume(int channel, float volume); // 0x0000000180319330-0x00000001803193F0
		public RESULT getMusicChannelVolume(int channel, out float volume); // 0x0000000180318050-0x0000000180318110
		public RESULT setMusicSpeed(float speed); // 0x00000001803193F0-0x00000001803194A0
		public RESULT getMusicSpeed(out float speed); // 0x00000001803181C0-0x0000000180318270
		public RESULT setUserData(IntPtr userdata); // 0x0000000180319550-0x0000000180319600
		public RESULT getUserData(out IntPtr userdata); // 0x00000001803189E0-0x0000000180318A90
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound); // 0x0000000181EF6E10-0x0000000181EF6EB0
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system); // 0x0000000181EF69C0-0x0000000181EF6A70
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2); // 0x0000000181EF6C50-0x0000000181EF6D40
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2); // 0x0000000181EF7780-0x0000000181EF8020
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority); // 0x0000000181EF71C0-0x0000000181EF7280
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority); // 0x0000000181EF5BA0-0x0000000181EF5C60
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max); // 0x0000000181EF7100-0x0000000181EF71C0
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max); // 0x0000000181EF5AE0-0x0000000181EF5BA0
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume); // 0x0000000181EF6F60-0x0000000181EF7040
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x0000000181EF5950-0x0000000181EF5A20
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints); // 0x0000000181EF7040-0x0000000181EF7100
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints); // 0x0000000181EF5A20-0x0000000181EF5AE0
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound); // 0x0000000181EF6780-0x0000000181EF6830
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound); // 0x0000000181EF66D0-0x0000000181EF6780
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen); // 0x0000000181EF6240-0x0000000181EF6300
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype); // 0x0000000181EF5D40-0x0000000181EF5E00
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits); // 0x0000000181EF5C60-0x0000000181EF5D40
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds); // 0x0000000181EF6300-0x0000000181EF63B0
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated); // 0x0000000181EF6460-0x0000000181EF6520
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag); // 0x0000000181EF6A70-0x0000000181EF6BA0
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy); // 0x0000000181EF6520-0x0000000181EF6620
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read); // 0x0000000181EF6D40-0x0000000181EF6E10
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm); // 0x0000000181EF6EB0-0x0000000181EF6F60
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup); // 0x0000000181EF7620-0x0000000181EF76D0
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup); // 0x0000000181EF6620-0x0000000181EF66D0
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints); // 0x0000000181EF63B0-0x0000000181EF6460
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point); // 0x0000000181EF6910-0x0000000181EF69C0
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype); // 0x0000000181EF6830-0x0000000181EF6910
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point); // 0x0000000181EF57B0-0x0000000181EF58A0
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point); // 0x0000000181EF58A0-0x0000000181EF5950
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode); // 0x0000000181EF7400-0x0000000181EF74B0
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode); // 0x0000000181EF5F80-0x0000000181EF6030
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount); // 0x0000000181EF7280-0x0000000181EF7330
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount); // 0x0000000181EF5E00-0x0000000181EF5EB0
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x0000000181EF7330-0x0000000181EF7400
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x0000000181EF5EB0-0x0000000181EF5F80
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels); // 0x0000000181EF60E0-0x0000000181EF6190
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume); // 0x0000000181EF74B0-0x0000000181EF7570
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume); // 0x0000000181EF6030-0x0000000181EF60E0
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed); // 0x0000000181EF7570-0x0000000181EF7620
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed); // 0x0000000181EF6190-0x0000000181EF6240
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata); // 0x0000000181EF76D0-0x0000000181EF7780
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata); // 0x0000000181EF6BA0-0x0000000181EF6C50
		public bool hasHandle(); // 0x0000000180318A90-0x0000000180318AD0
		public void clearHandle(); // 0x0000000180317870-0x00000001803178B0
	}
}
