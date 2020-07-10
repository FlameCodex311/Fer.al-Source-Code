/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801355F0-0x0000000180135650
	[DocumentationSorting] // 0x00000001801355F0-0x0000000180135650
	[SaveDuringPlay] // 0x00000001801355F0-0x0000000180135650
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 7308
	{
		// Fields
		[FormerlySerializedAs] // 0x00000001801358A0-0x0000000180135910
		[NoiseSettingsProperty] // 0x00000001801358A0-0x0000000180135910
		[Tooltip] // 0x00000001801358A0-0x0000000180135910
		public NoiseSettings m_NoiseProfile; // 0x50
		[Tooltip] // 0x0000000180135A40-0x0000000180135A70
		public float m_AmplitudeGain; // 0x58
		[Tooltip] // 0x0000000180135C10-0x0000000180135C40
		public float m_FrequencyGain; // 0x5C
		private bool mInitialized; // 0x60
		private float mNoiseTime; // 0x64
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private Vector3 mNoiseOffsets; // 0x68
	
		// Properties
		public override bool IsValid { get; } // 0x00000001818A4F50-0x00000001818A58D0 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000180362180-0x0000000180362190 
	
		// Constructors
		public CinemachineBasicMultiChannelPerlin(); // 0x00000001818A4ED0-0x00000001818A4F50
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001818A4A50-0x00000001818A4E20
		public void ReSeed(); // 0x00000001818A4E20-0x00000001818A4ED0
		private void Initialize(); // 0x00000001818A4900-0x00000001818A4A50
	}
}
