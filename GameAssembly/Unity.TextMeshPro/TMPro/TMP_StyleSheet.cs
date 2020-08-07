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
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 9010
	{
		// Fields
		private static TMP_StyleSheet s_Instance; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleDictionary; // 0x20
	
		// Properties
		public static TMP_StyleSheet instance { get; } // 0x00000001805ADBF0-0x00000001805ADD70 
	
		// Constructors
		public TMP_StyleSheet(); // 0x00000001805ADB60-0x00000001805ADBF0
	
		// Methods
		public static TMP_StyleSheet LoadDefaultStyleSheet(); // 0x00000001805AD840-0x00000001805AD850
		public static TMP_Style GetStyle(int hashCode); // 0x00000001805AD7B0-0x00000001805AD840
		private TMP_Style GetStyleInternal(int hashCode); // 0x00000001805AD730-0x00000001805AD7B0
		public void UpdateStyleDictionaryKey(int old_key, int new_key); // 0x00000001805ADA40-0x00000001805ADB00
		public static void UpdateStyleSheet(); // 0x00000001805ADB00-0x00000001805ADB60
		public static void RefreshStyles(); // 0x00000001805ADA10-0x00000001805ADA40
		private void LoadStyleDictionaryInternal(); // 0x00000001805AD850-0x00000001805ADA10
	}
}
