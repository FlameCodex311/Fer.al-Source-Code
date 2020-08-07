/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine.Utility
{
	public class CinemachineDebug // TypeDefIndex: 7568
	{
		// Fields
		private static HashSet<UnityEngine.Object> mClients; // 0x00
		public static OnGUIDelegate OnGUIHandlers; // 0x08
		private static List<StringBuilder> mAvailableStringBuilders; // 0x10
	
		// Nested types
		public delegate void OnGUIDelegate(); // TypeDefIndex: 7569; 0x000000018043B480-0x000000018043B690
	
		// Methods
		public static void ReleaseScreenPos(UnityEngine.Object client); // 0x0000000181FF1E90-0x0000000181FF1F20
		public static Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style); // 0x0000000181FF1BB0-0x0000000181FF1E90
		public static StringBuilder SBFromPool(); // 0x0000000181FF1FD0-0x0000000181FF20B0
		public static void ReturnToPool(StringBuilder sb); // 0x0000000181FF1F20-0x0000000181FF1FD0
	}
}
