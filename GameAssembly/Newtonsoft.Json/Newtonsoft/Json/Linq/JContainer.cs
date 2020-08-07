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
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class JContainer : JToken, IList<JToken>, ITypedList, IBindingList // TypeDefIndex: 8137
	{
		// Fields
		internal ListChangedEventHandler _listChanged; // 0x30
		internal AddingNewEventHandler _addingNew; // 0x38
		private object _syncRoot; // 0x40
		private bool _busy; // 0x48
	
		// Properties
		protected abstract IList<JToken> ChildrenTokens { get; }
		public override bool HasValues { get; } // 0x00000001818387F0-0x0000000181838850 
		public override JToken First { get; } // 0x0000000181838770-0x00000001818387F0 
		public override JToken Last { get; } // 0x0000000181838850-0x00000001818388D0 
		JToken IList<Newtonsoft.Json.Linq.JToken>.this[int index] { get => default; set {} } // 0x0000000181834F90-0x0000000181834FB0 0x0000000181834FB0-0x0000000181834FD0
		bool ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; } // 0x0000000180380950-0x0000000180380960 
		bool IList.IsFixedSize { get; } // 0x0000000180380950-0x0000000180380960 
		bool IList.IsReadOnly { get; } // 0x0000000180380950-0x0000000180380960 
		object IList.this[int index] { get => default; set {} } // 0x0000000181834F90-0x0000000181834FB0 0x0000000181837EB0-0x0000000181837EF0
		public int Count { get; } // 0x0000000181838710-0x0000000181838770 
		bool ICollection.IsSynchronized { get; } // 0x0000000180380950-0x0000000180380960 
		object ICollection.SyncRoot { get; } // 0x0000000181837CE0-0x0000000181837D50 
		bool IBindingList.AllowEdit { get; } // 0x0000000180380B60-0x0000000180380B70 
		bool IBindingList.AllowNew { get; } // 0x0000000180380B60-0x0000000180380B70 
		bool IBindingList.AllowRemove { get; } // 0x0000000180380B60-0x0000000180380B70 
		bool IBindingList.IsSorted { get; } // 0x0000000180380950-0x0000000180380960 
		ListSortDirection IBindingList.SortDirection { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		PropertyDescriptor IBindingList.SortProperty { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		bool IBindingList.SupportsChangeNotification { get; } // 0x0000000180380B60-0x0000000180380B70 
		bool IBindingList.SupportsSearching { get; } // 0x0000000180380950-0x0000000180380960 
		bool IBindingList.SupportsSorting { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Events
		public event ListChangedEventHandler ListChanged {
			add; // 0x0000000181838690-0x0000000181838710
			remove; // 0x00000001818388D0-0x0000000181838950
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetDescendants>d__29 // TypeDefIndex: 8138
		{
		}
	
		// Constructors
		internal JContainer(); // 0x0000000181838440-0x00000001818384A0
		internal JContainer(JContainer other); // 0x00000001818384A0-0x0000000181838690
	
		// Methods
		internal void CheckReentrancy(); // 0x0000000181835D70-0x0000000181835E20
		protected virtual void OnAddingNew(AddingNewEventArgs e); // 0x00000001815A52F0-0x00000001815A5310
		protected virtual void OnListChanged(ListChangedEventArgs e); // 0x0000000181836CA0-0x0000000181836D40
		internal bool ContentsEqual(JContainer container); // 0x00000001818360C0-0x0000000181836220
		public override JEnumerable<JToken> Children(); // 0x0000000181835E20-0x0000000181835E80
		internal bool IsMultiContent(object content); // 0x0000000181836B00-0x0000000181836BC0
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck); // 0x0000000181836700-0x00000001818367A0
		internal abstract int IndexOfItem(JToken item);
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck); // 0x00000001818368C0-0x0000000181836B00
		internal virtual void RemoveItemAt(int index); // 0x0000000181837710-0x0000000181837970
		internal virtual bool RemoveItem(JToken item); // 0x0000000181837970-0x00000001818379C0
		internal virtual JToken GetItem(int index); // 0x0000000181836850-0x00000001818368C0
		internal virtual void SetItem(int index, JToken item); // 0x0000000181837A10-0x0000000181837CE0
		internal virtual void ClearItems(); // 0x0000000181835E80-0x00000001818360A0
		internal virtual void ReplaceItem(JToken existing, JToken replacement); // 0x00000001818379C0-0x0000000181837A10
		internal virtual bool ContainsItem(JToken item); // 0x00000001818360A0-0x00000001818360C0
		internal virtual void CopyItemsTo(Array array, int arrayIndex); // 0x00000001818363E0-0x0000000181836650
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue); // 0x0000000181836BC0-0x0000000181836CA0
		internal virtual void ValidateToken(JToken o, JToken existing); // 0x0000000181838330-0x0000000181838440
		public virtual void Add(object content); // 0x0000000181835CF0-0x0000000181835D70
		internal void AddAndSkipParentCheck(JToken token); // 0x0000000181835950-0x00000001818359D0
		internal void AddInternal(int index, object content, bool skipParentCheck); // 0x00000001818359D0-0x0000000181835CF0
		internal static JToken CreateFromContent(object content); // 0x0000000181836650-0x0000000181836700
		public void RemoveAll(); // 0x0000000181834710-0x0000000181834730
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options); // 0x0000000181837560-0x0000000181837710
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings); // 0x0000000181836D40-0x0000000181837560
		internal int ContentsHashCode(); // 0x0000000181836220-0x00000001818363E0
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors); // 0x00000001818382F0-0x0000000181838330
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors); // 0x0000000181838210-0x00000001818382F0
		int IList<JToken>.IndexOf(JToken item); // 0x0000000181834A70-0x0000000181834A90
		void IList<JToken>.Insert(int index, JToken item); // 0x0000000181834A90-0x0000000181834AC0
		void IList<JToken>.RemoveAt(int index); // 0x0000000181834C70-0x0000000181834C90
		void ICollection<JToken>.Add(JToken item); // 0x00000001818346F0-0x0000000181834710
		void ICollection<JToken>.Clear(); // 0x0000000181834710-0x0000000181834730
		bool ICollection<JToken>.Contains(JToken item); // 0x0000000180CA1430-0x0000000180CA1450
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex); // 0x00000001818347D0-0x00000001818347F0
		bool ICollection<JToken>.Remove(JToken item); // 0x0000000181834C90-0x0000000181834CB0
		private JToken EnsureValue(object value); // 0x00000001818367A0-0x0000000181836850
		int IList.Add(object value); // 0x0000000181837D50-0x0000000181837DD0
		void IList.Clear(); // 0x0000000181834710-0x0000000181834730
		bool IList.Contains(object value); // 0x0000000181837DD0-0x0000000181837E00
		int IList.IndexOf(object value); // 0x0000000181837E00-0x0000000181837E30
		void IList.Insert(int index, object value); // 0x0000000181837E30-0x0000000181837E80
		void IList.Remove(object value); // 0x0000000181837E80-0x0000000181837EB0
		void IList.RemoveAt(int index); // 0x0000000181834C70-0x0000000181834C90
		void ICollection.CopyTo(Array array, int index); // 0x00000001818347D0-0x00000001818347F0
		void IBindingList.AddIndex(PropertyDescriptor property); // 0x00000001803774A0-0x00000001803774B0
		object IBindingList.AddNew(); // 0x0000000181837EF0-0x0000000181838120
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction); // 0x0000000181838120-0x0000000181838170
		int IBindingList.Find(PropertyDescriptor property, object key); // 0x0000000181838170-0x00000001818381C0
		void IBindingList.RemoveIndex(PropertyDescriptor property); // 0x00000001803774A0-0x00000001803774B0
		void IBindingList.RemoveSort(); // 0x00000001818381C0-0x0000000181838210
	}
}
