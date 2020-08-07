/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	public class BBParameter<T> : BBParameter // TypeDefIndex: 15736
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected T _value;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Func<T> getter;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<T> setter;
	
		// Properties
		public new T value { get; set; }
		public override Type varType { get; }
	
		// Events
		private event Func<T> getter {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		private event Action<T> setter {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 15737
		{
			// Fields
			public Func<object> convertFunc;
	
			// Constructors
			public <>c__DisplayClass20_0();
	
			// Methods
			internal T <BindGetter>b__0();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 15738
		{
			// Fields
			public Action<object> convertFunc;
	
			// Constructors
			public <>c__DisplayClass21_0();
	
			// Methods
			internal void <BindSetter>b__0(T value);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15739
		{
			// Fields
			public static readonly <>c<T> <>9;
			public static Action<T> <>9__21_1;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal void <BindSetter>b__21_1(T value);
		}
	
		// Constructors
		public BBParameter();
		public BBParameter(T value);
	
		// Methods
		public override object GetValueBoxed();
		public override void SetValueBoxed(object newValue);
		public T GetValue();
		public void SetValue(T value);
		protected override void SetDefaultValue();
		protected override void Bind(Variable variable);
		private bool BindGetter(Variable variable);
		private bool BindSetter(Variable variable);
		public static implicit operator BBParameter<T>(T value);
	}
}
