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
	internal sealed class SafeAction : SafeDelegate<Action> // TypeDefIndex: 7027
	{
		// Fields
		private static Action<object, Action> JCphBFhoPEtHfyRCzKJoRxrLskc; // 0x00
	
		// Properties
		private static Action<object, Action> invokeDelegate { get; } // 0x0000000181461790-0x0000000181461810 
	
		// Constructors
		public SafeAction(); // 0x0000000181461750-0x0000000181461790
		public SafeAction(Action<Exception> exceptionHandler); // 0x00000001814616B0-0x0000000181461700
		private SafeAction(SafeAction source); // 0x0000000181461700-0x0000000181461750
	
		// Methods
		public void Invoke(); // 0x00000001814615C0-0x00000001814616B0
		public override object Clone(); // 0x0000000181461540-0x00000001814615C0
		private static void pcfqsYgjozxJrZkdUiPNFzfgLZdq(object param_0000f0d4, Action param_0000f0d5); // 0x0000000181461A20-0x0000000181461A40
		public static SafeAction operator +(SafeAction eventList, Action listener); // 0x0000000181461810-0x00000001814618D0
		public static SafeAction operator -(SafeAction eventList, Action listener); // 0x00000001814619C0-0x0000000181461A20
		public static implicit operator Action(SafeAction obj); // 0x0000000181461970-0x00000001814619C0
		public static implicit operator SafeAction(Action obj); // 0x00000001814618D0-0x0000000181461970
	}
}
