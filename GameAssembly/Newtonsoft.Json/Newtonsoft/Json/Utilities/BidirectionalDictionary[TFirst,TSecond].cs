/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class BidirectionalDictionary<TFirst, TSecond> // TypeDefIndex: 7852
	{
		// Fields
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;
		private readonly string _duplicateFirstErrorMessage;
		private readonly string _duplicateSecondErrorMessage;
	
		// Constructors
		public BidirectionalDictionary();
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer);
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage);
	
		// Methods
		public void Set(TFirst first, TSecond second);
		public bool TryGetByFirst(TFirst first, out TSecond second);
		public bool TryGetBySecond(TSecond second, out TFirst first);
	}
}
