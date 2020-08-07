/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class UnknownControllerHat // TypeDefIndex: 5908
	{
		// Fields
		private HatButtons OXPByOKoaRQllfWevmTNQZWTRXk; // 0x10
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001801D0AE0-0x00000001801D0B50
		[CustomObfuscation] // 0x00000001801D0AE0-0x00000001801D0B50
		public class HatButtons // TypeDefIndex: 5909
		{
			// Fields
			private int[] OXPByOKoaRQllfWevmTNQZWTRXk; // 0x10
	
			// Properties
			public int this[int index] { get => default; } // 0x00000001809696E0-0x0000000180969720 
	
			// Constructors
			public HatButtons(int[] buttons); // 0x0000000180400150-0x0000000180400180
	
			// Methods
			public void GetNeighbors(int button, out int neighbor1, out int neighbor2); // 0x00000001810921E0-0x0000000181092360
			public bool IsCardinal(int button); // 0x0000000181092400-0x0000000181092430
			public bool IsCorner(int button); // 0x0000000181092430-0x0000000181092460
			public int IndexOf(int button); // 0x0000000181092360-0x0000000181092400
			public bool Contains(int button); // 0x00000001810921C0-0x00000001810921E0
		}
	
		// Constructors
		public UnknownControllerHat(HatButtons buttons); // 0x0000000180400150-0x0000000180400180
	
		// Methods
		public bool ContainsButtonIndex(int index); // 0x00000001810ABC70-0x00000001810ABD00
		public bool IsButtonIndexCardinal(int index); // 0x00000001810ABD00-0x00000001810ABDA0
		public HatButtons GetButtons(); // 0x0000000180372440-0x0000000180372450
	}
}
