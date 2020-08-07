/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class SpawnerGroup : UnityEngine.MonoBehaviour // TypeDefIndex: 9237
	{
		// Fields
		public List<SpawnerInstance> m_spawners; // 0x18
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<SpawnerGroup> m_spawnerGroups; // 0x20
		public IEnumerator m_updateCoroutine; // 0x28
		private bool m_cancelSpawn; // 0x30
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int m_progress; // 0x34
	
		// Nested types
		[Serializable]
		public class SpawnerInstance // TypeDefIndex: 9238
		{
			// Fields
			public string m_name; // 0x10
			public Spawner m_spawner; // 0x18
			public int m_interationsPerSpawn; // 0x20
	
			// Constructors
			public SpawnerInstance(); // 0x0000000180D941B0-0x0000000180D941C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RunSpawnerIterationCoRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 9239
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SpawnerGroup <>4__this; // 0x20
			private SpawnerInstance <si>5__2; // 0x28
			private int <idx>5__3; // 0x30
			private int <iter>5__4; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RunSpawnerIterationCoRoutine>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001816FC740-0x00000001816FC980
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001816FC980-0x00000001816FC9D0
		}
	
		// Constructors
		public SpawnerGroup(); // 0x00000001816F1BE0-0x00000001816F1C60
	
		// Methods
		private void OnEnable(); // 0x00000001803774A0-0x00000001803774B0
		private void OnDisable(); // 0x00000001803774A0-0x00000001803774B0
		public void StartEditorUpdates(); // 0x00000001803774A0-0x00000001803774B0
		public void StopEditorUpdates(); // 0x00000001803774A0-0x00000001803774B0
		private void EditorUpdate(); // 0x00000001816F1760-0x00000001816F1810
		public void RunSpawnerIteration(); // 0x00000001816F1B70-0x00000001816F1BE0
		[IteratorStateMachine] // 0x000000018024B2C0-0x000000018024B310
		public IEnumerator RunSpawnerIterationCoRoutine(); // 0x00000001816F1B10-0x00000001816F1B70
		public void CancelSpawn(); // 0x00000001816F1620-0x00000001816F1760
		public bool FixNames(); // 0x00000001816F1810-0x00000001816F1950
		public void ResetSpawner(); // 0x00000001816F1950-0x00000001816F1B10
	}
}
