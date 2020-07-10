/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class GroupSpawn : ManagedBehaviour // TypeDefIndex: 16072
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private InspirationDetails[] _inspirationDetails; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private IngredientDetails[] _ingredientDetails; // 0x58
		private List<Vector3> _usedPositions; // 0x60
	
		// Nested types
		public enum EShape // TypeDefIndex: 16073
		{
			SPHERE = 0,
			RECTANGLE = 1
		}
	
		[Serializable]
		public class SharedDetails // TypeDefIndex: 16074
		{
			// Fields
			public bool enabled; // 0x10
			public int amountToSpawn; // 0x14
			public float minSpacing; // 0x18
			public float offsetY; // 0x1C
			public bool checkForTerrain; // 0x20
			public LayerMask groundLayermask; // 0x24
			public Vector3 spawnAreaOffset; // 0x28
			public float spawnAreaSphere; // 0x34
			public Vector3 spawnAreaRectangle; // 0x38
			public EShape shape; // 0x44
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public List<Vector3> spawnPositions; // 0x48
			public Color gizmoColor; // 0x50
	
			// Constructors
			public SharedDetails(); // 0x00000001813A7220-0x00000001813A72F0
		}
	
		[Serializable]
		public class InspirationDetails // TypeDefIndex: 16075
		{
			// Fields
			[RootSelector] // 0x00000001800FF170-0x00000001800FF1D0
			public string defId; // 0x10
			public SharedDetails details; // 0x18
	
			// Constructors
			public InspirationDetails(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[Serializable]
		public class IngredientDetails // TypeDefIndex: 16076
		{
			// Fields
			[RootSelector] // 0x00000001800FF420-0x00000001800FF480
			public string defId; // 0x10
			public SharedDetails details; // 0x18
			public QuickGamesBase quickGame; // 0x20
	
			// Constructors
			public IngredientDetails(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Spawn>d__11 : IEnumerator<object> // TypeDefIndex: 16077
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GroupSpawn <>4__this; // 0x20
			public SharedDetails inSharedDetails; // 0x28
			public GameObject inPrefab; // 0x30
			public string inDefId; // 0x38
			public QuickGamesBase inQuickGame; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Spawn>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AFE50-0x00000001813B0600
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813B0600-0x00000001813B0650
		}
	
		// Constructors
		public GroupSpawn(); // 0x00000001813A5650-0x00000001813A56D0
	
		// Methods
		public override void MStart(); // 0x00000001813A4490-0x00000001813A4A50
		private void SetInitialUsedPositions(); // 0x00000001813A5140-0x00000001813A52C0
		private void Spawn(InspirationDetails inInspirationDetails); // 0x00000001813A54E0-0x00000001813A5650
		private void Spawn(IngredientDetails inIngredientDetails); // 0x00000001813A5360-0x00000001813A54E0
		[IteratorStateMachine] // 0x00000001800FED90-0x00000001800FEDE0
		private IEnumerator Spawn(SharedDetails inSharedDetails, GameObject inPrefab, string inDefId, QuickGamesBase inQuickGame = null); // 0x00000001813A52C0-0x00000001813A5360
		private bool IsValidPosition(SharedDetails inSharedDetails, Vector3 inPosition); // 0x00000001813A4300-0x00000001813A4490
		private void OnDrawGizmos(); // 0x00000001813A4A50-0x00000001813A5140
	}
}
