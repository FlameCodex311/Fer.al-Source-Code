/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace LitJson
{
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 15409
	{
		// Fields
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator; // 0x10
	
		// Properties
		public object Current { get; } // 0x00000001811F0410-0x00000001811F0520 
		public DictionaryEntry Entry { get; } // 0x00000001811F0520-0x00000001811F0610 
		public object Key { get; } // 0x00000001811F0610-0x00000001811F06C0 
		public object Value { get; } // 0x00000001811F06C0-0x00000001811F0780 
	
		// Constructors
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		public bool MoveNext(); // 0x00000001811F0370-0x00000001811F03C0
		public void Reset(); // 0x00000001811F03C0-0x00000001811F0410
	}
}
