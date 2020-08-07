/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal abstract class AssetCatalogItem // TypeDefIndex: 16107
	{
		// Fields
		public readonly string name; // 0x10
		public readonly string authorId; // 0x18
		protected Dictionary<string, string> m_Properties; // 0x20
		protected string m_Path; // 0x28
	
		// Properties
		public string path { get; } // 0x00000001803745B0-0x00000001803745C0 
	
		// Constructors
		public AssetCatalogItem(string name, string authorId); // 0x0000000180963FA0-0x0000000180964070
	
		// Methods
		protected JsonElementDict WriteInfoToJson(JsonDocument doc); // 0x0000000180963F00-0x0000000180963FA0
		public abstract void Write(List<string> warnings);
	}
}
