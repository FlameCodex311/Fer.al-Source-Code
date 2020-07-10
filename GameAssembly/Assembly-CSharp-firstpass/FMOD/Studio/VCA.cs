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
	public struct VCA // TypeDefIndex: 9820
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getID(out Guid id); // 0x00000001802CE940-0x00000001802CE9F0
		public RESULT getPath(out string path); // 0x00000001802CE9F0-0x00000001802CEA00
		public RESULT getVolume(out float volume); // 0x00000001802CEA10-0x00000001802CEAD0
		public RESULT getVolume(out float volume, out float finalvolume); // 0x00000001802CEA00-0x00000001802CEA10
		public RESULT setVolume(float volume); // 0x00000001802CEBF0-0x00000001802CECA0
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca); // 0x0000000181B39FC0-0x0000000181B3A060
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id); // 0x0000000181B39D80-0x0000000181B39E30
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved); // 0x0000000181B39E30-0x0000000181B39F00
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume); // 0x0000000181B39F00-0x0000000181B39FC0
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume); // 0x0000000181B3A060-0x0000000181B3A560
		public bool hasHandle(); // 0x00000001802CEAD0-0x00000001802CEB10
		public void clearHandle(); // 0x00000001802CE900-0x00000001802CE940
		public bool isValid(); // 0x00000001802CEB10-0x00000001802CEBF0
	}
}
