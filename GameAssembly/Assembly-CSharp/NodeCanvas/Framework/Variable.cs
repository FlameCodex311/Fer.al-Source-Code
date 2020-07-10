/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class Variable // TypeDefIndex: 14608
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _name; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _id; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _protected; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<string> onNameChanged; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<string, object> onValueChanged; // 0x30
	
		// Properties
		public string name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x0000000181761F40-0x0000000181761FB0
		public string ID { get; } // 0x0000000181761D70-0x0000000181761E00 
		public object value { get; set; } // 0x0000000180B2D770-0x0000000180B2D790 0x0000000180DDBD70-0x0000000180DDBD90
		public bool isProtected { get; set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
		protected abstract object objectValue { get; set; }
		public abstract Type varType { get; }
		public abstract bool hasBinding { get; }
		public abstract string propertyPath { get; set; }
	
		// Events
		public event Action<string> onNameChanged {
			add; // 0x0000000181761C30-0x0000000181761CD0
			remove; // 0x0000000181761E00-0x0000000181761EA0
		}
		public event Action<string, object> onValueChanged {
			add; // 0x0000000181761CD0-0x0000000181761D70
			remove; // 0x0000000181761EA0-0x0000000181761F40
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass37_0 // TypeDefIndex: 14609
		{
			// Fields
			public Variable <>4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public <>c__DisplayClass37_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <GetGetConverter>b__0(); // 0x0000000181760F70-0x0000000181760FA0
			internal object <GetGetConverter>b__1(); // 0x0000000181760FA0-0x0000000181761020
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 14610
		{
			// Fields
			public Variable <>4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public <>c__DisplayClass39_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <GetSetConverter>b__0(object x); // 0x0000000181761020-0x0000000181761050
			internal void <GetSetConverter>b__1(object x); // 0x0000000181761050-0x00000001817610E0
		}
	
		// Constructors
		public Variable(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		protected bool HasValueChangeEvent(); // 0x00000001807705D0-0x00000001807705E0
		protected void OnValueChanged(string name, object value); // 0x0000000181761BD0-0x0000000181761C30
		public abstract void BindProperty(MemberInfo prop, GameObject target = null);
		public abstract void UnBindProperty();
		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x00784642 */);
		public bool CanConvertTo(Type toType); // 0x0000000181761800-0x0000000181761930
		public Func<object> GetGetConverter(Type toType); // 0x0000000181761930-0x0000000181761A80
		public bool CanConvertFrom(Type fromType); // 0x00000001817616D0-0x0000000181761800
		public Action<object> GetSetConverter(Type fromType); // 0x0000000181761A80-0x0000000181761BD0
		public override string ToString(); // 0x000000018036AC80-0x000000018036AC90
	}
}
