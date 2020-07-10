/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Unitilities.Tuples
{
	[Serializable]
	public class Tuple3I : Tuple3<int, int, int> // TypeDefIndex: 15383
	{
		// Properties
		public static Tuple3I zero { get; } // 0x0000000180F77460-0x0000000180F774F0 
		public static Tuple3I one { get; } // 0x0000000180F773C0-0x0000000180F77460 
	
		// Constructors
		public Tuple3I(int a, int b, int c); // 0x0000000180F77330-0x0000000180F773C0
	
		// Methods
		public static Tuple3I operator +(Tuple3I a, Tuple3I b); // 0x0000000180F774F0-0x0000000180F775C0
		public static Tuple3I operator -(Tuple3I a, Tuple3I b); // 0x0000000180F77850-0x0000000180F77920
		public static Tuple3I operator *(Tuple3I a, Tuple3I b); // 0x0000000180F77780-0x0000000180F77850
		public static Tuple3I operator /(Tuple3I a, Tuple3I b); // 0x0000000180F775C0-0x0000000180F776A0
		public static implicit operator Vector3(Tuple3I t); // 0x0000000180F776A0-0x0000000180F77700
		public static implicit operator Tuple3I(Vector3 v); // 0x0000000180F77700-0x0000000180F77780
	}
}
