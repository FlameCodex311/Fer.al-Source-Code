/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public class TMP_UpdateManager // TypeDefIndex: 9037
	{
		// Fields
		private static TMP_UpdateManager s_Instance; // 0x00
		private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x10
		private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
		private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x20
		private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
		private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x30
		private Dictionary<int, int> m_InternalUpdateLookup; // 0x38
	
		// Properties
		public static TMP_UpdateManager instance { get; } // 0x0000000180D40A30-0x0000000180D40AB0 
	
		// Constructors
		protected TMP_UpdateManager(); // 0x0000000180D40850-0x0000000180D40A30
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000180D404D0-0x0000000180D405A0
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000180D40050-0x0000000180D40110
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element); // 0x0000000180D40400-0x0000000180D404D0
		private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x0000000180D3FF80-0x0000000180D40050
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element); // 0x0000000180D40330-0x0000000180D40400
		private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x0000000180D3FEB0-0x0000000180D3FF80
		private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras); // 0x0000000180D40320-0x0000000180D40330
		private void OnCameraPreCull(Camera cam); // 0x0000000180D40320-0x0000000180D40330
		private void DoRebuilds(); // 0x0000000180D3FC30-0x0000000180D3FEB0
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000180D40790-0x0000000180D40850
		public static void UnRegisterTextElementForRebuild(TMP_Text element); // 0x0000000180D405A0-0x0000000180D40790
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x0000000180D40110-0x0000000180D401C0
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x0000000180D401C0-0x0000000180D40270
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000180D40270-0x0000000180D40320
	}
}
