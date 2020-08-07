/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: DemiLib.dll - Assembly: DemiLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5861-5870

namespace DG.DemiLib.External
{
	public class DeHierarchyComponent : UnityEngine.MonoBehaviour // TypeDefIndex: 5867
	{
		// Fields
		public List<CustomizedItem> customizedItems; // 0x18
	
		// Nested types
		public enum HColor // TypeDefIndex: 5868
		{
			None = 0,
			Blue = 1,
			Green = 2,
			Orange = 3,
			Purple = 4,
			Red = 5,
			Yellow = 6,
			BrightGrey = 7,
			DarkGrey = 8,
			Black = 9,
			White = 10
		}
	
		public enum IcoType // TypeDefIndex: 5869
		{
			Dot = 0,
			Star = 1,
			Cog = 2,
			Comment = 3,
			UI = 4,
			Play = 5
		}
	
		[Serializable]
		public class CustomizedItem // TypeDefIndex: 5870
		{
			// Fields
			public GameObject gameObject; // 0x10
			public HColor hColor; // 0x18
			public IcoType icoType; // 0x1C
	
			// Constructors
			public CustomizedItem(GameObject gameObject, HColor hColor); // 0x00000001820E0E90-0x00000001820E0ED0
			public CustomizedItem(GameObject gameObject, IcoType icoType); // 0x00000001820E0E50-0x00000001820E0E90
		}
	
		// Constructors
		public DeHierarchyComponent(); // 0x00000001820E23E0-0x00000001820E24D0
	
		// Methods
		public List<int> MissingItemsIndexes(); // 0x00000001820E1D60-0x00000001820E1EA0
		public void StoreItemColor(GameObject go, HColor hColor); // 0x00000001820E1FD0-0x00000001820E21D0
		public void StoreItemIcon(GameObject go, IcoType icoType); // 0x00000001820E21D0-0x00000001820E23E0
		public bool RemoveItemData(GameObject go); // 0x00000001820E1EA0-0x00000001820E1FD0
		public CustomizedItem GetItem(GameObject go); // 0x00000001820E1BB0-0x00000001820E1D60
	}
}
