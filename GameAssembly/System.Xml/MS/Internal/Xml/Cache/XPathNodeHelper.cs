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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.Cache
{
	internal abstract class XPathNodeHelper // TypeDefIndex: 1900
	{
		// Methods
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x0000000180C9AF50-0x0000000180C9B000
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x0000000180C9ADE0-0x0000000180C9AF50
		public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180C9AD80-0x0000000180C9ADE0
		public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180C9B060-0x0000000180C9B110
		public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180C9A040-0x0000000180C9A190
		public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180C9A4D0-0x0000000180C9A580
		public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180C9B200-0x0000000180C9B270
		public static int GetLocation(XPathNode[] pageNode, int idxNode); // 0x0000000180C9B000-0x0000000180C9B060
		public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName); // 0x0000000180C9A580-0x0000000180C9A750
		public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName); // 0x0000000180C9AC10-0x0000000180C9AD80
		public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ); // 0x0000000180C99E70-0x0000000180C9A040
		public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ); // 0x0000000180C9A360-0x0000000180C9A4D0
		public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName); // 0x0000000180C99BF0-0x0000000180C99DF0
		public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName); // 0x0000000180C9A750-0x0000000180C9AC10
		public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ); // 0x0000000180C9A190-0x0000000180C9A360
		public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd); // 0x0000000180C9B270-0x0000000180C9B560
		public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180C9B110-0x0000000180C9B200
		private static void GetChild(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180C99DF0-0x0000000180C99E70
	}
}
