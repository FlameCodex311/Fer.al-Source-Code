/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.UI;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001800B4050-0x00000001800B4080
	[ExecuteInEditMode] // 0x00000001800B4050-0x00000001800B4080
	public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 5819
	{
		// Fields
		public const int POINTER_ID_NULL = -2147483648; // Metadata: 0x0072EC44
		public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1; // Metadata: 0x0072EC48
		public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2; // Metadata: 0x0072EC4C
		public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3; // Metadata: 0x0072EC50
		internal const int MAX_MOUSE_BUTTONS = 3; // Metadata: 0x0072EC54
		[CustomObfuscation] // 0x000000018014D720-0x000000018014D780
		[SerializeField] // 0x000000018014D720-0x000000018014D780
		[Tooltip] // 0x000000018014D720-0x000000018014D780
		private bool _interactable; // 0x38
		[CustomObfuscation] // 0x000000018014EE30-0x000000018014EE90
		[SerializeField] // 0x000000018014EE30-0x000000018014EE90
		[Tooltip] // 0x000000018014EE30-0x000000018014EE90
		private bool _visible; // 0x39
		[CustomObfuscation] // 0x000000018014F130-0x000000018014F190
		[SerializeField] // 0x000000018014F130-0x000000018014F190
		[Tooltip] // 0x000000018014F130-0x000000018014F190
		private bool _hideWhenIdle; // 0x3A
		[Bitmask] // 0x00000001801508C0-0x0000000180150960
		[CustomObfuscation] // 0x00000001801508C0-0x0000000180150960
		[SerializeField] // 0x00000001801508C0-0x0000000180150960
		[Tooltip] // 0x00000001801508C0-0x0000000180150960
		private MouseButtonFlags _allowedMouseButtons; // 0x3C
		[Bitmask] // 0x0000000180150F90-0x0000000180151030
		[CustomObfuscation] // 0x0000000180150F90-0x0000000180151030
		[SerializeField] // 0x0000000180150F90-0x0000000180151030
		[Tooltip] // 0x0000000180150F90-0x0000000180151030
		private TransitionTypeFlags _transitionType; // 0x40
		[CustomObfuscation] // 0x0000000180151480-0x00000001801514E0
		[SerializeField] // 0x0000000180151480-0x00000001801514E0
		[Tooltip] // 0x0000000180151480-0x00000001801514E0
		private ColorBlock _transitionColorTint; // 0x44
		[CustomObfuscation] // 0x0000000180151950-0x00000001801519B0
		[SerializeField] // 0x0000000180151950-0x00000001801519B0
		[Tooltip] // 0x0000000180151950-0x00000001801519B0
		private SpriteState _transitionSpriteState; // 0xA0
		[CustomObfuscation] // 0x0000000180151C50-0x0000000180151CB0
		[SerializeField] // 0x0000000180151C50-0x0000000180151CB0
		[Tooltip] // 0x0000000180151C50-0x0000000180151CB0
		private AnimationTriggers _transitionAnimationTriggers; // 0xC0
		[CustomObfuscation] // 0x0000000180151FE0-0x0000000180152040
		[SerializeField] // 0x0000000180151FE0-0x0000000180152040
		[Tooltip] // 0x0000000180151FE0-0x0000000180152040
		private Graphic _targetGraphic; // 0xC8
		[CustomObfuscation] // 0x0000000180152430-0x0000000180152490
		[SerializeField] // 0x0000000180152430-0x0000000180152490
		[Tooltip] // 0x0000000180152430-0x0000000180152490
		private InteractionStateTransitionEventHandler _onInteractionStateTransition; // 0xD0
		[CustomObfuscation] // 0x0000000180152740-0x00000001801527A0
		[SerializeField] // 0x0000000180152740-0x00000001801527A0
		[Tooltip] // 0x0000000180152740-0x00000001801527A0
		private VisibilityChangedEventHandler _onVisibilityChanged; // 0xD8
		[CustomObfuscation] // 0x0000000180152AD0-0x0000000180152B30
		[SerializeField] // 0x0000000180152AD0-0x0000000180152B30
		[Tooltip] // 0x0000000180152AD0-0x0000000180152B30
		private UnityEvent _onInteractionStateChangedToNormal; // 0xE0
		[CustomObfuscation] // 0x0000000180152CF0-0x0000000180152D50
		[SerializeField] // 0x0000000180152CF0-0x0000000180152D50
		[Tooltip] // 0x0000000180152CF0-0x0000000180152D50
		private UnityEvent _onInteractionStateChangedToHighlighted; // 0xE8
		[CustomObfuscation] // 0x0000000180153250-0x00000001801532B0
		[SerializeField] // 0x0000000180153250-0x00000001801532B0
		[Tooltip] // 0x0000000180153250-0x00000001801532B0
		private UnityEvent _onInteractionStateChangedToPressed; // 0xF0
		[CustomObfuscation] // 0x00000001801534A0-0x0000000180153500
		[SerializeField] // 0x00000001801534A0-0x0000000180153500
		[Tooltip] // 0x00000001801534A0-0x0000000180153500
		private UnityEvent _onInteractionStateChangedToDisabled; // 0xF8
		private readonly List<CanvasGroup> _canvasGroupCache; // 0x100
		private bool _groupsAllowInteraction; // 0x108
		private InteractionState _interactionState; // 0x10C
		[NonSerialized]
		private bool IXgubBiHZOnBAjLkDRcJjAfbtyr; // 0x110
		[NonSerialized]
		private bool byeanBfvjEeOOwRBSBerFwsuBMBA; // 0x111
		private bool _varWatch_visible; // 0x112
		private bool _varWatch_interactable; // 0x113
		private bool _allowSendingEvents; // 0x114
		private static InteractionStateTransitionArgs _transitionArgs; // 0x00
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers; // 0x118
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers; // 0x120
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate; // 0x08
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> CS$<>9__CachedAnonymousMethodDelegate4; // 0x10
	
		// Properties
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IVisibilityChangedHandler, bool> hierarchyVisibilityChangedHandlers { get; } // 0x00000001819105B0-0x0000000181910660 
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> hierarchyInteractionStateTransitionHandlers { get; } // 0x0000000181910370-0x00000001819105B0 
		public bool interactable { get; set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x00000001819114F0-0x0000000181911510
		public bool visible { get; set; } // 0x00000001806EDE30-0x00000001806EDE40 0x00000001819116F0-0x0000000181911730
		public bool hideWhenIdle { get; set; } // 0x00000001806EDE20-0x00000001806EDE30 0x00000001819113E0-0x0000000181911420
		public MouseButtonFlags allowedMouseButtons { get; set; } // 0x0000000180487DC0-0x0000000180487DD0 0x0000000181911390-0x00000001819113E0
		public TransitionTypeFlags transitionType { get; set; } // 0x000000018047AB20-0x000000018047AB30 0x00000001819116D0-0x00000001819116F0
		public ColorBlock transitionColorTint { get; set; } // 0x0000000181910860-0x00000001819108A0 0x00000001819115E0-0x0000000181911630
		public SpriteState transitionSpriteState { get; set; } // 0x00000001819108A0-0x00000001819108C0 0x0000000181911630-0x00000001819116D0
		public AnimationTriggers transitionAnimationTriggers { get; set; } // 0x00000001804A1050-0x00000001804A1060 0x00000001819115B0-0x00000001819115E0
		public Graphic targetGraphic { get; set; } // 0x00000001804A2590-0x00000001804A25A0 0x0000000181911510-0x00000001819115B0
		public Image image { get; set; } // 0x0000000181910660-0x00000001819106E0 0x0000000181911420-0x00000001819114F0
		public Animator animator { get; } // 0x0000000181910320-0x0000000181910370 
		public InteractionState interactionState { get; } // 0x00000001810D1C00-0x00000001810D1C10 
		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> interactionStateTransitionHandlerDelegate { get; } // 0x00000001819106E0-0x0000000181910860 
	
		// Events
		public event UnityAction<InteractionStateTransitionArgs> InteractionStateSetEvent {
			add; // 0x000000018190FE40-0x000000018190FEA0
			remove; // 0x00000001819112D0-0x0000000181911330
		}
		public event UnityAction<bool> VisibilityChangedEvent {
			add; // 0x000000018190FEA0-0x000000018190FF00
			remove; // 0x0000000181911330-0x0000000181911390
		}
		public event UnityAction InteractionStateChangedToNormal {
			add; // 0x000000018190FDE0-0x000000018190FE10
			remove; // 0x0000000181911270-0x00000001819112A0
		}
		public event UnityAction InteractionStateChangedToHighlighted {
			add; // 0x000000018190FDB0-0x000000018190FDE0
			remove; // 0x0000000181911240-0x0000000181911270
		}
		public event UnityAction InteractionStateChangedToPressed {
			add; // 0x000000018190FE10-0x000000018190FE40
			remove; // 0x00000001819112A0-0x00000001819112D0
		}
		public event UnityAction InteractionStateChangedToDisabled {
			add; // 0x000000018190FD80-0x000000018190FDB0
			remove; // 0x0000000181911210-0x0000000181911240
		}
	
		// Nested types
		public enum InteractionState // TypeDefIndex: 5820
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Disabled = 3
		}
	
		[Flags] // 0x00000001800B36B0-0x00000001800B36C0
		public enum TransitionTypeFlags // TypeDefIndex: 5821
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 4
		}
	
		[Flags] // 0x00000001800B36B0-0x00000001800B36C0
		public enum MouseButtonFlags // TypeDefIndex: 5822
		{
			AnyButton = -1,
			None = 0,
			LeftButton = 1,
			RightButton = 2,
			MiddleButton = 4
		}
	
		[Serializable]
		public class InteractionStateTransitionEventHandler : UnityEvent<InteractionStateTransitionArgs> // TypeDefIndex: 5823
		{
			// Constructors
			public InteractionStateTransitionEventHandler(); // 0x00000001819071E0-0x0000000181907220
		}
	
		[Serializable]
		public class VisibilityChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 5824
		{
			// Constructors
			public VisibilityChangedEventHandler(); // 0x00000001819227F0-0x0000000181922830
		}
	
		public class InteractionStateTransitionArgs // TypeDefIndex: 5825
		{
			// Fields
			private TouchInteractable BHsZlcPmudzzrVEaeCtsoDPceWKg; // 0x10
			private InteractionState rBokgqdrsZuLZsBTVapGfihGpbU; // 0x18
			private float OyidXNnuWGQINLNaEhmkwlZPCwz; // 0x1C
	
			// Properties
			public TouchInteractable sender { get; } // 0x000000018036AC80-0x000000018036AC90 
			public InteractionState state { get; } // 0x0000000180367710-0x0000000180367720 
			public float duration { get; } // 0x00000001805D9070-0x00000001805D9080 
	
			// Constructors
			internal InteractionStateTransitionArgs(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void bnteExvucnBsCpxQAJWOTetSFlq(TouchInteractable param_0000c71a, InteractionState param_0000c71b, float param_0000c71c); // 0x00000001819071D0-0x00000001819071E0
		}
	
		public interface IInteractionStateTransitionHandler // TypeDefIndex: 5826
		{
			// Methods
			void OnInteractionStateTransition(InteractionStateTransitionArgs data);
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal TouchInteractable(); // 0x000000018190FB10-0x000000018190FD80
		static TouchInteractable(); // 0x000000018190FAB0-0x000000018190FB10
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void Awake(); // 0x000000018190D350-0x000000018190D450
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnCanvasGroupChanged(); // 0x000000018190DF60-0x000000018190E380
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnDidApplyAnimationProperties(); // 0x000000018190E380-0x000000018190E3A0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnEnable(); // 0x000000018190E440-0x000000018190E560
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnDisable(); // 0x000000018190E3A0-0x000000018190E3C0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnValidate(); // 0x000000018190EA10-0x000000018190EE20
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void Reset(); // 0x000000018190EE50-0x000000018190EEC0
		internal override void OnSetProperty(); // 0x000000018190E8F0-0x000000018190EA10
		internal override void FindEventHandlers(); // 0x000000018190D5E0-0x000000018190D600
		private void lXXihxaGwUqiAesOLyAhYAOaHUTF(); // 0x0000000181910B60-0x0000000181910E40
		private void SYNlHHRrbZcAJodCuaKCnCWbJLf(InteractionState param_0000c6e9, bool param_0000c6ea); // 0x000000018190EEC0-0x000000018190F3E0
		private void EqHRSTidijHvHCzjafITwRmHRek(Color param_0000c6eb, bool param_0000c6ec); // 0x000000018190D500-0x000000018190D5E0
		private void ZTgcHEUFatyMOsotIsfeFdGabwT(Sprite param_0000c6ed); // 0x000000018190F990-0x000000018190FA40
		private void WDCQCdpqVqalHhBdpcWeKLDbEKBn(string param_0000c6ee); // 0x000000018190F4C0-0x000000018190F980
		private void vQItACpvQdVvDThyFEokrAlWHpk(bool param_0000c6ef); // 0x0000000181911730-0x00000001819117B0
		public bool IsInteractable(); // 0x000000018190DD30-0x000000018190DD50
		internal virtual bool IsPressed(); // 0x000000018190DD50-0x000000018190DD90
		internal void bEywVhSimReqAWaZxErFkjJjVtGP(BaseEventData param_0000c6f0); // 0x000000018190FF00-0x00000001819100A0
		internal virtual bool IsThisOrTouchRegionGameObject(GameObject param_0000c6f1); // 0x000000018190DD90-0x000000018190DE00
		private bool FwZXnhkBucajliMuWRCjmtpVpftx(BaseEventData param_0000c6f2); // 0x000000018190D600-0x000000018190D890
		private bool FwZXnhkBucajliMuWRCjmtpVpftx(bool param_0000c6f3, GameObject param_0000c6f4); // 0x000000018190D890-0x000000018190DA10
		private InteractionState iPvJBXPeCclLOnwPetnhgIQsLDZ(BaseEventData param_0000c6f5); // 0x00000001819108C0-0x0000000181910960
		private bool AlxDDcfwGckuFUYweCgYtwrdgQkE(InteractionState param_0000c6f6); // 0x000000018190D320-0x000000018190D350
		private void VgChwotAchouzECAvCsSsIzLjHr(); // 0x000000018190F4B0-0x000000018190F4C0
		private void ZqkunzJCzHBRZRpDdDGYJArAIWI(); // 0x000000018190FA40-0x000000018190FAB0
		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool param_0000c6f7, bool param_0000c6f8); // 0x000000018190DA10-0x000000018190DAE0
		private void mqiaGywLlRymbsGGeFSVkHQPXjn(); // 0x0000000181910F90-0x0000000181911210
		private void ixjtpheoJlhcHpvQksvNDhgeKCH(); // 0x0000000181910960-0x0000000181910A00
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x000000018190DE00-0x000000018190DEE0
		private void mXxeTnZEpQaukGpVlCughHfuIUBy(); // 0x0000000181910EF0-0x0000000181910F90
		internal virtual void OnPointerDown(PointerEventData param_0000c6f9); // 0x000000018190E5E0-0x000000018190E690
		internal virtual void OnPointerUp(PointerEventData param_0000c6fa); // 0x000000018190E840-0x000000018190E8F0
		internal virtual void OnPointerEnter(PointerEventData param_0000c6fb); // 0x000000018190E690-0x000000018190E770
		internal virtual void OnPointerExit(PointerEventData param_0000c6fc); // 0x000000018190E770-0x000000018190E840
		internal virtual void OnBeginDrag(PointerEventData param_0000c6fd); // 0x000000018190DEE0-0x000000018190DF60
		internal virtual void OnDrag(PointerEventData param_0000c6fe); // 0x000000018190E3C0-0x000000018190E440
		internal virtual void OnEndDrag(PointerEventData param_0000c6ff); // 0x000000018190E560-0x000000018190E5E0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018190F420-0x000000018190F440
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018190F460-0x000000018190F480
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x000000018190F440-0x000000018190F460
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x00000001805B1E70-0x00000001805B1E90
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x000000018190F3E0-0x000000018190F400
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018190F400-0x000000018190F420
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x0000000180854EA0-0x0000000180854EC0
		internal static bool HnDYYyEyytpwLaJegWvMADlHFsSd(int param_0000c707); // 0x000000018190DAE0-0x000000018190DD30
		internal static Vector3 cUxvuyDqpidwABRzxIDKypbqGbj(int param_0000c708); // 0x00000001819100A0-0x0000000181910290
		internal static bool YqHoLRMcduRQOWkGZqPZbSXCqMr(int param_0000c709); // 0x000000018190F980-0x000000018190F990
		internal static bool RKuBNDBltyOHRbYmamVpbyrCxlHD(int param_0000c70a); // 0x000000018190EE30-0x000000018190EE50
		private static int jdocHahTlBXSaoXdrVnORQOhnMr(int param_0000c70b); // 0x0000000181910A00-0x0000000181910B60
		internal static bool zXZcOyXprfvKGdTogolTEsqpkNr(MouseButtonFlags param_0000c70c, int param_0000c70d); // 0x0000000181911870-0x0000000181911970
		private static bool VJAvTiGJAjWQpqLdvzMxtBhsiBuJ(MouseButtonFlags param_0000c70e, int param_0000c70f); // 0x000000018190F480-0x000000018190F4B0
		private static int ehbuqvZMycoCNLbMSlrJgEAhxJr(int param_0000c710); // 0x0000000181910290-0x0000000181910320
		internal static bool mDtvTOyiODjBcicqmdrKnRoVnYx(MouseButtonFlags param_0000c711, out int param_0000c712); // 0x0000000181910E40-0x0000000181910EF0
		internal static bool zXZcOyXprfvKGdTogolTEsqpkNr(int param_0000c713, MouseButtonFlags param_0000c714, EventTriggerType param_0000c715); // 0x0000000181911970-0x0000000181911B50
		internal static bool wqlomoLqWqbNsWcBNmubucLvszN(MouseButtonFlags param_0000c716); // 0x00000001819117B0-0x0000000181911870
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void PiZvjlDfphRqtQeIlaOPmkLmwDj(bool param_0000c717); // 0x000000018190EE20-0x000000018190EE30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static void DDwUPgHHEKNvYLHTYIUQEMQYUeA(IInteractionStateTransitionHandler param_0000c718, InteractionStateTransitionArgs param_0000c719); // 0x000000018190D450-0x000000018190D500
	}
}
