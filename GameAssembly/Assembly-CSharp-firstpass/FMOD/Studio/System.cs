/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD.Studio
{
	public struct System // TypeDefIndex: 10270
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public static RESULT create(out System system); // 0x0000000181BE7170-0x0000000181BEAC40
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings); // 0x0000000180126130-0x0000000180126160
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey); // 0x0000000180126310-0x0000000180126340
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings); // 0x0000000180122FD0-0x00000001801230E0
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, INITFLAGS flags, IntPtr extradriverdata); // 0x00000001801250E0-0x00000001801251A0
		public RESULT release(); // 0x0000000180125D00-0x0000000180125D80
		public RESULT update(); // 0x0000000180127330-0x00000001801273B0
		public RESULT getCoreSystem(out FMOD.System coresystem); // 0x0000000180123630-0x00000001801236C0
		public RESULT getEvent(string path, out EventDescription _event); // 0x0000000180123A90-0x0000000180123AA0
		public RESULT getBus(string path, out Bus bus); // 0x00000001801232E0-0x00000001801232F0
		public RESULT getVCA(string path, out VCA vca); // 0x0000000180124F10-0x0000000180124F20
		public RESULT getBank(string path, out Bank bank); // 0x00000001801231A0-0x00000001801231B0
		public RESULT getEventByID(Guid id, out EventDescription _event); // 0x00000001801239F0-0x0000000180123A90
		public RESULT getBusByID(Guid id, out Bus bus); // 0x0000000180123240-0x00000001801232E0
		public RESULT getVCAByID(Guid id, out VCA vca); // 0x0000000180124E70-0x0000000180124F10
		public RESULT getBankByID(Guid id, out Bank bank); // 0x00000001801230E0-0x0000000180123180
		public RESULT getSoundInfo(string key, out SOUND_INFO info); // 0x0000000180124B30-0x0000000180124B40
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter); // 0x0000000180124600-0x0000000180124610
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x0000000180124560-0x0000000180124600
		public RESULT getParameterByID(PARAMETER_ID id, out float value); // 0x0000000180124460-0x0000000180124510
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue); // 0x0000000180124510-0x0000000180124520
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false /* Metadata: 0x0077B967 */); // 0x0000000180126B10-0x0000000180126BC0
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false /* Metadata: 0x0077B968 */); // 0x0000000180126BD0-0x0000000180126CA0
		public RESULT getParameterByName(string name, out float value); // 0x0000000180124530-0x0000000180124560
		public RESULT getParameterByName(string name, out float value, out float finalvalue); // 0x0000000180124520-0x0000000180124530
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false /* Metadata: 0x0077B969 */); // 0x0000000180126BC0-0x0000000180126BD0
		public RESULT lookupID(string path, out Guid id); // 0x0000000180125790-0x00000001801257A0
		public RESULT lookupPath(Guid id, out string path); // 0x00000001801257A0-0x00000001801257C0
		public RESULT getNumListeners(out int numlisteners); // 0x00000001801240E0-0x0000000180124170
		public RESULT setNumListeners(int numlisteners); // 0x0000000180126960-0x00000001801269F0
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes); // 0x0000000180123CA0-0x0000000180123D40
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes); // 0x0000000180126760-0x0000000180126820
		public RESULT getListenerWeight(int listener, out float weight); // 0x0000000180123D40-0x0000000180123DE0
		public RESULT setListenerWeight(int listener, float weight); // 0x0000000180126820-0x00000001801268C0
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank); // 0x0000000180125510-0x0000000180125520
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank); // 0x0000000180125520-0x0000000180125640
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank); // 0x0000000180125310-0x0000000180125510
		public RESULT unloadAll(); // 0x00000001801271A0-0x0000000180127220
		public RESULT flushCommands(); // 0x0000000180122B20-0x0000000180122BA0
		public RESULT flushSampleLoading(); // 0x0000000180122BA0-0x0000000180122C20
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags); // 0x0000000180127110-0x0000000180127120
		public RESULT stopCommandCapture(); // 0x0000000180127120-0x00000001801271A0
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay); // 0x0000000180125640-0x0000000180125650
		public RESULT getBankCount(out int count); // 0x0000000180123180-0x0000000180123190
		public RESULT getBankList(out Bank[] array); // 0x0000000180123190-0x00000001801231A0
		public RESULT getParameterDescriptionCount(out int count); // 0x0000000180124610-0x0000000180124620
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array); // 0x0000000180124620-0x0000000180124630
		public RESULT getCPUUsage(out CPU_USAGE usage); // 0x00000001801233B0-0x0000000180123440
		public RESULT getBufferUsage(out BUFFER_USAGE usage); // 0x00000001801231B0-0x0000000180123240
		public RESULT resetBufferUsage(); // 0x0000000180125E00-0x0000000180125E80
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.PREUPDATE | SYSTEM_CALLBACK_TYPE.POSTUPDATE | SYSTEM_CALLBACK_TYPE.BANK_UNLOAD | SYSTEM_CALLBACK_TYPE.ALL /* Metadata: 0x0077B96A */); // 0x00000001801263E0-0x0000000180126480
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180124DE0-0x0000000180124E70
		public RESULT setUserData(IntPtr userdata); // 0x0000000180127080-0x0000000180127110
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion); // 0x0000000181BE4820-0x0000000181BE48B0
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system); // 0x0000000181BE5C70-0x0000000181BE5CF0
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings); // 0x0000000181BE6370-0x0000000181BE6400
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings); // 0x0000000181BE49B0-0x0000000181BE4A40
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, INITFLAGS flags, IntPtr extradriverdata); // 0x0000000181BE5BC0-0x0000000181BE5C70
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system); // 0x0000000181BE6270-0x0000000181BE62F0
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system); // 0x0000000181BE6AF0-0x0000000181BE7170
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem); // 0x0000000181BE4F50-0x0000000181BE4FE0
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event); // 0x0000000181BE5080-0x0000000181BE5130
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus); // 0x0000000181BE4E10-0x0000000181BE4EC0
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca); // 0x0000000181BE5B10-0x0000000181BE5BC0
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank); // 0x0000000181BE4C30-0x0000000181BE4CE0
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event); // 0x0000000181BE4FE0-0x0000000181BE5080
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus); // 0x0000000181BE4D70-0x0000000181BE4E10
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca); // 0x0000000181BE5A70-0x0000000181BE5B10
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank); // 0x0000000181BE4A40-0x0000000181BE4AE0
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info); // 0x0000000181BE5780-0x0000000181BE59E0
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter); // 0x0000000181BE5510-0x0000000181BE55C0
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x0000000181BE5470-0x0000000181BE5510
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue); // 0x0000000181BE5300-0x0000000181BE53B0
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed); // 0x0000000181BE6670-0x0000000181BE6720
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed); // 0x0000000181BE67E0-0x0000000181BE68B0
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue); // 0x0000000181BE53B0-0x0000000181BE5470
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed); // 0x0000000181BE6720-0x0000000181BE67E0
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id); // 0x0000000181BE6100-0x0000000181BE61B0
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved); // 0x0000000181BE61B0-0x0000000181BE6270
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners); // 0x0000000181BE5270-0x0000000181BE5300
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners); // 0x0000000181BE65E0-0x0000000181BE6670
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes); // 0x0000000181BE5130-0x0000000181BE51D0
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes); // 0x0000000181BE64A0-0x0000000181BE6540
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight); // 0x0000000181BE51D0-0x0000000181BE5270
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight); // 0x0000000181BE6540-0x0000000181BE65E0
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank); // 0x0000000181BE5EC0-0x0000000181BE5F80
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank); // 0x0000000181BE5F80-0x0000000181BE6040
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank); // 0x0000000181BE5CF0-0x0000000181BE5EC0
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system); // 0x0000000181BE6A70-0x0000000181BE6AF0
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system); // 0x0000000181BE48B0-0x0000000181BE4930
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system); // 0x0000000181BE4930-0x0000000181BE49B0
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags); // 0x0000000181BE6940-0x0000000181BE69F0
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system); // 0x0000000181BE69F0-0x0000000181BE6A70
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay); // 0x0000000181BE6040-0x0000000181BE6100
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count); // 0x0000000181BE4AE0-0x0000000181BE4B70
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count); // 0x0000000181BE4B70-0x0000000181BE4C30
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count); // 0x0000000181BE55C0-0x0000000181BE5650
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, out PARAMETER_DESCRIPTION[] array, int capacity, out int count); // 0x0000000181BE5650-0x0000000181BE5780
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage); // 0x0000000181BE4EC0-0x0000000181BE4F50
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage); // 0x0000000181BE4CE0-0x0000000181BE4D70
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system); // 0x0000000181BE62F0-0x0000000181BE6370
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask); // 0x0000000181BE6400-0x0000000181BE64A0
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata); // 0x0000000181BE59E0-0x0000000181BE5A70
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata); // 0x0000000181BE68B0-0x0000000181BE6940
		public bool hasHandle(); // 0x0000000180124FF0-0x0000000180125030
		public void clearHandle(); // 0x0000000180121E50-0x0000000180121E90
		public bool isValid(); // 0x0000000180125250-0x0000000180125310
	}
}
