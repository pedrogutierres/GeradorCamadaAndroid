using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCamadaAndroid.Library
{
    public class ArquivoDAO
    {
        public static string RetornaTextoArquivo(string pacote)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("package " + pacote + ".dal;                                                   ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("import android.content.ContentResolver;                                       ");
            texto.AppendLine("import android.content.Context;                                               ");
            texto.AppendLine("import android.database.Cursor;                                               ");
            texto.AppendLine("import android.net.Uri;                                                       ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("// Superclasse de todos os DAOs da aplicação                                  ");
            texto.AppendLine("public abstract class DAO {                                                   ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("    private Context context;                                                  ");
            texto.AppendLine("    private ContentResolver cr;                                               ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("    public DAO() {                                                            ");
            texto.AppendLine("    }                                                                         ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("    public void init(Context context) {                                       ");
            texto.AppendLine("        this.context = context;                                               ");
            texto.AppendLine("        this.cr = context.getContentResolver();                               ");
            texto.AppendLine("    }                                                                         ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("    protected Context context() {                                             ");
            texto.AppendLine("        return context;                                                       ");
            texto.AppendLine("    }                                                                         ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("    protected ContentResolver contentResolver() {                             ");
            texto.AppendLine("        return cr;                                                            ");
            texto.AppendLine("    }                                                                         ");
            texto.AppendLine("                                                                              ");
            texto.AppendLine("    protected Cursor rawQuery(Uri uri, String sql, String[] selectionArgs) {  ");
            texto.AppendLine("        return contentResolver().query(uri, null, sql, selectionArgs, null);  ");
            texto.AppendLine("    }                                                                         ");
            texto.AppendLine("}                                                                             ");

            return texto.ToString();
        }
    }
}
