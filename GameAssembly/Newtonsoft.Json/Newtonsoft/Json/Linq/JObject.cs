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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180120400-0x0000000180120440
	public class JObject : JContainer, IDictionary<string, JToken>, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 7974
	{
		// Fields
		private readonly JPropertyKeyedCollection _properties; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PropertyChangedEventHandler PropertyChanged; // 0x58
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private PropertyChangingEventHandler PropertyChanging; // 0x60
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		public override JTokenType Type { get; } // 0x000000018042E670-0x000000018042E680 
		public JToken this[string propertyName] { get => default; set {} } // 0x0000000180953E10-0x0000000180953E90 0x0000000180953F30-0x0000000180954060
		ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; } // 0x0000000180953290-0x00000001809532F0 
		ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; } // 0x00000001809532F0-0x0000000180953340 
		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Events
		public event PropertyChangedEventHandler PropertyChanged {
			add; // 0x0000000180953D70-0x0000000180953E10
			remove; // 0x0000000180953E90-0x0000000180953F30
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7975
		{
			// Fields
			public static readonly <>c <>9; // 0x00
	
			// Constructors
			static <>c(); // 0x000000018096DE10-0x000000018096DE70
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>> // TypeDefIndex: 7976
		{
			// Fields
			private int <>1__state; // 0x10
			private KeyValuePair<string, JToken> <>2__current; // 0x18
			public JObject <>4__this; // 0x28
			private IEnumerator<JToken> <>7__wrap1; // 0x30
	
			// Properties
			KeyValuePair<string, JToken> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C2A00-0x00000001803C2A10 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018096DCC0-0x000000018096DD10 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <GetEnumerator>d__58(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x000000018096DD10-0x000000018096DDC0
			private bool MoveNext(); // 0x000000018096DA60-0x000000018096DC70
			private void <>m__Finally1(); // 0x000000018096DDC0-0x000000018096DE10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018096DC70-0x000000018096DCC0
		}
	
		// Constructors
		public JObject(); // 0x0000000180953C90-0x0000000180953D70
		public JObject(JObject other); // 0x0000000180953BD0-0x0000000180953C90
	
		// Methods
		internal override bool DeepEquals(JToken node); // 0x00000001809524C0-0x0000000180952570
		internal override int IndexOfItem(JToken item); // 0x00000001809525D0-0x0000000180952680
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x0000000180952680-0x00000001809526F0
		internal override void ValidateToken(JToken o, JToken existing); // 0x00000001809537E0-0x0000000180953AB0
		internal void InternalPropertyChanged(JProperty childProperty); // 0x00000001809526F0-0x00000001809527B0
		internal void InternalPropertyChanging(JProperty childProperty); // 0x00000001809527B0-0x00000001809527E0
		internal override JToken CloneToken(); // 0x00000001809523E0-0x00000001809524C0
		public JProperty Property(string name); // 0x0000000180952AE0-0x0000000180952BF0
		public static JObject Load(JsonReader reader); // 0x00000001809529B0-0x00000001809529C0
		public static JObject Load(JsonReader reader, JsonLoadSettings settings); // 0x00000001809527E0-0x00000001809529B0
		public override void WriteTo(JsonWriter writer, params /* 0x00000001800B36B0-0x00000001800B36C0 */ JsonConverter[] converters); // 0x0000000180953AB0-0x0000000180953BD0
		public void Add(string propertyName, JToken value); // 0x0000000180952350-0x00000001809523E0
		bool IDictionary<string, JToken>.ContainsKey(string key); // 0x00000001809531F0-0x0000000180953290
		public bool Remove(string propertyName); // 0x0000000180952BF0-0x0000000180952C80
		public bool TryGetValue(string propertyName, out JToken value); // 0x0000000180953790-0x00000001809537E0
		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item); // 0x0000000180952C80-0x0000000180952D00
		void ICollection<KeyValuePair<string, JToken>>.Clear(); // 0x000000018094E040-0x000000018094E060
		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item); // 0x0000000180952D00-0x0000000180952D70
		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex); // 0x0000000180952D70-0x0000000180953090
		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item); // 0x0000000180953090-0x00000001809531F0
		internal override int GetDeepHashCode(); // 0x000000018094E2F0-0x000000018094E300
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator(); // 0x0000000180952570-0x00000001809525D0
		protected virtual void OnPropertyChanged(string propertyName); // 0x00000001809529C0-0x0000000180952A50
		protected virtual void OnPropertyChanging(string propertyName); // 0x0000000180952A50-0x0000000180952AE0
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(); // 0x00000001809536E0-0x0000000180953790
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes); // 0x00000001809534B0-0x00000001809536E0
		AttributeCollection ICustomTypeDescriptor.GetAttributes(); // 0x0000000180953340-0x00000001809533A0
		string ICustomTypeDescriptor.GetClassName(); // 0x000000018035FCC0-0x000000018035FCD0
		string ICustomTypeDescriptor.GetComponentName(); // 0x000000018035FCC0-0x000000018035FCD0
		TypeConverter ICustomTypeDescriptor.GetConverter(); // 0x00000001809533A0-0x00000001809533F0
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent(); // 0x000000018035FCC0-0x000000018035FCD0
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty(); // 0x000000018035FCC0-0x000000018035FCD0
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType); // 0x000000018035FCC0-0x000000018035FCD0
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes); // 0x00000001809533F0-0x0000000180953450
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(); // 0x0000000180953450-0x00000001809534B0
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd); // 0x000000018035FCC0-0x000000018035FCD0
	}
}
