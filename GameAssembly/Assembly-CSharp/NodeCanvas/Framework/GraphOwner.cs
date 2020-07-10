/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	public abstract class GraphOwner : MonoBehaviour // TypeDefIndex: 14564
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string boundGraphSerialization; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<UnityEngine.Object> boundGraphObjectReferences; // 0x28
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public EnableAction enableAction; // 0x30
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public DisableAction disableAction; // 0x34
		public static Action<GraphOwner> onOwnerBehaviourStateChange; // 0x00
		private Dictionary<Graph, Graph> instances; // 0x38
		private bool initialized; // 0x40
		private bool startCalled; // 0x41
		private static bool isQuiting; // 0x08
	
		// Properties
		public abstract Graph graph { get; set; }
		public abstract IBlackboard blackboard { get; set; }
		public abstract Type graphType { get; }
		public bool isRunning { get; } // 0x00000001817537F0-0x00000001817538A0 
		public bool isPaused { get; } // 0x0000000181753740-0x00000001817537F0 
		public float elapsedTime { get; } // 0x0000000181753670-0x0000000181753740 
	
		// Nested types
		public enum EnableAction // TypeDefIndex: 14565
		{
			EnableBehaviour = 0,
			DoNothing = 1
		}
	
		public enum DisableAction // TypeDefIndex: 14566
		{
			DisableBehaviour = 0,
			PauseBehaviour = 1,
			DoNothing = 2
		}
	
		// Constructors
		protected GraphOwner(); // 0x0000000181753610-0x0000000181753670
	
		// Methods
		protected Graph GetInstance(Graph originalGraph); // 0x00000001817527E0-0x0000000181752930
		public void StartBehaviour(); // 0x00000001817532F0-0x0000000181753300
		public void StartBehaviour(Action<bool> callback); // 0x00000001817532E0-0x00000001817532F0
		public void StartBehaviour(bool autoUpdate, Action<bool> callback); // 0x0000000181753300-0x0000000181753450
		public void PauseBehaviour(); // 0x0000000181753020-0x00000001817530F0
		public void StopBehaviour(bool success = true /* Metadata: 0x00784603 */); // 0x0000000181753470-0x0000000181753550
		public void UpdateBehaviour(); // 0x0000000181753550-0x0000000181753610
		public void RestartBehaviour(); // 0x00000001817530F0-0x0000000181753120
		public void SendEvent(string eventName); // 0x0000000181753120-0x0000000181753210
		public void SendEvent<T>(string eventName, T eventValue);
		public void SendEvent(EventData eventData, object sender); // 0x0000000181753210-0x00000001817532E0
		public void Initialize(); // 0x0000000181752930-0x0000000181752BF0
		protected void Awake(); // 0x00000001817527D0-0x00000001817527E0
		protected void OnEnable(); // 0x0000000181753000-0x0000000181753020
		protected void Start(); // 0x0000000181753450-0x0000000181753470
		protected void OnDisable(); // 0x0000000181752EE0-0x0000000181753000
		protected void OnDestroy(); // 0x0000000181752C30-0x0000000181752EE0
		protected void OnApplicationQuit(); // 0x0000000181752BF0-0x0000000181752C30
	}
}
