/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace GestureRecognizer
{
	public struct Score // TypeDefIndex: 10040
	{
		// Fields
		public float positionDistance; // 0x00
		public float curvatureDistance; // 0x04
		public float angleDistance; // 0x08
	
		// Properties
		public float score { get; } // 0x0000000180071C10-0x0000000180071E90 
		public static Score MaxDistance { get; } // 0x0000000180D324C0-0x0000000180D325E0 
	
		// Methods
		public void InitMax(); // 0x0000000180071BF0-0x0000000180071C10
		public static bool operator >(Score s1, Score s2); // 0x0000000180D32620-0x0000000180D32660
		public static bool operator <(Score s1, Score s2); // 0x0000000180D326A0-0x0000000180D326E0
		public static bool operator >=(Score s1, Score s2); // 0x0000000180D325E0-0x0000000180D32620
		public static bool operator <=(Score s1, Score s2); // 0x0000000180D32660-0x0000000180D326A0
	}
}
