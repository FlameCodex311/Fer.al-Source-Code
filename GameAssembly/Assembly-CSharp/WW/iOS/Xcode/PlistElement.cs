/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	public class PlistElement // TypeDefIndex: 16139
	{
		// Properties
		public PlistElement this[string key] { get => default; set {} } // 0x00000001814CEC40-0x00000001814CECE0 0x00000001814CECE0-0x00000001814CED90
	
		// Constructors
		protected PlistElement(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public string AsString(); // 0x00000001814CEB70-0x00000001814CEC40
		public int AsInteger(); // 0x00000001814CEAA0-0x00000001814CEB70
		public bool AsBoolean(); // 0x00000001814CE950-0x00000001814CEA20
		public PlistElementArray AsArray(); // 0x00000001814CE8D0-0x00000001814CE950
		public PlistElementDict AsDict(); // 0x00000001814CEA20-0x00000001814CEAA0
	}
}
