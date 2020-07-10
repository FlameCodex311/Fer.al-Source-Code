/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	[CreateAssetMenu] // 0x00000001800B3860-0x00000001800B38F0
	[GraphInfo] // 0x00000001800B3860-0x00000001800B38F0
	public class DialogueTree : Graph // TypeDefIndex: 14077
	{
		// Fields
		public const string INSTIGATOR_NAME = "INSTIGATOR"; // Metadata: 0x00784431
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<ActorParameter> _actorParameters; // 0x88
		private DTNode currentNode; // 0x90
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<DialogueTree> OnDialogueStarted; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<DialogueTree> OnDialoguePaused; // 0x08
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<DialogueTree> OnDialogueFinished; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<SubtitlesRequestInfo> OnSubtitlesRequest; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static DialogueTree <currentDialogue>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static DialogueTree <previousDialogue>k__BackingField; // 0x30
	
		// Properties
		public static DialogueTree currentDialogue { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181565460-0x00000001815654A0 0x0000000181565980-0x00000001815659C0
		public static DialogueTree previousDialogue { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001815655D0-0x0000000181565610 0x00000001815659C0-0x0000000181565A00
		public override Type baseNodeType { get; } // 0x0000000181565400-0x0000000181565460 
		public override bool requiresAgent { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override bool requiresPrimeNode { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool isTree { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool useLocalBlackboard { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public List<ActorParameter> actorParameters { get; } // 0x0000000180424200-0x0000000180424210 
		public List<string> definedActorParameterNames { get; } // 0x00000001815654A0-0x00000001815655D0 
	
		// Events
		public static event Action<DialogueTree> OnDialogueStarted {
			add; // 0x00000001815651F0-0x00000001815652A0
			remove; // 0x0000000181565770-0x0000000181565820
		}
		public static event Action<DialogueTree> OnDialoguePaused {
			add; // 0x0000000181565140-0x00000001815651F0
			remove; // 0x00000001815656C0-0x0000000181565770
		}
		public static event Action<DialogueTree> OnDialogueFinished {
			add; // 0x0000000181565090-0x0000000181565140
			remove; // 0x0000000181565610-0x00000001815656C0
		}
		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest {
			add; // 0x0000000181565350-0x0000000181565400
			remove; // 0x00000001815658D0-0x0000000181565980
		}
		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest {
			add; // 0x00000001815652A0-0x0000000181565350
			remove; // 0x0000000181565820-0x00000001815658D0
		}
	
		// Nested types
		[Serializable]
		private struct DerivedSerializationData // TypeDefIndex: 14078
		{
			// Fields
			public List<ActorParameter> actorParameters; // 0x00
		}
	
		[Serializable]
		public class ActorParameter // TypeDefIndex: 14079
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private string _keyName; // 0x10
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private string _id; // 0x18
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private UnityEngine.Object _actorObject; // 0x20
			[NonSerialized]
			private IDialogueActor _actor; // 0x28
	
			// Properties
			public string name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public string ID { get; } // 0x000000018155EA00-0x000000018155EA90 
			public IDialogueActor actor { get; set; } // 0x000000018155EA90-0x000000018155EAE0 0x000000018155EAE0-0x000000018155EB60
	
			// Constructors
			public ActorParameter(); // 0x000000018036B6C0-0x000000018036B6D0
			public ActorParameter(string name); // 0x000000018037D3F0-0x000000018037D420
			public ActorParameter(string name, IDialogueActor actor); // 0x000000018155E960-0x000000018155EA00
	
			// Methods
			public override string ToString(); // 0x000000018036AC80-0x000000018036AC90
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14080
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ActorParameter, string> <>9__45_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001815763F0-0x0000000181576450
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <get_definedActorParameterNames>b__45_0(ActorParameter r); // 0x000000018059C9F0-0x000000018059CA10
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass46_0 // TypeDefIndex: 14081
		{
			// Fields
			public string id; // 0x10
	
			// Constructors
			public <>c__DisplayClass46_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetParameterByID>b__0(ActorParameter p); // 0x00000001815762F0-0x0000000181576330
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass47_0 // TypeDefIndex: 14082
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public <>c__DisplayClass47_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetParameterByName>b__0(ActorParameter p); // 0x0000000180EB3C90-0x0000000180EB3CC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass49_0 // TypeDefIndex: 14083
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public <>c__DisplayClass49_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetActorReferenceByName>b__0(ActorParameter r); // 0x0000000180EB3C90-0x0000000180EB3CC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass50_0 // TypeDefIndex: 14084
		{
			// Fields
			public string paramName; // 0x10
	
			// Constructors
			public <>c__DisplayClass50_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <SetActorReference>b__0(ActorParameter p); // 0x0000000180EB3C90-0x0000000180EB3CC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass51_0 // TypeDefIndex: 14085
		{
			// Fields
			public KeyValuePair<string, IDialogueActor> pair; // 0x10
	
			// Constructors
			public <>c__DisplayClass51_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <SetActorReferences>b__0(ActorParameter p); // 0x0000000181576330-0x0000000181576390
		}
	
		// Constructors
		public DialogueTree(); // 0x0000000181565010-0x0000000181565090
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x0000000181564580-0x00000001815645D0
		public override void OnDerivedDataDeserialization(object data); // 0x0000000181564500-0x0000000181564580
		public ActorParameter GetParameterByID(string id); // 0x0000000181564380-0x0000000181564440
		public ActorParameter GetParameterByName(string paramName); // 0x0000000181564440-0x0000000181564500
		public IDialogueActor GetActorReferenceByID(string id); // 0x0000000181564050-0x0000000181564080
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x0000000181564080-0x0000000181564380
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x0000000181564C70-0x0000000181564DF0
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x0000000181564DF0-0x0000000181565010
		public void Continue(int index = 0 /* Metadata: 0x0078442D */); // 0x0000000181563E70-0x0000000181563FC0
		public void EnterNode(DTNode node); // 0x0000000181563FC0-0x0000000181564050
		public static void RequestSubtitles(SubtitlesRequestInfo info); // 0x0000000181564BF0-0x0000000181564C70
		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info); // 0x0000000181564B70-0x0000000181564BF0
		protected override void OnGraphStarted(); // 0x0000000181564670-0x00000001815648B0
		protected override void OnGraphUnpaused(); // 0x00000001815649E0-0x0000000181564B70
		protected override void OnGraphStoped(); // 0x00000001815648B0-0x00000001815649E0
		protected override void OnGraphPaused(); // 0x00000001815645D0-0x0000000181564670
	}
}
