/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct System // TypeDefIndex: 9661
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x00000001802CD240-0x00000001802CD2E0
		public RESULT setOutput(OUTPUTTYPE output); // 0x00000001802CDE90-0x00000001802CDEA0
		public RESULT getOutput(out OUTPUTTYPE output); // 0x00000001802CBA20-0x00000001802CBAD0
		public RESULT getNumDrivers(out int numdrivers); // 0x00000001802CB5E0-0x00000001802CB690
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels); // 0x00000001802CAED0-0x00000001802CAEE0
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels); // 0x00000001802CAE40-0x00000001802CAED0
		public RESULT setDriver(int driver); // 0x00000001802CD960-0x00000001802CDA10
		public RESULT getDriver(out int driver); // 0x00000001802CAEE0-0x00000001802CAF90
		public RESULT setSoftwareChannels(int numsoftwarechannels); // 0x00000001802CE140-0x00000001802CE150
		public RESULT getSoftwareChannels(out int numsoftwarechannels); // 0x00000001802CC070-0x00000001802CC120
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers); // 0x00000001802CE150-0x00000001802CE160
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers); // 0x00000001802CC120-0x00000001802CC1F0
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers); // 0x00000001802CD8A0-0x00000001802CD960
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers); // 0x00000001802CABE0-0x00000001802CACA0
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign); // 0x00000001802CDA10-0x00000001802CDB60
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek); // 0x00000001802C9230-0x00000001802C9330
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings); // 0x00000001802CD6E0-0x00000001802CD6F0
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings); // 0x00000001802CA3D0-0x00000001802CA5A0
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.DEVICELISTCHANGED | SYSTEM_CALLBACK_TYPE.DEVICELOST | SYSTEM_CALLBACK_TYPE.MEMORYALLOCATIONFAILED | SYSTEM_CALLBACK_TYPE.THREADCREATED | SYSTEM_CALLBACK_TYPE.BADDSPCONNECTION | SYSTEM_CALLBACK_TYPE.PREMIX | SYSTEM_CALLBACK_TYPE.POSTMIX | SYSTEM_CALLBACK_TYPE.ERROR | SYSTEM_CALLBACK_TYPE.MIDMIX | SYSTEM_CALLBACK_TYPE.THREADDESTROYED | SYSTEM_CALLBACK_TYPE.PREUPDATE | SYSTEM_CALLBACK_TYPE.POSTUPDATE | SYSTEM_CALLBACK_TYPE.RECORDLISTCHANGED | SYSTEM_CALLBACK_TYPE.ALL /* Metadata: 0x00745804 */); // 0x00000001802CD720-0x00000001802CD7E0
		public RESULT setPluginPath(string path); // 0x00000001802CE070-0x00000001802CE080
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0 /* Metadata: 0x00745808 */); // 0x00000001802CCC50-0x00000001802CCC60
		public RESULT unloadPlugin(uint handle); // 0x00000001802CE5B0-0x00000001802CE660
		public RESULT getNumNestedPlugins(uint handle, out int count); // 0x00000001802CB740-0x00000001802CB800
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle); // 0x00000001802CB460-0x00000001802CB520
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins); // 0x00000001802CB800-0x00000001802CB8C0
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle); // 0x00000001802CBC40-0x00000001802CBD00
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version); // 0x00000001802CBD00-0x00000001802CBD10
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version); // 0x00000001802CBD10-0x00000001802CBD80
		public RESULT setOutputByPlugin(uint handle); // 0x00000001802CDDE0-0x00000001802CDE90
		public RESULT getOutputByPlugin(out uint handle); // 0x00000001802CB8C0-0x00000001802CB970
		public RESULT createDSPByPlugin(uint handle, out DSP dsp); // 0x00000001802C9460-0x00000001802C9520
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description); // 0x00000001802CACA0-0x00000001802CAD60
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle); // 0x00000001802CD090-0x00000001802CD230
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata); // 0x00000001802CC7D0-0x00000001802CC890
		public RESULT close(); // 0x00000001802C93B0-0x00000001802C9450
		public RESULT update(); // 0x00000001802CE710-0x00000001802CE810
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active); // 0x00000001802CE160-0x00000001802CE240
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active); // 0x00000001802CC2C0-0x00000001802CC3B0
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype); // 0x00000001802CE240-0x00000001802CE300
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype); // 0x00000001802CC3B0-0x00000001802CC470
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale); // 0x00000001802CD5D0-0x00000001802CD6B0
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale); // 0x00000001802CA300-0x00000001802CA3D0
		public RESULT set3DNumListeners(int numlisteners); // 0x00000001802CD460-0x00000001802CD510
		public RESULT get3DNumListeners(out int numlisteners); // 0x00000001802CA250-0x00000001802CA300
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up); // 0x00000001802CD380-0x00000001802CD460
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up); // 0x00000001802CA170-0x00000001802CA250
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback); // 0x00000001802CD510-0x00000001802CD5D0
		public RESULT mixerSuspend(); // 0x00000001802CCD40-0x00000001802CCD50
		public RESULT mixerResume(); // 0x00000001802CCD30-0x00000001802CCD40
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop); // 0x00000001802CAD60-0x00000001802CAE40
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels); // 0x00000001802CC200-0x00000001802CC2C0
		public RESULT getVersion(out uint version); // 0x00000001802CC6A0-0x00000001802CC750
		public RESULT getOutputHandle(out IntPtr handle); // 0x00000001802CB970-0x00000001802CBA20
		public RESULT getChannelsPlaying(out int channels); // 0x00000001802CAB00-0x00000001802CABD0
		public RESULT getChannelsPlaying(out int channels, out int realchannels); // 0x00000001802CAAF0-0x00000001802CAB00
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total); // 0x00000001802CA940-0x00000001802CAA20
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead); // 0x00000001802CAFC0-0x00000001802CB090
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001802C9AC0-0x00000001802C9AD0
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001802C9CB0-0x00000001802C9CD0
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001802C9900-0x00000001802C9AC0
		public RESULT createSound(string name, MODE mode, out Sound sound); // 0x00000001802C9AD0-0x00000001802C9CB0
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001802C9CD0-0x00000001802C9CE0
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001802C9EC0-0x00000001802C9EE0
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001802C9EE0-0x00000001802CA0A0
		public RESULT createStream(string name, MODE mode, out Sound sound); // 0x00000001802C9CE0-0x00000001802C9EC0
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp); // 0x00000001802C95E0-0x00000001802C9780
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp); // 0x00000001802C9520-0x00000001802C95E0
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup); // 0x00000001802C9450-0x00000001802C9460
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup); // 0x00000001802C98F0-0x00000001802C9900
		public RESULT createReverb3D(out Reverb3D reverb); // 0x00000001802C9840-0x00000001802C98F0
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel); // 0x00000001802CCE30-0x00000001802CCF10
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel); // 0x00000001802CCD50-0x00000001802CCE30
		public RESULT getChannel(int channelid, out Channel channel); // 0x00000001802CAA30-0x00000001802CAAF0
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup); // 0x00000001802CB3A0-0x00000001802CB3B0
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup); // 0x00000001802CB3B0-0x00000001802CB460
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false /* Metadata: 0x0074580C */); // 0x00000001802C9160-0x00000001802C9230
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup); // 0x00000001802CA0A0-0x00000001802CA150
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop); // 0x00000001802CE080-0x00000001802CE140
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop); // 0x00000001802CBFB0-0x00000001802CC070
		public RESULT lockDSP(); // 0x00000001802CCC60-0x00000001802CCD00
		public RESULT unlockDSP(); // 0x00000001802CE660-0x00000001802CE700
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected); // 0x00000001802CBE30-0x00000001802CBEF0
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state); // 0x00000001802CBD80-0x00000001802CBD90
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state); // 0x00000001802CBD90-0x00000001802CBE30
		public RESULT getRecordPosition(int id, out uint position); // 0x00000001802CBEF0-0x00000001802CBFB0
		public RESULT recordStart(int id, Sound sound, bool loop); // 0x00000001802CCF10-0x00000001802CCFE0
		public RESULT recordStop(int id); // 0x00000001802CCFE0-0x00000001802CD090
		public RESULT isRecording(int id, out bool recording); // 0x00000001802CC8A0-0x00000001802CC970
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry); // 0x00000001802C9780-0x00000001802C9840
		public RESULT setGeometrySettings(float maxworldsize); // 0x00000001802CDB60-0x00000001802CDC10
		public RESULT getGeometrySettings(out float maxworldsize); // 0x00000001802CB170-0x00000001802CB220
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry); // 0x00000001802CCB80-0x00000001802CCC50
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb); // 0x00000001802CB090-0x00000001802CB170
		public RESULT setNetworkProxy(string proxy); // 0x00000001802CDD10-0x00000001802CDD20
		public RESULT getNetworkProxy(out string proxy, int proxylen); // 0x00000001802CB520-0x00000001802CB530
		public RESULT setNetworkTimeout(int timeout); // 0x00000001802CDD20-0x00000001802CDDD0
		public RESULT getNetworkTimeout(out int timeout); // 0x00000001802CB530-0x00000001802CB5E0
		public RESULT setUserData(IntPtr userdata); // 0x00000001802CE300-0x00000001802CE3B0
		public RESULT getUserData(out IntPtr userdata); // 0x00000001802CC470-0x00000001802CC520
		private static extern RESULT FMOD5_System_Release(IntPtr system); // 0x0000000181B31880-0x0000000181B31920
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output); // 0x0000000181B32330-0x0000000181B323E0
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output); // 0x0000000181B303D0-0x0000000181B30480
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers); // 0x0000000181B30060-0x0000000181B30110
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels); // 0x0000000181B2F8C0-0x0000000181B2F9C0
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver); // 0x0000000181B31E60-0x0000000181B31F10
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver); // 0x0000000181B2F9C0-0x0000000181B2FA70
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels); // 0x0000000181B32550-0x0000000181B32600
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels); // 0x0000000181B30950-0x0000000181B30A00
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers); // 0x0000000181B32600-0x0000000181B326C0
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers); // 0x0000000181B30A00-0x0000000181B30AD0
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers); // 0x0000000181B31DB0-0x0000000181B31E60
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers); // 0x0000000181B2F670-0x0000000181B2F730
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign); // 0x0000000181B31F10-0x0000000181B32060
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek); // 0x0000000181B2E0D0-0x0000000181B2E1D0
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings); // 0x0000000181B31C40-0x0000000181B31CF0
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings); // 0x0000000181B2F2B0-0x0000000181B2F360
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask); // 0x0000000181B31CF0-0x0000000181B31DB0
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path); // 0x0000000181B323E0-0x0000000181B324A0
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority); // 0x0000000181B310F0-0x0000000181B311D0
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle); // 0x0000000181B32900-0x0000000181B329B0
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count); // 0x0000000181B30110-0x0000000181B301C0
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle); // 0x0000000181B2FE30-0x0000000181B2FEF0
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins); // 0x0000000181B301C0-0x0000000181B30270
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle); // 0x0000000181B30480-0x0000000181B30540
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version); // 0x0000000181B30540-0x0000000181B30620
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle); // 0x0000000181B32280-0x0000000181B32330
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle); // 0x0000000181B30270-0x0000000181B30320
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp); // 0x0000000181B2E340-0x0000000181B2E3F0
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description); // 0x0000000181B2F730-0x0000000181B2F7E0
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle); // 0x0000000181B316E0-0x0000000181B31880
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata); // 0x0000000181B30E90-0x0000000181B30F50
		private static extern RESULT FMOD5_System_Close(IntPtr system); // 0x0000000181B2E1D0-0x0000000181B2E270
		private static extern RESULT FMOD5_System_Update(IntPtr system); // 0x0000000181B32A50-0x0000000181B32AF0
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active); // 0x0000000181B326C0-0x0000000181B327A0
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active); // 0x0000000181B30B80-0x0000000181B30C70
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype); // 0x0000000181B327A0-0x0000000181B32850
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype); // 0x0000000181B30C70-0x0000000181B30D30
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale); // 0x0000000181B31B60-0x0000000181B31C40
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale); // 0x0000000181B2F1E0-0x0000000181B2F2B0
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners); // 0x0000000181B31A00-0x0000000181B31AB0
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners); // 0x0000000181B2F130-0x0000000181B2F1E0
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up); // 0x0000000181B31920-0x0000000181B31A00
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up); // 0x0000000181B2F050-0x0000000181B2F130
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback); // 0x0000000181B31AB0-0x0000000181B31B60
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system); // 0x0000000181B31310-0x0000000181B313B0
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system); // 0x0000000181B31270-0x0000000181B31310
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop); // 0x0000000181B2F7E0-0x0000000181B2F8C0
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels); // 0x0000000181B30AD0-0x0000000181B30B80
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version); // 0x0000000181B30DE0-0x0000000181B30E90
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle); // 0x0000000181B30320-0x0000000181B303D0
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero); // 0x0000000181B2F4F0-0x0000000181B2F5B0
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels); // 0x0000000181B2F5B0-0x0000000181B2F670
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total); // 0x0000000181B2F360-0x0000000181B2F440
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead); // 0x0000000181B2FA70-0x0000000181B2FB40
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181B2E880-0x0000000181B2EA50
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181B2EA50-0x0000000181B2EC10
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181B2EDD0-0x0000000181B2EFA0
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181B2EC10-0x0000000181B2EDD0
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp); // 0x0000000181B2E4A0-0x0000000181B2E640
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp); // 0x0000000181B2E3F0-0x0000000181B2E4A0
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup); // 0x0000000181B2E270-0x0000000181B2E340
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup); // 0x0000000181B2E7B0-0x0000000181B2E880
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb); // 0x0000000181B2E700-0x0000000181B2E7B0
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel); // 0x0000000181B31490-0x0000000181B31570
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel); // 0x0000000181B313B0-0x0000000181B31490
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel); // 0x0000000181B2F440-0x0000000181B2F4F0
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup); // 0x0000000181B2FCD0-0x0000000181B2FD80
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup); // 0x0000000181B2FD80-0x0000000181B2FE30
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru); // 0x0000000181B2E000-0x0000000181B2E0D0
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup); // 0x0000000181B2EFA0-0x0000000181B2F050
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop); // 0x0000000181B324A0-0x0000000181B32550
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop); // 0x0000000181B308A0-0x0000000181B30950
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system); // 0x0000000181B311D0-0x0000000181B31270
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system); // 0x0000000181B329B0-0x0000000181B32A50
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected); // 0x0000000181B30730-0x0000000181B307F0
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state); // 0x0000000181B30620-0x0000000181B30730
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position); // 0x0000000181B307F0-0x0000000181B308A0
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop); // 0x0000000181B31570-0x0000000181B31630
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id); // 0x0000000181B31630-0x0000000181B316E0
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording); // 0x0000000181B30F50-0x0000000181B31020
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry); // 0x0000000181B2E640-0x0000000181B2E700
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize); // 0x0000000181B32060-0x0000000181B32110
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize); // 0x0000000181B2FC20-0x0000000181B2FCD0
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry); // 0x0000000181B31020-0x0000000181B310F0
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb); // 0x0000000181B2FB40-0x0000000181B2FC20
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy); // 0x0000000181B32110-0x0000000181B321D0
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen); // 0x0000000181B2FEF0-0x0000000181B2FFB0
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout); // 0x0000000181B321D0-0x0000000181B32280
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout); // 0x0000000181B2FFB0-0x0000000181B30060
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata); // 0x0000000181B32850-0x0000000181B32900
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata); // 0x0000000181B30D30-0x0000000181B30DE0
		public bool hasHandle(); // 0x00000001802CC750-0x00000001802CC790
		public void clearHandle(); // 0x00000001802C9330-0x00000001802C9370
	}
}
