/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public class TMP_UpdateManager // TypeDefIndex: 8875
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
		public static TMP_UpdateManager instance { get; } // 0x0000000181888510-0x0000000181888740 
	
		// Constructors
		protected TMP_UpdateManager(); // 0x0000000181888350-0x0000000181888510
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000181887FB0-0x0000000181888090
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000181887B10-0x0000000181887BD0
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element); // 0x0000000181887ED0-0x0000000181887FB0
		private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x0000000181887A40-0x0000000181887B10
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element); // 0x0000000181887DF0-0x0000000181887ED0
		private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x0000000181887970-0x0000000181887A40
		private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras); // 0x0000000181887DE0-0x0000000181887DF0
		private void OnCameraPreCull(Camera cam); // 0x0000000181887DE0-0x0000000181887DF0
		private void DoRebuilds(); // 0x00000001818876E0-0x0000000181887970
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000181888290-0x0000000181888350
		public static void UnRegisterTextElementForRebuild(TMP_Text element); // 0x0000000181888090-0x0000000181888290
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x0000000181887BD0-0x0000000181887C80
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x0000000181887C80-0x0000000181887D30
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x0000000181887D30-0x0000000181887DE0
	}
}
