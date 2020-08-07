/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 8999
	{
		// Fields
		private static TMP_Settings s_Instance; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_enableWordWrapping; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_enableKerning; // 0x19
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_enableExtraPadding; // 0x1A
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_enableTintAllSprites; // 0x1B
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_enableParseEscapeCharacters; // 0x1C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_EnableRaycastTarget; // 0x1D
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_GetFontFeaturesAtRuntime; // 0x1E
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_missingGlyphCharacter; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_warningsDisabled; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_FontAsset m_defaultFontAsset; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_defaultFontAssetPath; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_defaultFontSize; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_defaultAutoSizeMinRatio; // 0x3C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_defaultAutoSizeMaxRatio; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_autoSizeTextContainer; // 0x54
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_matchMaterialPreset; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_defaultSpriteAssetPath; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_defaultColorGradientPresetsPath; // 0x78
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_enableEmojiSupport; // 0x80
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_StyleSheet m_defaultStyleSheet; // 0x88
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextAsset m_leadingCharacters; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextAsset m_followingCharacters; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LineBreakingTable m_linebreakingRules; // 0xA0
	
		// Properties
		public static string version { get; } // 0x00000001805AB650-0x00000001805AB680 
		public static bool enableWordWrapping { get; } // 0x00000001805AB320-0x00000001805AB340 
		public static bool enableKerning { get; } // 0x00000001805AB2A0-0x00000001805AB2C0 
		public static bool enableExtraPadding { get; } // 0x00000001805AB280-0x00000001805AB2A0 
		public static bool enableTintAllSprites { get; } // 0x00000001805AB300-0x00000001805AB320 
		public static bool enableParseEscapeCharacters { get; } // 0x00000001805AB2C0-0x00000001805AB2E0 
		public static bool enableRaycastTarget { get; } // 0x00000001805AB2E0-0x00000001805AB300 
		public static bool getFontFeaturesAtRuntime { get; } // 0x00000001805AB390-0x00000001805AB3B0 
		public static int missingGlyphCharacter { get; set; } // 0x00000001805AB630-0x00000001805AB650 0x00000001805AB6D0-0x00000001805AB700
		public static bool warningsDisabled { get; } // 0x00000001805AB680-0x00000001805AB6A0 
		public static TMP_FontAsset defaultFontAsset { get; } // 0x00000001805AB100-0x00000001805AB120 
		public static string defaultFontAssetPath { get; } // 0x00000001805AB0E0-0x00000001805AB100 
		public static float defaultFontSize { get; } // 0x00000001805AB120-0x00000001805AB140 
		public static float defaultTextAutoSizingMinRatio { get; } // 0x00000001805AB1D0-0x00000001805AB1F0 
		public static float defaultTextAutoSizingMaxRatio { get; } // 0x00000001805AB1B0-0x00000001805AB1D0 
		public static Vector2 defaultTextMeshProTextContainerSize { get; } // 0x00000001805AB1F0-0x00000001805AB220 
		public static Vector2 defaultTextMeshProUITextContainerSize { get; } // 0x00000001805AB220-0x00000001805AB250 
		public static bool autoSizeTextContainer { get; } // 0x00000001805AB0A0-0x00000001805AB0C0 
		public static List<TMP_FontAsset> fallbackFontAssets { get; } // 0x00000001805AB340-0x00000001805AB360 
		public static bool matchMaterialPreset { get; } // 0x00000001805AB610-0x00000001805AB630 
		public static TMP_SpriteAsset defaultSpriteAsset { get; } // 0x00000001805AB160-0x00000001805AB180 
		public static string defaultSpriteAssetPath { get; } // 0x00000001805AB140-0x00000001805AB160 
		public static string defaultColorGradientPresetsPath { get; } // 0x00000001805AB0C0-0x00000001805AB0E0 
		public static bool enableEmojiSupport { get; set; } // 0x00000001805AB250-0x00000001805AB280 0x00000001805AB6A0-0x00000001805AB6D0
		public static TMP_StyleSheet defaultStyleSheet { get; } // 0x00000001805AB180-0x00000001805AB1B0 
		public static TextAsset leadingCharacters { get; } // 0x00000001805AB450-0x00000001805AB480 
		public static TextAsset followingCharacters { get; } // 0x00000001805AB360-0x00000001805AB390 
		public static LineBreakingTable linebreakingRules { get; } // 0x00000001805AB480-0x00000001805AB610 
		public static TMP_Settings instance { get; } // 0x00000001805AB3B0-0x00000001805AB450 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 9000
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public TMP_Settings(); // 0x00000001805AB090-0x00000001805AB0A0
	
		// Methods
		public static TMP_Settings LoadDefaultSettings(); // 0x00000001805AAE70-0x00000001805AAF40
		public static TMP_Settings GetSettings(); // 0x00000001805AACF0-0x00000001805AAD60
		public static TMP_FontAsset GetFontAsset(); // 0x00000001805AAC70-0x00000001805AACF0
		public static TMP_SpriteAsset GetSpriteAsset(); // 0x00000001805AAD60-0x00000001805AADE0
		public static TMP_StyleSheet GetStyleSheet(); // 0x00000001805AADE0-0x00000001805AAE70
		public static void LoadLinebreakingRules(); // 0x00000001805AAF40-0x00000001805AB090
		private static Dictionary<int, char> GetCharacters(TextAsset file); // 0x00000001805AAB80-0x00000001805AAC70
	}
}
