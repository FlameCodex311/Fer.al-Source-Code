/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public class TMP_UpdateRegistry // TypeDefIndex: 9038
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get; } // 0x0000000180D418C0-0x0000000180D41A20 
	
		// Constructors
		protected TMP_UpdateRegistry(); // 0x0000000180D417C0-0x0000000180D418C0
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x0000000180D41420-0x0000000180D41570
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x0000000180D40C00-0x0000000180D40D50
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x0000000180D412D0-0x0000000180D41420
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x0000000180D40AB0-0x0000000180D40C00
		private void PerformUpdateForCanvasRendererObjects(); // 0x0000000180D40F90-0x0000000180D41280
		private void PerformUpdateForMeshRendererObjects(); // 0x0000000180D41280-0x0000000180D412D0
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x0000000180D41570-0x0000000180D417C0
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x0000000180D40E70-0x0000000180D40F90
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x0000000180D40D50-0x0000000180D40E70
	}
}
