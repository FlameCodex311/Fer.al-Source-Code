/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Iss.Data;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Util
{
	public class IssObjectSerializer // TypeDefIndex: 15999
	{
		// Fields
		private static IssObjectSerializer _instance; // 0x00
		private static Hashtable asciiTable_e; // 0x08
	
		// Constructors
		private IssObjectSerializer(); // 0x00000001812BC7B0-0x00000001812BC9E0
	
		// Methods
		public static IssObjectSerializer GetInstance(); // 0x00000001812BB8F0-0x00000001812BB970
		public string Serialize(IssObject ao); // 0x00000001812BC1C0-0x00000001812BC260
		public IssObject Deserialize(string xmlData); // 0x00000001812BB600-0x00000001812BB750
		private void Xml2obj(XmlNode xmlNode, IssObject ao, int depth); // 0x00000001812BC260-0x00000001812BC7B0
		private void Obj2xml(IssObject ao, int depth, string nodeName, StringBuilder xmlData); // 0x00000001812BB970-0x00000001812BC1C0
		private static string EncodeEntities(string in_str); // 0x00000001812BB750-0x00000001812BB8F0
	}
}
