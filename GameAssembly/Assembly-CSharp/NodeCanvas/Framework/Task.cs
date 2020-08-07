/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using ParadoxNotion.Services;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsDeserializeOverwrite] // 0x00000001801CDDD0-0x00000001801CDE00
	[SpoofAOT] // 0x00000001801CDDD0-0x00000001801CDE00
	public abstract class Task : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 15731
	{
		// Fields
		[fsSerializeAs] // 0x000000018021D7E0-0x000000018021D810
		private bool _isUserDisabled; // 0x10
		[fsSerializeAs] // 0x000000018021DA90-0x000000018021DAC0
		protected internal TaskAgentParameter _agentParameter; // 0x18
		private ITaskSystem _ownerSystem; // 0x20
		private Component _currentAgent; // 0x28
		private string _taskName; // 0x30
		private string _taskDescription; // 0x38
		private string _obsoleteInfo; // 0x40
		private bool _isRuntimeActive; // 0x48
		private bool _isInitSuccess; // 0x49
		private EventRouter _eventRouter; // 0x50
	
		// Properties
		public ITaskSystem ownerSystem { get; private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public Component ownerSystemAgent { get; } // 0x0000000180CD0A60-0x0000000180CD0B10 
		public IBlackboard ownerSystemBlackboard { get; } // 0x0000000180CD07A0-0x0000000180CD07F0 
		public float ownerSystemElapsedTime { get; } // 0x0000000180CD0B10-0x0000000180CD0BD0 
		public bool isUserEnabled { get; internal set; } // 0x0000000180CD09A0-0x0000000180CD09B0 0x0000000180AB0110-0x0000000180AB0120
		public string obsolete { get; } // 0x0000000180CD09B0-0x0000000180CD0A60 
		public string name { get; } // 0x0000000180CD08A0-0x0000000180CD09A0 
		public string description { get; } // 0x0000000180CD07F0-0x0000000180CD08A0 
		public string summaryInfo { get; } // 0x0000000180CD0C80-0x0000000180CD0E60 
		protected virtual string info { get; } // 0x0000000180CD08A0-0x0000000180CD09A0 
		public virtual Type agentType { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public string agentInfo { get; } // 0x0000000180CD0590-0x0000000180CD05E0 
		public string agentParameterName { get; } // 0x0000000180CD05F0-0x0000000180CD0600 
		public bool agentIsOverride { get; set; } // 0x0000000180CD05E0-0x0000000180CD05F0 0x0000000180CD0E60-0x0000000180CD0F50
		public Component agent { get; } // 0x0000000180CD0600-0x0000000180CD07A0 
		public IBlackboard blackboard { get; } // 0x0000000180CD07A0-0x0000000180CD07F0 
		public EventRouter router { get; } // 0x0000000180CD0BD0-0x0000000180CD0C80 
	
		// Nested types
		[AttributeUsage] // 0x00000001801D0B50-0x00000001801D0B70
		protected class GetFromAgentAttribute : Attribute // TypeDefIndex: 15732
		{
			// Constructors
			public GetFromAgentAttribute(); // 0x00000001803F46D0-0x00000001803F46E0
		}
	
		// Constructors
		public Task(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000180CD0430-0x0000000180CD0560
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803774A0-0x00000001803774B0
		public static T Create<T>(ITaskSystem newOwnerSystem)
			where T : Task;
		public static Task Create(Type type, ITaskSystem newOwnerSystem); // 0x0000000180CCF390-0x0000000180CCF4A0
		public virtual Task Duplicate(ITaskSystem newOwnerSystem); // 0x0000000180CCF4A0-0x0000000180CCF570
		public void Validate(ITaskSystem ownerSystem); // 0x0000000180CD0560-0x0000000180CD0590
		public void SetOwnerSystem(ITaskSystem newOwnerSystem); // 0x00000001803F70C0-0x00000001803F70D0
		protected bool Set(Component newAgent, IBlackboard newBB); // 0x0000000180CD0140-0x0000000180CD0420
		private bool Initialize(Component newAgent); // 0x0000000180CCFF30-0x0000000180CD0070
		private bool InitializeFieldAttributes(Component newAgent); // 0x0000000180CCFC60-0x0000000180CCFF30
		protected bool Error(string error, string tag = "Execution" /* Metadata: 0x007BB4BD */); // 0x0000000180380950-0x0000000180380960
		protected Coroutine StartCoroutine(IEnumerator routine); // 0x0000000180CCD300-0x0000000180CCD330
		protected void StopCoroutine(Coroutine routine); // 0x0000000180CCD330-0x0000000180CCD360
		protected void SendEvent(string name); // 0x0000000180CD0070-0x0000000180CD0140
		protected void SendEvent<T>(string name, T value);
		internal virtual string GetWarningOrError(); // 0x0000000180CCF6B0-0x0000000180CCFC60
		private string GetHardError(); // 0x0000000180CCF570-0x0000000180CCF6B0
		protected virtual string OnInit(); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual void OnCreate(ITaskSystem ownerSystem); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnValidate(ITaskSystem ownerSystem); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x000000018021DD20-0x000000018021DD50
		public virtual void OnDrawGizmos(); // 0x0000000180876F80-0x0000000180876FA0
		public virtual void OnDrawGizmosSelected(); // 0x00000001803774A0-0x00000001803774B0
		public override string ToString(); // 0x0000000180CD0420-0x0000000180CD0430
	}
}
