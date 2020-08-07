/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public abstract class ControllerMap // TypeDefIndex: 6667
	{
		// Fields
		protected int _id; // 0x10
		protected int _sourceMapId; // 0x14
		protected int _categoryId; // 0x18
		protected int _layoutId; // 0x1C
		protected string _name; // 0x20
		protected Guid _hardwareGuid; // 0x28
		protected bool _enabled; // 0x38
		internal readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x3C
		private readonly AList<ActionElementMap> yWpPsagHSVgRPacxUoojGfqEKmda; // 0x40
		private readonly ReadOnlyCollection<ActionElementMap> eFAVjhpIRHLgwmoNSEOSOpirTwI; // 0x48
		private readonly AList<ActionElementMap> BohAGnsjjxuOYHfhKphUKbZxLNl; // 0x50
		private readonly ReadOnlyCollection<ActionElementMap> JNrknNTAIwCCdJZGdAXTwuDNEET; // 0x58
		protected int _playerId; // 0x60
		protected int _controllerId; // 0x64
		protected ControllerType _controllerType; // 0x68
		private static int opOBHHseJkiuPTdqFxSPSFfBWwf; // 0x00
	
		// Properties
		private static int nextUid { get; } // 0x00000001808D44E0-0x00000001808D45C0 
		public int id { get; } // 0x00000001808D42F0-0x00000001808D4390 
		public int sourceMapId { get; internal set; } // 0x00000001808D4730-0x00000001808D47D0 0x00000001803FD620-0x00000001803FD630
		public int categoryId { get; internal set; } // 0x00000001808D3DD0-0x00000001808D3E70 0x00000001803F46C0-0x00000001803F46D0
		public int layoutId { get; internal set; } // 0x00000001808D4390-0x00000001808D4430 0x000000018042D0F0-0x000000018042D100
		public string name { get; internal set; } // 0x00000001808D4430-0x00000001808D44E0 0x00000001803F70C0-0x00000001803F70D0
		public Guid hardwareGuid { get; internal set; } // 0x00000001808D4210-0x00000001808D42F0 0x000000018041B740-0x000000018041B750
		public bool enabled { get; set; } // 0x00000001808D4170-0x00000001808D4210 0x00000001804F1690-0x00000001804F16A0
		public int playerId { get; internal set; } // 0x00000001808D45C0-0x00000001808D4660 0x00000001804ADAB0-0x00000001804ADAC0
		public int controllerId { get; internal set; } // 0x00000001808D3E70-0x00000001808D3F40 0x00000001808D4EB0-0x00000001808D4EC0
		public Controller controller { get; } // 0x00000001808D3FE0-0x00000001808D40C0 
		public ControllerType controllerType { get; internal set; } // 0x00000001808D3F40-0x00000001808D3FE0 0x00000001806F4B40-0x00000001806F4B50
		public Player player { get; } // 0x00000001808D4660-0x00000001808D4730 
		public int elementMapCount { get; } // 0x00000001808D40C0-0x00000001808D4170 
		public int buttonMapCount { get; } // 0x00000001808D3D20-0x00000001808D3DD0 
		public IList<ActionElementMap> AllMaps { get; } // 0x00000001808D3BC0-0x00000001808D3C70 
		public IList<ActionElementMap> ButtonMaps { get; } // 0x00000001808D3C70-0x00000001808D3D20 
		internal AList<ActionElementMap> ButtonMaps_orig { get; } // 0x00000001803C7290-0x00000001803C72A0 
	
		// Nested types
		private class FxHeXoCttgoRDEovXylvLhGTHdg : IComparer<ActionElementMap> // TypeDefIndex: 6668
		{
			// Fields
			public static FxHeXoCttgoRDEovXylvLhGTHdg DqYmGHECTlrDVQmfbrCSLOJGmsK; // 0x00
	
			// Properties
			public static FxHeXoCttgoRDEovXylvLhGTHdg ABeAWOemtDNDbkuEcBndYTrwdsCb { get; } // 0x00000001814A9140-0x00000001814A91B0 
	
			// Constructors
			public FxHeXoCttgoRDEovXylvLhGTHdg(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public int Compare(ActionElementMap x, ActionElementMap y); // 0x00000001814A8F10-0x00000001814A9140
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class fSTsTyNwHdFpJgZOmCmfdGjrEmr : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6669
		{
			// Fields
			private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public ControllerMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x28
			public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x2C
			public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x30
			public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x31
			public ActionElementMap ahESsJWqUpyzUlLsHRXpNjeRdlx; // 0x38
			public IEnumerator<ActionElementMap> ObCTocXbDfexIJHQKyCeqKyLZAQ; // 0x40
	
			// Properties
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public fSTsTyNwHdFpJgZOmCmfdGjrEmr(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001814B2900-0x00000001814B2A10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814B2900-0x00000001814B2A10
			private bool MoveNext(); // 0x00000001814B25D0-0x00000001814B2900
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814B2A10-0x00000001814B2A60
			void IDisposable.Dispose(); // 0x00000001814B2A60-0x00000001814B2B10
			private void UyxqCTivFhKkftRJACbuayqJVBII(); // 0x00000001814B2B10-0x00000001814B2B60
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class danrepvLqbfWQRsqHADtwUmjeoG : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6670
		{
			// Fields
			private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public ControllerMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public IControllerElementTarget VFwMDZMYrBvQvqPfgitohgKyAGR; // 0x28
			public IControllerElementTarget nCYudTpjINOmBpcFqbImQYuVzYO; // 0x30
			public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x38
			public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x39
			public TempListPool.TList<ActionElementMap> odiSvEKrvjCAFxiOJELOQtxBJGO; // 0x40
			public List<ActionElementMap> HodINAnlQZSUJenxtfRdpfMUakA; // 0x48
			public bool UUCqWWlNgxPhhsjzkHDUomBSdwRb; // 0x50
			public ActionElementMap EXsMxTaExpPZsqVCHaKzgifAfHMB; // 0x58
			public List<ActionElementMap> otHDqafzKaBAjPrQAetGliHTzvmM; // 0x60
	
			// Properties
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public danrepvLqbfWQRsqHADtwUmjeoG(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001814B1BB0-0x00000001814B1D10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814B1BB0-0x00000001814B1D10
			private bool MoveNext(); // 0x00000001814B1890-0x00000001814B1BB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814B1D10-0x00000001814B1D60
			void IDisposable.Dispose(); // 0x00000001814B1D60-0x00000001814B1E90
			private void VwBvbSfUDfldJESYzjPxVNKPpgB(); // 0x00000001814B1E90-0x00000001814B1EE0
			private void eZzXMgOVZJHRzuzUIdzvEniFART(); // 0x00000001814B1EE0-0x00000001814B1F20
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class dyOkQlIypnnAoaGbjpojWOlTvvC : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6671
		{
			// Fields
			private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public ControllerMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public IControllerElementTarget VFwMDZMYrBvQvqPfgitohgKyAGR; // 0x28
			public IControllerElementTarget nCYudTpjINOmBpcFqbImQYuVzYO; // 0x30
			public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x38
			public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x3C
			public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x40
			public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x41
			public TempListPool.TList<ActionElementMap> lCSXfSLopqLKnuqXvPsIzCzinsX; // 0x48
			public List<ActionElementMap> QbyTnnpmwBBqoKJyPnLWREfdRese; // 0x50
			public bool GuiWDeuucDqjEPDeJwobaiYqYdx; // 0x58
			public ActionElementMap gcVaoXeUCpAfcdqBiRhVxGdzvqL; // 0x60
			public List<ActionElementMap> lylVFiblgSULeABTTynRXrGQFzn; // 0x68
	
			// Properties
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public dyOkQlIypnnAoaGbjpojWOlTvvC(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001814B22B0-0x00000001814B2410
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814B22B0-0x00000001814B2410
			private bool MoveNext(); // 0x00000001814B1F20-0x00000001814B2260
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814B2410-0x00000001814B2460
			void IDisposable.Dispose(); // 0x00000001814B2460-0x00000001814B2590
			private void SQYWUvrGXMsgwiIqaEFnOltLMeR(); // 0x00000001814B2260-0x00000001814B22B0
			private void ndEbcivevubdslJnaIskXcuCcQX(); // 0x00000001814B2590-0x00000001814B25D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class rrMBewCCUTOilTKqzrWBnupbHUZB : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6672
		{
			// Fields
			private ActionElementMap aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x18
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x1C
			public ControllerMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x20
			public int OQcyWgBmnPWCLAcqVAqEsHoBwiC; // 0x28
			public int QxHmeEAGmVFnLuiDvwBgXueGYzo; // 0x2C
			public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x30
			public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x31
			public IList<ActionElementMap> wXndknXFUxPmDKDUeEEnIwQNwzZ; // 0x38
			public int agsBYrpYkSdyzrDzkGnsjoOlJWMA; // 0x40
			public int QyDDfdpGWGcYplbmqgZMddBHnRm; // 0x44
			public ActionElementMap SEVGICkrzSqgVoAhpphJLSXcavmv; // 0x48
	
			// Properties
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372440-0x0000000180372450 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public rrMBewCCUTOilTKqzrWBnupbHUZB(int <>1__state); // 0x00000001805EDEC0-0x00000001805EDF10
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x00000001814B4B90-0x00000001814B4CB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814B4B90-0x00000001814B4CB0
			private bool MoveNext(); // 0x00000001814B48D0-0x00000001814B4B90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814B4CB0-0x00000001814B4D00
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class XoPsMyGjFhnYIbmnLmCyOVNhcfd : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6673
		{
			// Fields
			private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
			public ControllerMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
			public ControllerMap VCwSAORWBiRNsmVsSGpfiFDKevf; // 0x50
			public ControllerMap KcBrVIGWhqebRqueSpComEPIkyB; // 0x58
			public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x60
			public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x61
			public IList<ActionElementMap> EdWmASWIHCjVDxgZpcvIyWcqfWyh; // 0x68
			public int rVrLLMOnVehupshVuCnlGVfTjNId; // 0x70
			public int TaQSqbPGfybhDHcxXrAmpRybkYG; // 0x74
			public ActionElementMap khrNszkhslCGNjQBofjyXOfgABS; // 0x78
			public int cXdgZGFivXIAEnJlPHuUBsbWkaX; // 0x80
			public ActionElementMap ugVblsqXZmJhDfuMNEMnptMcchY; // 0x88
	
			// Properties
			ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001814B1830-0x00000001814B1890 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public XoPsMyGjFhnYIbmnLmCyOVNhcfd(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001814B16E0-0x00000001814B17E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814B16E0-0x00000001814B17E0
			private bool MoveNext(); // 0x00000001814B1120-0x00000001814B16E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814B17E0-0x00000001814B1830
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class qJTomULwyZYYnkxernYXtczcTcI : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6674
		{
			// Fields
			private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
			public ControllerMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
			public ActionElementMap pXGtEcNGxzcsLHuQjqryTlbxHQM; // 0x50
			public ActionElementMap AotyrGexvkvFtbIHuGPbpxIPNaS; // 0x58
			public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0x60
			public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0x61
			public int dYAIUmxOtnsZWcYuYMHXBJUkLNT; // 0x64
			public ActionElementMap WdMIpLJecTOSmAfVHgNHSEpkBSwS; // 0x68
	
			// Properties
			ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001814B4870-0x00000001814B48D0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public qJTomULwyZYYnkxernYXtczcTcI(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001814B46C0-0x00000001814B4820
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814B46C0-0x00000001814B4820
			private bool MoveNext(); // 0x00000001814B4250-0x00000001814B46C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814B4820-0x00000001814B4870
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class lzLGtNAzuoolKhizvWulSozTLLlZ : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6675
		{
			// Fields
			private ElementAssignmentConflictInfo aSrFEaALHwhGTdXfCdeUqgbwaZGO; // 0x10
			private int eLrUhJFgzEZElCzdKvcrgOLXLvL; // 0x3C
			private int RQaeFqcJnaOYpZSBxtfUkVOjfOo; // 0x40
			public ControllerMap gKPmvKLRxdGbmXiMfUeDjGbezUo; // 0x48
			public ElementAssignmentConflictCheck gdXiyfccIlKDtIhrdLInicIqLXay; // 0x50
			public ElementAssignmentConflictCheck rCEjBPidFUoNshKDDcSlCqEOzsi; // 0x88
			public bool iZRgoSnrvDADGHAHeUljxBjBXqIa; // 0xC0
			public bool hsvMDnJdujXlHczadGEjywGdfVj; // 0xC1
			public ElementAssignment xcITiAIWRAFxxaexStUOgNRazKw; // 0xC4
			public int MuHEpzokdLUykNEJuQIZGpaigVT; // 0xE8
			public ActionElementMap CMFGDgzvdShVMdxTuKbloybeEIO; // 0xF0
	
			// Properties
			ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180EE7990-0x0000000180EE79C0 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001814B31F0-0x00000001814B3250 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public lzLGtNAzuoolKhizvWulSozTLLlZ(int <>1__state); // 0x0000000180EE87E0-0x0000000180EE8830
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x00000001814B3060-0x00000001814B31A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814B3060-0x00000001814B31A0
			private bool MoveNext(); // 0x00000001814B2B60-0x00000001814B3060
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001814B31A0-0x00000001814B31F0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		}
	
		// Constructors
		public ControllerMap(); // 0x00000001808D3920-0x00000001808D3AA0
		public ControllerMap(ControllerMap source); // 0x00000001808D34E0-0x00000001808D3920
		static ControllerMap(); // 0x00000001803774A0-0x00000001803774B0
	
		// Methods
		public bool ContainsAction(string actionName); // 0x00000001808C5D60-0x00000001808C5E70
		public virtual bool ContainsAction(int actionId); // 0x00000001808C5C20-0x00000001808C5D60
		public bool ContainsElementIdentifier(int elementIdentifierId); // 0x00000001808C5E70-0x00000001808C5FB0
		public bool ContainsKeyboardKey(KeyCode keyCode, ModifierKeyFlags modifierKeys); // 0x00000001808C6340-0x00000001808C6500
		public bool ContainsElementMap(ActionElementMap elementMap); // 0x00000001808C60D0-0x00000001808C6220
		public bool ContainsElementMap(int elementMapId); // 0x00000001808C5FB0-0x00000001808C60D0
		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment); // 0x00000001808D2210-0x00000001808D2390
		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result); // 0x00000001808D2390-0x00000001808D2490
		public bool CreateElementMap(ElementAssignment elementAssignment); // 0x00000001808C6500-0x00000001808C65E0
		public bool CreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result); // 0x00000001808C6BC0-0x00000001808C6D30
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3); // 0x00000001808C6D30-0x00000001808C6D80
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result); // 0x00000001808C6760-0x00000001808C6A00
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags); // 0x00000001808C6A00-0x00000001808C6A30
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result); // 0x00000001808C6A90-0x00000001808C6BC0
		public bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert); // 0x00000001808C6A30-0x00000001808C6A90
		public virtual bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result); // 0x00000001808C65E0-0x00000001808C6760
		public bool ReplaceElementMap(ElementAssignment elementAssignment); // 0x00000001808D16D0-0x00000001808D1710
		public bool ReplaceElementMap(ElementAssignment elementAssignment, out ActionElementMap result); // 0x00000001808D1710-0x00000001808D1890
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3); // 0x00000001808D1DF0-0x00000001808D1E40
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result); // 0x00000001808D1E40-0x00000001808D21B0
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags); // 0x00000001808D1940-0x00000001808D19F0
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result); // 0x00000001808D1890-0x00000001808D1940
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert); // 0x00000001808D21B0-0x00000001808D2210
		public virtual bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result); // 0x00000001808D19F0-0x00000001808D1DF0
		public virtual bool DeleteElementMap(int elementMapId); // 0x00000001808C7130-0x00000001808C7200
		public virtual bool DeleteElementMapsWithAction(string actionName); // 0x00000001808C7200-0x00000001808C72A0
		public virtual bool DeleteElementMapsWithAction(int actionId); // 0x00000001808C72A0-0x00000001808C72B0
		public virtual ActionElementMap GetElementMap(int elementMapId); // 0x00000001808CCCD0-0x00000001808CCE30
		public ActionElementMap[] GetElementMaps(); // 0x00000001808CEC20-0x00000001808CEC30
		public ActionElementMap[] GetElementMaps(bool skipDisabledMaps); // 0x00000001808CEE60-0x00000001808CF150
		public int GetElementMaps(List<ActionElementMap> results); // 0x00000001808CEC30-0x00000001808CED50
		public int GetElementMaps(bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CED50-0x00000001808CEE60
		public ActionElementMap[] GetElementMapsWithAction(string actionName); // 0x00000001808CD790-0x00000001808CD8E0
		public ActionElementMap[] GetElementMapsWithAction(int actionId); // 0x00000001808CCE30-0x00000001808CCE40
		public ActionElementMap[] GetElementMapsWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808CDA20-0x00000001808CDB30
		public ActionElementMap[] GetElementMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808CCE40-0x00000001808CD450
		public int GetElementMapsWithAction(string actionName, List<ActionElementMap> results); // 0x00000001808CD450-0x00000001808CD560
		public int GetElementMapsWithAction(int actionId, List<ActionElementMap> results); // 0x00000001808CD730-0x00000001808CD760
		public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CD8E0-0x00000001808CDA20
		public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CD760-0x00000001808CD790
		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName); // 0x00000001808C9280-0x00000001808C9390
		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId); // 0x00000001808C91E0-0x00000001808C91F0
		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808C9060-0x00000001808C91E0
		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808C91F0-0x00000001808C9280
		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId); // 0x00000001808CF660-0x00000001808CF680
		public virtual ActionElementMap GetFirstElementMapWithAction(string actionName); // 0x00000001808CF680-0x00000001808CF780
		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808CF890-0x00000001808CFA50
		public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808CF780-0x00000001808CF890
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808C9390-0x00000001808C94F0
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808C9600-0x00000001808C9690
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808C94F0-0x00000001808C9600
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808C98D0-0x00000001808C9AB0
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808C9830-0x00000001808C98D0
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808C9690-0x00000001808C9830
		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808CFB80-0x00000001808CFD30
		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001808D0280-0x00000001808D0370
		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808CFA50-0x00000001808CFB80
		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808CFD30-0x00000001808CFF30
		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001808D0370-0x00000001808D0450
		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001808D0160-0x00000001808D0280
		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CDD40-0x00000001808CDF20
		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CDF20-0x00000001808CE010
		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CE450-0x00000001808CE5B0
		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CE6B0-0x00000001808CE930
		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CE5B0-0x00000001808CE6B0
		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CE930-0x00000001808CEA50
		public ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> predicate); // 0x00000001808CF590-0x00000001808CF660
		internal virtual ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> param_0000dc02, bool param_0000dc03); // 0x00000001808CF580-0x00000001808CF590
		public int GetElementMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results); // 0x00000001808CCBE0-0x00000001808CCCB0
		internal virtual int GetElementMapMatches(Predicate<ActionElementMap> param_0000dc06, bool param_0000dc07, List<ActionElementMap> param_0000dc08, bool param_0000dc09); // 0x00000001808CCCB0-0x00000001808CCCD0
		public void ForEachElementMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform); // 0x00000001808CB630-0x00000001808CB870
		public virtual void ClearElementMaps(); // 0x00000001808C5B50-0x00000001808C5C20
		public int SetAllElementMapsEnabled(bool state); // 0x00000001808D2800-0x00000001808D2980
		public ActionElementMap GetButtonMap(int index); // 0x00000001808CB940-0x00000001808CBA30
		public ActionElementMap[] GetButtonMaps(); // 0x00000001808CC980-0x00000001808CCA30
		public ActionElementMap[] GetButtonMaps(bool skipDisabledMaps); // 0x00000001808CC780-0x00000001808CC980
		public int GetButtonMaps(bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CC500-0x00000001808CC780
		public ActionElementMap[] GetButtonMapsWithAction(string actionName); // 0x00000001808CC3F0-0x00000001808CC500
		public ActionElementMap[] GetButtonMapsWithAction(int actionId); // 0x00000001808CC170-0x00000001808CC180
		public ActionElementMap[] GetButtonMapsWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808CC180-0x00000001808CC290
		public ActionElementMap[] GetButtonMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808CBE10-0x00000001808CC170
		public int GetButtonMapsWithAction(string actionName, List<ActionElementMap> results); // 0x00000001808CBA30-0x00000001808CBB50
		public int GetButtonMapsWithAction(int actionId, List<ActionElementMap> results); // 0x00000001808CBB50-0x00000001808CBB70
		public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CC290-0x00000001808CC3F0
		public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x00000001808CBB70-0x00000001808CBE10
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId); // 0x00000001808C58D0-0x00000001808C58E0
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName); // 0x00000001808C5990-0x00000001808C5AA0
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808C58E0-0x00000001808C5990
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808C57C0-0x00000001808C58D0
		public ActionElementMap GetFirstButtonMapWithAction(int actionId); // 0x00000001808CF570-0x00000001808CF580
		public ActionElementMap GetFirstButtonMapWithAction(string actionName); // 0x00000001808CF470-0x00000001808CF570
		public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps); // 0x00000001808CF210-0x00000001808CF370
		public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps); // 0x00000001808CF370-0x00000001808CF470
		public ActionElementMap GetFirstButtonMapMatch(Predicate<ActionElementMap> predicate); // 0x00000001808CF150-0x00000001808CF210
		internal ActionElementMap sfrfjQHYwnzYMvBdMYFGgIuOxY(Predicate<ActionElementMap> param_0000dc2e, bool param_0000dc2f); // 0x00000001808D4EC0-0x00000001808D5110
		public int GetButtonMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results); // 0x00000001808CB870-0x00000001808CB940
		internal int EeNfZfiTCyIueEnVHfvFhlFcvuQA(Predicate<ActionElementMap> param_0000dc32, bool param_0000dc33, List<ActionElementMap> param_0000dc34, bool param_0000dc35); // 0x00000001808C8AB0-0x00000001808C8DD0
		public void ForEachButtonMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform); // 0x00000001808CA6A0-0x00000001808CA950
		public bool DeleteButtonMapsWithAction(string actionName); // 0x00000001808C6F00-0x00000001808C6F90
		public bool DeleteButtonMapsWithAction(int actionId); // 0x00000001808C6F90-0x00000001808C7130
		public int SetAllButtonMapsEnabled(bool state); // 0x00000001808D2660-0x00000001808D2800
		public bool DoesElementAssignmentConflict(ControllerMap controllerMap); // 0x0000000180541970-0x0000000180541990
		public bool DoesElementAssignmentConflict(ActionElementMap actionElementMap); // 0x00000001808C8A90-0x00000001808C8AB0
		public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck); // 0x00000001808C8820-0x00000001808C8870
		public virtual bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps); // 0x00000001808C8190-0x00000001808C85A0
		public virtual bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x00000001808C8870-0x00000001808C8A90
		public virtual bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001808C85A0-0x00000001808C8820
		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap); // 0x00000001808C8DD0-0x00000001808C8DF0
		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap); // 0x00000001808C8FB0-0x00000001808C8FD0
		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x00000001808C8ED0-0x00000001808C8F20
		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps); // 0x00000001808C8F20-0x00000001808C8FB0
		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x00000001808C8FD0-0x00000001808C9060
		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001808C8DF0-0x00000001808C8ED0
		public int RemoveElementAssignmentConflicts(ControllerMap controllerMap); // 0x00000001808D1640-0x00000001808D1660
		public int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap); // 0x00000001808D1660-0x00000001808D1680
		public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x00000001808D1680-0x00000001808D16D0
		public virtual int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps); // 0x00000001808D0C90-0x00000001808D10B0
		public virtual int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x00000001808D10B0-0x00000001808D1350
		public virtual int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001808D1350-0x00000001808D1640
		public int DisableElementAssignmentConflicts(ControllerMap controllerMap); // 0x00000001808C7850-0x00000001808C7920
		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap); // 0x00000001808C7F00-0x00000001808C7FD0
		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x00000001808C7A20-0x00000001808C7B20
		public int DisableElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps); // 0x00000001808C80B0-0x00000001808C8190
		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x00000001808C7FD0-0x00000001808C80B0
		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001808C7920-0x00000001808C7A20
		internal virtual int DisableElementAssignmentConflicts(ControllerMap param_0000dc5f, bool param_0000dc60, List<ActionElementMap> param_0000dc61, bool param_0000dc62); // 0x00000001808C7B20-0x00000001808C7F00
		internal virtual int DisableElementAssignmentConflicts(ActionElementMap param_0000dc63, bool param_0000dc64, List<ActionElementMap> param_0000dc65, bool param_0000dc66); // 0x00000001808C75B0-0x00000001808C7850
		internal virtual int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck param_0000dc67, bool param_0000dc68, List<ActionElementMap> param_0000dc69, bool param_0000dc6a); // 0x00000001808C72B0-0x00000001808C75B0
		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform); // 0x00000001808CB200-0x00000001808CB220
		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform); // 0x00000001808CB5C0-0x00000001808CB5E0
		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform); // 0x00000001808CB5E0-0x00000001808CB630
		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps); // 0x00000001808CA950-0x00000001808CAE70
		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps); // 0x00000001808CAE70-0x00000001808CB200
		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps); // 0x00000001808CB220-0x00000001808CB5C0
		public string[] GetButtonNames(); // 0x00000001808CCA30-0x00000001808CCBE0
		public string ToXmlString(); // 0x00000001808D3080-0x00000001808D3210
		public string ToJsonString(); // 0x00000001808D2EC0-0x00000001808D3080
		public ControllerTemplateMap ToControllerTemplateMap(Guid templateTypeGuid); // 0x00000001808D2980-0x00000001808D2C30
		public ControllerTemplateMap ToControllerTemplateMap<T>()
			where T : class;
		public ControllerTemplateMap ToControllerTemplateMap(Type templateInterfaceType); // 0x00000001808D2C30-0x00000001808D2EC0
		private ControllerTemplateMap WVBGGcAShyAhuaoJOBlxFvkqAyeX(IControllerTemplate param_0000dc7c); // 0x00000001808D3210-0x00000001808D3360
		internal virtual bool AddActionMapping_BeforeBake(ActionElementMap param_0000dc7d); // 0x00000001808C5600-0x00000001808C5690
		internal virtual int GetElementMaps_Append(List<ActionElementMap> param_0000dc7e, bool param_0000dc7f); // 0x00000001808CEA50-0x00000001808CEC20
		internal virtual ActionElementMap GetFirstElementMapWithMapping(int param_0000dc80, int param_0000dc81, ControllerElementType param_0000dc82); // 0x00000001808D0450-0x00000001808D04F0
		internal virtual int GetElementMapsWithElementIdentifier(int param_0000dc83, List<ActionElementMap> param_0000dc84, bool param_0000dc85); // 0x00000001808CDB30-0x00000001808CDD40
		internal virtual bool ContainsElementMapping(int param_0000dc86, int param_0000dc87, ControllerElementType param_0000dc88); // 0x00000001808C6220-0x00000001808C6340
		internal virtual int FirstIndexOfElementMapping(int param_0000dc89, int param_0000dc8a, ControllerElementType param_0000dc8b); // 0x00000001808CA580-0x00000001808CA6A0
		internal int WyfLcbhJdRIDggNTPQolKfmiqVXO(int param_0000dc8c); // 0x00000001808D3360-0x00000001808D3440
		internal int yMnCZVQpkDyZSdKlBPSwBpBVlbp(bool param_0000dc8d, List<ActionElementMap> param_0000dc8e, bool param_0000dc8f); // 0x00000001808D5260-0x00000001808D5460
		internal int iRpRMXtGPzaRzbxQcKhFNYOkpU(int param_0000dc90, bool param_0000dc91, List<ActionElementMap> param_0000dc92, bool param_0000dc93); // 0x00000001808D48F0-0x00000001808D4AE0
		internal virtual int GetElementMapsWithAction(int param_0000dc94, bool param_0000dc95, List<ActionElementMap> param_0000dc96, bool param_0000dc97); // 0x00000001808CD560-0x00000001808CD730
		internal virtual ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget param_0000dc98, bool param_0000dc99, int param_0000dc9a, bool param_0000dc9b, out bool param_0000dc9c); // 0x00000001808CFF30-0x00000001808D0160
		internal virtual int GetElementMapsWithElementTarget(IControllerElementTarget param_0000dc9d, bool param_0000dc9e, int param_0000dc9f, bool param_0000dca0, List<ActionElementMap> param_0000dca1, bool param_0000dca2, out bool param_0000dca3); // 0x00000001808CE010-0x00000001808CE450
		internal void wIiHdvPUJfaFsAkUPGzOpxxycfw(int param_0000dca4, ControllerElementType param_0000dca5); // 0x00000001808D51A0-0x00000001808D5260
		internal virtual bool AddElementMap(ActionElementMap param_0000dca6); // 0x00000001808C5690-0x00000001808C5710
		internal bool RfhTtmeWkZcZFiLsfhGeVjiiHuoh(IControllerElementTarget param_0000dca7); // 0x00000001808D2490-0x00000001808D2660
		internal bool eWiDVrOvsiJEhXKqKMxndRKHSFa(string param_0000dca8); // 0x00000001808D3AA0-0x00000001808D3BC0
		internal bool gpseceKgdzPYGBlDHZYIuHnhQOU(string param_0000dca9); // 0x00000001808D47D0-0x00000001808D48F0
		internal void BvQwmWjmkuaSrcNJOKWBWseKTqu(ActionElementMap param_0000dcaa); // 0x00000001808C5AA0-0x00000001808C5B50
		internal void ZpLhQoroHCPJpgiSGIbBdtOZzpr(int param_0000dcab); // 0x00000001808D3440-0x00000001808D34E0
		internal void KiwuQAMxILWbeWMikexDAnMBYLCk(int param_0000dcac, ActionElementMap param_0000dcad); // 0x00000001808D0990-0x00000001808D0A70
		internal static void lbnVQxzGkEMKtnLmmXZpetnKhrY(ActionElementMap param_0000dcae, int param_0000dcaf, Pole param_0000dcb0, int param_0000dcb1, ControllerElementType param_0000dcb2, AxisRange param_0000dcb3, bool param_0000dcb4); // 0x00000001808D4CF0-0x00000001808D4DA0
		protected void BakeElementMap(ActionElementMap map); // 0x00000001808C5710-0x00000001808C57C0
		internal virtual bool Import(SerializedObject param_0000dcb6); // 0x00000001808D04F0-0x00000001808D0980
		internal virtual void ExportDataToSerializedObject(SerializedObject param_0000dcb7); // 0x00000001808C9AB0-0x00000001808CA580
		private bool JRmEBsonHRIHpxNzlhMFatswGgC(ControllerElementType param_0000dcb8); // 0x00000001808D0980-0x00000001808D0990
		private void QuqQnEgfPsIDZdqpymfnbctnFQy(int param_0000dcb9, int param_0000dcba); // 0x00000001808D0B70-0x00000001808D0C90
		private void zEuxlwThoAgQOAEzAYufSpxEQW(ActionElementMap param_0000dcbb); // 0x00000001808D5460-0x00000001808D54D0
		private void rUugoLYJiHPgXpRoLNGOFQJlcUw(ActionElementMap param_0000dcbc, int param_0000dcbd); // 0x00000001808D4DA0-0x00000001808D4EB0
		private int LzysDciQEwighcIlMAYdCPAjvoMh(int param_0000dcbe); // 0x00000001808D0A70-0x00000001808D0B70
		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x00000001808D5110-0x00000001808D51A0
		internal static ControllerMap AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType param_0000dcbf); // 0x00000001808C5510-0x00000001808C5600
		internal static ControllerMap knpCzsAliOJCvESsOKEznoItAuz(Controller param_0000dcc0, int param_0000dcc1, int param_0000dcc2); // 0x00000001808D4AE0-0x00000001808D4CF0
		public static ControllerMap CreateFromXml(ControllerType controllerType, string xmlString); // 0x00000001808C6D80-0x00000001808C6F00
	}
}
