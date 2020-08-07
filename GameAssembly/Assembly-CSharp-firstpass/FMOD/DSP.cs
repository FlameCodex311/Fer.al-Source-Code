/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct DSP // TypeDefIndex: 10121
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x0000000180119550-0x00000001801195D0
		public RESULT getSystemObject(out System system); // 0x00000001801192B0-0x0000000180119340
		public RESULT addInput(DSP input); // 0x0000000180117F40-0x0000000180117FF0
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD /* Metadata: 0x0077B2C9 */); // 0x0000000180117FF0-0x00000001801180A0
		public RESULT disconnectFrom(DSP target, DSPConnection connection); // 0x0000000180118180-0x0000000180118220
		public RESULT disconnectAll(bool inputs, bool outputs); // 0x00000001801180E0-0x0000000180118180
		public RESULT getNumInputs(out int numinputs); // 0x0000000180118B20-0x0000000180118BB0
		public RESULT getNumOutputs(out int numoutputs); // 0x0000000180118BB0-0x0000000180118C40
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection); // 0x0000000180118680-0x0000000180118730
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection); // 0x0000000180118DA0-0x0000000180118E50
		public RESULT setActive(bool active); // 0x0000000180119650-0x00000001801196E0
		public RESULT getActive(out bool active); // 0x0000000180118220-0x00000001801182C0
		public RESULT setBypass(bool bypass); // 0x00000001801196E0-0x0000000180119770
		public RESULT getBypass(out bool bypass); // 0x00000001801182C0-0x0000000180118360
		public RESULT setWetDryMix(float prewet, float postwet, float dry); // 0x0000000180119C40-0x0000000180119D00
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry); // 0x0000000180119460-0x0000000180119510
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode); // 0x0000000180119770-0x0000000180119820
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode); // 0x0000000180118400-0x00000001801184B0
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode); // 0x0000000180118CD0-0x0000000180118DA0
		public RESULT reset(); // 0x00000001801195D0-0x0000000180119650
		public RESULT setParameterFloat(int index, float value); // 0x0000000180119A70-0x0000000180119B10
		public RESULT setParameterInt(int index, int value); // 0x0000000180119B10-0x0000000180119BB0
		public RESULT setParameterBool(int index, bool value); // 0x00000001801198C0-0x0000000180119960
		public RESULT setParameterData(int index, byte[] data); // 0x0000000180119960-0x0000000180119A70
		public RESULT getParameterFloat(int index, out float value); // 0x0000000180119010-0x00000001801190D0
		public RESULT getParameterInt(int index, out int value); // 0x00000001801191F0-0x00000001801192B0
		public RESULT getParameterBool(int index, out bool value); // 0x0000000180118E50-0x0000000180118F30
		public RESULT getParameterData(int index, out IntPtr data, out uint length); // 0x0000000180118F30-0x0000000180119010
		public RESULT getNumParameters(out int numparams); // 0x0000000180118C40-0x0000000180118CD0
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc); // 0x00000001801190D0-0x00000001801191F0
		public RESULT getDataParameterIndex(int datatype, out int index); // 0x00000001801184B0-0x0000000180118550
		public RESULT showConfigDialog(IntPtr hwnd, bool show); // 0x0000000180119D00-0x000000018011A4E0
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight); // 0x0000000180118670-0x0000000180118680
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight); // 0x00000001801185F0-0x0000000180118670
		public RESULT getType(out DSP_TYPE type); // 0x0000000180119340-0x00000001801193D0
		public RESULT getIdle(out bool idle); // 0x0000000180118550-0x00000001801185F0
		public RESULT setUserData(IntPtr userdata); // 0x0000000180119BB0-0x0000000180119C40
		public RESULT getUserData(out IntPtr userdata); // 0x00000001801193D0-0x0000000180119460
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled); // 0x0000000180119820-0x00000001801198C0
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled); // 0x0000000180118730-0x00000001801187F0
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo); // 0x00000001801188E0-0x00000001801189D0
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero); // 0x00000001801187F0-0x00000001801188E0
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo); // 0x00000001801189D0-0x0000000180118B20
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive); // 0x0000000180118360-0x0000000180118400
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp); // 0x0000000181B966E0-0x0000000181B96760
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system); // 0x0000000181B96480-0x0000000181B96510
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type); // 0x0000000181B951A0-0x0000000181B95250
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type); // 0x0000000181B95250-0x0000000181B95300
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection); // 0x0000000181B953A0-0x0000000181B95440
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs); // 0x0000000181B95300-0x0000000181B953A0
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs); // 0x0000000181B95D50-0x0000000181B95DE0
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs); // 0x0000000181B95DE0-0x0000000181B95E70
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection); // 0x0000000181B958D0-0x0000000181B95970
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection); // 0x0000000181B95FD0-0x0000000181B96070
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active); // 0x0000000181B967E0-0x0000000181B96870
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active); // 0x0000000181B95440-0x0000000181B954E0
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass); // 0x0000000181B96870-0x0000000181B96900
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass); // 0x0000000181B954E0-0x0000000181B95580
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry); // 0x0000000181B96D50-0x0000000181B96E10
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry); // 0x0000000181B96630-0x0000000181B966E0
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode); // 0x0000000181B96900-0x0000000181B969A0
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode); // 0x0000000181B95620-0x0000000181B956D0
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode); // 0x0000000181B95F00-0x0000000181B95FD0
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp); // 0x0000000181B96760-0x0000000181B967E0
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value); // 0x0000000181B96B80-0x0000000181B96C20
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value); // 0x0000000181B96C20-0x0000000181B96CC0
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value); // 0x0000000181B96A40-0x0000000181B96AE0
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length); // 0x0000000181B96AE0-0x0000000181B96B80
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen); // 0x0000000181B96200-0x0000000181B962B0
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen); // 0x0000000181B963D0-0x0000000181B96480
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen); // 0x0000000181B96070-0x0000000181B96140
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen); // 0x0000000181B96140-0x0000000181B96200
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams); // 0x0000000181B95E70-0x0000000181B95F00
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out DSP_PARAMETER_DESC desc); // 0x0000000181B962B0-0x0000000181B963D0
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index); // 0x0000000181B956D0-0x0000000181B95770
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show); // 0x0000000181B96E10-0x0000000181B96EB0
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight); // 0x0000000181B95810-0x0000000181B958D0
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type); // 0x0000000181B96510-0x0000000181B965A0
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle); // 0x0000000181B95770-0x0000000181B95810
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata); // 0x0000000181B96CC0-0x0000000181B96D50
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata); // 0x0000000181B965A0-0x0000000181B96630
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled); // 0x0000000181B969A0-0x0000000181B96A40
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled); // 0x0000000181B95970-0x0000000181B95A30
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo); // 0x0000000181B95A30-0x0000000181B95B20
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero); // 0x0000000181B95B20-0x0000000181B95C10
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo); // 0x0000000181B95C10-0x0000000181B95D50
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive); // 0x0000000181B95580-0x0000000181B95620
		public bool hasHandle(); // 0x0000000180119510-0x0000000180119550
		public void clearHandle(); // 0x00000001801180A0-0x00000001801180E0
	}
}
