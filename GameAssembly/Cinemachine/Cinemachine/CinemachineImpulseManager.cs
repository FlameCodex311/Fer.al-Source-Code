/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[DocumentationSorting] // 0x00000001800B6700-0x00000001800B6720
	public class CinemachineImpulseManager // TypeDefIndex: 7395
	{
		// Fields
		private static CinemachineImpulseManager sInstance; // 0x00
		private List<ImpulseEvent> m_ExpiredEvents; // 0x10
		private List<ImpulseEvent> m_ActiveEvents; // 0x18
	
		// Properties
		public static CinemachineImpulseManager Instance { get; } // 0x00000001817CFB30-0x00000001817CFBB0 
	
		// Nested types
		[Serializable]
		public struct EnvelopeDefinition // TypeDefIndex: 7396
		{
			// Fields
			[Tooltip] // 0x000000018016B0E0-0x000000018016B110
			public AnimationCurve m_AttackShape; // 0x00
			[Tooltip] // 0x000000018016B2A0-0x000000018016B2D0
			public AnimationCurve m_DecayShape; // 0x08
			[Tooltip] // 0x000000018016B410-0x000000018016B440
			public float m_AttackTime; // 0x10
			[Tooltip] // 0x000000018016B5E0-0x000000018016B610
			public float m_SustainTime; // 0x14
			[Tooltip] // 0x000000018016B6B0-0x000000018016B6E0
			public float m_DecayTime; // 0x18
			[Tooltip] // 0x000000018016B7D0-0x000000018016B800
			public bool m_ScaleWithImpact; // 0x1C
			[Tooltip] // 0x000000018016B990-0x000000018016B9C0
			public bool m_HoldForever; // 0x1D
	
			// Properties
			public float Duration { get; } // 0x0000000180298FC0-0x0000000180299130 
	
			// Methods
			public static EnvelopeDefinition Default(); // 0x00000001817E5D40-0x00000001817E5F50
			public float GetValueAt(float offset); // 0x0000000180298FA0-0x0000000180298FB0
			public void Clear(); // 0x0000000180298F80-0x0000000180298FA0
			public void Validate(); // 0x0000000180298FB0-0x0000000180298FC0
		}
	
		public class ImpulseEvent // TypeDefIndex: 7397
		{
			// Fields
			[Tooltip] // 0x000000018016BB40-0x000000018016BB70
			public float m_StartTime; // 0x10
			[Tooltip] // 0x000000018016BDA0-0x000000018016BDD0
			public EnvelopeDefinition m_Envelope; // 0x18
			[Tooltip] // 0x000000018016C050-0x000000018016C080
			public ISignalSource6D m_SignalSource; // 0x38
			[Tooltip] // 0x000000018016C270-0x000000018016C2A0
			public Vector3 m_Position; // 0x40
			[Tooltip] // 0x000000018016C440-0x000000018016C470
			public float m_Radius; // 0x4C
			[Tooltip] // 0x000000018016C670-0x000000018016C6A0
			public DirectionMode m_DirectionMode; // 0x50
			[Tooltip] // 0x000000018016C700-0x000000018016C730
			public int m_Channel; // 0x54
			[Tooltip] // 0x000000018016C960-0x000000018016C990
			public DissipationMode m_DissipationMode; // 0x58
			[Tooltip] // 0x000000018016DCF0-0x000000018016DD20
			public float m_DissipationDistance; // 0x5C
	
			// Properties
			public bool Expired { get; } // 0x00000001817E7570-0x00000001817E75C0 
	
			// Nested types
			public enum DirectionMode // TypeDefIndex: 7398
			{
				Fixed = 0,
				RotateTowardSource = 1
			}
	
			public enum DissipationMode // TypeDefIndex: 7399
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2
			}
	
			// Constructors
			internal ImpulseEvent(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public float DistanceDecay(float distance); // 0x00000001817E6CE0-0x00000001817E6E70
			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot); // 0x00000001817E6E70-0x00000001817E7570
			public void Clear(); // 0x00000001817E6C40-0x00000001817E6CE0
		}
	
		// Constructors
		private CinemachineImpulseManager(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot); // 0x00000001817CF6D0-0x00000001817CFA70
		public ImpulseEvent NewImpulseEvent(); // 0x00000001817CFA70-0x00000001817CFB30
		public void AddImpulseEvent(ImpulseEvent e); // 0x00000001817CF630-0x00000001817CF6D0
	}
}
