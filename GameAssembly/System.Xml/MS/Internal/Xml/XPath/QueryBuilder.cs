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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class QueryBuilder // TypeDefIndex: 1973
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
		private enum Flags // TypeDefIndex: 1974
		{
			None = 0,
			SmartDesc = 1,
			PosFilter = 2,
			Filter = 4
		}
	
		private enum Props // TypeDefIndex: 1975
		{
			None = 0,
			PosFilter = 1,
			HasPosition = 2,
			HasLast = 4,
			NonFlat = 8
		}
	
		// Constructors
		public QueryBuilder(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		private void Reset(); // 0x00000001819C9B50-0x00000001819C9B60
		private Query ProcessAxis(Axis root, Flags flags, out Props props); // 0x00000001819C7DB0-0x00000001819C8A40
		private bool CanBeNumber(Query q); // 0x00000001819C7BE0-0x00000001819C7C40
		private Query ProcessFilter(Filter root, Flags flags, out Props props); // 0x00000001819C8A40-0x00000001819C8F30
		private Query ProcessOperator(Operator root, out Props props); // 0x00000001819C97F0-0x00000001819C9A90
		private Query ProcessVariable(Variable root); // 0x00000001819C9A90-0x00000001819C9B50
		private Query ProcessFunction(Function root, out Props props); // 0x00000001819C8F30-0x00000001819C94D0
		private List<Query> ProcessArguments(ArrayList args, out Props props); // 0x00000001819C7C40-0x00000001819C7DB0
		private Query ProcessNode(AstNode root, Flags flags, out Props props); // 0x00000001819C94D0-0x00000001819C97F0
		private Query Build(AstNode root, string query); // 0x00000001819C7BB0-0x00000001819C7BE0
		internal Query Build(string query, bool allowVar, bool allowKey); // 0x00000001819C7A60-0x00000001819C7BB0
		internal Query Build(string query, out bool needContext); // 0x00000001819C7910-0x00000001819C7A60
	}
}
