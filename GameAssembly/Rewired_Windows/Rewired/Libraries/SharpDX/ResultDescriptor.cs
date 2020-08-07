/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

namespace Rewired.Libraries.SharpDX
{
	internal sealed class ResultDescriptor // TypeDefIndex: 8480
	{
		// Fields
		private static readonly object LockDescriptor; // 0x00
		private static readonly List<Type> RegisteredDescriptorProvider; // 0x08
		private static readonly Dictionary<UzlbEXavGoPESIZdELhSmKjMUa, ResultDescriptor> Descriptors; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UzlbEXavGoPESIZdELhSmKjMUa <Result>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Module>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <NativeApiCode>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <ApiCode>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Description>k__BackingField; // 0x30
	
		// Properties
		public UzlbEXavGoPESIZdELhSmKjMUa Result { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public string Module { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string NativeApiCode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public string ApiCode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public string Description { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	
		// Constructors
		public ResultDescriptor(UzlbEXavGoPESIZdELhSmKjMUa code, string module, string nativeApiCode, string apiCode, string description = null); // 0x000000018082E5D0-0x000000018082E630
		static ResultDescriptor(); // 0x000000018082E510-0x000000018082E5D0
	
		// Methods
		public bool Equals(ResultDescriptor other); // 0x000000018082DB20-0x000000018082DB40
		public override bool Equals(object obj); // 0x000000018082DB40-0x000000018082DC30
		public override int GetHashCode(); // 0x0000000180387590-0x0000000180387930
		public override string ToString(); // 0x000000018082E2F0-0x000000018082E510
		public static ResultDescriptor Find(UzlbEXavGoPESIZdELhSmKjMUa result); // 0x000000018082DC30-0x000000018082E0F0
		private static void AddDescriptorsFromType(Type type); // 0x000000018082D900-0x000000018082DB20
		private static string GetDescriptionFromResultCode(int resultCode); // 0x000000018082E1C0-0x000000018082E2F0
		private static extern uint FormatMessageW(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, ref IntPtr lpBuffer, int nSize, IntPtr Arguments); // 0x000000018082E0F0-0x000000018082E1C0
	}
}
