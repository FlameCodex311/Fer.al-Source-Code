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
	[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
	public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 7387
	{
		// Fields
		[Tooltip] // 0x0000000180165F60-0x0000000180165F90
		public AnimationCurve m_XCurve; // 0x18
		[Tooltip] // 0x0000000180166190-0x00000001801661C0
		public AnimationCurve m_YCurve; // 0x20
		[Tooltip] // 0x00000001801676A0-0x00000001801676D0
		public AnimationCurve m_ZCurve; // 0x28
	
		// Properties
		public override float SignalDuration { get; } // 0x00000001818B9910-0x00000001818B99D0 
	
		// Constructors
		public CinemachineFixedSignal(); // 0x00000001805E3F50-0x00000001805E3F60
	
		// Methods
		private float AxisDuration(AnimationCurve axis); // 0x00000001818B9670-0x00000001818B9750
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001818B97A0-0x00000001818B9910
		private float AxisValue(AnimationCurve axis, float time); // 0x00000001818B9750-0x00000001818B97A0
	}
}
