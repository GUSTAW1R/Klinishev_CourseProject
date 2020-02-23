using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinishev_CourseProject_Controllers
{
    public class ReportController
    {
        private string[] Graphs1 = new string[] { "Название продукции", "Зима", "Весна", "Лето", "Осень" };
        private string[] Season2019 = new string[] { "1543622400", "1551312000", "1551398400", "1559260800", "1559347200", "1567209600", "1567296000", "1575158400" };
        private string[] Season2020 = new string[] { "1575158400", "1582934400", "1583020800", "1590883200", "1590969600", "1598832000", "1598918400", "1606694400" };
        private SQLiteConnection connection;
        private string sPath = "C:\\Users\\Gustaw R\\source\\repos\\Klinishev_CourseProject_View\\Klinishev_CourseProject_Models\\KlinishevCourseProjectDB.db";
        public ReportController()
        {
            string ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3;DateTimeFormat=UnixEpoch";
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public DataGridView createCrossReport(DataGridView dataGridView, String year)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Add("name", "Название продукции");
            dataGridView.Columns.Add("winter", "Зима");
            dataGridView.Columns.Add("spring", "Весна");
            dataGridView.Columns.Add("summer", "Лето");
            dataGridView.Columns.Add("autumm", "Осень");
            SQLiteCommand getCountRow = connection.CreateCommand();
            getCountRow.CommandText = "select COUNT(Type) from PriceList";
            int count = Convert.ToInt32(getCountRow.ExecuteScalar());
            string[] arrTown = new string[count];
            for (int i = 0; i < count; i++)
            {
                SQLiteCommand getArrTown = connection.CreateCommand();
                getArrTown.CommandText = "select Type from PriceList WHERE Id = '" + (i + 1) + "' AND Type IS NOT NULL";
                string town = Convert.ToString(getArrTown.ExecuteScalar());
                arrTown[i] = town;
            }
            if(year == "2019")
            {
                for (int i = 0; i < count; i++)
                {
                    SQLiteCommand getCount1 = connection.CreateCommand();
                    getCount1.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2019[0] + "' AND '" + Season2019[1] + "'";
                    int c1 = Convert.ToInt32(getCount1.ExecuteScalar());

                    SQLiteCommand getCount2 = connection.CreateCommand();
                    getCount2.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2019[2] + "' AND '" + Season2019[3] + "'";
                    int c2 = Convert.ToInt32(getCount2.ExecuteScalar());

                    SQLiteCommand getCount3 = connection.CreateCommand();
                    getCount3.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2019[4] + "' AND '" + Season2019[5] + "'";
                    int c3 = Convert.ToInt32(getCount3.ExecuteScalar());

                    SQLiteCommand getCount4 = connection.CreateCommand();
                    getCount4.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2019[6] + "' AND '" + Season2019[7] + "'";
                    int c4 = Convert.ToInt32(getCount4.ExecuteScalar());

                    dataGridView.Rows.Add(arrTown[i], c1.ToString(), c2.ToString(), c3.ToString(), c4.ToString());
                }
            }
            if(year == "2020")
            {
                for (int i = 0; i < count; i++)
                {
                    SQLiteCommand getCount1 = connection.CreateCommand();
                    getCount1.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2020[0] + "' AND '" + Season2020[1] + "'";
                    int c1 = Convert.ToInt32(getCount1.ExecuteScalar());

                    SQLiteCommand getCount2 = connection.CreateCommand();
                    getCount2.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2020[2] + "' AND '" + Season2020[3] + "'";
                    int c2 = Convert.ToInt32(getCount2.ExecuteScalar());

                    SQLiteCommand getCount3 = connection.CreateCommand();
                    getCount3.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2020[4] + "' AND '" + Season2020[5] + "'";
                    int c3 = Convert.ToInt32(getCount3.ExecuteScalar());

                    SQLiteCommand getCount4 = connection.CreateCommand();
                    getCount4.CommandText = "select COUNT(IdCustomer) from Request WHERE Type = '" + arrTown[i] + "' AND Date BETWEEN '" + Season2020[6] + "' AND '" + Season2020[7] + "'";
                    int c4 = Convert.ToInt32(getCount4.ExecuteScalar());

                    dataGridView.Rows.Add(arrTown[i], c1.ToString(), c2.ToString(), c3.ToString(), c4.ToString());
                }
            }
            
            return dataGridView;
        }

        public void ExportFile(DataGridView dataGridView, string year, string fileName)
        {
            SQLiteCommand getCount2 = connection.CreateCommand();
            getCount2.CommandText = "select COUNT(Type) from Request";
            int sum = Convert.ToInt32(getCount2.ExecuteScalar());

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var winword = new Microsoft.Office.Interop.Word.Application();
            try
            {
                object missing = System.Reflection.Missing.Value;
                //создаем документ
                Microsoft.Office.Interop.Word.Document document =
                winword.Documents.Add(ref missing, ref missing, ref missing, ref
               missing);
                //получаем ссылку на параграф
                var paragraph = document.Paragraphs.Add(missing);
                var range = paragraph.Range;
                //задаем текст
                range.Text = "Отчёт: количество заявок на продукцию за год по сезонам";
                //задаем настройки шрифта
                var font = range.Font;
                font.Size = 16;
                font.Name = "Times New Roman";
                font.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range.InsertParagraphAfter();

                paragraph = document.Paragraphs.Add(missing);
                range = paragraph.Range;
                //задаем текст
                range.Text = "Год: " + year;
                //задаем настройки шрифта
                font = range.Font;
                font.Size = 16;
                font.Name = "Times New Roman";
                font.Bold = 1;
                //задаем настройки абзаца
                paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range.InsertParagraphAfter();

                //создаем таблицу
                var paragraphTable = document.Paragraphs.Add(Type.Missing);
                var rangeTable = paragraphTable.Range;
                var table = document.Tables.Add(rangeTable, dataGridView.Rows.Count, 5, ref
               missing, ref missing);
                font = table.Range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";
                var paragraphTableFormat = table.Range.ParagraphFormat;
                paragraphTableFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphTableFormat.SpaceAfter = 0;
                paragraphTableFormat.SpaceBefore = 0;
                for (int i = 0; i < 5; i++)
                {

                    table.Cell(1, i + 1).Range.Text = Graphs1[i];

                }

                for (int rows = 0; rows < dataGridView.Rows.Count - 1; rows++)
                {
                    for (int col = 0; col < dataGridView.Rows[rows].Cells.Count; col++)
                    {
                        if (dataGridView.Rows[rows].Cells[col] != null)
                        {
                            string value = dataGridView.Rows[rows].Cells[col].Value.ToString();
                            table.Cell(rows + 2, col + 1).Range.Text = value;
                        }

                    }
                }
                //задаем границы таблицы
                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                paragraph = document.Paragraphs.Add(missing);
                range = paragraph.Range;
                range.Text = "Общая сумма: " + sum;
                font = range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";
                paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 10;
                range.InsertParagraphAfter();

                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                paragraph = document.Paragraphs.Add(missing);
                range = paragraph.Range;
                range.Text = "Дата составления: " + DateTime.Now.ToString("dd/MM/yyyy");
                font = range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";
                paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 10;
                range.InsertParagraphAfter();
                //сохраняем
                object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                document.SaveAs(fileName, ref fileFormat, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing);
                document.Close(ref missing, ref missing, ref missing);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                winword.Quit();
            }
        }
        private string convertToUnix(DateTime date)
        {
            string unixTime = (date - new System.DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds.ToString();
            return unixTime;
        }
    }
}
