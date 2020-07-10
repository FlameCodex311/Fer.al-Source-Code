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
	public class Tuple3<T1, T2, T3> // TypeDefIndex: 15380
	{
		// Fields
		public T1 first;
		public T2 second;
		public T3 third;
		private static readonly IEqualityComparer<T1> Item1Comparer;
		private static readonly IEqualityComparer<T2> Item2Comparer;
		private static readonly IEqualityComparer<T3> Item3Comparer;
	
		// Constructors
		public Tuple3(Tuple<T1, T2> _tuple2, T3 _third);
		public Tuple3(T1 _first, T2 _second, T3 _third);
		static Tuple3();
	
		// Methods
		public override string ToString();
		public override int GetHashCode();
		public override bool Equals(object obj);
		private static bool IsNull(object obj);
		public static bool operator ==(Tuple3<T1, T2, T3> a, Tuple3<T1, T2, T3> b);
		public static bool operator !=(Tuple3<T1, T2, T3> a, Tuple3<T1, T2, T3> b);
	}
}
