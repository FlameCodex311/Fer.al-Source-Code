/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class SpawnerGroup : UnityEngine.MonoBehaviour // TypeDefIndex: 9066
	{
		// Fields
		public List<SpawnerInstance> m_spawners; // 0x18
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public List<SpawnerGroup> m_spawnerGroups; // 0x20
		public IEnumerator m_updateCoroutine; // 0x28
		private bool m_cancelSpawn; // 0x30
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public int m_progress; // 0x34
	
		// Nested types
		[Serializable]
		public class SpawnerInstance // TypeDefIndex: 9067
		{
			// Fields
			public string m_name; // 0x10
			public Spawner m_spawner; // 0x18
			public int m_interationsPerSpawn; // 0x20
	
			// Constructors
			public SpawnerInstance(); // 0x0000000180A6D730-0x0000000180A6D740
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RunSpawnerIterationCoRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 9068
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SpawnerGroup <>4__this; // 0x20
			private SpawnerInstance <si>5__2; // 0x28
			private int <idx>5__3; // 0x30
			private int <iter>5__4; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RunSpawnerIterationCoRoutine>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181C07520-0x0000000181C07770
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181C07770-0x0000000181C077C0
		}
	
		// Constructors
		public SpawnerGroup(); // 0x0000000181BFBCD0-0x0000000181BFBD50
	
		// Methods
		private void OnEnable(); // 0x00000001803581E0-0x00000001803581F0
		private void OnDisable(); // 0x00000001803581E0-0x00000001803581F0
		public void StartEditorUpdates(); // 0x00000001803581E0-0x00000001803581F0
		public void StopEditorUpdates(); // 0x00000001803581E0-0x00000001803581F0
		private void EditorUpdate(); // 0x0000000181BFB840-0x0000000181BFB8F0
		public void RunSpawnerIteration(); // 0x0000000181BFBC60-0x0000000181BFBCD0
		[IteratorStateMachine] // 0x00000001800EA200-0x00000001800EA250
		public IEnumerator RunSpawnerIterationCoRoutine(); // 0x0000000181BFBC00-0x0000000181BFBC60
		public void CancelSpawn(); // 0x0000000181BFB700-0x0000000181BFB840
		public bool FixNames(); // 0x0000000181BFB8F0-0x0000000181BFBA30
		public void ResetSpawner(); // 0x0000000181BFBA30-0x0000000181BFBC00
	}
}
