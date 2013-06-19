using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Aramis.Core;
using System.Linq;
using System.Reflection;
using Aramis;
using Aramis.UI;
using Aramis.SystemConfigurations;
using System.Collections.Generic;
using System;
using Catalogs;
using System.Drawing;
using System.Data;
using DevExpress.XtraTab;
using Aramis.Platform;
using Aramis.Enums;
using System.IO;

namespace Catalogs.Forms
    {
    public partial class ConstsForm : DevExpress.XtraBars.Ribbon.RibbonForm
        {

        private void Itemform_Load(object sender, EventArgs e)
            {
            Aramis.UI.WinFormsDevXpress.WinFormsDevX.SetAllImages(ribbon);
            }

        public ConstsForm()
            {
            InitializeComponent();
            lock (SystemConsts.locker)
                {
                // Если мы сюда попали, значит обновление не начнется пока мы не выйдем
                SystemConsts.СonstsAutoUpdating = false;
                }
            }

        private void Itemform_KeyDown(object sender, KeyEventArgs e)
            {
            switch (e.KeyCode)
                {
                case Keys.Escape:
                    Close();
                    break;
                }
            }
       
        private void OKButton_ItemClick(object sender, ItemClickEventArgs e)
            {
            Close();
            }
        
        private void ConstsForm_FormClosed(object sender, FormClosedEventArgs e)
            {
            SystemConsts.СonstsAutoUpdating = true;
            }

        }
    }