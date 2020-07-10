/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace GestureRecognizer
{
	public struct Score // TypeDefIndex: 9586
	{
		// Fields
		public float positionDistance; // 0x00
		public float curvatureDistance; // 0x04
		public float angleDistance; // 0x08
	
		// Properties
		public float score { get; } // 0x00000001802538B0-0x00000001802538F0 
		public static Score MaxDistance { get; } // 0x0000000181658620-0x0000000181658740 
	
		// Methods
		public void InitMax(); // 0x0000000180253890-0x00000001802538B0
		public static bool operator >(Score s1, Score s2); // 0x0000000181658780-0x00000001816587C0
		public static bool operator <(Score s1, Score s2); // 0x0000000181658800-0x0000000181658840
		public static bool operator >=(Score s1, Score s2); // 0x0000000181658740-0x0000000181658780
		public static bool operator <=(Score s1, Score s2); // 0x00000001816587C0-0x0000000181658800
	}
}
