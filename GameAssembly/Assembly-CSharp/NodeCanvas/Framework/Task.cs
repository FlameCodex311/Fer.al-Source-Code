/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class Task : ISubParametersContainer // TypeDefIndex: 14597
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _isDisabled; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TaskAgentParameter overrideAgent; // 0x18
		[NonSerialized]
		private IBlackboard _blackboard; // 0x20
		[NonSerialized]
		private ITaskSystem _ownerSystem; // 0x28
		[NonSerialized]
		private Component current; // 0x30
		[NonSerialized]
		private string _taskName; // 0x38
		[NonSerialized]
		private string _taskDescription; // 0x40
		[NonSerialized]
		private string _obsoleteInfo; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <firstWarningMessage>k__BackingField; // 0x50
	
		// Properties
		public ITaskSystem ownerSystem { get; private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public Component ownerAgent { get; } // 0x0000000181760480-0x0000000181760530 
		public IBlackboard ownerBlackboard { get; } // 0x0000000181760530-0x0000000181760580 
		protected float ownerElapsedTime { get; } // 0x0000000181760580-0x0000000181760640 
		public bool isActive { get; set; } // 0x0000000180B7E080-0x0000000180B7E090 0x0000000180F53280-0x0000000180F53290
		public string obsolete { get; } // 0x00000001817603C0-0x0000000181760470 
		public string name { get; } // 0x00000001817602C0-0x00000001817603C0 
		public string description { get; } // 0x0000000181760210-0x00000001817602C0 
		public virtual Type agentType { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public string summaryInfo { get; } // 0x0000000181760640-0x0000000181760820 
		protected virtual string info { get; } // 0x00000001817602C0-0x00000001817603C0 
		public string agentInfo { get; } // 0x0000000181760020-0x0000000181760070 
		public bool agentIsOverride { get; set; } // 0x0000000180C1ECA0-0x0000000180C1ECB0 0x0000000181760820-0x00000001817608E0
		public string overrideAgentParameterName { get; } // 0x0000000181760470-0x0000000181760480 
		public Component agent { get; } // 0x0000000181760070-0x0000000181760210 
		public IBlackboard blackboard { get; private set; } // 0x000000018036AC70-0x000000018036AC80 0x00000001817608E0-0x0000000181760930
		public string firstWarningMessage { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
	
		// Nested types
		[AttributeUsage] // 0x00000001800C1DA0-0x00000001800C1DC0
		protected class EventReceiverAttribute : Attribute // TypeDefIndex: 14598
		{
			// Fields
			public readonly string[] eventMessages; // 0x10
	
			// Constructors
			public EventReceiverAttribute(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] args); // 0x00000001805A9650-0x00000001805A9680
		}
	
		[AttributeUsage] // 0x00000001800C23C0-0x00000001800C23E0
		protected class GetFromAgentAttribute : Attribute // TypeDefIndex: 14599
		{
			// Constructors
			public GetFromAgentAttribute(); // 0x000000018037E800-0x000000018037E810
		}
	
		// Constructors
		public Task(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x000000018175F510-0x000000018175F5D0
		public static T Create<T>(ITaskSystem newOwnerSystem)
			where T : Task;
		public static Task Create(Type type, ITaskSystem newOwnerSystem); // 0x000000018175E660-0x000000018175E7B0
		public virtual Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018175E7B0-0x000000018175E8B0
		public virtual void OnCreate(ITaskSystem ownerSystem); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnValidate(ITaskSystem ownerSystem); // 0x00000001803581E0-0x00000001803581F0
		public void SetOwnerSystem(ITaskSystem newOwnerSystem); // 0x000000018175F890-0x000000018175F910
		protected Coroutine StartCoroutine(IEnumerator routine); // 0x000000018175C630-0x000000018175C660
		protected void StopCoroutine(Coroutine routine); // 0x000000018175C660-0x000000018175C690
		protected void SendEvent(EventData eventData); // 0x000000018175F7D0-0x000000018175F890
		protected virtual string OnInit(); // 0x000000018035FCC0-0x000000018035FCD0
		protected bool Set(Component newAgent, IBlackboard newBB); // 0x000000018175F910-0x000000018175FAF0
		private static Component TransformAgent(Component input, Type type); // 0x000000018175FB00-0x000000018175FCA0
		private bool Initialize(Component newAgent); // 0x000000018175ECC0-0x000000018175EF50
		private bool InitializeAttributes(Component newAgent); // 0x000000018175EA00-0x000000018175ECC0
		protected bool Error(string error); // 0x000000018175E8B0-0x000000018175E9E0
		public void RegisterEvent(string eventName); // 0x000000018175F5D0-0x000000018175F690
		public void RegisterEvents(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] eventNames); // 0x000000018175F690-0x000000018175F7D0
		public void UnRegisterEvent(string eventName); // 0x000000018175FD90-0x000000018175FF20
		public void UnRegisterEvents(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] eventNames); // 0x000000018175FF20-0x0000000181760020
		public void UnRegisterAllEvents(); // 0x000000018175FCA0-0x000000018175FD90
		public string GetWarning(); // 0x000000018175E9E0-0x000000018175EA00
		private string Internal_GetWarning(); // 0x000000018175EF50-0x000000018175F510
		public override string ToString(); // 0x000000018175FAF0-0x000000018175FB00
		public virtual void OnDrawGizmos(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnDrawGizmosSelected(); // 0x00000001803581E0-0x00000001803581F0
	}
}
