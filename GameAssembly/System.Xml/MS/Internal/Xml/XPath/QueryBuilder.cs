/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal sealed class QueryBuilder // TypeDefIndex: 1868
	{
		// Fields
		private string query; // 0x10
		private bool allowVar; // 0x18
		private bool allowKey; // 0x19
		private bool allowCurrent; // 0x1A
		private bool needContext; // 0x1B
		private BaseAxisQuery firstInput; // 0x20
		private int parseDepth; // 0x28
	
		// Nested types
		private enum Flags // TypeDefIndex: 1869
		{
			None = 0,
			SmartDesc = 1,
			PosFilter = 2,
			Filter = 4
		}
	
		private enum Props // TypeDefIndex: 1870
		{
			None = 0,
			PosFilter = 1,
			HasPosition = 2,
			HasLast = 4,
			NonFlat = 8
		}
	
		// Constructors
		public QueryBuilder(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		private void Reset(); // 0x0000000180C92040-0x0000000180C92050
		private Query ProcessAxis(Axis root, Flags flags, out Props props); // 0x0000000180C90250-0x0000000180C90F10
		private bool CanBeNumber(Query q); // 0x0000000180C90080-0x0000000180C900E0
		private Query ProcessFilter(Filter root, Flags flags, out Props props); // 0x0000000180C90F10-0x0000000180C91400
		private Query ProcessOperator(Operator root, out Props props); // 0x0000000180C91CD0-0x0000000180C91F80
		private Query ProcessVariable(Variable root); // 0x0000000180C91F80-0x0000000180C92040
		private Query ProcessFunction(Function root, out Props props); // 0x0000000180C91400-0x0000000180C919B0
		private List<Query> ProcessArguments(ArrayList args, out Props props); // 0x0000000180C900E0-0x0000000180C90250
		private Query ProcessNode(AstNode root, Flags flags, out Props props); // 0x0000000180C919B0-0x0000000180C91CD0
		private Query Build(AstNode root, string query); // 0x0000000180C90050-0x0000000180C90080
		internal Query Build(string query, bool allowVar, bool allowKey); // 0x0000000180C8FF00-0x0000000180C90050
		internal Query Build(string query, out bool needContext); // 0x0000000180C8FDB0-0x0000000180C8FF00
	}
}
