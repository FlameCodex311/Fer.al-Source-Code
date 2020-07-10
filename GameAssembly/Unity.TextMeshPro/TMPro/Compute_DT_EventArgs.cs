/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public class Compute_DT_EventArgs // TypeDefIndex: 8879
	{
		// Fields
		public Compute_DistanceTransform_EventTypes EventType; // 0x10
		public float ProgressPercentage; // 0x14
		public Color[] Colors; // 0x18
	
		// Constructors
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress); // 0x00000001810BDE50-0x00000001810BDE90
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors); // 0x0000000180393700-0x0000000180393740
	}
}
