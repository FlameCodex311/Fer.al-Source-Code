/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public class CancellationTokenEqualityComparer : IEqualityComparer<CancellationToken> // TypeDefIndex: 8545
	{
		// Fields
		public static readonly IEqualityComparer<CancellationToken> Default; // 0x00
	
		// Constructors
		public CancellationTokenEqualityComparer(); // 0x0000000180373240-0x0000000180373250
		static CancellationTokenEqualityComparer(); // 0x0000000180E158A0-0x0000000180E15900
	
		// Methods
		public bool Equals(CancellationToken x, CancellationToken y); // 0x0000000180E15860-0x0000000180E15880
		public int GetHashCode(CancellationToken obj); // 0x0000000180E15880-0x0000000180E158A0
	}
}
