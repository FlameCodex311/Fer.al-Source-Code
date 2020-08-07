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
	public struct EventDescription // TypeDefIndex: 10271
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x000000018011EF30-0x000000018011EFC0
		public RESULT getPath(out string path); // 0x000000018011F370-0x000000018011F380
		public RESULT getParameterDescriptionCount(out int count); // 0x000000018011F2E0-0x000000018011F370
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter); // 0x000000018011F230-0x000000018011F2D0
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter); // 0x000000018011F2D0-0x000000018011F2E0
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x000000018011F190-0x000000018011F230
		public RESULT getUserPropertyCount(out int count); // 0x000000018011F610-0x000000018011F6A0
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property); // 0x000000018011F530-0x000000018011F610
		public RESULT getUserProperty(string name, out USER_PROPERTY property); // 0x000000018011F6A0-0x000000018011F6B0
		public RESULT getLength(out int length); // 0x000000018011EFE0-0x000000018011F070
		public RESULT getMinimumDistance(out float distance); // 0x000000018011F100-0x000000018011F190
		public RESULT getMaximumDistance(out float distance); // 0x000000018011F070-0x000000018011F100
		public RESULT getSoundSize(out float size); // 0x000000018011F410-0x000000018011F4A0
		public RESULT isSnapshot(out bool snapshot); // 0x000000018011F8D0-0x000000018011F970
		public RESULT isOneshot(out bool oneshot); // 0x000000018011F830-0x000000018011F8D0
		public RESULT isStream(out bool isStream); // 0x000000018011F970-0x000000018011FA10
		public RESULT is3D(out bool is3D); // 0x000000018011F790-0x000000018011F830
		public RESULT hasCue(out bool cue); // 0x000000018011F6B0-0x000000018011F750
		public RESULT createInstance(out EventInstance instance); // 0x000000018011EEA0-0x000000018011EF30
		public RESULT getInstanceCount(out int count); // 0x000000018011EFC0-0x000000018011EFD0
		public RESULT getInstanceList(out EventInstance[] array); // 0x000000018011EFD0-0x000000018011EFE0
		public RESULT loadSampleData(); // 0x000000018011FAD0-0x000000018011FB50
		public RESULT unloadSampleData(); // 0x000000018011FD00-0x000000018011FD80
		public RESULT getSampleLoadingState(out LOADING_STATE state); // 0x000000018011F380-0x000000018011F410
		public RESULT releaseAllInstances(); // 0x000000018011FB50-0x000000018011FBD0
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.CREATED | EVENT_CALLBACK_TYPE.DESTROYED | EVENT_CALLBACK_TYPE.STARTING | EVENT_CALLBACK_TYPE.STARTED | EVENT_CALLBACK_TYPE.RESTARTED | EVENT_CALLBACK_TYPE.STOPPED | EVENT_CALLBACK_TYPE.START_FAILED | EVENT_CALLBACK_TYPE.CREATE_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.DESTROY_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.PLUGIN_CREATED | EVENT_CALLBACK_TYPE.PLUGIN_DESTROYED | EVENT_CALLBACK_TYPE.TIMELINE_MARKER | EVENT_CALLBACK_TYPE.TIMELINE_BEAT | EVENT_CALLBACK_TYPE.SOUND_PLAYED | EVENT_CALLBACK_TYPE.SOUND_STOPPED | EVENT_CALLBACK_TYPE.REAL_TO_VIRTUAL | EVENT_CALLBACK_TYPE.VIRTUAL_TO_REAL | EVENT_CALLBACK_TYPE.ALL /* Metadata: 0x0077B96E */); // 0x000000018011FBD0-0x000000018011FC70
		public RESULT getUserData(out IntPtr userdata); // 0x000000018011F4A0-0x000000018011F530
		public RESULT setUserData(IntPtr userdata); // 0x000000018011FC70-0x000000018011FD00
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription); // 0x0000000181BDC750-0x0000000181BDC7D0
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id); // 0x0000000181BDB960-0x0000000181BDB9F0
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved); // 0x0000000181BDBF70-0x0000000181BDC020
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count); // 0x0000000181BDBEE0-0x0000000181BDBF70
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter); // 0x0000000181BDBD90-0x0000000181BDBE30
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter); // 0x0000000181BDBE30-0x0000000181BDBEE0
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x0000000181BDBCF0-0x0000000181BDBD90
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count); // 0x0000000181BDC2B0-0x0000000181BDC340
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property); // 0x0000000181BDC1D0-0x0000000181BDC2B0
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property); // 0x0000000181BDC340-0x0000000181BDC430
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length); // 0x0000000181BDBB40-0x0000000181BDBBD0
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance); // 0x0000000181BDBC60-0x0000000181BDBCF0
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance); // 0x0000000181BDBBD0-0x0000000181BDBC60
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size); // 0x0000000181BDC0B0-0x0000000181BDC140
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot); // 0x0000000181BDC610-0x0000000181BDC6B0
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot); // 0x0000000181BDC570-0x0000000181BDC610
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream); // 0x0000000181BDC6B0-0x0000000181BDC750
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D); // 0x0000000181BDC4D0-0x0000000181BDC570
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue); // 0x0000000181BDC430-0x0000000181BDC4D0
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance); // 0x0000000181BDB8D0-0x0000000181BDB960
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count); // 0x0000000181BDB9F0-0x0000000181BDBA80
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count); // 0x0000000181BDBA80-0x0000000181BDBB40
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription); // 0x0000000181BDC7D0-0x0000000181BDC850
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription); // 0x0000000181BDCA00-0x0000000181BDD7A0
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state); // 0x0000000181BDC020-0x0000000181BDC0B0
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription); // 0x0000000181BDC850-0x0000000181BDC8D0
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask); // 0x0000000181BDC8D0-0x0000000181BDC970
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata); // 0x0000000181BDC140-0x0000000181BDC1D0
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata); // 0x0000000181BDC970-0x0000000181BDCA00
		public bool hasHandle(); // 0x000000018011F750-0x000000018011F790
		public void clearHandle(); // 0x000000018011EE60-0x000000018011EEA0
		public bool isValid(); // 0x000000018011FA10-0x000000018011FAD0
	}
}
