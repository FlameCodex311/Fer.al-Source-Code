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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class GroupSpawn : ManagedBehaviour // TypeDefIndex: 14811
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private InspirationDetails[] _inspirationDetails; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IngredientDetails[] _ingredientDetails; // 0x58
		private List<Vector3> _usedPositions; // 0x60
	
		// Nested types
		public enum EShape // TypeDefIndex: 14812
		{
			SPHERE = 0,
			RECTANGLE = 1
		}
	
		[Serializable]
		public class SharedDetails // TypeDefIndex: 14813
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
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public List<Vector3> spawnPositions; // 0x48
			public Color gizmoColor; // 0x50
	
			// Constructors
			public SharedDetails(); // 0x0000000180ADDEC0-0x0000000180ADDF90
		}
	
		[Serializable]
		public class InspirationDetails // TypeDefIndex: 14814
		{
			// Fields
			[RootSelector] // 0x000000018021B540-0x000000018021B5A0
			public string defId; // 0x10
			public SharedDetails details; // 0x18
	
			// Constructors
			public InspirationDetails(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		public class IngredientDetails // TypeDefIndex: 14815
		{
			// Fields
			[RootSelector] // 0x000000018021B930-0x000000018021B990
			public string defId; // 0x10
			public SharedDetails details; // 0x18
			public QuickGamesBase quickGame; // 0x20
	
			// Constructors
			public IngredientDetails(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Spawn>d__11 : IEnumerator<object> // TypeDefIndex: 14816
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Spawn>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE4D90-0x0000000180AE5510
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE5510-0x0000000180AE5560
		}
	
		// Constructors
		public GroupSpawn(); // 0x0000000180ADC690-0x0000000180ADC710
	
		// Methods
		public override void MStart(); // 0x0000000180ADB770-0x0000000180ADBC10
		private void SetInitialUsedPositions(); // 0x0000000180ADC2A0-0x0000000180ADC410
		private void Spawn(InspirationDetails inInspirationDetails); // 0x0000000180ADC5A0-0x0000000180ADC690
		private void Spawn(IngredientDetails inIngredientDetails); // 0x0000000180ADC4B0-0x0000000180ADC5A0
		[IteratorStateMachine] // 0x000000018021B130-0x000000018021B180
		private IEnumerator Spawn(SharedDetails inSharedDetails, GameObject inPrefab, string inDefId, QuickGamesBase inQuickGame = null); // 0x0000000180ADC410-0x0000000180ADC4B0
		private bool IsValidPosition(SharedDetails inSharedDetails, Vector3 inPosition); // 0x0000000180ADB5E0-0x0000000180ADB770
		private void OnDrawGizmos(); // 0x0000000180ADBC10-0x0000000180ADC2A0
	}
}
