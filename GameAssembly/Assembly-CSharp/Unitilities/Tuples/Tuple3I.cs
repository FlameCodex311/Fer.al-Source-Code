/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Unitilities.Tuples
{
	[Serializable]
	public class Tuple3I : Tuple3<int, int, int> // TypeDefIndex: 16098
	{
		// Properties
		public static Tuple3I zero { get; } // 0x00000001804433E0-0x0000000180443470 
		public static Tuple3I one { get; } // 0x0000000180443340-0x00000001804433E0 
	
		// Constructors
		public Tuple3I(int a, int b, int c); // 0x00000001804432B0-0x0000000180443340
	
		// Methods
		public static Tuple3I operator +(Tuple3I a, Tuple3I b); // 0x0000000180443470-0x0000000180443530
		public static Tuple3I operator -(Tuple3I a, Tuple3I b); // 0x00000001804437B0-0x0000000180443880
		public static Tuple3I operator *(Tuple3I a, Tuple3I b); // 0x00000001804436E0-0x00000001804437B0
		public static Tuple3I operator /(Tuple3I a, Tuple3I b); // 0x0000000180443530-0x0000000180443600
		public static implicit operator Vector3(Tuple3I t); // 0x0000000180443600-0x0000000180443660
		public static implicit operator Tuple3I(Vector3 v); // 0x0000000180443660-0x00000001804436E0
	}
}
