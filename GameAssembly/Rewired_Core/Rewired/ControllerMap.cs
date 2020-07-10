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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public abstract class ControllerMap // TypeDefIndex: 6508
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
		private static int nextUid { get; } // 0x000000018044D950-0x000000018044DA30 
		public int id { get; } // 0x000000018044D760-0x000000018044D800 
		public int sourceMapId { get; internal set; } // 0x000000018044DBA0-0x000000018044DC40 0x000000018036C6F0-0x000000018036C700
		public int categoryId { get; internal set; } // 0x000000018044D240-0x000000018044D2E0 0x000000018036B1F0-0x000000018036B200
		public int layoutId { get; internal set; } // 0x000000018044D800-0x000000018044D8A0 0x000000018037E600-0x000000018037E610
		public string name { get; internal set; } // 0x000000018044D8A0-0x000000018044D950 0x000000018036AC90-0x000000018036ACA0
		public Guid hardwareGuid { get; internal set; } // 0x000000018044D680-0x000000018044D760 0x000000018036CC20-0x000000018036CC30
		public bool enabled { get; set; } // 0x000000018044D5E0-0x000000018044D680 0x000000018044E330-0x000000018044E340
		public int playerId { get; internal set; } // 0x000000018044DA30-0x000000018044DAD0 0x000000018044E340-0x000000018044E350
		public int controllerId { get; internal set; } // 0x000000018044D2E0-0x000000018044D3B0 0x000000018044E320-0x000000018044E330
		public Controller controller { get; } // 0x000000018044D450-0x000000018044D530 
		public ControllerType controllerType { get; internal set; } // 0x000000018044D3B0-0x000000018044D450 0x00000001803DAE50-0x00000001803DAE60
		public Player player { get; } // 0x000000018044DAD0-0x000000018044DBA0 
		public int elementMapCount { get; } // 0x000000018044D530-0x000000018044D5E0 
		public int buttonMapCount { get; } // 0x000000018044D190-0x000000018044D240 
		public IList<ActionElementMap> AllMaps { get; } // 0x000000018044D030-0x000000018044D0E0 
		public IList<ActionElementMap> ButtonMaps { get; } // 0x000000018044D0E0-0x000000018044D190 
		internal AList<ActionElementMap> ButtonMaps_orig { get; } // 0x0000000180369B30-0x0000000180369B40 
	
		// Nested types
		private class FxHeXoCttgoRDEovXylvLhGTHdg : IComparer<ActionElementMap> // TypeDefIndex: 6509
		{
			// Fields
			public static FxHeXoCttgoRDEovXylvLhGTHdg DqYmGHECTlrDVQmfbrCSLOJGmsK; // 0x00
	
			// Properties
			public static FxHeXoCttgoRDEovXylvLhGTHdg ABeAWOemtDNDbkuEcBndYTrwdsCb { get; } // 0x0000000180A09BD0-0x0000000180A09C40 
	
			// Constructors
			public FxHeXoCttgoRDEovXylvLhGTHdg(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public int Compare(ActionElementMap x, ActionElementMap y); // 0x0000000180A09990-0x0000000180A09BD0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class fSTsTyNwHdFpJgZOmCmfdGjrEmr : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6510
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
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public fSTsTyNwHdFpJgZOmCmfdGjrEmr(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180A136A0-0x0000000180A137B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A136A0-0x0000000180A137B0
			private bool MoveNext(); // 0x0000000180A13360-0x0000000180A136A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A137B0-0x0000000180A13800
			void IDisposable.Dispose(); // 0x0000000180A13800-0x0000000180A138B0
			private void UyxqCTivFhKkftRJACbuayqJVBII(); // 0x0000000180A138B0-0x0000000180A13900
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class danrepvLqbfWQRsqHADtwUmjeoG : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6511
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
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public danrepvLqbfWQRsqHADtwUmjeoG(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180A12920-0x0000000180A12A80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A12920-0x0000000180A12A80
			private bool MoveNext(); // 0x0000000180A125F0-0x0000000180A12920
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A12A80-0x0000000180A12AD0
			void IDisposable.Dispose(); // 0x0000000180A12AD0-0x0000000180A12C00
			private void VwBvbSfUDfldJESYzjPxVNKPpgB(); // 0x0000000180A12C00-0x0000000180A12C50
			private void eZzXMgOVZJHRzuzUIdzvEniFART(); // 0x0000000180A12C50-0x0000000180A12C90
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class dyOkQlIypnnAoaGbjpojWOlTvvC : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6512
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
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public dyOkQlIypnnAoaGbjpojWOlTvvC(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180A13030-0x0000000180A131A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A13030-0x0000000180A131A0
			private bool MoveNext(); // 0x0000000180A12C90-0x0000000180A12FE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A131A0-0x0000000180A131F0
			void IDisposable.Dispose(); // 0x0000000180A131F0-0x0000000180A13320
			private void SQYWUvrGXMsgwiIqaEFnOltLMeR(); // 0x0000000180A12FE0-0x0000000180A13030
			private void ndEbcivevubdslJnaIskXcuCcQX(); // 0x0000000180A13320-0x0000000180A13360
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class rrMBewCCUTOilTKqzrWBnupbHUZB : IEnumerable<ActionElementMap>, IEnumerator<ActionElementMap> // TypeDefIndex: 6513
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
			ActionElementMap wREFtIYSMXfzFqOrbUZlcqTYuBI { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public rrMBewCCUTOilTKqzrWBnupbHUZB(int <>1__state); // 0x0000000180393A20-0x0000000180393A70
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ActionElementMap> IEnumerable<ActionElementMap>.GetEnumerator(); // 0x0000000180A159A0-0x0000000180A15AC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A159A0-0x0000000180A15AC0
			private bool MoveNext(); // 0x0000000180A156D0-0x0000000180A159A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A15AC0-0x0000000180A15B10
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class XoPsMyGjFhnYIbmnLmCyOVNhcfd : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6514
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
			ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180A12550-0x0000000180A125B0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public XoPsMyGjFhnYIbmnLmCyOVNhcfd(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180A123F0-0x0000000180A12500
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A123F0-0x0000000180A12500
			private bool MoveNext(); // 0x0000000180A11E20-0x0000000180A123F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A12500-0x0000000180A12550
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class qJTomULwyZYYnkxernYXtczcTcI : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6515
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
			ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180A15670-0x0000000180A156D0 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public qJTomULwyZYYnkxernYXtczcTcI(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180A154C0-0x0000000180A15620
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A154C0-0x0000000180A15620
			private bool MoveNext(); // 0x0000000180A15040-0x0000000180A154C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A15620-0x0000000180A15670
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class lzLGtNAzuoolKhizvWulSozTLLlZ : IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6516
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
			ElementAssignmentConflictInfo RktEALHXdmJYUCoXsuFPErnugkfQ { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180647DD0-0x0000000180647E00 
			object lEHmhZcDVBCvVkmanIeFkjDMVct { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180A13FA0-0x0000000180A14000 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public lzLGtNAzuoolKhizvWulSozTLLlZ(int <>1__state); // 0x0000000180648C40-0x0000000180648C90
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<ElementAssignmentConflictInfo> IEnumerable<ElementAssignmentConflictInfo>.GetEnumerator(); // 0x0000000180A13E10-0x0000000180A13F50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A13E10-0x0000000180A13F50
			private bool MoveNext(); // 0x0000000180A13900-0x0000000180A13E10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180A13F50-0x0000000180A13FA0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		}
	
		// Constructors
		public ControllerMap(); // 0x000000018044CD90-0x000000018044CF10
		public ControllerMap(ControllerMap source); // 0x000000018044C940-0x000000018044CD90
		static ControllerMap(); // 0x00000001803581E0-0x00000001803581F0
	
		// Methods
		public bool ContainsAction(string actionName); // 0x000000018043F090-0x000000018043F1A0
		public virtual bool ContainsAction(int actionId); // 0x000000018043EF50-0x000000018043F090
		public bool ContainsElementIdentifier(int elementIdentifierId); // 0x000000018043F1A0-0x000000018043F2E0
		public bool ContainsKeyboardKey(KeyCode keyCode, ModifierKeyFlags modifierKeys); // 0x000000018043F680-0x000000018043F840
		public bool ContainsElementMap(ActionElementMap elementMap); // 0x000000018043F410-0x000000018043F560
		public bool ContainsElementMap(int elementMapId); // 0x000000018043F2E0-0x000000018043F410
		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment); // 0x000000018044B640-0x000000018044B7C0
		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result); // 0x000000018044B7C0-0x000000018044B8C0
		public bool CreateElementMap(ElementAssignment elementAssignment); // 0x000000018043F840-0x000000018043F920
		public bool CreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result); // 0x000000018043FF10-0x0000000180440080
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3); // 0x0000000180440080-0x00000001804400D0
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result); // 0x000000018043FAA0-0x000000018043FD50
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags); // 0x000000018043FD50-0x000000018043FD80
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result); // 0x000000018043FDE0-0x000000018043FF10
		public bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert); // 0x000000018043FD80-0x000000018043FDE0
		public virtual bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result); // 0x000000018043F920-0x000000018043FAA0
		public bool ReplaceElementMap(ElementAssignment elementAssignment); // 0x000000018044AB60-0x000000018044ABA0
		public bool ReplaceElementMap(ElementAssignment elementAssignment, out ActionElementMap result); // 0x000000018044ABA0-0x000000018044AD20
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3); // 0x000000018044B220-0x000000018044B270
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result); // 0x000000018044B270-0x000000018044B5E0
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags); // 0x000000018044ADD0-0x000000018044AE80
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result); // 0x000000018044AD20-0x000000018044ADD0
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert); // 0x000000018044B5E0-0x000000018044B640
		public virtual bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result); // 0x000000018044AE80-0x000000018044B220
		public virtual bool DeleteElementMap(int elementMapId); // 0x0000000180440490-0x0000000180440560
		public virtual bool DeleteElementMapsWithAction(string actionName); // 0x0000000180440560-0x0000000180440600
		public virtual bool DeleteElementMapsWithAction(int actionId); // 0x0000000180440600-0x0000000180440610
		public virtual ActionElementMap GetElementMap(int elementMapId); // 0x0000000180446170-0x00000001804462D0
		public ActionElementMap[] GetElementMaps(); // 0x0000000180448130-0x0000000180448140
		public ActionElementMap[] GetElementMaps(bool skipDisabledMaps); // 0x0000000180448370-0x0000000180448670
		public int GetElementMaps(List<ActionElementMap> results); // 0x0000000180448140-0x0000000180448260
		public int GetElementMaps(bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180448260-0x0000000180448370
		public ActionElementMap[] GetElementMapsWithAction(string actionName); // 0x0000000180446C70-0x0000000180446DC0
		public ActionElementMap[] GetElementMapsWithAction(int actionId); // 0x00000001804462D0-0x00000001804462E0
		public ActionElementMap[] GetElementMapsWithAction(string actionName, bool skipDisabledMaps); // 0x0000000180446F00-0x0000000180447010
		public ActionElementMap[] GetElementMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001804462E0-0x0000000180446920
		public int GetElementMapsWithAction(string actionName, List<ActionElementMap> results); // 0x0000000180446920-0x0000000180446A30
		public int GetElementMapsWithAction(int actionId, List<ActionElementMap> results); // 0x0000000180446C10-0x0000000180446C40
		public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180446DC0-0x0000000180446F00
		public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180446C40-0x0000000180446C70
		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName); // 0x0000000180442640-0x0000000180442750
		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId); // 0x00000001804425A0-0x00000001804425B0
		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps); // 0x0000000180442420-0x00000001804425A0
		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps); // 0x00000001804425B0-0x0000000180442640
		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId); // 0x0000000180448B80-0x0000000180448BA0
		public virtual ActionElementMap GetFirstElementMapWithAction(string actionName); // 0x0000000180448BA0-0x0000000180448CA0
		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps); // 0x0000000180448DB0-0x0000000180448F80
		public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps); // 0x0000000180448CA0-0x0000000180448DB0
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x0000000180442750-0x00000001804428C0
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001804429D0-0x0000000180442A60
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001804428C0-0x00000001804429D0
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x0000000180442CA0-0x0000000180442E80
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x0000000180442C00-0x0000000180442CA0
		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x0000000180442A60-0x0000000180442C00
		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001804490B0-0x0000000180449260
		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps); // 0x00000001804497C0-0x00000001804498B0
		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x0000000180448F80-0x00000001804490B0
		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x0000000180449260-0x0000000180449460
		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps); // 0x00000001804498B0-0x0000000180449990
		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps); // 0x00000001804496A0-0x00000001804497C0
		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180447230-0x0000000180447410
		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180447410-0x0000000180447500
		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180447950-0x0000000180447AB0
		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180447BB0-0x0000000180447E30
		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180447AB0-0x0000000180447BB0
		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180447E30-0x0000000180447F50
		public ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> predicate); // 0x0000000180448AB0-0x0000000180448B80
		internal virtual ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> param_0000d992, bool param_0000d993); // 0x0000000180448AA0-0x0000000180448AB0
		public int GetElementMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results); // 0x0000000180446080-0x0000000180446150
		internal virtual int GetElementMapMatches(Predicate<ActionElementMap> param_0000d996, bool param_0000d997, List<ActionElementMap> param_0000d998, bool param_0000d999); // 0x0000000180446150-0x0000000180446170
		public void ForEachElementMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform); // 0x0000000180444AA0-0x0000000180444CE0
		public virtual void ClearElementMaps(); // 0x000000018043EE80-0x000000018043EF50
		public int SetAllElementMapsEnabled(bool state); // 0x000000018044BC30-0x000000018044BDC0
		public ActionElementMap GetButtonMap(int index); // 0x0000000180444DB0-0x0000000180444EA0
		public ActionElementMap[] GetButtonMaps(); // 0x0000000180445E10-0x0000000180445EC0
		public ActionElementMap[] GetButtonMaps(bool skipDisabledMaps); // 0x0000000180445C10-0x0000000180445E10
		public int GetButtonMaps(bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180445980-0x0000000180445C10
		public ActionElementMap[] GetButtonMapsWithAction(string actionName); // 0x0000000180445870-0x0000000180445980
		public ActionElementMap[] GetButtonMapsWithAction(int actionId); // 0x00000001804455F0-0x0000000180445600
		public ActionElementMap[] GetButtonMapsWithAction(string actionName, bool skipDisabledMaps); // 0x0000000180445600-0x0000000180445710
		public ActionElementMap[] GetButtonMapsWithAction(int actionId, bool skipDisabledMaps); // 0x0000000180445280-0x00000001804455F0
		public int GetButtonMapsWithAction(string actionName, List<ActionElementMap> results); // 0x0000000180444EA0-0x0000000180444FC0
		public int GetButtonMapsWithAction(int actionId, List<ActionElementMap> results); // 0x0000000180444FC0-0x0000000180444FE0
		public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180445710-0x0000000180445870
		public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results); // 0x0000000180444FE0-0x0000000180445280
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId); // 0x000000018043EC00-0x000000018043EC10
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName); // 0x000000018043ECC0-0x000000018043EDD0
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps); // 0x000000018043EC10-0x000000018043ECC0
		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps); // 0x000000018043EAF0-0x000000018043EC00
		public ActionElementMap GetFirstButtonMapWithAction(int actionId); // 0x0000000180448A90-0x0000000180448AA0
		public ActionElementMap GetFirstButtonMapWithAction(string actionName); // 0x0000000180448990-0x0000000180448A90
		public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps); // 0x0000000180448730-0x0000000180448890
		public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps); // 0x0000000180448890-0x0000000180448990
		public ActionElementMap GetFirstButtonMapMatch(Predicate<ActionElementMap> predicate); // 0x0000000180448670-0x0000000180448730
		internal ActionElementMap sfrfjQHYwnzYMvBdMYFGgIuOxY(Predicate<ActionElementMap> param_0000d9be, bool param_0000d9bf); // 0x000000018044E350-0x000000018044E5A0
		public int GetButtonMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results); // 0x0000000180444CE0-0x0000000180444DB0
		internal int EeNfZfiTCyIueEnVHfvFhlFcvuQA(Predicate<ActionElementMap> param_0000d9c2, bool param_0000d9c3, List<ActionElementMap> param_0000d9c4, bool param_0000d9c5); // 0x0000000180441E50-0x0000000180442180
		public void ForEachButtonMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform); // 0x0000000180443AD0-0x0000000180443D90
		public bool DeleteButtonMapsWithAction(string actionName); // 0x0000000180440260-0x00000001804402F0
		public bool DeleteButtonMapsWithAction(int actionId); // 0x00000001804402F0-0x0000000180440490
		public int SetAllButtonMapsEnabled(bool state); // 0x000000018044BA90-0x000000018044BC30
		public bool DoesElementAssignmentConflict(ControllerMap controllerMap); // 0x0000000180441E30-0x0000000180441E50
		public bool DoesElementAssignmentConflict(ActionElementMap actionElementMap); // 0x0000000180441E10-0x0000000180441E30
		public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180441BA0-0x0000000180441BF0
		public virtual bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps); // 0x0000000180441510-0x0000000180441920
		public virtual bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x0000000180441BF0-0x0000000180441E10
		public virtual bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180441920-0x0000000180441BA0
		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap); // 0x0000000180442180-0x00000001804421A0
		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap); // 0x0000000180442370-0x0000000180442390
		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180442290-0x00000001804422E0
		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps); // 0x00000001804422E0-0x0000000180442370
		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x0000000180442390-0x0000000180442420
		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x00000001804421A0-0x0000000180442290
		public int RemoveElementAssignmentConflicts(ControllerMap controllerMap); // 0x000000018044AAD0-0x000000018044AAF0
		public int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap); // 0x000000018044AAF0-0x000000018044AB10
		public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x000000018044AB10-0x000000018044AB60
		public virtual int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps); // 0x000000018044A110-0x000000018044A540
		public virtual int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x000000018044A540-0x000000018044A7E0
		public virtual int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x000000018044A7E0-0x000000018044AAD0
		public int DisableElementAssignmentConflicts(ControllerMap controllerMap); // 0x0000000180440BC0-0x0000000180440C90
		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap); // 0x0000000180441280-0x0000000180441350
		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck); // 0x0000000180440D90-0x0000000180440E90
		public int DisableElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps); // 0x0000000180441430-0x0000000180441510
		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps); // 0x0000000180441350-0x0000000180441430
		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps); // 0x0000000180440C90-0x0000000180440D90
		internal virtual int DisableElementAssignmentConflicts(ControllerMap param_0000d9ef, bool param_0000d9f0, List<ActionElementMap> param_0000d9f1, bool param_0000d9f2); // 0x0000000180440E90-0x0000000180441280
		internal virtual int DisableElementAssignmentConflicts(ActionElementMap param_0000d9f3, bool param_0000d9f4, List<ActionElementMap> param_0000d9f5, bool param_0000d9f6); // 0x0000000180440910-0x0000000180440BC0
		internal virtual int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck param_0000d9f7, bool param_0000d9f8, List<ActionElementMap> param_0000d9f9, bool param_0000d9fa); // 0x0000000180440610-0x0000000180440910
		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform); // 0x0000000180444660-0x0000000180444680
		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform); // 0x0000000180444A30-0x0000000180444A50
		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform); // 0x0000000180444A50-0x0000000180444AA0
		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps); // 0x0000000180443D90-0x00000001804442C0
		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps); // 0x00000001804442C0-0x0000000180444660
		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps); // 0x0000000180444680-0x0000000180444A30
		public string[] GetButtonNames(); // 0x0000000180445EC0-0x0000000180446080
		public string ToXmlString(); // 0x000000018044C4C0-0x000000018044C650
		public string ToJsonString(); // 0x000000018044C300-0x000000018044C4C0
		public ControllerTemplateMap ToControllerTemplateMap(Guid templateTypeGuid); // 0x000000018044BDC0-0x000000018044C070
		public ControllerTemplateMap ToControllerTemplateMap<T>()
			where T : class;
		public ControllerTemplateMap ToControllerTemplateMap(Type templateInterfaceType); // 0x000000018044C070-0x000000018044C300
		private ControllerTemplateMap WVBGGcAShyAhuaoJOBlxFvkqAyeX(IControllerTemplate param_0000da0c); // 0x000000018044C650-0x000000018044C7B0
		internal virtual bool AddActionMapping_BeforeBake(ActionElementMap param_0000da0d); // 0x000000018043E930-0x000000018043E9C0
		internal virtual int GetElementMaps_Append(List<ActionElementMap> param_0000da0e, bool param_0000da0f); // 0x0000000180447F50-0x0000000180448130
		internal virtual ActionElementMap GetFirstElementMapWithMapping(int param_0000da10, int param_0000da11, ControllerElementType param_0000da12); // 0x0000000180449990-0x0000000180449A30
		internal virtual int GetElementMapsWithElementIdentifier(int param_0000da13, List<ActionElementMap> param_0000da14, bool param_0000da15); // 0x0000000180447010-0x0000000180447230
		internal virtual bool ContainsElementMapping(int param_0000da16, int param_0000da17, ControllerElementType param_0000da18); // 0x000000018043F560-0x000000018043F680
		internal virtual int FirstIndexOfElementMapping(int param_0000da19, int param_0000da1a, ControllerElementType param_0000da1b); // 0x00000001804439A0-0x0000000180443AD0
		internal int WyfLcbhJdRIDggNTPQolKfmiqVXO(int param_0000da1c); // 0x000000018044C7B0-0x000000018044C8A0
		internal int yMnCZVQpkDyZSdKlBPSwBpBVlbp(bool param_0000da1d, List<ActionElementMap> param_0000da1e, bool param_0000da1f); // 0x000000018044E6F0-0x000000018044E900
		internal int iRpRMXtGPzaRzbxQcKhFNYOkpU(int param_0000da20, bool param_0000da21, List<ActionElementMap> param_0000da22, bool param_0000da23); // 0x000000018044DD60-0x000000018044DF50
		internal virtual int GetElementMapsWithAction(int param_0000da24, bool param_0000da25, List<ActionElementMap> param_0000da26, bool param_0000da27); // 0x0000000180446A30-0x0000000180446C10
		internal virtual ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget param_0000da28, bool param_0000da29, int param_0000da2a, bool param_0000da2b, out bool param_0000da2c); // 0x0000000180449460-0x00000001804496A0
		internal virtual int GetElementMapsWithElementTarget(IControllerElementTarget param_0000da2d, bool param_0000da2e, int param_0000da2f, bool param_0000da30, List<ActionElementMap> param_0000da31, bool param_0000da32, out bool param_0000da33); // 0x0000000180447500-0x0000000180447950
		internal void wIiHdvPUJfaFsAkUPGzOpxxycfw(int param_0000da34, ControllerElementType param_0000da35); // 0x000000018044E630-0x000000018044E6F0
		internal virtual bool AddElementMap(ActionElementMap param_0000da36); // 0x000000018043E9C0-0x000000018043EA40
		internal bool RfhTtmeWkZcZFiLsfhGeVjiiHuoh(IControllerElementTarget param_0000da37); // 0x000000018044B8C0-0x000000018044BA90
		internal bool eWiDVrOvsiJEhXKqKMxndRKHSFa(string param_0000da38); // 0x000000018044CF10-0x000000018044D030
		internal bool gpseceKgdzPYGBlDHZYIuHnhQOU(string param_0000da39); // 0x000000018044DC40-0x000000018044DD60
		internal void BvQwmWjmkuaSrcNJOKWBWseKTqu(ActionElementMap param_0000da3a); // 0x000000018043EDD0-0x000000018043EE80
		internal void ZpLhQoroHCPJpgiSGIbBdtOZzpr(int param_0000da3b); // 0x000000018044C8A0-0x000000018044C940
		internal void KiwuQAMxILWbeWMikexDAnMBYLCk(int param_0000da3c, ActionElementMap param_0000da3d); // 0x0000000180449E10-0x0000000180449EF0
		internal static void lbnVQxzGkEMKtnLmmXZpetnKhrY(ActionElementMap param_0000da3e, int param_0000da3f, Pole param_0000da40, int param_0000da41, ControllerElementType param_0000da42, AxisRange param_0000da43, bool param_0000da44); // 0x000000018044E160-0x000000018044E210
		protected void BakeElementMap(ActionElementMap map); // 0x000000018043EA40-0x000000018043EAF0
		internal virtual bool Import(SerializedObject param_0000da46); // 0x0000000180449A30-0x0000000180449E00
		internal virtual void ExportDataToSerializedObject(SerializedObject param_0000da47); // 0x0000000180442E80-0x00000001804439A0
		private bool JRmEBsonHRIHpxNzlhMFatswGgC(ControllerElementType param_0000da48); // 0x0000000180449E00-0x0000000180449E10
		private void QuqQnEgfPsIDZdqpymfnbctnFQy(int param_0000da49, int param_0000da4a); // 0x0000000180449FF0-0x000000018044A110
		private void zEuxlwThoAgQOAEzAYufSpxEQW(ActionElementMap param_0000da4b); // 0x000000018044E900-0x000000018044E970
		private void rUugoLYJiHPgXpRoLNGOFQJlcUw(ActionElementMap param_0000da4c, int param_0000da4d); // 0x000000018044E210-0x000000018044E320
		private int LzysDciQEwighcIlMAYdCPAjvoMh(int param_0000da4e); // 0x0000000180449EF0-0x0000000180449FF0
		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x000000018044E5A0-0x000000018044E630
		internal static ControllerMap AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType param_0000da4f); // 0x000000018043E840-0x000000018043E930
		internal static ControllerMap knpCzsAliOJCvESsOKEznoItAuz(Controller param_0000da50, int param_0000da51, int param_0000da52); // 0x000000018044DF50-0x000000018044E160
		public static ControllerMap CreateFromXml(ControllerType controllerType, string xmlString); // 0x00000001804400D0-0x0000000180440260
	}
}
