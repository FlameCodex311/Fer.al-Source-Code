/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct System // TypeDefIndex: 10115
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x0000000180125D80-0x0000000180125E00
		public RESULT setOutput(OUTPUTTYPE output); // 0x0000000180126A80-0x0000000180126B10
		public RESULT getOutput(out OUTPUTTYPE output); // 0x00000001801243D0-0x0000000180124460
		public RESULT getNumDrivers(out int numdrivers); // 0x0000000180124050-0x00000001801240E0
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels); // 0x0000000180123950-0x0000000180123960
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels); // 0x00000001801238C0-0x0000000180123950
		public RESULT setDriver(int driver); // 0x0000000180126520-0x00000001801265B0
		public RESULT getDriver(out int driver); // 0x0000000180123960-0x00000001801239F0
		public RESULT setSoftwareChannels(int numsoftwarechannels); // 0x0000000180126D50-0x0000000180126DE0
		public RESULT getSoftwareChannels(out int numsoftwarechannels); // 0x00000001801249F0-0x0000000180124A80
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers); // 0x0000000180126DE0-0x0000000180126E90
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers); // 0x0000000180124A80-0x0000000180124B30
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers); // 0x0000000180126480-0x0000000180126520
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers); // 0x00000001801236C0-0x0000000180123760
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign); // 0x00000001801265B0-0x00000001801266D0
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek); // 0x0000000180121D30-0x0000000180121E10
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings); // 0x0000000180126160-0x0000000180126310
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings); // 0x0000000180122E20-0x0000000180122FD0
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.DEVICELISTCHANGED | SYSTEM_CALLBACK_TYPE.DEVICELOST | SYSTEM_CALLBACK_TYPE.MEMORYALLOCATIONFAILED | SYSTEM_CALLBACK_TYPE.THREADCREATED | SYSTEM_CALLBACK_TYPE.BADDSPCONNECTION | SYSTEM_CALLBACK_TYPE.PREMIX | SYSTEM_CALLBACK_TYPE.POSTMIX | SYSTEM_CALLBACK_TYPE.ERROR | SYSTEM_CALLBACK_TYPE.MIDMIX | SYSTEM_CALLBACK_TYPE.THREADDESTROYED | SYSTEM_CALLBACK_TYPE.PREUPDATE | SYSTEM_CALLBACK_TYPE.POSTUPDATE | SYSTEM_CALLBACK_TYPE.RECORDLISTCHANGED | SYSTEM_CALLBACK_TYPE.ALL /* Metadata: 0x0077B2B6 */); // 0x0000000180126340-0x00000001801263E0
		public RESULT setPluginPath(string path); // 0x0000000180126CA0-0x0000000180126CB0
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0 /* Metadata: 0x0077B2BA */); // 0x0000000180125700-0x0000000180125710
		public RESULT unloadPlugin(uint handle); // 0x0000000180127220-0x00000001801272B0
		public RESULT getNumNestedPlugins(uint handle, out int count); // 0x0000000180124170-0x0000000180124210
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle); // 0x0000000180123F00-0x0000000180123FB0
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins); // 0x0000000180124210-0x00000001801242B0
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle); // 0x0000000180124630-0x00000001801246E0
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version); // 0x00000001801246E0-0x00000001801246F0
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version); // 0x00000001801246F0-0x0000000180124760
		public RESULT setOutputByPlugin(uint handle); // 0x00000001801269F0-0x0000000180126A80
		public RESULT getOutputByPlugin(out uint handle); // 0x00000001801242B0-0x0000000180124340
		public RESULT createDSPByPlugin(uint handle, out DSP dsp); // 0x0000000180121F20-0x0000000180121FC0
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description); // 0x0000000180123760-0x0000000180123800
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle); // 0x0000000180125B80-0x0000000180125D00
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata); // 0x0000000180125030-0x00000001801250E0
		public RESULT close(); // 0x0000000180121E90-0x0000000180121F10
		public RESULT update(); // 0x00000001801273B0-0x0000000180127430
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active); // 0x0000000180126E90-0x0000000180126F50
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active); // 0x0000000180124BE0-0x0000000180124CB0
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype); // 0x0000000180126F50-0x0000000180126FF0
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype); // 0x0000000180124CB0-0x0000000180124D50
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale); // 0x0000000180126070-0x0000000180126130
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale); // 0x0000000180122D70-0x0000000180122E20
		public RESULT set3DNumListeners(int numlisteners); // 0x0000000180125F40-0x0000000180125FD0
		public RESULT get3DNumListeners(out int numlisteners); // 0x0000000180122CE0-0x0000000180122D70
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up); // 0x0000000180125E80-0x0000000180125F40
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up); // 0x0000000180122C20-0x0000000180122CE0
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback); // 0x0000000180125FD0-0x0000000180126070
		public RESULT mixerSuspend(); // 0x0000000180125840-0x00000001801258C0
		public RESULT mixerResume(); // 0x00000001801257C0-0x0000000180125840
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop); // 0x0000000180123800-0x00000001801238C0
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels); // 0x0000000180124B40-0x0000000180124BE0
		public RESULT getVersion(out uint version); // 0x0000000180124F20-0x0000000180124FB0
		public RESULT getOutputHandle(out IntPtr handle); // 0x0000000180124340-0x00000001801243D0
		public RESULT getChannelsPlaying(out int channels); // 0x0000000180123580-0x0000000180123630
		public RESULT getChannelsPlaying(out int channels, out int realchannels); // 0x00000001801234E0-0x0000000180123580
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total); // 0x00000001801232F0-0x00000001801233B0
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead); // 0x0000000180123AA0-0x0000000180123B50
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001801224D0-0x00000001801224E0
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001801226C0-0x00000001801226E0
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x0000000180122330-0x00000001801224D0
		public RESULT createSound(string name, MODE mode, out Sound sound); // 0x00000001801224E0-0x00000001801226C0
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001801226E0-0x00000001801226F0
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001801228D0-0x00000001801228F0
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound); // 0x00000001801228F0-0x0000000180122A90
		public RESULT createStream(string name, MODE mode, out Sound sound); // 0x00000001801226F0-0x00000001801228D0
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp); // 0x0000000180122060-0x00000001801221E0
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp); // 0x0000000180121FC0-0x0000000180122060
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup); // 0x0000000180121F10-0x0000000180121F20
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup); // 0x0000000180122320-0x0000000180122330
		public RESULT createReverb3D(out Reverb3D reverb); // 0x0000000180122290-0x0000000180122320
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel); // 0x0000000180125980-0x0000000180125A40
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel); // 0x00000001801258C0-0x0000000180125980
		public RESULT getChannel(int channelid, out Channel channel); // 0x0000000180123440-0x00000001801234E0
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup); // 0x0000000180123DE0-0x0000000180123E70
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup); // 0x0000000180123E70-0x0000000180123F00
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false /* Metadata: 0x0077B2BE */); // 0x0000000180121C80-0x0000000180121D30
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup); // 0x0000000180122A90-0x0000000180122B20
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop); // 0x0000000180126CB0-0x0000000180126D50
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop); // 0x0000000180124950-0x00000001801249F0
		public RESULT lockDSP(); // 0x0000000180125710-0x0000000180125790
		public RESULT unlockDSP(); // 0x00000001801272B0-0x0000000180127330
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected); // 0x0000000180124810-0x00000001801248B0
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state); // 0x0000000180124760-0x0000000180124770
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state); // 0x0000000180124770-0x0000000180124810
		public RESULT getRecordPosition(int id, out uint position); // 0x00000001801248B0-0x0000000180124950
		public RESULT recordStart(int id, Sound sound, bool loop); // 0x0000000180125A40-0x0000000180125AF0
		public RESULT recordStop(int id); // 0x0000000180125AF0-0x0000000180125B80
		public RESULT isRecording(int id, out bool recording); // 0x00000001801251A0-0x0000000180125250
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry); // 0x00000001801221E0-0x0000000180122290
		public RESULT setGeometrySettings(float maxworldsize); // 0x00000001801266D0-0x0000000180126760
		public RESULT getGeometrySettings(out float maxworldsize); // 0x0000000180123C10-0x0000000180123CA0
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry); // 0x0000000180125650-0x0000000180125700
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb); // 0x0000000180123B50-0x0000000180123C10
		public RESULT setNetworkProxy(string proxy); // 0x00000001801268C0-0x00000001801268D0
		public RESULT getNetworkProxy(out string proxy, int proxylen); // 0x0000000180123FB0-0x0000000180123FC0
		public RESULT setNetworkTimeout(int timeout); // 0x00000001801268D0-0x0000000180126960
		public RESULT getNetworkTimeout(out int timeout); // 0x0000000180123FC0-0x0000000180124050
		public RESULT setUserData(IntPtr userdata); // 0x0000000180126FF0-0x0000000180127080
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180124D50-0x0000000180124DE0
		private static extern RESULT FMOD5_System_Release(IntPtr system); // 0x0000000181BE38A0-0x0000000181BE3920
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output); // 0x0000000181BE41A0-0x0000000181BE4230
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output); // 0x0000000181BE26F0-0x0000000181BE2780
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers); // 0x0000000181BE2400-0x0000000181BE2490
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels); // 0x0000000181BE1DA0-0x0000000181BE1E80
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver); // 0x0000000181BE3DA0-0x0000000181BE3E30
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver); // 0x0000000181BE1E80-0x0000000181BE1F10
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels); // 0x0000000181BE4370-0x0000000181BE4400
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels); // 0x0000000181BE2BB0-0x0000000181BE2C40
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers); // 0x0000000181BE4400-0x0000000181BE44A0
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers); // 0x0000000181BE2C40-0x0000000181BE2CF0
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers); // 0x0000000181BE3D00-0x0000000181BE3DA0
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers); // 0x0000000181BE1BA0-0x0000000181BE1C40
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign); // 0x0000000181BE3E30-0x0000000181BE3F50
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek); // 0x0000000181BE0890-0x0000000181BE0970
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings); // 0x0000000181BE3BD0-0x0000000181BE3C60
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings); // 0x0000000181BE1870-0x0000000181BE1900
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask); // 0x0000000181BE3C60-0x0000000181BE3D00
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path); // 0x0000000181BE4230-0x0000000181BE42D0
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority); // 0x0000000181BE3220-0x0000000181BE32E0
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle); // 0x0000000181BE4690-0x0000000181BE4720
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count); // 0x0000000181BE2490-0x0000000181BE2530
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle); // 0x0000000181BE2230-0x0000000181BE22D0
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins); // 0x0000000181BE2530-0x0000000181BE25D0
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle); // 0x0000000181BE2780-0x0000000181BE2820
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version); // 0x0000000181BE2820-0x0000000181BE28E0
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle); // 0x0000000181BE4110-0x0000000181BE41A0
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle); // 0x0000000181BE25D0-0x0000000181BE2660
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp); // 0x0000000181BE0AA0-0x0000000181BE0B40
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description); // 0x0000000181BE1C40-0x0000000181BE1CE0
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle); // 0x0000000181BE3720-0x0000000181BE38A0
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata); // 0x0000000181BE3020-0x0000000181BE30C0
		private static extern RESULT FMOD5_System_Close(IntPtr system); // 0x0000000181BE0970-0x0000000181BE09F0
		private static extern RESULT FMOD5_System_Update(IntPtr system); // 0x0000000181BE47A0-0x0000000181BE4820
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active); // 0x0000000181BE44A0-0x0000000181BE4560
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active); // 0x0000000181BE2D90-0x0000000181BE2E60
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype); // 0x0000000181BE4560-0x0000000181BE4600
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype); // 0x0000000181BE2E60-0x0000000181BE2F00
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale); // 0x0000000181BE3B10-0x0000000181BE3BD0
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale); // 0x0000000181BE17C0-0x0000000181BE1870
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners); // 0x0000000181BE39E0-0x0000000181BE3A70
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners); // 0x0000000181BE1730-0x0000000181BE17C0
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up); // 0x0000000181BE3920-0x0000000181BE39E0
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up); // 0x0000000181BE1670-0x0000000181BE1730
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback); // 0x0000000181BE3A70-0x0000000181BE3B10
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system); // 0x0000000181BE33E0-0x0000000181BE3460
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system); // 0x0000000181BE3360-0x0000000181BE33E0
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop); // 0x0000000181BE1CE0-0x0000000181BE1DA0
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels); // 0x0000000181BE2CF0-0x0000000181BE2D90
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version); // 0x0000000181BE2F90-0x0000000181BE3020
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle); // 0x0000000181BE2660-0x0000000181BE26F0
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero); // 0x0000000181BE1A60-0x0000000181BE1B00
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels); // 0x0000000181BE1B00-0x0000000181BE1BA0
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total); // 0x0000000181BE1900-0x0000000181BE19C0
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead); // 0x0000000181BE1F10-0x0000000181BE1FC0
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181BE0F40-0x0000000181BE10F0
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181BE10F0-0x0000000181BE1290
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181BE1430-0x0000000181BE15E0
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound); // 0x0000000181BE1290-0x0000000181BE1430
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp); // 0x0000000181BE0BE0-0x0000000181BE0D60
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp); // 0x0000000181BE0B40-0x0000000181BE0BE0
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup); // 0x0000000181BE09F0-0x0000000181BE0AA0
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup); // 0x0000000181BE0E90-0x0000000181BE0F40
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb); // 0x0000000181BE0E00-0x0000000181BE0E90
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel); // 0x0000000181BE3520-0x0000000181BE35E0
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel); // 0x0000000181BE3460-0x0000000181BE3520
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel); // 0x0000000181BE19C0-0x0000000181BE1A60
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup); // 0x0000000181BE2110-0x0000000181BE21A0
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup); // 0x0000000181BE21A0-0x0000000181BE2230
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru); // 0x0000000181BE07E0-0x0000000181BE0890
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup); // 0x0000000181BE15E0-0x0000000181BE1670
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop); // 0x0000000181BE42D0-0x0000000181BE4370
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop); // 0x0000000181BE2B10-0x0000000181BE2BB0
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system); // 0x0000000181BE32E0-0x0000000181BE3360
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system); // 0x0000000181BE4720-0x0000000181BE47A0
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected); // 0x0000000181BE29D0-0x0000000181BE2A70
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state); // 0x0000000181BE28E0-0x0000000181BE29D0
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position); // 0x0000000181BE2A70-0x0000000181BE2B10
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop); // 0x0000000181BE35E0-0x0000000181BE3690
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id); // 0x0000000181BE3690-0x0000000181BE3720
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording); // 0x0000000181BE30C0-0x0000000181BE3170
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry); // 0x0000000181BE0D60-0x0000000181BE0E00
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize); // 0x0000000181BE3F50-0x0000000181BE3FE0
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize); // 0x0000000181BE2080-0x0000000181BE2110
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry); // 0x0000000181BE3170-0x0000000181BE3220
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb); // 0x0000000181BE1FC0-0x0000000181BE2080
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy); // 0x0000000181BE3FE0-0x0000000181BE4080
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen); // 0x0000000181BE22D0-0x0000000181BE2370
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout); // 0x0000000181BE4080-0x0000000181BE4110
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout); // 0x0000000181BE2370-0x0000000181BE2400
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata); // 0x0000000181BE4600-0x0000000181BE4690
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata); // 0x0000000181BE2F00-0x0000000181BE2F90
		public bool hasHandle(); // 0x0000000180124FB0-0x0000000180124FF0
		public void clearHandle(); // 0x0000000180121E10-0x0000000180121E50
	}
}
