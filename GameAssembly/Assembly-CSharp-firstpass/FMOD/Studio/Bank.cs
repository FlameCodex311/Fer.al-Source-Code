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
	public struct Bank // TypeDefIndex: 10275
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x000000018011D380-0x000000018011D410
		public RESULT getPath(out string path); // 0x000000018011D4A0-0x000000018011D4B0
		public RESULT unload(); // 0x000000018011D920-0x000000018011D9A0
		public RESULT loadSampleData(); // 0x000000018011D790-0x000000018011D810
		public RESULT unloadSampleData(); // 0x000000018011D8A0-0x000000018011D920
		public RESULT getLoadingState(out LOADING_STATE state); // 0x000000018011D410-0x000000018011D4A0
		public RESULT getSampleLoadingState(out LOADING_STATE state); // 0x000000018011D4B0-0x000000018011D540
		public RESULT getStringCount(out int count); // 0x000000018011D540-0x000000018011D5D0
		public RESULT getStringInfo(int index, out Guid id, out string path); // 0x000000018011D5D0-0x000000018011D5E0
		public RESULT getEventCount(out int count); // 0x000000018011D360-0x000000018011D370
		public RESULT getEventList(out EventDescription[] array); // 0x000000018011D370-0x000000018011D380
		public RESULT getBusCount(out int count); // 0x000000018011D340-0x000000018011D350
		public RESULT getBusList(out Bus[] array); // 0x000000018011D350-0x000000018011D360
		public RESULT getVCACount(out int count); // 0x000000018011D670-0x000000018011D680
		public RESULT getVCAList(out VCA[] array); // 0x000000018011D680-0x000000018011D690
		public RESULT getUserData(out IntPtr userdata); // 0x000000018011D5E0-0x000000018011D670
		public RESULT setUserData(IntPtr userdata); // 0x000000018011D810-0x000000018011D8A0
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank); // 0x0000000181BD79E0-0x0000000181BD7A60
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id); // 0x0000000181BD7450-0x0000000181BD74E0
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved); // 0x0000000181BD7570-0x0000000181BD7620
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank); // 0x0000000181BD7BF0-0x0000000181BD89B0
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank); // 0x0000000181BD7A60-0x0000000181BD7AE0
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank); // 0x0000000181BD7B70-0x0000000181BD7BF0
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state); // 0x0000000181BD74E0-0x0000000181BD7570
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state); // 0x0000000181BD7620-0x0000000181BD76B0
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count); // 0x0000000181BD76B0-0x0000000181BD7740
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved); // 0x0000000181BD7740-0x0000000181BD7800
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count); // 0x0000000181BD7300-0x0000000181BD7390
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count); // 0x0000000181BD7390-0x0000000181BD7450
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count); // 0x0000000181BD71B0-0x0000000181BD7240
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count); // 0x0000000181BD7240-0x0000000181BD7300
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count); // 0x0000000181BD7890-0x0000000181BD7920
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count); // 0x0000000181BD7920-0x0000000181BD79E0
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata); // 0x0000000181BD7800-0x0000000181BD7890
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata); // 0x0000000181BD7AE0-0x0000000181BD7B70
		public bool hasHandle(); // 0x000000018011D690-0x000000018011D6D0
		public void clearHandle(); // 0x000000018011D300-0x000000018011D340
		public bool isValid(); // 0x000000018011D6D0-0x000000018011D790
	}
}
