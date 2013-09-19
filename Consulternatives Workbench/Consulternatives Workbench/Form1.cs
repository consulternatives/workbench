using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consulternatives_Workbench
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
     
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.GoBack();
                
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.GoForward();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbbrowser.GoHome();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Refresh();
        }

        private void googleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://voice.google.com");
        }

        private void gMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://mail.google.com");
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://webmail.consulternatives.com");
        }

        private void newMediaPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://consulternatives.com/media/wp-admin/post-new.php");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("outlook.exe");
        }

        private void eclipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files (x86)/eclipse/eclipse.exe");
        }

        private void wireframeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files (x86)/Evolus/Pencil/pencil.exe");
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void surfbtn_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate(searchBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dreamweaverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files (x86)/Adobe/Adobe Dreamweaver CS6/Dreamweaver.exe");
        }

        private void softwareResearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.alternativeto.net");
        }

        private void trendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.yourversion.com");
        }

        private void mediaAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/media/wp-admin");
        }

        private void vPSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://204.17.41.34/whm");
        }

        private void siteAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/site/administrator");
        }

        private void wbbrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.twitter.com/login");
        }

        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.linkedin.com/company/433435?goback=.npv_25125167_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1_*1&trk=prof-exp-company-name");

        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wbbrowser.Navigate(searchBox.Text);
            }
            }

        private void consulternativesLLCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com");
        }

        private void siteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.cliffkelly.com");
        }

        private void siteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.thefinancialindependenceproject.com");
        }

        private void siteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.vitamindistributorship.com");
        }

        private void siteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.jutingates.com");
        }

        private void uploadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("https://www.consulternatives.com:2083/cpsess4694836773/frontend/x3/filemanager/index.html?dirselect=domainrootselect&domainselect=consulternatives.com&dir=&saveoption=1");
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/workbench/code/ConsulternativesWorkbench.zip");
        }

        private void googleAnalyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://analytics.google.com");
        }

        private void oneNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("onenote");
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:");
        }

        private void companyDocsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/docs");
        }

        private void anyMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.anymeeting.com");
        }

        private void elanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.elance.com");
        }

        private void sSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/putty.exe");
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://208.80.3.10/whm");
        }

        private void siteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/joomla/administrator");
        }

        private void mediaServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/media/wp-admin");
        }

        private void analyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://analytics.google.com");
        }

        private void industryTrendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.yourversion.com");
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.cliffkelly.com/site/administrator");
        }

        private void cPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.clliffkelly.com/cpanel");
        }

        private void adminToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.thefinancialindependenceproject.com/administrator");
        }

        private void cPanelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.thefinancialindependenceproject.com/cpanel");
        }

        private void nationalHomeBuyerClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liveSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.nationalhomebuyerclass.com");
        }

        private void adminToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.nationalhomebuyerclass.com/wp-admin");
        }

        private void cPanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.nationalhomebuyerclass.com/cpanel");
        }

        private void liveSiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.intern-nationa.com");
        }

        private void adminToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.intern-nationa.com/wp-admin");
        }

        private void devSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.intern-nationa.com/dev");
        }

        private void adminToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.intern-nationa.com/dev/wp-admin");
        }

        private void cPanelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.intern-nationa.com/cpanel");
        }

        private void oneNotePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("onenote");
        }

        private void meetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.anymeeting.com");
        }

        private void nDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/docs/corp/nda.doc");
        }

        private void proposalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/docs/corp/proposal.doc");
        }

        private void requirementsDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/docs/corp/reqdoc.doc");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad");
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.google.com/keep");
        }

        private void cPanelToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.kelowna-forclosure.com/cpanel");
        }

        private void localVoicesnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void cPanelToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.local-voices.net/cpanel");
        }

        private void wPProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.local-voices.net/wp-admin");
        }

        private void wPDevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.local-voices.net/dev/wp-admin");
        }

        private void supportCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://consulternatives.com/support/scp/admin.php");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cPanelToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.nationalhomebuyerclass.com");
        }

        private void kelownaForeclosurescaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wPProdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.nationalhomebuyerclass.com/wp-admin");
        }

        private void cPanelToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.nationalhomebuyerclass.com/cpanel");
        }

        private void courseDevelopmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void courseMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://sotd.us/justingates/nm260");
        }

        private void newsPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://consulternatives.com/media/wp-admin/post-new.php");
        }

        private void liveSiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.justingates.com");
        }

        private void adminToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.justingates.com/web/wp-admin");
        }

        private void cPanelToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.justingates.com/cpanel");
        }

        private void mD5CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("http://www.consulternatives.com/MD5/WinMD5.exe");
        }

        private void databaseMgmtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbbrowser.Navigate("https://www.consulternatives.com:2083/cpsess1427245625/frontend/x3/sql/PhpMyAdmin.html");
        }

    }
}
