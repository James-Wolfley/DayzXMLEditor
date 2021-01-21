using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DayzXMLEditor
{
    public partial class Form1 : Form
    {

        public XmlDocument xmlDocument;

        public Form1()
        {
            InitializeComponent();
        }

        private class ListItem
        {
            public string Name { get; set; }
            public XmlNode Node { get; set; }
            public ListItem(string name, XmlNode node)
            {
                Name = name;
                Node = node;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void FilterXML_Click(object sender, EventArgs e)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = true;
            if (!System.IO.File.Exists(FilePathTextBox.Text))
            {
                ErrorLabel.Text = "Select a file first";
                return;
            }

            xmlDocument.Load(FilePathTextBox.Text);



            var nodes = xmlDocument.GetElementsByTagName("type");

            string filterString = FilterStringTextbox.Text;
            ListOfXMLObjects.Items.Clear();
            for (int i = 0; i < nodes.Count; i++)
            {
                XmlNode node = nodes[i];
                string name = node.Attributes["name"].Value;
                if (name.Contains(filterString))
                {
                    var item = ListOfXMLObjects.Items.Add(new ListItem(name, node));
                }
            }

        }

        private void OpenFileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Browse xml Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void ChangeAllValues_Click(object sender, EventArgs e)
        {
            int nominalValue = int.Parse(NominalValueTextbox.Text);
            int lifetime = int.Parse(lifetimeTextBox.Text);
            int restock = int.Parse(restockTextBox.Text);
            int minValue = int.Parse(MinValueTextbox.Text);
            int quantMin = int.Parse(quantMinTextBox.Text);
            int quantMax = int.Parse(quantMaxTextBox.Text);
            int cost = int.Parse(costTextBox.Text);



            if (nominalValue < 0 || minValue < 0 || restock < 0 || lifetime < 0 || quantMin < -1 || quantMax < -1 || cost < 0)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name) {
                        case "nominal":
                            node.InnerText = nominalValue.ToString();
                            break;
                        case "min":
                            node.InnerText = minValue.ToString();
                            break;
                        case "lifetime":
                            node.InnerText = lifetime.ToString();
                            break;
                        case "restock":
                            node.InnerText = restock.ToString();
                            break;
                        case "quantmin":
                            node.InnerText = quantMin.ToString();
                            break;
                        case "quantmax":
                            node.InnerText = quantMax.ToString();
                            break;
                        case "cost":
                            node.InnerText = cost.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);

        }

        private void costButton_Click(object sender, EventArgs e)
        {
            int cost = int.Parse(costTextBox.Text);



            if (cost < 0)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "cost":
                            node.InnerText = cost.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);
        }

        private void QuantMaxButton_Click(object sender, EventArgs e)
        {
            int quantMax = int.Parse(quantMaxTextBox.Text);



            if (quantMax < -1)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "quantmax":
                            node.InnerText = quantMax.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);
        }

        private void QuantMinButton_Click(object sender, EventArgs e)
        {
            int quantMin = int.Parse(quantMinTextBox.Text);



            if (quantMin < -1)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "quantmin":
                            node.InnerText = quantMin.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);
        }

        private void MinValueButton_Click(object sender, EventArgs e)
        {
            int minValue = int.Parse(MinValueTextbox.Text);



            if (minValue < 0)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "min":
                            node.InnerText = minValue.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);
        }

        private void RestockButton_Click(object sender, EventArgs e)
        {
            int restock = int.Parse(restockTextBox.Text);



            if (restock < 0)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "restock":
                            node.InnerText = restock.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);
        }

        private void LifetimeButton_Click(object sender, EventArgs e)
        {
            int lifetime = int.Parse(lifetimeTextBox.Text);



            if (lifetime < 0)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "lifetime":
                            node.InnerText = lifetime.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);
        }

        private void NominalValueButton_Click(object sender, EventArgs e)
        {
            int nominalValue = int.Parse(NominalValueTextbox.Text);



            if (nominalValue < 0)
            {
                ErrorLabel.Text = "Values cannot be lower then 0";
                return;
            }

            for (int i = 0; i < ListOfXMLObjects.Items.Count; i++)
            {
                ListItem item = (ListItem)ListOfXMLObjects.Items[i];
                foreach (XmlNode node in item.Node.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "nominal":
                            node.InnerText = nominalValue.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(FilePathTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
