/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public static class XmlHelper // TypeDefIndex: 9752
	{
		// Methods
		public static void SerializeToFile<T>(T obj, string filename);
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false /* Metadata: 0x0077AA57 */);
		public static string SerializeToString<T>(T obj);
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true /* Metadata: 0x0077AA58 */);
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true /* Metadata: 0x0077AA59 */);
	}
}
