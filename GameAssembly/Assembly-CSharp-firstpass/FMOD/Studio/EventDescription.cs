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
	public struct EventDescription // TypeDefIndex: 9817
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x00000001802C6B80-0x00000001802C6C30
		public RESULT getPath(out string path); // 0x00000001802C70A0-0x00000001802C70B0
		public RESULT getParameterDescriptionCount(out int count); // 0x00000001802C6FF0-0x00000001802C70A0
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter); // 0x00000001802C6F20-0x00000001802C6FE0
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter); // 0x00000001802C6FE0-0x00000001802C6FF0
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x00000001802C6E60-0x00000001802C6F20
		public RESULT getUserPropertyCount(out int count); // 0x00000001802C73C0-0x00000001802C7470
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property); // 0x00000001802C72C0-0x00000001802C73C0
		public RESULT getUserProperty(string name, out USER_PROPERTY property); // 0x00000001802C7470-0x00000001802C7480
		public RESULT getLength(out int length); // 0x00000001802C6C50-0x00000001802C6D00
		public RESULT getMinimumDistance(out float distance); // 0x00000001802C6DB0-0x00000001802C6E60
		public RESULT getMaximumDistance(out float distance); // 0x00000001802C6D00-0x00000001802C6DB0
		public RESULT getSoundSize(out float size); // 0x00000001802C7160-0x00000001802C7210
		public RESULT isSnapshot(out bool snapshot); // 0x00000001802C7700-0x00000001802C77C0
		public RESULT isOneshot(out bool oneshot); // 0x00000001802C7640-0x00000001802C7700
		public RESULT isStream(out bool isStream); // 0x00000001802C77C0-0x00000001802C7880
		public RESULT is3D(out bool is3D); // 0x00000001802C7580-0x00000001802C7640
		public RESULT hasCue(out bool cue); // 0x00000001802C7480-0x00000001802C7540
		public RESULT createInstance(out EventInstance instance); // 0x00000001802C6B70-0x00000001802C6B80
		public RESULT getInstanceCount(out int count); // 0x00000001802C6C30-0x00000001802C6C40
		public RESULT getInstanceList(out EventInstance[] array); // 0x00000001802C6C40-0x00000001802C6C50
		public RESULT loadSampleData(); // 0x00000001802C7890-0x00000001802C7930
		public RESULT unloadSampleData(); // 0x00000001802C7B40-0x00000001802C7BE0
		public RESULT getSampleLoadingState(out LOADING_STATE state); // 0x00000001802C70B0-0x00000001802C7160
		public RESULT releaseAllInstances(); // 0x00000001802C7930-0x00000001802C79D0
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.CREATED | EVENT_CALLBACK_TYPE.DESTROYED | EVENT_CALLBACK_TYPE.STARTING | EVENT_CALLBACK_TYPE.STARTED | EVENT_CALLBACK_TYPE.RESTARTED | EVENT_CALLBACK_TYPE.STOPPED | EVENT_CALLBACK_TYPE.START_FAILED | EVENT_CALLBACK_TYPE.CREATE_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.DESTROY_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.PLUGIN_CREATED | EVENT_CALLBACK_TYPE.PLUGIN_DESTROYED | EVENT_CALLBACK_TYPE.TIMELINE_MARKER | EVENT_CALLBACK_TYPE.TIMELINE_BEAT | EVENT_CALLBACK_TYPE.SOUND_PLAYED | EVENT_CALLBACK_TYPE.SOUND_STOPPED | EVENT_CALLBACK_TYPE.REAL_TO_VIRTUAL | EVENT_CALLBACK_TYPE.VIRTUAL_TO_REAL | EVENT_CALLBACK_TYPE.ALL /* Metadata: 0x00745EBC */); // 0x00000001802C79D0-0x00000001802C7A90
		public RESULT getUserData(out IntPtr userdata); // 0x00000001802C7210-0x00000001802C72C0
		public RESULT setUserData(IntPtr userdata); // 0x00000001802C7A90-0x00000001802C7B40
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription); // 0x0000000181B21320-0x0000000181B213C0
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id); // 0x0000000181B20280-0x0000000181B20330
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved); // 0x0000000181B209C0-0x0000000181B20A90
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count); // 0x0000000181B20910-0x0000000181B209C0
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter); // 0x0000000181B20790-0x0000000181B20840
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter); // 0x0000000181B20840-0x0000000181B20910
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter); // 0x0000000181B206D0-0x0000000181B20790
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count); // 0x0000000181B20DA0-0x0000000181B20E50
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property); // 0x0000000181B20CA0-0x0000000181B20DA0
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property); // 0x0000000181B20E50-0x0000000181B20F60
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length); // 0x0000000181B204C0-0x0000000181B20570
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance); // 0x0000000181B20620-0x0000000181B206D0
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance); // 0x0000000181B20570-0x0000000181B20620
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size); // 0x0000000181B20B40-0x0000000181B20BF0
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot); // 0x0000000181B211A0-0x0000000181B21260
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot); // 0x0000000181B210E0-0x0000000181B211A0
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream); // 0x0000000181B21260-0x0000000181B21320
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D); // 0x0000000181B21020-0x0000000181B210E0
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue); // 0x0000000181B20F60-0x0000000181B21020
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance); // 0x0000000181B201D0-0x0000000181B20280
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count); // 0x0000000181B20330-0x0000000181B203E0
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count); // 0x0000000181B203E0-0x0000000181B204C0
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription); // 0x0000000181B213C0-0x0000000181B21460
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription); // 0x0000000181B21670-0x0000000181B22520
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state); // 0x0000000181B20A90-0x0000000181B20B40
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription); // 0x0000000181B21460-0x0000000181B21500
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask); // 0x0000000181B21500-0x0000000181B215C0
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata); // 0x0000000181B20BF0-0x0000000181B20CA0
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata); // 0x0000000181B215C0-0x0000000181B21670
		public bool hasHandle(); // 0x00000001802C7540-0x00000001802C7580
		public void clearHandle(); // 0x00000001802C6B30-0x00000001802C6B70
		public bool isValid(); // 0x00000001802C7880-0x00000001802C7890
	}
}
