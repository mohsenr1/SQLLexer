using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLLexerByMohsenr1;
using System.Text.RegularExpressions;

namespace SQLLexerByMohsenr1
{
    public partial class Form1 : Form
    {
        Lexer lexer = new Lexer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckSyntax_Click(object sender, EventArgs e)
        {
            var tokens = lexer.Tokenize(rtMain.Text.ToUpper()); //سورس وارد شده در تکست باکس را به صورت حروف بزرگ به لکسر بده

            try
            {
                rtResult.Clear();
                rtResult.Text = "نتایج:";
                System.Data.DataTable tokensDataTable = new DataTable();
                tokensDataTable.Columns.Add("ID");
                tokensDataTable.Columns.Add("Type");
                tokensDataTable.Columns.Add("Value");
                tokensDataTable.Columns.Add("Line");
                tokensDataTable.Columns.Add("Character");
                tokensDataTable.Columns.Add("Index");
                tokensDataTable.Columns.Add("Lentgh");
                int index = 0;
                foreach (var token in tokens)                   //به ازای همه ی توکن ها در لیست توکن ها
                {
                    rtResult.Text += "\r\n" + token;
                    index++;
                    tokensDataTable.Rows.Add(index, token.Type.ToString(), token.Value.ToString(), token.Position.Line.ToString(), token.Position.Column.ToString(), token.Position.Index.ToString(), token.Value.Length.ToString());
                }

                dtgResualts.DataSource = tokensDataTable.DefaultView ;
                dtgResualts.Refresh();
                lblMessages.Text = "کد اس کیو ال وارد شده از نظر لغوی به نظر درست و صحیح می آید.";
            }
            catch (Exception ex)
            {
                lblMessages.Text = ex.Message.ToString();
            }

        }


        public string ignoreTheSecondTypeOfComments()
        {
            //string[] splitted = Regex.Split(rtMain.Text, @"/\*|\*/");

            //bool commntClosed = true;
            //int count = 0;

            //for (int i = 0; i<splitted.Length; i++)
            //{
            //    if (splitted[i] == "/*")
            //    {
            //        commntClosed = false;
            //        count++;
            //    }
            //    else if (splitted[i] == "*/")
            //    {
            //        commntClosed = true;
            //        count--;
            //    }
            //}

            //foreach (string ss in splitted)
            //{
            //    if ( ss == "/*")
            //    {
            //        commntClosed = false;
            //        count++;
                    
            //    }
            //    else if (ss == "*/")
            //    {
            //        commntClosed = true;
            //        count--;
            //    }
            //}

            //if (commntClosed && count == 0;)


            
            string s = "";
            return s;
        }

