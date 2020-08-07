/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[CreateAssetMenu] // 0x00000001801FAC30-0x00000001801FACC0
	[GraphInfo] // 0x00000001801FAC30-0x00000001801FACC0
	public class DialogueTree : Graph // TypeDefIndex: 15101
	{
		// Fields
		public const string INSTIGATOR_NAME = "INSTIGATOR"; // Metadata: 0x007BB16F
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<ActorParameter> actorParameters; // 0x98
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<DialogueTree> OnDialogueStarted; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<DialogueTree> OnDialoguePaused; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<DialogueTree> OnDialogueFinished; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<SubtitlesRequestInfo> OnSubtitlesRequest; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static DialogueTree <currentDialogue>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static DialogueTree <previousDialogue>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DTNode <currentNode>k__BackingField; // 0xA0
	
		// Properties
		public static DialogueTree currentDialogue { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001808A58F0-0x00000001808A5930 0x00000001808A5E10-0x00000001808A5E50
		public static DialogueTree previousDialogue { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001808A5A60-0x00000001808A5AA0 0x00000001808A5E50-0x00000001808A5E90
		public DTNode currentNode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460
		public override Type baseNodeType { get; } // 0x00000001808A5890-0x00000001808A58F0 
		public override bool requiresAgent { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool requiresPrimeNode { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool isTree { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool allowBlackboardOverrides { get; } // 0x0000000180380B60-0x0000000180380B70 
		public sealed override bool canAcceptVariableDrops { get; } // 0x0000000180380950-0x0000000180380960 
		public List<string> definedActorParameterNames { get; } // 0x00000001808A5930-0x00000001808A5A60 
	
		// Events
		public static event Action<DialogueTree> OnDialogueStarted {
			add; // 0x00000001808A5680-0x00000001808A5730
			remove; // 0x00000001808A5C00-0x00000001808A5CB0
		}
		public static event Action<DialogueTree> OnDialoguePaused {
			add; // 0x00000001808A55D0-0x00000001808A5680
			remove; // 0x00000001808A5B50-0x00000001808A5C00
		}
		public static event Action<DialogueTree> OnDialogueFinished {
			add; // 0x00000001808A5520-0x00000001808A55D0
			remove; // 0x00000001808A5AA0-0x00000001808A5B50
		}
		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest {
			add; // 0x00000001808A57E0-0x00000001808A5890
			remove; // 0x00000001808A5D60-0x00000001808A5E10
		}
		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest {
			add; // 0x00000001808A5730-0x00000001808A57E0
			remove; // 0x00000001808A5CB0-0x00000001808A5D60
		}
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 15102
		{
			// Fields
			public List<ActorParameter> actorParameters; // 0x10
	
			// Constructors
			public DerivedSerializationData(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		public class ActorParameter // TypeDefIndex: 15103
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string _keyName; // 0x10
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string _id; // 0x18
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private UnityEngine.Object _actorObject; // 0x20
			[NonSerialized]
			private IDialogueActor _actor; // 0x28
	
			// Properties
			public string name { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public string ID { get; } // 0x000000018089F080-0x000000018089F110 
			public IDialogueActor actor { get; set; } // 0x000000018089F110-0x000000018089F160 0x000000018089F160-0x000000018089F1E0
	
			// Constructors
			public ActorParameter(); // 0x0000000180373240-0x0000000180373250
			public ActorParameter(string name); // 0x0000000180400150-0x0000000180400180
			public ActorParameter(string name, IDialogueActor actor); // 0x000000018089EFE0-0x000000018089F080
	
			// Methods
			public override string ToString(); // 0x0000000180372440-0x0000000180372450
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15104
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ActorParameter, string> <>9__46_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001808B7AC0-0x00000001808B7B20
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <get_definedActorParameterNames>b__46_0(ActorParameter r); // 0x0000000180386C00-0x0000000180386C20
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass47_0 // TypeDefIndex: 15105
		{
			// Fields
			public string id; // 0x10
	
			// Constructors
			public <>c__DisplayClass47_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetParameterByID>b__0(ActorParameter p); // 0x00000001808B7A30-0x00000001808B7A70
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 15106
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public <>c__DisplayClass48_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetParameterByName>b__0(ActorParameter p); // 0x00000001803E2140-0x00000001803E2170
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass50_0 // TypeDefIndex: 15107
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public <>c__DisplayClass50_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetActorReferenceByName>b__0(ActorParameter r); // 0x00000001803E2140-0x00000001803E2170
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass51_0 // TypeDefIndex: 15108
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public <>c__DisplayClass51_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <SetActorReference>b__0(ActorParameter p); // 0x00000001803E2140-0x00000001803E2170
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass52_0 // TypeDefIndex: 15109
		{
			// Fields
			public KeyValuePair<string, IDialogueActor> pair; // 0x10
	
			// Constructors
			public <>c__DisplayClass52_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <SetActorReferences>b__0(ActorParameter p); // 0x00000001808B7A70-0x00000001808B7AC0
		}
	
		// Constructors
		public DialogueTree(); // 0x00000001808A5480-0x00000001808A5520
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x00000001808A4AF0-0x00000001808A4B60
		public override void OnDerivedDataDeserialization(object data); // 0x00000001808A49E0-0x00000001808A4AF0
		public ActorParameter GetParameterByID(string id); // 0x00000001808A4860-0x00000001808A4920
		public ActorParameter GetParameterByName(string paramName); // 0x00000001808A4920-0x00000001808A49E0
		public IDialogueActor GetActorReferenceByID(string id); // 0x00000001808A4590-0x00000001808A45C0
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x00000001808A45C0-0x00000001808A4860
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x00000001808A5160-0x00000001808A52A0
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x00000001808A52A0-0x00000001808A5480
		public void Continue(int index = 0 /* Metadata: 0x007BB16B */); // 0x00000001808A4300-0x00000001808A4510
		public void EnterNode(DTNode node); // 0x00000001808A4510-0x00000001808A4590
		public static void RequestSubtitles(SubtitlesRequestInfo info); // 0x00000001808A5080-0x00000001808A50E0
		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info); // 0x00000001808A5020-0x00000001808A5080
		protected override void OnGraphStarted(); // 0x00000001808A4BC0-0x00000001808A4D70
		protected override void OnGraphUpdate(); // 0x00000001808A4F90-0x00000001808A5020
		protected override void OnGraphStoped(); // 0x00000001808A4D70-0x00000001808A4E60
		protected override void OnGraphPaused(); // 0x00000001808A4B60-0x00000001808A4BC0
		protected override void OnGraphUnpaused(); // 0x00000001808A4E60-0x00000001808A4F90
		[CoreResetTarget] // 0x00000001801FEF10-0x00000001801FEF40
		[RuntimeInitializeOnLoadMethod] // 0x00000001801FEF10-0x00000001801FEF40
		public static void ResetStaticVariables(); // 0x00000001808A50E0-0x00000001808A5160
	}
}
