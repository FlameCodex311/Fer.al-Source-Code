/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class CancellationTokenExtensions // TypeDefIndex: 8380
	{
		// Fields
		private static readonly Action<object> cancellationTokenCallback; // 0x00
	
		// Constructors
		static CancellationTokenExtensions(); // 0x0000000181668F00-0x0000000181668F60
	
		// Methods
		private static void Callback(object state); // 0x00000001816688A0-0x00000001816689B0
	
		// Extension methods
		public static ValueTuple<UniTask, CancellationTokenRegistration> ToUniTask(this CancellationToken cts); // 0x0000000181668CC0-0x0000000181668F00
		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action callback); // 0x00000001816689B0-0x0000000181668B30
		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action<object> callback, object state); // 0x0000000181668B30-0x0000000181668CC0
	}
}
