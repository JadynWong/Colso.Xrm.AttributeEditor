﻿namespace Colso.Xrm.AttributeEditor
{
    partial class AttributeEditor
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttributeEditor));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadEntities = new System.Windows.Forms.ToolStripButton();
            this.tsbPublish = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbEntity = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSelectTemplate = new System.Windows.Forms.Button();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.lvAttributes = new System.Windows.Forms.ListView();
            this.chLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFieldRequirement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblUsed = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tsbDonate = new System.Windows.Forms.ToolStripButton();
            this.tsMain.SuspendLayout();
            this.gbEntity.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator2,
            this.tsbLoadEntities,
            this.tsbPublish,
            this.toolStripSeparator1,
            this.tsbDonate});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(800, 25);
            this.tsMain.TabIndex = 90;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(23, 22);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLoadEntities
            // 
            this.tsbLoadEntities.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbLoadEntities.Image = global::Colso.Xrm.AttributeEditor.Properties.Resources.entities;
            this.tsbLoadEntities.Name = "tsbLoadEntities";
            this.tsbLoadEntities.Size = new System.Drawing.Size(107, 22);
            this.tsbLoadEntities.Text = "Refresh Entities";
            this.tsbLoadEntities.Click += new System.EventHandler(this.tsbLoadEntities_Click);
            // 
            // tsbPublish
            // 
            this.tsbPublish.Image = global::Colso.Xrm.AttributeEditor.Properties.Resources.publishall;
            this.tsbPublish.Name = "tsbPublish";
            this.tsbPublish.Size = new System.Drawing.Size(106, 22);
            this.tsbPublish.Text = "Save && Publish";
            this.tsbPublish.ToolTipText = "Save and Publish";
            this.tsbPublish.Click += new System.EventHandler(this.tsbPublish_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gbEntity
            // 
            this.gbEntity.Controls.Add(this.btnImport);
            this.gbEntity.Controls.Add(this.btnSelectTemplate);
            this.gbEntity.Controls.Add(this.txtTemplatePath);
            this.gbEntity.Controls.Add(this.btnExport);
            this.gbEntity.Controls.Add(this.cmbEntities);
            this.gbEntity.Location = new System.Drawing.Point(3, 28);
            this.gbEntity.Name = "gbEntity";
            this.gbEntity.Size = new System.Drawing.Size(529, 81);
            this.gbEntity.TabIndex = 91;
            this.gbEntity.TabStop = false;
            this.gbEntity.Text = "Entity";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(389, 44);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(125, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Upload template";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSelectTemplate
            // 
            this.btnSelectTemplate.Location = new System.Drawing.Point(357, 44);
            this.btnSelectTemplate.Name = "btnSelectTemplate";
            this.btnSelectTemplate.Size = new System.Drawing.Size(26, 23);
            this.btnSelectTemplate.TabIndex = 4;
            this.btnSelectTemplate.Text = "...";
            this.btnSelectTemplate.UseVisualStyleBackColor = true;
            this.btnSelectTemplate.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Location = new System.Drawing.Point(9, 46);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.ReadOnly = true;
            this.txtTemplatePath.Size = new System.Drawing.Size(342, 20);
            this.txtTemplatePath.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(389, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Download template";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbEntities
            // 
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(9, 19);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(374, 21);
            this.cmbEntities.TabIndex = 0;
            this.cmbEntities.SelectedIndexChanged += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(11, 61);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(57, 17);
            this.cbDelete.TabIndex = 7;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Checked = true;
            this.cbUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdate.Location = new System.Drawing.Point(11, 38);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(61, 17);
            this.cbUpdate.TabIndex = 6;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbCreate
            // 
            this.cbCreate.AutoSize = true;
            this.cbCreate.Checked = true;
            this.cbCreate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCreate.Location = new System.Drawing.Point(11, 15);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(57, 17);
            this.cbCreate.TabIndex = 5;
            this.cbCreate.Text = "Create";
            this.cbCreate.UseVisualStyleBackColor = true;
            // 
            // gbAttributes
            // 
            this.gbAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAttributes.Controls.Add(this.lvAttributes);
            this.gbAttributes.Location = new System.Drawing.Point(3, 115);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(794, 482);
            this.gbAttributes.TabIndex = 93;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Attributes";
            // 
            // lvAttributes
            // 
            this.lvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLogicalName,
            this.chDisplayName,
            this.chType,
            this.chState,
            this.chFieldRequirement,
            this.chAction});
            this.lvAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAttributes.FullRowSelect = true;
            this.lvAttributes.HideSelection = false;
            this.lvAttributes.Location = new System.Drawing.Point(3, 16);
            this.lvAttributes.Name = "lvAttributes";
            this.lvAttributes.Size = new System.Drawing.Size(788, 463);
            this.lvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAttributes.TabIndex = 0;
            this.lvAttributes.UseCompatibleStateImageBehavior = false;
            this.lvAttributes.View = System.Windows.Forms.View.Details;
            this.lvAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAttributes_ColumnClick);
            // 
            // chLogicalName
            // 
            this.chLogicalName.Text = "Logical Name";
            this.chLogicalName.Width = 175;
            // 
            // chDisplayName
            // 
            this.chDisplayName.Text = "Display Name";
            this.chDisplayName.Width = 150;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 120;
            // 
            // chState
            // 
            this.chState.Text = "State";
            this.chState.Width = 120;
            // 
            // chFieldRequirement
            // 
            this.chFieldRequirement.Text = "Field RequiredLevel";
            this.chFieldRequirement.Width = 150;
            // 
            // chAction
            // 
            this.chAction.Text = "Action";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbDelete);
            this.gbSettings.Controls.Add(this.cbCreate);
            this.gbSettings.Controls.Add(this.cbUpdate);
            this.gbSettings.Location = new System.Drawing.Point(538, 28);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(83, 81);
            this.gbSettings.TabIndex = 94;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.lblAvailable);
            this.gbInfo.Controls.Add(this.lblUsed);
            this.gbInfo.Controls.Add(this.lblCount);
            this.gbInfo.Location = new System.Drawing.Point(627, 28);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(167, 81);
            this.gbInfo.TabIndex = 95;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // lblAvailable
            // 
            this.lblAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailable.AutoEllipsis = true;
            this.lblAvailable.Location = new System.Drawing.Point(7, 49);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(154, 29);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Available space: -Money: 0; -Lookup: 0; -Picklist/Boolean: 0; -Other: 0";
            // 
            // lblUsed
            // 
            this.lblUsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsed.AutoEllipsis = true;
            this.lblUsed.AutoSize = true;
            this.lblUsed.Location = new System.Drawing.Point(7, 32);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(105, 13);
            this.lblUsed.TabIndex = 1;
            this.lblUsed.Text = "Used space: 0/1024";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoEllipsis = true;
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(7, 15);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 13);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "0 attributes";
            // 
            // tsbDonate
            // 
            this.tsbDonate.Image = global::Colso.Xrm.AttributeEditor.Properties.Resources.paypal;
            this.tsbDonate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDonate.Name = "tsbDonate";
            this.tsbDonate.Size = new System.Drawing.Size(65, 22);
            this.tsbDonate.Text = "Donate";
            this.tsbDonate.Click += new System.EventHandler(this.tsbDonate_Click);
            // 
            // AttributeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.Custom_ConnectionUpdated);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.gbEntity);
            this.Controls.Add(this.tsMain);
            this.Name = "AttributeEditor";
            this.Size = new System.Drawing.Size(800, 600);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.gbEntity.ResumeLayout(false);
            this.gbEntity.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbLoadEntities;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPublish;
        private System.Windows.Forms.GroupBox gbEntity;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Button btnSelectTemplate;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.ListView lvAttributes;
        private System.Windows.Forms.ColumnHeader chDisplayName;
        private System.Windows.Forms.ColumnHeader chLogicalName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chFieldRequirement;
        private System.Windows.Forms.ColumnHeader chAction;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbCreate;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.ToolStripButton tsbDonate;
    }
}
