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
	public struct Bank // TypeDefIndex: 9821
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x00000001803103B0-0x0000000180310460
		public RESULT getPath(out string path); // 0x0000000180310510-0x0000000180310520
		public RESULT unload(); // 0x0000000180310A70-0x0000000180310B10
		public RESULT loadSampleData(); // 0x0000000180310880-0x0000000180310920
		public RESULT unloadSampleData(); // 0x00000001803109D0-0x0000000180310A70
		public RESULT getLoadingState(out LOADING_STATE state); // 0x0000000180310460-0x0000000180310510
		public RESULT getSampleLoadingState(out LOADING_STATE state); // 0x0000000180310520-0x00000001803105D0
		public RESULT getStringCount(out int count); // 0x00000001803105D0-0x0000000180310680
		public RESULT getStringInfo(int index, out Guid id, out string path); // 0x0000000180310680-0x0000000180310690
		public RESULT getEventCount(out int count); // 0x0000000180310390-0x00000001803103A0
		public RESULT getEventList(out EventDescription[] array); // 0x00000001803103A0-0x00000001803103B0
		public RESULT getBusCount(out int count); // 0x0000000180310370-0x0000000180310380
		public RESULT getBusList(out Bus[] array); // 0x0000000180310380-0x0000000180310390
		public RESULT getVCACount(out int count); // 0x0000000180310740-0x0000000180310750
		public RESULT getVCAList(out VCA[] array); // 0x0000000180310750-0x0000000180310760
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180310690-0x0000000180310740
		public RESULT setUserData(IntPtr userdata); // 0x0000000180310920-0x00000001803109D0
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank); // 0x0000000181EE5C90-0x0000000181EE5D30
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id); // 0x0000000181EE55E0-0x0000000181EE5690
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved); // 0x0000000181EE5740-0x0000000181EE5810
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank); // 0x0000000181EE5F20-0x0000000181EE6D20
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank); // 0x0000000181EE5D30-0x0000000181EE5DD0
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank); // 0x0000000181EE5E80-0x0000000181EE5F20
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state); // 0x0000000181EE5690-0x0000000181EE5740
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state); // 0x0000000181EE5810-0x0000000181EE58C0
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count); // 0x0000000181EE58C0-0x0000000181EE5970
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved); // 0x0000000181EE5970-0x0000000181EE5A50
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count); // 0x0000000181EE5450-0x0000000181EE5500
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count); // 0x0000000181EE5500-0x0000000181EE55E0
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count); // 0x0000000181EE52C0-0x0000000181EE5370
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count); // 0x0000000181EE5370-0x0000000181EE5450
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count); // 0x0000000181EE5B00-0x0000000181EE5BB0
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count); // 0x0000000181EE5BB0-0x0000000181EE5C90
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata); // 0x0000000181EE5A50-0x0000000181EE5B00
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata); // 0x0000000181EE5DD0-0x0000000181EE5E80
		public bool hasHandle(); // 0x0000000180310760-0x00000001803107A0
		public void clearHandle(); // 0x0000000180310330-0x0000000180310370
		public bool isValid(); // 0x00000001803107A0-0x0000000180310880
	}
}
