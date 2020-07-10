/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public static class TMPro_EventManager // TypeDefIndex: 8878
	{
		// Fields
		public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x00
		public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x08
		public static readonly FastAction<bool, TMP_FontAsset> FONT_PROPERTY_EVENT; // 0x10
		public static readonly FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
		public static readonly FastAction<bool, TextMeshPro> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
		public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
		public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
		public static readonly FastAction<TMP_ColorGradient> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
		public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
		public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
		public static readonly FastAction<bool, TextMeshProUGUI> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
		public static readonly FastAction OnPreRenderObject_Event; // 0x58
		public static readonly FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT; // 0x60
	
		// Constructors
		static TMPro_EventManager(); // 0x0000000181889DA0-0x000000018188A030
	
		// Methods
		public static void ON_PRE_RENDER_OBJECT_CHANGED(); // 0x00000001818899A0-0x0000000181889A10
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat); // 0x0000000181889910-0x00000001818899A0
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font); // 0x0000000181889880-0x0000000181889910
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x0000000181889A80-0x0000000181889B10
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj); // 0x0000000181889B10-0x0000000181889BA0
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial); // 0x00000001818897E0-0x0000000181889880
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged); // 0x0000000181889CB0-0x0000000181889D30
		public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient); // 0x00000001818896D0-0x0000000181889750
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x0000000181889C30-0x0000000181889CB0
		public static void ON_TMP_SETTINGS_CHANGED(); // 0x0000000181889D30-0x0000000181889DA0
		public static void ON_RESOURCES_LOADED(); // 0x0000000181889A10-0x0000000181889A80
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj); // 0x0000000181889BA0-0x0000000181889C30
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e); // 0x0000000181889750-0x00000001818897E0
	}
}
