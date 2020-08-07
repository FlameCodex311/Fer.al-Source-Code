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
	public class TupleI : Tuple<int, int> // TypeDefIndex: 16097
	{
		// Properties
		public static TupleI zero { get; } // 0x0000000180443990-0x0000000180443A20 
		public static TupleI one { get; } // 0x0000000180443900-0x0000000180443990 
	
		// Constructors
		public TupleI(int a, int b); // 0x0000000180443880-0x0000000180443900
	
		// Methods
		public static TupleI operator +(TupleI a, TupleI b); // 0x0000000180443A20-0x0000000180443B10
		public static TupleI operator -(TupleI a, TupleI b); // 0x0000000180443DF0-0x0000000180443EE0
		public static TupleI operator *(TupleI a, TupleI b); // 0x0000000180443D00-0x0000000180443DF0
		public static TupleI operator /(TupleI a, TupleI b); // 0x0000000180443B10-0x0000000180443C10
		public static implicit operator Vector2(TupleI t); // 0x0000000180443CC0-0x0000000180443D00
		public static implicit operator TupleI(Vector2 v); // 0x0000000180443C10-0x0000000180443CC0
	}
}
