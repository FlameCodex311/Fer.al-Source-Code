/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public static class XmlHelper // TypeDefIndex: 9966
	{
		// Methods
		public static void SerializeToFile<T>(T obj, string filename);
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false /* Metadata: 0x0074678C */);
		public static string SerializeToString<T>(T obj);
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true /* Metadata: 0x0074678D */);
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true /* Metadata: 0x0074678E */);
	}
}
