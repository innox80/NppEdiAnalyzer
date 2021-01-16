using System;
using System.Windows.Forms;
using Kbg.NppPluginNET.PluginInfrastructure;

using System.Data;
using System.Data.SQLite;
using System.IO;
using System;
using System.Text.Json;


namespace Kbg.Demo.Namespace
{
    partial class frmGoToLine : Form
    {
        private readonly IScintillaGateway editor;

        public frmGoToLine(IScintillaGateway editor)
        {
            this.editor = editor;
            InitializeComponent();
            //this.myEDIAnalizer.setEDIAnalizer(editor);
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int line;
            if (!int.TryParse(textBox1.Text, out line))
                return;
            editor.EnsureVisible(line - 1);
            editor.GotoLine(line - 1);
            editor.GrabFocus();
        }
        */

        /*
        private void frmGoToLine_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Return) || (e.Alt && (e.KeyCode == Keys.G)))
            {
                button1.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Escape)
            {
                editor.GrabFocus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                Control next = GetNextControl((Control)sender, !e.Shift);
                while ((next == null) || (!next.TabStop)) next = GetNextControl(next, !e.Shift);
                next.Focus();
                e.Handled = true;
            }
        }
        */

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && (e.KeyChar != '\b')
                && (e.KeyChar != '\t')) 
                e.Handled = true;
        }
        
        void FrmGoToLineVisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint) NppMsg.NPPM_SETMENUITEMCHECK,
                                  PluginBase._funcItems.Items[Main.idFrmGotToLine]._cmdID, 0);
            }
        }

        /*
        private void button2_Click(object sender, EventArgs e)
        {

            //Util.FindNext(textBox2.Text,editor);
            //Util.ReplaceNext(textBox2.Text, textBox3.Text, editor);
            Util.ReplaceAll(textBox2.Text, textBox3.Text, editor);

        }
        */

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            Util.ReplaceAll("'", "'\r\n", editor);
        }

        private void btnUnFormat_Click(object sender, EventArgs e)
        {
            Util.ReplaceAll("'\r\n", "'", editor);
            Util.ReplaceAll("'\n", "'", editor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int intLineCount = editor.GetLineCount();
            int intLineNumb = 0;
            System.Diagnostics.Debug.WriteLine(intLineCount.ToString());
            string myString = "";

            while (intLineNumb < intLineCount)
            {
                myString = editor.GetLine(intLineNumb);
                System.Diagnostics.Debug.WriteLine(myString);
                intLineNumb = intLineNumb + 1;
                System.Diagnostics.Debug.WriteLine(intLineNumb.ToString());
            }    


        }

        /*
        private void button4_Click(object sender, EventArgs e)
        {
            //
            // This is the first node in the view.
            //
            TreeNode treeNode = new TreeNode("Windows");
            treeView1.Nodes.Add(treeNode);
            //
            // Another node following the first node.
            //
            treeNode = new TreeNode("Linux");
            treeView1.Nodes.Add(treeNode);
            //
            // Create two child nodes and put them in an array.
            // ... Add the third node, and specify these as its children.
            //
            TreeNode node2 = new TreeNode("C#");
            TreeNode node3 = new TreeNode("VB.NET");
            TreeNode[] array = new TreeNode[] { node2, node3 };
            //
            // Final node.
            //
            treeNode = new TreeNode("Dot Net Perls", array);
            treeView1.Nodes.Add(treeNode);
        }
        */

        /*
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //
            // Get the selected node.
            //
            TreeNode node = treeView1.SelectedNode;
            //
            // Render message box.
            //
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }
        */

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string xmlFileName = Path.Combine(assemblyFolder,"AggregatorItems.xml");

            string curAssemblyFolder = new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
             */

            string curAssemblyFolder = new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            MessageBox.Show(string.Format("DLL path is: {0}", curAssemblyFolder));


        }

        public void displaySegmentOnListview()
        {
            listView1.Clear();
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Refresh();
            //listView1.DataBindings();



            ColumnHeader header1 = listView1.Columns.Add("Element", 20 * (int)listView1.Font.SizeInPoints, HorizontalAlignment.Left);
            ColumnHeader header2 = listView1.Columns.Add("Component", 20 * (int)listView1.Font.SizeInPoints, HorizontalAlignment.Left);
            ColumnHeader header3 = listView1.Columns.Add("Value", 20 * (int)listView1.Font.SizeInPoints, HorizontalAlignment.Left);

            // create the subitems to add to the list   
            /*
            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("2");

            // insert all the items into the listview at the last available row  
            listView1.Items.Add(item1);
            */

            foreach (SegmentStructure mySegment in Main.SegmentList)
            {
                foreach (ElementStructure myElement in mySegment.ElementsList)
                {
                    ListViewItem item1 = new ListViewItem(myElement.sDescription, 0);
                    item1.SubItems.Add("");
                    item1.SubItems.Add(myElement.sValue);
                    listView1.Items.Add(item1);

                    foreach (ComponentStructure myComponent in myElement.ComponentList)
                    {
                        ListViewItem item2 = new ListViewItem("", 0);
                        item2.SubItems.Add(myComponent.sDescription);
                        item2.SubItems.Add(myComponent.sValue);
                        listView1.Items.Add(item2);
                    }

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displaySegmentOnListview();
        }

        private void frmGoToLine_Load(object sender, EventArgs e)
        {

        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteConnection db = new SQLiteConnection(@"Data Source=C:\code\NotepadPlusPlusPluginPack\EDIFACT.db;Pooling=true;FailIfMissing=false;Version=3");

                db.Open();

                var selectCommand = new SQLiteCommand
                    ("select rowid,* from test", db);

                SQLiteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    //Console.WriteLine(query.GetInt32(0) + "  " + query.GetString(1));
                    MessageBox.Show(query.GetInt32(0) + "  " + query.GetString(1) + "  " + query.GetString(2));
                }

                db.Close();


            }
            catch (Exception Myerr)
            {
                // Something unexpected went wrong.
                System.Diagnostics.Debug.WriteLine(Myerr.Message);
                // Maybe it is also necessary to terminate / restart the application.
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader(@"C:\code\edifact_D95B\D95B\RSSBus_D95B.json"))
            {
                string Myjson = r.ReadToEnd();
                JsonDocument doc = JsonDocument.Parse(Myjson);
                JsonElement root = doc.RootElement;

                Console.WriteLine(root);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Main.EDIAnalizeSelectedLine();
        }


        /*
private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
{
//
// Get the selected node.
//
TreeNode node = treeView1.SelectedNode;
//
// Render message box.
//
MessageBox.Show(string.Format("You selected: {0}", node.Text));
}
*/

    }
}
