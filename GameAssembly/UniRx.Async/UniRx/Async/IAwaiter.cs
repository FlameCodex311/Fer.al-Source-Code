/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public interface IAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 8560
	{
		// Properties
		AwaiterStatus Status { get; }
		bool IsCompleted { get; }
	
		// Methods
		void GetResult();
	}
}
