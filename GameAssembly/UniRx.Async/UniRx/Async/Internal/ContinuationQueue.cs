/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal class ContinuationQueue // TypeDefIndex: 8860
	{
		// Fields
		private const int MaxArrayLength = 2146435071; // Metadata: 0x007780DB
		private const int InitialSize = 16; // Metadata: 0x007780DF
		private SpinLock gate; // 0x10
		private bool dequing; // 0x14
		private int actionListCount; // 0x18
		private Action[] actionList; // 0x20
		private int waitingListCount; // 0x28
		private Action[] waitingList; // 0x30
	
		// Constructors
		public ContinuationQueue(); // 0x0000000180E16B40-0x0000000180E16BA0
	
		// Methods
		public void Enqueue(Action continuation); // 0x0000000180E166C0-0x0000000180E16920
		public void Run(); // 0x0000000180E16920-0x0000000180E16B40
	}
}
