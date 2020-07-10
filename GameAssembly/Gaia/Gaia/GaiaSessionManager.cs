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

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class GaiaSessionManager : UnityEngine.MonoBehaviour // TypeDefIndex: 9058
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
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public Stamper m_currentStamper; // 0x78
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public Spawner m_currentSpawner; // 0x80
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
		public DateTime m_lastUpdateDateTime; // 0x88
		[fsIgnore] // 0x00000001800B36B0-0x00000001800B36C0
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PlaySessionCoRoutine>d__65 : IEnumerator<object> // TypeDefIndex: 9059
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GaiaSessionManager <>4__this; // 0x20
			private int <idx>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PlaySessionCoRoutine>d__65(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815A6FD0-0x00000001815A7280
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815A7280-0x00000001815A72D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PlayOperationCoRoutine>d__67 : IEnumerator<object> // TypeDefIndex: 9060
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PlayOperationCoRoutine>d__67(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815A6680-0x00000001815A6F80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815A6F80-0x00000001815A6FD0
		}
	
		// Constructors
		public GaiaSessionManager(); // 0x0000000181596C80-0x0000000181596EA0
	
		// Methods
		public static GaiaSessionManager GetSessionManager(bool pickupExistingTerrain = false /* Metadata: 0x0074421F */); // 0x00000001815947E0-0x00000001815949F0
		public bool IsLocked(); // 0x0000000181594CA0-0x0000000181594D30
		public bool LockSession(); // 0x0000000181594D30-0x0000000181594DC0
		public bool UnLockSession(); // 0x0000000181596BF0-0x0000000181596C80
		public void AddOperation(GaiaOperation operation); // 0x0000000181591F10-0x0000000181591FC0
		public GaiaOperation GetOperation(int operationIdx); // 0x0000000181593CA0-0x0000000181593D90
		public void RemoveOperation(int operationIdx); // 0x00000001815966A0-0x0000000181596770
		public void AddResource(GaiaResource resource); // 0x00000001815920D0-0x00000001815921F0
		public void AddDefaults(GaiaDefaults defaults); // 0x0000000181591E60-0x0000000181591F10
		public void AddPreviewImage(Texture2D image); // 0x0000000181591FC0-0x00000001815920D0
		public bool HasPreviewImage(); // 0x0000000181594C30-0x0000000181594CA0
		public void RemovePreviewImage(); // 0x0000000181596770-0x0000000181596830
		public Texture2D GetPreviewImage(); // 0x0000000181593D90-0x0000000181593EC0
		public void SaveSession(); // 0x00000001803581E0-0x00000001803581F0
		public void StartEditorUpdates(); // 0x00000001803581E0-0x00000001803581F0
		public void StopEditorUpdates(); // 0x0000000181596BD0-0x0000000181596BF0
		private void EditorUpdate(); // 0x0000000181592E40-0x0000000181592F70
		public GaiaSession CreateSession(bool pickupExistingTerrain = false /* Metadata: 0x00744220 */); // 0x00000001815928D0-0x0000000181592D00
		public void SetSeaLevel(float seaLevel); // 0x00000001815969F0-0x0000000181596A10
		public float GetSeaLevel(); // 0x00000001815946C0-0x00000001815947E0
		public void ResetSession(); // 0x0000000181596830-0x00000001815969F0
		public void RandomiseStamps(); // 0x0000000181595CD0-0x00000001815966A0
		private void PositionStamp(Bounds bounds, Stamper stamper, GaiaConstants.FeatureType stampType); // 0x00000001815957F0-0x0000000181595CD0
		private void PositionStampV2(Bounds bounds, Stamper stamper, GaiaConstants.FeatureType stampType, float suggestX, float suggestZ, float suggestJitter); // 0x00000001815952F0-0x00000001815957F0
		private GaiaConstants.FeatureType GetWeightedRandomFeatureType(); // 0x00000001815949F0-0x0000000181594C30
		public string GetRandomStampPath(GaiaConstants.FeatureType featureType); // 0x00000001815940D0-0x00000001815946C0
		public string GetRandomMountainFieldPath(); // 0x0000000181593EC0-0x00000001815940D0
		public GameObject Apply(int operationIdx); // 0x00000001815921F0-0x0000000181592800
		public void PlaySession(); // 0x0000000181595280-0x00000001815952F0
		[IteratorStateMachine] // 0x00000001800E3250-0x00000001800E32A0
		public IEnumerator PlaySessionCoRoutine(); // 0x0000000181595220-0x0000000181595280
		public void PlayOperation(int opIdx); // 0x00000001815951A0-0x0000000181595220
		[IteratorStateMachine] // 0x00000001800E3560-0x00000001800E35B0
		public IEnumerator PlayOperationCoRoutine(int operationIdx); // 0x0000000181595130-0x00000001815951A0
		public void CancelPlayback(); // 0x0000000181592800-0x00000001815928D0
		public void ExportSessionResources(); // 0x0000000181593490-0x0000000181593860
		public void ExportSessionDefaults(); // 0x0000000181592F70-0x00000001815931A0
		public void ExportSessionResource(string resourcePath); // 0x00000001815931A0-0x0000000181593490
		private void OnDrawGizmosSelected(); // 0x0000000181594DC0-0x0000000181595130
		private GameObject FindOrCreateObject(GaiaOperation operation); // 0x0000000181593860-0x0000000181593CA0
		private GameObject ShowStamper(string name, string id); // 0x0000000181596A10-0x0000000181596BD0
		private GameObject CreateSpawner(string name, string id); // 0x0000000181592D00-0x0000000181592E40
	}
}
