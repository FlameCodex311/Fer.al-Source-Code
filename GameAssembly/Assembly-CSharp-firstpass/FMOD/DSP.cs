/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct DSP // TypeDefIndex: 9667
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x00000001802D98E0-0x00000001802D9980
		public RESULT getSystemObject(out System system); // 0x00000001802D95C0-0x00000001802D9670
		public RESULT addInput(DSP input); // 0x00000001802D7F20-0x00000001802D7FF0
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD /* Metadata: 0x00745817 */); // 0x00000001802D7FF0-0x00000001802D80C0
		public RESULT disconnectFrom(DSP target, DSPConnection connection); // 0x00000001802D81C0-0x00000001802D8280
		public RESULT disconnectAll(bool inputs, bool outputs); // 0x00000001802D8100-0x00000001802D81C0
		public RESULT getNumInputs(out int numinputs); // 0x00000001802D8D00-0x00000001802D8DB0
		public RESULT getNumOutputs(out int numoutputs); // 0x00000001802D8DB0-0x00000001802D8E60
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection); // 0x00000001802D87A0-0x00000001802D8860
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection); // 0x00000001802D9000-0x00000001802D90C0
		public RESULT setActive(bool active); // 0x00000001802D9A20-0x00000001802D9AD0
		public RESULT getActive(out bool active); // 0x00000001802D8280-0x00000001802D8340
		public RESULT setBypass(bool bypass); // 0x00000001802D9AD0-0x00000001802D9B80
		public RESULT getBypass(out bool bypass); // 0x00000001802D8340-0x00000001802D8400
		public RESULT setWetDryMix(float prewet, float postwet, float dry); // 0x00000001802DA120-0x00000001802DA200
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry); // 0x00000001802D97D0-0x00000001802D98A0
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode); // 0x00000001802D9B80-0x00000001802D9C40
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode); // 0x00000001802D84C0-0x00000001802D8590
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode); // 0x00000001802D8F10-0x00000001802D9000
		public RESULT reset(); // 0x00000001802D9980-0x00000001802D9A20
		public RESULT setParameterFloat(int index, float value); // 0x00000001802D9EF0-0x00000001802D9FB0
		public RESULT setParameterInt(int index, int value); // 0x00000001802D9FB0-0x00000001802DA070
		public RESULT setParameterBool(int index, bool value); // 0x00000001802D9D00-0x00000001802D9DC0
		public RESULT setParameterData(int index, byte[] data); // 0x00000001802D9DC0-0x00000001802D9EF0
		public RESULT getParameterFloat(int index, out float value); // 0x00000001802D92C0-0x00000001802D93A0
		public RESULT getParameterInt(int index, out int value); // 0x00000001802D94E0-0x00000001802D95C0
		public RESULT getParameterBool(int index, out bool value); // 0x00000001802D90C0-0x00000001802D91C0
		public RESULT getParameterData(int index, out IntPtr data, out uint length); // 0x00000001802D91C0-0x00000001802D92C0
		public RESULT getNumParameters(out int numparams); // 0x00000001802D8E60-0x00000001802D8F10
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc); // 0x00000001802D93A0-0x00000001802D94E0
		public RESULT getDataParameterIndex(int datatype, out int index); // 0x00000001802D8590-0x00000001802D8650
		public RESULT showConfigDialog(IntPtr hwnd, bool show); // 0x00000001802DA200-0x00000001802DA850
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight); // 0x00000001802D8790-0x00000001802D87A0
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight); // 0x00000001802D8710-0x00000001802D8790
		public RESULT getType(out DSP_TYPE type); // 0x00000001802D9670-0x00000001802D9720
		public RESULT getIdle(out bool idle); // 0x00000001802D8650-0x00000001802D8710
		public RESULT setUserData(IntPtr userdata); // 0x00000001802DA070-0x00000001802DA120
		public RESULT getUserData(out IntPtr userdata); // 0x00000001802D9720-0x00000001802D97D0
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled); // 0x00000001802D9C40-0x00000001802D9D00
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled); // 0x00000001802D8860-0x00000001802D8940
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo); // 0x00000001802D8A60-0x00000001802D8B80
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero); // 0x00000001802D8940-0x00000001802D8A60
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo); // 0x00000001802D8B80-0x00000001802D8D00
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive); // 0x00000001802D8400-0x00000001802D84C0
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp); // 0x0000000181B5D320-0x0000000181B5D3C0
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system); // 0x0000000181B5D040-0x0000000181B5D0F0
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type); // 0x0000000181B5BA00-0x0000000181B5BAD0
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type); // 0x0000000181B5BAD0-0x0000000181B5BBA0
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection); // 0x0000000181B5BC60-0x0000000181B5BD20
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs); // 0x0000000181B5BBA0-0x0000000181B5BC60
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs); // 0x0000000181B5C7E0-0x0000000181B5C890
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs); // 0x0000000181B5C890-0x0000000181B5C940
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection); // 0x0000000181B5C280-0x0000000181B5C340
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection); // 0x0000000181B5CAE0-0x0000000181B5CBA0
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active); // 0x0000000181B5D460-0x0000000181B5D510
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active); // 0x0000000181B5BD20-0x0000000181B5BDE0
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass); // 0x0000000181B5D510-0x0000000181B5D5C0
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass); // 0x0000000181B5BDE0-0x0000000181B5BEA0
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry); // 0x0000000181B5DAE0-0x0000000181B5DBC0
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry); // 0x0000000181B5D250-0x0000000181B5D320
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode); // 0x0000000181B5D5C0-0x0000000181B5D680
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode); // 0x0000000181B5BF60-0x0000000181B5C030
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode); // 0x0000000181B5C9F0-0x0000000181B5CAE0
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp); // 0x0000000181B5D3C0-0x0000000181B5D460
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value); // 0x0000000181B5D8C0-0x0000000181B5D980
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value); // 0x0000000181B5D980-0x0000000181B5DA30
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value); // 0x0000000181B5D740-0x0000000181B5D800
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length); // 0x0000000181B5D800-0x0000000181B5D8C0
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen); // 0x0000000181B5CD60-0x0000000181B5CE30
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen); // 0x0000000181B5CF70-0x0000000181B5D040
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen); // 0x0000000181B5CBA0-0x0000000181B5CC80
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen); // 0x0000000181B5CC80-0x0000000181B5CD60
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams); // 0x0000000181B5C940-0x0000000181B5C9F0
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out DSP_PARAMETER_DESC desc); // 0x0000000181B5CE30-0x0000000181B5CF70
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index); // 0x0000000181B5C030-0x0000000181B5C0E0
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show); // 0x0000000181B5DBC0-0x0000000181B5E180
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight); // 0x0000000181B5C1A0-0x0000000181B5C280
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type); // 0x0000000181B5D0F0-0x0000000181B5D1A0
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle); // 0x0000000181B5C0E0-0x0000000181B5C1A0
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata); // 0x0000000181B5DA30-0x0000000181B5DAE0
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata); // 0x0000000181B5D1A0-0x0000000181B5D250
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled); // 0x0000000181B5D680-0x0000000181B5D740
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled); // 0x0000000181B5C340-0x0000000181B5C420
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo); // 0x0000000181B5C420-0x0000000181B5C540
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero); // 0x0000000181B5C540-0x0000000181B5C660
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo); // 0x0000000181B5C660-0x0000000181B5C7E0
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive); // 0x0000000181B5BEA0-0x0000000181B5BF60
		public bool hasHandle(); // 0x00000001802D98A0-0x00000001802D98E0
		public void clearHandle(); // 0x00000001802D80C0-0x00000001802D8100
	}
}
