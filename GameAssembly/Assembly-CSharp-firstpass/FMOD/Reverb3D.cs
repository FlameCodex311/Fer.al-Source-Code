/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct Reverb3D // TypeDefIndex: 10124
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x000000018011B570-0x000000018011B5F0
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance); // 0x000000018011B5F0-0x000000018011B6A0
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance); // 0x000000018011B2C0-0x000000018011B370
		public RESULT setProperties(ref REVERB_PROPERTIES properties); // 0x000000018011B730-0x000000018011B7C0
		public RESULT getProperties(ref REVERB_PROPERTIES properties); // 0x000000018011B410-0x000000018011B4A0
		public RESULT setActive(bool active); // 0x000000018011B6A0-0x000000018011B730
		public RESULT getActive(out bool active); // 0x000000018011B370-0x000000018011B410
		public RESULT setUserData(IntPtr userdata); // 0x000000018011B7C0-0x000000018011B850
		public RESULT getUserData(out IntPtr userdata); // 0x000000018011B4A0-0x000000018011B530
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d); // 0x0000000181BA0EE0-0x0000000181BA0F60
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance); // 0x0000000181BA0F60-0x0000000181BA1010
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance); // 0x0000000181BA0C70-0x0000000181BA0D20
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties); // 0x0000000181BA10A0-0x0000000181BA1130
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties); // 0x0000000181BA0DC0-0x0000000181BA0E50
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active); // 0x0000000181BA1010-0x0000000181BA10A0
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active); // 0x0000000181BA0D20-0x0000000181BA0DC0
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata); // 0x0000000181BA1130-0x0000000181BA11C0
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata); // 0x0000000181BA0E50-0x0000000181BA0EE0
		public bool hasHandle(); // 0x000000018011B530-0x000000018011B570
		public void clearHandle(); // 0x000000018011B280-0x000000018011B2C0
	}
}
