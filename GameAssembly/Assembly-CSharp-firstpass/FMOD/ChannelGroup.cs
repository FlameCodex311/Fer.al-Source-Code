/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct ChannelGroup : IChannelControl // TypeDefIndex: 9665
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x00000001802D2E70-0x00000001802D2F10
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true /* Metadata: 0x00745816 */); // 0x00000001802D12F0-0x00000001802D13D0
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection); // 0x00000001802D1220-0x00000001802D12F0
		public RESULT getNumGroups(out int numgroups); // 0x00000001802D2710-0x00000001802D27C0
		public RESULT getGroup(int index, out ChannelGroup group); // 0x00000001802D21D0-0x00000001802D2290
		public RESULT getParentGroup(out ChannelGroup group); // 0x00000001802D27C0-0x00000001802D2870
		public RESULT getName(out string name, int namelen); // 0x00000001802D25A0-0x00000001802D25B0
		public RESULT getNumChannels(out int numchannels); // 0x00000001802D25B0-0x00000001802D2660
		public RESULT getChannel(int index, out Channel channel); // 0x00000001802D1C30-0x00000001802D1CF0
		public RESULT getSystemObject(out System system); // 0x00000001802D2AA0-0x00000001802D2B50
		public RESULT stop(); // 0x00000001802D44D0-0x00000001802D4570
		public RESULT setPaused(bool paused); // 0x00000001802D40A0-0x00000001802D4150
		public RESULT getPaused(out bool paused); // 0x00000001802D2870-0x00000001802D2930
		public RESULT setVolume(float volume); // 0x00000001802D4420-0x00000001802D44D0
		public RESULT getVolume(out float volume); // 0x00000001802D2CC0-0x00000001802D2D70
		public RESULT setVolumeRamp(bool ramp); // 0x00000001802D4370-0x00000001802D4420
		public RESULT getVolumeRamp(out bool ramp); // 0x00000001802D2C00-0x00000001802D2CC0
		public RESULT getAudibility(out float audibility); // 0x00000001802D1B80-0x00000001802D1C30
		public RESULT setPitch(float pitch); // 0x00000001802D4150-0x00000001802D4200
		public RESULT getPitch(out float pitch); // 0x00000001802D2930-0x00000001802D29E0
		public RESULT setMute(bool mute); // 0x00000001802D3F40-0x00000001802D3FF0
		public RESULT getMute(out bool mute); // 0x00000001802D24E0-0x00000001802D25A0
		public RESULT setReverbProperties(int instance, float wet); // 0x00000001802D4200-0x00000001802D42C0
		public RESULT getReverbProperties(int instance, out float wet); // 0x00000001802D29E0-0x00000001802D2AA0
		public RESULT setLowPassGain(float gain); // 0x00000001802D3B00-0x00000001802D3BB0
		public RESULT getLowPassGain(out float gain); // 0x00000001802D2290-0x00000001802D2340
		public RESULT setMode(MODE mode); // 0x00000001802D3E90-0x00000001802D3F40
		public RESULT getMode(out MODE mode); // 0x00000001802D2430-0x00000001802D24E0
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback); // 0x00000001802D37F0-0x00000001802D38B0
		public RESULT isPlaying(out bool isplaying); // 0x00000001802D2DB0-0x00000001802D2E70
		public RESULT setPan(float pan); // 0x00000001802D3FF0-0x00000001802D40A0
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x00000001802D3C80-0x00000001802D3DA0
		public RESULT setMixLevelsInput(float[] levels, int numlevels); // 0x00000001802D3BB0-0x00000001802D3C80
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x00000001802D3DA0-0x00000001802D3E90
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x00000001802D2340-0x00000001802D2430
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock); // 0x00000001802D1CF0-0x00000001802D1DB0
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels); // 0x00000001802D3970-0x00000001802D3A40
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end); // 0x00000001802D1F30-0x00000001802D2010
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x00000001802D2010-0x00000001802D20F0
		public RESULT addFadePoint(ulong dspclock, float volume); // 0x00000001802D1160-0x00000001802D1220
		public RESULT setFadePointRamp(ulong dspclock, float volume); // 0x00000001802D3A40-0x00000001802D3B00
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end); // 0x00000001802D2FC0-0x00000001802D3080
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x00000001802D20F0-0x00000001802D21D0
		public RESULT getDSP(int index, out DSP dsp); // 0x00000001802D1E70-0x00000001802D1F30
		public RESULT addDSP(int index, DSP dsp); // 0x00000001802D10A0-0x00000001802D1160
		public RESULT removeDSP(DSP dsp); // 0x00000001802D2F10-0x00000001802D2FC0
		public RESULT getNumDSPs(out int numdsps); // 0x00000001802D2660-0x00000001802D2710
		public RESULT setDSPIndex(DSP dsp, int index); // 0x00000001802D38B0-0x00000001802D3970
		public RESULT getDSPIndex(DSP dsp, out int index); // 0x00000001802D1DB0-0x00000001802D1E70
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel); // 0x00000001802D3080-0x00000001802D3140
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel); // 0x00000001802D1410-0x00000001802D14D0
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance); // 0x00000001802D35C0-0x00000001802D3680
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance); // 0x00000001802D1950-0x00000001802D1A10
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume); // 0x00000001802D31F0-0x00000001802D32D0
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x00000001802D1580-0x00000001802D1650
		public RESULT set3DConeOrientation(ref VECTOR orientation); // 0x00000001802D3140-0x00000001802D31F0
		public RESULT get3DConeOrientation(out VECTOR orientation); // 0x00000001802D14D0-0x00000001802D1580
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints); // 0x00000001802D32D0-0x00000001802D3390
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints); // 0x00000001802D1650-0x00000001802D1710
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion); // 0x00000001802D3680-0x00000001802D3740
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion); // 0x00000001802D1A10-0x00000001802D1AD0
		public RESULT set3DSpread(float angle); // 0x00000001802D3740-0x00000001802D37F0
		public RESULT get3DSpread(out float angle); // 0x00000001802D1AD0-0x00000001802D1B80
		public RESULT set3DLevel(float level); // 0x00000001802D3510-0x00000001802D35C0
		public RESULT get3DLevel(out float level); // 0x00000001802D18A0-0x00000001802D1950
		public RESULT set3DDopplerLevel(float level); // 0x00000001802D3460-0x00000001802D3510
		public RESULT get3DDopplerLevel(out float level); // 0x00000001802D17F0-0x00000001802D18A0
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq); // 0x00000001802D3390-0x00000001802D3460
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq); // 0x00000001802D1710-0x00000001802D17F0
		public RESULT setUserData(IntPtr userdata); // 0x00000001802D42C0-0x00000001802D4370
		public RESULT getUserData(out IntPtr userdata); // 0x00000001802D2B50-0x00000001802D2C00
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup); // 0x0000000181B56260-0x0000000181B56300
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero); // 0x0000000181B54710-0x0000000181B547E0
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection); // 0x0000000181B54640-0x0000000181B54710
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups); // 0x0000000181B55B50-0x0000000181B55C00
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group); // 0x0000000181B55570-0x0000000181B55620
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group); // 0x0000000181B55C00-0x0000000181B55CB0
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen); // 0x0000000181B55930-0x0000000181B559F0
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels); // 0x0000000181B559F0-0x0000000181B55AA0
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel); // 0x0000000181B55000-0x0000000181B550B0
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system); // 0x0000000181B55ED0-0x0000000181B55F80
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup); // 0x0000000181B578B0-0x0000000181B57D10
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused); // 0x0000000181B57480-0x0000000181B57530
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused); // 0x0000000181B55CB0-0x0000000181B55D70
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume); // 0x0000000181B57800-0x0000000181B578B0
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume); // 0x0000000181B560F0-0x0000000181B561A0
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp); // 0x0000000181B57750-0x0000000181B57800
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp); // 0x0000000181B56030-0x0000000181B560F0
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility); // 0x0000000181B54F50-0x0000000181B55000
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch); // 0x0000000181B57530-0x0000000181B575E0
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch); // 0x0000000181B55D70-0x0000000181B55E20
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute); // 0x0000000181B57320-0x0000000181B573D0
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute); // 0x0000000181B55870-0x0000000181B55930
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet); // 0x0000000181B575E0-0x0000000181B576A0
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet); // 0x0000000181B55E20-0x0000000181B55ED0
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain); // 0x0000000181B56EE0-0x0000000181B56F90
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain); // 0x0000000181B55620-0x0000000181B556D0
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode); // 0x0000000181B57270-0x0000000181B57320
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode); // 0x0000000181B557C0-0x0000000181B55870
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback); // 0x0000000181B56BE0-0x0000000181B56C90
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying); // 0x0000000181B561A0-0x0000000181B56260
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan); // 0x0000000181B573D0-0x0000000181B57480
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x0000000181B57060-0x0000000181B57180
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels); // 0x0000000181B56F90-0x0000000181B57060
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x0000000181B57180-0x0000000181B57270
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x0000000181B556D0-0x0000000181B557C0
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock); // 0x0000000181B550B0-0x0000000181B55170
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels); // 0x0000000181B56D50-0x0000000181B56E20
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero); // 0x0000000181B552E0-0x0000000181B553B0
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x0000000181B553B0-0x0000000181B55490
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume); // 0x0000000181B54580-0x0000000181B54640
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume); // 0x0000000181B56E20-0x0000000181B56EE0
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end); // 0x0000000181B563B0-0x0000000181B56470
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x0000000181B55490-0x0000000181B55570
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp); // 0x0000000181B55230-0x0000000181B552E0
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp); // 0x0000000181B544D0-0x0000000181B54580
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp); // 0x0000000181B56300-0x0000000181B563B0
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps); // 0x0000000181B55AA0-0x0000000181B55B50
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index); // 0x0000000181B56C90-0x0000000181B56D50
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index); // 0x0000000181B55170-0x0000000181B55230
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel); // 0x0000000181B56470-0x0000000181B56530
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel); // 0x0000000181B547E0-0x0000000181B548A0
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance); // 0x0000000181B569B0-0x0000000181B56A70
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance); // 0x0000000181B54D20-0x0000000181B54DE0
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume); // 0x0000000181B565E0-0x0000000181B566C0
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x0000000181B54950-0x0000000181B54A20
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation); // 0x0000000181B56530-0x0000000181B565E0
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation); // 0x0000000181B548A0-0x0000000181B54950
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints); // 0x0000000181B566C0-0x0000000181B56780
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints); // 0x0000000181B54A20-0x0000000181B54AE0
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion); // 0x0000000181B56A70-0x0000000181B56B30
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion); // 0x0000000181B54DE0-0x0000000181B54EA0
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle); // 0x0000000181B56B30-0x0000000181B56BE0
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle); // 0x0000000181B54EA0-0x0000000181B54F50
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level); // 0x0000000181B56900-0x0000000181B569B0
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level); // 0x0000000181B54C70-0x0000000181B54D20
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level); // 0x0000000181B56850-0x0000000181B56900
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level); // 0x0000000181B54BC0-0x0000000181B54C70
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq); // 0x0000000181B56780-0x0000000181B56850
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq); // 0x0000000181B54AE0-0x0000000181B54BC0
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata); // 0x0000000181B576A0-0x0000000181B57750
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata); // 0x0000000181B55F80-0x0000000181B56030
		public bool hasHandle(); // 0x00000001802D2D70-0x00000001802D2DB0
		public void clearHandle(); // 0x00000001802D13D0-0x00000001802D1410
	}
}
