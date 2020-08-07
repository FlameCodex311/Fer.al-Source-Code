/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class GaiaSessionManager : UnityEngine.MonoBehaviour // TypeDefIndex: 9224
	{
		// Fields
		public IEnumerator m_updateSessionCoroutine; // 0x18
		public IEnumerator m_updateOperationCoroutine; // 0x20
		private bool m_cancelPlayback; // 0x28
		public GaiaSession m_session; // 0x30
		public bool m_focusSceneView; // 0x38
		public bool m_genShowRandomGenerator; // 0x39
		public bool m_genShowTerrainHelper; // 0x3A
		public GaiaConstants.GeneratorBorderStyle m_genBorderStyle; // 0x3C
		public int m_genGridSize; // 0x40
		public int m_genNumStampsToGenerate; // 0x44
		public float m_genScaleWidth; // 0x48
		public float m_genScaleHeight; // 0x4C
		public float m_genChanceOfHills; // 0x50
		public float m_genChanceOfIslands; // 0x54
		public float m_genChanceOfLakes; // 0x58
		public float m_genChanceOfMesas; // 0x5C
		public float m_genChanceOfMountains; // 0x60
		public float m_genChanceOfPlains; // 0x64
		public float m_genChanceOfRivers; // 0x68
		public float m_genChanceOfValleys; // 0x6C
		public float m_genChanceOfVillages; // 0x70
		public float m_genChanceOfWaterfalls; // 0x74
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Stamper m_currentStamper; // 0x78
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Spawner m_currentSpawner; // 0x80
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public DateTime m_lastUpdateDateTime; // 0x88
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ulong m_progress; // 0x90
		private List<string> m_genHillStamps; // 0x98
		private List<string> m_genIslandStamps; // 0xA0
		private List<string> m_genLakeStamps; // 0xA8
		private List<string> m_genMesaStamps; // 0xB0
		private List<string> m_genMountainStamps; // 0xB8
		private List<string> m_genPlainsStamps; // 0xC0
		private List<string> m_genRiverStamps; // 0xC8
		private List<string> m_genValleyStamps; // 0xD0
		private List<string> m_genVillageStamps; // 0xD8
		private List<string> m_genWaterfallStamps; // 0xE0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PlaySessionCoRoutine>d__65 : IEnumerator<object> // TypeDefIndex: 9225
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GaiaSessionManager <>4__this; // 0x20
			private int <idx>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PlaySessionCoRoutine>d__65(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819A51F0-0x00000001819A5490
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819A5490-0x00000001819A54E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PlayOperationCoRoutine>d__67 : IEnumerator<object> // TypeDefIndex: 9226
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public int operationIdx; // 0x20
			public GaiaSessionManager <>4__this; // 0x28
			private bool <lockState>5__2; // 0x30
			private Stamper <stamper>5__3; // 0x38
			private Spawner <spawner>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PlayOperationCoRoutine>d__67(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819A48C0-0x00000001819A51A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819A51A0-0x00000001819A51F0
		}
	
		// Constructors
		public GaiaSessionManager(); // 0x0000000180E4D910-0x0000000180E4DB30
	
		// Methods
		public static GaiaSessionManager GetSessionManager(bool pickupExistingTerrain = false /* Metadata: 0x00778F0D */); // 0x0000000180E4B350-0x0000000180E4B550
		public bool IsLocked(); // 0x0000000180E4B7F0-0x0000000180E4B880
		public bool LockSession(); // 0x0000000180E4B880-0x0000000180E4B910
		public bool UnLockSession(); // 0x0000000180E4D880-0x0000000180E4D910
		public void AddOperation(GaiaOperation operation); // 0x0000000180E48960-0x0000000180E48A10
		public GaiaOperation GetOperation(int operationIdx); // 0x0000000180E4A8A0-0x0000000180E4A990
		public void RemoveOperation(int operationIdx); // 0x0000000180E4D360-0x0000000180E4D430
		public void AddResource(GaiaResource resource); // 0x0000000180E48B10-0x0000000180E48C30
		public void AddDefaults(GaiaDefaults defaults); // 0x0000000180E488B0-0x0000000180E48960
		public void AddPreviewImage(Texture2D image); // 0x0000000180E48A10-0x0000000180E48B10
		public bool HasPreviewImage(); // 0x0000000180E4B790-0x0000000180E4B7F0
		public void RemovePreviewImage(); // 0x0000000180E4D430-0x0000000180E4D4E0
		public Texture2D GetPreviewImage(); // 0x0000000180E4A990-0x0000000180E4AAC0
		public void SaveSession(); // 0x00000001803774A0-0x00000001803774B0
		public void StartEditorUpdates(); // 0x00000001803774A0-0x00000001803774B0
		public void StopEditorUpdates(); // 0x0000000180E4D860-0x0000000180E4D880
		private void EditorUpdate(); // 0x0000000180E49A90-0x0000000180E49BC0
		public GaiaSession CreateSession(bool pickupExistingTerrain = false /* Metadata: 0x00778F0E */); // 0x0000000180E49460-0x0000000180E49960
		public void SetSeaLevel(float seaLevel); // 0x0000000180E4D690-0x0000000180E4D6B0
		public float GetSeaLevel(); // 0x0000000180E4B260-0x0000000180E4B350
		public void ResetSession(); // 0x0000000180E4D4E0-0x0000000180E4D690
		public void RandomiseStamps(); // 0x0000000180E4C820-0x0000000180E4D360
		private void PositionStamp(Bounds bounds, Stamper stamper, GaiaConstants.FeatureType stampType); // 0x0000000180E4C350-0x0000000180E4C820
		private void PositionStampV2(Bounds bounds, Stamper stamper, GaiaConstants.FeatureType stampType, float suggestX, float suggestZ, float suggestJitter); // 0x0000000180E4BE60-0x0000000180E4C350
		private GaiaConstants.FeatureType GetWeightedRandomFeatureType(); // 0x0000000180E4B550-0x0000000180E4B790
		public string GetRandomStampPath(GaiaConstants.FeatureType featureType); // 0x0000000180E4ACC0-0x0000000180E4B260
		public string GetRandomMountainFieldPath(); // 0x0000000180E4AAC0-0x0000000180E4ACC0
		public GameObject Apply(int operationIdx); // 0x0000000180E48C30-0x0000000180E49390
		public void PlaySession(); // 0x0000000180E4BDE0-0x0000000180E4BE60
		[IteratorStateMachine] // 0x0000000180242230-0x0000000180242280
		public IEnumerator PlaySessionCoRoutine(); // 0x0000000180E4BD70-0x0000000180E4BDE0
		public void PlayOperation(int opIdx); // 0x0000000180E4BCF0-0x0000000180E4BD70
		[IteratorStateMachine] // 0x0000000180242510-0x0000000180242560
		public IEnumerator PlayOperationCoRoutine(int operationIdx); // 0x0000000180E4BC80-0x0000000180E4BCF0
		public void CancelPlayback(); // 0x0000000180E49390-0x0000000180E49460
		public void ExportSessionResources(); // 0x0000000180E4A0C0-0x0000000180E4A480
		public void ExportSessionDefaults(); // 0x0000000180E49BC0-0x0000000180E49DE0
		public void ExportSessionResource(string resourcePath); // 0x0000000180E49DE0-0x0000000180E4A0C0
		private void OnDrawGizmosSelected(); // 0x0000000180E4B910-0x0000000180E4BC80
		private GameObject FindOrCreateObject(GaiaOperation operation); // 0x0000000180E4A480-0x0000000180E4A8A0
		private GameObject ShowStamper(string name, string id); // 0x0000000180E4D6B0-0x0000000180E4D860
		private GameObject CreateSpawner(string name, string id); // 0x0000000180E49960-0x0000000180E49A90
	}
}
