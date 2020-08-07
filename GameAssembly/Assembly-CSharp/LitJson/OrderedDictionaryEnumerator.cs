/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 16064
	{
		// Fields
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator; // 0x10
	
		// Properties
		public object Current { get; } // 0x0000000180C5A310-0x0000000180C5A420 
		public DictionaryEntry Entry { get; } // 0x0000000180C5A420-0x0000000180C5A510 
		public object Key { get; } // 0x0000000180C5A510-0x0000000180C5A5C0 
		public object Value { get; } // 0x0000000180C5A5C0-0x0000000180C5A680 
	
		// Constructors
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator); // 0x0000000180400150-0x0000000180400180
	
		// Methods
		public bool MoveNext(); // 0x0000000180C5A270-0x0000000180C5A2C0
		public void Reset(); // 0x0000000180C5A2C0-0x0000000180C5A310
	}
}
