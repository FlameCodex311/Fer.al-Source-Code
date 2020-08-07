/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class UniTaskScheduler // TypeDefIndex: 8785
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> UnobservedTaskException; // 0x00
		public static bool PropagateOperationCanceledException; // 0x08
		public static LogType UnobservedExceptionWriteLogType; // 0x0C
		public static bool DispatchUnityMainThread; // 0x10
		private static readonly SendOrPostCallback handleExceptionInvoke; // 0x18
	
		// Events
		public static event Action<Exception> UnobservedTaskException {
			add; // 0x0000000181AC9C30-0x0000000181AC9D20
			remove; // 0x0000000181AC9D20-0x0000000181AC9E10
		}
	
		// Constructors
		static UniTaskScheduler(); // 0x0000000181AC9B90-0x0000000181AC9C30
	
		// Methods
		internal static void PublishUnobservedTaskException(Exception ex); // 0x0000000181AC9800-0x0000000181AC9B90
		private static void InvokeUnobservedTaskException(object state); // 0x0000000181AC9730-0x0000000181AC9800
	}
}
