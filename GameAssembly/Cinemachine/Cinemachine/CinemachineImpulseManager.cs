/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[DocumentationSorting] // 0x00000001801E4110-0x00000001801E4130
	public class CinemachineImpulseManager // TypeDefIndex: 7561
	{
		// Fields
		private static CinemachineImpulseManager sInstance; // 0x00
		private List<ImpulseEvent> m_ExpiredEvents; // 0x10
		private List<ImpulseEvent> m_ActiveEvents; // 0x18
	
		// Properties
		public static CinemachineImpulseManager Instance { get; } // 0x000000018138BC20-0x000000018138BCA0 
	
		// Nested types
		[Serializable]
		public struct EnvelopeDefinition // TypeDefIndex: 7562
		{
			// Fields
			[Tooltip] // 0x000000018020B590-0x000000018020B5C0
			public AnimationCurve m_AttackShape; // 0x00
			[Tooltip] // 0x000000018020B710-0x000000018020B740
			public AnimationCurve m_DecayShape; // 0x08
			[Tooltip] // 0x000000018020B8A0-0x000000018020B8D0
			public float m_AttackTime; // 0x10
			[Tooltip] // 0x000000018020BA70-0x000000018020BAA0
			public float m_SustainTime; // 0x14
			[Tooltip] // 0x000000018020BC40-0x000000018020BC70
			public float m_DecayTime; // 0x18
			[Tooltip] // 0x000000018020BDB0-0x000000018020BDE0
			public bool m_ScaleWithImpact; // 0x1C
			[Tooltip] // 0x000000018020BFC0-0x000000018020BFF0
			public bool m_HoldForever; // 0x1D
	
			// Properties
			public float Duration { get; } // 0x00000001800C1440-0x00000001800C15B0 
	
			// Methods
			public static EnvelopeDefinition Default(); // 0x000000018139E5C0-0x000000018139E7D0
			public float GetValueAt(float offset); // 0x00000001800C1420-0x00000001800C1430
			public void Clear(); // 0x00000001800C1400-0x00000001800C1420
			public void Validate(); // 0x00000001800C1430-0x00000001800C1440
		}
	
		public class ImpulseEvent // TypeDefIndex: 7563
		{
			// Fields
			[Tooltip] // 0x000000018020C200-0x000000018020C230
			public float m_StartTime; // 0x10
			[Tooltip] // 0x000000018020C370-0x000000018020C3A0
			public EnvelopeDefinition m_Envelope; // 0x18
			[Tooltip] // 0x000000018020C550-0x000000018020C580
			public ISignalSource6D m_SignalSource; // 0x38
			[Tooltip] // 0x000000018020C820-0x000000018020C850
			public Vector3 m_Position; // 0x40
			[Tooltip] // 0x000000018020DD40-0x000000018020DD70
			public float m_Radius; // 0x4C
			[Tooltip] // 0x000000018020DFD0-0x000000018020E000
			public DirectionMode m_DirectionMode; // 0x50
			[Tooltip] // 0x000000018020E220-0x000000018020E250
			public int m_Channel; // 0x54
			[Tooltip] // 0x000000018020E4D0-0x000000018020E500
			public DissipationMode m_DissipationMode; // 0x58
			[Tooltip] // 0x000000018020E780-0x000000018020E7B0
			public float m_DissipationDistance; // 0x5C
	
			// Properties
			public bool Expired { get; } // 0x000000018139F0F0-0x000000018139F140 
	
			// Nested types
			public enum DirectionMode // TypeDefIndex: 7564
			{
				Fixed = 0,
				RotateTowardSource = 1
			}
	
			public enum DissipationMode // TypeDefIndex: 7565
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2
			}
	
			// Constructors
			internal ImpulseEvent(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public float DistanceDecay(float distance); // 0x000000018139E870-0x000000018139EA00
			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot); // 0x000000018139EA00-0x000000018139F0F0
			public void Clear(); // 0x000000018139E7D0-0x000000018139E870
		}
	
		// Constructors
		private CinemachineImpulseManager(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot); // 0x000000018138B7C0-0x000000018138BB60
		public ImpulseEvent NewImpulseEvent(); // 0x000000018138BB60-0x000000018138BC20
		public void AddImpulseEvent(ImpulseEvent e); // 0x000000018138B720-0x000000018138B7C0
	}
}
