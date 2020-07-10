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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ActionCategoryMap // TypeDefIndex: 6041
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private List<Entry> list; // 0x10
	
		// Nested types
		[Serializable]
		public class Entry // TypeDefIndex: 6042
		{
			// Fields
			public int categoryId; // 0x10
			public List<int> actionIds; // 0x18
	
			// Properties
			public IEnumerable<int> ActionIds { get; } // 0x00000001805E9BE0-0x00000001805E9C60 
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class rDZyonyRKXduFbhzHyoaqyVNNbX : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 6043
			{
				// Fields
				private int aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
				private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x14
				private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x18
				public Entry gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
				public int fuSLQQxKYvdjYbulPnFSVxmgnRA; // 0x28
	
				// Properties
				int WSBEdAEEtGKxuQineQbAxjcuTLP { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
				object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001805F2830-0x00000001805F2880 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public rDZyonyRKXduFbhzHyoaqyVNNbX(int <>1__state); // 0x00000001803C0450-0x00000001803C04A0
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x00000001805F26F0-0x00000001805F27E0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F26F0-0x00000001805F27E0
				private bool MoveNext(); // 0x00000001805F25A0-0x00000001805F26F0
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001805F27E0-0x00000001805F2830
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			}
	
			// Constructors
			public Entry(); // 0x00000001805E9B80-0x00000001805E9BE0
			public Entry(int categoryId); // 0x00000001805E9A80-0x00000001805E9B10
			public Entry(Entry source); // 0x00000001805E9B10-0x00000001805E9B80
	
			// Methods
			public void AddAction(int actionId); // 0x00000001805E9470-0x00000001805E9500
			public bool InsertAction(int actionId, int index); // 0x00000001805E96B0-0x00000001805E97B0
			public bool ReorderAction(int actionId, bool offsetDown, bool offsetNow); // 0x00000001805E9820-0x00000001805E9A80
			public void RemoveAction(int actionId); // 0x00000001805E97B0-0x00000001805E9820
			public int IndexOfAction(int id); // 0x00000001805E95B0-0x00000001805E96B0
			public bool ContainsAction(int id); // 0x00000001805E9590-0x00000001805E95B0
			public Entry Clone(); // 0x00000001805E9500-0x00000001805E9590
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class ZECCsfyvaebqUZkpZsTIDeNKHuq : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 6044
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
			int WSBEdAEEtGKxuQineQbAxjcuTLP { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001805F1EB0-0x00000001805F1F00 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public ZECCsfyvaebqUZkpZsTIDeNKHuq(int <>1__state); // 0x00000001803C0450-0x00000001803C04A0
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x00000001805F1D60-0x00000001805F1E60
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001805F1D60-0x00000001805F1E60
			private bool MoveNext(); // 0x00000001805F19E0-0x00000001805F1D60
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001805F1E60-0x00000001805F1EB0
			void IDisposable.Dispose(); // 0x00000001805F1F00-0x00000001805F1F70
			private void ISxlGoNrohaTYGNdnYJULBjdBYA(); // 0x00000001805F18B0-0x00000001805F19E0
		}
	
		// Constructors
		public ActionCategoryMap(); // 0x00000001805D8410-0x00000001805D8470
		public ActionCategoryMap(ActionCategoryMap source); // 0x00000001805D8470-0x00000001805D8620
	
		// Methods
		public IEnumerable<int> ActionIdsInCategory(int categoryId); // 0x00000001805D7440-0x00000001805D74F0
		public void AddCategory(int id); // 0x00000001805D75A0-0x00000001805D7680
		public void RemoveCategory(int id); // 0x00000001805D8070-0x00000001805D8110
		public bool ReorderCategory(int id, bool offsetDown); // 0x00000001805D81D0-0x00000001805D8410
		public bool ChangeCategory(int actionId, int newCategoryId); // 0x00000001805D7680-0x00000001805D79E0
		public int IndexOfCategory(int id); // 0x00000001805D7CA0-0x00000001805D7DB0
		public bool AddAction(int categoryId, int actionId); // 0x00000001805D74F0-0x00000001805D75A0
		public bool InsertAction(int categoryId, int actionId, int index); // 0x00000001805D7DB0-0x00000001805D7F30
		public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow); // 0x00000001805D8110-0x00000001805D81D0
		public void RemoveAction(int categoryId, int actionId); // 0x00000001805D7F30-0x00000001805D8070
		public int IndexOfAction(int categoryId, int actionId); // 0x00000001805D7BC0-0x00000001805D7CA0
		public ActionCategoryMap Clone(); // 0x00000001805D79E0-0x00000001805D7BC0
	}
}
