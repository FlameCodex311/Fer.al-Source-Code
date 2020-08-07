/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal class JsonElementDict : JsonElement // TypeDefIndex: 16127
	{
		// Fields
		private SortedDictionary<string, JsonElement> m_PrivateValue; // 0x10
	
		// Properties
		public IDictionary<string, JsonElement> values { get; } // 0x0000000180372440-0x0000000180372450 
		public new JsonElement this[string key] { get => default; set {} } // 0x0000000180973030-0x0000000180973120 0x0000000180973120-0x0000000180973190
	
		// Constructors
		public JsonElementDict(); // 0x0000000180972FD0-0x0000000180973030
	
		// Methods
		public bool Contains(string key); // 0x0000000180972B90-0x0000000180972BF0
		public void Remove(string key); // 0x0000000180972D90-0x0000000180972DF0
		public void SetInteger(string key, int val); // 0x0000000180972E90-0x0000000180972F30
		public void SetString(string key, string val); // 0x0000000180972F30-0x0000000180972FD0
		public void SetBoolean(string key, bool val); // 0x0000000180972DF0-0x0000000180972E90
		public JsonElementArray CreateArray(string key); // 0x0000000180972BF0-0x0000000180972CC0
		public JsonElementDict CreateDict(string key); // 0x0000000180972CC0-0x0000000180972D90
	}
}
