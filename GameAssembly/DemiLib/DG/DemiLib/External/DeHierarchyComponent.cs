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

// Image 49: DemiLib.dll - Assembly: DemiLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5702-5711

namespace DG.DemiLib.External
{
	public class DeHierarchyComponent : UnityEngine.MonoBehaviour // TypeDefIndex: 5708
	{
		// Fields
		public List<CustomizedItem> customizedItems; // 0x18
	
		// Nested types
		public enum HColor // TypeDefIndex: 5709
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
	
		public enum IcoType // TypeDefIndex: 5710
		{
			Dot = 0,
			Star = 1,
			Cog = 2,
			Comment = 3,
			UI = 4,
			Play = 5
		}
	
		[Serializable]
		public class CustomizedItem // TypeDefIndex: 5711
		{
			// Fields
			public GameObject gameObject; // 0x10
			public HColor hColor; // 0x18
			public IcoType icoType; // 0x1C
	
			// Constructors
			public CustomizedItem(GameObject gameObject, HColor hColor); // 0x0000000180DFEB30-0x0000000180DFEB70
			public CustomizedItem(GameObject gameObject, IcoType icoType); // 0x0000000180DFEAF0-0x0000000180DFEB30
		}
	
		// Constructors
		public DeHierarchyComponent(); // 0x0000000180E000A0-0x0000000180E00190
	
		// Methods
		public List<int> MissingItemsIndexes(); // 0x0000000180DFFA10-0x0000000180DFFB50
		public void StoreItemColor(GameObject go, HColor hColor); // 0x0000000180DFFC80-0x0000000180DFFE90
		public void StoreItemIcon(GameObject go, IcoType icoType); // 0x0000000180DFFE90-0x0000000180E000A0
		public bool RemoveItemData(GameObject go); // 0x0000000180DFFB50-0x0000000180DFFC80
		public CustomizedItem GetItem(GameObject go); // 0x0000000180DFF850-0x0000000180DFFA10
	}
}
