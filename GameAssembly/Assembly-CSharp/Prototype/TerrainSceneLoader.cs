/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class TerrainSceneLoader : ManagedBehaviour // TypeDefIndex: 14826
	{
		// Fields
		private static float _timerLoad; // 0x00
		private static float _timerUnload; // 0x04
	
		// Constructors
		public TerrainSceneLoader(); // 0x0000000180A3DA90-0x0000000180A3DAF0
	
		// Methods
		public override void MAwake(); // 0x0000000180A3D620-0x0000000180A3D700
		public override void MUpdate(); // 0x0000000180A3D7A0-0x0000000180A3D840
		public override void MOnDestroy(); // 0x0000000180A3D700-0x0000000180A3D7A0
		private void SceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode); // 0x0000000180A3D8C0-0x0000000180A3D9E0
		private void SceneUnloaded(Scene inScene); // 0x0000000180A3D9E0-0x0000000180A3DA90
		public static void ResetLoadTimer(); // 0x0000000180A3D840-0x0000000180A3D880
		public static void ResetUnloadTimer(); // 0x0000000180A3D880-0x0000000180A3D8C0
	}
}
