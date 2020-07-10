/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180120400-0x0000000180120440
	internal class JPropertyKeyedCollection : Collection<Newtonsoft.Json.Linq.JToken> // TypeDefIndex: 7953
	{
		// Fields
		private static readonly IEqualityComparer<string> Comparer; // 0x00
		private Dictionary<string, JToken> _dictionary; // 0x20
	
		// Properties
		public ICollection<string> Keys { get; } // 0x0000000180955200-0x0000000180955250 
	
		// Constructors
		public JPropertyKeyedCollection(); // 0x0000000180955190-0x0000000180955200
		static JPropertyKeyedCollection(); // 0x00000001809550E0-0x0000000180955190
	
		// Methods
		private void AddKey(string key, JToken item); // 0x0000000180954560-0x00000001809545D0
		protected override void ClearItems(); // 0x00000001809545D0-0x0000000180954630
		public bool Contains(string key); // 0x00000001809549C0-0x0000000180954A60
		private void EnsureDictionary(); // 0x0000000180954A60-0x0000000180954B00
		private string GetKeyForItem(JToken item); // 0x0000000180954B00-0x0000000180954BD0
		protected override void InsertItem(int index, JToken item); // 0x0000000180954C70-0x0000000180954D30
		protected override void RemoveItem(int index); // 0x0000000180954D30-0x0000000180954DF0
		private void RemoveKey(string key); // 0x0000000180954DF0-0x0000000180954E40
		protected override void SetItem(int index, JToken item); // 0x0000000180954E40-0x0000000180955060
		public bool TryGetValue(string key, out JToken value); // 0x0000000180955060-0x00000001809550E0
		public int IndexOfReference(JToken t); // 0x0000000180954BD0-0x0000000180954C70
		public bool Compare(JPropertyKeyedCollection other); // 0x0000000180954630-0x00000001809549C0
	}
}
