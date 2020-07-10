/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	[SpoofAOT] // 0x00000001800B36B0-0x00000001800B36C0
	public class ReflectedFunction<TResult> : ReflectedFunctionWrapper // TypeDefIndex: 14629
	{
		// Fields
		private FunctionCall<TResult> call;
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
