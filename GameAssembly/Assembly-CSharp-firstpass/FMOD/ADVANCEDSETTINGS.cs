/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct ADVANCEDSETTINGS // TypeDefIndex: 10110
	{
		// Fields
		public int cbSize; // 0x00
		public int maxMPEGCodecs; // 0x04
		public int maxADPCMCodecs; // 0x08
		public int maxXMACodecs; // 0x0C
		public int maxVorbisCodecs; // 0x10
		public int maxAT9Codecs; // 0x14
		public int maxFADPCMCodecs; // 0x18
		public int maxPCMCodecs; // 0x1C
		public int ASIONumChannels; // 0x20
		public IntPtr ASIOChannelList; // 0x28
		public IntPtr ASIOSpeakerList; // 0x30
		public float vol0virtualvol; // 0x38
		public uint defaultDecodeBufferSize; // 0x3C
		public ushort profilePort; // 0x40
		public uint geometryMaxFadeTime; // 0x44
		public float distanceFilterCenterFreq; // 0x48
		public int reverb3Dinstance; // 0x4C
		public int DSPBufferPoolSize; // 0x50
		public uint stackSizeStream; // 0x54
		public uint stackSizeNonBlocking; // 0x58
		public uint stackSizeMixer; // 0x5C
		public DSP_RESAMPLER resamplerMethod; // 0x60
		public uint commandQueueSize; // 0x64
		public uint randomSeed; // 0x68
	}
}
