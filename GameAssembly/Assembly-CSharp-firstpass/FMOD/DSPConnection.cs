/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct DSPConnection // TypeDefIndex: 9668
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getInput(out DSP input); // 0x0000000180312340-0x00000001803123F0
		public RESULT getOutput(out DSP output); // 0x0000000180312590-0x0000000180312640
		public RESULT setMix(float volume); // 0x00000001803128D0-0x0000000180312980
		public RESULT getMix(out float volume); // 0x00000001803124E0-0x0000000180312590
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0 /* Metadata: 0x0074581B */); // 0x00000001803127E0-0x00000001803128D0
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0 /* Metadata: 0x0074581F */); // 0x00000001803123F0-0x00000001803124E0
		public RESULT getType(out DSPCONNECTION_TYPE type); // 0x0000000180312640-0x00000001803126F0
		public RESULT setUserData(IntPtr userdata); // 0x0000000180312980-0x00000001803144A0
		public RESULT getUserData(out IntPtr userdata); // 0x00000001803126F0-0x00000001803127A0
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input); // 0x0000000181EE9BE0-0x0000000181EE9C90
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output); // 0x0000000181EE9E30-0x0000000181EE9EE0
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume); // 0x0000000181EEA130-0x0000000181EEA1E0
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume); // 0x0000000181EE9D80-0x0000000181EE9E30
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x0000000181EEA040-0x0000000181EEA130
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x0000000181EE9C90-0x0000000181EE9D80
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type); // 0x0000000181EE9EE0-0x0000000181EE9F90
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata); // 0x0000000181EEA1E0-0x0000000181EEA290
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata); // 0x0000000181EE9F90-0x0000000181EEA040
		public bool hasHandle(); // 0x00000001803127A0-0x00000001803127E0
		public void clearHandle(); // 0x0000000180312300-0x0000000180312340
	}
}
