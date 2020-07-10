/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	public abstract class ReflectedActionWrapper : ReflectedWrapper // TypeDefIndex: 14651
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14652
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, Type> <>9__0_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001817613A0-0x0000000181761400
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Type <Create>b__0_0(ParameterInfo p); // 0x0000000180DF2B50-0x0000000180DF2B80
		}
	
		// Constructors
		protected ReflectedActionWrapper(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static new ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018175D160-0x000000018175D620
		public abstract void Call();
	}
}