        private void rtMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar.ToString() == Keys.F5.ToString())
            //{
            //    btnCheckSyntax_Click(sender, e);
            //}
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void rtMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnCheckSyntax_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                Help hp = new Help();
                hp.ShowDialog();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void splitContainer1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //برای گذر از کامنت هایی که به صورت
            //--<محتوا>
            //نوشته شده اند از این توکن دفینیشن استفاده می کنیم. 
            //در آخر الگوی کامنت را به لیست الگوهایمان در متغیر لکسر اضاف می کنیم. این متغیر نمونه ای از کلاس لکسر است که یک لیست در خود دارد که حاوی الگوهاست.
            //حواستان باشد که ترتیب افزودن الگوها به لیست مهم است. یعنی مهم است اول کامنت ها، بعد کلمات کلیدی و بعد بقیه ی چیز ها اضاف شوند.
            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Comment,
                new Regex(@"--.*"),
                true));

            //برای گذر از کامنت هایی که به صورت
            //    /*<محتوا>*/
            //نوشته شده اند از این توکن دفینیشن استفاده می کنیم. 
            // چون برنامه، توکن ها را خط به خط بررسی می کند، فعلا امکلا گذر از کامنت های چند خطی وجود ندارد.

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Comment,
                new Regex(@"\/\*.*\*\/"),
                true));

            //این استرینگ حاوی الگوهایی برای تطابق با کلمات کلیدی است. تعداد کلمات کلیدی 218 تا هست که از یک وبسایت حاوی کلمات کلیدی مای اس کیو ال گرفته شده است.
            string keywords = @"\bACCESSIBLE\b|\bALTER\b|\bBEFORE\b|\bBINARY\b|\bCASE\b|\bCHARACTER\b|\bCOLUMN\b|\bCONTINUE\b|\bCROSS\b|\bCURRENT_TIMESTAMP\b|\bDATABASE\b|\bDAY_MICROSECOND\b|\bDEFAULT\b|\bDISTINCT\b|\bDOUBLE\b|\bEACH\b|\bENCLOSED\b|\bEXIT\b|\bFETCH\b|\bFLOAT8\b|\bFOREIGN\b|\bGRANT\b|\bHIGH_PRIORITY\b|\bHOUR_SECOND\b|\bINNER\b|\bINSERT\b|\bINT2\b|\bINT8\b|\bJOIN\b|\bKILL\b|\bLEFT\b|\bLINEAR\b|\bLOCALTIME\b|\bLONG\b|\bLOOP\b|\bMATCH\b|\bMEDIUMTEXT\b|\bMINUTE_SECOND\b|\bNATURAL\b|\bNULL\b|\bOPTIMIZE\b|\bOUTER\b|\bPRIMARY\b|\bRANGE\b|\bREAD_WRITE\b|\bREGEXP\b|\bREPEAT\b|\bRESTRICT\b|\bRIGHT\b|\bSCHEMAS\b|\bSENSITIVE\b|\bSHOW\b|\bSPECIFIC\b|\bSQLSTATE\b|\bSQL_CALC_FOUND_ROWS\b|\bSTARTING\b|\bTERMINATED\b|\bTINYINT\b|\bTRAILING\b|\bUNDO\b|\bUNLOCK\b|\bUSAGE\b|\bUTC_DATE\b|\bVALUES\b|\bVARCHARACTER\b|\bWHERE\b|\bWRITE\b|\bZEROFILL\b|\bASENSITIVE\b|\bBIGINT\b|\bBOTH\b|\bCASCADE\b|\bCHAR\b|\bCOLLATE\b|\bCONSTRAINT\b|\bCREATE\b|\bCURRENT_TIME\b|\bCURSOR\b|\bDAY_HOUR\b|\bDAY_SECOND\b|\bDECLARE\b|\bDELETE\b|\bDETERMINISTIC\b|\bDUAL\b|\bELSEIF\b|\bEXISTS\b|\bFALSE\b|\bFLOAT4\b|\bFORCE\b|\bFULLTEXT\b|\bHAVING\b|\bHOUR_MINUTE\b|\bIGNORE\b|\bINFILE\b|\bINSENSITIVE\b|\bINT1\b|\bINT4\b|\bINTERVAL\b|\bITERATE\b|\bKEYS\b|\bLEAVE\b|\bLIMIT\b|\bLOAD\b|\bLOCK\b|\bLONGTEXT\b|\bMASTER_SSL_VERIFY_SERVER_CERT\b|\bMEDIUMINT\b|\bMINUTE_MICROSECOND\b|\bMODIFIES\b|\bNO_WRITE_TO_BINLOG\b|\bOPTIONALLY\b|\bOUT\b|\bPRECISION\b|\bPURGE\b|\bREADS\b|\bREFERENCES\b|\bRENAME\b|\bREQUIRE\b|\bREVOKE\b|\bSCHEMA\b|\bSELECT\b|\bSET\b|\bSPATIAL\b|\bSQLEXCEPTION\b|\bSQL_BIG_RESULT\b|\bSSL\b|\bTABLE\b|\bTINYBLOB\b|\bTRUE\b|\bUNIQUE\b|\bUPDATE\b|\bUSING\b|\bUTC_TIMESTAMP\b|\bVARCHAR\b|\bWHEN\b|\bWITH\b|\bYEAR_MONTH\b|\bADD\b|\bANALYZE\b|\bASC\b|\bBETWEEN\b|\bBLOB\b|\bCALL\b|\bCHANGE\b|\bCHECK\b|\bCONDITION\b|\bCONVERT\b|\bCURRENT_DATE\b|\bCURRENT_USER\b|\bDATABASES\b|\bDAY_MINUTE\b|\bDECIMAL\b|\bDELAYED\b|\bDESCRIBE\b|\bDISTINCTROW\b|\bDROP\b|\bELSE\b|\bESCAPED\b|\bEXPLAIN\b|\bFLOAT\b|\bFOR\b|\bFROM\b|\bGROUP\b|\bHOUR_MICROSECOND\b|\bIF\b|\bINDEX\b|\bINOUT\b|\bINT3\b|\bINTEGER\b|\bLEADING\b|\bLIKE\b|\bLINES\b|\bLOCALTIMESTAMP\b|\bLONGBLOB\b|\bLOW_PRIORITY\b|\bMEDIUMBLOB\b|\bMIDDLEINTNUMERIC\b|\bOPTION\b|\bORDER\b|\bOUTFILE\b|\bPROCEDURE\b|\bREAD\b|\bREAL\b|\bRELEASE\b|\bREPLACE\b|\bRETURN\b|\bRLIKE\b|\bSECOND_MICROSECOND\b|\bSEPARATOR\b|\bSMALLINT\b|\bSQLWARNING\b|\bSQL_SMALL_RESULT\b|\bSTRAIGHT_JOIN\b|\bTHEN\b|\bTINYTEXT\b|\bTRIGGER\b|\bUNION\b|\bUNSIGNED\b|\bUSE\b|\bUTC_TIME\b|\bVARBINARY\b|\bVARYING\b|\bWHILE\b|\bXOR\b|\bFULL\b|\bCOLUMNS\b|\bMIN\b|\bMAX\b|\bSTDEV\b|\bCOUNT\b|\bALL\b|\bTO\b|\bAND\b|\bDESC\b|\bDEC\b|\bIN\b|\bINTO\b|\bAS\b|\bBY\b|\bOR\b|\bDIV\b|\bON\b|\bINT\b|\bIS\b|\bKEY\b|\bMOD\b|\bNOT\b|\bSQL\b";

            //افزودن الگوی کلمات کلیدی به لیست
            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Keyword,
                new Regex(keywords)
            ));


            //الگوی مشهور تشخیص کلمات. این دفعه آندرلاین هم لکس می شود.
            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Literal,
                new Regex(@"[a-zA-Z][a-zA-Z0-9_]*")));

            //متغیر را در اس کیو ال اینگونه تعریف می کنند : @var1 برای همین اینطوری لکس می شود.
            lexer.AddDefinition(new TokenDefinition(
                 Token.TokenType.Variable,
                 new Regex(@"\@[a-zA-Z][a-zA-Z0-9_]*")));

            //و الی آخر
            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.String,
                new Regex(@"\'[^""\']*\'|""[^""\']*""")));


            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Digit,
                new Regex(@"\b[0-9]+\b|\b[0-9]+\.[0-9]+\b")));

            //وقتی 
            //\B
            //را قبل از کاراکتری می آوریم یعنی می گوییم قبل از آن هیچ کلمه ای نباشد. اگر کلمه ای بود این الگو قابل تطبیق نیست.
            //به همین ترتیب برای بعد از آن
            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Operator,
                new Regex(@"\B\*\B|\/|\+|\-")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Parenthese,
                new Regex(@"\(|\)")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.GT,
                new Regex(@">")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.LT,
                new Regex(@"<")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.EQ,
                new Regex(@"=+")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Semicolon,
                new Regex(@";")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Colon,
                new Regex(@",")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.Dot,
                new Regex(@"\.")));

            lexer.AddDefinition(new TokenDefinition(
                Token.TokenType.WhiteSpace,
                new Regex(@"\s+|\t+|\r+\n+"),
                true));
        }

    }
}
