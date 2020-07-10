/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public static class FTransformMethods // TypeDefIndex: 9283
{
	// Methods
	public static Transform FindChildByNameInDepth(string name, Transform transform); // 0x000000018164F600-0x000000018164F710
	public static List<T> FindComponentsInAllChildren<T>(Transform transformToSearchIn)
		where T : Component;
	public static T FindComponentInAllChildren<T>(Transform transformToSearchIn)
		where T : Component;
	public static T FindComponentInAllParents<T>(Transform transformToSearchIn)
		where T : Component;
	public static void ChangeActiveChildrenInside(Transform parentOfThem, bool active); // 0x000000018164F410-0x000000018164F4B0
	public static void ChangeActiveThroughParentTo(Transform start, Transform end, bool active, bool changeParentsChildrenActivation = false /* Metadata: 0x00744F5F */); // 0x000000018164F4B0-0x000000018164F600
}

