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
	internal sealed class SafeAction<T, T2> : SafeDelegate<Action<T, T2>> // TypeDefIndex: 7029
	{
		// Fields
		private T TlDguKccNAoLJIGHCRDccVerjIaM;
		private T2 oblUDRJNDgDPDYPcAEdpfehHggEH;
		private static Action<object, Action<T, T2>> JCphBFhoPEtHfyRCzKJoRxrLskc;
	
		// Properties
		private static Action<object, Action<T, T2>> invokeDelegate { get; }
	
		// Constructors
		public SafeAction();
		public SafeAction(Action<Exception> exceptionHandler);
		protected SafeAction(SafeAction<T, T2> source);
	
		// Methods
		public void Invoke(T arg0, T2 arg1);
		public override object Clone();
		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object param_0000f0eb, Action<T, T2> param_0000f0ec);
		public static SafeAction<T, T2> operator +(SafeAction<T, T2> eventList, Action<T, T2> listener);
		public static SafeAction<T, T2> operator -(SafeAction<T, T2> eventList, Action<T, T2> listener);
		public static implicit operator Action<T, T2>(SafeAction<T, T2> obj);
		public static implicit operator SafeAction<T, T2>(Action<T, T2> obj);
	}
}
