/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public class Hierarchy // TypeDefIndex: 9315
	{
		// Constructors
		public Hierarchy(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static bool HierarchyIsValid(Transform[] bones); // 0x0000000182281080-0x0000000182281120
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects); // 0x0000000182280920-0x0000000182280A50
		public static bool IsAncestor(Transform transform, Transform ancestor); // 0x0000000182281120-0x00000001822812A0
		public static bool ContainsChild(Transform transform, Transform child); // 0x00000001822807F0-0x0000000182280920
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array); // 0x00000001822804D0-0x00000001822807F0
		public static Transform GetAncestor(Transform transform, int minChildCount); // 0x0000000182280A50-0x0000000182280B70
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2); // 0x0000000182280ED0-0x0000000182281080
		public static Transform GetFirstCommonAncestor(Transform[] transforms); // 0x0000000182280D10-0x0000000182280ED0
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms); // 0x0000000182280B70-0x0000000182280D10
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms); // 0x00000001822812A0-0x00000001822814C0
	}
}
