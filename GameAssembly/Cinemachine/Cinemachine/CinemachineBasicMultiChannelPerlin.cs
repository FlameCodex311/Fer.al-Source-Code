/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801D2840-0x00000001801D28A0
	[DocumentationSorting] // 0x00000001801D2840-0x00000001801D28A0
	[SaveDuringPlay] // 0x00000001801D2840-0x00000001801D28A0
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 7474
	{
		// Fields
		[FormerlySerializedAs] // 0x00000001801D2E40-0x00000001801D2EB0
		[NoiseSettingsProperty] // 0x00000001801D2E40-0x00000001801D2EB0
		[Tooltip] // 0x00000001801D2E40-0x00000001801D2EB0
		public NoiseSettings m_NoiseProfile; // 0x50
		[Tooltip] // 0x00000001801D3270-0x00000001801D32A0
		public float m_AmplitudeGain; // 0x58
		[Tooltip] // 0x00000001801D3460-0x00000001801D3490
		public float m_FrequencyGain; // 0x5C
		private bool mInitialized; // 0x60
		private float mNoiseTime; // 0x64
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Vector3 mNoiseOffsets; // 0x68
	
		// Properties
		public override bool IsValid { get; } // 0x000000018134B490-0x000000018134BDA0 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000180411150-0x0000000180411160 
	
		// Constructors
		public CinemachineBasicMultiChannelPerlin(); // 0x000000018134B410-0x000000018134B490
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018134AF90-0x000000018134B360
		public void ReSeed(); // 0x000000018134B360-0x000000018134B410
		private void Initialize(); // 0x000000018134AE40-0x000000018134AF90
	}
}
