/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct DSPConnection // TypeDefIndex: 10122
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT getInput(out DSP input); // 0x0000000180115590-0x0000000180115620
		public RESULT getOutput(out DSP output); // 0x0000000180115780-0x0000000180115810
		public RESULT setMix(float volume); // 0x0000000180115A40-0x0000000180115AD0
		public RESULT getMix(out float volume); // 0x00000001801156F0-0x0000000180115780
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0 /* Metadata: 0x0077B2CD */); // 0x0000000180115970-0x0000000180115A40
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0 /* Metadata: 0x0077B2D1 */); // 0x0000000180115620-0x00000001801156F0
		public RESULT getType(out DSPCONNECTION_TYPE type); // 0x0000000180115810-0x00000001801158A0
		public RESULT setUserData(IntPtr userdata); // 0x0000000180115AD0-0x00000001801175C0
		public RESULT getUserData(out IntPtr userdata); // 0x00000001801158A0-0x0000000180115930
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input); // 0x0000000181B94130-0x0000000181B941C0
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output); // 0x0000000181B94310-0x0000000181B943A0
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume); // 0x0000000181B94580-0x0000000181B94610
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume); // 0x0000000181B94280-0x0000000181B94310
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop); // 0x0000000181B944C0-0x0000000181B94580
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop); // 0x0000000181B941C0-0x0000000181B94280
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type); // 0x0000000181B943A0-0x0000000181B94430
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata); // 0x0000000181B94610-0x0000000181B946A0
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata); // 0x0000000181B94430-0x0000000181B944C0
		public bool hasHandle(); // 0x0000000180115930-0x0000000180115970
		public void clearHandle(); // 0x0000000180115550-0x0000000180115590
	}
}
