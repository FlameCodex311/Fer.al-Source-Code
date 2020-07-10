/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class Template // TypeDefIndex: 9003
	{
		// Fields
		public string FilePath; // 0x10
		public TemplateFrame Frame; // 0x18
		private Dictionary<string, TemplateValue> Variables; // 0x20
	
		// Constructors
		public Template(string filePath, bool debug); // 0x0000000181C01870-0x0000000181C019E0
	
		// Methods
		private bool findPreviouslyBuiltFrame(); // 0x0000000181C019E0-0x0000000181C01BB0
		public void Set(string name, string value); // 0x0000000181C01070-0x0000000181C011C0
		private int[] CopyIndicies(TemplateFrameVariable tfv); // 0x0000000181C00FE0-0x0000000181C01070
		public override string ToString(); // 0x0000000181C011C0-0x0000000181C01610
		private void UpdateIndicies(int position, int length); // 0x0000000181C01610-0x0000000181C01870
	}
}
