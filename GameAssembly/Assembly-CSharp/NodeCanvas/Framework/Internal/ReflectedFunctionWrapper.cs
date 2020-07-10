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
	public abstract class ReflectedFunctionWrapper : ReflectedWrapper // TypeDefIndex: 14653
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14654
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ParameterInfo, Type> <>9__0_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181761520-0x0000000181761580
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Type <Create>b__0_0(ParameterInfo p); // 0x0000000180DF2B50-0x0000000180DF2B80
		}
	
		// Constructors
		protected ReflectedFunctionWrapper(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static new ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018175D710-0x000000018175DC20
		public abstract object Call();
	}
}
