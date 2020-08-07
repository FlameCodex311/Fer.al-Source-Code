/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public interface IInvokable : IGraphElement // TypeDefIndex: 15699
	{
		// Methods
		string GetInvocationID();
		object Invoke(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args);
		void InvokeAsync(Action<object> callback, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args);
	}
}
