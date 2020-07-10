/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public struct PlayerSaveData // TypeDefIndex: 6557
	{
		// Fields
		private JoystickMapSaveData[] OEJfsNUuTIeuFBuRDCaNuRpxUgZt; // 0x00
		private KeyboardMapSaveData[] uXllotqyAHIWsQRCshTcigWbMPd; // 0x08
		private MouseMapSaveData[] MYsrOqZuPpyBAFfCkIkwcriQASF; // 0x10
		private CustomControllerMapSaveData[] UjtGVqusKclhkzHaSUwoqSCiNKz; // 0x18
		private InputBehavior[] vRzKeKfOVPvpbXPvQFawHLKwCdF; // 0x20
	
		// Properties
		public JoystickMapSaveData[] joystickMapSaveData { get; } // 0x0000000180004C30-0x0000000180004C40 
		public KeyboardMapSaveData[] keyboardMapSaveData { get; } // 0x0000000180002710-0x0000000180002720 
		public MouseMapSaveData[] mouseMapSaveData { get; } // 0x0000000180003C20-0x0000000180003C30 
		public CustomControllerMapSaveData[] customControllerMapSaveData { get; } // 0x0000000180002430-0x00000001800024A0 
		public InputBehavior[] inputBehaviors { get; } // 0x0000000180005D20-0x0000000180005D30 
		public int joystickMapCount { get; } // 0x0000000180006820-0x0000000180006830 
		public int keyboardMapCount { get; } // 0x0000000180006830-0x0000000180006840 
		public int mouseMapCount { get; } // 0x0000000180006840-0x0000000180006960 
		public int customControllerMapCount { get; } // 0x0000000180006800-0x0000000180006810 
		public int inputBehaviorCount { get; } // 0x0000000180006810-0x0000000180006820 
		public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData { get; } // 0x0000000180006740-0x0000000180006800 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class VUZdugEcCNzTUDqEUUKJNLALwvi : IEnumerable<ControllerMapSaveData>, IEnumerator<ControllerMapSaveData> // TypeDefIndex: 6558
		{
			// Fields
			private ControllerMapSaveData aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public PlayerSaveData gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public PlayerSaveData eBLlhiGHVnEGzXsXPDhzgMxdOdW; // 0x48
			public int ZKnOmfdBGxPCzuiOaEmmaNwByyN; // 0x70
			public int ShqExnPgFGPPSuEkjAhpbhgXsVm; // 0x74
			public int EzlNdDiJLzCGKJIWzgipESarGzsK; // 0x78
			public int cddIyxGkSTGjwyXaReqLlOuzwcTj; // 0x7C
	
			// Properties
			ControllerMapSaveData LmEtVDpAbJKkdyFOfYKJjvDHBpp { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public VUZdugEcCNzTUDqEUUKJNLALwvi(int <>1__state); // 0x000000018051AFB0-0x000000018051B020
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ControllerMapSaveData> IEnumerable<ControllerMapSaveData>.GetEnumerator(); // 0x000000018051AE00-0x000000018051AF60
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018051AE00-0x000000018051AF60
			private bool MoveNext(); // 0x000000018051A970-0x000000018051AE00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018051AF60-0x000000018051AFB0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		internal PlayerSaveData(JoystickMapSaveData[] joystickMapSaveData, KeyboardMapSaveData[] keyboardMapSaveData, MouseMapSaveData[] mouseMapSaveData, CustomControllerMapSaveData[] customControllerMapSaveData, IList<InputBehavior> inputBehaviors); // 0x0000000180006730-0x0000000180006740
	}
}
