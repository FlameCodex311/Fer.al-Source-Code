/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class BsonWriter : JsonWriter // TypeDefIndex: 8225
	{
		// Fields
		private BsonToken _root; // 0x60
		private BsonToken _parent; // 0x68
		private string _propertyName; // 0x70
	
		// Methods
		private void AddValue(object value, BsonType type); // 0x0000000180C61DE0-0x0000000180C61E60
		internal void AddToken(BsonToken token); // 0x0000000180C61A30-0x0000000180C61DE0
		public void WriteObjectId(byte[] value); // 0x0000000180C61E60-0x0000000180C61F50
		public void WriteRegex(string pattern, string options); // 0x0000000180C61F50-0x0000000180C62070
	}
}
