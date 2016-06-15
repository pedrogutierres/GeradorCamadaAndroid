using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCamadaAndroid.Library
{
    public class ArquivoBaseObjects
    {
        public static string RetornaTextoArquivo(string pacote)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("package "+ pacote + ".basemodel;                                   ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("import com.google.gson.annotations.SerializedName;                 ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("import java.io.Serializable;                                       ");
            texto.AppendLine("import java.util.Date;                                             ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("public abstract class BaseObject implements Serializable {         ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("    @SerializedName(\"datahora_criacao\")                          ");
            texto.AppendLine("    protected Date datahora_criacao;                               ");
            texto.AppendLine("    @SerializedName(\"datahora_alteracao\")                        ");
            texto.AppendLine("    protected Date datahora_alteracao;                             ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("    public Date getDatahora_alteracao() {                          ");
            texto.AppendLine("        return datahora_alteracao;                                 ");
            texto.AppendLine("    }                                                              ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("    public void setDatahora_alteracao(Date datahora_alteracao) {   ");
            texto.AppendLine("        this.datahora_alteracao = datahora_alteracao;              ");
            texto.AppendLine("    }                                                              ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("    public Date getDatahora_criacao() {                            ");
            texto.AppendLine("        return datahora_criacao;                                   ");
            texto.AppendLine("    }                                                              ");
            texto.AppendLine("                                                                   ");
            texto.AppendLine("    public void setDatahora_criacao(Date datahora_criacao) {       ");
            texto.AppendLine("        this.datahora_criacao = datahora_criacao;                  ");
            texto.AppendLine("    }                                                              ");
            texto.AppendLine("}                                                                  ");
            return texto.ToString();
        }
    }
}
