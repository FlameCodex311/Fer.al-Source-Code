/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

public static class FTransformMethods // TypeDefIndex: 9687
{
	// Methods
	public static Transform FindChildByNameInDepth(string name, Transform transform); // 0x0000000180D23290-0x0000000180D233A0
	public static List<T> FindComponentsInAllChildren<T>(Transform transformToSearchIn)
		where T : Component;
	public static T FindComponentInAllChildren<T>(Transform transformToSearchIn)
		where T : Component;
	public static T FindComponentInAllParents<T>(Transform transformToSearchIn)
		where T : Component;
	public static void ChangeActiveChildrenInside(Transform parentOfThem, bool active); // 0x0000000180D230C0-0x0000000180D23150
	public static void ChangeActiveThroughParentTo(Transform start, Transform end, bool active, bool changeParentsChildrenActivation = false /* Metadata: 0x0077A269 */); // 0x0000000180D23150-0x0000000180D23290
}

