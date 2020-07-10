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
	[DocumentationSorting] // 0x000000018011FBE0-0x000000018011FC10
	[SaveDuringPlay] // 0x000000018011FBE0-0x000000018011FC10
	public class CinemachineImpulseSource : UnityEngine.MonoBehaviour // TypeDefIndex: 7400
	{
		// Fields
		[CinemachineImpulseDefinitionProperty] // 0x00000001800BDB50-0x00000001800BDB60
		public CinemachineImpulseDefinition m_ImpulseDefinition; // 0x18
	
		// Constructors
		public CinemachineImpulseSource(); // 0x00000001817CFDF0-0x00000001817CFEC0
	
		// Methods
		private void OnValidate(); // 0x00000001817CFD50-0x00000001817CFDF0
		public void GenerateImpulseAt(Vector3 position, Vector3 velocity); // 0x00000001817CFBB0-0x00000001817CFC00
		public void GenerateImpulse(Vector3 velocity); // 0x00000001817CFCD0-0x00000001817CFD50
		public void GenerateImpulse(); // 0x00000001817CFC00-0x00000001817CFCD0
	}
}
