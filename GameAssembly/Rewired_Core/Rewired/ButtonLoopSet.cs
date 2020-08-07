/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class ButtonLoopSet : UpdateLoopDataSet<Rewired.ButtonLoopSet.ButtonData> // TypeDefIndex: 5932
	{
		// Fields
		public readonly int buttonCount; // 0x38
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		public class ButtonData // TypeDefIndex: 5933
		{
			// Fields
			public readonly UpdateLoopType updateLoop; // 0x10
			public readonly bool[] values; // 0x18
			public readonly bool[] wasTrueThisFrame; // 0x20
			private bool[] cMhEJwVMfmVmCFDwoVYzoCYbEQTH; // 0x28
			private int pJEKLHQNGkWDQQpFzlufkYmYkQp; // 0x30
	
			// Properties
			public bool[] effectiveValue { get; } // 0x000000018090CCD0-0x000000018090CD00 
	
			// Constructors
			public ButtonData(int count, UpdateLoopType updateLoop); // 0x000000018090CBD0-0x000000018090CCD0
	
			// Methods
			public void SetValue(int index, bool value); // 0x000000018090CA90-0x000000018090CBD0
			public void ClearWasTrueThisFrame(); // 0x000000018090C3F0-0x000000018090C4F0
			public void Clear(); // 0x000000018090C4F0-0x000000018090C630
			public void Import(ButtonData source); // 0x000000018090C630-0x000000018090C840
			private void RaLVxJRaHFAmTEJyNEOQHPVXPJy(); // 0x000000018090C840-0x000000018090CA90
		}
	
		// Constructors
		public ButtonLoopSet(UpdateLoopSetting updateLoops, int buttonCount); // 0x000000018090D000-0x000000018090D1A0
	
		// Methods
		public void SetValue(int index, bool value, float timestamp); // 0x000000018090CF30-0x000000018090D000
		public void Clear(); // 0x000000018090CD00-0x000000018090CDB0
		public void Import(ButtonLoopSet set); // 0x000000018090CDB0-0x000000018090CF30
	}
}
