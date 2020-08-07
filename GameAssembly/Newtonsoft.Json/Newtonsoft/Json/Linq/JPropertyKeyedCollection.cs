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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180257B50-0x0000000180257B90
	internal class JPropertyKeyedCollection : Collection<Newtonsoft.Json.Linq.JToken> // TypeDefIndex: 8119
	{
		// Fields
		private static readonly IEqualityComparer<string> Comparer; // 0x00
		private Dictionary<string, JToken> _dictionary; // 0x20
	
		// Properties
		public ICollection<string> Keys { get; } // 0x000000018183B780-0x000000018183B7D0 
	
		// Constructors
		public JPropertyKeyedCollection(); // 0x000000018183B710-0x000000018183B780
		static JPropertyKeyedCollection(); // 0x000000018183B660-0x000000018183B710
	
		// Methods
		private void AddKey(string key, JToken item); // 0x000000018183AB10-0x000000018183AB80
		protected override void ClearItems(); // 0x000000018183AB80-0x000000018183ABE0
		public bool Contains(string key); // 0x000000018183AF60-0x000000018183AFF0
		private void EnsureDictionary(); // 0x000000018183AFF0-0x000000018183B090
		private string GetKeyForItem(JToken item); // 0x000000018183B090-0x000000018183B160
		protected override void InsertItem(int index, JToken item); // 0x000000018183B200-0x000000018183B2C0
		protected override void RemoveItem(int index); // 0x000000018183B2C0-0x000000018183B380
		private void RemoveKey(string key); // 0x000000018183B380-0x000000018183B3D0
		protected override void SetItem(int index, JToken item); // 0x000000018183B3D0-0x000000018183B5E0
		public bool TryGetValue(string key, out JToken value); // 0x000000018183B5E0-0x000000018183B660
		public int IndexOfReference(JToken t); // 0x000000018183B160-0x000000018183B200
		public bool Compare(JPropertyKeyedCollection other); // 0x000000018183ABE0-0x000000018183AF60
	}
}
