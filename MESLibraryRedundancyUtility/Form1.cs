using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MES.Library.Client;
using System.Diagnostics;

namespace MESLibraryRedundancyUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_primServiceURL.Text = @"http://PHTANL0021/MESLibraryV31/";
            txt_secServiceURL.Text = @"http://PHTANL0021/MESLibraryV31/";
            txt_ServiceName.Text = @"WCFService.svc";
            txt_dllVersion.Text = "3.1.0";
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Request request = new Request();
            Request.PrimaryServiceURL = txt_primServiceURL.Text;
            Request.SecondaryServiceURL = txt_secServiceURL.Text;
            Request.PrimaryServiceDisabled = chkb_primServiceDisabled.Checked;
            Request.SecondaryServiceDisabled = chkb_secServiceDisabled.Checked;

            request.Init(txt_dllVersion.Text, 0, "nestec");
            request.ObjectName = "MESLibraryTestUtility";
            request.AddParameter("sscc", "");
            request.ExecuteById("GeneralManager_ValidateSSCCNumber");
            if (request.ReturnCode == 0)
            {
                LogLine("SUCCESS: " + request.ReturnMessage);
                LogLine(MES.Library.Client.SQLCommand.GetConnectionString("MES"));
                btn_init.BackColor = Color.Green;
            }
            else
            {
                LogLine("ERROR:" + request.ReturnCode + " ReturnMessage:" + request.ReturnMessage + " ReturnErrorDetail:" + request.ReturnErrorDetail);
                btn_init.BackColor = Color.Red;
            }

            sw.Stop();
            LogLine(String.Format("TIME - {0}msec", sw.ElapsedMilliseconds));

        }



        private void LogLine(String message)
        {
            txt_debug.Text += message + Environment.NewLine;
        }

        private void btn_getEntNameByID_Click(object sender, EventArgs e)
        {

            Request request = new Request();
            request.Init(txt_dllVersion.Text, 0, "nestec");
            request.ObjectName = "MESLibraryTestUtility";
            request.AddParameter("entId", 1);
            request.ExecuteById("EntityManager_GetEntityNameById");

            if (request.ReturnCode == 0)
            {
                LogLine("SUCCESS - " + request.ReturnValueAsString);
            }
            else
            {
                LogLine("ERROR:" + request.ReturnCode + " Return Message:" + request.ReturnMessage + " Return Error Detail:" + request.ReturnErrorDetail);

            }

        }

        private void btn_getActiveServiceURL_Click(object sender, EventArgs e)
        {
            LogLine(Request.ActiveServiceURL);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txt_debug.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String mes = MES.Library.Client.SQLCommand.GetConnectionString("MES");
                txt_debug.Text +=  mes + Environment.NewLine;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }
    }
}
