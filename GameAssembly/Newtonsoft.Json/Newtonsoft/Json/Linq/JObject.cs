/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180257B50-0x0000000180257B90
	public class JObject : JContainer, IDictionary<string, JToken>, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 8140
	{
		// Fields
		private readonly JPropertyKeyedCollection _properties; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PropertyChangedEventHandler PropertyChanged; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PropertyChangingEventHandler PropertyChanging; // 0x60
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x0000000180378320-0x0000000180378330 
		public override JTokenType Type { get; } // 0x000000018058C710-0x000000018058C720 
		public JToken this[string propertyName] { get => default; set {} } // 0x000000018183A3D0-0x000000018183A450 0x000000018183A4F0-0x000000018183A620
		ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; } // 0x0000000181839870-0x00000001818398D0 
		ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; } // 0x00000001818398D0-0x0000000181839920 
		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Events
		public event PropertyChangedEventHandler PropertyChanged {
			add; // 0x000000018183A330-0x000000018183A3D0
			remove; // 0x000000018183A450-0x000000018183A4F0
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8141
		{
			// Fields
			public static readonly <>c <>9; // 0x00
	
			// Constructors
			static <>c(); // 0x0000000181851530-0x0000000181851590
			public <>c(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>> // TypeDefIndex: 8142
		{
			// Fields
			private int <>1__state; // 0x10
			private KeyValuePair<string, JToken> <>2__current; // 0x18
			public JObject <>4__this; // 0x28
			private IEnumerator<JToken> <>7__wrap1; // 0x30
	
			// Properties
			KeyValuePair<string, JToken> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001806DCE20-0x00000001806DCE30 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001818513E0-0x0000000181851430 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GetEnumerator>d__58(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000181851430-0x00000001818514E0
			private bool MoveNext(); // 0x0000000181851190-0x0000000181851390
			private void <>m__Finally1(); // 0x00000001818514E0-0x0000000181851530
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181851390-0x00000001818513E0
		}
	
		// Constructors
		public JObject(); // 0x000000018183A250-0x000000018183A330
		public JObject(JObject other); // 0x000000018183A190-0x000000018183A250
	
		// Methods
		internal override bool DeepEquals(JToken node); // 0x0000000181838AC0-0x0000000181838B70
		internal override int IndexOfItem(JToken item); // 0x0000000181838BD0-0x0000000181838C80
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x0000000181838C80-0x0000000181838CF0
		internal override void ValidateToken(JToken o, JToken existing); // 0x0000000181839DC0-0x000000018183A080
		internal void InternalPropertyChanged(JProperty childProperty); // 0x0000000181838CF0-0x0000000181838DB0
		internal void InternalPropertyChanging(JProperty childProperty); // 0x0000000181838DB0-0x0000000181838DE0
		internal override JToken CloneToken(); // 0x00000001818389E0-0x0000000181838AC0
		public JProperty Property(string name); // 0x00000001818390D0-0x00000001818391E0
		public static JObject Load(JsonReader reader); // 0x0000000181838FA0-0x0000000181838FB0
		public static JObject Load(JsonReader reader, JsonLoadSettings settings); // 0x0000000181838DE0-0x0000000181838FA0
		public override void WriteTo(JsonWriter writer, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ JsonConverter[] converters); // 0x000000018183A080-0x000000018183A190
		public void Add(string propertyName, JToken value); // 0x0000000181838950-0x00000001818389E0
		bool IDictionary<string, JToken>.ContainsKey(string key); // 0x00000001818397D0-0x0000000181839870
		public bool Remove(string propertyName); // 0x00000001818391E0-0x0000000181839270
		public bool TryGetValue(string propertyName, out JToken value); // 0x0000000181839D70-0x0000000181839DC0
		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item); // 0x0000000181839270-0x00000001818392F0
		void ICollection<KeyValuePair<string, JToken>>.Clear(); // 0x0000000181834710-0x0000000181834730
		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item); // 0x00000001818392F0-0x0000000181839360
		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex); // 0x0000000181839360-0x0000000181839670
		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item); // 0x0000000181839670-0x00000001818397D0
		internal override int GetDeepHashCode(); // 0x00000001818349B0-0x00000001818349C0
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator(); // 0x0000000181838B70-0x0000000181838BD0
		protected virtual void OnPropertyChanged(string propertyName); // 0x0000000181838FB0-0x0000000181839040
		protected virtual void OnPropertyChanging(string propertyName); // 0x0000000181839040-0x00000001818390D0
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(); // 0x0000000181839CC0-0x0000000181839D70
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes); // 0x0000000181839A90-0x0000000181839CC0
		AttributeCollection ICustomTypeDescriptor.GetAttributes(); // 0x0000000181839920-0x0000000181839980
		string ICustomTypeDescriptor.GetClassName(); // 0x000000018037DDC0-0x000000018037DDD0
		string ICustomTypeDescriptor.GetComponentName(); // 0x000000018037DDC0-0x000000018037DDD0
		TypeConverter ICustomTypeDescriptor.GetConverter(); // 0x0000000181839980-0x00000001818399D0
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent(); // 0x000000018037DDC0-0x000000018037DDD0
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty(); // 0x000000018037DDC0-0x000000018037DDD0
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType); // 0x000000018037DDC0-0x000000018037DDD0
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes); // 0x00000001818399D0-0x0000000181839A30
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(); // 0x0000000181839A30-0x0000000181839A90
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd); // 0x000000018037DDC0-0x000000018037DDD0
	}
}
