/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper // TypeDefIndex: 14633
	{
		// Fields
		private FunctionCall<T1, T2, T3, T4, TResult> call;
		public BBParameter<T1> p1;
		public BBParameter<T2> p2;
		public BBParameter<T3> p3;
		public BBParameter<T4> p4;
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<TResult> result;
	
		// Constructors
		public ReflectedFunction();
	
		// Methods
		public override BBParameter[] GetVariables();
		public override void Init(object instance);
		public override object Call();
	}
}
