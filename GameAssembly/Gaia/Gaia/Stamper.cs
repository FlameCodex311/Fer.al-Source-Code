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
	public class Stamper : UnityEngine.MonoBehaviour // TypeDefIndex: 9242
	{
		// Fields
		public string m_stampID; // 0x18
		public Texture2D m_stampPreviewImage; // 0x20
		public float m_x; // 0x28
		public float m_y; // 0x2C
		public float m_z; // 0x30
		public float m_width; // 0x34
		public float m_height; // 0x38
		public float m_rotation; // 0x3C
		public bool m_stickBaseToGround; // 0x40
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GaiaResource m_resources; // 0x48
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_seaLevel; // 0x50
		public string m_resourcesPath; // 0x58
		public bool m_invertStamp; // 0x60
		public bool m_normaliseStamp; // 0x61
		public float m_baseLevel; // 0x64
		public bool m_drawStampBase; // 0x68
		public GaiaConstants.FeatureOperation m_stampOperation; // 0x6C
		public int m_smoothIterations; // 0x70
		public float m_blendStrength; // 0x74
		public float m_stencilHeight; // 0x78
		public AnimationCurve m_heightModifier; // 0x80
		public AnimationCurve m_distanceMask; // 0x88
		public GaiaConstants.ImageFitnessFilterMode m_areaMaskMode; // 0x90
		public Texture2D m_imageMask; // 0x98
		public bool m_imageMaskInvert; // 0xA0
		public bool m_imageMaskNormalise; // 0xA1
		public bool m_imageMaskFlip; // 0xA2
		public int m_imageMaskSmoothIterations; // 0xA4
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public HeightMap m_imageMaskHM; // 0xA8
		public float m_noiseMaskSeed; // 0xB0
		public int m_noiseMaskOctaves; // 0xB4
		public float m_noiseMaskPersistence; // 0xB8
		public float m_noiseMaskFrequency; // 0xBC
		public float m_noiseMaskLacunarity; // 0xC0
		public float m_noiseZoom; // 0xC4
		public bool m_alwaysShow; // 0xC8
		public bool m_showBase; // 0xC9
		public bool m_showSeaLevel; // 0xCA
		public bool m_showRulers; // 0xCB
		public bool m_showTerrainHelper; // 0xCC
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Color m_gizmoColour; // 0xD0
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public IEnumerator m_updateCoroutine; // 0xE0
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_updateTimeAllowed; // 0xE8
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public float m_stampProgress; // 0xEC
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool m_stampComplete; // 0xF0
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool m_cancelStamp; // 0xF1
		[fsIgnore] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Material m_previewMaterial; // 0xF8
		private int m_featureID; // 0x100
		private int m_scanWidth; // 0x104
		private int m_scanDepth; // 0x108
		private int m_scanHeight; // 0x10C
		private float m_scanResolution; // 0x110
		private Bounds m_scanBounds; // 0x114
		private UnityHeightMap m_stampHM; // 0x130
		private GaiaWorldManager m_undoMgr; // 0x138
		private GaiaWorldManager m_redoMgr; // 0x140
		private MeshFilter m_previewFilter; // 0x148
		private MeshRenderer m_previewRenderer; // 0x150
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ApplyStamp>d__97 : IEnumerator<object> // TypeDefIndex: 9243
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Stamper <>4__this; // 0x20
			private GaiaWorldManager <mgr>5__2; // 0x28
			private Vector3 <pivot>5__3; // 0x30
			private int <newSmMaxX>5__4; // 0x3C
			private int <newSmMaxZ>5__5; // 0x40
			private float <newSmXtoNU>5__6; // 0x44
			private float <newSmZtoNU>5__7; // 0x48
			private float <xNewSMtoOrigSMScale>5__8; // 0x4C
			private float <zNewSMtoOrigSMScale>5__9; // 0x50
			private float <scaleOffsetX>5__10; // 0x54
			private float <scaleOffsetZ>5__11; // 0x58
			private float <currentTime>5__12; // 0x5C
			private float <accumulatedTime>5__13; // 0x60
			private int <currChecks>5__14; // 0x64
			private int <totalChecks>5__15; // 0x68
			private Vector3 <globalOffsetTU>5__16; // 0x6C
			private Vector3 <globalPositionTU>5__17; // 0x78
			private float <smToOrigHeightConversion>5__18; // 0x84
			private float <smHeightOffset>5__19; // 0x88
			private float <stencilHeightNU>5__20; // 0x8C
			private double <rotationCosTheta>5__21; // 0x90
			private double <rotationSinTheta>5__22; // 0x98
			private RotationProducts <xRotationProducts>5__23; // 0xA0
			private RotationProducts[] <zRotationProductCache>5__24; // 0xA8
			private int <x>5__25; // 0xB0
			private int <z>5__26; // 0xB4
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ApplyStamp>d__97(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001816FA440-0x00000001816FBB30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001816FBB30-0x00000001816FBB80
		}
	
		// Constructors
		public Stamper(); // 0x00000001816F6350-0x00000001816F6610
	
		// Methods
		public void LoadStamp(); // 0x00000001816F5360-0x00000001816F58B0
		public void LoadStamp(string imagePreviewPath); // 0x00000001816F5350-0x00000001816F5360
		public bool LoadRuntimeStamp(TextAsset stamp); // 0x00000001816F4FE0-0x00000001816F5350
		public void InvertStamp(); // 0x00000001816F3D90-0x00000001816F3DD0
		public void NormaliseStamp(); // 0x00000001816F58B0-0x00000001816F58F0
		public void Stamp(); // 0x00000001816F5D70-0x00000001816F5E50
		public void CancelStamp(); // 0x0000000181571A70-0x0000000181571A80
		public bool IsStamping(); // 0x00000001816F4010-0x00000001816F4020
		public void UpdateStamp(); // 0x00000001816F6050-0x00000001816F6350
		public void AlignToGround(); // 0x00000001816F1F00-0x00000001816F2230
		public bool GetHeightRange(ref float baseLevel, ref float minHeight, ref float maxHeight); // 0x00000001816F3C80-0x00000001816F3D00
		public void FitToTerrain(); // 0x00000001816F3440-0x00000001816F3680
		public bool IsFitToTerrain(); // 0x00000001816F3DD0-0x00000001816F4010
		public void AddToSession(GaiaOperation.OperationType opType, string opName); // 0x00000001816F1C60-0x00000001816F1F00
		public string SerialiseJson(); // 0x00000001816F5B60-0x00000001816F5BF0
		public void DeSerialiseJson(string json); // 0x00000001816F2600-0x00000001816F26D0
		public void FlattenTerrain(); // 0x00000001816F3680-0x00000001816F3770
		public void SmoothTerrain(); // 0x00000001816F5C80-0x00000001816F5D70
		public void ClearTrees(); // 0x00000001816F2490-0x00000001816F24E0
		public void ClearDetails(); // 0x00000001816F2440-0x00000001816F2490
		public bool CanPreview(); // 0x00000001816F23C0-0x00000001816F2420
		public bool CurrentPreviewState(); // 0x00000001816F2570-0x00000001816F2600
		public void ShowPreview(); // 0x00000001816F5BF0-0x00000001816F5C80
		public void HidePreview(); // 0x00000001816F3D00-0x00000001816F3D90
		public void TogglePreview(); // 0x00000001816F5EF0-0x00000001816F5F90
		public bool CanUndo(); // 0x00000001816F2430-0x00000001816F2440
		public void CreateUndo(); // 0x00000001816F24E0-0x00000001816F2570
		public void Undo(); // 0x00000001816F5F90-0x00000001816F6050
		public bool CanRedo(); // 0x00000001816F2420-0x00000001816F2430
		public void Redo(); // 0x00000001816F5980-0x00000001816F5A00
		private void OnEnable(); // 0x00000001816F5910-0x00000001816F5980
		private void Start(); // 0x00000001816F5E50-0x00000001816F5EF0
		public void StartEditorUpdates(); // 0x00000001803774A0-0x00000001803774B0
		public void StopEditorUpdates(); // 0x00000001803774A0-0x00000001803774B0
		private void EditorUpdate(); // 0x00000001803774A0-0x00000001803774B0
		private void OnDrawGizmosSelected(); // 0x00000001816F58F0-0x00000001816F5900
		private void OnDrawGizmos(); // 0x00000001816F5900-0x00000001816F5910
		private void DrawGizmos(bool isSelected); // 0x00000001816F26D0-0x00000001816F3440
		private void DrawRulers(); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x000000018024CD40-0x000000018024CD90
		public IEnumerator ApplyStamp(); // 0x00000001816F2230-0x00000001816F2290
		private void GeneratePreviewMesh(); // 0x00000001816F3770-0x00000001816F3C80
		private bool LoadImageMask(); // 0x00000001816F4020-0x00000001816F4FE0
		private float CalculateHeight(float terrainHeight, float smHeightRaw, float smHeightAdj, float stencilHeightNU, float strength); // 0x00000001816F2290-0x00000001816F23C0
		private Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle); // 0x00000001816F5A00-0x00000001816F5B60
	}
}
