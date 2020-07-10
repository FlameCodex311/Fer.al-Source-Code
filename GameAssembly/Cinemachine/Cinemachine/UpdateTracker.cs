/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[DocumentationSorting] // 0x000000018012F850-0x000000018012F870
	internal class UpdateTracker // TypeDefIndex: 7378
	{
		// Fields
		private static Dictionary<Transform, UpdateStatus> mUpdateStatus; // 0x00
		private static List<Transform> sToDelete; // 0x08
		private static float mLastUpdateTime; // 0x10
	
		// Nested types
		public enum UpdateClock // TypeDefIndex: 7379
		{
			Fixed = 0,
			Late = 1
		}
	
		private class UpdateStatus // TypeDefIndex: 7380
		{
			// Fields
			private int windowStart; // 0x10
			private int numWindowLateUpdateMoves; // 0x14
			private int numWindowFixedUpdateMoves; // 0x18
			private int numWindows; // 0x1C
			private int lastFrameUpdated; // 0x20
			private Matrix4x4 lastPos; // 0x24
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private UpdateClock <PreferredUpdate>k__BackingField; // 0x64
	
			// Properties
			public UpdateClock PreferredUpdate { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804D0650-0x00000001804D0660 0x000000018044E320-0x000000018044E330
	
			// Constructors
			public UpdateStatus(int currentFrame, Matrix4x4 pos); // 0x00000001817E9CC0-0x00000001817E9D30
	
			// Methods
			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos); // 0x00000001817E9B10-0x00000001817E9CC0
		}
	
		// Constructors
		public UpdateTracker(); // 0x000000018036B6C0-0x000000018036B6D0
		static UpdateTracker(); // 0x00000001817EA3A0-0x00000001817EA430
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
		private static void InitializeModule(); // 0x00000001817E9F50-0x00000001817E9FC0
		private static void UpdateTargets(UpdateClock currentClock); // 0x00000001817EA070-0x00000001817EA3A0
		public static UpdateClock GetPreferredUpdate(Transform target); // 0x00000001817E9D30-0x00000001817E9F50
		public static void OnUpdate(UpdateClock currentClock); // 0x00000001817E9FC0-0x00000001817EA070
	}
}
