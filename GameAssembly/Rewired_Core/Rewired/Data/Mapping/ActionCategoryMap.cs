/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ActionCategoryMap // TypeDefIndex: 6200
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private List<Entry> list; // 0x10
	
		// Nested types
		[Serializable]
		public class Entry // TypeDefIndex: 6201
		{
			// Fields
			public int categoryId; // 0x10
			public List<int> actionIds; // 0x18
	
			// Properties
			public IEnumerable<int> ActionIds { get; } // 0x0000000180D88CB0-0x0000000180D88D30 
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class rDZyonyRKXduFbhzHyoaqyVNNbX : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 6202
			{
				// Fields
				private int aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x14
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x18
				public Entry gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int fuSLQQxKYvdjYbulPnFSVxmgnRA; // 0x28
	
				// Properties
				int WSBEdAEEtGKxuQineQbAxjcuTLP { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180387590-0x0000000180387930 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180D91660-0x0000000180D916B0 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public rDZyonyRKXduFbhzHyoaqyVNNbX(int <>1__state); // 0x0000000180619870-0x00000001806198C0
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x0000000180D91520-0x0000000180D91610
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D91520-0x0000000180D91610
				private bool MoveNext(); // 0x0000000180D913D0-0x0000000180D91520
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180D91610-0x0000000180D91660
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			}
	
			// Constructors
			public Entry(); // 0x0000000180D88C50-0x0000000180D88CB0
			public Entry(int categoryId); // 0x0000000180D88B60-0x0000000180D88BF0
			public Entry(Entry source); // 0x0000000180D88BF0-0x0000000180D88C50
	
			// Methods
			public void AddAction(int actionId); // 0x0000000180D88550-0x0000000180D885E0
			public bool InsertAction(int actionId, int index); // 0x0000000180D88790-0x0000000180D88890
			public bool ReorderAction(int actionId, bool offsetDown, bool offsetNow); // 0x0000000180D88900-0x0000000180D88B60
			public void RemoveAction(int actionId); // 0x0000000180D88890-0x0000000180D88900
			public int IndexOfAction(int id); // 0x0000000180D88690-0x0000000180D88790
			public bool ContainsAction(int id); // 0x0000000180D88670-0x0000000180D88690
			public Entry Clone(); // 0x0000000180D885E0-0x0000000180D88670
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class ZECCsfyvaebqUZkpZsTIDeNKHuq : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 6203
		{
			// Fields
			private int aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x14
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x18
			public ActionCategoryMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int dowbRlGIIniWSeAGysskFGgBremp; // 0x28
			public int KsrdqTrgHEoQODZSdprvCFDgWBr; // 0x2C
			public int KzYBLieXlolrpndNQfPqgHJKZD; // 0x30
			public int zaECrrbHtrDoxsagyDUwDfiwtWye; // 0x34
			public IEnumerator<int> IFjqIuMXDNRyWIScPohuqJVYAOP; // 0x38
	
			// Properties
			int WSBEdAEEtGKxuQineQbAxjcuTLP { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180387590-0x0000000180387930 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180D90D10-0x0000000180D90D60 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public ZECCsfyvaebqUZkpZsTIDeNKHuq(int <>1__state); // 0x0000000180619870-0x00000001806198C0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x0000000180D90BC0-0x0000000180D90CC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D90BC0-0x0000000180D90CC0
			private bool MoveNext(); // 0x0000000180D90840-0x0000000180D90BC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180D90CC0-0x0000000180D90D10
			void IDisposable.Dispose(); // 0x0000000180D90D60-0x0000000180D90DD0
			private void ISxlGoNrohaTYGNdnYJULBjdBYA(); // 0x0000000180D90720-0x0000000180D90840
		}
	
		// Constructors
		public ActionCategoryMap(); // 0x0000000180D777A0-0x0000000180D77800
		public ActionCategoryMap(ActionCategoryMap source); // 0x0000000180D77800-0x0000000180D779A0
	
		// Methods
		public IEnumerable<int> ActionIdsInCategory(int categoryId); // 0x0000000180D76840-0x0000000180D768F0
		public void AddCategory(int id); // 0x0000000180D769A0-0x0000000180D76A80
		public void RemoveCategory(int id); // 0x0000000180D77410-0x0000000180D774B0
		public bool ReorderCategory(int id, bool offsetDown); // 0x0000000180D77570-0x0000000180D777A0
		public bool ChangeCategory(int actionId, int newCategoryId); // 0x0000000180D76A80-0x0000000180D76DD0
		public int IndexOfCategory(int id); // 0x0000000180D77070-0x0000000180D77170
		public bool AddAction(int categoryId, int actionId); // 0x0000000180D768F0-0x0000000180D769A0
		public bool InsertAction(int categoryId, int actionId, int index); // 0x0000000180D77170-0x0000000180D772D0
		public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow); // 0x0000000180D774B0-0x0000000180D77570
		public void RemoveAction(int categoryId, int actionId); // 0x0000000180D772D0-0x0000000180D77410
		public int IndexOfAction(int categoryId, int actionId); // 0x0000000180D76FA0-0x0000000180D77070
		public ActionCategoryMap Clone(); // 0x0000000180D76DD0-0x0000000180D76FA0
	}
}
