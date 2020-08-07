/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801CDB30-0x00000001801CDBA0
	[DocumentationSorting] // 0x00000001801CDB30-0x00000001801CDBA0
	[ExecuteAlways] // 0x00000001801CDB30-0x00000001801CDBA0
	[SaveDuringPlay] // 0x00000001801CDB30-0x00000001801CDBA0
	public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 7462
	{
		// Fields
		[Tooltip] // 0x00000001801CDF20-0x00000001801CDF50
		public bool m_ShowImage; // 0x28
		[Tooltip] // 0x00000001801CE0B0-0x00000001801CE0E0
		public Texture m_Image; // 0x30
		[Tooltip] // 0x00000001801CE2F0-0x00000001801CE320
		public FillStrategy m_Aspect; // 0x38
		[Range] // 0x00000001801CE450-0x00000001801CE4A0
		[Tooltip] // 0x00000001801CE450-0x00000001801CE4A0
		public float m_Alpha; // 0x3C
		[Tooltip] // 0x00000001801CE750-0x00000001801CE780
		public Vector2 m_Center; // 0x40
		[Tooltip] // 0x00000001801CE970-0x00000001801CE9A0
		public Vector3 m_Rotation; // 0x48
		[Tooltip] // 0x00000001801CEB00-0x00000001801CEB30
		public Vector2 m_Scale; // 0x54
		[Tooltip] // 0x00000001801CEDA0-0x00000001801CEDD0
		public bool m_SyncScale; // 0x5C
		[Tooltip] // 0x00000001801CEEA0-0x00000001801CEED0
		public bool m_MuteCamera; // 0x5D
		[Range] // 0x00000001801CF150-0x00000001801CF1B0
		[Tooltip] // 0x00000001801CF150-0x00000001801CF1B0
		public float m_SplitView; // 0x60
		private List<CanvasInfo> mCanvasInfo; // 0x68
	
		// Properties
		private string CanvasName { get; } // 0x0000000181396C90-0x0000000181396D10 
	
		// Nested types
		public enum FillStrategy // TypeDefIndex: 7463
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2
		}
	
		private class CanvasInfo // TypeDefIndex: 7464
		{
			// Fields
			public GameObject mCanvas; // 0x10
			public CinemachineBrain mCanvasParent; // 0x18
			public RectTransform mViewport; // 0x20
			public RawImage mRawImage; // 0x28
	
			// Constructors
			public CanvasInfo(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public CinemachineStoryboard(); // 0x0000000181396B60-0x0000000181396C90
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float wipeAmountTime); // 0x00000001813967A0-0x0000000181396890
		protected override void ConnectToVcam(bool connect); // 0x0000000181395210-0x0000000181395380
		private void CameraUpdatedCallback(CinemachineBrain brain); // 0x0000000181395030-0x0000000181395210
		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound); // 0x0000000181395B20-0x0000000181395ED0
		private void CreateCanvas(CanvasInfo ci); // 0x0000000181395380-0x00000001813957F0
		private void DestroyCanvas(); // 0x00000001813957F0-0x0000000181395A20
		private void PlaceImage(CanvasInfo ci, float alpha); // 0x0000000181395ED0-0x00000001813967A0
		private static void StaticBlendingHandler(CinemachineBrain brain); // 0x0000000181396890-0x0000000181396B60
		[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
		private static void InitializeModule(); // 0x0000000181395A20-0x0000000181395B20
	}
}
