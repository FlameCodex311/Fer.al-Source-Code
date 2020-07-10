/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x000000018015C200-0x000000018015C260
	[HelpURL] // 0x000000018015C200-0x000000018015C260
	public class InteractionObject : UnityEngine.MonoBehaviour // TypeDefIndex: 9419
	{
		// Fields
		[Tooltip] // 0x000000018015C590-0x000000018015C5C0
		public Transform otherLookAtTarget; // 0x18
		[Tooltip] // 0x000000018015C9E0-0x000000018015CA10
		public Transform otherTargetsRoot; // 0x20
		[Tooltip] // 0x000000018015CC60-0x000000018015CC90
		public Transform positionOffsetSpace; // 0x28
		public WeightCurve[] weightCurves; // 0x30
		public Multiplier[] multipliers; // 0x38
		public InteractionEvent[] events; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <length>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField; // 0x50
		private InteractionTarget[] targets; // 0x58
	
		// Properties
		public float length { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487CC0-0x0000000180487CD0 0x0000000180DD2D70-0x0000000180DD2D80
		public InteractionSystem lastUsedInteractionSystem { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
		public Transform lookAtTarget { get; } // 0x0000000181AFA110-0x0000000181AFA190 
		public Transform targetsRoot { get; } // 0x0000000181AFA190-0x0000000181AFA210 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 9420
		{
			// Fields
			[Tooltip] // 0x000000018015E880-0x000000018015E8B0
			public float time; // 0x10
			[Tooltip] // 0x000000018015EAA0-0x000000018015EAD0
			public bool pause; // 0x14
			[Tooltip] // 0x000000018015EC20-0x000000018015EC50
			public bool pickUp; // 0x15
			[Tooltip] // 0x000000018015ED70-0x000000018015EDA0
			public AnimatorEvent[] animations; // 0x18
			[Tooltip] // 0x000000018015EEF0-0x000000018015EF20
			public Message[] messages; // 0x20
			[Tooltip] // 0x000000018015F060-0x000000018015F090
			public UnityEvent unityEvent; // 0x28
	
			// Constructors
			public InteractionEvent(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void Activate(Transform t); // 0x0000000181AF76C0-0x0000000181AF7890
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 9421
		{
			// Fields
			[Tooltip] // 0x000000018015F240-0x000000018015F270
			public string function; // 0x10
			[Tooltip] // 0x000000018015F530-0x000000018015F560
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x00745198
	
			// Constructors
			public Message(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void Send(Transform t); // 0x0000000181B09DC0-0x0000000181B09EA0
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 9422
		{
			// Fields
			[Tooltip] // 0x000000018015F740-0x000000018015F770
			public Animator animator; // 0x10
			[Tooltip] // 0x0000000180160B00-0x0000000180160B30
			public Animation animation; // 0x18
			[Tooltip] // 0x0000000180160D20-0x0000000180160D50
			public string animationState; // 0x20
			[Tooltip] // 0x0000000180160F30-0x0000000180160F60
			public float crossfadeTime; // 0x28
			[Tooltip] // 0x0000000180161070-0x00000001801610A0
			public int layer; // 0x2C
			[Tooltip] // 0x00000001801612F0-0x0000000180161320
			public bool resetNormalizedTime; // 0x30
			private const string empty = ""; // Metadata: 0x0074519C
	
			// Constructors
			public AnimatorEvent(); // 0x0000000181AF1E70-0x0000000181AF1E80
	
			// Methods
			public void Activate(bool pickUp); // 0x0000000181AF1C20-0x0000000181AF1E70
			private void Activate(Animator animator); // 0x0000000181AF1B60-0x0000000181AF1C20
			private void Activate(Animation animation); // 0x0000000181AF1A80-0x0000000181AF1B60
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 9423
		{
			// Fields
			[Tooltip] // 0x0000000180161480-0x00000001801614B0
			public Type type; // 0x10
			[Tooltip] // 0x0000000180161630-0x0000000180161660
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 9424
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
			public WeightCurve(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public float GetValue(float timer); // 0x0000000181B17A00-0x0000000181B17A20
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 9425
		{
			// Fields
			[Tooltip] // 0x00000001801617E0-0x0000000180161810
			public WeightCurve.Type curve; // 0x10
			[Tooltip] // 0x00000001801619A0-0x00000001801619D0
			public float multiplier; // 0x14
			[Tooltip] // 0x0000000180161C10-0x0000000180161C40
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier(); // 0x000000018127EAF0-0x000000018127EB00
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer); // 0x0000000181B09EA0-0x0000000181B09EE0
		}
	
		// Constructors
		public InteractionObject(); // 0x0000000181AFA0C0-0x0000000181AFA110
	
		// Methods
		[ContextMenu] // 0x000000018015D0D0-0x000000018015D100
		private void OpenTutorial1(); // 0x0000000181AF9F40-0x0000000181AF9F80
		[ContextMenu] // 0x000000018015D1F0-0x000000018015D220
		private void OpenTutorial2(); // 0x0000000181AF9F80-0x0000000181AF9FC0
		[ContextMenu] // 0x000000018015D480-0x000000018015D4B0
		private void OpenTutorial3(); // 0x0000000181AF9FC0-0x0000000181AFA000
		[ContextMenu] // 0x000000018015D6A0-0x000000018015D6D0
		private void OpenTutorial4(); // 0x0000000181AFA000-0x0000000181AFA040
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x0000000181AFA080-0x0000000181AFA0C0
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000181AF8170-0x0000000181AF81B0
		public void Initiate(); // 0x0000000181AF9BB0-0x0000000181AF9F00
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem); // 0x0000000181AF9510-0x0000000181AF96C0
		public bool CurveUsed(WeightCurve.Type type); // 0x0000000181AF9110-0x0000000181AF91F0
		public InteractionTarget[] GetTargets(); // 0x0000000180357120-0x0000000180357130
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag); // 0x0000000181AF9270-0x0000000181AF9510
		public void OnStartInteraction(InteractionSystem interactionSystem); // 0x00000001803A2850-0x00000001803A2860
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight); // 0x0000000181AF81B0-0x0000000181AF88D0
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer); // 0x0000000181AF97A0-0x0000000181AF9B30
		private void Awake(); // 0x0000000181AF9100-0x0000000181AF9110
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight); // 0x0000000181AF88D0-0x0000000181AF9100
		private Transform GetTarget(FullBodyBipedEffector effectorType); // 0x0000000181AF96C0-0x0000000181AF97A0
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType); // 0x0000000181AF9B30-0x0000000181AF9BB0
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType); // 0x0000000181AF91F0-0x0000000181AF9270
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x0000000181AFA040-0x0000000181AFA080
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x0000000181AF9F00-0x0000000181AF9F40
	}
}
