using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FAXCOMEXLib;
using System.Drawing.Printing;
using ExcelCOM = Microsoft.Office.Interop.Excel;
using WORDCOM = Microsoft.Office.Interop.Word;

namespace SendFax
{
    public partial class Form1 : Form
    {
        private FaxDocument faxDoc;
        private static FaxServer faxServer;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
           
            FaxSender();
            SendFax();
            //MessageBox.Show("Send complete");
            //sendfax_ex();
        } 

        public void FaxSender()
        {
            try
            {
                faxServer = new FaxServer();
                faxServer.Connect(Environment.MachineName);//Environment.MachineName

                //checking divice
               //  FaxDevices divece =faxServer.GetDevices();
               // rtd_log.Text += "Có 1 didivice " + divece.ItemById[0].DeviceName  + " - -  -   " + divece.ItemById[0].SendingNow.ToString();
               // rtd_log.Text+= divece.ToString() + " \n" + faxServer.Activity.IncomingMessages.ToString() + " \n" + faxServer.Activity.OutgoingMessages.ToString() + " \n" + faxServer.Activity.QueuedMessages.ToString()+ " \n" + faxServer.Activity.RoutingMessages.ToString() + "\n";
                RegisterFaxServerEvents(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void RegisterFaxServerEvents()
        {
            faxServer.OnOutgoingJobAdded +=
                new IFaxServerNotify2_OnOutgoingJobAddedEventHandler(faxServer_OnOutgoingJobAdded);
            faxServer.OnOutgoingJobChanged +=
                    new IFaxServerNotify2_OnOutgoingJobChangedEventHandler(faxServer_OnOutgoingJobChanged);
            faxServer.OnOutgoingJobRemoved +=
                    new IFaxServerNotify2_OnOutgoingJobRemovedEventHandler(faxServer_OnOutgoingJobRemoved);

            var eventsToListen =
                      FAX_SERVER_EVENTS_TYPE_ENUM.fsetFXSSVC_ENDED | FAX_SERVER_EVENTS_TYPE_ENUM.fsetOUT_QUEUE
                    | FAX_SERVER_EVENTS_TYPE_ENUM.fsetOUT_ARCHIVE | FAX_SERVER_EVENTS_TYPE_ENUM.fsetQUEUE_STATE
                    | FAX_SERVER_EVENTS_TYPE_ENUM.fsetACTIVITY | FAX_SERVER_EVENTS_TYPE_ENUM.fsetDEVICE_STATUS;

            faxServer.ListenToServerEvents(eventsToListen);
        }
        #region Event Handlers/Listeners
        string a;
        private static void faxServer_OnOutgoingJobAdded(FaxServer pFaxServer , string bstrJobId)
        {
            //this.a = "  A fax is added to the outgoing queue. --  "+ bstrJobId);

        }

        private static void faxServer_OnOutgoingJobChanged(FaxServer pFaxServer, string bstrJobId, FaxJobStatus pJobStatus)
        {
          //  MessageBox.Show(" A fax is changed to the outgoing queue.  --  "+ pJobStatus);
            pFaxServer.Folders.OutgoingQueue.Refresh();
            PrintFaxStatus(pJobStatus);
        }

        private static void faxServer_OnOutgoingJobRemoved(FaxServer pFaxServer, string bstrJobId)
        {
            MessageBox.Show(" Fax job is removed to outbound queue.");
        }
        #endregion
        private static void PrintFaxStatus(FaxJobStatus faxJobStatus)
        {
            if (faxJobStatus.ExtendedStatusCode == FAX_JOB_EXTENDED_STATUS_ENUM.fjesDIALING)
            {
                //MessageBox.Show("Dialing...");
            }

            if (faxJobStatus.ExtendedStatusCode == FAX_JOB_EXTENDED_STATUS_ENUM.fjesTRANSMITTING)
            {
                //MessageBox.Show("Sending Fax...");
            }

            if (faxJobStatus.Status == FAX_JOB_STATUS_ENUM.fjsCOMPLETED
                && faxJobStatus.ExtendedStatusCode == FAX_JOB_EXTENDED_STATUS_ENUM.fjesCALL_COMPLETED)
            {
                MessageBox.Show(  "Fax is sent successfully.") ;
            }
        }
        public void SendFax()
        {
            try
            {        
                FaxDocumentSetup("Tuan", "THCOMPANY", txt_file.Text, "Send Test Fax from Windows", "Test file", txt_faxnum.Text);
                object submitReturnValue = faxDoc.Submit(faxServer.ServerName);
                faxDoc = null;
                rtd_log.Text += "Activity:   " + faxServer.Activity + Environment.NewLine + "Configuration:   " + faxServer.Configuration + Environment.NewLine
                             + "CurrentAccount:   " + faxServer.CurrentAccount + Environment.NewLine
                             + "FaxAccountSet:   " + faxServer.FaxAccountSet + Environment.NewLine
                             + "GetDeviceProviders:   " + faxServer.GetDeviceProviders().Count + Environment.NewLine
                             + "GetDevices:   " + faxServer.GetDevices().Count + Environment.NewLine
                             + "LoggingOptions.ActivityLogging:   " + faxServer.LoggingOptions.ActivityLogging + Environment.NewLine
                             + "LoggingOptions.ActivityLogging:   " + faxServer.ServerName + Environment.NewLine
                             + faxServer.Activity.IncomingMessages.ToString() 
                             + " \n" + faxServer.Activity.OutgoingMessages.ToString() 
                             + " \n" + faxServer.Activity.QueuedMessages.ToString() 
                             + " \n" + faxServer.Activity.RoutingMessages.ToString();


            }
            catch (Exception  comException)
            {
                MessageBox.Show("Data: " + comException.Data +"\n" + "HelpLink: " + comException.HelpLink + "\n" + "HResult: " + comException.HResult + "\n" + "InnerException: " + comException.InnerException + "\n" + "Message: " + comException.Message + "\n"+ "Source: " +comException.Source + "\n" + "StackTrace: " + comException.StackTrace + "\n" + "TargetSite: " + comException.TargetSite);
            }
        }
        private void FaxDocumentSetup(string F_Name,string F_Company , string F_text,string Subject , string DocumentName , string faxnumber)
        {
            faxDoc = new FaxDocument();
            faxDoc.Priority = FAX_PRIORITY_TYPE_ENUM.fptHIGH;
            faxDoc.ReceiptType = FAX_RECEIPT_TYPE_ENUM.frtNONE;
            faxDoc.AttachFaxToReceipt = true;

            faxDoc.Sender.Name = F_Name;
            faxDoc.Sender.Company = F_Company;
            faxDoc.Body = F_text;
            faxDoc.Subject = Subject;
            faxDoc.DocumentName = DocumentName;
            faxDoc.Recipients.Add(faxnumber); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            txt_file.Text = op.FileName;
        } 
#region
        //UPLOAD EXCEL FILE 
        private void button2_Click(object sender, EventArgs e)
        {
           // gvwexcel.Columns.Clear();
            Upload_excel();
            Clipboard.Clear();  
        }
        void Upload_excel()
        {
            int cnt_error = 0;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel Files(*.xls;*.xlsx)|*.xls;*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {  
                 
                Cursor.Current = Cursors.WaitCursor; 

                ExcelCOM.Application objExcel = new ExcelCOM.Application();
                ExcelCOM.Workbooks objBooks = objExcel.Workbooks;
                ExcelCOM.Workbook objBook = null;
                ExcelCOM.Worksheet worksheet = null;
                ExcelCOM.Range range = null;
                try
                {
                    objBook = objBooks.Open(dlg.FileName);
                    //worksheet = (ExcelCOM.Worksheet)objBook.Worksheets.get_Item(1);

                    worksheet = objBook.Worksheets[1] as ExcelCOM.Worksheet;

                    //! Todo: Init sheet data.
                    range = worksheet.UsedRange;
                    range.Copy();
                    object[,] data = range.Value;

                    DataTable dt_result = ArraytoDatatable(data);

                    if (dt_result == null)
                    {
                        if (gvwexcel.RowCount > 0)
                        {
                            for (int i = 0; i < gvwexcel.RowCount;)
                            {
                                gvwexcel.Rows.RemoveAt(i);
                            }
                            rtd_log.Text += "Excel file không có data \n";
                        }

                        return;
                    }
                    else
                    {
                        //day du lieu vao
                        gvwexcel.DataSource = dt_result;
                        rtd_log.Text += "Import excel thành công \n";

                    }  
                }
                catch (Exception ex)
                {
                    rtd_log.Text+=ex;
                }
                finally
                {
                     
                    //! Todo: Close and quit application.
                    objBook.Close(false);
                    objExcel.Quit();
                }
            }
        }
        //column excel file
        string colName_TOTAL = "FAXNUMBER;NAME";
        public DataTable ArraytoDatatable(Object[,] numbers)
        {
            DataTable dt = new DataTable();
            dt.Columns.Clear();
             
            // them column
            for (int i = 1; i <= numbers.GetLength(1); i++)
            {
                // trym,To_upper ten cot
                string colName = numbers[1, i].ToString().Trim().ToUpper().Replace(" ", "");
                if (colName_TOTAL.Contains(colName) == false)
                {
                    rtd_log.Text+=DateTime.Now.ToString() + Environment.NewLine + colName + " Tên column trong file excel không đúng format" + Environment.NewLine;

                    return dt = null;
                }
                dt.Columns.Add(colName);
            }
            if (dt.Columns.Count == 0 || dt == null)
            {

            }
            else
            {
                // them dong 
               // dt.Columns.Add("ERROR");
                for (var i = 2; i <= numbers.GetLength(0); i++)
                {
                    DataRow row = dt.NewRow();
                    // trym ten dong
                    for (var j = 1; j <= numbers.GetLength(1); j++)
                    {   
                        row[j - 1] = numbers[i, j].ToString().Trim().ToUpper().Replace(" ", "");
                    }
                    //    row[numbers.GetLength(1) - 1]= "";
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
        #endregion

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                (gvwexcel.DataSource as DataTable).Rows.RemoveAt(gvwexcel.CurrentCell.RowIndex);
                (gvwexcel.DataSource as DataTable).AcceptChanges();
            }
            catch (Exception ex)
            {
                rtd_log.Text += "không có dòng nào được chọn" + Environment.NewLine;
                return;
            }
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Microsoft_Click(object sender, EventArgs e)
        {

            var wordApp = new WORDCOM.Application();
           // var wordAddress= wordApp.AddAddress
            //var work_document = new WORDCOM.Document();
            wordApp.Visible = true;
            object useDefaultValue = Type.Missing;
             wordApp.Documents.Add(ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue);
            wordApp.ActivePrinter = "SHARP MX-2310F FAX";
            FaxDevice dc = new FaxDevice();
           // dc.
           // wordApp.AddAddress("Nguoi dung 1",)
            //wordApp.ActiveDocument.PrintOut(ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue, ref useDefaultValue);
            //wordApp.ActiveDocument.SendFax("0524859018", "Test from");
           // wordApp.ActiveDocument.SendFax("0524859018", "This is fax");
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            
        }
    }
}
