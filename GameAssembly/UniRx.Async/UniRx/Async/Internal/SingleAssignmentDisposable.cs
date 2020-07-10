/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	internal sealed class SingleAssignmentDisposable : IDisposable // TypeDefIndex: 8728
	{
		// Fields
		private readonly object gate; // 0x10
		private IDisposable current; // 0x18
		private bool disposed; // 0x20
	
		// Properties
		public bool IsDisposed { get; } // 0x000000018166F260-0x000000018166F330 
		public IDisposable Disposable { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018166F330-0x000000018166F4C0
	
		// Constructors
		public SingleAssignmentDisposable(); // 0x000000018166F200-0x000000018166F260
	
		// Methods
		public void Dispose(); // 0x000000018166F100-0x000000018166F200
	}
}
