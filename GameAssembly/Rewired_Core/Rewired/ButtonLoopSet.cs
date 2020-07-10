/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class ButtonLoopSet : UpdateLoopDataSet<Rewired.ButtonLoopSet.ButtonData> // TypeDefIndex: 5773
	{
		// Fields
		public readonly int buttonCount; // 0x38
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		public class ButtonData // TypeDefIndex: 5774
		{
			// Fields
			public readonly UpdateLoopType updateLoop; // 0x10
			public readonly bool[] values; // 0x18
			public readonly bool[] wasTrueThisFrame; // 0x20
			private bool[] cMhEJwVMfmVmCFDwoVYzoCYbEQTH; // 0x28
			private int pJEKLHQNGkWDQQpFzlufkYmYkQp; // 0x30
	
			// Properties
			public bool[] effectiveValue { get; } // 0x000000018142F100-0x000000018142F130 
	
			// Constructors
			public ButtonData(int count, UpdateLoopType updateLoop); // 0x000000018142F000-0x000000018142F100
	
			// Methods
			public void SetValue(int index, bool value); // 0x000000018142EEB0-0x000000018142F000
			public void ClearWasTrueThisFrame(); // 0x000000018142E7C0-0x000000018142E8D0
			public void Clear(); // 0x000000018142E8D0-0x000000018142EA10
			public void Import(ButtonData source); // 0x000000018142EA10-0x000000018142EC40
			private void RaLVxJRaHFAmTEJyNEOQHPVXPJy(); // 0x000000018142EC40-0x000000018142EEB0
		}
	
		// Constructors
		public ButtonLoopSet(UpdateLoopSetting updateLoops, int buttonCount); // 0x000000018142F430-0x000000018142F5D0
	
		// Methods
		public void SetValue(int index, bool value, float timestamp); // 0x000000018142F360-0x000000018142F430
		public void Clear(); // 0x000000018142F130-0x000000018142F1E0
		public void Import(ButtonLoopSet set); // 0x000000018142F1E0-0x000000018142F360
	}
}
