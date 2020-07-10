/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[DocumentationSorting] // 0x000000018011FBE0-0x000000018011FC10
	[SaveDuringPlay] // 0x000000018011FBE0-0x000000018011FC10
	public class CinemachineTriggerAction : UnityEngine.MonoBehaviour // TypeDefIndex: 7381
	{
		// Fields
		[Header] // 0x0000000180163510-0x0000000180163570
		[Tooltip] // 0x0000000180163510-0x0000000180163570
		public LayerMask m_LayerMask; // 0x18
		[TagField] // 0x00000001801636A0-0x00000001801636E0
		[Tooltip] // 0x00000001801636A0-0x00000001801636E0
		public string m_WithTag; // 0x20
		[TagField] // 0x00000001801639B0-0x0000000180163A00
		[Tooltip] // 0x00000001801639B0-0x0000000180163A00
		public string m_WithoutTag; // 0x28
		[NoSaveDuringPlay] // 0x0000000180163D10-0x0000000180163D50
		[Tooltip] // 0x0000000180163D10-0x0000000180163D50
		public int m_SkipFirst; // 0x30
		[Tooltip] // 0x0000000180163F80-0x0000000180163FB0
		public bool m_Repeating; // 0x34
		public ActionSettings m_OnObjectEnter; // 0x38
		public ActionSettings m_OnObjectExit; // 0x60
		private HashSet<GameObject> m_ActiveTriggerObjects; // 0x88
	
		// Nested types
		[Serializable]
		public struct ActionSettings // TypeDefIndex: 7382
		{
			// Fields
			[Tooltip] // 0x0000000180164110-0x0000000180164140
			public Mode m_Action; // 0x00
			[Tooltip] // 0x0000000180164460-0x0000000180164490
			public UnityEngine.Object m_Target; // 0x08
			[Tooltip] // 0x0000000180164570-0x00000001801645A0
			public int m_BoostAmount; // 0x10
			[Tooltip] // 0x0000000180164840-0x0000000180164870
			public float m_StartTime; // 0x14
			[Tooltip] // 0x0000000180164BA0-0x0000000180164BD0
			public TimeMode m_Mode; // 0x18
			[Tooltip] // 0x0000000180164D20-0x0000000180164D50
			public TriggerEvent m_Event; // 0x20
	
			// Nested types
			public enum Mode // TypeDefIndex: 7383
			{
				Custom = 0,
				PriorityBoost = 1,
				Activate = 2,
				Deactivate = 3,
				Enable = 4,
				Disable = 5,
				Play = 6,
				Stop = 7
			}
	
			[Serializable]
			public class TriggerEvent : UnityEvent // TypeDefIndex: 7384
			{
				// Constructors
				public TriggerEvent(); // 0x0000000180E3CEA0-0x0000000180E3CEB0
			}
	
			public enum TimeMode // TypeDefIndex: 7385
			{
				FromStart = 0,
				FromEnd = 1,
				BeforeNow = 2,
				AfterNow = 3
			}
	
			// Constructors
			public ActionSettings(Mode action); // 0x0000000180298ED0-0x0000000180298F60
	
			// Methods
			public void Invoke(); // 0x0000000180298EC0-0x0000000180298ED0
		}
	
		// Constructors
		public CinemachineTriggerAction(); // 0x00000001817E1630-0x00000001817E17D0
	
		// Methods
		private bool Filter(GameObject other); // 0x00000001817E1230-0x00000001817E12F0
		private void InternalDoTriggerEnter(GameObject other); // 0x00000001817E12F0-0x00000001817E1410
		private void InternalDoTriggerExit(GameObject other); // 0x00000001817E1410-0x00000001817E14B0
		private void OnTriggerEnter(Collider other); // 0x00000001817E15B0-0x00000001817E15F0
		private void OnTriggerExit(Collider other); // 0x00000001817E15F0-0x00000001817E1630
		private void OnCollisionEnter(Collision other); // 0x00000001817E14F0-0x00000001817E1530
		private void OnCollisionExit(Collision other); // 0x00000001817E1570-0x00000001817E15B0
		private void OnTriggerEnter2D(Collider2D other); // 0x00000001817E15B0-0x00000001817E15F0
		private void OnTriggerExit2D(Collider2D other); // 0x00000001817E15F0-0x00000001817E1630
		private void OnCollisionEnter2D(Collision2D other); // 0x00000001817E14B0-0x00000001817E14F0
		private void OnCollisionExit2D(Collision2D other); // 0x00000001817E1530-0x00000001817E1570
		private void OnEnable(); // 0x00000001803581E0-0x00000001803581F0
	}
}
