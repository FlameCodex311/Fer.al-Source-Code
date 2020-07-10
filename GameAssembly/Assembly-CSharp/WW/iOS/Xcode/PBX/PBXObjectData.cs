/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXObjectData // TypeDefIndex: 15798
	{
		// Fields
		public string guid; // 0x10
		protected PBXElementDict m_Properties; // 0x18
		private static PropertyCommentChecker checkerData; // 0x00
	
		// Properties
		internal virtual PropertyCommentChecker checker { get; } // 0x0000000181681040-0x00000001816810A0 
		internal virtual bool shouldCompact { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public PBXObjectData(); // 0x0000000181680FA0-0x0000000181681040
		static PBXObjectData(); // 0x0000000181680EF0-0x0000000181680FA0
	
		// Methods
		internal void SetPropertiesWhenSerializing(PBXElementDict props); // 0x000000018038B160-0x000000018038B170
		internal PBXElementDict GetPropertiesWhenSerializing(); // 0x000000018038B150-0x000000018038B160
		internal PBXElementDict GetPropertiesRaw(); // 0x00000001816809A0-0x00000001816809D0
		protected string GetPropertyString(string name); // 0x0000000181680BF0-0x0000000181680C30
		protected void SetPropertyString(string name, string value); // 0x0000000181680E60-0x0000000181680EF0
		protected List<string> GetPropertyList(string name); // 0x00000001816809D0-0x0000000181680BF0
		protected void SetPropertyList(string name, List<string> value); // 0x0000000181680C30-0x0000000181680E60
		public virtual void UpdateProps(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void UpdateVars(); // 0x00000001803581E0-0x00000001803581F0
	}
}
