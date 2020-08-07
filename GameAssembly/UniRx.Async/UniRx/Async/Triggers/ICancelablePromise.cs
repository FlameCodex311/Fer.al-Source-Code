/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	public interface ICancelablePromise // TypeDefIndex: 8839
	{
		// Properties
		CancellationToken RegisteredCancellationToken { get; }
	
		// Methods
		bool TrySetCanceled();
	}
}
