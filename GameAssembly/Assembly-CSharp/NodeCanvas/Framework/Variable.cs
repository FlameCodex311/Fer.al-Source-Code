/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsUninitialized] // 0x00000001801CDDD0-0x00000001801CDE00
	[SpoofAOT] // 0x00000001801CDDD0-0x00000001801CDE00
	public abstract class Variable // TypeDefIndex: 15748
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _name; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _id; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _isPublic; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<string> onNameChanged; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<object> onValueChanged; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action onDestroy; // 0x38
	
		// Properties
		public string name { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180CD3430-0x0000000180CD34A0
		public string ID { get; } // 0x0000000180CD3130-0x0000000180CD31C0 
		public object value { get; set; } // 0x0000000180CD3230-0x0000000180CD3250 0x0000000180CD34A0-0x0000000180CD34C0
		public bool isExposedPublic { get; set; } // 0x0000000180CD31C0-0x0000000180CD3200 0x00000001803FA0B0-0x00000001803FA0C0
		public bool isPropertyBound { get; } // 0x0000000180CD3200-0x0000000180CD3230 
		public abstract bool isDataBound { get; }
		public abstract Type varType { get; }
		public abstract string propertyPath { get; set; }
	
		// Events
		public event Action<string> onNameChanged {
			add; // 0x0000000180CD2FF0-0x0000000180CD3090
			remove; // 0x0000000180CD32F0-0x0000000180CD3390
		}
		public event Action<object> onValueChanged {
			add; // 0x0000000180CD3090-0x0000000180CD3130
			remove; // 0x0000000180CD3390-0x0000000180CD3430
		}
		public event Action onDestroy {
			add; // 0x0000000180CD2F50-0x0000000180CD2FF0
			remove; // 0x0000000180CD3250-0x0000000180CD32F0
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass43_0 // TypeDefIndex: 15749
		{
			// Fields
			public Variable <>4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public <>c__DisplayClass43_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <GetGetConverter>b__0(); // 0x00000001808F60E0-0x00000001808F6110
			internal object <GetGetConverter>b__1(); // 0x0000000180CD2380-0x0000000180CD2400
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass45_0 // TypeDefIndex: 15750
		{
			// Fields
			public Variable <>4__this; // 0x10
			public Func<object, object> converter; // 0x18
	
			// Constructors
			public <>c__DisplayClass45_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <GetSetConverter>b__0(object x); // 0x0000000180CD2400-0x0000000180CD2430
			internal void <GetSetConverter>b__1(object x); // 0x0000000180CD2430-0x0000000180CD24C0
		}
	
		// Constructors
		public Variable(); // 0x0000000180CD2ED0-0x0000000180CD2F50
	
		// Methods
		public abstract void BindProperty(MemberInfo prop, GameObject target = null);
		public abstract void UnBind();
		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false /* Metadata: 0x007BB4CD */);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		internal void OnDestroy(); // 0x0000000180CD2E60-0x0000000180CD2E80
		public Variable Duplicate(IBlackboard targetBB); // 0x0000000180CD29E0-0x0000000180CD2BB0
		protected bool HasValueChangeEvent(); // 0x0000000180CD2E50-0x0000000180CD2E60
		protected void TryInvokeValueChangeEvent(object value); // 0x0000000180CD2E80-0x0000000180CD2ED0
		public bool CanConvertTo(Type toType); // 0x0000000180CD28B0-0x0000000180CD29E0
		public Func<object> GetGetConverter(Type toType); // 0x0000000180CD2BB0-0x0000000180CD2D00
		public bool CanConvertFrom(Type fromType); // 0x0000000180CD2780-0x0000000180CD28B0
		public Action<object> GetSetConverter(Type fromType); // 0x0000000180CD2D00-0x0000000180CD2E50
		public override string ToString(); // 0x0000000180372440-0x0000000180372450
	}
}
