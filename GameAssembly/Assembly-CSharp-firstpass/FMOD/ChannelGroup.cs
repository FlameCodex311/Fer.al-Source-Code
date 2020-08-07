/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct ChannelGroup : IChannelControl // TypeDefIndex: 10119
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x0000000180114230-0x00000001801142B0
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true /* Metadata: 0x0077B2C8 */); // 0x0000000180112B30-0x0000000180112BF0
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection); // 0x0000000180112A80-0x0000000180112B30
		public RESULT getNumGroups(out int numgroups); // 0x0000000180113C10-0x0000000180113CA0
		public RESULT getGroup(int index, out ChannelGroup group); // 0x00000001801137B0-0x0000000180113850
		public RESULT getParentGroup(out ChannelGroup group); // 0x0000000180113CA0-0x0000000180113D30
		public RESULT getName(out string name, int namelen); // 0x0000000180113AE0-0x0000000180113AF0
		public RESULT getNumChannels(out int numchannels); // 0x0000000180113AF0-0x0000000180113B80
		public RESULT getChannel(int index, out Channel channel); // 0x00000001801132F0-0x0000000180113390
		public RESULT getSystemObject(out System system); // 0x0000000180113F00-0x0000000180113F90
		public RESULT stop(); // 0x00000001801154D0-0x0000000180115550
		public RESULT setPaused(bool paused); // 0x0000000180115160-0x00000001801151F0
		public RESULT getPaused(out bool paused); // 0x0000000180113D30-0x0000000180113DD0
		public RESULT setVolume(float volume); // 0x0000000180115440-0x00000001801154D0
		public RESULT getVolume(out float volume); // 0x00000001801140C0-0x0000000180114150
		public RESULT setVolumeRamp(bool ramp); // 0x00000001801153B0-0x0000000180115440
		public RESULT getVolumeRamp(out bool ramp); // 0x0000000180114020-0x00000001801140C0
		public RESULT getAudibility(out float audibility); // 0x0000000180113260-0x00000001801132F0
		public RESULT setPitch(float pitch); // 0x00000001801151F0-0x0000000180115280
		public RESULT getPitch(out float pitch); // 0x0000000180113DD0-0x0000000180113E60
		public RESULT setMute(bool mute); // 0x0000000180115040-0x00000001801150D0
		public RESULT getMute(out bool mute); // 0x0000000180113A40-0x0000000180113AE0
		public RESULT setReverbProperties(int instance, float wet); // 0x0000000180115280-0x0000000180115320
		public RESULT getReverbProperties(int instance, out float wet); // 0x0000000180113E60-0x0000000180113F00
		public RESULT setLowPassGain(float gain); // 0x0000000180114CA0-0x0000000180114D30
		public RESULT getLowPassGain(out float gain); // 0x0000000180113850-0x00000001801138E0
		public RESULT setMode(MODE mode); // 0x0000000180114FB0-0x0000000180115040
		public RESULT getMode(out MODE mode); // 0x00000001801139B0-0x0000000180113A40
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback); // 0x0000000180114A10-0x0000000180114AB0
		public RESULT isPlaying(out bool isplaying); // 0x0000000180114190-0x0000000180114230
		public RESULT setPan(float pan); // 0x00000001801150D0-0x0000000180115160
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x0000000180114DE0-0x0000000180114EE0
		public RESULT setMixLevelsInput(float[] levels, int numlevels); // 0x0000000180114D30-0x0000000180114DE0
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x0000000180114EE0-0x0000000180114FB0
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x00000001801138E0-0x00000001801139B0
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock); // 0x0000000180113390-0x0000000180113430
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels); // 0x0000000180114B50-0x0000000180114C00
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end); // 0x0000000180113570-0x0000000180113630
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x0000000180113630-0x00000001801136F0
		public RESULT addFadePoint(ulong dspclock, float volume); // 0x00000001801129E0-0x0000000180112A80
		public RESULT setFadePointRamp(ulong dspclock, float volume); // 0x0000000180114C00-0x0000000180114CA0
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end); // 0x0000000180114340-0x00000001801143E0
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x00000001801136F0-0x00000001801137B0
		public RESULT getDSP(int index, out DSP dsp); // 0x00000001801134D0-0x0000000180113570
		public RESULT addDSP(int index, DSP dsp); // 0x0000000180112940-0x00000001801129E0
		public RESULT removeDSP(DSP dsp); // 0x00000001801142B0-0x0000000180114340
		public RESULT getNumDSPs(out int numdsps); // 0x0000000180113B80-0x0000000180113C10
		public RESULT setDSPIndex(DSP dsp, int index); // 0x0000000180114AB0-0x0000000180114B50
		public RESULT getDSPIndex(DSP dsp, out int index); // 0x0000000180113430-0x00000001801134D0
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel); // 0x00000001801143E0-0x0000000180114480
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel); // 0x0000000180112C30-0x0000000180112CD0
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance); // 0x0000000180114840-0x00000001801148E0
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance); // 0x0000000180113090-0x0000000180113130
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume); // 0x0000000180114510-0x00000001801145D0
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x0000000180112D60-0x0000000180112E10
		public RESULT set3DConeOrientation(ref VECTOR orientation); // 0x0000000180114480-0x0000000180114510
		public RESULT get3DConeOrientation(out VECTOR orientation); // 0x0000000180112CD0-0x0000000180112D60
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints); // 0x00000001801145D0-0x0000000180114670
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints); // 0x0000000180112E10-0x0000000180112EB0
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion); // 0x00000001801148E0-0x0000000180114980
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion); // 0x0000000180113130-0x00000001801131D0
		public RESULT set3DSpread(float angle); // 0x0000000180114980-0x0000000180114A10
		public RESULT get3DSpread(out float angle); // 0x00000001801131D0-0x0000000180113260
		public RESULT set3DLevel(float level); // 0x00000001801147B0-0x0000000180114840
		public RESULT get3DLevel(out float level); // 0x0000000180113000-0x0000000180113090
		public RESULT set3DDopplerLevel(float level); // 0x0000000180114720-0x00000001801147B0
		public RESULT get3DDopplerLevel(out float level); // 0x0000000180112F70-0x0000000180113000
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq); // 0x0000000180114670-0x0000000180114720
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq); // 0x0000000180112EB0-0x0000000180112F70
		public RESULT setUserData(IntPtr userdata); // 0x0000000180115320-0x00000001801153B0
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180113F90-0x0000000180114020
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup); // 0x0000000181B92620-0x0000000181B926A0
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero); // 0x0000000181B90F40-0x0000000181B90FF0
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection); // 0x0000000181B90E90-0x0000000181B90F40
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups); // 0x0000000181B92040-0x0000000181B920D0
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group); // 0x0000000181B91B60-0x0000000181B91C00
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group); // 0x0000000181B920D0-0x0000000181B92160
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen); // 0x0000000181B91E80-0x0000000181B91F20
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels); // 0x0000000181B91F20-0x0000000181B91FB0
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel); // 0x0000000181B916B0-0x0000000181B91750
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system); // 0x0000000181B92330-0x0000000181B923C0
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup); // 0x0000000181B938B0-0x0000000181B93CA0
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused); // 0x0000000181B93540-0x0000000181B935D0
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused); // 0x0000000181B92160-0x0000000181B92200
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume); // 0x0000000181B93820-0x0000000181B938B0
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume); // 0x0000000181B924F0-0x0000000181B92580
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp); // 0x0000000181B93790-0x0000000181B93820
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp); // 0x0000000181B92450-0x0000000181B924F0
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility); // 0x0000000181B91620-0x0000000181B916B0
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch); // 0x0000000181B935D0-0x0000000181B93660
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch); // 0x0000000181B92200-0x0000000181B92290
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute); // 0x0000000181B93420-0x0000000181B934B0
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute); // 0x0000000181B91DE0-0x0000000181B91E80
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet); // 0x0000000181B93660-0x0000000181B93700
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet); // 0x0000000181B92290-0x0000000181B92330
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain); // 0x0000000181B93090-0x0000000181B93120
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain); // 0x0000000181B91C00-0x0000000181B91C90
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode); // 0x0000000181B93390-0x0000000181B93420
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode); // 0x0000000181B91D50-0x0000000181B91DE0
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback); // 0x0000000181B92E00-0x0000000181B92EA0
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying); // 0x0000000181B92580-0x0000000181B92620
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan); // 0x0000000181B934B0-0x0000000181B93540
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x0000000181B931D0-0x0000000181B932D0
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels); // 0x0000000181B93120-0x0000000181B931D0
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x0000000181B932D0-0x0000000181B93390
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x0000000181B91C90-0x0000000181B91D50
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock); // 0x0000000181B91750-0x0000000181B917F0
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels); // 0x0000000181B92F40-0x0000000181B92FF0
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero); // 0x0000000181B91930-0x0000000181B919E0
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x0000000181B919E0-0x0000000181B91AA0
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume); // 0x0000000181B90DF0-0x0000000181B90E90
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume); // 0x0000000181B92FF0-0x0000000181B93090
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end); // 0x0000000181B92730-0x0000000181B927D0
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x0000000181B91AA0-0x0000000181B91B60
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp); // 0x0000000181B91890-0x0000000181B91930
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp); // 0x0000000181B90D50-0x0000000181B90DF0
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp); // 0x0000000181B926A0-0x0000000181B92730
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps); // 0x0000000181B91FB0-0x0000000181B92040
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index); // 0x0000000181B92EA0-0x0000000181B92F40
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index); // 0x0000000181B917F0-0x0000000181B91890
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel); // 0x0000000181B927D0-0x0000000181B92870
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel); // 0x0000000181B90FF0-0x0000000181B91090
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance); // 0x0000000181B92C30-0x0000000181B92CD0
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance); // 0x0000000181B91450-0x0000000181B914F0
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume); // 0x0000000181B92900-0x0000000181B929C0
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x0000000181B91120-0x0000000181B911D0
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation); // 0x0000000181B92870-0x0000000181B92900
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation); // 0x0000000181B91090-0x0000000181B91120
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints); // 0x0000000181B929C0-0x0000000181B92A60
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints); // 0x0000000181B911D0-0x0000000181B91270
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion); // 0x0000000181B92CD0-0x0000000181B92D70
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion); // 0x0000000181B914F0-0x0000000181B91590
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle); // 0x0000000181B92D70-0x0000000181B92E00
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle); // 0x0000000181B91590-0x0000000181B91620
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level); // 0x0000000181B92BA0-0x0000000181B92C30
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level); // 0x0000000181B913C0-0x0000000181B91450
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level); // 0x0000000181B92B10-0x0000000181B92BA0
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level); // 0x0000000181B91330-0x0000000181B913C0
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq); // 0x0000000181B92A60-0x0000000181B92B10
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq); // 0x0000000181B91270-0x0000000181B91330
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata); // 0x0000000181B93700-0x0000000181B93790
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata); // 0x0000000181B923C0-0x0000000181B92450
		public bool hasHandle(); // 0x0000000180114150-0x0000000180114190
		public void clearHandle(); // 0x0000000180112BF0-0x0000000180112C30
	}
}
