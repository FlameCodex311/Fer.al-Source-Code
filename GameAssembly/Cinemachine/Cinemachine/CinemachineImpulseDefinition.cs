/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001800B6700-0x00000001800B6720
	public class CinemachineImpulseDefinition // TypeDefIndex: 7389
	{
		// Fields
		[CinemachineImpulseChannelProperty] // 0x0000000180167A10-0x0000000180167A60
		[Tooltip] // 0x0000000180167A10-0x0000000180167A60
		public int m_ImpulseChannel; // 0x10
		[CinemachineEmbeddedAssetProperty] // 0x0000000180167C20-0x0000000180167C90
		[Header] // 0x0000000180167C20-0x0000000180167C90
		[Tooltip] // 0x0000000180167C20-0x0000000180167C90
		public SignalSourceAsset m_RawSignal; // 0x18
		[Tooltip] // 0x00000001801680D0-0x0000000180168100
		public float m_AmplitudeGain; // 0x20
		[Tooltip] // 0x0000000180168320-0x0000000180168350
		public float m_FrequencyGain; // 0x24
		[Tooltip] // 0x0000000180168510-0x0000000180168540
		public RepeatMode m_RepeatMode; // 0x28
		[Tooltip] // 0x0000000180168740-0x0000000180168770
		public bool m_Randomize; // 0x2C
		[CinemachineImpulseEnvelopeProperty] // 0x0000000180168860-0x00000001801688B0
		[Tooltip] // 0x0000000180168860-0x00000001801688B0
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope; // 0x30
		[Header] // 0x0000000180168AB0-0x0000000180168B10
		[Tooltip] // 0x0000000180168AB0-0x0000000180168B10
		public float m_ImpactRadius; // 0x50
		[Tooltip] // 0x0000000180168D60-0x0000000180168D90
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x54
		[Tooltip] // 0x0000000180168E90-0x0000000180168EC0
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x58
		[Tooltip] // 0x0000000180169110-0x0000000180169140
		public float m_DissipationDistance; // 0x5C
	
		// Nested types
		public enum RepeatMode // TypeDefIndex: 7390
		{
			Stretch = 0,
			Loop = 1
		}
	
		private class SignalSource : ISignalSource6D // TypeDefIndex: 7391
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
			private float m_StartTimeOffset; // 0x24
	
			// Properties
			public float SignalDuration { get; } // 0x00000001817E8EE0-0x00000001817E8F20 
	
			// Constructors
			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity); // 0x00000001817E8E40-0x00000001817E8EE0
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001817E8B20-0x00000001817E8E40
		}
	
		// Constructors
		public CinemachineImpulseDefinition(); // 0x00000001817CF310-0x00000001817CF390
	
		// Methods
		public void OnValidate(); // 0x00000001817CF280-0x00000001817CF310
		public void CreateEvent(Vector3 position, Vector3 velocity); // 0x00000001817CEF30-0x00000001817CF280
	}
}
