namespace MarketAutomation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.GetProductRefund = new DevExpress.XtraBars.BarButtonItem();
            this.SaveCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.WriteMessageAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.FootballGame = new DevExpress.XtraBars.BarButtonItem();
            this.ObjectFindGame = new DevExpress.XtraBars.BarButtonItem();
            this.AddStaff = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteStaff = new DevExpress.XtraBars.BarButtonItem();
            this.AddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteProduct = new DevExpress.XtraBars.BarButtonItem();
            this.ListSoldProducts = new DevExpress.XtraBars.BarButtonItem();
            this.TotalEarn = new DevExpress.XtraBars.BarButtonItem();
            this.ReadMessage = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.StaffScreen = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AdminScreen = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.GetProductRefund,
            this.SaveCustomer,
            this.DeleteCustomer,
            this.WriteMessageAdmin,
            this.FootballGame,
            this.ObjectFindGame,
            this.AddStaff,
            this.DeleteStaff,
            this.AddProduct,
            this.DeleteProduct,
            this.ListSoldProducts,
            this.TotalEarn,
            this.ReadMessage,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.StaffScreen,
            this.AdminScreen});
            this.ribbonControl1.Size = new System.Drawing.Size(1442, 183);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sell Product";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // GetProductRefund
            // 
            this.GetProductRefund.Caption = "Get Product Refund";
            this.GetProductRefund.Id = 2;
            this.GetProductRefund.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GetProductRefund.ImageOptions.Image")));
            this.GetProductRefund.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GetProductRefund.ImageOptions.LargeImage")));
            this.GetProductRefund.Name = "GetProductRefund";
            this.GetProductRefund.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GetProductRefund_ItemClick);
            // 
            // SaveCustomer
            // 
            this.SaveCustomer.Caption = "Save Customer";
            this.SaveCustomer.Id = 3;
            this.SaveCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveCustomer.ImageOptions.Image")));
            this.SaveCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SaveCustomer.ImageOptions.LargeImage")));
            this.SaveCustomer.Name = "SaveCustomer";
            this.SaveCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveCustomer_ItemClick);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Caption = "Delete Customer";
            this.DeleteCustomer.Id = 4;
            this.DeleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCustomer.ImageOptions.Image")));
            this.DeleteCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteCustomer.ImageOptions.LargeImage")));
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteCustomer_ItemClick);
            // 
            // WriteMessageAdmin
            // 
            this.WriteMessageAdmin.Caption = "Write Message Admin";
            this.WriteMessageAdmin.Id = 5;
            this.WriteMessageAdmin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("WriteMessageAdmin.ImageOptions.SvgImage")));
            this.WriteMessageAdmin.Name = "WriteMessageAdmin";
            this.WriteMessageAdmin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.WriteMessageAdmin_ItemClick);
            // 
            // FootballGame
            // 
            this.FootballGame.Caption = "football Game";
            this.FootballGame.Id = 6;
            this.FootballGame.Name = "FootballGame";
            this.FootballGame.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FootballGame_ItemClick);
            // 
            // ObjectFindGame
            // 
            this.ObjectFindGame.Caption = "Object Find Game";
            this.ObjectFindGame.Id = 7;
            this.ObjectFindGame.Name = "ObjectFindGame";
            this.ObjectFindGame.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ObjectFindGame_ItemClick);
            // 
            // AddStaff
            // 
            this.AddStaff.Caption = "Add Staff";
            this.AddStaff.Id = 8;
            this.AddStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddStaff.ImageOptions.Image")));
            this.AddStaff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AddStaff.ImageOptions.LargeImage")));
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddStaff_ItemClick);
            // 
            // DeleteStaff
            // 
            this.DeleteStaff.Caption = "Delete Staff";
            this.DeleteStaff.Id = 9;
            this.DeleteStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteStaff.ImageOptions.Image")));
            this.DeleteStaff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteStaff.ImageOptions.LargeImage")));
            this.DeleteStaff.Name = "DeleteStaff";
            this.DeleteStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteStaff_ItemClick);
            // 
            // AddProduct
            // 
            this.AddProduct.Caption = "Add Product";
            this.AddProduct.Id = 10;
            this.AddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddProduct.ImageOptions.Image")));
            this.AddProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AddProduct.ImageOptions.LargeImage")));
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddProduct_ItemClick);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Caption = "Delete Product";
            this.DeleteProduct.Id = 11;
            this.DeleteProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteProduct.ImageOptions.Image")));
            this.DeleteProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DeleteProduct.ImageOptions.LargeImage")));
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteProduct_ItemClick);
            // 
            // ListSoldProducts
            // 
            this.ListSoldProducts.Caption = "List Sold Products";
            this.ListSoldProducts.Id = 12;
            this.ListSoldProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListSoldProducts.ImageOptions.Image")));
            this.ListSoldProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ListSoldProducts.ImageOptions.LargeImage")));
            this.ListSoldProducts.Name = "ListSoldProducts";
            this.ListSoldProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ListSoldProducts_ItemClick);
            // 
            // TotalEarn
            // 
            this.TotalEarn.Caption = "Total Earn";
            this.TotalEarn.Id = 13;
            this.TotalEarn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TotalEarn.ImageOptions.SvgImage")));
            this.TotalEarn.Name = "TotalEarn";
            this.TotalEarn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TotalEarn_ItemClick);
            // 
            // ReadMessage
            // 
            this.ReadMessage.Caption = "Read Message";
            this.ReadMessage.Id = 14;
            this.ReadMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ReadMessage.ImageOptions.Image")));
            this.ReadMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ReadMessage.ImageOptions.LargeImage")));
            this.ReadMessage.Name = "ReadMessage";
            this.ReadMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReadMessage_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 17;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // StaffScreen
            // 
            this.StaffScreen.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.StaffScreen.Name = "StaffScreen";
            this.StaffScreen.Text = "Staff screen";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.GetProductRefund);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.SaveCustomer);
            this.ribbonPageGroup2.ItemLinks.Add(this.DeleteCustomer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.WriteMessageAdmin);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.FootballGame);
            this.ribbonPageGroup4.ItemLinks.Add(this.ObjectFindGame);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // AdminScreen
            // 
            this.AdminScreen.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.AdminScreen.Name = "AdminScreen";
            this.AdminScreen.Text = "Admin Screen";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.AddStaff);
            this.ribbonPageGroup5.ItemLinks.Add(this.DeleteStaff);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.AddProduct);
            this.ribbonPageGroup6.ItemLinks.Add(this.DeleteProduct);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.ListSoldProducts);
            this.ribbonPageGroup7.ItemLinks.Add(this.TotalEarn);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.ReadMessage);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 693);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage StaffScreen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem GetProductRefund;
        private DevExpress.XtraBars.BarButtonItem SaveCustomer;
        private DevExpress.XtraBars.BarButtonItem DeleteCustomer;
        private DevExpress.XtraBars.BarButtonItem WriteMessageAdmin;
        private DevExpress.XtraBars.BarButtonItem FootballGame;
        private DevExpress.XtraBars.BarButtonItem ObjectFindGame;
        private DevExpress.XtraBars.BarButtonItem AddStaff;
        private DevExpress.XtraBars.BarButtonItem DeleteStaff;
        private DevExpress.XtraBars.BarButtonItem AddProduct;
        private DevExpress.XtraBars.BarButtonItem DeleteProduct;
        private DevExpress.XtraBars.BarButtonItem ListSoldProducts;
        private DevExpress.XtraBars.BarButtonItem TotalEarn;
        private DevExpress.XtraBars.BarButtonItem ReadMessage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage AdminScreen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}

