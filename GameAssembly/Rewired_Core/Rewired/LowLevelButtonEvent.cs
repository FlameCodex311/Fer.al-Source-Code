/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Utility;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal sealed class LowLevelButtonEvent : LowLevelEvent // TypeDefIndex: 5935
	{
		// Fields
		private const int qjYEzlcqnRjpmfRwXjlhcmfUoPZw = 100; // Metadata: 0x00763830
		public float value; // 0x18
		private static readonly ObjectPool<LowLevelButtonEvent> eFCibrbGidYVCqriQoUjiEnwNFDh; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<LowLevelButtonEvent> RmAwVhXJkTmkPbnjHBqKiBrHewI; // 0x08
	
		// Constructors
		private LowLevelButtonEvent(); // 0x0000000180373240-0x0000000180373250
		static LowLevelButtonEvent(); // 0x0000000180EAB850-0x0000000180EAB920
	
		// Methods
		public static LowLevelButtonEvent GetPooled(float timestamp, float value); // 0x0000000180EAB640-0x0000000180EAB760
		public static void ReturnPooled(LowLevelButtonEvent @event); // 0x0000000180EAB760-0x0000000180EAB800
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static LowLevelButtonEvent SHhkYQoZOcOvJaWepRTLupkJhxaf(); // 0x0000000180EAB800-0x0000000180EAB850
	}
}
