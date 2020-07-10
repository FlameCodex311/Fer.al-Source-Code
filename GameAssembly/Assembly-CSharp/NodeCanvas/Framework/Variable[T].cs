/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[Serializable]
	public class Variable<T> : Variable // TypeDefIndex: 14611
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private T _value;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _propertyPath;
		private Func<T> getter;
		private Action<T> setter;
	
		// Properties
		public override string propertyPath { get; set; }
		public override bool hasBinding { get; }
		protected override object objectValue { get; set; }
		public override Type varType { get; }
		public new T value { get; set; }
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 14612
		{
			// Fields
			public Variable<T> <>4__this;
			public GameObject go;
			public FieldInfo field;
	
			// Constructors
			public <>c__DisplayClass22_0();
	
			// Methods
			internal T <InitializePropertyBinding>b__1();
			internal void <InitializePropertyBinding>b__3(T o);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass22_1 // TypeDefIndex: 14613
		{
			// Fields
			public MethodInfo getMethod;
			public Component instance;
			public MethodInfo setMethod;
	
			// Constructors
			public <>c__DisplayClass22_1();
	
			// Methods
			internal T <InitializePropertyBinding>b__0();
			internal void <InitializePropertyBinding>b__2(T o);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass22_2 // TypeDefIndex: 14614
		{
			// Fields
			public Component instance;
			public <>c__DisplayClass22_0<T> CS$<>8__locals1;
	
			// Constructors
			public <>c__DisplayClass22_2();
	
			// Methods
			internal T <InitializePropertyBinding>b__4();
			internal void <InitializePropertyBinding>b__5(T o);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass22_3 // TypeDefIndex: 14615
		{
			// Fields
			public T value;
	
			// Constructors
			public <>c__DisplayClass22_3();
	
			// Methods
			internal T <InitializePropertyBinding>b__6();
		}
	
		// Constructors
		public Variable();
	
		// Methods
		public T GetValue();
		public void SetValue(T newValue);
		public override void BindProperty(MemberInfo prop, GameObject target = null);
		public override void UnBindProperty();
		public override void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x00784643 */);
	}
}
