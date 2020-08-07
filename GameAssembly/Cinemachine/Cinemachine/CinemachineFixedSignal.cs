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
	[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
	public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 7553
	{
		// Fields
		[Tooltip] // 0x0000000180208DA0-0x0000000180208DD0
		public AnimationCurve m_XCurve; // 0x18
		[Tooltip] // 0x0000000180208F80-0x0000000180208FB0
		public AnimationCurve m_YCurve; // 0x20
		[Tooltip] // 0x0000000180209100-0x0000000180209130
		public AnimationCurve m_ZCurve; // 0x28
	
		// Properties
		public override float SignalDuration { get; } // 0x000000018135FBE0-0x000000018135FCA0 
	
		// Constructors
		public CinemachineFixedSignal(); // 0x000000018069E0F0-0x000000018069E100
	
		// Methods
		private float AxisDuration(AnimationCurve axis); // 0x000000018135F940-0x000000018135FA20
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x000000018135FA70-0x000000018135FBE0
		private float AxisValue(AnimationCurve axis, float time); // 0x000000018135FA20-0x000000018135FA70
	}
}
