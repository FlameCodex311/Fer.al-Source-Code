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
	public class TupleI : Tuple<int, int> // TypeDefIndex: 15382
	{
		// Properties
		public static TupleI zero { get; } // 0x0000000180F77A30-0x0000000180F77AC0 
		public static TupleI one { get; } // 0x0000000180F779A0-0x0000000180F77A30 
	
		// Constructors
		public TupleI(int a, int b); // 0x0000000180F77920-0x0000000180F779A0
	
		// Methods
		public static TupleI operator +(TupleI a, TupleI b); // 0x0000000180F77AC0-0x0000000180F77BB0
		public static TupleI operator -(TupleI a, TupleI b); // 0x0000000180F77E90-0x0000000180F77F80
		public static TupleI operator *(TupleI a, TupleI b); // 0x0000000180F77DA0-0x0000000180F77E90
		public static TupleI operator /(TupleI a, TupleI b); // 0x0000000180F77BB0-0x0000000180F77CB0
		public static implicit operator Vector2(TupleI t); // 0x0000000180F77D60-0x0000000180F77DA0
		public static implicit operator TupleI(Vector2 v); // 0x0000000180F77CB0-0x0000000180F77D60
	}
}
