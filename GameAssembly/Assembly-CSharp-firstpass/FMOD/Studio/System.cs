/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD.Studio
{
	public struct System // TypeDefIndex: 9816
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public static RESULT create(out System system); // 0x0000000181B35A50-0x0000000181B39B00
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings); // 0x00000001802CD6B0-0x00000001802CD6E0
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey); // 0x00000001802CD6F0-0x00000001802CD720
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings); // 0x00000001802CA5A0-0x00000001802CA6D0
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, INITFLAGS flags, IntPtr extradriverdata); // 0x00000001802CC890-0x00000001802CC8A0
		public RESULT release(); // 0x00000001802CD230-0x00000001802CD240
		public RESULT update(); // 0x00000001802CE700-0x00000001802CE710
		public RESULT getCoreSystem(out FMOD.System coresystem); // 0x00000001802CABD0-0x00000001802CABE0
		public RESULT getEvent(string path, out EventDescription _event); // 0x00000001802CAFB0-0x00000001802CAFC0
		public RESULT getBus(string path, out Bus bus); // 0x00000001802CA930-0x00000001802CA940
		public RESULT getVCA(string path, out VCA vca); // 0x00000001802CC690-0x00000001802CC6A0
		public RESULT getBank(string path, out Bank bank); // 0x00000001802CA7B0-0x00000001802CA7C0
		public RESULT getEventByID(Guid id, out EventDescription _event); // 0x00000001802CAF90-0x00000001802CAFB0
		public RESULT getBusByID(Guid id, out Bus bus); // 0x00000001802CA870-0x00000001802CA930
		public RESULT getVCAByID(Guid id, out VCA vca); // 0x00000001802CC5D0-0x00000001802CC690
		public RESULT getBankByID(Guid id, out Bank bank); // 0x00000001802CA6D0-0x00000001802CA790
		public RESULT getSoundInfo(string key, out SOUND_INFO info); // 0x00000001802CC1F0-0x00000001802CC200
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter); // 0x00000001802CBC10-0x00000001802CBC20
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x00000001802CBB50-0x00000001802CBC10
		public RESULT getParameterByID(PARAMETER_ID id, out float value); // 0x00000001802CBAD0-0x00000001802CBB00
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue); // 0x00000001802CBB00-0x00000001802CBB10
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false /* Metadata: 0x00745EB5 */); // 0x00000001802CDEA0-0x00000001802CDF70
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false /* Metadata: 0x00745EB6 */); // 0x00000001802CDF80-0x00000001802CE070
		public RESULT getParameterByName(string name, out float value); // 0x00000001802CBB20-0x00000001802CBB50
		public RESULT getParameterByName(string name, out float value, out float finalvalue); // 0x00000001802CBB10-0x00000001802CBB20
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false /* Metadata: 0x00745EB7 */); // 0x00000001802CDF70-0x00000001802CDF80
		public RESULT lookupID(string path, out Guid id); // 0x00000001802CCD00-0x00000001802CCD10
		public RESULT lookupPath(Guid id, out string path); // 0x00000001802CCD10-0x00000001802CCD30
		public RESULT getNumListeners(out int numlisteners); // 0x00000001802CB690-0x00000001802CB740
		public RESULT setNumListeners(int numlisteners); // 0x00000001802CDDD0-0x00000001802CDDE0
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes); // 0x00000001802CB220-0x00000001802CB2E0
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes); // 0x00000001802CDC10-0x00000001802CDC50
		public RESULT getListenerWeight(int listener, out float weight); // 0x00000001802CB2E0-0x00000001802CB3A0
		public RESULT setListenerWeight(int listener, float weight); // 0x00000001802CDC50-0x00000001802CDD10
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank); // 0x00000001802CCB50-0x00000001802CCB60
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank); // 0x00000001802CCB60-0x00000001802CCB70
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank); // 0x00000001802CC980-0x00000001802CCB50
		public RESULT unloadAll(); // 0x00000001802CE510-0x00000001802CE5B0
		public RESULT flushCommands(); // 0x00000001802CA150-0x00000001802CA160
		public RESULT flushSampleLoading(); // 0x00000001802CA160-0x00000001802CA170
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags); // 0x00000001802CE460-0x00000001802CE470
		public RESULT stopCommandCapture(); // 0x00000001802CE470-0x00000001802CE510
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay); // 0x00000001802CCB70-0x00000001802CCB80
		public RESULT getBankCount(out int count); // 0x00000001802CA790-0x00000001802CA7A0
		public RESULT getBankList(out Bank[] array); // 0x00000001802CA7A0-0x00000001802CA7B0
		public RESULT getParameterDescriptionCount(out int count); // 0x00000001802CBC20-0x00000001802CBC30
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array); // 0x00000001802CBC30-0x00000001802CBC40
		public RESULT getCPUUsage(out CPU_USAGE usage); // 0x00000001802CAA20-0x00000001802CAA30
		public RESULT getBufferUsage(out BUFFER_USAGE usage); // 0x00000001802CA7C0-0x00000001802CA870
		public RESULT resetBufferUsage(); // 0x00000001802CD2E0-0x00000001802CD380
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.PREUPDATE | SYSTEM_CALLBACK_TYPE.POSTUPDATE | SYSTEM_CALLBACK_TYPE.BANK_UNLOAD | SYSTEM_CALLBACK_TYPE.ALL /* Metadata: 0x00745EB8 */); // 0x00000001802CD7E0-0x00000001802CD8A0
		public RESULT getUserData(out IntPtr userdata); // 0x00000001802CC520-0x00000001802CC5D0
		public RESULT setUserData(IntPtr userdata); // 0x00000001802CE3B0-0x00000001802CE460
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion); // 0x0000000181B32AF0-0x0000000181B32BA0
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system); // 0x0000000181B342C0-0x0000000181B34360
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings); // 0x0000000181B34A40-0x0000000181B34AF0
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings); // 0x0000000181B32CE0-0x0000000181B32D90
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, INITFLAGS flags, IntPtr extradriverdata); // 0x0000000181B341F0-0x0000000181B342C0
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system); // 0x0000000181B34900-0x0000000181B349A0
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system); // 0x0000000181B35330-0x0000000181B35A50
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem); // 0x0000000181B333A0-0x0000000181B33450
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event); // 0x0000000181B33510-0x0000000181B335E0
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus); // 0x0000000181B33220-0x0000000181B332F0
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca); // 0x0000000181B34120-0x0000000181B341F0
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank); // 0x0000000181B32FE0-0x0000000181B330B0
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event); // 0x0000000181B33450-0x0000000181B33510
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus); // 0x0000000181B33160-0x0000000181B33220
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca); // 0x0000000181B34060-0x0000000181B34120
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank); // 0x0000000181B32D90-0x0000000181B32E50
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info); // 0x0000000181B33D30-0x0000000181B33FB0
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter); // 0x0000000181B33A60-0x0000000181B33B30
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x0000000181B339A0-0x0000000181B33A60
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue); // 0x0000000181B337F0-0x0000000181B338C0
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed); // 0x0000000181B34DD0-0x0000000181B34EA0
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed); // 0x0000000181B34F80-0x0000000181B35070
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue); // 0x0000000181B338C0-0x0000000181B339A0
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed); // 0x0000000181B34EA0-0x0000000181B34F80
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id); // 0x0000000181B34750-0x0000000181B34820
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved); // 0x0000000181B34820-0x0000000181B34900
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners); // 0x0000000181B33740-0x0000000181B337F0
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners); // 0x0000000181B34D20-0x0000000181B34DD0
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes); // 0x0000000181B335E0-0x0000000181B33690
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes); // 0x0000000181B34BB0-0x0000000181B34C60
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight); // 0x0000000181B33690-0x0000000181B33740
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight); // 0x0000000181B34C60-0x0000000181B34D20
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank); // 0x0000000181B344B0-0x0000000181B34590
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank); // 0x0000000181B34590-0x0000000181B34670
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank); // 0x0000000181B34360-0x0000000181B344B0
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system); // 0x0000000181B35290-0x0000000181B35330
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system); // 0x0000000181B32BA0-0x0000000181B32C40
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system); // 0x0000000181B32C40-0x0000000181B32CE0
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags); // 0x0000000181B35120-0x0000000181B351F0
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system); // 0x0000000181B351F0-0x0000000181B35290
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay); // 0x0000000181B34670-0x0000000181B34750
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count); // 0x0000000181B32E50-0x0000000181B32F00
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count); // 0x0000000181B32F00-0x0000000181B32FE0
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count); // 0x0000000181B33B30-0x0000000181B33BE0
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, out PARAMETER_DESCRIPTION[] array, int capacity, out int count); // 0x0000000181B33BE0-0x0000000181B33D30
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage); // 0x0000000181B332F0-0x0000000181B333A0
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage); // 0x0000000181B330B0-0x0000000181B33160
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system); // 0x0000000181B349A0-0x0000000181B34A40
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask); // 0x0000000181B34AF0-0x0000000181B34BB0
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata); // 0x0000000181B33FB0-0x0000000181B34060
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata); // 0x0000000181B35070-0x0000000181B35120
		public bool hasHandle(); // 0x00000001802CC790-0x00000001802CC7D0
		public void clearHandle(); // 0x00000001802C9370-0x00000001802C93B0
		public bool isValid(); // 0x00000001802CC970-0x00000001802CC980
	}
}
