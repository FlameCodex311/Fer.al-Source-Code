/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public class PlayerController : IPlayerController // TypeDefIndex: 5989
	{
		// Fields
		internal readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x10
		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x14
		private int qInCCRhldamcdoUHmMSlSCAIgFUz; // 0x18
		private readonly AList<Element> OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0x20
		private readonly AList<Button> fjFgJnkphrVLUzcZIWNBokLGbBNJ; // 0x28
		private readonly AList<Axis> BqSdtKydcIEkoWCjLJvCiEzwQMG; // 0x30
		private readonly ReadOnlyCollection<Element> kaRwVFuEhQdielEoQKhHRABCAZN; // 0x38
		private readonly ReadOnlyCollection<Button> QuTkLcsJfPxBFSRuDfxUaqsjZOb; // 0x40
		private readonly ReadOnlyCollection<Axis> HgnDXeeXjaKmhoSMUMJYfFspyCX; // 0x48
		private readonly List<Element.MRSxTLCDMzyoYmLxMtPsgqaOqRM> ioJNlllsMpiwRfzvIjyxgfOErJq; // 0x50
		private Action<int, bool> QrZsEgKYkcJKmjROaBmabjkSdnR; // 0x58
		private Action<int, float> dXAglJjpHkbNtdLxhsZnPZwJEng; // 0x60
		private Action<bool> PqDQtwapHeHHTvTTXUKIVftJHvU; // 0x68
	
		// Properties
		public bool enabled { get; set; } // 0x000000018086EE80-0x000000018086EF20 0x000000018086F2F0-0x000000018086F510
		public int playerId { get; set; } // 0x000000018086EF20-0x000000018086EFC0 0x000000018086F510-0x000000018086F640
		public IList<Button> buttons { get; } // 0x000000018086EC90-0x000000018086ED30 
		public IList<Axis> axes { get; } // 0x000000018086EA90-0x000000018086EB30 
		public IList<Element> elements { get; } // 0x000000018086EDE0-0x000000018086EE80 
		public int buttonCount { get; } // 0x000000018086EBE0-0x000000018086EC90 
		public int axisCount { get; } // 0x000000018086EB30-0x000000018086EBE0 
		public int elementCount { get; } // 0x000000018086ED30-0x000000018086EDE0 
		internal Player player { get; } // 0x000000018086EFC0-0x000000018086F130 
	
		// Events
		public event Action<int, bool> ButtonStateChangedEvent {
			add; // 0x000000018086E160-0x000000018086E260
			remove; // 0x000000018086F1F0-0x000000018086F270
		}
		public event Action<int, float> AxisValueChangedEvent {
			add; // 0x000000018086E060-0x000000018086E160
			remove; // 0x000000018086F170-0x000000018086F1F0
		}
		public event Action<bool> EnabledStateChangedEvent {
			add; // 0x000000018086E260-0x000000018086E350
			remove; // 0x000000018086F270-0x000000018086F2F0
		}
	
		// Nested types
		public class Definition // TypeDefIndex: 5990
		{
			// Fields
			public bool enabled; // 0x10
			public int playerId; // 0x14
			public ICollection<Element.Definition> elements; // 0x18
	
			// Constructors
			public Definition(); // 0x0000000180508DA0-0x0000000180508DC0
		}
	
		public static class Factory // TypeDefIndex: 5991
		{
			// Methods
			public static PlayerController Create(Definition definition); // 0x000000018050A700-0x000000018050A760
		}
	
		public abstract class Element // TypeDefIndex: 5992
		{
			// Fields
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal const bool defaultEnabled = true; // Metadata: 0x0072F770
			private readonly PlayerController PdhGYsFKOBEfRexHgTcxFTVoRup; // 0x10
			private bool mQkcdPwOLpYhTWVqAcbeBDxVqFB; // 0x18
			private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x19
			private string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x20
			private static int[] PXSahuUbHTFSSaAMlGcaxaiteNP; // 0x00
			private static int[] ZoADVVbThOoxQgYAQShsFjMXvcg; // 0x08
	
			// Properties
			protected Player player { get; } // 0x0000000180509E00-0x0000000180509FB0 
			protected bool selfAndParentEnabled { get; } // 0x0000000180509FB0-0x0000000180509FE0 
			internal bool isMemberElement { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018050A050-0x000000018050A060
			public bool enabled { get; set; } // 0x000000018048F440-0x000000018048F450 0x0000000180509FE0-0x000000018050A050
			public string name { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	
			// Nested types
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal enum Type // TypeDefIndex: 5993
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3,
				Axis2D = 100,
				MouseAxis2D = 101,
				MouseWheel = 102
			}
	
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal enum TypeWithSource // TypeDefIndex: 5994
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3
			}
	
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal enum CompoundTypes // TypeDefIndex: 5995
			{
				Axis2D = 100,
				MouseAxis2D = 101,
				MouseWheel = 102
			}
	
			public abstract class Definition // TypeDefIndex: 5996
			{
				// Fields
				public bool enabled; // 0x10
				public string name; // 0x18
	
				// Constructors
				public Definition(); // 0x0000000180508D70-0x0000000180508DA0
	
				// Methods
				internal abstract Element CreateElement(PlayerController param_0000cc19);
			}
	
			internal struct MRSxTLCDMzyoYmLxMtPsgqaOqRM // TypeDefIndex: 5997
			{
				// Fields
				public ControllerElementType xeMmavuWtuUUxDhpNKJkwIubLnW; // 0x00
				public int sTgsnEJuUoRNnuSXfCYtcCJrAEKa; // 0x04
				public float PLdosENimxvPBjeGrIWuaBaRuLxb; // 0x08
	
				// Constructors
				public MRSxTLCDMzyoYmLxMtPsgqaOqRM(ControllerElementType elementType, int index, float value); // 0x0000000180006720-0x0000000180006730
			}
	
			// Constructors
			internal Element(PlayerController parent, Definition definition); // 0x0000000180509D30-0x0000000180509E00
	
			// Methods
			internal virtual void Update(); // 0x00000001803581E0-0x00000001803581F0
			protected virtual void EnabledStateChanged(bool state); // 0x00000001803581E0-0x00000001803581F0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal static bool IsTypeWithSource(Type type); // 0x0000000180509C20-0x0000000180509D30
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal static bool IsCompoundType(Type type); // 0x0000000180509AE0-0x0000000180509C20
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal static int GetMaxElementCount(Type type); // 0x00000001805099F0-0x0000000180509AE0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal static string GetElementTitle(Type type, int index); // 0x00000001805097F0-0x00000001805099F0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal static Definition CreateDefinition(Type type); // 0x0000000180509670-0x00000001805097F0
		}
	
		public abstract class ElementWithSource : Element // TypeDefIndex: 5998
		{
			// Fields
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal const int defaultActionId = -1; // Metadata: 0x0072F7A9
			private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x28
	
			// Properties
			public int actionId { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
			public string actionName { get; set; } // 0x00000001805093F0-0x0000000180509500 0x0000000180509500-0x0000000180509670
	
			// Nested types
			public abstract class Definition : Element.Definition // TypeDefIndex: 5999
			{
				// Fields
				private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x20
	
				// Properties
				public int actionId { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
				public string actionName { get; set; } // 0x0000000180508F10-0x0000000180509030 0x00000001805091F0-0x0000000180509310
	
				// Constructors
				public Definition(); // 0x0000000180508E20-0x0000000180508E50
			}
	
			// Constructors
			internal ElementWithSource(PlayerController parent, Definition definition); // 0x0000000180509310-0x00000001805093F0
		}
	
		public class Axis : ElementWithSource // TypeDefIndex: 6000
		{
			// Fields
			internal const float OrWBWiLwNqnZDmxoCxBcQKPNBnv = 1f; // Metadata: 0x0072F7AD
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Absolute; // Metadata: 0x0072F7B1
			private float fiuUYpYCXYmOYvTUhvXpiNXbiMp; // 0x30
			private AxisCoordinateMode nOaMmPosthuskIXXGxomFGYeVyS; // 0x34
			private bool JkROLnyJhuWmKzuyOKpacGRAqbA; // 0x38
	
			// Properties
			public float absoluteToRelativeSensitivity { get; set; } // 0x0000000180485990-0x00000001804859A0 0x000000018086A890-0x000000018086A8A0
			public AxisCoordinateMode coordinateMode { get; } // 0x000000018043E170-0x000000018043E180 
			public virtual float value { get; } // 0x000000018086A6D0-0x000000018086A890 
			public virtual float valueRaw { get; } // 0x000000018086A670-0x000000018086A6D0 
	
			// Nested types
			public class Definition : ElementWithSource.Definition // TypeDefIndex: 6001
			{
				// Fields
				public AxisCoordinateMode coordinateMode; // 0x28
				public float absoluteToRelativeSensitivity; // 0x2C
	
				// Constructors
				public Definition(); // 0x000000018086B110-0x000000018086B140
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cc26); // 0x000000018086AFD0-0x000000018086B090
			}
	
			// Constructors
			internal Axis(PlayerController parent, Definition definition); // 0x000000018086A5F0-0x000000018086A670
		}
	
		public class MouseAxis : Axis // TypeDefIndex: 6002
		{
			// Fields
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative; // Metadata: 0x0072F7B5
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal const float defaultAbsoluteToRelativeSensitivity = 600f; // Metadata: 0x0072F7B9
	
			// Properties
			public override float value { get; } // 0x000000018050AA80-0x000000018050AB20 
	
			// Nested types
			public class Definition : Axis.Definition // TypeDefIndex: 6003
			{
				// Constructors
				public Definition(); // 0x0000000180508DD0-0x0000000180508E20
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cc29); // 0x0000000180508C90-0x0000000180508D00
			}
	
			// Constructors
			internal MouseAxis(PlayerController parent, Definition definition); // 0x000000018050AA70-0x000000018050AA80
		}
	
		public abstract class CompoundElement : Element // TypeDefIndex: 6004
		{
			// Fields
			private readonly List<Element> OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0x28
	
			// Properties
			internal int elementCount { get; } // 0x000000018086AF20-0x000000018086AF60 
	
			// Nested types
			public abstract class Definition : Element.Definition // TypeDefIndex: 6005
			{
				// Constructors
				public Definition(); // 0x0000000180508D70-0x0000000180508DA0
			}
	
			// Constructors
			internal CompoundElement(PlayerController parent, Definition definition, Definition[] elementDefinitions); // 0x000000018086ACE0-0x000000018086AE80
	
			// Methods
			internal T UGlMdiDpLKJKtHXHHJEhBRhmhUC<T>(int param_0000cc2d)
				where T : Element;
			internal void VFCQQBTYSyadaLgMiblsyszoGYwh(List<Element> param_0000cc2e); // 0x000000018086AA70-0x000000018086ACE0
			internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000cc2f); // 0x000000018086AE80-0x000000018086AF20
		}
	
		public class Axis2D : CompoundElement // TypeDefIndex: 6006
		{
			// Fields
			internal const int vMTMrrWvhVGfeqJuWtvMfyPeZcT = 0; // Metadata: 0x0072F7BD
			internal const int rhChdatIyapyNgCVkAAwHxvYlfLJ = 1; // Metadata: 0x0072F7C1
			internal const int jAtgQVtGRPKRJusJhmABUujfutp = 2; // Metadata: 0x0072F7C5
	
			// Properties
			public Axis xAxis { get; } // 0x000000018086A570-0x000000018086A5B0 
			public Axis yAxis { get; } // 0x000000018086A5B0-0x000000018086A5F0 
			public virtual Vector2 value { get; } // 0x000000018086A4B0-0x000000018086A570 
			public virtual Vector2 valueRaw { get; } // 0x000000018086A3F0-0x000000018086A4B0 
	
			// Nested types
			public class Definition : CompoundElement.Definition // TypeDefIndex: 6007
			{
				// Fields
				private Axis.Definition VliJwwvajVbJxXXRGIsrSMzSWjL; // 0x20
				private Axis.Definition NMrHUNqNrEgrMrkSNHUphwfnbeW; // 0x28
	
				// Properties
				public Axis.Definition xAxis { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
				public Axis.Definition yAxis { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
				// Constructors
				public Definition(); // 0x000000018086B100-0x000000018086B110
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cc37); // 0x000000018086B090-0x000000018086B100
			}
	
			// Constructors
			internal Axis2D(PlayerController parent, Definition definition, Definition[] definitions); // 0x000000018086A230-0x000000018086A240
			internal Axis2D(PlayerController parent, Definition definition); // 0x000000018086A240-0x000000018086A3F0
		}
	
		public sealed class MouseAxis2D : Axis2D // TypeDefIndex: 6008
		{
			// Properties
			public new MouseAxis xAxis { get; } // 0x000000018050A9F0-0x000000018050AA30 
			public new MouseAxis yAxis { get; } // 0x000000018050AA30-0x000000018050AA70 
	
			// Nested types
			public class Definition : Axis2D.Definition // TypeDefIndex: 6009
			{
				// Properties
				public new MouseAxis.Definition xAxis { get; set; } // 0x0000000180509030-0x00000001805090A0 0x000000018036AC90-0x000000018036ACA0
				public new MouseAxis.Definition yAxis { get; set; } // 0x0000000180509110-0x0000000180509180 0x0000000180422D30-0x0000000180422D40
	
				// Constructors
				public Definition(); // 0x0000000180508DC0-0x0000000180508DD0
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cc3c); // 0x0000000180508D00-0x0000000180508D70
			}
	
			// Constructors
			internal MouseAxis2D(PlayerController parent, Definition definition); // 0x000000018050A7D0-0x000000018050A9F0
		}
	
		public sealed class Button : ElementWithSource // TypeDefIndex: 6010
		{
			// Properties
			public bool value { get; } // 0x000000018086AA10-0x000000018086AA70 
			public bool valuePrev { get; } // 0x000000018086A9B0-0x000000018086AA10 
			public bool justPressed { get; } // 0x000000018086A8B0-0x000000018086A930 
			public bool justReleased { get; } // 0x000000018086A930-0x000000018086A9B0 
	
			// Nested types
			public class Definition : ElementWithSource.Definition // TypeDefIndex: 6011
			{
				// Constructors
				public Definition(); // 0x000000018086B140-0x000000018086B150
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cc3f); // 0x000000018086AF60-0x000000018086AFD0
			}
	
			// Constructors
			internal Button(PlayerController parent, Definition definition); // 0x000000018086A8A0-0x000000018086A8B0
		}
	
		public sealed class MouseWheel : Axis2D // TypeDefIndex: 6012
		{
			// Properties
			public new MouseWheelAxis xAxis { get; } // 0x000000018050B200-0x000000018050B240 
			public new MouseWheelAxis yAxis { get; } // 0x000000018050B240-0x000000018050B280 
	
			// Nested types
			public class Definition : Axis2D.Definition // TypeDefIndex: 6013
			{
				// Properties
				public new MouseWheelAxis.Definition xAxis { get; set; } // 0x00000001805090A0-0x0000000180509110 0x000000018036AC90-0x000000018036ACA0
				public new MouseWheelAxis.Definition yAxis { get; set; } // 0x0000000180509180-0x00000001805091F0 0x0000000180422D30-0x0000000180422D40
	
				// Constructors
				public Definition(); // 0x0000000180508DC0-0x0000000180508DD0
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cc44); // 0x0000000180508B30-0x0000000180508BA0
			}
	
			// Constructors
			internal MouseWheel(PlayerController parent, Definition definition); // 0x000000018050B020-0x000000018050B200
		}
	
		public sealed class MouseWheelAxis : Axis // TypeDefIndex: 6014
		{
			// Fields
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal const float defaultRepeatRate = 4f; // Metadata: 0x0072F7C9
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative; // Metadata: 0x0072F7CD
			private const float NnORUHpefPaoPacfdBpHlxUsvoK = 0.01f; // Metadata: 0x0072F7D1
			private float jjHSfqqDeWRWsomgdKSrKqCmiEm; // 0x40
			private float DyokgikgtwkeAsBaySPCuczefavJ; // 0x44
			private float FsxdnKHTiBkQzQeLhcyCJCYysFt; // 0x48
	
			// Properties
			public float repeatRate { get; set; } // 0x000000018050AF50-0x000000018050AF70 0x000000018050AFB0-0x000000018050B010
			public override float value { get; } // 0x000000018050AF70-0x000000018050AFB0 
	
			// Nested types
			public class Definition : Axis.Definition // TypeDefIndex: 6015
			{
				// Fields
				public float repeatRate; // 0x30
	
				// Constructors
				public Definition(); // 0x0000000180508EE0-0x0000000180508F10
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cc49); // 0x0000000180508BA0-0x0000000180508C90
			}
	
			// Constructors
			internal MouseWheelAxis(PlayerController parent, Definition definition); // 0x000000018050AEB0-0x000000018050AF50
	
			// Methods
			internal override void Update(); // 0x000000018050AE70-0x000000018050AEB0
			protected override void EnabledStateChanged(bool state); // 0x000000018050AB20-0x000000018050AB60
			private float JsyZcAsJkGtpxRoNnaQEhifEbJg(); // 0x000000018050AB60-0x000000018050AE70
			private void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x000000018050B010-0x000000018050B020
		}
	
		// Constructors
		internal PlayerController(Definition definition); // 0x000000018086DA80-0x000000018086E060
	
		// Methods
		~PlayerController(); // 0x000000018086C9B0-0x000000018086CAA0
		public bool GetButton(int index); // 0x000000018086CE80-0x000000018086CFC0
		public bool GetButtonDown(int index); // 0x000000018086CCA0-0x000000018086CD90
		public bool GetButtonUp(int index); // 0x000000018086CD90-0x000000018086CE80
		public float GetAxis(int index); // 0x000000018086CBA0-0x000000018086CCA0
		public float GetAxisRaw(int index); // 0x000000018086CAA0-0x000000018086CBA0
		public Element GetElement(int index); // 0x000000018086CFC0-0x000000018086D0A0
		public T GetElement<T>(int index)
			where T : Element;
		private void kEjGWRDBbQIibaQyqmAVnMEsGYGe(UpdateLoopType param_0000cc01); // 0x000000018086F130-0x000000018086F170
		protected virtual bool Update(UpdateLoopType updateLoop); // 0x000000018086D260-0x000000018086DA80
		protected virtual void UpdateFinished(); // 0x000000018086D0A0-0x000000018086D260
		protected virtual void ClearVars(); // 0x000000018086C960-0x000000018086C9B0
		internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000cc03); // 0x000000018086E350-0x000000018086E510
		private void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000cc04, List<Element> param_0000cc05, List<Element> param_0000cc06, List<Button> param_0000cc07, List<Axis> param_0000cc08); // 0x000000018086E510-0x000000018086EA90
		internal static int ewjdgwCsnIlEmBYngRXHuyJOgDwI<T>(IList<T> param_0000cc09, Predicate<T> param_0000cc0a, int param_0000cc0b)
			where T : Element;
	}
}
