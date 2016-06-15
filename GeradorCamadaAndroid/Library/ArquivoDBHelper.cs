using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCamadaAndroid.Library
{
    public class ArquivoDBHelper
    {
        public static string RetornaTextoArquivo(string pacote)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("package " + pacote + ".data;                                                               ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("import android.content.Context;                                                            ");
            texto.AppendLine("import android.database.sqlite.SQLiteDatabase;                                             ");
            texto.AppendLine("import android.database.sqlite.SQLiteOpenHelper;                                           ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("import java.io.InputStream;                                                                ");
            texto.AppendLine("import java.util.Scanner;                                                                  ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("import " + pacote + ".R;                                                                   ");
            texto.AppendLine("import br.com.pedrogutierres.androidutils.utils.AndroidUtils;                              ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("public class DBHelper extends SQLiteOpenHelper {                                           ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    public static final String DB_NAME = \"NOME_BANCO\";                                   ");
            texto.AppendLine("    public static final int DB_VERSION = 1;                                                ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    private static DBHelper instance;                                                      ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    private Context context;                                                               ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    private DBHelper(Context context) {                                                    ");
            texto.AppendLine("        super(context, DB_NAME, null, DB_VERSION);                                         ");
            texto.AppendLine("        this.context = context;                                                            ");
            texto.AppendLine("    }                                                                                      ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    public static DBHelper getInstance(Context context) {                                  ");
            texto.AppendLine("        if (instance == null) {                                                            ");
            texto.AppendLine("            instance = new DBHelper(context);                                              ");
            texto.AppendLine("        }                                                                                  ");
            texto.AppendLine("        return instance;                                                                   ");
            texto.AppendLine("    }                                                                                      ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    public void executaScript(SQLiteDatabase db, int resource) {                           ");
            texto.AppendLine("        InputStream in = context.getResources().openRawResource(resource);                 ");
            texto.AppendLine("        Scanner scanner = new Scanner(in);                                                 ");
            texto.AppendLine("        scanner.useDelimiter(\";\");                                                       ");
            texto.AppendLine("        try {                                                                              ");
            texto.AppendLine("            while (scanner.hasNext()) {                                                    ");
            texto.AppendLine("                String sql = scanner.next().trim();                                        ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("                if (!AndroidUtils.isEmptyOrWhiteSpaces(sql)) {                             ");
            texto.AppendLine("                    db.execSQL(sql);                                                       ");
            texto.AppendLine("                }                                                                          ");
            texto.AppendLine("            }                                                                              ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("            AndroidUtils.log(\"Tabelas criadas/atualizadas\");                             ");
            texto.AppendLine("        } catch (Exception ex) {                                                           ");
            texto.AppendLine("            AndroidUtils.log(\"Erro ao criar/atualizar tabelas: \" + ex.getMessage());     ");
            texto.AppendLine("        } finally {                                                                        ");
            texto.AppendLine("            scanner.close();                                                               ");
            texto.AppendLine("        }                                                                                  ");
            texto.AppendLine("    }                                                                                      ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    @Override                                                                              ");
            texto.AppendLine("    public void onCreate(SQLiteDatabase db) {                                              ");
            texto.AppendLine("        AndroidUtils.log(\"Iniciar criação das tabelas\");                                 ");
            texto.AppendLine("        executaScript(db, R.raw.db_script_create);                                         ");
            texto.AppendLine("    }                                                                                      ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    @Override                                                                              ");
            texto.AppendLine("    public void onUpgrade(SQLiteDatabase db, int antigo, int novo) {                       ");
            texto.AppendLine("        //if (antigo <= 1) {                                                               ");
            texto.AppendLine("        //    executaScript(db, R.raw.db_script_update_1);                                 ");
            texto.AppendLine("        //}                                                                                ");
            texto.AppendLine("    }                                                                                      ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("    @Override                                                                              ");
            texto.AppendLine("    // Chamado pelo Android quando o banco de dados é aberto                               ");
            texto.AppendLine("    public void onOpen(SQLiteDatabase db) {                                                ");
            texto.AppendLine("        super.onOpen(db);                                                                  ");
            texto.AppendLine("                                                                                           ");
            texto.AppendLine("        // Habilita as chaves estrangeiras. O SQLite exige que isto seja feito a cada      ");
            texto.AppendLine("        // abertura do banco de dados                                                      ");
            texto.AppendLine("        if (!db.isReadOnly()) {                                                            ");
            texto.AppendLine("            db.execSQL(\"PRAGMA foreign_keys=ON;\");                                       ");
            texto.AppendLine("        }                                                                                  ");
            texto.AppendLine("    }                                                                                      ");
            texto.AppendLine("}                                                                                          ");

            return texto.ToString();
        }
    }
}
