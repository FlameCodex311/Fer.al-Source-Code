/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public static class TMP_FontUtilities // TypeDefIndex: 8791
	{
		// Fields
		private static List<int> k_searchedFontAssets; // 0x00
	
		// Methods
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x00000001810D2600-0x00000001810D26D0
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x00000001810D26D0-0x00000001810D2880
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x00000001810D2370-0x00000001810D2600
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x00000001810D2290-0x00000001810D2370
	}
}
