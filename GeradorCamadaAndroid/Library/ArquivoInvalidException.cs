using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCamadaAndroid.Library
{
    public class ArquivoInvalidException
    {
        public static string RetornaTextoArquivo(string pacote)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("package " + pacote + ".provider;           ");
            texto.AppendLine("                                                                ");
            texto.AppendLine("import android.net.Uri;                                         ");
            texto.AppendLine("                                                                ");
            texto.AppendLine("// Exceção que representa uma URI inv�lida                      ");
            texto.AppendLine("@SuppressWarnings(\"serial\")                                     ");
            texto.AppendLine("public class InvalidURIException extends RuntimeException {     ");
            texto.AppendLine("                                                                ");
            texto.AppendLine("	public InvalidURIException(Uri uri) {                         ");
            texto.AppendLine("		super(\"URI inválida: \" + uri);                            ");
            texto.AppendLine("	}                                                             ");
            texto.AppendLine("}                                                               ");
            return texto.ToString();
        }
    }
}
