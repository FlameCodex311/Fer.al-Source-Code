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
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal sealed class SafeAction<T> : SafeDelegate<Action<T>> // TypeDefIndex: 7028
	{
		// Fields
		private T TlDguKccNAoLJIGHCRDccVerjIaM;
		private static Action<object, Action<T>> JCphBFhoPEtHfyRCzKJoRxrLskc;
	
		// Properties
		private static Action<object, Action<T>> invokeDelegate { get; }
	
		// Constructors
		public SafeAction();
		public SafeAction(Action<Exception> exceptionHandler);
		protected SafeAction(SafeAction<T> source);
	
		// Methods
		public void Invoke(T arg0);
		public override object Clone();
		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object param_0000f0df, Action<T> param_0000f0e0);
		public static SafeAction<T> operator +(SafeAction<T> eventList, Action<T> listener);
		public static SafeAction<T> operator -(SafeAction<T> eventList, Action<T> listener);
		public static implicit operator Action<T>(SafeAction<T> obj);
		public static implicit operator SafeAction<T>(Action<T> obj);
	}
}
