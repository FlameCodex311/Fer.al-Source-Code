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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public struct PlayerSaveData // TypeDefIndex: 6716
	{
		// Fields
		private JoystickMapSaveData[] OEJfsNUuTIeuFBuRDCaNuRpxUgZt; // 0x00
		private KeyboardMapSaveData[] uXllotqyAHIWsQRCshTcigWbMPd; // 0x08
		private MouseMapSaveData[] MYsrOqZuPpyBAFfCkIkwcriQASF; // 0x10
		private CustomControllerMapSaveData[] UjtGVqusKclhkzHaSUwoqSCiNKz; // 0x18
		private InputBehavior[] vRzKeKfOVPvpbXPvQFawHLKwCdF; // 0x20
	
		// Properties
		public JoystickMapSaveData[] joystickMapSaveData { get; } // 0x000000018001A8D0-0x000000018001A8E0 
		public KeyboardMapSaveData[] keyboardMapSaveData { get; } // 0x00000001800034E0-0x00000001800034F0 
		public MouseMapSaveData[] mouseMapSaveData { get; } // 0x000000018001A8E0-0x000000018001A8F0 
		public CustomControllerMapSaveData[] customControllerMapSaveData { get; } // 0x0000000180003250-0x0000000180003270 
		public InputBehavior[] inputBehaviors { get; } // 0x0000000180028200-0x0000000180028E60 
		public int joystickMapCount { get; } // 0x00000001800520E0-0x00000001800520F0 
		public int keyboardMapCount { get; } // 0x00000001800520F0-0x0000000180052100 
		public int mouseMapCount { get; } // 0x0000000180052100-0x0000000180052130 
		public int customControllerMapCount { get; } // 0x00000001800520C0-0x00000001800520D0 
		public int inputBehaviorCount { get; } // 0x00000001800520D0-0x00000001800520E0 
		public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData { get; } // 0x0000000180052000-0x00000001800520C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class VUZdugEcCNzTUDqEUUKJNLALwvi : IEnumerable<ControllerMapSaveData>, IEnumerator<ControllerMapSaveData> // TypeDefIndex: 6717
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
			ControllerMapSaveData LmEtVDpAbJKkdyFOfYKJjvDHBpp { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public VUZdugEcCNzTUDqEUUKJNLALwvi(int <>1__state); // 0x0000000180B43030-0x0000000180B430A0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ControllerMapSaveData> IEnumerable<ControllerMapSaveData>.GetEnumerator(); // 0x0000000180B42E90-0x0000000180B42FE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180B42E90-0x0000000180B42FE0
			private bool MoveNext(); // 0x0000000180B42A30-0x0000000180B42E90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180B42FE0-0x0000000180B43030
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		internal PlayerSaveData(JoystickMapSaveData[] joystickMapSaveData, KeyboardMapSaveData[] keyboardMapSaveData, MouseMapSaveData[] mouseMapSaveData, CustomControllerMapSaveData[] customControllerMapSaveData, IList<InputBehavior> inputBehaviors); // 0x0000000180051E60-0x0000000180052000
	}
}
