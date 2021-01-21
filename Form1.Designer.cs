
namespace DayzXMLEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangeAllValuesButton = new System.Windows.Forms.Button();
            this.MinValueTextbox = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.NominalLabel = new System.Windows.Forms.Label();
            this.NominalValueTextbox = new System.Windows.Forms.TextBox();
            this.FilterStringLabel = new System.Windows.Forms.Label();
            this.FilterStringTextbox = new System.Windows.Forms.TextBox();
            this.FilterXML = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileBrowser = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ListOfXMLObjects = new System.Windows.Forms.ListBox();
            this.quantMinLabel = new System.Windows.Forms.Label();
            this.quantMinTextBox = new System.Windows.Forms.TextBox();
            this.restockLabel = new System.Windows.Forms.Label();
            this.restockTextBox = new System.Windows.Forms.TextBox();
            this.LifetimeLabel = new System.Windows.Forms.Label();
            this.lifetimeTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.quantMaxLabel = new System.Windows.Forms.Label();
            this.quantMaxTextBox = new System.Windows.Forms.TextBox();
            this.NominalValueButton = new System.Windows.Forms.Button();
            this.LifetimeButton = new System.Windows.Forms.Button();
            this.RestockButton = new System.Windows.Forms.Button();
            this.MinValueButton = new System.Windows.Forms.Button();
            this.QuantMinButton = new System.Windows.Forms.Button();
            this.QuantMaxButton = new System.Windows.Forms.Button();
            this.costButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeAllValuesButton
            // 
            this.ChangeAllValuesButton.Location = new System.Drawing.Point(455, 691);
            this.ChangeAllValuesButton.Name = "ChangeAllValuesButton";
            this.ChangeAllValuesButton.Size = new System.Drawing.Size(225, 23);
            this.ChangeAllValuesButton.TabIndex = 0;
            this.ChangeAllValuesButton.Text = "Change All Values";
            this.ChangeAllValuesButton.UseVisualStyleBackColor = true;
            this.ChangeAllValuesButton.Click += new System.EventHandler(this.ChangeAllValues_Click);
            // 
            // MinValueTextbox
            // 
            this.MinValueTextbox.Location = new System.Drawing.Point(454, 539);
            this.MinValueTextbox.Name = "MinValueTextbox";
            this.MinValueTextbox.Size = new System.Drawing.Size(224, 20);
            this.MinValueTextbox.TabIndex = 2;
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(454, 520);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(54, 13);
            this.MinLabel.TabIndex = 4;
            this.MinLabel.Text = "Min Value";
            // 
            // NominalLabel
            // 
            this.NominalLabel.AutoSize = true;
            this.NominalLabel.Location = new System.Drawing.Point(454, 394);
            this.NominalLabel.Name = "NominalLabel";
            this.NominalLabel.Size = new System.Drawing.Size(75, 13);
            this.NominalLabel.TabIndex = 6;
            this.NominalLabel.Text = "Nominal Value";
            // 
            // NominalValueTextbox
            // 
            this.NominalValueTextbox.Location = new System.Drawing.Point(454, 413);
            this.NominalValueTextbox.Name = "NominalValueTextbox";
            this.NominalValueTextbox.Size = new System.Drawing.Size(224, 20);
            this.NominalValueTextbox.TabIndex = 5;
            // 
            // FilterStringLabel
            // 
            this.FilterStringLabel.AutoSize = true;
            this.FilterStringLabel.Location = new System.Drawing.Point(460, 65);
            this.FilterStringLabel.Name = "FilterStringLabel";
            this.FilterStringLabel.Size = new System.Drawing.Size(59, 13);
            this.FilterStringLabel.TabIndex = 8;
            this.FilterStringLabel.Text = "Filter String";
            // 
            // FilterStringTextbox
            // 
            this.FilterStringTextbox.Location = new System.Drawing.Point(460, 84);
            this.FilterStringTextbox.Name = "FilterStringTextbox";
            this.FilterStringTextbox.Size = new System.Drawing.Size(224, 20);
            this.FilterStringTextbox.TabIndex = 7;
            // 
            // FilterXML
            // 
            this.FilterXML.Location = new System.Drawing.Point(460, 110);
            this.FilterXML.Name = "FilterXML";
            this.FilterXML.Size = new System.Drawing.Size(225, 23);
            this.FilterXML.TabIndex = 9;
            this.FilterXML.Text = "Filter XML";
            this.FilterXML.UseVisualStyleBackColor = true;
            this.FilterXML.Click += new System.EventHandler(this.FilterXML_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(459, 13);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(221, 20);
            this.FilePathTextBox.TabIndex = 10;
            // 
            // OpenFileBrowser
            // 
            this.OpenFileBrowser.Location = new System.Drawing.Point(459, 39);
            this.OpenFileBrowser.Name = "OpenFileBrowser";
            this.OpenFileBrowser.Size = new System.Drawing.Size(225, 23);
            this.OpenFileBrowser.TabIndex = 11;
            this.OpenFileBrowser.Text = "Choose XML File";
            this.OpenFileBrowser.UseVisualStyleBackColor = true;
            this.OpenFileBrowser.Click += new System.EventHandler(this.OpenFileBrowser_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(459, 12);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 12;
            // 
            // ListOfXMLObjects
            // 
            this.ListOfXMLObjects.FormattingEnabled = true;
            this.ListOfXMLObjects.Location = new System.Drawing.Point(13, 13);
            this.ListOfXMLObjects.Name = "ListOfXMLObjects";
            this.ListOfXMLObjects.Size = new System.Drawing.Size(435, 706);
            this.ListOfXMLObjects.TabIndex = 13;
            // 
            // quantMinLabel
            // 
            this.quantMinLabel.AutoSize = true;
            this.quantMinLabel.Location = new System.Drawing.Point(454, 562);
            this.quantMinLabel.Name = "quantMinLabel";
            this.quantMinLabel.Size = new System.Drawing.Size(53, 13);
            this.quantMinLabel.TabIndex = 15;
            this.quantMinLabel.Text = "QuantMin";
            // 
            // quantMinTextBox
            // 
            this.quantMinTextBox.Location = new System.Drawing.Point(454, 581);
            this.quantMinTextBox.Name = "quantMinTextBox";
            this.quantMinTextBox.Size = new System.Drawing.Size(224, 20);
            this.quantMinTextBox.TabIndex = 14;
            // 
            // restockLabel
            // 
            this.restockLabel.AutoSize = true;
            this.restockLabel.Location = new System.Drawing.Point(454, 478);
            this.restockLabel.Name = "restockLabel";
            this.restockLabel.Size = new System.Drawing.Size(47, 13);
            this.restockLabel.TabIndex = 17;
            this.restockLabel.Text = "Restock";
            // 
            // restockTextBox
            // 
            this.restockTextBox.Location = new System.Drawing.Point(454, 497);
            this.restockTextBox.Name = "restockTextBox";
            this.restockTextBox.Size = new System.Drawing.Size(224, 20);
            this.restockTextBox.TabIndex = 16;
            // 
            // LifetimeLabel
            // 
            this.LifetimeLabel.AutoSize = true;
            this.LifetimeLabel.Location = new System.Drawing.Point(454, 436);
            this.LifetimeLabel.Name = "LifetimeLabel";
            this.LifetimeLabel.Size = new System.Drawing.Size(43, 13);
            this.LifetimeLabel.TabIndex = 19;
            this.LifetimeLabel.Text = "Lifetime";
            // 
            // lifetimeTextBox
            // 
            this.lifetimeTextBox.Location = new System.Drawing.Point(454, 455);
            this.lifetimeTextBox.Name = "lifetimeTextBox";
            this.lifetimeTextBox.Size = new System.Drawing.Size(224, 20);
            this.lifetimeTextBox.TabIndex = 18;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(454, 646);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 21;
            this.costLabel.Text = "Cost";
            // 
            // costTextBox
            // 
            this.costTextBox.AcceptsReturn = true;
            this.costTextBox.Location = new System.Drawing.Point(454, 665);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(224, 20);
            this.costTextBox.TabIndex = 20;
            // 
            // quantMaxLabel
            // 
            this.quantMaxLabel.AutoSize = true;
            this.quantMaxLabel.Location = new System.Drawing.Point(454, 604);
            this.quantMaxLabel.Name = "quantMaxLabel";
            this.quantMaxLabel.Size = new System.Drawing.Size(56, 13);
            this.quantMaxLabel.TabIndex = 23;
            this.quantMaxLabel.Text = "QuantMax";
            // 
            // quantMaxTextBox
            // 
            this.quantMaxTextBox.Location = new System.Drawing.Point(454, 623);
            this.quantMaxTextBox.Name = "quantMaxTextBox";
            this.quantMaxTextBox.Size = new System.Drawing.Size(224, 20);
            this.quantMaxTextBox.TabIndex = 22;
            // 
            // NominalValueButton
            // 
            this.NominalValueButton.Location = new System.Drawing.Point(685, 413);
            this.NominalValueButton.Name = "NominalValueButton";
            this.NominalValueButton.Size = new System.Drawing.Size(134, 20);
            this.NominalValueButton.TabIndex = 24;
            this.NominalValueButton.Text = "Change Nominal Value";
            this.NominalValueButton.UseVisualStyleBackColor = true;
            this.NominalValueButton.Click += new System.EventHandler(this.NominalValueButton_Click);
            // 
            // LifetimeButton
            // 
            this.LifetimeButton.Location = new System.Drawing.Point(685, 455);
            this.LifetimeButton.Name = "LifetimeButton";
            this.LifetimeButton.Size = new System.Drawing.Size(134, 20);
            this.LifetimeButton.TabIndex = 25;
            this.LifetimeButton.Text = "Change Lifetime";
            this.LifetimeButton.UseVisualStyleBackColor = true;
            this.LifetimeButton.Click += new System.EventHandler(this.LifetimeButton_Click);
            // 
            // RestockButton
            // 
            this.RestockButton.Location = new System.Drawing.Point(684, 497);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(134, 20);
            this.RestockButton.TabIndex = 26;
            this.RestockButton.Text = "Change Restock";
            this.RestockButton.UseVisualStyleBackColor = true;
            this.RestockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // MinValueButton
            // 
            this.MinValueButton.Location = new System.Drawing.Point(685, 539);
            this.MinValueButton.Name = "MinValueButton";
            this.MinValueButton.Size = new System.Drawing.Size(134, 20);
            this.MinValueButton.TabIndex = 27;
            this.MinValueButton.Text = "Change Min Value";
            this.MinValueButton.UseVisualStyleBackColor = true;
            this.MinValueButton.Click += new System.EventHandler(this.MinValueButton_Click);
            // 
            // QuantMinButton
            // 
            this.QuantMinButton.Location = new System.Drawing.Point(684, 581);
            this.QuantMinButton.Name = "QuantMinButton";
            this.QuantMinButton.Size = new System.Drawing.Size(134, 20);
            this.QuantMinButton.TabIndex = 28;
            this.QuantMinButton.Text = "Change QuantMin";
            this.QuantMinButton.UseVisualStyleBackColor = true;
            this.QuantMinButton.Click += new System.EventHandler(this.QuantMinButton_Click);
            // 
            // QuantMaxButton
            // 
            this.QuantMaxButton.Location = new System.Drawing.Point(684, 623);
            this.QuantMaxButton.Name = "QuantMaxButton";
            this.QuantMaxButton.Size = new System.Drawing.Size(134, 20);
            this.QuantMaxButton.TabIndex = 29;
            this.QuantMaxButton.Text = "Change QuantMax";
            this.QuantMaxButton.UseVisualStyleBackColor = true;
            this.QuantMaxButton.Click += new System.EventHandler(this.QuantMaxButton_Click);
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(684, 665);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(134, 20);
            this.costButton.TabIndex = 30;
            this.costButton.Text = "Change Cost";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 737);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.QuantMaxButton);
            this.Controls.Add(this.QuantMinButton);
            this.Controls.Add(this.MinValueButton);
            this.Controls.Add(this.RestockButton);
            this.Controls.Add(this.LifetimeButton);
            this.Controls.Add(this.NominalValueButton);
            this.Controls.Add(this.quantMaxLabel);
            this.Controls.Add(this.quantMaxTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.LifetimeLabel);
            this.Controls.Add(this.lifetimeTextBox);
            this.Controls.Add(this.restockLabel);
            this.Controls.Add(this.restockTextBox);
            this.Controls.Add(this.quantMinLabel);
            this.Controls.Add(this.quantMinTextBox);
            this.Controls.Add(this.ListOfXMLObjects);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.OpenFileBrowser);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FilterXML);
            this.Controls.Add(this.FilterStringLabel);
            this.Controls.Add(this.FilterStringTextbox);
            this.Controls.Add(this.NominalLabel);
            this.Controls.Add(this.NominalValueTextbox);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MinValueTextbox);
            this.Controls.Add(this.ChangeAllValuesButton);
            this.Name = "Form1";
            this.Text = "ItemsXML Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeAllValuesButton;
        private System.Windows.Forms.TextBox MinValueTextbox;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label NominalLabel;
        private System.Windows.Forms.TextBox NominalValueTextbox;
        private System.Windows.Forms.Label FilterStringLabel;
        private System.Windows.Forms.TextBox FilterStringTextbox;
        private System.Windows.Forms.Button FilterXML;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button OpenFileBrowser;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ListBox ListOfXMLObjects;
        private System.Windows.Forms.Label quantMinLabel;
        private System.Windows.Forms.TextBox quantMinTextBox;
        private System.Windows.Forms.Label restockLabel;
        private System.Windows.Forms.TextBox restockTextBox;
        private System.Windows.Forms.Label LifetimeLabel;
        private System.Windows.Forms.TextBox lifetimeTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label quantMaxLabel;
        private System.Windows.Forms.TextBox quantMaxTextBox;
        private System.Windows.Forms.Button NominalValueButton;
        private System.Windows.Forms.Button LifetimeButton;
        private System.Windows.Forms.Button RestockButton;
        private System.Windows.Forms.Button MinValueButton;
        private System.Windows.Forms.Button QuantMinButton;
        private System.Windows.Forms.Button QuantMaxButton;
        private System.Windows.Forms.Button costButton;
    }
}

