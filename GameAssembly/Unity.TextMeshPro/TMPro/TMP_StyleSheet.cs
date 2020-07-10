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
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 8848
	{
		// Fields
		private static TMP_StyleSheet s_Instance; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleDictionary; // 0x20
	
		// Properties
		public static TMP_StyleSheet instance { get; } // 0x00000001811A8990-0x00000001811A8B10 
	
		// Constructors
		public TMP_StyleSheet(); // 0x00000001811A8900-0x00000001811A8990
	
		// Methods
		public static TMP_StyleSheet LoadDefaultStyleSheet(); // 0x00000001811A85D0-0x00000001811A85E0
		public static TMP_Style GetStyle(int hashCode); // 0x00000001811A8540-0x00000001811A85D0
		private TMP_Style GetStyleInternal(int hashCode); // 0x00000001811A84C0-0x00000001811A8540
		public void UpdateStyleDictionaryKey(int old_key, int new_key); // 0x00000001811A87E0-0x00000001811A88A0
		public static void UpdateStyleSheet(); // 0x00000001811A88A0-0x00000001811A8900
		public static void RefreshStyles(); // 0x00000001811A87B0-0x00000001811A87E0
		private void LoadStyleDictionaryInternal(); // 0x00000001811A85E0-0x00000001811A87B0
	}
}
