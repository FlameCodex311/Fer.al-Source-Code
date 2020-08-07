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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Util
{
	public class IssObjectSerializer // TypeDefIndex: 14386
	{
		// Fields
		private static IssObjectSerializer _instance; // 0x00
		private static Hashtable asciiTable_e; // 0x08
	
		// Constructors
		private IssObjectSerializer(); // 0x00000001808753C0-0x00000001808755E0
	
		// Methods
		public static IssObjectSerializer GetInstance(); // 0x00000001808744C0-0x0000000180874540
		public string Serialize(IssObject ao); // 0x0000000180874D70-0x0000000180874E10
		public IssObject Deserialize(string xmlData); // 0x0000000180874190-0x0000000180874320
		private void Xml2obj(XmlNode xmlNode, IssObject ao, int depth); // 0x0000000180874E10-0x00000001808753C0
		private void Obj2xml(IssObject ao, int depth, string nodeName, StringBuilder xmlData); // 0x0000000180874540-0x0000000180874D70
		private static string EncodeEntities(string in_str); // 0x0000000180874320-0x00000001808744C0
	}
}
