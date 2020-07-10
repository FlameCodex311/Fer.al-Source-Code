/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[Serializable]
	public class BBParameter<T> : BBParameter // TypeDefIndex: 14601
	{
		// Fields
		private Func<T> getter;
		private Action<T> setter;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected T _value;
	
		// Properties
		public new T value { get; set; }
		protected override object objectValue { get; set; }
		public override Type varType { get; }
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 14602
		{
			// Fields
			public Func<object> convertFunc;
	
			// Constructors
			public <>c__DisplayClass14_0();
	
			// Methods
			internal T <BindGetter>b__0();
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 14603
		{
			// Fields
			public Action<object> convertFunc;
			public Variable variable;
			public BBParameter<T> <>4__this;
	
			// Constructors
			public <>c__DisplayClass15_0();
	
			// Methods
			internal void <BindSetter>b__0(T value);
			internal void <BindSetter>b__1(T value);
		}
	
		// Constructors
		public BBParameter();
		public BBParameter(T value);
	
		// Methods
		protected override void Bind(Variable variable);
		private bool BindGetter(Variable variable);
		private bool BindSetter(Variable variable);
		public static implicit operator BBParameter<T>(T value);
	}
}
