/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[DocumentationSorting] // 0x00000001801FE1B0-0x00000001801FE1D0
	internal class UpdateTracker // TypeDefIndex: 7544
	{
		// Fields
		private static Dictionary<Transform, UpdateStatus> mUpdateStatus; // 0x00
		private static List<Transform> sToDelete; // 0x08
		private static float mLastUpdateTime; // 0x10
	
		// Nested types
		public enum UpdateClock // TypeDefIndex: 7545
		{
			Fixed = 0,
			Late = 1
		}
	
		private class UpdateStatus // TypeDefIndex: 7546
		{
			// Fields
			private int windowStart; // 0x10
			private int numWindowLateUpdateMoves; // 0x14
			private int numWindowFixedUpdateMoves; // 0x18
			private int numWindows; // 0x1C
			private int lastFrameUpdated; // 0x20
			private Matrix4x4 lastPos; // 0x24
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private UpdateClock <PreferredUpdate>k__BackingField; // 0x64
	
			// Properties
			public UpdateClock PreferredUpdate { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C5F20-0x00000001804C5F30 0x00000001808D4EB0-0x00000001808D4EC0
	
			// Constructors
			public UpdateStatus(int currentFrame, Matrix4x4 pos); // 0x0000000181FFB120-0x0000000181FFB190
	
			// Methods
			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos); // 0x0000000181FFAF70-0x0000000181FFB120
		}
	
		// Constructors
		public UpdateTracker(); // 0x0000000180373240-0x0000000180373250
		static UpdateTracker(); // 0x0000000181FFB7F0-0x0000000181FFB880
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
		private static void InitializeModule(); // 0x0000000181FFB3B0-0x0000000181FFB420
		private static void UpdateTargets(UpdateClock currentClock); // 0x0000000181FFB4D0-0x0000000181FFB7F0
		public static UpdateClock GetPreferredUpdate(Transform target); // 0x0000000181FFB190-0x0000000181FFB3B0
		public static void OnUpdate(UpdateClock currentClock); // 0x0000000181FFB420-0x0000000181FFB4D0
	}
}
