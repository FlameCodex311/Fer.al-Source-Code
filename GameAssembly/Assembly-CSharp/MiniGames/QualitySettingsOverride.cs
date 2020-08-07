/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace MiniGames
{
	public class QualitySettingsOverride : MonoBehaviour // TypeDefIndex: 16356
	{
		// Fields
		public OverrideValues overrides; // 0x20
		private OverrideValues _savedValues; // 0x28
	
		// Nested types
		[Serializable]
		public class OverrideValues // TypeDefIndex: 16357
		{
			// Fields
			public float shadowDistance; // 0x10
			public ShadowProjection shadowProjectionOverride; // 0x14
	
			// Constructors
			public OverrideValues(); // 0x0000000180C12AE0-0x0000000180C12B00
		}
	
		// Constructors
		public QualitySettingsOverride(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Start(); // 0x0000000180C12C80-0x0000000180C12D40
		private void OnDestroy(); // 0x0000000180C12C30-0x0000000180C12C80
	}
}
