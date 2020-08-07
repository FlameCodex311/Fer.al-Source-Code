/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	internal abstract class SafeDelegate<T> : SafeDelegate // TypeDefIndex: 7025
		where T : class
	{
		// Fields
		private Action<Exception> rpMwVctogLElzcidCcosEDQHfPtL;
		private readonly List<ioVfZdavojDzSzqHhsqubIvYMDVd> JgWxgQVSTfegkMMvfrWLmelxDQJi;
		private readonly List<ioVfZdavojDzSzqHhsqubIvYMDVd> CONBvmvrjMrLfnROHJCzYlyyvBN;
	
		// Properties
		internal override int Count { get; }
		internal override Action<Exception> ExceptionHandler { get; set; }
	
		// Nested types
		private class ioVfZdavojDzSzqHhsqubIvYMDVd // TypeDefIndex: 7026
		{
			// Fields
			public readonly T HEAxMKleMyFbOQutibQnIcEzBoA;
			public readonly object xPZdhDiOAODYIzoOlCwTEHEonFp;
			public readonly object lIOBGjICXrwWyjfSYSCCGUMMrLck;
			public readonly bool mMSsivqaeuVDUshNhCOYGLVQNPB;
	
			// Constructors
			public ioVfZdavojDzSzqHhsqubIvYMDVd(T item);
			public ioVfZdavojDzSzqHhsqubIvYMDVd(ioVfZdavojDzSzqHhsqubIvYMDVd<T> source);
	
			// Methods
			public bool qAHdZZcQxZdBjKbxrpHfialqsGdm();
		}
	
		// Constructors
		protected SafeDelegate();
		protected SafeDelegate(Action<Exception> exceptionHandler);
		protected SafeDelegate(SafeDelegate<T> source);
	
		// Methods
		public void AddDelegate(T @delegate);
		public void RemoveDelegate(T @delegate);
		internal override void RemoveDelegateOrAllDelegatesFromAnObject(object obj);
		internal override void Clear();
		protected void Invoke(Action<object, T> invokeCallback);
		protected T GetCombinedDelegate();
		private bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(T param_0000f0c8);
		private int ItDzbHMiIYGseDXjmhIUEkIaQew(T param_0000f0c9);
		private static Delegate pjSEfrAYzkjyadtCHwQBeiGuJphx(object param_0000f0ca, Delegate param_0000f0cb);
		private static Delegate pjSEfrAYzkjyadtCHwQBeiGuJphx(Delegate param_0000f0cc, Delegate param_0000f0cd);
		private static int hEybybeLnBgNQNCYsXAEbTIQLtMh(Delegate param_0000f0ce);
		private static List<Delegate> pHGHHQkphXaGwILuHyerCtjXIel(Delegate param_0000f0cf);
	}
}
