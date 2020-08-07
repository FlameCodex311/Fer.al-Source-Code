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
	public struct VCA // TypeDefIndex: 10274
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x0000000180127560-0x00000001801275F0
		public RESULT getPath(out string path); // 0x00000001801275F0-0x0000000180127600
		public RESULT getVolume(out float volume); // 0x0000000180127610-0x00000001801276B0
		public RESULT getVolume(out float volume, out float finalvolume); // 0x0000000180127600-0x0000000180127610
		public RESULT setVolume(float volume); // 0x00000001801277B0-0x0000000180127AA0
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca); // 0x0000000181BEB650-0x0000000181BEB6D0
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id); // 0x0000000181BEB470-0x0000000181BEB500
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved); // 0x0000000181BEB500-0x0000000181BEB5B0
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume); // 0x0000000181BEB5B0-0x0000000181BEB650
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume); // 0x0000000181BEB6D0-0x0000000181BEBBF0
		public bool hasHandle(); // 0x00000001801276B0-0x00000001801276F0
		public void clearHandle(); // 0x0000000180127520-0x0000000180127560
		public bool isValid(); // 0x00000001801276F0-0x00000001801277B0
	}
}
