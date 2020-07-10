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
	public struct EventInstance // TypeDefIndex: 9818
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getDescription(out EventDescription description); // 0x00000001802C7D80-0x00000001802C7E30
		public RESULT getVolume(out float volume); // 0x00000001802C83E0-0x00000001802C84A0
		public RESULT getVolume(out float volume, out float finalvolume); // 0x00000001802C84A0-0x00000001802C84B0
		public RESULT setVolume(float volume); // 0x00000001802C8D50-0x00000001802C8E00
		public RESULT getPitch(out float pitch); // 0x00000001802C8030-0x00000001802C80F0
		public RESULT getPitch(out float pitch, out float finalpitch); // 0x00000001802C8020-0x00000001802C8030
		public RESULT setPitch(float pitch); // 0x00000001802C89C0-0x00000001802C8A70
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes); // 0x00000001802C7C20-0x00000001802C7CD0
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes); // 0x00000001802C85D0-0x00000001802C8690
		public RESULT getListenerMask(out uint mask); // 0x00000001802C7E30-0x00000001802C7EE0
		public RESULT setListenerMask(uint mask); // 0x00000001802C8750-0x00000001802C8800
		public RESULT getProperty(EVENT_PROPERTY index, out float value); // 0x00000001802C8100-0x00000001802C81C0
		public RESULT setProperty(EVENT_PROPERTY index, float value); // 0x00000001802C8A70-0x00000001802C8B30
		public RESULT getReverbLevel(int index, out float level); // 0x00000001802C81C0-0x00000001802C8280
		public RESULT setReverbLevel(int index, float level); // 0x00000001802C8B30-0x00000001802C8BF0
		public RESULT getPaused(out bool paused); // 0x00000001802C7F60-0x00000001802C8020
		public RESULT setPaused(bool paused); // 0x00000001802C8910-0x00000001802C89C0
		public RESULT start(); // 0x00000001802C8E00-0x00000001802C8E10
		public RESULT stop(STOP_MODE mode); // 0x00000001802C8E10-0x00000001802C8E20
		public RESULT getTimelinePosition(out int position); // 0x00000001802C8280-0x00000001802C8330
		public RESULT setTimelinePosition(int position); // 0x00000001802C8BF0-0x00000001802C8CA0
		public RESULT getPlaybackState(out PLAYBACK_STATE state); // 0x00000001802C80F0-0x00000001802C8100
		public RESULT getChannelGroup(out ChannelGroup group); // 0x00000001802C7CD0-0x00000001802C7D80
		public RESULT release(); // 0x00000001802C85C0-0x00000001802C85D0
		public RESULT isVirtual(out bool virtualstate); // 0x00000001802C8500-0x00000001802C85C0
		public RESULT getParameterByID(PARAMETER_ID id, out float value); // 0x00000001802C7EF0-0x00000001802C7F20
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue); // 0x00000001802C7EE0-0x00000001802C7EF0
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false /* Metadata: 0x00745EC0 */); // 0x00000001802C8800-0x00000001802C8810
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false /* Metadata: 0x00745EC1 */); // 0x00000001802C8820-0x00000001802C8910
		public RESULT getParameterByName(string name, out float value); // 0x00000001802C7F30-0x00000001802C7F60
		public RESULT getParameterByName(string name, out float value, out float finalvalue); // 0x00000001802C7F20-0x00000001802C7F30
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false /* Metadata: 0x00745EC2 */); // 0x00000001802C8810-0x00000001802C8820
		public RESULT triggerCue(); // 0x00000001802C8E20-0x00000001802C8F70
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.CREATED | EVENT_CALLBACK_TYPE.DESTROYED | EVENT_CALLBACK_TYPE.STARTING | EVENT_CALLBACK_TYPE.STARTED | EVENT_CALLBACK_TYPE.RESTARTED | EVENT_CALLBACK_TYPE.STOPPED | EVENT_CALLBACK_TYPE.START_FAILED | EVENT_CALLBACK_TYPE.CREATE_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.DESTROY_PROGRAMMER_SOUND | EVENT_CALLBACK_TYPE.PLUGIN_CREATED | EVENT_CALLBACK_TYPE.PLUGIN_DESTROYED | EVENT_CALLBACK_TYPE.TIMELINE_MARKER | EVENT_CALLBACK_TYPE.TIMELINE_BEAT | EVENT_CALLBACK_TYPE.SOUND_PLAYED | EVENT_CALLBACK_TYPE.SOUND_STOPPED | EVENT_CALLBACK_TYPE.REAL_TO_VIRTUAL | EVENT_CALLBACK_TYPE.VIRTUAL_TO_REAL | EVENT_CALLBACK_TYPE.ALL /* Metadata: 0x00745EC3 */); // 0x00000001802C8690-0x00000001802C8750
		public RESULT getUserData(out IntPtr userdata); // 0x00000001802C8330-0x00000001802C83E0
		public RESULT setUserData(IntPtr userdata); // 0x00000001802C8CA0-0x00000001802C8D50
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event); // 0x0000000181B23280-0x0000000181B23320
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description); // 0x0000000181B229C0-0x0000000181B22A70
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume); // 0x0000000181B231C0-0x0000000181B23280
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume); // 0x0000000181B23D80-0x0000000181B23E30
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch); // 0x0000000181B22D90-0x0000000181B22E50
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch); // 0x0000000181B239F0-0x0000000181B23AA0
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes); // 0x0000000181B22860-0x0000000181B22910
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes); // 0x0000000181B23480-0x0000000181B23530
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask); // 0x0000000181B22A70-0x0000000181B22B20
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask); // 0x0000000181B235F0-0x0000000181B236A0
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value); // 0x0000000181B22F00-0x0000000181B22FB0
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value); // 0x0000000181B23AA0-0x0000000181B23B60
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level); // 0x0000000181B22FB0-0x0000000181B23060
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level); // 0x0000000181B23B60-0x0000000181B23C20
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused); // 0x0000000181B22CD0-0x0000000181B22D90
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused); // 0x0000000181B23940-0x0000000181B239F0
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event); // 0x0000000181B23E30-0x0000000181B23ED0
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode); // 0x0000000181B23ED0-0x0000000181B23F80
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position); // 0x0000000181B23060-0x0000000181B23110
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position); // 0x0000000181B23C20-0x0000000181B23CD0
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state); // 0x0000000181B22E50-0x0000000181B22F00
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group); // 0x0000000181B22910-0x0000000181B229C0
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event); // 0x0000000181B233E0-0x0000000181B23480
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate); // 0x0000000181B23320-0x0000000181B233E0
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue); // 0x0000000181B22BF0-0x0000000181B22CD0
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed); // 0x0000000181B23770-0x0000000181B23850
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue); // 0x0000000181B22B20-0x0000000181B22BF0
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed); // 0x0000000181B236A0-0x0000000181B23770
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed); // 0x0000000181B23850-0x0000000181B23940
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event); // 0x0000000181B23F80-0x0000000181B24C60
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask); // 0x0000000181B23530-0x0000000181B235F0
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata); // 0x0000000181B23110-0x0000000181B231C0
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata); // 0x0000000181B23CD0-0x0000000181B23D80
		public bool hasHandle(); // 0x00000001802C84B0-0x00000001802C84F0
		public void clearHandle(); // 0x00000001802C7BE0-0x00000001802C7C20
		public bool isValid(); // 0x00000001802C84F0-0x00000001802C8500
	}
}
