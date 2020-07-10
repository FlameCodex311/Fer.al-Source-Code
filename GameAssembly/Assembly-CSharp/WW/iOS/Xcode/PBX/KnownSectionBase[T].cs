/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class KnownSectionBase<T> : SectionBase // TypeDefIndex: 15829
		where T : PBXObjectData, new()
	{
		// Fields
		private Dictionary<string, T> m_Entries;
		private string m_Name;
	
		// Properties
		public T this[string guid] { get => default; }
	
		// Constructors
		public KnownSectionBase(string sectionName);
	
		// Methods
		public IEnumerable<KeyValuePair<string, T>> GetEntries();
		public IEnumerable<string> GetGuids();
		public IEnumerable<T> GetObjects();
		public override void AddObject(string key, PBXElementDict value);
		public override void WriteSection(StringBuilder sb, GUIDToCommentMap comments);
		public bool HasEntry(string guid);
		public void AddEntry(T obj);
		public void RemoveEntry(string guid);
	}
}
