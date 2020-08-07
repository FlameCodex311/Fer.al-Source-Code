/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public static class TMPro_EventManager // TypeDefIndex: 9040
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
		static TMPro_EventManager(); // 0x0000000180D420F0-0x0000000180D42380
	
		// Methods
		public static void ON_PRE_RENDER_OBJECT_CHANGED(); // 0x0000000180D41CF0-0x0000000180D41D60
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat); // 0x0000000180D41C60-0x0000000180D41CF0
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font); // 0x0000000180D41BD0-0x0000000180D41C60
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x0000000180D41DD0-0x0000000180D41E60
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj); // 0x0000000180D41E60-0x0000000180D41EF0
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial); // 0x0000000180D41B30-0x0000000180D41BD0
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged); // 0x0000000180D42000-0x0000000180D42080
		public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient); // 0x0000000180D41A20-0x0000000180D41AA0
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x0000000180D41F80-0x0000000180D42000
		public static void ON_TMP_SETTINGS_CHANGED(); // 0x0000000180D42080-0x0000000180D420F0
		public static void ON_RESOURCES_LOADED(); // 0x0000000180D41D60-0x0000000180D41DD0
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj); // 0x0000000180D41EF0-0x0000000180D41F80
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e); // 0x0000000180D41AA0-0x0000000180D41B30
	}
}
