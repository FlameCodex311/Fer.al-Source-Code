/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal static class Error // TypeDefIndex: 8861
	{
		// Methods
		public static void ThrowArgumentNullException<T>(T value, string paramName)
			where T : class;
		private static void ThrowArgumentNullExceptionCore(string paramName); // 0x0000000180E18B70-0x0000000180E18BD0
		public static void ThrowArgumentException<T>(string message);
		public static void ThrowNotYetCompleted(); // 0x0000000180E18C30-0x0000000180E18C90
		public static T ThrowNotYetCompleted<T>();
		public static void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField)
			where T : class;
		private static void ThrowInvalidOperationExceptionCore(string message); // 0x0000000180E18BD0-0x0000000180E18C30
		public static void ThrowOperationCanceledException(); // 0x0000000180E18C90-0x0000000180E18CE0
	}
}
