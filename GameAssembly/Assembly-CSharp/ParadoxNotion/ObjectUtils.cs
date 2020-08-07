/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public static class ObjectUtils // TypeDefIndex: 15842
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 15843
		{
			// Fields
			public GameObject exclude; // 0x10
			public LayerMask mask; // 0x18
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <FindGameObjectsWithinLayerMask>b__0(GameObject x); // 0x00000001806D99A0-0x00000001806D9A60
		}
	
		// Methods
		public static bool AnyEquals(object a, object b); // 0x00000001806CCC10-0x00000001806CCDB0
		public static IEnumerable<GameObject> FindGameObjectsWithinLayerMask(LayerMask mask, GameObject exclude = null); // 0x00000001806CCDB0-0x00000001806CCE80
	
		// Extension methods
		public static List<T> Shuffle<T>(this List<T> list);
		public static bool Is<T>(this object o, out T result);
		public static T GetAddComponent<T>(this GameObject gameObject)
			where T : Component;
		public static Component TransformToType(this Component current, Type type); // 0x00000001806CCEE0-0x00000001806CD0A0
		public static bool IsInLayerMask(this GameObject gameObject, LayerMask mask); // 0x00000001806CCE80-0x00000001806CCEE0
	}
}
