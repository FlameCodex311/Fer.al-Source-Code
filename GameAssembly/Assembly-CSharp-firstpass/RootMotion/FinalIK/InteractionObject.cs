/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x000000018025D380-0x000000018025D3E0
	[HelpURL] // 0x000000018025D380-0x000000018025D3E0
	public class InteractionObject : UnityEngine.MonoBehaviour // TypeDefIndex: 9953
	{
		// Fields
		[Tooltip] // 0x000000018025D580-0x000000018025D5B0
		public Transform otherLookAtTarget; // 0x18
		[Tooltip] // 0x000000018025D6E0-0x000000018025D710
		public Transform otherTargetsRoot; // 0x20
		[Tooltip] // 0x000000018025D840-0x000000018025D870
		public Transform positionOffsetSpace; // 0x28
		public WeightCurve[] weightCurves; // 0x30
		public Multiplier[] multipliers; // 0x38
		public InteractionEvent[] events; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <length>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField; // 0x50
		private InteractionTarget[] targets; // 0x58
	
		// Properties
		public float length { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804D5810-0x00000001804D5820 0x00000001809892C0-0x00000001809892D0
		public InteractionSystem lastUsedInteractionSystem { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		public Transform lookAtTarget { get; } // 0x0000000181632A00-0x0000000181632A80 
		public Transform targetsRoot { get; } // 0x0000000181632A80-0x0000000181632B00 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 9954
		{
			// Fields
			[Tooltip] // 0x000000018025EBC0-0x000000018025EBF0
			public float time; // 0x10
			[Tooltip] // 0x000000018025ECC0-0x000000018025ECF0
			public bool pause; // 0x14
			[Tooltip] // 0x000000018025EE50-0x000000018025EE80
			public bool pickUp; // 0x15
			[Tooltip] // 0x000000018025EF50-0x000000018025EF80
			public AnimatorEvent[] animations; // 0x18
			[Tooltip] // 0x000000018025F180-0x000000018025F1B0
			public Message[] messages; // 0x20
			[Tooltip] // 0x000000018025F350-0x000000018025F380
			public UnityEvent unityEvent; // 0x28
	
			// Constructors
			public InteractionEvent(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void Activate(Transform t); // 0x0000000181630130-0x0000000181630300
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 9955
		{
			// Fields
			[Tooltip] // 0x000000018025F470-0x000000018025F4A0
			public string function; // 0x10
			[Tooltip] // 0x000000018025F630-0x000000018025F660
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x0077ACA5
	
			// Constructors
			public Message(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void Send(Transform t); // 0x000000018163AB60-0x000000018163AC40
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 9956
		{
			// Fields
			[Tooltip] // 0x000000018025F8F0-0x000000018025F920
			public Animator animator; // 0x10
			[Tooltip] // 0x000000018025FA00-0x000000018025FA30
			public Animation animation; // 0x18
			[Tooltip] // 0x000000018025FC40-0x000000018025FC70
			public string animationState; // 0x20
			[Tooltip] // 0x000000018025FDB0-0x000000018025FDE0
			public float crossfadeTime; // 0x28
			[Tooltip] // 0x000000018025FEA0-0x000000018025FED0
			public int layer; // 0x2C
			[Tooltip] // 0x00000001802600A0-0x00000001802600D0
			public bool resetNormalizedTime; // 0x30
			private const string empty = ""; // Metadata: 0x0077ACA9
	
			// Constructors
			public AnimatorEvent(); // 0x000000018162A8D0-0x000000018162A8E0
	
			// Methods
			public void Activate(bool pickUp); // 0x000000018162A690-0x000000018162A8D0
			private void Activate(Animator animator); // 0x000000018162A5D0-0x000000018162A690
			private void Activate(Animation animation); // 0x000000018162A500-0x000000018162A5D0
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 9957
		{
			// Fields
			[Tooltip] // 0x00000001802601F0-0x0000000180260220
			public Type type; // 0x10
			[Tooltip] // 0x0000000180260330-0x0000000180260360
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 9958
			{
				PositionWeight = 0,
				RotationWeight = 1,
				PositionOffsetX = 2,
				PositionOffsetY = 3,
				PositionOffsetZ = 4,
				Pull = 5,
				Reach = 6,
				RotateBoneWeight = 7,
				Push = 8,
				PushParent = 9,
				PoserWeight = 10
			}
	
			// Constructors
			public WeightCurve(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public float GetValue(float timer); // 0x000000018164B6D0-0x000000018164B6F0
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 9959
		{
			// Fields
			[Tooltip] // 0x00000001802604D0-0x0000000180260500
			public WeightCurve.Type curve; // 0x10
			[Tooltip] // 0x00000001802606D0-0x0000000180260700
			public float multiplier; // 0x14
			[Tooltip] // 0x0000000180260850-0x0000000180260880
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier(); // 0x00000001807843A0-0x00000001807843B0
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer); // 0x000000018163AC40-0x000000018163AC80
		}
	
		// Constructors
		public InteractionObject(); // 0x00000001816329B0-0x0000000181632A00
	
		// Methods
		[ContextMenu] // 0x000000018025DB00-0x000000018025DB30
		private void OpenTutorial1(); // 0x0000000181632830-0x0000000181632870
		[ContextMenu] // 0x000000018025DD40-0x000000018025DD70
		private void OpenTutorial2(); // 0x0000000181632870-0x00000001816328B0
		[ContextMenu] // 0x000000018025DE30-0x000000018025DE60
		private void OpenTutorial3(); // 0x00000001816328B0-0x00000001816328F0
		[ContextMenu] // 0x000000018025DFF0-0x000000018025E020
		private void OpenTutorial4(); // 0x00000001816328F0-0x0000000181632930
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000181632970-0x00000001816329B0
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x0000000181630BB0-0x0000000181630BF0
		public void Initiate(); // 0x00000001816324D0-0x00000001816327F0
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem); // 0x0000000181631E80-0x0000000181632020
		public bool CurveUsed(WeightCurve.Type type); // 0x0000000181631AC0-0x0000000181631B90
		public InteractionTarget[] GetTargets(); // 0x00000001803A1580-0x00000001803A1590
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag); // 0x0000000181631C10-0x0000000181631E80
		public void OnStartInteraction(InteractionSystem interactionSystem); // 0x00000001803F7B90-0x00000001803F7BA0
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight); // 0x0000000181630BF0-0x00000001816312C0
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer); // 0x00000001816320F0-0x0000000181632450
		private void Awake(); // 0x0000000181631AB0-0x0000000181631AC0
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight); // 0x00000001816312C0-0x0000000181631AB0
		private Transform GetTarget(FullBodyBipedEffector effectorType); // 0x0000000181632020-0x00000001816320F0
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType); // 0x0000000181632450-0x00000001816324D0
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType); // 0x0000000181631B90-0x0000000181631C10
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x0000000181632930-0x0000000181632970
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x00000001816327F0-0x0000000181632830
	}
}
