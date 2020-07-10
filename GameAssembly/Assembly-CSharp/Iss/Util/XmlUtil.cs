/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Util
{
	public class XmlUtil // TypeDefIndex: 16002
	{
		// Fields
		private static bool DEBUG; // 0x00
	
		// Constructors
		public XmlUtil(); // 0x000000018036B6C0-0x000000018036B6D0
		static XmlUtil(); // 0x00000001803581E0-0x00000001803581F0
	
		// Methods
		public static string GetString(XmlNode node, string path); // 0x00000001812D6B80-0x00000001812D6CE0
		public static int GetInt(XmlNode node, string path); // 0x00000001812D6770-0x00000001812D68E0
		public static bool GetBool(XmlNode node, string path); // 0x00000001812D6590-0x00000001812D6770
		public static XmlNode GetSingleNode(XmlNode node, string path); // 0x00000001812D6A50-0x00000001812D6B80
		public static XmlNodeList GetNodeList(XmlNode node, string path); // 0x00000001812D68E0-0x00000001812D6A50
		public static void Dump(XmlNode xnod, int level); // 0x00000001812D5E40-0x00000001812D6590
	}
}
