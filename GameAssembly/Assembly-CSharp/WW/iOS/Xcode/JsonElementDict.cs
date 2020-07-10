/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	internal class JsonElementDict : JsonElement // TypeDefIndex: 15747
	{
		// Fields
		private SortedDictionary<string, JsonElement> m_PrivateValue; // 0x10
	
		// Properties
		public IDictionary<string, JsonElement> values { get; } // 0x000000018036AC80-0x000000018036AC90 
		public new JsonElement this[string key] { get => default; set {} } // 0x00000001816793D0-0x00000001816794D0 0x00000001816794D0-0x0000000181679540
	
		// Constructors
		public JsonElementDict(); // 0x0000000181679370-0x00000001816793D0
	
		// Methods
		public bool Contains(string key); // 0x0000000181678F30-0x0000000181678F90
		public void Remove(string key); // 0x0000000181679130-0x0000000181679190
		public void SetInteger(string key, int val); // 0x0000000181679230-0x00000001816792D0
		public void SetString(string key, string val); // 0x00000001816792D0-0x0000000181679370
		public void SetBoolean(string key, bool val); // 0x0000000181679190-0x0000000181679230
		public JsonElementArray CreateArray(string key); // 0x0000000181678F90-0x0000000181679060
		public JsonElementDict CreateDict(string key); // 0x0000000181679060-0x0000000181679130
	}
}
