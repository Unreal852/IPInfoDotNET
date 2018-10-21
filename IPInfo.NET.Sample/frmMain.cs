using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;

namespace IPInfo.NET.Sample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            cmbFields.Items.Add("All");
            foreach (IPInfoKey key in Enum.GetValues(typeof(IPInfoKey)))
                cmbFields.Items.Add(key);
            cmbFields.SelectedIndex = 0;

            btnRequest.Click += BtnRequest_Click;
        }

        private async void BtnRequest_Click(object sender, EventArgs e)
        {
            treeResult.Nodes.Clear();
            SetControlsState(false);
            IPResult result = null;
            if (ckAsync.Checked)
            {
                if (cmbFields.SelectedIndex != 0)
                {
                    string txt = await IPInfo.GetAsync((IPInfoKey)cmbFields.SelectedItem, GetValidIP(), txtToken.Text);
                    MessageBox.Show(txt);
                    SetControlsState(true);
                    return;
                }
                result = await IPInfo.GetAsync(GetValidIP(), txtToken.Text);
                result.DownloadLocalisationMap();
            }
            else
            {
                if (cmbFields.SelectedIndex != 0)
                {
                    MessageBox.Show(IPInfo.Get((IPInfoKey)cmbFields.SelectedItem, GetValidIP(), txtToken.Text));
                    SetControlsState(true);
                    return;
                }
                result = IPInfo.Get(GetValidIP(), txtToken.Text);
            }
            PopulateTree(result);
        }

        private void PopulateTree(IPResult result)
        {
            TreeNode mainNode = new TreeNode("IP Informations");

            // This reflection is done to speed up dev time, it's not recommended to use this in a prod app
            foreach (PropertyInfo p in result.GetType().GetProperties())
            {
                if (p.PropertyType == typeof(string))
                    mainNode.Nodes.Add(new TreeNode($"{p.Name}: {p.GetValue(result)}"));
                else if (p.GetValue(result) != null)
                {
                    TreeNode secondNode = new TreeNode(p.Name);
                    foreach (PropertyInfo pp in p.PropertyType.GetProperties())
                    {
                        if (pp.PropertyType == typeof(string))
                            secondNode.Nodes.Add(new TreeNode($"{pp.Name}: {pp.GetValue(p.GetValue(result))}"));
                    }
                    mainNode.Nodes.Add(secondNode);
                }
            }

            treeResult.Nodes.Add(mainNode);

            SetControlsState(true);
        }

        /// <summary>
        /// Simply checks if the specified IP is a valid one
        /// </summary>
        /// <returns><see cref="string"/> IP if the specified IP is valid, <see cref="null"/> otherwise</returns>
        private string GetValidIP()
        {
            if (txtIP.Text.Contains(".") || txtIP.Text.Contains(":"))
            {
                IPAddress address;
                if (IPAddress.TryParse(txtIP.Text, out address))
                {
                    switch (address.AddressFamily)
                    {
                        case AddressFamily.InterNetwork:
                            return txtIP.Text;
                        case AddressFamily.InterNetworkV6:
                            return txtIP.Text;
                        default:
                            return null;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Set controls panel state
        /// </summary>
        /// <param name="value">Enabled state</param>
        private void SetControlsState(bool value)
        {
            if(value)
            {
                pnlControls.Enabled = true;
                pbRequesting.Style = ProgressBarStyle.Blocks;
            }
            else
            {
                pnlControls.Enabled = false;
                pbRequesting.Style = ProgressBarStyle.Marquee;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
