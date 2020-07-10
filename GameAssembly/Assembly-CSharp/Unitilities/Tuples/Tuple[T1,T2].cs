/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Unitilities.Tuples
{
	[Serializable]
	public class Tuple<T1, T2> // TypeDefIndex: 15379
	{
		// Fields
		public T1 first;
		public T2 second;
		private static readonly IEqualityComparer<T1> Item1Comparer;
		private static readonly IEqualityComparer<T2> Item2Comparer;
	
		// Constructors
		public Tuple(T1 _first, T2 _second);
		static Tuple();
	
		// Methods
		public override string ToString();
		public override int GetHashCode();
		public override bool Equals(object obj);
		private static bool IsNull(object obj);
		public static bool operator ==(Tuple<T1, T2> a, Tuple<T1, T2> b);
		public static bool operator !=(Tuple<T1, T2> a, Tuple<T1, T2> b);
	}
}
