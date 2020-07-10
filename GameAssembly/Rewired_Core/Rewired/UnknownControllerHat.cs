/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class UnknownControllerHat // TypeDefIndex: 5749
	{
		// Fields
		private HatButtons OXPByOKoaRQllfWevmTNQZWTRXk; // 0x10
	
		// Nested types
		[CustomClassObfuscation] // 0x000000018012FF20-0x000000018012FF90
		[CustomObfuscation] // 0x000000018012FF20-0x000000018012FF90
		public class HatButtons // TypeDefIndex: 5750
		{
			// Fields
			private int[] OXPByOKoaRQllfWevmTNQZWTRXk; // 0x10
	
			// Properties
			public int this[int index] { get => default; } // 0x000000018079D320-0x000000018079D360 
	
			// Constructors
			public HatButtons(int[] buttons); // 0x000000018037D3F0-0x000000018037D420
	
			// Methods
			public void GetNeighbors(int button, out int neighbor1, out int neighbor2); // 0x000000018079D080-0x000000018079D210
			public bool IsCardinal(int button); // 0x000000018079D2C0-0x000000018079D2F0
			public bool IsCorner(int button); // 0x000000018079D2F0-0x000000018079D320
			public int IndexOf(int button); // 0x000000018079D210-0x000000018079D2C0
			public bool Contains(int button); // 0x000000018079D060-0x000000018079D080
		}
	
		// Constructors
		public UnknownControllerHat(HatButtons buttons); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		public bool ContainsButtonIndex(int index); // 0x00000001807B70C0-0x00000001807B7150
		public bool IsButtonIndexCardinal(int index); // 0x00000001807B7150-0x00000001807B71F0
		public HatButtons GetButtons(); // 0x000000018036AC80-0x000000018036AC90
	}
}
