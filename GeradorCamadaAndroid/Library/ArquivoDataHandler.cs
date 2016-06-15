using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCamadaAndroid.Library
{
    public class ArquivoDataHandler
    {
        public static string RetornaTextoArquivo(string pacote)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("package " + pacote + ".provider;                                                                                 ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("import android.content.ContentResolver;                                                                                               ");
            texto.AppendLine("import android.content.ContentValues;                                                                                                 ");
            texto.AppendLine("import android.content.Context;                                                                                                       ");
            texto.AppendLine("import android.database.Cursor;                                                                                                       ");
            texto.AppendLine("import android.database.sqlite.SQLiteDatabase;                                                                                        ");
            texto.AppendLine("import android.net.Uri;                                                                                                               ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("import " + pacote + ".data.DBHelper;                                                                             ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("// Superclasse dos handlers                                                                                                           ");
            texto.AppendLine("public abstract class DataHandler {                                                                                                   ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    private static SQLiteDatabase db;                                                                                                 ");
            texto.AppendLine("    private ContentResolver cr;                                                                                                       ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    protected DataHandler(Context context) {                                                                                          ");
            texto.AppendLine("        this.cr = context.getContentResolver();                                                                                       ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("        if (this.db == null)                                                                                                          ");
            texto.AppendLine("            this.db = DBHelper.getInstance(context).getWritableDatabase();                                                            ");
            texto.AppendLine("    }                                                                                                                                 ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    protected SQLiteDatabase db() {                                                                                                   ");
            texto.AppendLine("        return db;                                                                                                                    ");
            texto.AppendLine("    }                                                                                                                                 ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    void notifyChange(Uri uri) {                                                                                                      ");
            texto.AppendLine("        cr.notifyChange(uri, null);                                                                                                   ");
            texto.AppendLine("    }                                                                                                                                 ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    void setNotificationUri(Cursor c, Uri uri) {                                                                                      ");
            texto.AppendLine("        c.setNotificationUri(cr, uri);                                                                                                ");
            texto.AppendLine("    }                                                                                                                                 ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    public abstract Cursor query(int code, Uri uri, String[] projection, String selection, String[] selectionArgs, String sortOrder); ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    public abstract Cursor rawQuery(String selection, String[] selectionArgs);                                                        ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    public abstract Uri insert(int code, Uri uri, ContentValues values);                                                              ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    public abstract int update(int code, Uri uri, ContentValues values, String selection, String[] selectionArgs);                    ");
            texto.AppendLine("                                                                                                                                      ");
            texto.AppendLine("    public abstract int delete(int code, Uri uri, String selection, String[] selectionArgs);                                          ");
            texto.AppendLine("}");
            return texto.ToString();
        }
    }
}
