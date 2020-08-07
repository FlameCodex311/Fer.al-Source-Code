/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001801E4110-0x00000001801E4130
	public class CinemachineImpulseDefinition // TypeDefIndex: 7555
	{
		// Fields
		[CinemachineImpulseChannelProperty] // 0x0000000180209470-0x00000001802094C0
		[Tooltip] // 0x0000000180209470-0x00000001802094C0
		public int m_ImpulseChannel; // 0x10
		[CinemachineEmbeddedAssetProperty] // 0x0000000180209730-0x00000001802097A0
		[Header] // 0x0000000180209730-0x00000001802097A0
		[Tooltip] // 0x0000000180209730-0x00000001802097A0
		public SignalSourceAsset m_RawSignal; // 0x18
		[Tooltip] // 0x0000000180209A90-0x0000000180209AC0
		public float m_AmplitudeGain; // 0x20
		[Tooltip] // 0x0000000180209C50-0x0000000180209C80
		public float m_FrequencyGain; // 0x24
		[Tooltip] // 0x0000000180209D90-0x0000000180209DC0
		public RepeatMode m_RepeatMode; // 0x28
		[Tooltip] // 0x0000000180209EF0-0x0000000180209F20
		public bool m_Randomize; // 0x2C
		[CinemachineImpulseEnvelopeProperty] // 0x000000018020A1D0-0x000000018020A220
		[Tooltip] // 0x000000018020A1D0-0x000000018020A220
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope; // 0x30
		[Header] // 0x000000018020A3B0-0x000000018020A410
		[Tooltip] // 0x000000018020A3B0-0x000000018020A410
		public float m_ImpactRadius; // 0x50
		[Tooltip] // 0x000000018020A690-0x000000018020A6C0
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x54
		[Tooltip] // 0x000000018020A860-0x000000018020A890
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x58
		[Tooltip] // 0x000000018020A9C0-0x000000018020A9F0
		public float m_DissipationDistance; // 0x5C
	
		// Nested types
		public enum RepeatMode // TypeDefIndex: 7556
		{
			Stretch = 0,
			Loop = 1
		}
	
		private class SignalSource : ISignalSource6D // TypeDefIndex: 7557
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
			private float m_StartTimeOffset; // 0x24
	
			// Properties
			public float SignalDuration { get; } // 0x000000018139F4F0-0x000000018139F530 
	
			// Constructors
			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity); // 0x000000018139F450-0x000000018139F4F0
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x000000018139F140-0x000000018139F450
		}
	
		// Constructors
		public CinemachineImpulseDefinition(); // 0x000000018138B400-0x000000018138B480
	
		// Methods
		public void OnValidate(); // 0x000000018138B370-0x000000018138B400
		public void CreateEvent(Vector3 position, Vector3 velocity); // 0x000000018138B030-0x000000018138B370
	}
}
