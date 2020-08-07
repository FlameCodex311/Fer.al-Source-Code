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
	internal class SafePredicate<T> : SafeDelegate<Predicate<T>> // TypeDefIndex: 7031
	{
		// Fields
		private T TlDguKccNAoLJIGHCRDccVerjIaM;
		private bool GzQCfFvbKgfaLkhUNswDRjHQSqD;
		private static Action<object, Predicate<T>> JCphBFhoPEtHfyRCzKJoRxrLskc;
	
		// Properties
		private static Action<object, Predicate<T>> invokeDelegate { get; }
	
		// Constructors
		public SafePredicate();
		public SafePredicate(Action<Exception> exceptionHandler);
		protected SafePredicate(SafePredicate<T> source);
	
		// Methods
		public bool Invoke(T arg0);
		public override object Clone();
		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object param_0000f101, Predicate<T> param_0000f102);
		public static SafePredicate<T> operator +(SafePredicate<T> eventList, Predicate<T> predicate);
		public static SafePredicate<T> operator -(SafePredicate<T> eventList, Predicate<T> predicate);
		public static implicit operator Predicate<T>(SafePredicate<T> obj);
		public static implicit operator SafePredicate<T>(Predicate<T> obj);
	}
}
