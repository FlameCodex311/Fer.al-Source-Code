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
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public abstract class ControllerTemplate : IControllerTemplate // TypeDefIndex: 6091
	{
		// Fields
		private readonly string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x10
		private readonly Guid fBpYGJSbJtEYFnuyeCxcBFLcFejM; // 0x18
		private readonly Controller VFyAcBdeMMCAMfDOgPwemixrJuYM; // 0x28
		private readonly ADictionary<int, IControllerTemplateElement> qKaEkYzcrEvcwLNOaSobtDoPDvt; // 0x30
		private readonly ADictionary<string, IControllerTemplateElement> QNFfBjCDNzgKSHOdXuarceOAPPW; // 0x38
		private IControllerTemplateElement[] OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0x40
		private ReadOnlyCollection<IControllerTemplateElement> kaRwVFuEhQdielEoQKhHRABCAZN; // 0x48
		private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x50
	
		// Properties
		Controller IControllerTemplate.controller { get; } // 0x0000000181542A50-0x0000000181542B20 
		string IControllerTemplate.name { get; } // 0x0000000181542C70-0x0000000181542D10 
		Guid IControllerTemplate.typeGuid { get; } // 0x0000000181542D10-0x0000000181542DF0 
		IList<IControllerTemplateElement> IControllerTemplate.elements { get; } // 0x0000000181542BD0-0x0000000181542C70 
		int IControllerTemplate.elementCount { get; } // 0x0000000181542B20-0x0000000181542BD0 
	
		// Nested types
		internal abstract class GhREpLFgCYFrjIBVIYiOgCvfqHg : IControllerTemplateElement, IControllerTemplateElement_Internal // TypeDefIndex: 6092
		{
			// Fields
			private readonly IControllerTemplate PdhGYsFKOBEfRexHgTcxFTVoRup; // 0x10
			private readonly int jotfbgeLQZTIFstijorJbghJlvHQ; // 0x18
			private readonly string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x20
			private readonly ControllerTemplateElementType qYQtZXCUUQiyGpzdDXLOHBOwcPe; // 0x28
			protected readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x2C
	
			// Properties
			public int nowyFwjWnwrGQsPrcpSlPNkfVZu { get; } // 0x000000018154E3D0-0x000000018154E470 
			public string sOeddyDbBHwonMuiGWkqixyPkvu { get; } // 0x000000018154E330-0x000000018154E3D0 
			public ControllerTemplateElementType JmvHHQieRmxAYahCfvzgQBWHgSne { get; } // 0x000000018154E470-0x000000018154E510 
			public IControllerTemplate GsoDNwSmTlqXUxYxRnLUXMOoArhh { get; } // 0x0000000180372440-0x0000000180372450 
			public abstract int mqnUPxNtcFFogFDLlSnptdcvqQI { get; }
			public abstract IControllerTemplateElementSource EWvxEcokoAEStdCudJqOMgkHwwyD { get; }
			public abstract bool ewKnBoQtyaAQMQWdtvMPKLvKkoW { get; }
	
			// Constructors
			protected GhREpLFgCYFrjIBVIYiOgCvfqHg(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType); // 0x000000018154E200-0x000000018154E330
	
			// Methods
			public abstract IControllerTemplateElement GetElement(int param_0000cd64);
			public abstract int GetElementTargets(ControllerElementTarget param_0000cd65, ref IList<ControllerTemplateElementTarget> param_0000cd66);
		}
	
		internal abstract class KBYdzGRBzlXhtbUXRkUUOyEYMKl : GhREpLFgCYFrjIBVIYiOgCvfqHg // TypeDefIndex: 6093
		{
			// Fields
			protected readonly int ZXIUOoKfSNEvXAgqaKQAqjTqFkd; // 0x30
			protected readonly bZJyKtoDpKBrniWesjOeCJlrijn[] XVNhDzzLptFZxGvnmMhUfZhmxtsX; // 0x38
	
			// Properties
			public override bool ewKnBoQtyaAQMQWdtvMPKLvKkoW { get; } // 0x000000018154FF10-0x0000000181550050 
	
			// Constructors
			protected KBYdzGRBzlXhtbUXRkUUOyEYMKl(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x000000018154FE50-0x000000018154FF10
		}
	
		internal abstract class KMCVBWMPRfCCvsWXeOWVAVbJlSL : KBYdzGRBzlXhtbUXRkUUOyEYMKl, IControllerTemplateAxis, IControllerTemplateButton // TypeDefIndex: 6094
		{
			// Fields
			private oDhSVhqolYnpfNXmoDZvnEklacS dNWBSoAyVwPHsvQTGMAsQMzzdxU; // 0x40
			private string BFiybaexsfDqYszLAhDqXHlJPRJ; // 0x48
			private string RfeHNKNVEmyfJOcCPQKJQeeVWcE; // 0x50
	
			// Properties
			public float SmusaJYEiWkzlQwwWeWgpvQUdTv { get; } // 0x0000000181551CE0-0x0000000181551ED0 
			public float KWEArpYLlLDDbadXGBrjBxHaMRC { get; } // 0x0000000181551AE0-0x0000000181551CE0 
			public bool GHUeJCzFrDgzBXDTzvzXRREPKiu { get; } // 0x0000000181551930-0x0000000181551AE0 
			public bool CYoiuSaiDOhzEDDwIKdSkbMwjSa { get; } // 0x00000001815517A0-0x0000000181551930 
			string EreKZFjHcgkRyTstdLHiLeioxNL { get; } // 0x0000000181550770-0x0000000181550810 
			string YTvZzbNUUzHSEQKezlGntgMdjxI { get; } // 0x00000001815506D0-0x0000000181550770 
			float pyAHKferViMNbconiASqZIHgkDP { get; } // 0x0000000181550990-0x0000000181550A40 
			float vzknhlTmXKDPehKVvHJlFscBGpj { get; } // 0x00000001815508E0-0x0000000181550990 
			IControllerTemplateAxisSource MvaWGMDxzWCuFdNDIhjOHDATUQr { get; } // 0x0000000181550810-0x00000001815508E0 
			bool yhYHNxwamVZMPxRgAQqCaDCsItg { get; } // 0x0000000181551310-0x00000001815513E0 
			bool sGZWnrbtnKXyKhbLZDDToXdcBgr { get; } // 0x0000000181551270-0x0000000181551310 
			bool zzAzTAETPPVvtCOxkDipKjnvhBI { get; } // 0x0000000181550B00-0x0000000181550DA0 
			bool VYoYmPgzeoKWGyXVclmnmJsEmVZ { get; } // 0x0000000181550DA0-0x0000000181551070 
			bool XZUpRFXoiMCEykRvUOnYOWRbfcv { get; } // 0x0000000181550A40-0x0000000181550B00 
			float ZnWqLUxYZNoKrbOakICMDgiRDQm { get; } // 0x0000000181551120-0x00000001815511D0 
			float LGxyjtXFbvAmYIqrroeMLNEMvPq { get; } // 0x0000000181551070-0x0000000181551120 
			IControllerTemplateButtonSource RtVnWuNxPsSKjbmwlYoCwAVvZsd { get; } // 0x00000001815511D0-0x0000000181551270 
			public override IControllerTemplateElementSource EWvxEcokoAEStdCudJqOMgkHwwyD { get; } // 0x0000000181551ED0-0x0000000181551F70 
			public override int mqnUPxNtcFFogFDLlSnptdcvqQI { get; } // 0x000000018037DDC0-0x000000018037DDD0 
			public IControllerTemplateAxis AFkHcsMZfyqAhwdMMqDsbUdNedP { get; } // 0x0000000181551660-0x0000000181551700 
			public IControllerTemplateButton cyiCdIGXOEOueUEQbonWfmhOpBmZ { get; } // 0x0000000181551700-0x00000001815517A0 
	
			// Constructors
			protected KMCVBWMPRfCCvsWXeOWVAVbJlSL(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, oDhSVhqolYnpfNXmoDZvnEklacS target, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x00000001815513E0-0x0000000181551550
	
			// Methods
			string IControllerTemplateAxis.GetDescriptiveName(AxisRange param_0000cd74); // 0x0000000181550550-0x00000001815506D0
			public override IControllerTemplateElement GetElement(int param_0000cd75); // 0x000000018037DDC0-0x000000018037DDD0
			public override int GetElementTargets(ControllerElementTarget param_0000cd76, ref IList<ControllerTemplateElementTarget> param_0000cd77); // 0x0000000181550050-0x0000000181550550
			private static bool cDpEVdjnzvpcJhElJvglrKqBtWC(ControllerElementTarget param_0000cd78, IControllerElementTarget param_0000cd79); // 0x0000000181551550-0x0000000181551660
		}
	
		internal sealed class nNYFTddguJmElItENvBEjAjSLTE : KMCVBWMPRfCCvsWXeOWVAVbJlSL // TypeDefIndex: 6095
		{
			// Constructors
			public nNYFTddguJmElItENvBEjAjSLTE(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, oDhSVhqolYnpfNXmoDZvnEklacS target, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x0000000181556900-0x0000000181556AE0
	
			// Methods
			internal static nNYFTddguJmElItENvBEjAjSLTE EMrPyzqGuVTmURWytVHqWrdHoDK(IControllerTemplate param_0000cd81); // 0x00000001815567B0-0x0000000181556900
		}
	
		internal sealed class ElgBEiBoHPzlobPMCMNsKMpHpuXh : KMCVBWMPRfCCvsWXeOWVAVbJlSL // TypeDefIndex: 6096
		{
			// Constructors
			public ElgBEiBoHPzlobPMCMNsKMpHpuXh(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, oDhSVhqolYnpfNXmoDZvnEklacS target, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x000000018154E020-0x000000018154E200
	
			// Methods
			internal static ElgBEiBoHPzlobPMCMNsKMpHpuXh EMrPyzqGuVTmURWytVHqWrdHoDK(IControllerTemplate param_0000cd89); // 0x000000018154DED0-0x000000018154E020
		}
	
		internal abstract class guxazzOWayClFBASgkpzgjDfiZp : GhREpLFgCYFrjIBVIYiOgCvfqHg // TypeDefIndex: 6097
		{
			// Fields
			protected readonly int YTYDwGdmGpEbFaMPNISAGnnqKPXP; // 0x30
			protected readonly GhREpLFgCYFrjIBVIYiOgCvfqHg[] OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0x38
	
			// Properties
			public override bool ewKnBoQtyaAQMQWdtvMPKLvKkoW { get; } // 0x0000000181554410-0x0000000181554530 
			public override IControllerTemplateElementSource EWvxEcokoAEStdCudJqOMgkHwwyD { get; } // 0x0000000181554530-0x00000001815545C0 
			public override int mqnUPxNtcFFogFDLlSnptdcvqQI { get; } // 0x00000001804AA650-0x00000001804AA660 
	
			// Constructors
			protected guxazzOWayClFBASgkpzgjDfiZp(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x00000001815542B0-0x0000000181554410
	
			// Methods
			public override IControllerTemplateElement GetElement(int param_0000cd8f); // 0x0000000181554270-0x00000001815542B0
			public override int GetElementTargets(ControllerElementTarget param_0000cd90, ref IList<ControllerTemplateElementTarget> param_0000cd91); // 0x0000000181554180-0x0000000181554270
		}
	
		internal abstract class IcRKTtNeZRRArveGoktgEdYanpJ : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateAxis2D // TypeDefIndex: 6098
		{
			// Fields
			protected const int wjpgCBMxcJpstDTqIbiSGKQLnjg = 0; // Metadata: 0x0076434D
			protected const int LEaUruLkKoduqbnMNbAekYUtYAI = 1; // Metadata: 0x00764351
			protected const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 2; // Metadata: 0x00764355
	
			// Properties
			public Vector2 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x000000018154E8F0-0x000000018154EBB0 
			public Vector2 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x000000018154E600-0x000000018154E8F0 
			public IControllerTemplateAxis nNNSsjDADTeOSDOfDqdrXrZdKQd { get; } // 0x000000018154E520-0x000000018154E600 
			public IControllerTemplateAxis AqQpbMYqbiUnnuilmhdyOXFOFoI { get; } // 0x000000018154EBB0-0x000000018154EC90 
	
			// Constructors
			protected IcRKTtNeZRRArveGoktgEdYanpJ(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x000000018154E510-0x000000018154E520
		}
	
		internal abstract class UZRIRmnTHtHUrIhzebhIbGDzHICR : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateAxis3D // TypeDefIndex: 6099
		{
			// Fields
			protected const int wjpgCBMxcJpstDTqIbiSGKQLnjg = 0; // Metadata: 0x00764359
			protected const int LEaUruLkKoduqbnMNbAekYUtYAI = 1; // Metadata: 0x0076435D
			protected const int HzPzlSnkOTErRgiqIdefuovowIKo = 2; // Metadata: 0x00764361
			protected const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 3; // Metadata: 0x00764365
	
			// Properties
			public Vector3 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000181552F80-0x0000000181553380 
			public Vector3 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x0000000181552B80-0x0000000181552F80 
			public IControllerTemplateAxis nNNSsjDADTeOSDOfDqdrXrZdKQd { get; } // 0x0000000181552AA0-0x0000000181552B80 
			public IControllerTemplateAxis AqQpbMYqbiUnnuilmhdyOXFOFoI { get; } // 0x0000000181553380-0x0000000181553460 
			public IControllerTemplateAxis dUFMdsYfQzbWedBwqfhpwhYgpAzi { get; } // 0x00000001815529C0-0x0000000181552AA0 
	
			// Constructors
			protected UZRIRmnTHtHUrIhzebhIbGDzHICR(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x000000018154E510-0x000000018154E520
		}
	
		internal abstract class uTxUfgOiQNURvPChXIypCPYRBYQ : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateAxis6D // TypeDefIndex: 6100
		{
			// Fields
			protected const int SFZCtsAMycUHzjXFnViABeQcdtO = 0; // Metadata: 0x00764369
			protected const int BzGxkcndVIvGGGTJLfuhCOnJrkI = 1; // Metadata: 0x0076436D
			protected const int gbqrQktAQHcbYftAHpbLUsSCpUe = 2; // Metadata: 0x00764371
			protected const int BMeeqBBXKmlJmHtrWkGOlIzOQyMC = 3; // Metadata: 0x00764375
			protected const int kHPXXfKCcBMeFBnmWVpmyOpXaCT = 4; // Metadata: 0x00764379
			protected const int mmwGMcpOPhvATumMEVJDoSyEDcU = 5; // Metadata: 0x0076437D
			protected const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 6; // Metadata: 0x00764381
	
			// Properties
			public Vector3 zNPvFpvqeBhBWvhYDxPITBksqbH { get; } // 0x0000000181557560-0x0000000181557950 
			public Vector3 qddefUiuEoaNXXKsMDqwbYwrzRfG { get; } // 0x0000000181556ED0-0x00000001815572C0 
			public Vector3 XyRcbqECbieglNQLRYEsCcrvxJbo { get; } // 0x0000000181558020-0x0000000181558410 
			public Vector3 hYZaPcgZBKwaeSjRBRwbGtlxJNOe { get; } // 0x0000000181557950-0x0000000181557D40 
			public IControllerTemplateAxis HduhRkWIJFXWvufnWQeHYKxuCkMg { get; } // 0x00000001815572C0-0x00000001815573A0 
			public IControllerTemplateAxis LmvrlYbVIxpSdCUheWpnYMVnEzk { get; } // 0x00000001815573A0-0x0000000181557480 
			public IControllerTemplateAxis lTECiqLpbMVWKuVfQrvMvPJjswo { get; } // 0x0000000181557480-0x0000000181557560 
			public IControllerTemplateAxis ajojxpUnLKsoGgMfHlsCIqtSodi { get; } // 0x0000000181557D40-0x0000000181557E20 
			public IControllerTemplateAxis UXzFvxRVWbfflnyXIDxucTsOdtB { get; } // 0x0000000181557E20-0x0000000181557F00 
			public IControllerTemplateAxis DtOFdpLYpHdCCfRBXLrrFpgJzZF { get; } // 0x0000000181557F00-0x0000000181558020 
	
			// Constructors
			protected uTxUfgOiQNURvPChXIypCPYRBYQ(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x000000018154E510-0x000000018154E520
		}
	
		internal sealed class kIbPlwMGfbOBbkmYvurjruhOmgR : UZRIRmnTHtHUrIhzebhIbGDzHICR, IControllerTemplateStick // TypeDefIndex: 6101
		{
			// Fields
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 3; // Metadata: 0x00764385
	
			// Properties
			public IControllerTemplateAxis XyRcbqECbieglNQLRYEsCcrvxJbo { get; } // 0x00000001815548D0-0x00000001815549B0 
	
			// Constructors
			private kIbPlwMGfbOBbkmYvurjruhOmgR(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x00000001815545C0-0x00000001815546B0
			public kIbPlwMGfbOBbkmYvurjruhOmgR(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL xAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL yAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL zAxis); // 0x00000001815546B0-0x00000001815548D0
		}
	
		internal sealed class tuEOTEuKqAbwXRrEKMPsqEWNnby : IcRKTtNeZRRArveGoktgEdYanpJ, IControllerTemplateThumbStick // TypeDefIndex: 6102
		{
			// Fields
			private const int mgGqDxRyHlKHppIisbewmsWFzsP = 2; // Metadata: 0x00764389
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 3; // Metadata: 0x0076438D
	
			// Properties
			public IControllerTemplateButton EaqkEcDlmDHXCMtKLBziapwyeHfT { get; } // 0x0000000181556DF0-0x0000000181556ED0 
	
			// Constructors
			private tuEOTEuKqAbwXRrEKMPsqEWNnby(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000181556AE0-0x0000000181556BD0
			internal tuEOTEuKqAbwXRrEKMPsqEWNnby(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL xAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL yAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL button); // 0x0000000181556BD0-0x0000000181556DF0
		}
	
		internal sealed class JbjMDsVrQPuqNDEfubxyjWhcTmK : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateDPad // TypeDefIndex: 6103
		{
			// Fields
			private const int oQAkzCgPCxSxFqAUikDOBsZXDDC = 0; // Metadata: 0x00764391
			private const int ngODNUGGiQbrNRepKZmYoGFvrOfe = 1; // Metadata: 0x00764395
			private const int NCCxowypuDdKUoISYuIYFySIIrM = 2; // Metadata: 0x00764399
			private const int bKqrIDxzqDabOatIKEGgvpxQhvq = 3; // Metadata: 0x0076439D
			private const int XVFVTYpXETLPCwPhRlaRQXjEbog = 4; // Metadata: 0x007643A1
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 5; // Metadata: 0x007643A5
	
			// Properties
			public Vector2 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x000000018154F9A0-0x000000018154FE50 
			public Vector2 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x000000018154F4F0-0x000000018154F9A0 
			public IControllerTemplateButton xHwVJEHIDBSbHTHmPinLpFIiclL { get; } // 0x000000018154F410-0x000000018154F4F0 
			public IControllerTemplateButton fifGhyxBhATzweykVeGAHsleBaB { get; } // 0x000000018154F330-0x000000018154F410 
			public IControllerTemplateButton yYgJokxONevQcKPvgIDhkGmQmLq { get; } // 0x000000018154F050-0x000000018154F170 
			public IControllerTemplateButton ufmkrvcpjxzyDasVMJazgfPUhDQ { get; } // 0x000000018154F170-0x000000018154F250 
			public IControllerTemplateButton EaqkEcDlmDHXCMtKLBziapwyeHfT { get; } // 0x000000018154F250-0x000000018154F330 
	
			// Constructors
			private JbjMDsVrQPuqNDEfubxyjWhcTmK(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x000000018154EC90-0x000000018154ED80
			internal JbjMDsVrQPuqNDEfubxyjWhcTmK(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL up, KMCVBWMPRfCCvsWXeOWVAVbJlSL right, KMCVBWMPRfCCvsWXeOWVAVbJlSL down, KMCVBWMPRfCCvsWXeOWVAVbJlSL left, KMCVBWMPRfCCvsWXeOWVAVbJlSL press); // 0x000000018154ED80-0x000000018154F050
		}
	
		internal sealed class KbXlRnQSZDpXZpZgQwLeyXBeGmE : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateThrottle // TypeDefIndex: 6104
		{
			// Fields
			private const int TQcBXDWWsFbZEbRXiMvycPggfYkE = 0; // Metadata: 0x007643A9
			private const int IjRoGrMZkVmeopVUuulBDlIcbma = 1; // Metadata: 0x007643AD
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 2; // Metadata: 0x007643B1
	
			// Properties
			public float PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000181552570-0x00000001815526F0 
			public float HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x00000001815523F0-0x0000000181552570 
			public IControllerTemplateAxis bsyLbuoRqktxCMFfmDZFuEoECMu { get; } // 0x0000000181552310-0x00000001815523F0 
			public IControllerTemplateButton SeZvGVwmgsgxNNMiPJzdWYzPCOy { get; } // 0x0000000181552230-0x0000000181552310 
	
			// Constructors
			private KbXlRnQSZDpXZpZgQwLeyXBeGmE(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000181552140-0x0000000181552230
			internal KbXlRnQSZDpXZpZgQwLeyXBeGmE(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL axis, KMCVBWMPRfCCvsWXeOWVAVbJlSL zeroDetentButton); // 0x0000000181551F70-0x0000000181552140
		}
	
		internal sealed class lIlDBtDlZdpUYCYSRagDwCVnKCqg : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateHat // TypeDefIndex: 6105
		{
			// Fields
			private const int oQAkzCgPCxSxFqAUikDOBsZXDDC = 0; // Metadata: 0x007643B5
			private const int GgeLGtcpDJxgymIKeJNChTzRLTF = 1; // Metadata: 0x007643B9
			private const int ngODNUGGiQbrNRepKZmYoGFvrOfe = 2; // Metadata: 0x007643BD
			private const int njcuvGlicVIivJOQJEonHNUjQtA = 3; // Metadata: 0x007643C1
			private const int NCCxowypuDdKUoISYuIYFySIIrM = 4; // Metadata: 0x007643C5
			private const int dLyqxUvhDfbbpjLJAujnVnbuFJU = 5; // Metadata: 0x007643C9
			private const int bKqrIDxzqDabOatIKEGgvpxQhvq = 6; // Metadata: 0x007643CD
			private const int MCFRDurIvwNucOSkAiZBWByEeLS = 7; // Metadata: 0x007643D1
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 8; // Metadata: 0x007643D5
	
			// Properties
			public Vector2 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000181555E30-0x00000001815567B0 
			public Vector2 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x0000000181555560-0x0000000181555E30 
			public IControllerTemplateButton xHwVJEHIDBSbHTHmPinLpFIiclL { get; } // 0x0000000181555480-0x0000000181555560 
			public IControllerTemplateButton QjnVkYbIXqqYWfVOkQntsRhOMuK { get; } // 0x00000001815553A0-0x0000000181555480 
			public IControllerTemplateButton fifGhyxBhATzweykVeGAHsleBaB { get; } // 0x00000001815551E0-0x00000001815552C0 
			public IControllerTemplateButton tgKdExIJOdHAIbvUktuLBnEbKKnx { get; } // 0x0000000181554F40-0x0000000181555020 
			public IControllerTemplateButton yYgJokxONevQcKPvgIDhkGmQmLq { get; } // 0x0000000181555020-0x0000000181555100 
			public IControllerTemplateButton lzCsXgdurJQpwFcuhrVBSCGYlKR { get; } // 0x0000000181554E60-0x0000000181554F40 
			public IControllerTemplateButton ufmkrvcpjxzyDasVMJazgfPUhDQ { get; } // 0x0000000181555100-0x00000001815551E0 
			public IControllerTemplateButton KJyLenHXIufKybmHkFtqZmaPUhM { get; } // 0x00000001815552C0-0x00000001815553A0 
	
			// Constructors
			private lIlDBtDlZdpUYCYSRagDwCVnKCqg(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000181554D70-0x0000000181554E60
			internal lIlDBtDlZdpUYCYSRagDwCVnKCqg(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL up, KMCVBWMPRfCCvsWXeOWVAVbJlSL upRight, KMCVBWMPRfCCvsWXeOWVAVbJlSL right, KMCVBWMPRfCCvsWXeOWVAVbJlSL downRight, KMCVBWMPRfCCvsWXeOWVAVbJlSL down, KMCVBWMPRfCCvsWXeOWVAVbJlSL downLeft, KMCVBWMPRfCCvsWXeOWVAVbJlSL left, KMCVBWMPRfCCvsWXeOWVAVbJlSL upLeft); // 0x00000001815549B0-0x0000000181554D70
		}
	
		internal sealed class fQsKtIrYykFeZweCocXLkUMvVIH : IcRKTtNeZRRArveGoktgEdYanpJ, IControllerTemplateYoke // TypeDefIndex: 6106
		{
			// Fields
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 2; // Metadata: 0x007643D9
	
			// Properties
			public IControllerTemplateAxis XyRcbqECbieglNQLRYEsCcrvxJbo { get; } // 0x00000001815540A0-0x0000000181554180 
			public IControllerTemplateAxis dyfjcATmSTnkAhTwisTPIgdzYqh { get; } // 0x0000000181553FC0-0x00000001815540A0 
	
			// Constructors
			private fQsKtIrYykFeZweCocXLkUMvVIH(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000181553E40-0x0000000181553E70
			internal fQsKtIrYykFeZweCocXLkUMvVIH(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL rollAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL pitchAxis); // 0x0000000181553E70-0x0000000181553FC0
		}
	
		internal sealed class LdlVuTDcjTesFajrqPIKPmgNMlCL : uTxUfgOiQNURvPChXIypCPYRBYQ, IControllerTemplateStick6D // TypeDefIndex: 6107
		{
			// Fields
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 6; // Metadata: 0x007643DD
	
			// Constructors
			private LdlVuTDcjTesFajrqPIKPmgNMlCL(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000181552990-0x00000001815529C0
			internal LdlVuTDcjTesFajrqPIKPmgNMlCL(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL positionX, KMCVBWMPRfCCvsWXeOWVAVbJlSL positionY, KMCVBWMPRfCCvsWXeOWVAVbJlSL positionZ, KMCVBWMPRfCCvsWXeOWVAVbJlSL rotationX, KMCVBWMPRfCCvsWXeOWVAVbJlSL rotationY, KMCVBWMPRfCCvsWXeOWVAVbJlSL rotationZ); // 0x00000001815526F0-0x0000000181552990
		}
	
		internal class bZJyKtoDpKBrniWesjOeCJlrijn // TypeDefIndex: 6108
		{
			// Fields
			public readonly Controller.Element bDuDNJMpWydtSCGFbesOhkyhlgiA; // 0x10
			public readonly IControllerElementTarget xPZdhDiOAODYIzoOlCwTEHEonFp; // 0x18
	
			// Properties
			public bool GHUeJCzFrDgzBXDTzvzXRREPKiu { get; } // 0x00000001815537F0-0x0000000181553970 
			public bool CYoiuSaiDOhzEDDwIKdSkbMwjSa { get; } // 0x00000001815535C0-0x00000001815537F0 
			public bool WYJZMikCCobqJEBifGUemzdCEbUz { get; } // 0x0000000181553C80-0x0000000181553D40 
			public bool NNbGOZMcXVJtDpyGwfVLmfRMBaE { get; } // 0x0000000181553D40-0x0000000181553E40 
			public float SmusaJYEiWkzlQwwWeWgpvQUdTv { get; } // 0x0000000181553AE0-0x0000000181553C80 
			public float KWEArpYLlLDDbadXGBrjBxHaMRC { get; } // 0x0000000181553970-0x0000000181553AE0 
	
			// Constructors
			public bZJyKtoDpKBrniWesjOeCJlrijn(IControllerElementTarget target, Controller.Element element); // 0x0000000180F5CFD0-0x0000000180F5D010
	
			// Methods
			public static bZJyKtoDpKBrniWesjOeCJlrijn EMrPyzqGuVTmURWytVHqWrdHoDK(); // 0x0000000181553550-0x00000001815535C0
		}
	
		internal class VFxPhDPrNTgTyVHycNmEMHDCedd // TypeDefIndex: 6109
		{
			// Fields
			public readonly Controller jbVnEoSGijlOtsPVojcUnqQxqRw; // 0x10
			public readonly IHardwareControllerTemplateMap_Internal sSbEZCaDREYtKmkAmjHJRMyprbG; // 0x18
	
			// Constructors
			public VFxPhDPrNTgTyVHycNmEMHDCedd(Controller controller, IHardwareControllerTemplateMap_Internal templateMap); // 0x0000000181553460-0x0000000181553550
		}
	
		// Constructors
		protected ControllerTemplate(object payload); // 0x0000000181542DF0-0x0000000181542E80
		private ControllerTemplate(VFxPhDPrNTgTyVHycNmEMHDCedd initializer); // 0x0000000181542E80-0x0000000181545F70
	
		// Methods
		protected IControllerTemplateElement GetElement(int id); // 0x0000000181542370-0x0000000181542670
		protected T GetElement<T>(int id)
			where T : class, IControllerTemplateElement;
		IControllerTemplateElement IControllerTemplate.GetElement(int param_0000cd4b); // 0x0000000181542990-0x0000000181542A50
		T IControllerTemplate.GetElement<T>(int param_0000cd4c)
			where T : class, IControllerTemplateElement;
		int IControllerTemplate.GetElementTargets(ControllerElementTarget param_0000cd4d, IList<ControllerTemplateElementTarget> param_0000cd4e); // 0x0000000181542880-0x0000000181542990
		private int EipMJtPImKVJQBqufeiVaoyqHqL(ControllerElementTarget param_0000cd4f, ref IList<ControllerTemplateElementTarget> param_0000cd50); // 0x0000000181541FF0-0x00000001815422C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static Type GetInterfaceType(ControllerTemplateElementType elementType); // 0x0000000181542670-0x0000000181542780
		private static IList<bZJyKtoDpKBrniWesjOeCJlrijn> rACWlXdmVRNjpPnzabTwfjNfTtn(Controller param_0000cd52, IControllerTemplateAxisSource param_0000cd53); // 0x0000000181546200-0x0000000181546940
		private static IList<bZJyKtoDpKBrniWesjOeCJlrijn> rACWlXdmVRNjpPnzabTwfjNfTtn(Controller param_0000cd54, IControllerTemplateButtonSource param_0000cd55); // 0x0000000181546060-0x00000001815460D0
		private static IList<bZJyKtoDpKBrniWesjOeCJlrijn> rACWlXdmVRNjpPnzabTwfjNfTtn(Controller param_0000cd56, IControllerElementTarget param_0000cd57); // 0x00000001815460D0-0x0000000181546200
		private static IControllerTemplateElement JBZNIUqbswEjAdvJHzevReoISFt(List<IControllerTemplateElement> param_0000cd58, int param_0000cd59); // 0x0000000181542780-0x0000000181542880
		private static KMCVBWMPRfCCvsWXeOWVAVbJlSL mfezPfINNspUYIPtDUojBZinDwU(IControllerTemplate param_0000cd5a, ADictionary<int, IControllerTemplateElement> param_0000cd5b, int param_0000cd5c); // 0x0000000181545F70-0x0000000181546060
		private static KMCVBWMPRfCCvsWXeOWVAVbJlSL FqdaJmHwGdXJxRcJfcNriYraEQxA(IControllerTemplate param_0000cd5d, ADictionary<int, IControllerTemplateElement> param_0000cd5e, int param_0000cd5f); // 0x00000001815422C0-0x0000000181542370
	}
}
