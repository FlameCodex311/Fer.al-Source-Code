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
	public struct EventInstance // TypeDefIndex: 10272
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getDescription(out EventDescription description); // 0x000000018011FEE0-0x000000018011FF70
		public RESULT getVolume(out float volume); // 0x0000000180120540-0x00000001801205E0
		public RESULT getVolume(out float volume, out float finalvolume); // 0x00000001801205E0-0x00000001801205F0
		public RESULT setVolume(float volume); // 0x0000000180120EF0-0x0000000180120F80
		public RESULT getPitch(out float pitch); // 0x00000001801201B0-0x0000000180120250
		public RESULT getPitch(out float pitch, out float finalpitch); // 0x00000001801201A0-0x00000001801201B0
		public RESULT setPitch(float pitch); // 0x0000000180120C00-0x0000000180120C90
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes); // 0x000000018011FDC0-0x000000018011FE50
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes); // 0x0000000180120810-0x00000001801208B0
		public RESULT getListenerMask(out uint mask); // 0x000000018011FF70-0x0000000180120000
		public RESULT setListenerMask(uint mask); // 0x0000000180120950-0x00000001801209E0
		public RESULT getProperty(EVENT_PROPERTY index, out float value); // 0x00000001801202E0-0x0000000180120380
		public RESULT setProperty(EVENT_PROPERTY index, float value); // 0x0000000180120C90-0x0000000180120D30
		public RESULT getReverbLevel(int index, out float level); // 0x0000000180120380-0x0000000180120420
		public RESULT setReverbLevel(int index, float level); // 0x0000000180120D30-0x0000000180120DD0
		public RESULT getPaused(out bool paused); // 0x0000000180120100-0x00000001801201A0
		public RESULT setPaused(bool paused); // 0x0000000180120B70-0x0000000180120C00
		public RESULT start(); // 0x0000000180120F80-0x0000000180121000
		public RESULT stop(STOP_MODE mode); // 0x0000000180121000-0x0000000180121090
		public RESULT getTimelinePosition(out int position); // 0x0000000180120420-0x00000001801204B0
		public RESULT setTimelinePosition(int position); // 0x0000000180120DD0-0x0000000180120E60
		public RESULT getPlaybackState(out PLAYBACK_STATE state); // 0x0000000180120250-0x00000001801202E0
		public RESULT getChannelGroup(out ChannelGroup group); // 0x000000018011FE50-0x000000018011FEE0
		public RESULT release(); // 0x0000000180120790-0x0000000180120810
		public RESULT isVirtual(out bool virtualstate); // 0x00000001801206F0-0x0000000180120790
		public RESULT getParameterByID(PARAMETER_ID id, out float value); // 0x0000000180120010-0x00000001801200C0
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue); // 0x0000000180120000-0x0000000180120010
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false /* Metadata: 0x0077B972 */); // 0x00000001801209E0-0x0000000180120A90
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false /* Metadata: 0x0077B973 */); // 0x0000000180120AA0-0x0000000180120B70
		public RESULT getParameterByName(string name, out float value); // 0x00000001801200D0-0x0000000180120100
		public RESULT getParameterByName(string name, out float value, out float finalvalue); // 0x00000001801200C0-0x00000001801200D0
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false /* Metadata: 0x0077B974 */); // 0x0000000180120A90-0x0000000180120AA0
		public RESULT triggerCue(); // 0x0000000180121090-0x0000000180121110
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.CREATED | EVENT_CALLBACK_TYPE.DESTROYED | EVENT_CALLBACK_TYPE.STARTING | EVENT_CALLBACK_TYPE.STARTED | EVENT_CALLBACK_TYPE.RESTARTED | EVENT_CALLBACK_TYPE.STOPPED | EVENT_CALLBACK_TYPE.START_FAILED | EVENT_CALLBACK_TYPE.CREATE_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.DESTROY_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.PLUGIN_CREATED | EVENT_CALLBACK_TYPE.PLUGIN_DESTROYED | EVENT_CALLBACK_TYPE.TIMELINE_MARKER | EVENT_CALLBACK_TYPE.TIMELINE_BEAT | EVENT_CALLBACK_TYPE.SOUND_PLAYED | EVENT_CALLBACK_TYPE.SOUND_STOPPED | EVENT_CALLBACK_TYPE.REAL_TO_VIRTUAL | EVENT_CALLBACK_TYPE.VIRTUAL_TO_REAL | EVENT_CALLBACK_TYPE.ALL /* Metadata: 0x0077B975 */); // 0x00000001801208B0-0x0000000180120950
		public RESULT getUserData(out IntPtr userdata); // 0x00000001801204B0-0x0000000180120540
		public RESULT setUserData(IntPtr userdata); // 0x0000000180120E60-0x0000000180120EF0
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event); // 0x0000000181BDE020-0x0000000181BDE0A0
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description); // 0x0000000181BDD8C0-0x0000000181BDD950
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume); // 0x0000000181BDDF80-0x0000000181BDE020
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume); // 0x0000000181BDE940-0x0000000181BDE9D0
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch); // 0x0000000181BDDBF0-0x0000000181BDDC90
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch); // 0x0000000181BDE650-0x0000000181BDE6E0
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes); // 0x0000000181BDD7A0-0x0000000181BDD830
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes); // 0x0000000181BDE1C0-0x0000000181BDE250
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask); // 0x0000000181BDD950-0x0000000181BDD9E0
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask); // 0x0000000181BDE2F0-0x0000000181BDE380
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value); // 0x0000000181BDDD20-0x0000000181BDDDC0
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value); // 0x0000000181BDE6E0-0x0000000181BDE780
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level); // 0x0000000181BDDDC0-0x0000000181BDDE60
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level); // 0x0000000181BDE780-0x0000000181BDE820
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused); // 0x0000000181BDDB50-0x0000000181BDDBF0
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused); // 0x0000000181BDE5C0-0x0000000181BDE650
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event); // 0x0000000181BDE9D0-0x0000000181BDEA50
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode); // 0x0000000181BDEA50-0x0000000181BDEAE0
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position); // 0x0000000181BDDE60-0x0000000181BDDEF0
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position); // 0x0000000181BDE820-0x0000000181BDE8B0
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state); // 0x0000000181BDDC90-0x0000000181BDDD20
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group); // 0x0000000181BDD830-0x0000000181BDD8C0
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event); // 0x0000000181BDE140-0x0000000181BDE1C0
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate); // 0x0000000181BDE0A0-0x0000000181BDE140
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue); // 0x0000000181BDDA90-0x0000000181BDDB50
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed); // 0x0000000181BDE430-0x0000000181BDE4F0
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue); // 0x0000000181BDD9E0-0x0000000181BDDA90
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed); // 0x0000000181BDE380-0x0000000181BDE430
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed); // 0x0000000181BDE4F0-0x0000000181BDE5C0
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event); // 0x0000000181BDEAE0-0x0000000181BDF720
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask); // 0x0000000181BDE250-0x0000000181BDE2F0
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata); // 0x0000000181BDDEF0-0x0000000181BDDF80
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata); // 0x0000000181BDE8B0-0x0000000181BDE940
		public bool hasHandle(); // 0x00000001801205F0-0x0000000180120630
		public void clearHandle(); // 0x000000018011FD80-0x000000018011FDC0
		public bool isValid(); // 0x0000000180120630-0x00000001801206F0
	}
}
