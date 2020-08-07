/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Util
{
	public class XmlUtil // TypeDefIndex: 14389
	{
		// Fields
		private static bool DEBUG; // 0x00
	
		// Constructors
		public XmlUtil(); // 0x0000000180373240-0x0000000180373250
		static XmlUtil(); // 0x00000001803774A0-0x00000001803774B0
	
		// Methods
		public static string GetString(XmlNode node, string path); // 0x0000000180885AF0-0x0000000180885C50
		public static int GetInt(XmlNode node, string path); // 0x00000001808856E0-0x0000000180885850
		public static bool GetBool(XmlNode node, string path); // 0x0000000180885510-0x00000001808856E0
		public static XmlNode GetSingleNode(XmlNode node, string path); // 0x00000001808859C0-0x0000000180885AF0
		public static XmlNodeList GetNodeList(XmlNode node, string path); // 0x0000000180885850-0x00000001808859C0
		public static void Dump(XmlNode xnod, int level); // 0x0000000180884E20-0x0000000180885510
	}
}
