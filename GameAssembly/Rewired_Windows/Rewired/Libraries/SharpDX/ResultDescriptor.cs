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

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

namespace Rewired.Libraries.SharpDX
{
	internal sealed class ResultDescriptor // TypeDefIndex: 8314
	{
		// Fields
		private static readonly object LockDescriptor; // 0x00
		private static readonly List<Type> RegisteredDescriptorProvider; // 0x08
		private static readonly Dictionary<UzlbEXavGoPESIZdELhSmKjMUa, ResultDescriptor> Descriptors; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private UzlbEXavGoPESIZdELhSmKjMUa <Result>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Module>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <NativeApiCode>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <ApiCode>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Description>k__BackingField; // 0x30
	
		// Properties
		public UzlbEXavGoPESIZdELhSmKjMUa Result { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public string Module { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string NativeApiCode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public string ApiCode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public string Description { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	
		// Constructors
		public ResultDescriptor(UzlbEXavGoPESIZdELhSmKjMUa code, string module, string nativeApiCode, string apiCode, string description = null); // 0x0000000180422CD0-0x0000000180422D30
		static ResultDescriptor(); // 0x0000000180422C10-0x0000000180422CD0
	
		// Methods
		public bool Equals(ResultDescriptor other); // 0x0000000180422190-0x00000001804221B0
		public override bool Equals(object obj); // 0x00000001804221B0-0x00000001804222A0
		public override int GetHashCode(); // 0x000000018036CFF0-0x000000018036D000
		public override string ToString(); // 0x00000001804229D0-0x0000000180422C10
		public static ResultDescriptor Find(UzlbEXavGoPESIZdELhSmKjMUa result); // 0x00000001804222A0-0x0000000180422790
		private static void AddDescriptorsFromType(Type type); // 0x0000000180421F70-0x0000000180422190
		private static string GetDescriptionFromResultCode(int resultCode); // 0x0000000180422880-0x00000001804229D0
		private static extern uint FormatMessageW(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, ref IntPtr lpBuffer, int nSize, IntPtr Arguments); // 0x0000000180422790-0x0000000180422880
	}
}
