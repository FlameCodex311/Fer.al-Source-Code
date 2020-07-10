/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	internal static class NativeMethods // TypeDefIndex: 9949
	{
		// Nested types
		internal struct STARTUPINFOEX // TypeDefIndex: 9950
		{
			// Fields
			public STARTUPINFO StartupInfo; // 0x00
			public IntPtr lpAttributeList; // 0x68
		}
	
		internal struct STARTUPINFO // TypeDefIndex: 9951
		{
			// Fields
			public int cb; // 0x00
			public string lpReserved; // 0x08
			public string lpDesktop; // 0x10
			public string lpTitle; // 0x18
			public int dwX; // 0x20
			public int dwY; // 0x24
			public int dwXSize; // 0x28
			public int dwYSize; // 0x2C
			public int dwXCountChars; // 0x30
			public int dwYCountChars; // 0x34
			public int dwFillAttribute; // 0x38
			public int dwFlags; // 0x3C
			public short wShowWindow; // 0x40
			public short cbReserved2; // 0x42
			public IntPtr lpReserved2; // 0x48
			public IntPtr hStdInput; // 0x50
			public IntPtr hStdOutput; // 0x58
			public IntPtr hStdError; // 0x60
		}
	
		internal struct PROCESS_INFORMATION // TypeDefIndex: 9952
		{
			// Fields
			public IntPtr hProcess; // 0x00
			public IntPtr hThread; // 0x08
			public int dwProcessId; // 0x10
			public int dwThreadId; // 0x14
		}
	
		internal struct SECURITY_ATTRIBUTES // TypeDefIndex: 9953
		{
			// Fields
			public int nLength; // 0x00
			public IntPtr lpSecurityDescriptor; // 0x08
			public int bInheritHandle; // 0x10
		}
	
		// Methods
		internal static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, in STARTUPINFOEX lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation); // 0x00000001815E9800-0x00000001815E9AB0
		[ReliabilityContract] // 0x00000001800DE560-0x00000001800DE580
		internal static extern bool CloseHandle(IntPtr hObject); // 0x00000001815E9750-0x00000001815E9800
		internal static extern bool GetExitCodeProcess(IntPtr process, ref uint exitCode); // 0x00000001815E9B40-0x00000001815E9C00
		internal static extern uint WaitForSingleObject(IntPtr handle, uint milliseconds); // 0x00000001815EA4C0-0x00000001815EA570
		internal static extern bool TerminateProcess(IntPtr hProcess, ref uint exitCode); // 0x00000001815EA400-0x00000001815EA4C0
		internal static extern uint GetLastError(); // 0x00000001815E9C00-0x00000001815E9C90
	}
}
