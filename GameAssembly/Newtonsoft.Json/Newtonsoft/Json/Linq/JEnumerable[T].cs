﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180257B50-0x0000000180257B90
	public struct JEnumerable<T> : IJEnumerable<T>, IEquatable<Newtonsoft.Json.Linq.JEnumerable<T>> // TypeDefIndex: 8139
		where T : JToken
	{
		// Fields
		public static readonly JEnumerable<T> Empty;
		private readonly IEnumerable<T> _enumerable;
	
		// Constructors
		public JEnumerable(IEnumerable<T> enumerable);
		static JEnumerable();
	
		// Methods
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool Equals(JEnumerable<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
	}
}
