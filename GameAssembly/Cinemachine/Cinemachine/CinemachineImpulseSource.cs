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
	[DocumentationSorting] // 0x0000000180205D10-0x0000000180205D40
	[SaveDuringPlay] // 0x0000000180205D10-0x0000000180205D40
	public class CinemachineImpulseSource : UnityEngine.MonoBehaviour // TypeDefIndex: 7566
	{
		// Fields
		[CinemachineImpulseDefinitionProperty] // 0x00000001801CEA70-0x00000001801CEA80
		public CinemachineImpulseDefinition m_ImpulseDefinition; // 0x18
	
		// Constructors
		public CinemachineImpulseSource(); // 0x000000018138BEE0-0x000000018138BFB0
	
		// Methods
		private void OnValidate(); // 0x000000018138BE40-0x000000018138BEE0
		public void GenerateImpulseAt(Vector3 position, Vector3 velocity); // 0x000000018138BCA0-0x000000018138BCF0
		public void GenerateImpulse(Vector3 velocity); // 0x000000018138BDC0-0x000000018138BE40
		public void GenerateImpulse(); // 0x000000018138BCF0-0x000000018138BDC0
	}
}
