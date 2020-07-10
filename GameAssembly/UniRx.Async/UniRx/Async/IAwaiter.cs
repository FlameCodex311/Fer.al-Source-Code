/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public interface IAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 8394
	{
		// Properties
		AwaiterStatus Status { get; }
		bool IsCompleted { get; }
	
		// Methods
		void GetResult();
	}
}
