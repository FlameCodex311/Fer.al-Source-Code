/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class Template // TypeDefIndex: 9169
	{
		// Fields
		public string FilePath; // 0x10
		public TemplateFrame Frame; // 0x18
		private Dictionary<string, TemplateValue> Variables; // 0x20
	
		// Constructors
		public Template(string filePath, bool debug); // 0x00000001816F75E0-0x00000001816F7750
	
		// Methods
		private bool findPreviouslyBuiltFrame(); // 0x00000001816F7750-0x00000001816F7920
		public void Set(string name, string value); // 0x00000001816F6E20-0x00000001816F6F70
		private int[] CopyIndicies(TemplateFrameVariable tfv); // 0x00000001816F6D90-0x00000001816F6E20
		public override string ToString(); // 0x00000001816F6F70-0x00000001816F7390
		private void UpdateIndicies(int position, int length); // 0x00000001816F7390-0x00000001816F75E0
	}
}
