/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x000000018012F8C0-0x000000018012F930
	[DocumentationSorting] // 0x000000018012F8C0-0x000000018012F930
	[ExecuteAlways] // 0x000000018012F8C0-0x000000018012F930
	[SaveDuringPlay] // 0x000000018012F8C0-0x000000018012F930
	public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 7296
	{
		// Fields
		[Tooltip] // 0x000000018012FD30-0x000000018012FD60
		public bool m_ShowImage; // 0x28
		[Tooltip] // 0x000000018012FE50-0x000000018012FE80
		public Texture m_Image; // 0x30
		[Tooltip] // 0x000000018012FFC0-0x000000018012FFF0
		public FillStrategy m_Aspect; // 0x38
		[Range] // 0x0000000180130210-0x0000000180130260
		[Tooltip] // 0x0000000180130210-0x0000000180130260
		public float m_Alpha; // 0x3C
		[Tooltip] // 0x0000000180130890-0x00000001801308C0
		public Vector2 m_Center; // 0x40
		[Tooltip] // 0x0000000180130990-0x00000001801309C0
		public Vector3 m_Rotation; // 0x48
		[Tooltip] // 0x0000000180130A70-0x0000000180130AA0
		public Vector2 m_Scale; // 0x54
		[Tooltip] // 0x0000000180130CB0-0x0000000180130CE0
		public bool m_SyncScale; // 0x5C
		[Tooltip] // 0x0000000180130DE0-0x0000000180130E10
		public bool m_MuteCamera; // 0x5D
		[Range] // 0x0000000180131010-0x0000000180131070
		[Tooltip] // 0x0000000180131010-0x0000000180131070
		public float m_SplitView; // 0x60
		private List<CanvasInfo> mCanvasInfo; // 0x68
	
		// Properties
		private string CanvasName { get; } // 0x00000001817DC6B0-0x00000001817DC730 
	
		// Nested types
		public enum FillStrategy // TypeDefIndex: 7297
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2
		}
	
		private class CanvasInfo // TypeDefIndex: 7298
		{
			// Fields
			public GameObject mCanvas; // 0x10
			public CinemachineBrain mCanvasParent; // 0x18
			public RectTransform mViewport; // 0x20
			public RawImage mRawImage; // 0x28
	
			// Constructors
			public CanvasInfo(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public CinemachineStoryboard(); // 0x00000001817DC580-0x00000001817DC6B0
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float wipeAmountTime); // 0x00000001817DC1B0-0x00000001817DC2A0
		protected override void ConnectToVcam(bool connect); // 0x00000001817DABD0-0x00000001817DAD40
		private void CameraUpdatedCallback(CinemachineBrain brain); // 0x00000001817DA9F0-0x00000001817DABD0
		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound); // 0x00000001817DB510-0x00000001817DB8D0
		private void CreateCanvas(CanvasInfo ci); // 0x00000001817DAD40-0x00000001817DB1D0
		private void DestroyCanvas(); // 0x00000001817DB1D0-0x00000001817DB410
		private void PlaceImage(CanvasInfo ci, float alpha); // 0x00000001817DB8D0-0x00000001817DC1B0
		private static void StaticBlendingHandler(CinemachineBrain brain); // 0x00000001817DC2A0-0x00000001817DC580
		[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
		private static void InitializeModule(); // 0x00000001817DB410-0x00000001817DB510
	}
}
