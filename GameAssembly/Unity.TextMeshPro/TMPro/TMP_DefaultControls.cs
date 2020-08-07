/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public static class TMP_DefaultControls // TypeDefIndex: 8929
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x0077811C
		private const float kThickHeight = 30f; // Metadata: 0x00778120
		private const float kThinHeight = 20f; // Metadata: 0x00778124
		private static Vector2 s_ThickElementSize; // 0x00
		private static Vector2 s_ThinElementSize; // 0x08
		private static Color s_DefaultSelectableColor; // 0x10
		private static Color s_TextColor; // 0x20
	
		// Nested types
		public struct Resources // TypeDefIndex: 8930
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
		static TMP_DefaultControls(); // 0x00000001805710A0-0x00000001805711F0
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size); // 0x0000000180570C30-0x0000000180570CD0
		private static GameObject CreateUIObject(string name, GameObject parent); // 0x0000000180570CD0-0x0000000180570D80
		private static void SetDefaultTextValues(TMP_Text lbl); // 0x0000000180570E20-0x0000000180570EC0
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x0000000180570D80-0x0000000180570E20
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x0000000180570FB0-0x00000001805710A0
		private static void SetLayerRecursively(GameObject go, int layer); // 0x0000000180570EC0-0x0000000180570FB0
		public static GameObject CreateScrollbar(Resources resources); // 0x0000000180570760-0x0000000180570AE0
		public static GameObject CreateButton(Resources resources); // 0x000000018056EAC0-0x000000018056EE10
		public static GameObject CreateText(Resources resources); // 0x0000000180570AE0-0x0000000180570C30
		public static GameObject CreateInputField(Resources resources); // 0x000000018056FF80-0x0000000180570760
		public static GameObject CreateDropdown(Resources resources); // 0x000000018056EE10-0x000000018056FF80
	}
}
