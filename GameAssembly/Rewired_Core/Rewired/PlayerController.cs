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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public class PlayerController : IPlayerController // TypeDefIndex: 6148
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
		public bool enabled { get; set; } // 0x00000001811D7830-0x00000001811D78D0 0x00000001811D7CA0-0x00000001811D7EC0
		public int playerId { get; set; } // 0x00000001811D78D0-0x00000001811D7970 0x00000001811D7EC0-0x00000001811D7FF0
		public IList<Button> buttons { get; } // 0x00000001811D7640-0x00000001811D76E0 
		public IList<Axis> axes { get; } // 0x00000001811D7440-0x00000001811D74E0 
		public IList<Element> elements { get; } // 0x00000001811D7790-0x00000001811D7830 
		public int buttonCount { get; } // 0x00000001811D7590-0x00000001811D7640 
		public int axisCount { get; } // 0x00000001811D74E0-0x00000001811D7590 
		public int elementCount { get; } // 0x00000001811D76E0-0x00000001811D7790 
		internal Player player { get; } // 0x00000001811D7970-0x00000001811D7AE0 
	
		// Events
		public event Action<int, bool> ButtonStateChangedEvent {
			add; // 0x00000001811D6B20-0x00000001811D6C20
			remove; // 0x00000001811D7BA0-0x00000001811D7C20
		}
		public event Action<int, float> AxisValueChangedEvent {
			add; // 0x00000001811D6A20-0x00000001811D6B20
			remove; // 0x00000001811D7B20-0x00000001811D7BA0
		}
		public event Action<bool> EnabledStateChangedEvent {
			add; // 0x00000001811D6C20-0x00000001811D6D10
			remove; // 0x00000001811D7C20-0x00000001811D7CA0
		}
	
		// Nested types
		public class Definition // TypeDefIndex: 6149
		{
			// Fields
			public bool enabled; // 0x10
			public int playerId; // 0x14
			public ICollection<Element.Definition> elements; // 0x18
	
			// Constructors
			public Definition(); // 0x0000000180B31080-0x0000000180B310A0
		}
	
		public static class Factory // TypeDefIndex: 6150
		{
			// Methods
			public static PlayerController Create(Definition definition); // 0x0000000180B329A0-0x0000000180B32A00
		}
	
		public abstract class Element // TypeDefIndex: 6151
		{
			// Fields
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal const bool defaultEnabled = true; // Metadata: 0x0076440D
			private readonly PlayerController PdhGYsFKOBEfRexHgTcxFTVoRup; // 0x10
			private bool mQkcdPwOLpYhTWVqAcbeBDxVqFB; // 0x18
			private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb; // 0x19
			private string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x20
			private static int[] PXSahuUbHTFSSaAMlGcaxaiteNP; // 0x00
			private static int[] ZoADVVbThOoxQgYAQShsFjMXvcg; // 0x08
	
			// Properties
			protected Player player { get; } // 0x0000000180B320B0-0x0000000180B32260 
			protected bool selfAndParentEnabled { get; } // 0x0000000180B32260-0x0000000180B32290 
			internal bool isMemberElement { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x0000000180B32300-0x0000000180B32310
			public bool enabled { get; set; } // 0x0000000180690340-0x0000000180690350 0x0000000180B32290-0x0000000180B32300
			public string name { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	
			// Nested types
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal enum Type // TypeDefIndex: 6152
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3,
				Axis2D = 100,
				MouseAxis2D = 101,
				MouseWheel = 102
			}
	
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal enum TypeWithSource // TypeDefIndex: 6153
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3
			}
	
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal enum CompoundTypes // TypeDefIndex: 6154
			{
				Axis2D = 100,
				MouseAxis2D = 101,
				MouseWheel = 102
			}
	
			public abstract class Definition // TypeDefIndex: 6155
			{
				// Fields
				public bool enabled; // 0x10
				public string name; // 0x18
	
				// Constructors
				public Definition(); // 0x0000000180B31050-0x0000000180B31080
	
				// Methods
				internal abstract Element CreateElement(PlayerController param_0000ce89);
			}
	
			internal struct MRSxTLCDMzyoYmLxMtPsgqaOqRM // TypeDefIndex: 6156
			{
				// Fields
				public ControllerElementType xeMmavuWtuUUxDhpNKJkwIubLnW; // 0x00
				public int sTgsnEJuUoRNnuSXfCYtcCJrAEKa; // 0x04
				public float PLdosENimxvPBjeGrIWuaBaRuLxb; // 0x08
	
				// Constructors
				public MRSxTLCDMzyoYmLxMtPsgqaOqRM(ControllerElementType elementType, int index, float value); // 0x0000000180022490-0x00000001800224A0
			}
	
			// Constructors
			internal Element(PlayerController parent, Definition definition); // 0x0000000180B31FE0-0x0000000180B320B0
	
			// Methods
			internal virtual void Update(); // 0x00000001803774A0-0x00000001803774B0
			protected virtual void EnabledStateChanged(bool state); // 0x00000001803774A0-0x00000001803774B0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal static bool IsTypeWithSource(Type type); // 0x0000000180B31ED0-0x0000000180B31FE0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal static bool IsCompoundType(Type type); // 0x0000000180B31D90-0x0000000180B31ED0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal static int GetMaxElementCount(Type type); // 0x0000000180B31CB0-0x0000000180B31D90
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal static string GetElementTitle(Type type, int index); // 0x0000000180B31AC0-0x0000000180B31CB0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal static Definition CreateDefinition(Type type); // 0x0000000180B31940-0x0000000180B31AC0
		}
	
		public abstract class ElementWithSource : Element // TypeDefIndex: 6157
		{
			// Fields
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal const int defaultActionId = -1; // Metadata: 0x00764446
			private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x28
	
			// Properties
			public int actionId { get; set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
			public string actionName { get; set; } // 0x0000000180B316D0-0x0000000180B317E0 0x0000000180B317E0-0x0000000180B31940
	
			// Nested types
			public abstract class Definition : Element.Definition // TypeDefIndex: 6158
			{
				// Fields
				private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x20
	
				// Properties
				public int actionId { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
				public string actionName { get; set; } // 0x0000000180B311F0-0x0000000180B31310 0x0000000180B314D0-0x0000000180B315F0
	
				// Constructors
				public Definition(); // 0x0000000180B31100-0x0000000180B31130
			}
	
			// Constructors
			internal ElementWithSource(PlayerController parent, Definition definition); // 0x0000000180B315F0-0x0000000180B316D0
		}
	
		public class Axis : ElementWithSource // TypeDefIndex: 6159
		{
			// Fields
			internal const float OrWBWiLwNqnZDmxoCxBcQKPNBnv = 1f; // Metadata: 0x0076444A
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Absolute; // Metadata: 0x0076444E
			private float fiuUYpYCXYmOYvTUhvXpiNXbiMp; // 0x30
			private AxisCoordinateMode nOaMmPosthuskIXXGxomFGYeVyS; // 0x34
			private bool JkROLnyJhuWmKzuyOKpacGRAqbA; // 0x38
	
			// Properties
			public float absoluteToRelativeSensitivity { get; set; } // 0x00000001806757B0-0x00000001806757C0 0x00000001811D3170-0x00000001811D3180
			public AxisCoordinateMode coordinateMode { get; } // 0x00000001804EF8F0-0x00000001804EF900 
			public virtual float value { get; } // 0x00000001811D2FC0-0x00000001811D3170 
			public virtual float valueRaw { get; } // 0x00000001811D2F60-0x00000001811D2FC0 
	
			// Nested types
			public class Definition : ElementWithSource.Definition // TypeDefIndex: 6160
			{
				// Fields
				public AxisCoordinateMode coordinateMode; // 0x28
				public float absoluteToRelativeSensitivity; // 0x2C
	
				// Constructors
				public Definition(); // 0x00000001811D3B40-0x00000001811D3B70
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000ce96); // 0x00000001811D38A0-0x00000001811D3960
			}
	
			// Constructors
			internal Axis(PlayerController parent, Definition definition); // 0x00000001811D2EE0-0x00000001811D2F60
		}
	
		public class MouseAxis : Axis // TypeDefIndex: 6161
		{
			// Fields
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative; // Metadata: 0x00764452
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal const float defaultAbsoluteToRelativeSensitivity = 600f; // Metadata: 0x00764456
	
			// Properties
			public override float value { get; } // 0x0000000180B32D10-0x0000000180B32DB0 
	
			// Nested types
			public class Definition : Axis.Definition // TypeDefIndex: 6162
			{
				// Constructors
				public Definition(); // 0x0000000180B310B0-0x0000000180B31100
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000ce99); // 0x0000000180B30F70-0x0000000180B30FE0
			}
	
			// Constructors
			internal MouseAxis(PlayerController parent, Definition definition); // 0x0000000180B32D00-0x0000000180B32D10
		}
	
		public abstract class CompoundElement : Element // TypeDefIndex: 6163
		{
			// Fields
			private readonly List<Element> OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0x28
	
			// Properties
			internal int elementCount { get; } // 0x00000001811D37F0-0x00000001811D3830 
	
			// Nested types
			public abstract class Definition : Element.Definition // TypeDefIndex: 6164
			{
				// Constructors
				public Definition(); // 0x0000000180B31050-0x0000000180B31080
			}
	
			// Constructors
			internal CompoundElement(PlayerController parent, Definition definition, Definition[] elementDefinitions); // 0x00000001811D35C0-0x00000001811D3750
	
			// Methods
			internal T UGlMdiDpLKJKtHXHHJEhBRhmhUC<T>(int param_0000ce9d)
				where T : Element;
			internal void VFCQQBTYSyadaLgMiblsyszoGYwh(List<Element> param_0000ce9e); // 0x00000001811D3350-0x00000001811D35C0
			internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000ce9f); // 0x00000001811D3750-0x00000001811D37F0
		}
	
		public class Axis2D : CompoundElement // TypeDefIndex: 6165
		{
			// Fields
			internal const int vMTMrrWvhVGfeqJuWtvMfyPeZcT = 0; // Metadata: 0x0076445A
			internal const int rhChdatIyapyNgCVkAAwHxvYlfLJ = 1; // Metadata: 0x0076445E
			internal const int jAtgQVtGRPKRJusJhmABUujfutp = 2; // Metadata: 0x00764462
	
			// Properties
			public Axis xAxis { get; } // 0x00000001811D2E60-0x00000001811D2EA0 
			public Axis yAxis { get; } // 0x00000001811D2EA0-0x00000001811D2EE0 
			public virtual Vector2 value { get; } // 0x00000001811D2DA0-0x00000001811D2E60 
			public virtual Vector2 valueRaw { get; } // 0x00000001811D2CE0-0x00000001811D2DA0 
	
			// Nested types
			public class Definition : CompoundElement.Definition // TypeDefIndex: 6166
			{
				// Fields
				private Axis.Definition VliJwwvajVbJxXXRGIsrSMzSWjL; // 0x20
				private Axis.Definition NMrHUNqNrEgrMrkSNHUphwfnbeW; // 0x28
	
				// Properties
				public Axis.Definition xAxis { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
				public Axis.Definition yAxis { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
				// Constructors
				public Definition(); // 0x00000001811D3B30-0x00000001811D3B40
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000cea7); // 0x00000001811D3960-0x00000001811D3B30
			}
	
			// Constructors
			internal Axis2D(PlayerController parent, Definition definition, Definition[] definitions); // 0x00000001811D2B30-0x00000001811D2B40
			internal Axis2D(PlayerController parent, Definition definition); // 0x00000001811D2B40-0x00000001811D2CE0
		}
	
		public sealed class MouseAxis2D : Axis2D // TypeDefIndex: 6167
		{
			// Properties
			public new MouseAxis xAxis { get; } // 0x0000000180B32C80-0x0000000180B32CC0 
			public new MouseAxis yAxis { get; } // 0x0000000180B32CC0-0x0000000180B32D00 
	
			// Nested types
			public class Definition : Axis2D.Definition // TypeDefIndex: 6168
			{
				// Properties
				public new MouseAxis.Definition xAxis { get; set; } // 0x0000000180B31310-0x0000000180B31380 0x00000001803F70C0-0x00000001803F70D0
				public new MouseAxis.Definition yAxis { get; set; } // 0x0000000180B313F0-0x0000000180B31460 0x00000001803FA0C0-0x00000001803FA0D0
	
				// Constructors
				public Definition(); // 0x0000000180B310A0-0x0000000180B310B0
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000ceac); // 0x0000000180B30FE0-0x0000000180B31050
			}
	
			// Constructors
			internal MouseAxis2D(PlayerController parent, Definition definition); // 0x0000000180B32A70-0x0000000180B32C80
		}
	
		public sealed class Button : ElementWithSource // TypeDefIndex: 6169
		{
			// Properties
			public bool value { get; } // 0x00000001811D32F0-0x00000001811D3350 
			public bool valuePrev { get; } // 0x00000001811D3290-0x00000001811D32F0 
			public bool justPressed { get; } // 0x00000001811D3190-0x00000001811D3210 
			public bool justReleased { get; } // 0x00000001811D3210-0x00000001811D3290 
	
			// Nested types
			public class Definition : ElementWithSource.Definition // TypeDefIndex: 6170
			{
				// Constructors
				public Definition(); // 0x00000001811D3B70-0x00000001811D3B80
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000ceaf); // 0x00000001811D3830-0x00000001811D38A0
			}
	
			// Constructors
			internal Button(PlayerController parent, Definition definition); // 0x00000001811D3180-0x00000001811D3190
		}
	
		public sealed class MouseWheel : Axis2D // TypeDefIndex: 6171
		{
			// Properties
			public new MouseWheelAxis xAxis { get; } // 0x0000000180B33470-0x0000000180B334B0 
			public new MouseWheelAxis yAxis { get; } // 0x0000000180B334B0-0x0000000180B334F0 
	
			// Nested types
			public class Definition : Axis2D.Definition // TypeDefIndex: 6172
			{
				// Properties
				public new MouseWheelAxis.Definition xAxis { get; set; } // 0x0000000180B31380-0x0000000180B313F0 0x00000001803F70C0-0x00000001803F70D0
				public new MouseWheelAxis.Definition yAxis { get; set; } // 0x0000000180B31460-0x0000000180B314D0 0x00000001803FA0C0-0x00000001803FA0D0
	
				// Constructors
				public Definition(); // 0x0000000180B310A0-0x0000000180B310B0
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000ceb4); // 0x0000000180B30E10-0x0000000180B30E80
			}
	
			// Constructors
			internal MouseWheel(PlayerController parent, Definition definition); // 0x0000000180B332A0-0x0000000180B33470
		}
	
		public sealed class MouseWheelAxis : Axis // TypeDefIndex: 6173
		{
			// Fields
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal const float defaultRepeatRate = 4f; // Metadata: 0x00764466
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Relative; // Metadata: 0x0076446A
			private const float NnORUHpefPaoPacfdBpHlxUsvoK = 0.01f; // Metadata: 0x0076446E
			private float jjHSfqqDeWRWsomgdKSrKqCmiEm; // 0x40
			private float DyokgikgtwkeAsBaySPCuczefavJ; // 0x44
			private float FsxdnKHTiBkQzQeLhcyCJCYysFt; // 0x48
	
			// Properties
			public float repeatRate { get; set; } // 0x0000000180B331D0-0x0000000180B331F0 0x0000000180B33230-0x0000000180B33290
			public override float value { get; } // 0x0000000180B331F0-0x0000000180B33230 
	
			// Nested types
			public class Definition : Axis.Definition // TypeDefIndex: 6174
			{
				// Fields
				public float repeatRate; // 0x30
	
				// Constructors
				public Definition(); // 0x0000000180B311C0-0x0000000180B311F0
	
				// Methods
				internal override Element CreateElement(PlayerController param_0000ceb9); // 0x0000000180B30E80-0x0000000180B30F70
			}
	
			// Constructors
			internal MouseWheelAxis(PlayerController parent, Definition definition); // 0x0000000180B33130-0x0000000180B331D0
	
			// Methods
			internal override void Update(); // 0x0000000180B330F0-0x0000000180B33130
			protected override void EnabledStateChanged(bool state); // 0x0000000180B32DB0-0x0000000180B32DF0
			private float JsyZcAsJkGtpxRoNnaQEhifEbJg(); // 0x0000000180B32DF0-0x0000000180B330F0
			private void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x0000000180B33290-0x0000000180B332A0
		}
	
		// Constructors
		internal PlayerController(Definition definition); // 0x00000001811D6460-0x00000001811D6A20
	
		// Methods
		~PlayerController(); // 0x00000001811D53B0-0x00000001811D54A0
		public bool GetButton(int index); // 0x00000001811D5880-0x00000001811D59C0
		public bool GetButtonDown(int index); // 0x00000001811D56A0-0x00000001811D5790
		public bool GetButtonUp(int index); // 0x00000001811D5790-0x00000001811D5880
		public float GetAxis(int index); // 0x00000001811D55A0-0x00000001811D56A0
		public float GetAxisRaw(int index); // 0x00000001811D54A0-0x00000001811D55A0
		public Element GetElement(int index); // 0x00000001811D59C0-0x00000001811D5AA0
		public T GetElement<T>(int index)
			where T : Element;
		private void kEjGWRDBbQIibaQyqmAVnMEsGYGe(UpdateLoopType param_0000ce71); // 0x00000001811D7AE0-0x00000001811D7B20
		protected virtual bool Update(UpdateLoopType updateLoop); // 0x00000001811D5C50-0x00000001811D6460
		protected virtual void UpdateFinished(); // 0x00000001811D5AA0-0x00000001811D5C50
		protected virtual void ClearVars(); // 0x00000001811D5360-0x00000001811D53B0
		internal void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000ce73); // 0x00000001811D6D10-0x00000001811D6ED0
		private void eMLWHPWlVLcjuKEIpkdHeEbTVNGo(Element param_0000ce74, List<Element> param_0000ce75, List<Element> param_0000ce76, List<Button> param_0000ce77, List<Axis> param_0000ce78); // 0x00000001811D6ED0-0x00000001811D7440
		internal static int ewjdgwCsnIlEmBYngRXHuyJOgDwI<T>(IList<T> param_0000ce79, Predicate<T> param_0000ce7a, int param_0000ce7b)
			where T : Element;
	}
}
