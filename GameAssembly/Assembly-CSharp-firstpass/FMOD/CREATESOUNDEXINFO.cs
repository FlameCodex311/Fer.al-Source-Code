/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct CREATESOUNDEXINFO // TypeDefIndex: 9653
	{
		// Fields
		public int cbsize; // 0x00
		public uint length; // 0x04
		public uint fileoffset; // 0x08
		public int numchannels; // 0x0C
		public int defaultfrequency; // 0x10
		public SOUND_FORMAT format; // 0x14
		public uint decodebuffersize; // 0x18
		public int initialsubsound; // 0x1C
		public int numsubsounds; // 0x20
		public IntPtr inclusionlist; // 0x28
		public int inclusionlistnum; // 0x30
		public SOUND_PCMREAD_CALLBACK pcmreadcallback; // 0x38
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback; // 0x40
		public SOUND_NONBLOCK_CALLBACK nonblockcallback; // 0x48
		public IntPtr dlsname; // 0x50
		public IntPtr encryptionkey; // 0x58
		public int maxpolyphony; // 0x60
		public IntPtr userdata; // 0x68
		public SOUND_TYPE suggestedsoundtype; // 0x70
		public FILE_OPEN_CALLBACK fileuseropen; // 0x78
		public FILE_CLOSE_CALLBACK fileuserclose; // 0x80
		public FILE_READ_CALLBACK fileuserread; // 0x88
		public FILE_SEEK_CALLBACK fileuserseek; // 0x90
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread; // 0x98
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel; // 0xA0
		public IntPtr fileuserdata; // 0xA8
		public int filebuffersize; // 0xB0
		public CHANNELORDER channelorder; // 0xB4
		public IntPtr initialsoundgroup; // 0xB8
		public uint initialseekposition; // 0xC0
		public TIMEUNIT initialseekpostype; // 0xC4
		public int ignoresetfilesystem; // 0xC8
		public uint audioqueuepolicy; // 0xCC
		public uint minmidigranularity; // 0xD0
		public int nonblockthreadid; // 0xD4
		public IntPtr fsbguid; // 0xD8
	}
}
