/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Core
{
	internal struct SafeModeReport // TypeDefIndex: 5678
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <totMissingTargetOrFieldErrors>k__BackingField; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <totCallbackErrors>k__BackingField; // 0x04
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <totStartupErrors>k__BackingField; // 0x08
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <totUnsetErrors>k__BackingField; // 0x0C
	
		// Properties
		public int totMissingTargetOrFieldErrors { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180004180-0x0000000180004190 0x0000000180004650-0x0000000180004660
		public int totCallbackErrors { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180002FD0-0x0000000180003310 0x0000000180004CC0-0x0000000180004CD0
		public int totStartupErrors { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public int totUnsetErrors { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001800060E0-0x00000001800060F0 0x000000018000A1D0-0x000000018000A1E0
	
		// Nested types
		internal enum SafeModeReportType // TypeDefIndex: 5679
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}
	
		// Methods
		public void Add(SafeModeReportType type); // 0x000000018001F530-0x000000018001F550
		public int GetTotErrors(); // 0x000000018001F550-0x000000018001F560
	}
}
