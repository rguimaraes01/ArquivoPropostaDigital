
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Projeto.Infra.DataContext
{

using System;
    using System.Collections.Generic;
    
public partial class TB_PROPOSTA
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TB_PROPOSTA()
    {

        this.TB_CLIENTE = new HashSet<TB_CLIENTE>();

        this.TB_BENEFICIARIO = new HashSet<TB_BENEFICIARIO>();

    }


    public int cd_ctt { get; set; }

    public int cd_prd { get; set; }

    public int nr_ppt { get; set; }

    public Nullable<System.DateTime> dt_inivig { get; set; }

    public Nullable<System.DateTime> dt_vndppt { get; set; }

    public Nullable<System.DateTime> dt_iclppt { get; set; }

    public string id_ppncjgpcp { get; set; }

    public Nullable<System.DateTime> dt_ven { get; set; }

    public string ds_pervig { get; set; }

    public Nullable<int> cd_clb { get; set; }

    public Nullable<int> cd_clbsup { get; set; }

    public string ds_perpag { get; set; }

    public Nullable<decimal> vl_przrec { get; set; }

    public Nullable<int> qt_przrec { get; set; }

    public Nullable<decimal> vr_pmotot { get; set; }

    public Nullable<System.DateTime> dt_digppt { get; set; }

    public string cd_usu { get; set; }

    public string id_sitppt { get; set; }

    public Nullable<System.DateTime> dt_excppt { get; set; }

    public System.DateTime dt_sitppt { get; set; }

    public Nullable<System.DateTime> dt_ultpss { get; set; }

    public Nullable<decimal> vr_pmopcp { get; set; }

    public Nullable<decimal> vr_pmototdpd { get; set; }

    public Nullable<decimal> vr_cobadc { get; set; }

    public string id_cboadcbnfmsa { get; set; }

    public short id_meicba { get; set; }

    public string cd_orivnd { get; set; }

    public Nullable<int> cd_cra { get; set; }

    public string id_autdpdagr { get; set; }

    public Nullable<int> cd_emp { get; set; }

    public string id_bencjgflh { get; set; }

    public Nullable<bool> fl_canpag { get; set; }

    public string ds_infadc { get; set; }

    public string tp_motdve { get; set; }

    public Nullable<decimal> vr_pmototflh { get; set; }

    public Nullable<decimal> vr_pmodoecon { get; set; }

    public Nullable<decimal> vr_pmocobinf { get; set; }

    public Nullable<decimal> vr_pmoalodtr { get; set; }

    public Nullable<int> cd_envkit { get; set; }

    public Nullable<decimal> vl_przreccjg { get; set; }

    public Nullable<decimal> vr_cobadccjg { get; set; }

    public Nullable<int> qt_przreccjg { get; set; }

    public Nullable<bool> fl_dadcli { get; set; }

    public Nullable<int> tp_vldcli { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TB_CLIENTE> TB_CLIENTE { get; set; }

    public virtual TB_DADOS_BANCARIOS TB_DADOS_BANCARIOS { get; set; }

    public virtual TB_DADOS_CARTAO TB_DADOS_CARTAO { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TB_BENEFICIARIO> TB_BENEFICIARIO { get; set; }

}

}
