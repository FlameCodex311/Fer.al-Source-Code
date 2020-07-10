/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public class TMP_UpdateRegistry // TypeDefIndex: 8876
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get; } // 0x0000000181889570-0x00000001818896D0 
	
		// Constructors
		protected TMP_UpdateRegistry(); // 0x0000000181889470-0x0000000181889570
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001818890C0-0x0000000181889210
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x0000000181888890-0x00000001818889E0
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x0000000181888F70-0x00000001818890C0
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x0000000181888740-0x0000000181888890
		private void PerformUpdateForCanvasRendererObjects(); // 0x0000000181888C20-0x0000000181888F20
		private void PerformUpdateForMeshRendererObjects(); // 0x0000000181888F20-0x0000000181888F70
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x0000000181889210-0x0000000181889470
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x0000000181888B00-0x0000000181888C20
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001818889E0-0x0000000181888B00
	}
}
