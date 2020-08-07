/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class CancellationTokenExtensions // TypeDefIndex: 8546
	{
		// Fields
		private static readonly Action<object> cancellationTokenCallback; // 0x00
	
		// Constructors
		static CancellationTokenExtensions(); // 0x0000000180E15F00-0x0000000180E15F60
	
		// Methods
		private static void Callback(object state); // 0x0000000180E15900-0x0000000180E15A10
	
		// Extension methods
		public static ValueTuple<UniTask, CancellationTokenRegistration> ToUniTask(this CancellationToken cts); // 0x0000000180E15D20-0x0000000180E15F00
		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action callback); // 0x0000000180E15A10-0x0000000180E15B90
		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action<object> callback, object state); // 0x0000000180E15B90-0x0000000180E15D20
	}
}
