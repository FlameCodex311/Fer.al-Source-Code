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
	public class TemplateFrame // TypeDefIndex: 9007
	{
		// Fields
		public Dictionary<string, TemplateFrameVariable> Variables; // 0x10
		public string FilePath; // 0x18
		public string Text; // 0x20
		private const char BeginChar = '{'; // Metadata: 0x00743FBA
		private const char EndChar = '}'; // Metadata: 0x00743FBC
		private int VariableCount; // 0x28
	
		// Constructors
		public TemplateFrame(string filePath, bool debug); // 0x0000000181C00B10-0x0000000181C00C00
	
		// Methods
		public string Build(string filePath); // 0x0000000181C00830-0x0000000181C00B10
		private char[] shiftCharArryLeft(char[] arry, int startIndex, int endIndex); // 0x0000000181C00DE0-0x0000000181C00F30
		private string getVarName(char[] text, ref int pos); // 0x0000000181C00C00-0x0000000181C00DE0
		private static int skipSpaces(char[] text, int pos); // 0x0000000181C00F30-0x0000000181C00F80
	}
}
