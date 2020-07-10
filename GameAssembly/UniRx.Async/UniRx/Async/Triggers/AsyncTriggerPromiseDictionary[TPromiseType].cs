/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	public class AsyncTriggerPromiseDictionary<TPromiseType> : Dictionary<CancellationToken, UniRx.Async.Triggers.AsyncTriggerPromise<TPromiseType>>, ICancellationTokenKeyDictionary, IEnumerable<UniRx.Async.Triggers.ICancelablePromise> // TypeDefIndex: 8676
	{
		// Constructors
		public AsyncTriggerPromiseDictionary();
	
		// Methods
		IEnumerator<ICancelablePromise> IEnumerable<ICancelablePromise>.GetEnumerator();
		void ICancellationTokenKeyDictionary.Remove(CancellationToken token);
	}
}
