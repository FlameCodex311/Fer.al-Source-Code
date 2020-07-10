/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class TerrainSceneLoader : ManagedBehaviour // TypeDefIndex: 16087
	{
		// Fields
		private static float _timerLoad; // 0x00
		private static float _timerUnload; // 0x04
	
		// Constructors
		public TerrainSceneLoader(); // 0x0000000181600DE0-0x0000000181600E40
	
		// Methods
		public override void MAwake(); // 0x0000000181600970-0x0000000181600A50
		public override void MUpdate(); // 0x0000000181600AF0-0x0000000181600B90
		public override void MOnDestroy(); // 0x0000000181600A50-0x0000000181600AF0
		private void SceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode); // 0x0000000181600C10-0x0000000181600D30
		private void SceneUnloaded(Scene inScene); // 0x0000000181600D30-0x0000000181600DE0
		public static void ResetLoadTimer(); // 0x0000000181600B90-0x0000000181600BD0
		public static void ResetUnloadTimer(); // 0x0000000181600BD0-0x0000000181600C10
	}
}
