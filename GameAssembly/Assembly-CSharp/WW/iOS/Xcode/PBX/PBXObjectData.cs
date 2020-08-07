/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXObjectData // TypeDefIndex: 16178
	{
		// Fields
		public string guid; // 0x10
		protected PBXElementDict m_Properties; // 0x18
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal virtual PropertyCommentChecker checker { get; } // 0x00000001814B7270-0x00000001814B72D0 
		internal virtual bool shouldCompact { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public PBXObjectData(); // 0x00000001814B7210-0x00000001814B7270
		static PBXObjectData(); // 0x00000001814B7160-0x00000001814B7210
	
		// Methods
		internal void SetPropertiesWhenSerializing(PBXElementDict props); // 0x0000000180379F30-0x0000000180379F40
		internal PBXElementDict GetPropertiesWhenSerializing(); // 0x0000000180372430-0x0000000180372440
		internal PBXElementDict GetPropertiesRaw(); // 0x00000001814B6D70-0x00000001814B6DA0
		protected string GetPropertyString(string name); // 0x00000001814B6F60-0x00000001814B6FA0
		protected void SetPropertyString(string name, string value); // 0x00000001814B7120-0x00000001814B7160
		protected List<string> GetPropertyList(string name); // 0x00000001814B6DA0-0x00000001814B6F60
		protected void SetPropertyList(string name, List<string> value); // 0x00000001814B6FA0-0x00000001814B7120
		public virtual void UpdateProps(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void UpdateVars(); // 0x00000001803774A0-0x00000001803774B0
	}
}
