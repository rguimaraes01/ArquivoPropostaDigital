
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
    
public partial class TB_ERRO_REGISTRO
{

    public int cd_erreg { get; set; }

    public int cd_regpss { get; set; }

    public Nullable<int> cd_err { get; set; }

    public string ds_msgerr { get; set; }



    public virtual TB_REGISTRO_PROCESSAMENTO TB_REGISTRO_PROCESSAMENTO { get; set; }

}

}
