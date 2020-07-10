/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct Channel : IChannelControl // TypeDefIndex: 9664
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT setFrequency(float frequency); // 0x00000001802D7110-0x00000001802D71C0
		public RESULT getFrequency(out float frequency); // 0x00000001802D5590-0x00000001802D5640
		public RESULT setPriority(int priority); // 0x00000001802D7B00-0x00000001802D7BB0
		public RESULT getPriority(out int priority); // 0x00000001802D5E70-0x00000001802D5F20
		public RESULT setPosition(uint position, TIMEUNIT postype); // 0x00000001802D7A40-0x00000001802D7B00
		public RESULT getPosition(out uint position, TIMEUNIT postype); // 0x00000001802D5DB0-0x00000001802D5E70
		public RESULT setChannelGroup(ChannelGroup channelgroup); // 0x00000001802D6E10-0x00000001802D6EC0
		public RESULT getChannelGroup(out ChannelGroup channelgroup); // 0x00000001802D4F50-0x00000001802D5000
		public RESULT setLoopCount(int loopcount); // 0x00000001802D71C0-0x00000001802D7270
		public RESULT getLoopCount(out int loopcount); // 0x00000001802D56F0-0x00000001802D57A0
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x00000001802D7270-0x00000001802D7340
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x00000001802D57A0-0x00000001802D5880
		public RESULT isVirtual(out bool isvirtual); // 0x00000001802D63B0-0x00000001802D6470
		public RESULT getCurrentSound(out Sound sound); // 0x00000001802D5000-0x00000001802D50B0
		public RESULT getIndex(out int index); // 0x00000001802D5640-0x00000001802D56F0
		public RESULT getSystemObject(out System system); // 0x00000001802D5FE0-0x00000001802D6090
		public RESULT stop(); // 0x00000001802D7E80-0x00000001802D7F20
		public RESULT setPaused(bool paused); // 0x00000001802D78E0-0x00000001802D7990
		public RESULT getPaused(out bool paused); // 0x00000001802D5C40-0x00000001802D5D00
		public RESULT setVolume(float volume); // 0x00000001802D7DD0-0x00000001802D7E80
		public RESULT getVolume(out float volume); // 0x00000001802D6200-0x00000001802D62B0
		public RESULT setVolumeRamp(bool ramp); // 0x00000001802D7D20-0x00000001802D7DD0
		public RESULT getVolumeRamp(out bool ramp); // 0x00000001802D6140-0x00000001802D6200
		public RESULT getAudibility(out float audibility); // 0x00000001802D4EA0-0x00000001802D4F50
		public RESULT setPitch(float pitch); // 0x00000001802D7990-0x00000001802D7A40
		public RESULT getPitch(out float pitch); // 0x00000001802D5D00-0x00000001802D5DB0
		public RESULT setMute(bool mute); // 0x00000001802D7780-0x00000001802D7830
		public RESULT getMute(out bool mute); // 0x00000001802D5AD0-0x00000001802D5B90
		public RESULT setReverbProperties(int instance, float wet); // 0x00000001802D7BB0-0x00000001802D7C70
		public RESULT getReverbProperties(int instance, out float wet); // 0x00000001802D5F20-0x00000001802D5FE0
		public RESULT setLowPassGain(float gain); // 0x00000001802D7340-0x00000001802D73F0
		public RESULT getLowPassGain(out float gain); // 0x00000001802D5880-0x00000001802D5930
		public RESULT setMode(MODE mode); // 0x00000001802D76D0-0x00000001802D7780
		public RESULT getMode(out MODE mode); // 0x00000001802D5A20-0x00000001802D5AD0
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback); // 0x00000001802D6D50-0x00000001802D6E10
		public RESULT isPlaying(out bool isplaying); // 0x00000001802D62F0-0x00000001802D63B0
		public RESULT setPan(float pan); // 0x00000001802D7830-0x00000001802D78E0
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x00000001802D74C0-0x00000001802D75E0
		public RESULT setMixLevelsInput(float[] levels, int numlevels); // 0x00000001802D73F0-0x00000001802D74C0
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0 /* Metadata: 0x0074580D */); // 0x00000001802D75E0-0x00000001802D76D0
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0 /* Metadata: 0x00745811 */); // 0x00000001802D5930-0x00000001802D5A20
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock); // 0x00000001802D50B0-0x00000001802D5170
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true /* Metadata: 0x00745815 */); // 0x00000001802D6F80-0x00000001802D7050
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end); // 0x00000001802D53D0-0x00000001802D54B0
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x00000001802D52F0-0x00000001802D53D0
		public RESULT addFadePoint(ulong dspclock, float volume); // 0x00000001802D4630-0x00000001802D46F0
		public RESULT setFadePointRamp(ulong dspclock, float volume); // 0x00000001802D7050-0x00000001802D7110
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end); // 0x00000001802D6520-0x00000001802D65E0
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x00000001802D54B0-0x00000001802D5590
		public RESULT getDSP(int index, out DSP dsp); // 0x00000001802D5230-0x00000001802D52F0
		public RESULT addDSP(int index, DSP dsp); // 0x00000001802D4570-0x00000001802D4630
		public RESULT removeDSP(DSP dsp); // 0x00000001802D6470-0x00000001802D6520
		public RESULT getNumDSPs(out int numdsps); // 0x00000001802D5B90-0x00000001802D5C40
		public RESULT setDSPIndex(DSP dsp, int index); // 0x00000001802D6EC0-0x00000001802D6F80
		public RESULT getDSPIndex(DSP dsp, out int index); // 0x00000001802D5170-0x00000001802D5230
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel); // 0x00000001802D65E0-0x00000001802D66A0
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel); // 0x00000001802D4730-0x00000001802D47F0
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance); // 0x00000001802D6B20-0x00000001802D6BE0
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance); // 0x00000001802D4C70-0x00000001802D4D30
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume); // 0x00000001802D6750-0x00000001802D6830
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x00000001802D48A0-0x00000001802D4970
		public RESULT set3DConeOrientation(ref VECTOR orientation); // 0x00000001802D66A0-0x00000001802D6750
		public RESULT get3DConeOrientation(out VECTOR orientation); // 0x00000001802D47F0-0x00000001802D48A0
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints); // 0x00000001802D6830-0x00000001802D68F0
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints); // 0x00000001802D4970-0x00000001802D4A30
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion); // 0x00000001802D6BE0-0x00000001802D6CA0
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion); // 0x00000001802D4D30-0x00000001802D4DF0
		public RESULT set3DSpread(float angle); // 0x00000001802D6CA0-0x00000001802D6D50
		public RESULT get3DSpread(out float angle); // 0x00000001802D4DF0-0x00000001802D4EA0
		public RESULT set3DLevel(float level); // 0x00000001802D6A70-0x00000001802D6B20
		public RESULT get3DLevel(out float level); // 0x00000001802D4BC0-0x00000001802D4C70
		public RESULT set3DDopplerLevel(float level); // 0x00000001802D69C0-0x00000001802D6A70
		public RESULT get3DDopplerLevel(out float level); // 0x00000001802D4B10-0x00000001802D4BC0
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq); // 0x00000001802D68F0-0x00000001802D69C0
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq); // 0x00000001802D4A30-0x00000001802D4B10
		public RESULT setUserData(IntPtr userdata); // 0x00000001802D7C70-0x00000001802D7D20
		public RESULT getUserData(out IntPtr userdata); // 0x00000001802D6090-0x00000001802D6140
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency); // 0x0000000181B5A7D0-0x0000000181B5A880
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency); // 0x0000000181B58CC0-0x0000000181B58D70
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority); // 0x0000000181B5B1B0-0x0000000181B5B260
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority); // 0x0000000181B59590-0x0000000181B59640
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype); // 0x0000000181B5B100-0x0000000181B5B1B0
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype); // 0x0000000181B594D0-0x0000000181B59590
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup); // 0x0000000181B5A4D0-0x0000000181B5A580
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup); // 0x0000000181B586A0-0x0000000181B58750
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount); // 0x0000000181B5A880-0x0000000181B5A930
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount); // 0x0000000181B58E20-0x0000000181B58ED0
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x0000000181B5A930-0x0000000181B5AA00
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x0000000181B58ED0-0x0000000181B58FA0
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual); // 0x0000000181B59A80-0x0000000181B59B40
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound); // 0x0000000181B58750-0x0000000181B58800
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index); // 0x0000000181B58D70-0x0000000181B58E20
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system); // 0x0000000181B596F0-0x0000000181B597A0
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel); // 0x0000000181B5B530-0x0000000181B5B5D0
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused); // 0x0000000181B5AFA0-0x0000000181B5B050
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused); // 0x0000000181B59360-0x0000000181B59420
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume); // 0x0000000181B5B480-0x0000000181B5B530
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume); // 0x0000000181B59910-0x0000000181B599C0
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp); // 0x0000000181B5B3D0-0x0000000181B5B480
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp); // 0x0000000181B59850-0x0000000181B59910
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility); // 0x0000000181B585F0-0x0000000181B586A0
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch); // 0x0000000181B5B050-0x0000000181B5B100
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch); // 0x0000000181B59420-0x0000000181B594D0
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute); // 0x0000000181B5AE40-0x0000000181B5AEF0
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute); // 0x0000000181B591F0-0x0000000181B592B0
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet); // 0x0000000181B5B260-0x0000000181B5B320
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet); // 0x0000000181B59640-0x0000000181B596F0
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain); // 0x0000000181B5AA00-0x0000000181B5AAB0
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain); // 0x0000000181B58FA0-0x0000000181B59050
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode); // 0x0000000181B5AD90-0x0000000181B5AE40
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode); // 0x0000000181B59140-0x0000000181B591F0
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback); // 0x0000000181B5A420-0x0000000181B5A4D0
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying); // 0x0000000181B599C0-0x0000000181B59A80
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan); // 0x0000000181B5AEF0-0x0000000181B5AFA0
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x0000000181B5AB80-0x0000000181B5ACA0
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels); // 0x0000000181B5AAB0-0x0000000181B5AB80
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x0000000181B5ACA0-0x0000000181B5AD90
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x0000000181B59050-0x0000000181B59140
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock); // 0x0000000181B58800-0x0000000181B588C0
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels); // 0x0000000181B5A640-0x0000000181B5A710
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero); // 0x0000000181B58B10-0x0000000181B58BE0
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x0000000181B58A30-0x0000000181B58B10
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume); // 0x0000000181B57DC0-0x0000000181B57E80
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume); // 0x0000000181B5A710-0x0000000181B5A7D0
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end); // 0x0000000181B59BF0-0x0000000181B59CB0
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x0000000181B58BE0-0x0000000181B58CC0
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp); // 0x0000000181B58980-0x0000000181B58A30
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp); // 0x0000000181B57D10-0x0000000181B57DC0
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp); // 0x0000000181B59B40-0x0000000181B59BF0
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps); // 0x0000000181B592B0-0x0000000181B59360
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index); // 0x0000000181B5A580-0x0000000181B5A640
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index); // 0x0000000181B588C0-0x0000000181B58980
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel); // 0x0000000181B59CB0-0x0000000181B59D70
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel); // 0x0000000181B57E80-0x0000000181B57F40
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance); // 0x0000000181B5A1F0-0x0000000181B5A2B0
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance); // 0x0000000181B583C0-0x0000000181B58480
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume); // 0x0000000181B59E20-0x0000000181B59F00
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x0000000181B57FF0-0x0000000181B580C0
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation); // 0x0000000181B59D70-0x0000000181B59E20
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation); // 0x0000000181B57F40-0x0000000181B57FF0
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints); // 0x0000000181B59F00-0x0000000181B59FC0
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints); // 0x0000000181B580C0-0x0000000181B58180
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion); // 0x0000000181B5A2B0-0x0000000181B5A370
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion); // 0x0000000181B58480-0x0000000181B58540
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle); // 0x0000000181B5A370-0x0000000181B5A420
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle); // 0x0000000181B58540-0x0000000181B585F0
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level); // 0x0000000181B5A140-0x0000000181B5A1F0
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level); // 0x0000000181B58310-0x0000000181B583C0
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level); // 0x0000000181B5A090-0x0000000181B5A140
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level); // 0x0000000181B58260-0x0000000181B58310
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq); // 0x0000000181B59FC0-0x0000000181B5A090
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq); // 0x0000000181B58180-0x0000000181B58260
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata); // 0x0000000181B5B320-0x0000000181B5B3D0
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata); // 0x0000000181B597A0-0x0000000181B59850
		public bool hasHandle(); // 0x00000001802D62B0-0x00000001802D62F0
		public void clearHandle(); // 0x00000001802D46F0-0x00000001802D4730
	}
}
