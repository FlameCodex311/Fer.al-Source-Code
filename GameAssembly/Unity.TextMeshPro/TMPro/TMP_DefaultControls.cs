/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public static class TMP_DefaultControls // TypeDefIndex: 8767
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x00743456
		private const float kThickHeight = 30f; // Metadata: 0x0074345A
		private const float kThinHeight = 20f; // Metadata: 0x0074345E
		private static Vector2 s_ThickElementSize; // 0x00
		private static Vector2 s_ThinElementSize; // 0x08
		private static Color s_DefaultSelectableColor; // 0x10
		private static Color s_TextColor; // 0x20
	
		// Nested types
		public struct Resources // TypeDefIndex: 8768
		{
			// Fields
			public Sprite standard; // 0x00
			public Sprite background; // 0x08
			public Sprite inputField; // 0x10
			public Sprite knob; // 0x18
			public Sprite checkmark; // 0x20
			public Sprite dropdown; // 0x28
			public Sprite mask; // 0x30
		}
	
		// Constructors
		static TMP_DefaultControls(); // 0x00000001810C6650-0x00000001810C67A0
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size); // 0x00000001810C61D0-0x00000001810C6270
		private static GameObject CreateUIObject(string name, GameObject parent); // 0x00000001810C6270-0x00000001810C6320
		private static void SetDefaultTextValues(TMP_Text lbl); // 0x00000001810C63C0-0x00000001810C6460
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x00000001810C6320-0x00000001810C63C0
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x00000001810C6550-0x00000001810C6650
		private static void SetLayerRecursively(GameObject go, int layer); // 0x00000001810C6460-0x00000001810C6550
		public static GameObject CreateScrollbar(Resources resources); // 0x00000001810C5CF0-0x00000001810C6080
		public static GameObject CreateButton(Resources resources); // 0x00000001810C3FD0-0x00000001810C4330
		public static GameObject CreateText(Resources resources); // 0x00000001810C6080-0x00000001810C61D0
		public static GameObject CreateInputField(Resources resources); // 0x00000001810C54F0-0x00000001810C5CF0
		public static GameObject CreateDropdown(Resources resources); // 0x00000001810C4330-0x00000001810C54F0
	}
}
