/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal sealed class SingleAssignmentDisposable : IDisposable // TypeDefIndex: 8894
	{
		// Fields
		private readonly object gate; // 0x10
		private IDisposable current; // 0x18
		private bool disposed; // 0x20
	
		// Properties
		public bool IsDisposed { get; } // 0x0000000180E1BCE0-0x0000000180E1BDA0 
		public IDisposable Disposable { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180E1BDA0-0x0000000180E1BF20
	
		// Constructors
		public SingleAssignmentDisposable(); // 0x0000000180E1BC80-0x0000000180E1BCE0
	
		// Methods
		public void Dispose(); // 0x0000000180E1BB80-0x0000000180E1BC80
	}
}
