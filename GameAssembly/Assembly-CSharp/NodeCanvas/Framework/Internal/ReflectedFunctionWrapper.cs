/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	public abstract class ReflectedFunctionWrapper : ReflectedWrapper // TypeDefIndex: 15779
	{
		// Constructors
		protected ReflectedFunctionWrapper(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static new ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb); // 0x0000000180CCE190-0x0000000180CCE720
		public abstract object Call();
	}
}
