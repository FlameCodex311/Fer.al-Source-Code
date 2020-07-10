/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct Reverb3D // TypeDefIndex: 9670
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x0000000180316960-0x0000000180316A00
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance); // 0x0000000180316A00-0x0000000180316AD0
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance); // 0x0000000180316630-0x0000000180316700
		public RESULT setProperties(ref REVERB_PROPERTIES properties); // 0x0000000180316B80-0x0000000180316C30
		public RESULT getProperties(ref REVERB_PROPERTIES properties); // 0x00000001803167C0-0x0000000180316870
		public RESULT setActive(bool active); // 0x0000000180316AD0-0x0000000180316B80
		public RESULT getActive(out bool active); // 0x0000000180316700-0x00000001803167C0
		public RESULT setUserData(IntPtr userdata); // 0x0000000180316C30-0x0000000180316CE0
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180316870-0x0000000180316920
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d); // 0x0000000181EF3D80-0x0000000181EF3E20
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance); // 0x0000000181EF3E20-0x0000000181EF3EF0
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance); // 0x0000000181EF3A90-0x0000000181EF3B60
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties); // 0x0000000181EF3FA0-0x0000000181EF4050
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties); // 0x0000000181EF3C20-0x0000000181EF3CD0
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active); // 0x0000000181EF3EF0-0x0000000181EF3FA0
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active); // 0x0000000181EF3B60-0x0000000181EF3C20
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata); // 0x0000000181EF4050-0x0000000181EF4100
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata); // 0x0000000181EF3CD0-0x0000000181EF3D80
		public bool hasHandle(); // 0x0000000180316920-0x0000000180316960
		public void clearHandle(); // 0x00000001803165F0-0x0000000180316630
	}
}
