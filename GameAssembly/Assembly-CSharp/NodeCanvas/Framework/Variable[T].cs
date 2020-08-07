/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public class Variable<T> : Variable // TypeDefIndex: 15751
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T _value;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _propertyPath;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Func<T> getter;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<T> setter;
	
		// Properties
		public override Type varType { get; }
		public override bool isDataBound { get; }
		public override string propertyPath { get; set; }
		public new T value { get; set; }
	
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
		private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 15752
		{
			// Fields
			public FieldInfo field;
			public Component instance;
	
			// Constructors
			public <>c__DisplayClass26_0();
	
			// Methods
			internal T <InitializePropertyBinding>b__0();
			internal void <InitializePropertyBinding>b__1(T o);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass26_1 // TypeDefIndex: 15753
		{
			// Fields
			public T value;
	
			// Constructors
			public <>c__DisplayClass26_1();
	
			// Methods
			internal T <InitializePropertyBinding>b__2();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass26_2 // TypeDefIndex: 15754
		{
			// Fields
			public MethodInfo getMethod;
			public Component instance;
			public MethodInfo setMethod;
	
			// Constructors
			public <>c__DisplayClass26_2();
	
			// Methods
			internal T <InitializePropertyBinding>b__3();
			internal void <InitializePropertyBinding>b__5(T o);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15755
		{
			// Fields
			public static readonly <>c<T> <>9;
			public static Func<T> <>9__26_4;
			public static Action<T> <>9__26_6;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal T <InitializePropertyBinding>b__26_4();
			internal void <InitializePropertyBinding>b__26_6(T o);
		}
	
		// Constructors
		public Variable();
	
		// Methods
		public override object GetValueBoxed();
		public override void SetValueBoxed(object newValue);
		public T GetValue();
		public void SetValue(T newValue);
		public override void BindProperty(MemberInfo prop, GameObject target = null);
		public void BindGetSet(Func<T> _get, Action<T> _set);
		public override void UnBind();
		public override void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x007BB4CE */);
	}
}
