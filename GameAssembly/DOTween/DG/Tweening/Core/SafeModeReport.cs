/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Core
{
	internal struct SafeModeReport // TypeDefIndex: 5837
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <totMissingTargetOrFieldErrors>k__BackingField; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <totCallbackErrors>k__BackingField; // 0x04
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <totStartupErrors>k__BackingField; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <totUnsetErrors>k__BackingField; // 0x0C
	
		// Properties
		public int totMissingTargetOrFieldErrors { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180004EC0-0x0000000180004ED0 0x0000000180007630-0x0000000180007640
		public int totCallbackErrors { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180003CA0-0x0000000180003FD0 0x00000001800215B0-0x00000001800215C0
		public int totStartupErrors { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
		public int totUnsetErrors { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180030DA0-0x0000000180030DB0 0x00000001800A2910-0x00000001800A2920
	
		// Nested types
		internal enum SafeModeReportType // TypeDefIndex: 5838
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}
	
		// Methods
		public void Add(SafeModeReportType type); // 0x00000001800DFB90-0x00000001800DFBB0
		public int GetTotErrors(); // 0x00000001800DFBB0-0x00000001800DFBC0
	}
}
