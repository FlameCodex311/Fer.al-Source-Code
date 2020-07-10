/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	public interface ICancelablePromise // TypeDefIndex: 8673
	{
		// Properties
		CancellationToken RegisteredCancellationToken { get; }
	
		// Methods
		bool TrySetCanceled();
	}
}
