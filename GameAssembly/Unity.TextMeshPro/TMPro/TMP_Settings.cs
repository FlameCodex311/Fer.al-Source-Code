/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 8837
	{
		// Fields
		private static TMP_Settings s_Instance; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_enableWordWrapping; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_enableKerning; // 0x19
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_enableExtraPadding; // 0x1A
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_enableTintAllSprites; // 0x1B
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_enableParseEscapeCharacters; // 0x1C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_EnableRaycastTarget; // 0x1D
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_GetFontFeaturesAtRuntime; // 0x1E
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_missingGlyphCharacter; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_warningsDisabled; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_FontAsset m_defaultFontAsset; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_defaultFontAssetPath; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_defaultFontSize; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_defaultAutoSizeMinRatio; // 0x3C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_defaultAutoSizeMaxRatio; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_autoSizeTextContainer; // 0x54
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_matchMaterialPreset; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_defaultSpriteAssetPath; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_defaultColorGradientPresetsPath; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_enableEmojiSupport; // 0x80
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_StyleSheet m_defaultStyleSheet; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextAsset m_leadingCharacters; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextAsset m_followingCharacters; // 0x98
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LineBreakingTable m_linebreakingRules; // 0xA0
	
		// Properties
		public static string version { get; } // 0x00000001811A6370-0x00000001811A63A0 
		public static bool enableWordWrapping { get; } // 0x00000001811A5FF0-0x00000001811A6020 
		public static bool enableKerning { get; } // 0x00000001811A5F30-0x00000001811A5F60 
		public static bool enableExtraPadding { get; } // 0x00000001811A5F00-0x00000001811A5F30 
		public static bool enableTintAllSprites { get; } // 0x00000001811A5FC0-0x00000001811A5FF0 
		public static bool enableParseEscapeCharacters { get; } // 0x00000001811A5F60-0x00000001811A5F90 
		public static bool enableRaycastTarget { get; } // 0x00000001811A5F90-0x00000001811A5FC0 
		public static bool getFontFeaturesAtRuntime { get; } // 0x00000001811A6080-0x00000001811A60B0 
		public static int missingGlyphCharacter { get; set; } // 0x00000001811A6350-0x00000001811A6370 0x00000001811A6400-0x00000001811A6430
		public static bool warningsDisabled { get; } // 0x00000001811A63A0-0x00000001811A63D0 
		public static TMP_FontAsset defaultFontAsset { get; } // 0x00000001811A5D20-0x00000001811A5D50 
		public static string defaultFontAssetPath { get; } // 0x00000001811A5CF0-0x00000001811A5D20 
		public static float defaultFontSize { get; } // 0x00000001811A5D50-0x00000001811A5D80 
		public static float defaultTextAutoSizingMinRatio { get; } // 0x00000001811A5E40-0x00000001811A5E70 
		public static float defaultTextAutoSizingMaxRatio { get; } // 0x00000001811A5E10-0x00000001811A5E40 
		public static Vector2 defaultTextMeshProTextContainerSize { get; } // 0x00000001811A5E70-0x00000001811A5EA0 
		public static Vector2 defaultTextMeshProUITextContainerSize { get; } // 0x00000001811A5EA0-0x00000001811A5ED0 
		public static bool autoSizeTextContainer { get; } // 0x00000001811A5C90-0x00000001811A5CC0 
		public static List<TMP_FontAsset> fallbackFontAssets { get; } // 0x00000001811A6020-0x00000001811A6050 
		public static bool matchMaterialPreset { get; } // 0x00000001811A6320-0x00000001811A6350 
		public static TMP_SpriteAsset defaultSpriteAsset { get; } // 0x00000001811A5DB0-0x00000001811A5DE0 
		public static string defaultSpriteAssetPath { get; } // 0x00000001811A5D80-0x00000001811A5DB0 
		public static string defaultColorGradientPresetsPath { get; } // 0x00000001811A5CC0-0x00000001811A5CF0 
		public static bool enableEmojiSupport { get; set; } // 0x00000001811A5ED0-0x00000001811A5F00 0x00000001811A63D0-0x00000001811A6400
		public static TMP_StyleSheet defaultStyleSheet { get; } // 0x00000001811A5DE0-0x00000001811A5E10 
		public static TextAsset leadingCharacters { get; } // 0x00000001811A6150-0x00000001811A6180 
		public static TextAsset followingCharacters { get; } // 0x00000001811A6050-0x00000001811A6080 
		public static LineBreakingTable linebreakingRules { get; } // 0x00000001811A6180-0x00000001811A6320 
		public static TMP_Settings instance { get; } // 0x00000001811A60B0-0x00000001811A6150 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 8838
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public TMP_Settings(); // 0x00000001811A5C80-0x00000001811A5C90
	
		// Methods
		public static TMP_Settings LoadDefaultSettings(); // 0x00000001811A5A50-0x00000001811A5B20
		public static TMP_Settings GetSettings(); // 0x00000001811A58D0-0x00000001811A5940
		public static TMP_FontAsset GetFontAsset(); // 0x00000001811A5850-0x00000001811A58D0
		public static TMP_SpriteAsset GetSpriteAsset(); // 0x00000001811A5940-0x00000001811A59C0
		public static TMP_StyleSheet GetStyleSheet(); // 0x00000001811A59C0-0x00000001811A5A50
		public static void LoadLinebreakingRules(); // 0x00000001811A5B20-0x00000001811A5C80
		private static Dictionary<int, char> GetCharacters(TextAsset file); // 0x00000001811A5750-0x00000001811A5850
	}
}
