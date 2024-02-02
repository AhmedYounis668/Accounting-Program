namespace DXApplication8
{
    partial class suppliers
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
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliers));
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.txtidentityid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxcity = new System.Windows.Forms.ComboBox();
            this.cbx_gov = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsup_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsup_id = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(23, 427);
            this.tileControl1.MaxId = 8;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(841, 131);
            this.tileControl1.TabIndex = 134;
            this.tileControl1.Text = "العمليات المتاحه";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem5);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem4);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItem1.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileItemElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement7.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement7.Text = "Save";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem1.Elements.Add(tileItemElement7);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItem5
            // 
            tileItemElement8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement8.Text = "New";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem5.Elements.Add(tileItemElement8);
            tileItemFrame2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            tileItemFrame2.Appearance.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileItemFrame2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            tileItemFrame2.Appearance.Options.UseBackColor = true;
            tileItemFrame2.Appearance.Options.UseFont = true;
            tileItemFrame2.Appearance.Options.UseForeColor = true;
            tileItemElement9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement9.Text = "New";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemFrame2.Elements.Add(tileItemElement9);
            tileItemFrame2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame2.Image")));
            this.tileItem5.Frames.Add(tileItemFrame2);
            this.tileItem5.Id = 7;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            this.tileItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem5_ItemClick);
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItem2.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileItemElement10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement10.Text = "Update";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem2.Elements.Add(tileItemElement10);
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItem3.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileItemElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement11.Text = "Delete";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem3.Elements.Add(tileItemElement11);
            this.tileItem3.Id = 3;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem4.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem4.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItem4.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileItemElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement12.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement12.Text = "Exit";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem4.Elements.Add(tileItemElement12);
            this.tileItem4.Id = 5;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // txtidentityid
            // 
            this.txtidentityid.Location = new System.Drawing.Point(603, 148);
            this.txtidentityid.Multiline = true;
            this.txtidentityid.Name = "txtidentityid";
            this.txtidentityid.Size = new System.Drawing.Size(260, 28);
            this.txtidentityid.TabIndex = 133;
            this.txtidentityid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(466, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 132;
            this.label5.Text = "رقم تعريفي اخر للمورد";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtsearch.ForeColor = System.Drawing.Color.Navy;
            this.txtsearch.Location = new System.Drawing.Point(229, 249);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(634, 28);
            this.txtsearch.TabIndex = 131;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(5, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 25);
            this.label10.TabIndex = 130;
            this.label10.Text = "بحث باسم المورد او بحرف من الاسم :";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtaddress.ForeColor = System.Drawing.Color.Navy;
            this.txtaddress.Location = new System.Drawing.Point(119, 114);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(745, 28);
            this.txtaddress.TabIndex = 129;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(26, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 128;
            this.label9.Text = "عنوان المورد :";
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(114, 189);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(749, 59);
            this.txtnotes.TabIndex = 127;
            this.txtnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(27, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 126;
            this.label8.Text = "Notes :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(455, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 125;
            this.label7.Text = "المدينه :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(29, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 124;
            this.label6.Text = "المجافظه :";
            // 
            // cbxcity
            // 
            this.cbxcity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxcity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxcity.FormattingEnabled = true;
            this.cbxcity.Items.AddRange(new object[] {
            "طنطا",
            "المحله الكبري",
            "كفر الزيات",
            "زفتي",
            "السنطه",
            "بسيون",
            "قطور",
            "سمنود",
            "القاهره",
            "كفر الشيخ",
            "طوخ",
            "قها",
            "العبور",
            "الخصوص",
            "شبين القناطر",
            "الاسكندريه",
            "الجيزه",
            "السادس من اكتوبر",
            "الشيخ زايد",
            "الحوامديه",
            "البدرشين",
            "الصف",
            "أطْفِيح",
            "العياط",
            "البويطي",
            "منشاه القناطر",
            "اوسيم",
            "كرداسه",
            "ابو النمرس",
            "بنها",
            "قليوب",
            "شبرا الخيمه",
            "القناطر الخيريه",
            "الخانكه",
            "برج العرب",
            "برج العرب الجديده",
            "دمنهور",
            "كفر الدوار",
            "ادكو",
            "رشيد",
            "ابو المطامير",
            "ابوحمص",
            "الدلنجات",
            "المحموديه",
            "الرحمانيه",
            "ايتاي البارود",
            "حوش عيسي",
            "شبراخيت",
            "كوم حماده",
            "بدر",
            "وادي النطرون",
            "النوباريه الجديده",
            "مرسي مطروح",
            "الحمام",
            "العلمين",
            "الضبعه",
            "النجيله",
            "سيدي براني",
            "السلوم",
            "سيوة",
            "دمياط",
            "دمياط الجديده",
            "راس البر",
            "فارسكور",
            "كفر سعد",
            "الزرقا",
            "الروضه",
            "السرو",
            "كفر البطيخ",
            "عزبه البرج",
            "ميت ابوغالب",
            "المنصوره",
            "طلخا",
            "ميت غمر",
            "دكرنس",
            "اجا",
            "منيه النصر",
            "السنبلاوين",
            "الكردي",
            "بني عبيد",
            "المنزله",
            "تمي الامديد",
            "الجماليه",
            "شربين",
            "المطريه",
            "بلقاس",
            "ميت سلسيل",
            "جمصه",
            "محله دمنه",
            "نبروة",
            "كفر الشيخ",
            "دسوق",
            "فوة",
            "مطوبس",
            "بلطيم",
            "مصيف بلطيم",
            "الحامول",
            "بيلا",
            "الرياض",
            "سيدي سالم",
            "قلين",
            "سيدي غازي",
            "برج البرلس",
            "مسير",
            "شبين الكوم",
            "مدينه السادات",
            "منوف",
            "سرس اليان",
            "اشمون",
            "الباجور",
            "قويسنا",
            "بركه السبع",
            "تلا",
            "الشهداء",
            "الزقازيق",
            "العاشر من رمضان",
            "منيا القمح",
            "بلبيس",
            "مشتول السوق",
            "القنايات",
            "ابوحماد",
            "القرين",
            "ههيا",
            "ابوكبير",
            "فاقوس",
            "الصالحيه الجديده",
            "الابراهيميه",
            "ديرب نجم",
            "كفر صقر",
            "اولاد صقر",
            "الحسينيه",
            "صان الحجر القبليه",
            "منشاه ابوعمر",
            "بور سعيد",
            "بور فؤاد",
            "الاسماعليه",
            "فايد",
            "القنطره شرق",
            "القنطره غرب",
            "التل الكبير",
            "ابو صوير المحطه",
            "القصاصين الجديده",
            "السويس",
            "العريش",
            "الشيخ زويد",
            "رفح",
            "بئر العبد",
            "الحسنه",
            "نخل",
            "الطور",
            "شرم الشيخ",
            "دهب ",
            "نويبع",
            "طابا",
            "سانت كاترين",
            "ابورديس",
            "ابو زنيمه",
            "راس سدر",
            "بني سويف",
            "بني سويف الجديده",
            "الواسطي",
            "ناصر",
            "اهناسيا",
            "ببا",
            "سمسطا",
            "الفشن",
            "الفيوم",
            "اليوم الجديده",
            "طاميه",
            "سنورس",
            "اطسا",
            "ابشواي",
            "يوسف الصديق",
            "المنيا",
            "المنيا الجديده",
            "العدوه",
            "مغاغه",
            "بني مزار",
            "مطاي",
            "سمالوط",
            "المدينه الفكريه",
            "ملوي",
            "دير مواس",
            "اسيوط",
            "اسيوط الجديده",
            "ديروط",
            "منفلوط",
            "القوصيه",
            "ابنوب",
            "ابو تيج",
            "الغنايم",
            "ساحل سليم",
            "البداري",
            "صدفا",
            "الخارجه",
            "باريس",
            "موط",
            "الفرافره",
            "بلاط",
            "الغردقه",
            "راس غارب",
            "سفاجا",
            "القصير",
            "مرسي علم",
            "الشلاتين",
            "حلايب",
            "سوهاج",
            "سوهاج الجديده",
            "اخميم",
            "اخميم الجديده",
            "البلينا",
            "المراغه",
            "المنشاه",
            "دار السلام",
            "جرجا",
            "جهينه الغربيه",
            "ساقلتا",
            "طما",
            "طهطا",
            "قنا",
            "قنا الجديده",
            "ابوتشت",
            "نجع حمادي",
            "دشنا",
            "الوقف",
            "ققط",
            "نقاده",
            "قوص",
            "فرشوط",
            "الاقصر",
            "الاقصر الجديده",
            "طيبه الجديده",
            "الزينيه",
            "البياضيه",
            "القزنه",
            "ارمنت",
            "الطود",
            "اسنا",
            "اسوان",
            "اسوان الجديده",
            "دراو",
            "كوم امبو",
            "نصر النوبه",
            "كلابشه",
            "ادفو",
            "الراديسيه",
            "البصيليه",
            "السباعيه",
            "ابو سمبل السياحيه",
            ""});
            this.cbxcity.Location = new System.Drawing.Point(528, 74);
            this.cbxcity.Name = "cbxcity";
            this.cbxcity.Size = new System.Drawing.Size(315, 27);
            this.cbxcity.TabIndex = 123;
            // 
            // cbx_gov
            // 
            this.cbx_gov.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_gov.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_gov.FormattingEnabled = true;
            this.cbx_gov.Items.AddRange(new object[] {
            "الغربيه",
            "كفر الشيخ",
            "القاهره",
            "الاسكندريه",
            "الاسماعليه",
            "اسوان",
            "اسيوط",
            "الاقصر",
            "البحرالاحمر",
            "البحيره",
            "بني سويف",
            "بورسعيد",
            "جنوب سينا",
            "الجيزه",
            "الدقهليه",
            "دمياط",
            "سوهاج",
            "السويس",
            "الشرقيه",
            "شمال سينا",
            "الفيوم",
            "القليوبيه",
            "قنا",
            "مطروح",
            "المنوفيه",
            "المنيا",
            "الوادي الجديد"});
            this.cbx_gov.Location = new System.Drawing.Point(119, 78);
            this.cbx_gov.Name = "cbx_gov";
            this.cbx_gov.Size = new System.Drawing.Size(328, 27);
            this.cbx_gov.TabIndex = 122;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(138, 150);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(315, 28);
            this.txtphone.TabIndex = 121;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 120;
            this.label4.Text = "رقم تليفون المورد :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(403, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 119;
            this.label3.Text = "المورديين";
            // 
            // txtsup_name
            // 
            this.txtsup_name.Location = new System.Drawing.Point(442, 40);
            this.txtsup_name.Multiline = true;
            this.txtsup_name.Name = "txtsup_name";
            this.txtsup_name.Size = new System.Drawing.Size(421, 28);
            this.txtsup_name.TabIndex = 118;
            this.txtsup_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(350, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 117;
            this.label2.Text = "اسم المورد :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "رقم المورد :";
            // 
            // txtsup_id
            // 
            this.txtsup_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsup_id.ForeColor = System.Drawing.Color.Navy;
            this.txtsup_id.Location = new System.Drawing.Point(119, 36);
            this.txtsup_id.Name = "txtsup_id";
            this.txtsup_id.ReadOnly = true;
            this.txtsup_id.Size = new System.Drawing.Size(213, 26);
            this.txtsup_id.TabIndex = 115;
            this.txtsup_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.GridColor = System.Drawing.Color.Navy;
            this.dgv.Location = new System.Drawing.Point(5, 280);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(858, 141);
            this.dgv.TabIndex = 114;
            // 
            // suppliers
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(871, 562);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.txtidentityid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxcity);
            this.Controls.Add(this.cbx_gov);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsup_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsup_id);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "suppliers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المورديين";
            this.Load += new System.EventHandler(this.suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private System.Windows.Forms.TextBox txtidentityid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxcity;
        private System.Windows.Forms.ComboBox cbx_gov;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsup_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsup_id;
        private System.Windows.Forms.DataGridView dgv;
    }
}