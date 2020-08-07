/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.Cache
{
	internal abstract class XPathNodeHelper // TypeDefIndex: 2005
	{
		// Methods
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x00000001819D2B30-0x00000001819D2BE0
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x00000001819D29D0-0x00000001819D2B30
		public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode); // 0x00000001819D2980-0x00000001819D29D0
		public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode); // 0x00000001819D2C30-0x00000001819D2CD0
		public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode); // 0x00000001819D1CE0-0x00000001819D1E20
		public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode); // 0x00000001819D2140-0x00000001819D21F0
		public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode); // 0x00000001819D2DB0-0x00000001819D2E10
		public static int GetLocation(XPathNode[] pageNode, int idxNode); // 0x00000001819D2BE0-0x00000001819D2C30
		public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName); // 0x00000001819D21F0-0x00000001819D23A0
		public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName); // 0x00000001819D2820-0x00000001819D2980
		public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ); // 0x00000001819D1B20-0x00000001819D1CE0
		public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ); // 0x00000001819D1FE0-0x00000001819D2140
		public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName); // 0x00000001819D18C0-0x00000001819D1AA0
		public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName); // 0x00000001819D23A0-0x00000001819D2820
		public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ); // 0x00000001819D1E20-0x00000001819D1FE0
		public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd); // 0x00000001819D2E10-0x00000001819D3230
		public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode); // 0x00000001819D2CD0-0x00000001819D2DB0
		private static void GetChild(ref XPathNode[] pageNode, ref int idxNode); // 0x00000001819D1AA0-0x00000001819D1B20
	}
}
