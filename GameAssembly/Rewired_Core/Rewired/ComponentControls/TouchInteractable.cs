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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801CDDD0-0x00000001801CDE00
	[ExecuteInEditMode] // 0x00000001801CDDD0-0x00000001801CDE00
	public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 5978
	{
		// Fields
		public const int POINTER_ID_NULL = -2147483648; // Metadata: 0x007638E1
		public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1; // Metadata: 0x007638E5
		public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2; // Metadata: 0x007638E9
		public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3; // Metadata: 0x007638ED
		internal const int MAX_MOUSE_BUTTONS = 3; // Metadata: 0x007638F1
		[CustomObfuscation] // 0x00000001801EB660-0x00000001801EB6C0
		[SerializeField] // 0x00000001801EB660-0x00000001801EB6C0
		[Tooltip] // 0x00000001801EB660-0x00000001801EB6C0
		private bool _interactable; // 0x38
		[CustomObfuscation] // 0x00000001801EB920-0x00000001801EB980
		[SerializeField] // 0x00000001801EB920-0x00000001801EB980
		[Tooltip] // 0x00000001801EB920-0x00000001801EB980
		private bool _visible; // 0x39
		[CustomObfuscation] // 0x00000001801EBD00-0x00000001801EBD60
		[SerializeField] // 0x00000001801EBD00-0x00000001801EBD60
		[Tooltip] // 0x00000001801EBD00-0x00000001801EBD60
		private bool _hideWhenIdle; // 0x3A
		[Bitmask] // 0x00000001801EC2C0-0x00000001801EC360
		[CustomObfuscation] // 0x00000001801EC2C0-0x00000001801EC360
		[SerializeField] // 0x00000001801EC2C0-0x00000001801EC360
		[Tooltip] // 0x00000001801EC2C0-0x00000001801EC360
		private MouseButtonFlags _allowedMouseButtons; // 0x3C
		[Bitmask] // 0x00000001801EC8F0-0x00000001801EC990
		[CustomObfuscation] // 0x00000001801EC8F0-0x00000001801EC990
		[SerializeField] // 0x00000001801EC8F0-0x00000001801EC990
		[Tooltip] // 0x00000001801EC8F0-0x00000001801EC990
		private TransitionTypeFlags _transitionType; // 0x40
		[CustomObfuscation] // 0x00000001801ECDC0-0x00000001801ECE20
		[SerializeField] // 0x00000001801ECDC0-0x00000001801ECE20
		[Tooltip] // 0x00000001801ECDC0-0x00000001801ECE20
		private ColorBlock _transitionColorTint; // 0x44
		[CustomObfuscation] // 0x00000001801ED0F0-0x00000001801ED150
		[SerializeField] // 0x00000001801ED0F0-0x00000001801ED150
		[Tooltip] // 0x00000001801ED0F0-0x00000001801ED150
		private SpriteState _transitionSpriteState; // 0xA0
		[CustomObfuscation] // 0x00000001801ED3B0-0x00000001801ED410
		[SerializeField] // 0x00000001801ED3B0-0x00000001801ED410
		[Tooltip] // 0x00000001801ED3B0-0x00000001801ED410
		private AnimationTriggers _transitionAnimationTriggers; // 0xC0
		[CustomObfuscation] // 0x00000001801ED710-0x00000001801ED770
		[SerializeField] // 0x00000001801ED710-0x00000001801ED770
		[Tooltip] // 0x00000001801ED710-0x00000001801ED770
		private Graphic _targetGraphic; // 0xC8
		[CustomObfuscation] // 0x00000001801ED940-0x00000001801ED9A0
		[SerializeField] // 0x00000001801ED940-0x00000001801ED9A0
		[Tooltip] // 0x00000001801ED940-0x00000001801ED9A0
		private InteractionStateTransitionEventHandler _onInteractionStateTransition; // 0xD0
		[CustomObfuscation] // 0x00000001801EDC20-0x00000001801EDC80
		[SerializeField] // 0x00000001801EDC20-0x00000001801EDC80
		[Tooltip] // 0x00000001801EDC20-0x00000001801EDC80
		private VisibilityChangedEventHandler _onVisibilityChanged; // 0xD8
		[CustomObfuscation] // 0x00000001801EDE50-0x00000001801EDEB0
		[SerializeField] // 0x00000001801EDE50-0x00000001801EDEB0
		[Tooltip] // 0x00000001801EDE50-0x00000001801EDEB0
		private UnityEvent _onInteractionStateChangedToNormal; // 0xE0
		[CustomObfuscation] // 0x00000001801EE0E0-0x00000001801EE140
		[SerializeField] // 0x00000001801EE0E0-0x00000001801EE140
		[Tooltip] // 0x00000001801EE0E0-0x00000001801EE140
		private UnityEvent _onInteractionStateChangedToHighlighted; // 0xE8
		[CustomObfuscation] // 0x00000001801EE490-0x00000001801EE4F0
		[SerializeField] // 0x00000001801EE490-0x00000001801EE4F0
		[Tooltip] // 0x00000001801EE490-0x00000001801EE4F0
		private UnityEvent _onInteractionStateChangedToPressed; // 0xF0
		[CustomObfuscation] // 0x00000001801EE770-0x00000001801EE7D0
		[SerializeField] // 0x00000001801EE770-0x00000001801EE7D0
		[Tooltip] // 0x00000001801EE770-0x00000001801EE7D0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> CS$<>9__CachedAnonymousMethodDelegate4; // 0x10
	
		// Properties
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IVisibilityChangedHandler, bool> hierarchyVisibilityChangedHandlers { get; } // 0x00000001810B63A0-0x00000001810B6450 
		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> hierarchyInteractionStateTransitionHandlers { get; } // 0x00000001810B6160-0x00000001810B63A0 
		public bool interactable { get; set; } // 0x0000000180379B20-0x0000000180379B30 0x00000001810B72D0-0x00000001810B72F0
		public bool visible { get; set; } // 0x00000001804F1610-0x00000001804F1620 0x00000001810B74D0-0x00000001810B7510
		public bool hideWhenIdle { get; set; } // 0x00000001804F1650-0x00000001804F1660 0x00000001810B71C0-0x00000001810B7200
		public MouseButtonFlags allowedMouseButtons { get; set; } // 0x000000018099EBE0-0x000000018099EBF0 0x00000001810B7170-0x00000001810B71C0
		public TransitionTypeFlags transitionType { get; set; } // 0x0000000180379F10-0x0000000180379F20 0x00000001810B74B0-0x00000001810B74D0
		public ColorBlock transitionColorTint { get; set; } // 0x00000001810B6650-0x00000001810B6690 0x00000001810B73C0-0x00000001810B7410
		public SpriteState transitionSpriteState { get; set; } // 0x00000001810B6690-0x00000001810B66B0 0x00000001810B7410-0x00000001810B74B0
		public AnimationTriggers transitionAnimationTriggers { get; set; } // 0x0000000180529360-0x0000000180529370 0x00000001810B7390-0x00000001810B73C0
		public Graphic targetGraphic { get; set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001810B72F0-0x00000001810B7390
		public Image image { get; set; } // 0x00000001810B6450-0x00000001810B64D0 0x00000001810B7200-0x00000001810B72D0
		public Animator animator { get; } // 0x00000001810B6110-0x00000001810B6160 
		public InteractionState interactionState { get; } // 0x000000018057C2F0-0x000000018057C300 
		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> interactionStateTransitionHandlerDelegate { get; } // 0x00000001810B64D0-0x00000001810B6650 
	
		// Events
		public event UnityAction<InteractionStateTransitionArgs> InteractionStateSetEvent {
			add; // 0x00000001810B5C30-0x00000001810B5C90
			remove; // 0x00000001810B70B0-0x00000001810B7110
		}
		public event UnityAction<bool> VisibilityChangedEvent {
			add; // 0x00000001810B5C90-0x00000001810B5CF0
			remove; // 0x00000001810B7110-0x00000001810B7170
		}
		public event UnityAction InteractionStateChangedToNormal {
			add; // 0x00000001810B5BD0-0x00000001810B5C00
			remove; // 0x00000001810B7050-0x00000001810B7080
		}
		public event UnityAction InteractionStateChangedToHighlighted {
			add; // 0x00000001810B5BA0-0x00000001810B5BD0
			remove; // 0x00000001810B7020-0x00000001810B7050
		}
		public event UnityAction InteractionStateChangedToPressed {
			add; // 0x00000001810B5C00-0x00000001810B5C30
			remove; // 0x00000001810B7080-0x00000001810B70B0
		}
		public event UnityAction InteractionStateChangedToDisabled {
			add; // 0x00000001810B5B70-0x00000001810B5BA0
			remove; // 0x00000001810B6FF0-0x00000001810B7020
		}
	
		// Nested types
		public enum InteractionState // TypeDefIndex: 5979
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Disabled = 3
		}
	
		[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
		public enum TransitionTypeFlags // TypeDefIndex: 5980
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 4
		}
	
		[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
		public enum MouseButtonFlags // TypeDefIndex: 5981
		{
			AnyButton = -1,
			None = 0,
			LeftButton = 1,
			RightButton = 2,
			MiddleButton = 4
		}
	
		[Serializable]
		public class InteractionStateTransitionEventHandler : UnityEvent<InteractionStateTransitionArgs> // TypeDefIndex: 5982
		{
			// Constructors
			public InteractionStateTransitionEventHandler(); // 0x00000001810AD150-0x00000001810AD190
		}
	
		[Serializable]
		public class VisibilityChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 5983
		{
			// Constructors
			public VisibilityChangedEventHandler(); // 0x00000001810C8420-0x00000001810C8460
		}
	
		public class InteractionStateTransitionArgs // TypeDefIndex: 5984
		{
			// Fields
			private TouchInteractable BHsZlcPmudzzrVEaeCtsoDPceWKg; // 0x10
			private InteractionState rBokgqdrsZuLZsBTVapGfihGpbU; // 0x18
			private float OyidXNnuWGQINLNaEhmkwlZPCwz; // 0x1C
	
			// Properties
			public TouchInteractable sender { get; } // 0x0000000180372440-0x0000000180372450 
			public InteractionState state { get; } // 0x00000001803F46B0-0x00000001803F46C0 
			public float duration { get; } // 0x0000000180918C20-0x0000000180918C30 
	
			// Constructors
			internal InteractionStateTransitionArgs(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void bnteExvucnBsCpxQAJWOTetSFlq(TouchInteractable param_0000c98a, InteractionState param_0000c98b, float param_0000c98c); // 0x00000001810AD140-0x00000001810AD150
		}
	
		public interface IInteractionStateTransitionHandler // TypeDefIndex: 5985
		{
			// Methods
			void OnInteractionStateTransition(InteractionStateTransitionArgs data);
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal TouchInteractable(); // 0x00000001810B5900-0x00000001810B5B70
		static TouchInteractable(); // 0x00000001810B58A0-0x00000001810B5900
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void Awake(); // 0x00000001810B31A0-0x00000001810B32A0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnCanvasGroupChanged(); // 0x00000001810B3D90-0x00000001810B41A0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnDidApplyAnimationProperties(); // 0x00000001810B41A0-0x00000001810B41C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnEnable(); // 0x00000001810B4260-0x00000001810B4380
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnDisable(); // 0x00000001810B41C0-0x00000001810B41E0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnValidate(); // 0x00000001810B4830-0x00000001810B4C30
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void Reset(); // 0x00000001810B4C60-0x00000001810B4CD0
		internal override void OnSetProperty(); // 0x00000001810B4710-0x00000001810B4830
		internal override void FindEventHandlers(); // 0x00000001810B3430-0x00000001810B3450
		private void lXXihxaGwUqiAesOLyAhYAOaHUTF(); // 0x00000001810B6950-0x00000001810B6C20
		private void SYNlHHRrbZcAJodCuaKCnCWbJLf(InteractionState param_0000c959, bool param_0000c95a); // 0x00000001810B4CD0-0x00000001810B51E0
		private void EqHRSTidijHvHCzjafITwRmHRek(Color param_0000c95b, bool param_0000c95c); // 0x00000001810B3350-0x00000001810B3430
		private void ZTgcHEUFatyMOsotIsfeFdGabwT(Sprite param_0000c95d); // 0x00000001810B5790-0x00000001810B5830
		private void WDCQCdpqVqalHhBdpcWeKLDbEKBn(string param_0000c95e); // 0x00000001810B52E0-0x00000001810B5780
		private void vQItACpvQdVvDThyFEokrAlWHpk(bool param_0000c95f); // 0x00000001810B7510-0x00000001810B7590
		public bool IsInteractable(); // 0x00000001810B3B70-0x00000001810B3B90
		internal virtual bool IsPressed(); // 0x00000001810B3B90-0x00000001810B3BD0
		internal void bEywVhSimReqAWaZxErFkjJjVtGP(BaseEventData param_0000c960); // 0x00000001810B5CF0-0x00000001810B5E90
		internal virtual bool IsThisOrTouchRegionGameObject(GameObject param_0000c961); // 0x00000001810B3BD0-0x00000001810B3C40
		private bool FwZXnhkBucajliMuWRCjmtpVpftx(BaseEventData param_0000c962); // 0x00000001810B3450-0x00000001810B36D0
		private bool FwZXnhkBucajliMuWRCjmtpVpftx(bool param_0000c963, GameObject param_0000c964); // 0x00000001810B36D0-0x00000001810B3850
		private InteractionState iPvJBXPeCclLOnwPetnhgIQsLDZ(BaseEventData param_0000c965); // 0x00000001810B66B0-0x00000001810B6750
		private bool AlxDDcfwGckuFUYweCgYtwrdgQkE(InteractionState param_0000c966); // 0x00000001810B3170-0x00000001810B31A0
		private void VgChwotAchouzECAvCsSsIzLjHr(); // 0x00000001810B52D0-0x00000001810B52E0
		private void ZqkunzJCzHBRZRpDdDGYJArAIWI(); // 0x00000001810B5830-0x00000001810B58A0
		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool param_0000c967, bool param_0000c968); // 0x00000001810B3850-0x00000001810B3920
		private void mqiaGywLlRymbsGGeFSVkHQPXjn(); // 0x00000001810B6D70-0x00000001810B6FF0
		private void ixjtpheoJlhcHpvQksvNDhgeKCH(); // 0x00000001810B6750-0x00000001810B67F0
		private new void LZtLIradkTZxeuvnkQoCvQBxNXr(); // 0x00000001810B3C40-0x00000001810B3D10
		private void mXxeTnZEpQaukGpVlCughHfuIUBy(); // 0x00000001810B6CD0-0x00000001810B6D70
		internal virtual void OnPointerDown(PointerEventData param_0000c969); // 0x00000001810B4400-0x00000001810B44B0
		internal virtual void OnPointerUp(PointerEventData param_0000c96a); // 0x00000001810B4660-0x00000001810B4710
		internal virtual void OnPointerEnter(PointerEventData param_0000c96b); // 0x00000001810B44B0-0x00000001810B4590
		internal virtual void OnPointerExit(PointerEventData param_0000c96c); // 0x00000001810B4590-0x00000001810B4660
		internal virtual void OnBeginDrag(PointerEventData param_0000c96d); // 0x00000001810B3D10-0x00000001810B3D90
		internal virtual void OnDrag(PointerEventData param_0000c96e); // 0x00000001810B41E0-0x00000001810B4260
		internal virtual void OnEndDrag(PointerEventData param_0000c96f); // 0x00000001810B4380-0x00000001810B4400
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x00000001810B5240-0x00000001810B5260
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x00000001810B5280-0x00000001810B52A0
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x00000001810B5260-0x00000001810B5280
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x0000000180C9BFB0-0x0000000180C9BFD0
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x00000001810B51E0-0x00000001810B5200
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x00000001810B5200-0x00000001810B5220
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x00000001810B5220-0x00000001810B5240
		internal static bool HnDYYyEyytpwLaJegWvMADlHFsSd(int param_0000c977); // 0x00000001810B3920-0x00000001810B3B70
		internal static Vector3 cUxvuyDqpidwABRzxIDKypbqGbj(int param_0000c978); // 0x00000001810B5E90-0x00000001810B6080
		internal static bool YqHoLRMcduRQOWkGZqPZbSXCqMr(int param_0000c979); // 0x00000001810B5780-0x00000001810B5790
		internal static bool RKuBNDBltyOHRbYmamVpbyrCxlHD(int param_0000c97a); // 0x00000001810B4C40-0x00000001810B4C60
		private static int jdocHahTlBXSaoXdrVnORQOhnMr(int param_0000c97b); // 0x00000001810B67F0-0x00000001810B6950
		internal static bool zXZcOyXprfvKGdTogolTEsqpkNr(MouseButtonFlags param_0000c97c, int param_0000c97d); // 0x00000001810B7650-0x00000001810B7750
		private static bool VJAvTiGJAjWQpqLdvzMxtBhsiBuJ(MouseButtonFlags param_0000c97e, int param_0000c97f); // 0x00000001810B52A0-0x00000001810B52D0
		private static int ehbuqvZMycoCNLbMSlrJgEAhxJr(int param_0000c980); // 0x00000001810B6080-0x00000001810B6110
		internal static bool mDtvTOyiODjBcicqmdrKnRoVnYx(MouseButtonFlags param_0000c981, out int param_0000c982); // 0x00000001810B6C20-0x00000001810B6CD0
		internal static bool zXZcOyXprfvKGdTogolTEsqpkNr(int param_0000c983, MouseButtonFlags param_0000c984, EventTriggerType param_0000c985); // 0x00000001810B7750-0x00000001810B7930
		internal static bool wqlomoLqWqbNsWcBNmubucLvszN(MouseButtonFlags param_0000c986); // 0x00000001810B7590-0x00000001810B7650
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void PiZvjlDfphRqtQeIlaOPmkLmwDj(bool param_0000c987); // 0x00000001810B4C30-0x00000001810B4C40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void DDwUPgHHEKNvYLHTYIUQEMQYUeA(IInteractionStateTransitionHandler param_0000c988, InteractionStateTransitionArgs param_0000c989); // 0x00000001810B32A0-0x00000001810B3350
	}
}
