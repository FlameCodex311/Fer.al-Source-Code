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
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class JContainer : JToken, IList<JToken>, ITypedList, IBindingList // TypeDefIndex: 7971
	{
		// Fields
		internal ListChangedEventHandler _listChanged; // 0x30
		internal AddingNewEventHandler _addingNew; // 0x38
		private object _syncRoot; // 0x40
		private bool _busy; // 0x48
	
		// Properties
		protected abstract IList<JToken> ChildrenTokens { get; }
		public override bool HasValues { get; } // 0x00000001809521F0-0x0000000180952250 
		public override JToken First { get; } // 0x0000000180952170-0x00000001809521F0 
		public override JToken Last { get; } // 0x0000000180952250-0x00000001809522D0 
		JToken IList<Newtonsoft.Json.Linq.JToken>.this[int index] { get => default; set {} } // 0x000000018094E8D0-0x000000018094E8F0 0x000000018094E8F0-0x000000018094E910
		bool ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
		bool IList.IsFixedSize { get; } // 0x00000001803C28F0-0x00000001803C2900 
		bool IList.IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
		object IList.this[int index] { get => default; set {} } // 0x000000018094E8D0-0x000000018094E8F0 0x0000000180951890-0x00000001809518D0
		public int Count { get; } // 0x0000000180952110-0x0000000180952170 
		bool ICollection.IsSynchronized { get; } // 0x00000001803C28F0-0x00000001803C2900 
		object ICollection.SyncRoot { get; } // 0x00000001809516C0-0x0000000180951730 
		bool IBindingList.AllowEdit { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		bool IBindingList.AllowNew { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		bool IBindingList.AllowRemove { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		bool IBindingList.IsSorted { get; } // 0x00000001803C28F0-0x00000001803C2900 
		ListSortDirection IBindingList.SortDirection { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		PropertyDescriptor IBindingList.SortProperty { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		bool IBindingList.SupportsChangeNotification { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		bool IBindingList.SupportsSearching { get; } // 0x00000001803C28F0-0x00000001803C2900 
		bool IBindingList.SupportsSorting { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Events
		public event ListChangedEventHandler ListChanged {
			add; // 0x0000000180952090-0x0000000180952110
			remove; // 0x00000001809522D0-0x0000000180952350
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GetDescendants>d__29 // TypeDefIndex: 7972
		{
		}
	
		// Constructors
		internal JContainer(); // 0x0000000180951E30-0x0000000180951E90
		internal JContainer(JContainer other); // 0x0000000180951E90-0x0000000180952090
	
		// Methods
		internal void CheckReentrancy(); // 0x000000018094F6E0-0x000000018094F7A0
		protected virtual void OnAddingNew(AddingNewEventArgs e); // 0x0000000180950660-0x0000000180950680
		protected virtual void OnListChanged(ListChangedEventArgs e); // 0x0000000180950680-0x0000000180950720
		internal bool ContentsEqual(JContainer container); // 0x000000018094FA50-0x000000018094FBB0
		public override JEnumerable<JToken> Children(); // 0x000000018094F7A0-0x000000018094F800
		internal bool IsMultiContent(object content); // 0x00000001809504C0-0x0000000180950580
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck); // 0x00000001809500C0-0x0000000180950160
		internal abstract int IndexOfItem(JToken item);
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck); // 0x0000000180950280-0x00000001809504C0
		internal virtual void RemoveItemAt(int index); // 0x00000001809510F0-0x0000000180951350
		internal virtual bool RemoveItem(JToken item); // 0x0000000180951350-0x00000001809513A0
		internal virtual JToken GetItem(int index); // 0x0000000180950210-0x0000000180950280
		internal virtual void SetItem(int index, JToken item); // 0x00000001809513F0-0x00000001809516C0
		internal virtual void ClearItems(); // 0x000000018094F800-0x000000018094FA30
		internal virtual void ReplaceItem(JToken existing, JToken replacement); // 0x00000001809513A0-0x00000001809513F0
		internal virtual bool ContainsItem(JToken item); // 0x000000018094FA30-0x000000018094FA50
		internal virtual void CopyItemsTo(Array array, int arrayIndex); // 0x000000018094FD80-0x0000000180950010
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue); // 0x0000000180950580-0x0000000180950660
		internal virtual void ValidateToken(JToken o, JToken existing); // 0x0000000180951D10-0x0000000180951E30
		public virtual void Add(object content); // 0x000000018094F660-0x000000018094F6E0
		internal void AddAndSkipParentCheck(JToken token); // 0x000000018094F2C0-0x000000018094F340
		internal void AddInternal(int index, object content, bool skipParentCheck); // 0x000000018094F340-0x000000018094F660
		internal static JToken CreateFromContent(object content); // 0x0000000180950010-0x00000001809500C0
		public void RemoveAll(); // 0x000000018094E040-0x000000018094E060
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options); // 0x0000000180950F30-0x00000001809510F0
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings); // 0x0000000180950720-0x0000000180950F30
		internal int ContentsHashCode(); // 0x000000018094FBB0-0x000000018094FD80
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors); // 0x0000000180951CD0-0x0000000180951D10
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors); // 0x0000000180951BF0-0x0000000180951CD0
		int IList<JToken>.IndexOf(JToken item); // 0x000000018094E3B0-0x000000018094E3D0
		void IList<JToken>.Insert(int index, JToken item); // 0x000000018094E3D0-0x000000018094E400
		void IList<JToken>.RemoveAt(int index); // 0x000000018094E5B0-0x000000018094E5D0
		void ICollection<JToken>.Add(JToken item); // 0x000000018094E020-0x000000018094E040
		void ICollection<JToken>.Clear(); // 0x000000018094E040-0x000000018094E060
		bool ICollection<JToken>.Contains(JToken item); // 0x00000001805B7260-0x00000001805B7280
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex); // 0x000000018094E100-0x000000018094E120
		bool ICollection<JToken>.Remove(JToken item); // 0x000000018094E5D0-0x000000018094E5F0
		private JToken EnsureValue(object value); // 0x0000000180950160-0x0000000180950210
		int IList.Add(object value); // 0x0000000180951730-0x00000001809517B0
		void IList.Clear(); // 0x000000018094E040-0x000000018094E060
		bool IList.Contains(object value); // 0x00000001809517B0-0x00000001809517E0
		int IList.IndexOf(object value); // 0x00000001809517E0-0x0000000180951810
		void IList.Insert(int index, object value); // 0x0000000180951810-0x0000000180951860
		void IList.Remove(object value); // 0x0000000180951860-0x0000000180951890
		void IList.RemoveAt(int index); // 0x000000018094E5B0-0x000000018094E5D0
		void ICollection.CopyTo(Array array, int index); // 0x000000018094E100-0x000000018094E120
		void IBindingList.AddIndex(PropertyDescriptor property); // 0x00000001803581E0-0x00000001803581F0
		object IBindingList.AddNew(); // 0x00000001809518D0-0x0000000180951B00
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction); // 0x0000000180951B00-0x0000000180951B50
		int IBindingList.Find(PropertyDescriptor property, object key); // 0x0000000180951B50-0x0000000180951BA0
		void IBindingList.RemoveIndex(PropertyDescriptor property); // 0x00000001803581E0-0x00000001803581F0
		void IBindingList.RemoveSort(); // 0x0000000180951BA0-0x0000000180951BF0
	}
}
