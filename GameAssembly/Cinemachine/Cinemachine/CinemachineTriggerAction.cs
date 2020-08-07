/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[DocumentationSorting] // 0x0000000180205D10-0x0000000180205D40
	[SaveDuringPlay] // 0x0000000180205D10-0x0000000180205D40
	public class CinemachineTriggerAction : UnityEngine.MonoBehaviour // TypeDefIndex: 7547
	{
		// Fields
		[Header] // 0x0000000180205F90-0x0000000180205FF0
		[Tooltip] // 0x0000000180205F90-0x0000000180205FF0
		public LayerMask m_LayerMask; // 0x18
		[TagField] // 0x0000000180206420-0x0000000180206460
		[Tooltip] // 0x0000000180206420-0x0000000180206460
		public string m_WithTag; // 0x20
		[TagField] // 0x00000001802066A0-0x00000001802066F0
		[Tooltip] // 0x00000001802066A0-0x00000001802066F0
		public string m_WithoutTag; // 0x28
		[NoSaveDuringPlay] // 0x0000000180206850-0x0000000180206890
		[Tooltip] // 0x0000000180206850-0x0000000180206890
		public int m_SkipFirst; // 0x30
		[Tooltip] // 0x0000000180206B70-0x0000000180206BA0
		public bool m_Repeating; // 0x34
		public ActionSettings m_OnObjectEnter; // 0x38
		public ActionSettings m_OnObjectExit; // 0x60
		private HashSet<GameObject> m_ActiveTriggerObjects; // 0x88
	
		// Nested types
		[Serializable]
		public struct ActionSettings // TypeDefIndex: 7548
		{
			// Fields
			[Tooltip] // 0x0000000180206E60-0x0000000180206E90
			public Mode m_Action; // 0x00
			[Tooltip] // 0x0000000180207180-0x00000001802071B0
			public UnityEngine.Object m_Target; // 0x08
			[Tooltip] // 0x0000000180207470-0x00000001802074A0
			public int m_BoostAmount; // 0x10
			[Tooltip] // 0x0000000180207660-0x0000000180207690
			public float m_StartTime; // 0x14
			[Tooltip] // 0x00000001802077C0-0x00000001802077F0
			public TimeMode m_Mode; // 0x18
			[Tooltip] // 0x0000000180207AE0-0x0000000180207B10
			public TriggerEvent m_Event; // 0x20
	
			// Nested types
			public enum Mode // TypeDefIndex: 7549
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
			public class TriggerEvent : UnityEvent // TypeDefIndex: 7550
			{
				// Constructors
				public TriggerEvent(); // 0x0000000180372000-0x0000000180372010
			}
	
			public enum TimeMode // TypeDefIndex: 7551
			{
				FromStart = 0,
				FromEnd = 1,
				BeforeNow = 2,
				AfterNow = 3
			}
	
			// Constructors
			public ActionSettings(Mode action); // 0x00000001800C1350-0x00000001800C13E0
	
			// Methods
			public void Invoke(); // 0x00000001800C1340-0x00000001800C1350
		}
	
		// Constructors
		public CinemachineTriggerAction(); // 0x000000018139BB70-0x000000018139BD10
	
		// Methods
		private bool Filter(GameObject other); // 0x000000018139B780-0x000000018139B840
		private void InternalDoTriggerEnter(GameObject other); // 0x000000018139B840-0x000000018139B950
		private void InternalDoTriggerExit(GameObject other); // 0x000000018139B950-0x000000018139B9F0
		private void OnTriggerEnter(Collider other); // 0x000000018139BAF0-0x000000018139BB30
		private void OnTriggerExit(Collider other); // 0x000000018139BB30-0x000000018139BB70
		private void OnCollisionEnter(Collision other); // 0x000000018139BA30-0x000000018139BA70
		private void OnCollisionExit(Collision other); // 0x000000018139BAB0-0x000000018139BAF0
		private void OnTriggerEnter2D(Collider2D other); // 0x000000018139BAF0-0x000000018139BB30
		private void OnTriggerExit2D(Collider2D other); // 0x000000018139BB30-0x000000018139BB70
		private void OnCollisionEnter2D(Collision2D other); // 0x000000018139B9F0-0x000000018139BA30
		private void OnCollisionExit2D(Collision2D other); // 0x000000018139BA70-0x000000018139BAB0
		private void OnEnable(); // 0x00000001803774A0-0x00000001803774B0
	}
}
