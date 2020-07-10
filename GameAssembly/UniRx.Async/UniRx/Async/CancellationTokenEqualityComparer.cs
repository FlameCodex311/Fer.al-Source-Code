/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public class CancellationTokenEqualityComparer : IEqualityComparer<CancellationToken> // TypeDefIndex: 8379
	{
		// Fields
		public static readonly IEqualityComparer<CancellationToken> Default; // 0x00
	
		// Constructors
		public CancellationTokenEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
		static CancellationTokenEqualityComparer(); // 0x0000000181668840-0x00000001816688A0
	
		// Methods
		public bool Equals(CancellationToken x, CancellationToken y); // 0x0000000181668800-0x0000000181668820
		public int GetHashCode(CancellationToken obj); // 0x0000000181668820-0x0000000181668840
	}
}
