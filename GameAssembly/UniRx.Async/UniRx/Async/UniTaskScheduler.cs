/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class UniTaskScheduler // TypeDefIndex: 8619
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Exception> UnobservedTaskException; // 0x00
		public static bool PropagateOperationCanceledException; // 0x08
		public static LogType UnobservedExceptionWriteLogType; // 0x0C
		public static bool DispatchUnityMainThread; // 0x10
		private static readonly SendOrPostCallback handleExceptionInvoke; // 0x18
	
		// Events
		public static event Action<Exception> UnobservedTaskException {
			add; // 0x00000001820E32F0-0x00000001820E33E0
			remove; // 0x00000001820E33E0-0x00000001820E34D0
		}
	
		// Constructors
		static UniTaskScheduler(); // 0x00000001820E3250-0x00000001820E32F0
	
		// Methods
		internal static void PublishUnobservedTaskException(Exception ex); // 0x00000001820E2EC0-0x00000001820E3250
		private static void InvokeUnobservedTaskException(object state); // 0x00000001820E2DF0-0x00000001820E2EC0
	}
}
