/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine.Utility
{
	public class CinemachineDebug // TypeDefIndex: 7402
	{
		// Fields
		private static HashSet<UnityEngine.Object> mClients; // 0x00
		public static OnGUIDelegate OnGUIHandlers; // 0x08
		private static List<StringBuilder> mAvailableStringBuilders; // 0x10
	
		// Nested types
		public delegate void OnGUIDelegate(); // TypeDefIndex: 7403; 0x00000001804C7D50-0x00000001804C7EF0
	
		// Methods
		public static void ReleaseScreenPos(UnityEngine.Object client); // 0x00000001817CCE50-0x00000001817CCEE0
		public static Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style); // 0x00000001817CCB70-0x00000001817CCE50
		public static StringBuilder SBFromPool(); // 0x00000001817CCF90-0x00000001817CD070
		public static void ReturnToPool(StringBuilder sb); // 0x00000001817CCEE0-0x00000001817CCF90
	}
}
