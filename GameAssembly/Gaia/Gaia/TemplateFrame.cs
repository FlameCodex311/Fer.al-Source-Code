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
	public class TemplateFrame // TypeDefIndex: 9173
	{
		// Fields
		public Dictionary<string, TemplateFrameVariable> Variables; // 0x10
		public string FilePath; // 0x18
		public string Text; // 0x20
		private const char BeginChar = '{'; // Metadata: 0x00778CA8
		private const char EndChar = '}'; // Metadata: 0x00778CAA
		private int VariableCount; // 0x28
	
		// Constructors
		public TemplateFrame(string filePath, bool debug); // 0x00000001816F68E0-0x00000001816F69D0
	
		// Methods
		public string Build(string filePath); // 0x00000001816F6610-0x00000001816F68E0
		private char[] shiftCharArryLeft(char[] arry, int startIndex, int endIndex); // 0x00000001816F6BA0-0x00000001816F6CE0
		private string getVarName(char[] text, ref int pos); // 0x00000001816F69D0-0x00000001816F6BA0
		private static int skipSpaces(char[] text, int pos); // 0x00000001816F6CE0-0x00000001816F6D30
	}
}
