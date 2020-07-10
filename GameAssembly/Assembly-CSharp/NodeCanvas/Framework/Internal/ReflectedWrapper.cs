/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	public abstract class ReflectedWrapper // TypeDefIndex: 14636
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected SerializedMethodInfo _targetMethod; // 0x10
	
		// Nested types
		protected delegate void ActionCall(); // TypeDefIndex: 14637; 0x000000018038CED0-0x000000018038D0E0
	
		protected delegate void ActionCall<T1>(T1 a); // TypeDefIndex: 14638; 0x00000000-0x00000000
	
		protected delegate void ActionCall<T1, T2>(T1 a, T2 b); // TypeDefIndex: 14639; 0x00000000-0x00000000
	
		protected delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c); // TypeDefIndex: 14640; 0x00000000-0x00000000
	
		protected delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 14641; 0x00000000-0x00000000
	
		protected delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 14642; 0x00000000-0x00000000
	
		protected delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 14643; 0x00000000-0x00000000
	
		protected delegate TResult FunctionCall<TResult>(); // TypeDefIndex: 14644; 0x00000000-0x00000000
	
		protected delegate TResult FunctionCall<T1, TResult>(T1 a); // TypeDefIndex: 14645; 0x00000000-0x00000000
	
		protected delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b); // TypeDefIndex: 14646; 0x00000000-0x00000000
	
		protected delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c); // TypeDefIndex: 14647; 0x00000000-0x00000000
	
		protected delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d); // TypeDefIndex: 14648; 0x00000000-0x00000000
	
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e); // TypeDefIndex: 14649; 0x00000000-0x00000000
	
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f); // TypeDefIndex: 14650; 0x00000000-0x00000000
	
		// Constructors
		public ReflectedWrapper(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb); // 0x000000018175DC20-0x000000018175DD10
		public void SetVariablesBB(IBlackboard bb); // 0x000000018175DD60-0x000000018175DDF0
		public bool HasChanged(); // 0x000000018175DD40-0x000000018175DD60
		public MethodInfo GetMethod(); // 0x000000018175DD30-0x000000018175DD40
		public string GetMethodString(); // 0x000000018175DD10-0x000000018175DD30
		public abstract BBParameter[] GetVariables();
		public abstract void Init(object instance);
	}
}
