/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class SafeFunc<T, TResult> : SafeDelegate<Func<T, TResult>> // TypeDefIndex: 7030
	{
		// Fields
		private T TlDguKccNAoLJIGHCRDccVerjIaM;
		private TResult GzQCfFvbKgfaLkhUNswDRjHQSqD;
		private static Action<object, Func<T, TResult>> JCphBFhoPEtHfyRCzKJoRxrLskc;
	
		// Properties
		private static Action<object, Func<T, TResult>> invokeDelegate { get; }
	
		// Constructors
		public SafeFunc();
		public SafeFunc(Action<Exception> exceptionHandler);
		protected SafeFunc(SafeFunc<T, TResult> source);
	
		// Methods
		public TResult Invoke(T arg0);
		public override object Clone();
		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object param_0000f0f6, Func<T, TResult> param_0000f0f7);
		public static SafeFunc<T, TResult> operator +(SafeFunc<T, TResult> eventList, Func<T, TResult> func);
		public static SafeFunc<T, TResult> operator -(SafeFunc<T, TResult> eventList, Func<T, TResult> func);
		public static implicit operator Func<T, TResult>(SafeFunc<T, TResult> obj);
		public static implicit operator SafeFunc<T, TResult>(Func<T, TResult> obj);
	}
}
