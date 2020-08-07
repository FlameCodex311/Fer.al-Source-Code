/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	public static class SerializationTools // TypeDefIndex: 7052
	{
		// Methods
		public static string SerializeObjectToXmlString<T>(T obj);
		public static void WriteXmlElement(XmlWriter writer, string name, object value); // 0x0000000181463BD0-0x0000000181463DE0
		public static void WriteXmlElement<T>(XmlWriter writer, string name, T value);
		private static void KLKUswJvjFGJaorCZEWHfSWexmG(XmlWriter param_0000f3f7, object param_0000f3f8); // 0x0000000181461B90-0x00000001814638E0
		public static string ReadXmlElement(XmlReader reader, string name); // 0x00000001814638E0-0x00000001814639D0
		public static T ReadXmlElement<T>(XmlReader reader, string name);
		public static bool TryReadXmlElement(XmlReader reader, string name, out string outValue); // 0x00000001814639D0-0x0000000181463AB0
		public static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue);
		public static bool TryReadXmlElement<T>(XmlReader reader, string name, out T outValue, T defaultValue);
		public static bool TryReadXmlStartElement(XmlReader reader, string name, out bool isEmpty); // 0x0000000181463B20-0x0000000181463BD0
		public static bool TryReadXmlEndElement(XmlReader reader); // 0x0000000181463AB0-0x0000000181463B20
		public static string CleanInvalidXmlChars(string text); // 0x0000000181461AC0-0x0000000181461B90
	}
}
