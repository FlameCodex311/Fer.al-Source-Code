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
	[DocumentationSorting] // 0x00000001800B6700-0x00000001800B6720
	public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D // TypeDefIndex: 7377
	{
		// Properties
		public abstract float SignalDuration { get; }
	
		// Constructors
		protected SignalSourceAsset(); // 0x00000001803A2BB0-0x00000001803A2BC0
	
		// Methods
		public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}
}
