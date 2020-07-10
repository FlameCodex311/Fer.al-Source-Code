/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	internal static class Error // TypeDefIndex: 8695
	{
		// Methods
		public static void ThrowArgumentNullException<T>(T value, string paramName)
			where T : class;
		private static void ThrowArgumentNullExceptionCore(string paramName); // 0x000000018166BE20-0x000000018166BE80
		public static void ThrowArgumentException<T>(string message);
		public static void ThrowNotYetCompleted(); // 0x000000018166BEE0-0x000000018166BF40
		public static T ThrowNotYetCompleted<T>();
		public static void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField)
			where T : class;
		private static void ThrowInvalidOperationExceptionCore(string message); // 0x000000018166BE80-0x000000018166BEE0
		public static void ThrowOperationCanceledException(); // 0x000000018166BF40-0x000000018166BF90
	}
}
