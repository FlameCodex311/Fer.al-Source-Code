/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	internal class ContinuationQueue // TypeDefIndex: 8694
	{
		// Fields
		private const int MaxArrayLength = 2146435071; // Metadata: 0x007433ED
		private const int InitialSize = 16; // Metadata: 0x007433F1
		private SpinLock gate; // 0x10
		private bool dequing; // 0x14
		private int actionListCount; // 0x18
		private Action[] actionList; // 0x20
		private int waitingListCount; // 0x28
		private Action[] waitingList; // 0x30
	
		// Constructors
		public ContinuationQueue(); // 0x0000000181669D90-0x0000000181669DF0
	
		// Methods
		public void Enqueue(Action continuation); // 0x00000001816698F0-0x0000000181669B60
		public void Run(); // 0x0000000181669B60-0x0000000181669D90
	}
}
