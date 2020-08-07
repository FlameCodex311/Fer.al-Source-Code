/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public abstract class GraphOwner : ManagedBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 15688
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializationPair[] _serializedExposedParameters; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<ExposedParameter> <exposedParameters>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<GraphOwner> onOwnerBehaviourStateChange; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action onMonoBehaviourStart; // 0x60
		[FormerlySerializedAs] // 0x000000018020C1C0-0x000000018020C200
		[SerializeField] // 0x000000018020C1C0-0x000000018020C200
		private string _boundGraphSerialization; // 0x68
		[FormerlySerializedAs] // 0x000000018020C3D0-0x000000018020C410
		[SerializeField] // 0x000000018020C3D0-0x000000018020C410
		private List<UnityEngine.Object> _boundGraphObjectReferences; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GraphSource _boundGraphSource; // 0x78
		[FormerlySerializedAs] // 0x000000018020DBD0-0x000000018020DC40
		[SerializeField] // 0x000000018020DBD0-0x000000018020DC40
		[Tooltip] // 0x000000018020DBD0-0x000000018020DC40
		private FirstActivation _firstActivation; // 0x80
		[FormerlySerializedAs] // 0x000000018020E030-0x000000018020E0A0
		[SerializeField] // 0x000000018020E030-0x000000018020E0A0
		[Tooltip] // 0x000000018020E030-0x000000018020E0A0
		private EnableAction _enableAction; // 0x84
		[FormerlySerializedAs] // 0x000000018020E440-0x000000018020E4B0
		[SerializeField] // 0x000000018020E440-0x000000018020E4B0
		[Tooltip] // 0x000000018020E440-0x000000018020E4B0
		private DisableAction _disableAction; // 0x88
		[SerializeField] // 0x000000018020FB90-0x000000018020FBD0
		[Tooltip] // 0x000000018020FB90-0x000000018020FBD0
		private bool _lockBoundGraphPrefabOverrides; // 0x8C
		[SerializeField] // 0x000000018020FF60-0x000000018020FFA0
		[Tooltip] // 0x000000018020FF60-0x000000018020FFA0
		private bool _preInitializeSubGraphs; // 0x8D
		[SerializeField] // 0x0000000180210370-0x00000001802103B0
		[Tooltip] // 0x0000000180210370-0x00000001802103B0
		private Graph.UpdateMode _updateMode; // 0x90
		private Dictionary<Graph, Graph> instances; // 0x98
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <initialized>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <enableCalled>k__BackingField; // 0xA1
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <startCalled>k__BackingField; // 0xA2
	
		// Properties
		public List<ExposedParameter> exposedParameters { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public abstract Graph graph { get; set; }
		public abstract IBlackboard blackboard { get; set; }
		public abstract Type graphType { get; }
		public bool initialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418A20-0x0000000180418A30 0x0000000180419180-0x0000000180419190
		public bool enableCalled { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180BEC7E0-0x0000000180BEC7F0 0x0000000180CC7EB0-0x0000000180CC7EC0
		public bool startCalled { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180CC7D50-0x0000000180CC7D60 0x0000000180CC7EE0-0x0000000180CC7EF0
		public GraphSource boundGraphSource { get; private set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
		public string boundGraphSerialization { get; private set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
		public List<UnityEngine.Object> boundGraphObjectReferences { get; private set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
		public bool lockBoundGraphPrefabOverrides { get; set; } // 0x0000000180CC7D10-0x0000000180CC7D40 0x0000000180CC7EC0-0x0000000180CC7ED0
		public bool preInitializeSubGraphs { get; set; } // 0x0000000180CC7D40-0x0000000180CC7D50 0x0000000180CC7ED0-0x0000000180CC7EE0
		public FirstActivation firstActivation { get; set; } // 0x000000018082F980-0x000000018082F990 0x000000018082F210-0x000000018082F220
		public EnableAction enableAction { get; set; } // 0x0000000180779F60-0x0000000180779F70 0x0000000180779F70-0x0000000180779F80
		public DisableAction disableAction { get; set; } // 0x00000001803CCE20-0x00000001803CCE30 0x00000001803CCEB0-0x00000001803CCEC0
		public Graph.UpdateMode updateMode { get; set; } // 0x0000000180476020-0x0000000180476030 0x0000000180479490-0x00000001804794A0
		public bool graphIsBound { get; } // 0x0000000180CC7B90-0x0000000180CC7BB0 
		public bool isRunning { get; } // 0x0000000180CC7C60-0x0000000180CC7D10 
		public bool isPaused { get; } // 0x0000000180CC7BB0-0x0000000180CC7C60 
		public float elapsedTime { get; } // 0x0000000180CC7AE0-0x0000000180CC7B90 
	
		// Events
		public static event Action<GraphOwner> onOwnerBehaviourStateChange {
			add; // 0x0000000180CC7A30-0x0000000180CC7AE0
			remove; // 0x0000000180CC7E00-0x0000000180CC7EB0
		}
		public event Action onMonoBehaviourStart {
			add; // 0x0000000180CC7990-0x0000000180CC7A30
			remove; // 0x0000000180CC7D60-0x0000000180CC7E00
		}
	
		// Nested types
		public enum EnableAction // TypeDefIndex: 15689
		{
			EnableBehaviour = 0,
			DoNothing = 1
		}
	
		public enum DisableAction // TypeDefIndex: 15690
		{
			DisableBehaviour = 0,
			PauseBehaviour = 1,
			DoNothing = 2
		}
	
		public enum FirstActivation // TypeDefIndex: 15691
		{
			OnEnable = 0,
			OnStart = 1,
			Async = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass92_0<T> // TypeDefIndex: 15692
		{
			// Fields
			public string name;
	
			// Constructors
			public <>c__DisplayClass92_0();
	
			// Methods
			internal bool <SetExposedParameterValue>b__0(ExposedParameter x);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass93_0<T> // TypeDefIndex: 15693
		{
			// Fields
			public string name;
	
			// Constructors
			public <>c__DisplayClass93_0();
	
			// Methods
			internal bool <GetExposedParameterValue>b__0(ExposedParameter x);
		}
	
		// Constructors
		protected GraphOwner(); // 0x0000000180CC7790-0x0000000180CC7990
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180CC7500-0x0000000180CC76F0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000180CC7360-0x0000000180CC7500
		protected Graph GetInstance(Graph originalGraph); // 0x0000000180CC6240-0x0000000180CC6380
		public void StartBehaviour(); // 0x0000000180CC7200-0x0000000180CC7220
		public void StartBehaviour(Action<bool> callback); // 0x0000000180CC6F90-0x0000000180CC6FB0
		public void StartBehaviour(Graph.UpdateMode updateMode, Action<bool> callback = null); // 0x0000000180CC6FB0-0x0000000180CC7200
		public void PauseBehaviour(); // 0x0000000180CC6CF0-0x0000000180CC6DC0
		public void StopBehaviour(bool success = true /* Metadata: 0x007BB473 */); // 0x0000000180CC7220-0x0000000180CC7300
		public void UpdateBehaviour(); // 0x0000000180CC76F0-0x0000000180CC7790
		public void RestartBehaviour(); // 0x0000000180CC6DC0-0x0000000180CC6DF0
		public void SendEvent(string eventName); // 0x0000000180CC6DF0-0x0000000180CC6EB0
		public void SendEvent(string eventName, object value, object sender); // 0x0000000180CC6EB0-0x0000000180CC6F90
		public void SendEvent<T>(string eventName, T eventValue, object sender);
		public void SetExposedParameterValue<T>(string name, T value);
		public T GetExposedParameterValue<T>(string name);
		public override void MAwake(); // 0x0000000180CC67D0-0x0000000180CC67F0
		public void Initialize(); // 0x0000000180CC6380-0x0000000180CC67A0
		public void BindExposedParameters(); // 0x0000000180CC60F0-0x0000000180CC6240
		public override void MOnEnable(); // 0x0000000180CC6B90-0x0000000180CC6C80
		public override void MStart(); // 0x0000000180CC6C80-0x0000000180CC6CF0
		private void InvokeStartEvent(); // 0x0000000180CC67A0-0x0000000180CC67D0
		public override void MOnDisable(); // 0x0000000180CC6AA0-0x0000000180CC6B90
		public override void MOnDestroy(); // 0x0000000180CC67F0-0x0000000180CC6AA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Initialize>b__95_0(); // 0x0000000180CC7300-0x0000000180CC7360
	}
}
