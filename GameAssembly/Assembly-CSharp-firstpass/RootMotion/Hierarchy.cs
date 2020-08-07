/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public class Hierarchy // TypeDefIndex: 9769
	{
		// Constructors
		public Hierarchy(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static bool HierarchyIsValid(Transform[] bones); // 0x000000018201C980-0x000000018201CA20
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects); // 0x000000018201C240-0x000000018201C360
		public static bool IsAncestor(Transform transform, Transform ancestor); // 0x000000018201CA20-0x000000018201CBA0
		public static bool ContainsChild(Transform transform, Transform child); // 0x000000018201C120-0x000000018201C240
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array); // 0x000000018201BE10-0x000000018201C120
		public static Transform GetAncestor(Transform transform, int minChildCount); // 0x000000018201C360-0x000000018201C480
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2); // 0x000000018201C7D0-0x000000018201C980
		public static Transform GetFirstCommonAncestor(Transform[] transforms); // 0x000000018201C620-0x000000018201C7D0
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms); // 0x000000018201C480-0x000000018201C620
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms); // 0x000000018201CBA0-0x000000018201CDB0
	}
}
