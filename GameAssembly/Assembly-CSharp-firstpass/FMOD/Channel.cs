/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct Channel : IChannelControl // TypeDefIndex: 10118
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT setFrequency(float frequency); // 0x00000001800D4EB0-0x00000001800D4F40
		public RESULT getFrequency(out float frequency); // 0x00000001800D37D0-0x00000001800D3860
		public RESULT setPriority(int priority); // 0x00000001800D5700-0x00000001800D5790
		public RESULT getPriority(out int priority); // 0x00000001800D3F30-0x00000001800D3FC0
		public RESULT setPosition(uint position, TIMEUNIT postype); // 0x00000001800D5660-0x00000001800D5700
		public RESULT getPosition(out uint position, TIMEUNIT postype); // 0x00000001800D3E90-0x00000001800D3F30
		public RESULT setChannelGroup(ChannelGroup channelgroup); // 0x00000001800D4C30-0x00000001800D4CC0
		public RESULT getChannelGroup(out ChannelGroup channelgroup); // 0x00000001800D3290-0x00000001800D3320
		public RESULT setLoopCount(int loopcount); // 0x00000001800D4F40-0x00000001800D4FD0
		public RESULT getLoopCount(out int loopcount); // 0x00000001800D38F0-0x00000001800D3980
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x00000001800D4FD0-0x00000001800D5080
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x00000001800D3980-0x00000001800D3A40
		public RESULT isVirtual(out bool isvirtual); // 0x00000001800D4390-0x00000001800D4430
		public RESULT getCurrentSound(out Sound sound); // 0x00000001800D3320-0x00000001800D33B0
		public RESULT getIndex(out int index); // 0x00000001800D3860-0x00000001800D38F0
		public RESULT getSystemObject(out System system); // 0x00000001800D4060-0x00000001800D40F0
		public RESULT stop(); // 0x00000001800D59E0-0x00000001800DA500
		public RESULT setPaused(bool paused); // 0x00000001800D5540-0x00000001800D55D0
		public RESULT getPaused(out bool paused); // 0x00000001800D3D60-0x00000001800D3E00
		public RESULT setVolume(float volume); // 0x00000001800D5950-0x00000001800D59E0
		public RESULT getVolume(out float volume); // 0x00000001800D4220-0x00000001800D42B0
		public RESULT setVolumeRamp(bool ramp); // 0x00000001800D58C0-0x00000001800D5950
		public RESULT getVolumeRamp(out bool ramp); // 0x00000001800D4180-0x00000001800D4220
		public RESULT getAudibility(out float audibility); // 0x00000001800D3200-0x00000001800D3290
		public RESULT setPitch(float pitch); // 0x00000001800D55D0-0x00000001800D5660
		public RESULT getPitch(out float pitch); // 0x00000001800D3E00-0x00000001800D3E90
		public RESULT setMute(bool mute); // 0x00000001800D5420-0x00000001800D54B0
		public RESULT getMute(out bool mute); // 0x00000001800D3C30-0x00000001800D3CD0
		public RESULT setReverbProperties(int instance, float wet); // 0x00000001800D5790-0x00000001800D5830
		public RESULT getReverbProperties(int instance, out float wet); // 0x00000001800D3FC0-0x00000001800D4060
		public RESULT setLowPassGain(float gain); // 0x00000001800D5080-0x00000001800D5110
		public RESULT getLowPassGain(out float gain); // 0x00000001800D3A40-0x00000001800D3AD0
		public RESULT setMode(MODE mode); // 0x00000001800D5390-0x00000001800D5420
		public RESULT getMode(out MODE mode); // 0x00000001800D3BA0-0x00000001800D3C30
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback); // 0x00000001800D4B90-0x00000001800D4C30
		public RESULT isPlaying(out bool isplaying); // 0x00000001800D42F0-0x00000001800D4390
		public RESULT setPan(float pan); // 0x00000001800D54B0-0x00000001800D5540
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x00000001800D51C0-0x00000001800D52C0
		public RESULT setMixLevelsInput(float[] levels, int numlevels); // 0x00000001800D5110-0x00000001800D51C0
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0 /* Metadata: 0x0077B2BF */); // 0x00000001800D52C0-0x00000001800D5390
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0 /* Metadata: 0x0077B2C3 */); // 0x00000001800D3AD0-0x00000001800D3BA0
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock); // 0x00000001800D33B0-0x00000001800D3450
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true /* Metadata: 0x0077B2C7 */); // 0x00000001800D4D60-0x00000001800D4E10
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end); // 0x00000001800D3650-0x00000001800D3710
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x00000001800D3590-0x00000001800D3650
		public RESULT addFadePoint(ulong dspclock, float volume); // 0x00000001800D2AF0-0x00000001800D2B90
		public RESULT setFadePointRamp(ulong dspclock, float volume); // 0x00000001800D4E10-0x00000001800D4EB0
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end); // 0x00000001800D44C0-0x00000001800D4560
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x00000001800D3710-0x00000001800D37D0
		public RESULT getDSP(int index, out DSP dsp); // 0x00000001800D34F0-0x00000001800D3590
		public RESULT addDSP(int index, DSP dsp); // 0x00000001800D2A50-0x00000001800D2AF0
		public RESULT removeDSP(DSP dsp); // 0x00000001800D4430-0x00000001800D44C0
		public RESULT getNumDSPs(out int numdsps); // 0x00000001800D3CD0-0x00000001800D3D60
		public RESULT setDSPIndex(DSP dsp, int index); // 0x00000001800D4CC0-0x00000001800D4D60
		public RESULT getDSPIndex(DSP dsp, out int index); // 0x00000001800D3450-0x00000001800D34F0
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel); // 0x00000001800D4560-0x00000001800D4600
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel); // 0x00000001800D2BD0-0x00000001800D2C70
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance); // 0x00000001800D49C0-0x00000001800D4A60
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance); // 0x00000001800D3030-0x00000001800D30D0
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume); // 0x00000001800D4690-0x00000001800D4750
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x00000001800D2D00-0x00000001800D2DB0
		public RESULT set3DConeOrientation(ref VECTOR orientation); // 0x00000001800D4600-0x00000001800D4690
		public RESULT get3DConeOrientation(out VECTOR orientation); // 0x00000001800D2C70-0x00000001800D2D00
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints); // 0x00000001800D4750-0x00000001800D47F0
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints); // 0x00000001800D2DB0-0x00000001800D2E50
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion); // 0x00000001800D4A60-0x00000001800D4B00
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion); // 0x00000001800D30D0-0x00000001800D3170
		public RESULT set3DSpread(float angle); // 0x00000001800D4B00-0x00000001800D4B90
		public RESULT get3DSpread(out float angle); // 0x00000001800D3170-0x00000001800D3200
		public RESULT set3DLevel(float level); // 0x00000001800D4930-0x00000001800D49C0
		public RESULT get3DLevel(out float level); // 0x00000001800D2FA0-0x00000001800D3030
		public RESULT set3DDopplerLevel(float level); // 0x00000001800D48A0-0x00000001800D4930
		public RESULT get3DDopplerLevel(out float level); // 0x00000001800D2F10-0x00000001800D2FA0
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq); // 0x00000001800D47F0-0x00000001800D48A0
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq); // 0x00000001800D2E50-0x00000001800D2F10
		public RESULT setUserData(IntPtr userdata); // 0x00000001800D5830-0x00000001800D58C0
		public RESULT getUserData(out IntPtr userdata); // 0x00000001800D40F0-0x00000001800D4180
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency); // 0x0000000181727B10-0x0000000181727BA0
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency); // 0x0000000181726490-0x0000000181726520
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority); // 0x0000000181728350-0x00000001817283E0
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority); // 0x0000000181726BD0-0x0000000181726C60
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype); // 0x00000001817282B0-0x0000000181728350
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype); // 0x0000000181726B30-0x0000000181726BD0
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup); // 0x0000000181727890-0x0000000181727920
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup); // 0x0000000181725F60-0x0000000181725FF0
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount); // 0x0000000181727BA0-0x0000000181727C30
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount); // 0x00000001817265B0-0x0000000181726640
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype); // 0x0000000181727C30-0x0000000181727CE0
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype); // 0x0000000181726640-0x00000001817266F0
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual); // 0x0000000181726FF0-0x0000000181727090
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound); // 0x0000000181725FF0-0x0000000181726080
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index); // 0x0000000181726520-0x00000001817265B0
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system); // 0x0000000181726D00-0x0000000181726D90
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel); // 0x0000000181728630-0x00000001817286B0
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused); // 0x0000000181728190-0x0000000181728220
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused); // 0x0000000181726A00-0x0000000181726AA0
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume); // 0x00000001817285A0-0x0000000181728630
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume); // 0x0000000181726EC0-0x0000000181726F50
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp); // 0x0000000181728510-0x00000001817285A0
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp); // 0x0000000181726E20-0x0000000181726EC0
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility); // 0x0000000181725ED0-0x0000000181725F60
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch); // 0x0000000181728220-0x00000001817282B0
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch); // 0x0000000181726AA0-0x0000000181726B30
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute); // 0x0000000181728070-0x0000000181728100
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute); // 0x00000001817268D0-0x0000000181726970
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet); // 0x00000001817283E0-0x0000000181728480
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet); // 0x0000000181726C60-0x0000000181726D00
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain); // 0x0000000181727CE0-0x0000000181727D70
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain); // 0x00000001817266F0-0x0000000181726780
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode); // 0x0000000181727FE0-0x0000000181728070
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode); // 0x0000000181726840-0x00000001817268D0
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback); // 0x00000001817277F0-0x0000000181727890
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying); // 0x0000000181726F50-0x0000000181726FF0
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan); // 0x0000000181728100-0x0000000181728190
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright); // 0x0000000181727E20-0x0000000181727F20
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels); // 0x0000000181727D70-0x0000000181727E20
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x0000000181727F20-0x0000000181727FE0
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x0000000181726780-0x0000000181726840
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock); // 0x0000000181726080-0x0000000181726120
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels); // 0x00000001817279C0-0x0000000181727A70
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero); // 0x0000000181726320-0x00000001817263D0
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels); // 0x0000000181726260-0x0000000181726320
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume); // 0x0000000181725800-0x00000001817258A0
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume); // 0x0000000181727A70-0x0000000181727B10
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end); // 0x0000000181727120-0x00000001817271C0
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume); // 0x00000001817263D0-0x0000000181726490
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp); // 0x00000001817261C0-0x0000000181726260
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp); // 0x0000000181725760-0x0000000181725800
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp); // 0x0000000181727090-0x0000000181727120
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps); // 0x0000000181726970-0x0000000181726A00
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index); // 0x0000000181727920-0x00000001817279C0
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index); // 0x0000000181726120-0x00000001817261C0
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel); // 0x00000001817271C0-0x0000000181727260
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel); // 0x00000001817258A0-0x0000000181725940
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance); // 0x0000000181727620-0x00000001817276C0
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance); // 0x0000000181725D00-0x0000000181725DA0
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume); // 0x00000001817272F0-0x00000001817273B0
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume); // 0x00000001817259D0-0x0000000181725A80
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation); // 0x0000000181727260-0x00000001817272F0
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation); // 0x0000000181725940-0x00000001817259D0
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints); // 0x00000001817273B0-0x0000000181727450
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints); // 0x0000000181725A80-0x0000000181725B20
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion); // 0x00000001817276C0-0x0000000181727760
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion); // 0x0000000181725DA0-0x0000000181725E40
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle); // 0x0000000181727760-0x00000001817277F0
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle); // 0x0000000181725E40-0x0000000181725ED0
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level); // 0x0000000181727590-0x0000000181727620
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level); // 0x0000000181725C70-0x0000000181725D00
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level); // 0x0000000181727500-0x0000000181727590
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level); // 0x0000000181725BE0-0x0000000181725C70
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq); // 0x0000000181727450-0x0000000181727500
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq); // 0x0000000181725B20-0x0000000181725BE0
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata); // 0x0000000181728480-0x0000000181728510
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata); // 0x0000000181726D90-0x0000000181726E20
		public bool hasHandle(); // 0x00000001800D42B0-0x00000001800D42F0
		public void clearHandle(); // 0x00000001800D2B90-0x00000001800D2BD0
	}
}
