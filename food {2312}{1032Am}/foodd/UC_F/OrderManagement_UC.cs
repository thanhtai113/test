using System;
using System.Collections.Generic;
using System.ComponentModel;
using Model;
using BusinessLayer;
using foodd.Forms_F;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace foodd.UC_F
{
    public partial class OrderManagement_UC : UserControl
    {
        bool isSave=false;
        public OrderManagement_UC()
        {
            InitializeComponent();
            progressBar.Visible = false;
            labelStatus.Visible = false;

        }

        private void btnRefTempt_Click(object sender, EventArgs e)
        {
            cusOrdersBindingSource.DataSource = CusOrderBUS.GetAll();
            labelTotal.Text = CusOrderBUS.TotalCost().ToString() + "$";
        }

        private void btnClearTempt_Click(object sender, EventArgs e)
        {
            if (isSave == true)
            {
                CusOrderBUS.clearAll();
                cusOrdersBindingSource.DataSource = CusOrderBUS.GetAll();
                isSave = false;
                labelTotal.Text = "0$";
            }
            else
            {
                MessageBox.Show("You must save before clear!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OrderHistoryBUS.insert();
            orderHistorysBindingSource.DataSource = OrderHistoryBUS.GetAll();
            isSave = true;
        }

        private void btnClearHis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to clear history ?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)            
            {
                OrderHistoryBUS.clearAll();
                orderHistorysBindingSource.DataSource = OrderHistoryBUS.GetAll();
            }
        }
        struct DataParameter
        {
            public List<OrderHistorys> hisList;
            public string FileName { get; set; }
        }
        DataParameter input;
        private void btnExport_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            labelStatus.Visible = true; ;
            orderHistorysBindingSource.DataSource = OrderHistoryBUS.GetAll();
            if (backgroundWorker.IsBusy)
                return; 
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "*.xls|*.xls"})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    input.FileName = sfd.FileName;
                    input.hisList = OrderHistoryBUS.GetAll();
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync(input);
                }
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<OrderHistorys> listHis = ((DataParameter)e.Argument).hisList;
            string filename = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = listHis.Count;
            ws.Cells[1, 1] = "Name";
            ws.Cells[1, 2] = "Price";
            ws.Cells[1, 3] = "Quantity";
            ws.Cells[1, 4] = "Order date";
            foreach(OrderHistorys od in listHis)
            {
                if(!backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = od.name.ToString();
                    ws.Cells[index, 2] = od.price.ToString();
                    ws.Cells[index, 3] = od.numberDish.ToString();
                    ws.Cells[index, 4] = od.dateOrder.ToString();
                }
            }
            ws.SaveAs(filename, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            excel.Quit();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            labelStatus.Text = string.Format("Processing...{0}", e.ProgressPercentage);
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelStatus.Text = "Complete export!";            
            progressBar.Visible = false;
            labelStatus.Visible = false;
        }

        private void btnRefHis_Click(object sender, EventArgs e)
        {
            orderHistorysBindingSource.DataSource = OrderHistoryBUS.GetAll();
        }

        private void timerReload_Tick(object sender, EventArgs e)
        {
            cusOrdersBindingSource.DataSource = CusOrderBUS.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            od.Show();
            if(isSave==true)
            {
                CusOrderBUS.clearAll();
                isSave = false;
            }
            
        }
    }
}
