namespace View.MainPart.Author
{
    partial class AuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            this.authorPages = new System.Windows.Forms.TabControl();
            this.addNewImagePage = new System.Windows.Forms.TabPage();
            this.addTabImageSettings = new System.Windows.Forms.Panel();
            this.addTabFiltersPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.addTabImageFormat = new System.Windows.Forms.RichTextBox();
            this.addTabImageFormatTitle = new System.Windows.Forms.RichTextBox();
            this.addTabFiltersTitle = new System.Windows.Forms.RichTextBox();
            this.addTabImageAddDate = new System.Windows.Forms.RichTextBox();
            this.addTabAddDateTitle = new System.Windows.Forms.RichTextBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.addTabSizeFormat = new System.Windows.Forms.RichTextBox();
            this.addTabImageSize = new System.Windows.Forms.RichTextBox();
            this.addTabimagePixelsTitle = new System.Windows.Forms.RichTextBox();
            this.addTabImageHeigth = new System.Windows.Forms.RichTextBox();
            this.addTabImageWidth = new System.Windows.Forms.RichTextBox();
            this.addTabSizeTitle = new System.Windows.Forms.RichTextBox();
            this.addTabImageTitle = new System.Windows.Forms.RichTextBox();
            this.addTabTitle = new System.Windows.Forms.RichTextBox();
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.myImages = new System.Windows.Forms.TabPage();
            this.imagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchFiltersBox = new System.Windows.Forms.GroupBox();
            this.filtersLayuoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sortingBox = new System.Windows.Forms.GroupBox();
            this.sortParameters = new System.Windows.Forms.ComboBox();
            this.sortDown = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.imagesPageFormat = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.imagePageAddDate = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.kb = new System.Windows.Forms.RichTextBox();
            this.imagesPageSize = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.imagesPageHeight = new System.Windows.Forms.RichTextBox();
            this.imagesPageWidth = new System.Windows.Forms.RichTextBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.currentImageTitleTitle = new System.Windows.Forms.RichTextBox();
            this.imagesPageTitle = new System.Windows.Forms.RichTextBox();
            this.account = new System.Windows.Forms.TabPage();
            this.rankBox = new System.Windows.Forms.GroupBox();
            this.rank = new System.Windows.Forms.RichTextBox();
            this.logout = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.GroupBox();
            this.accountEmail = new System.Windows.Forms.RichTextBox();
            this.passwordBox = new System.Windows.Forms.GroupBox();
            this.accountPassword = new System.Windows.Forms.RichTextBox();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.accountLogin = new System.Windows.Forms.RichTextBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.authorPages.SuspendLayout();
            this.addNewImagePage.SuspendLayout();
            this.addTabImageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.myImages.SuspendLayout();
            this.searchFiltersBox.SuspendLayout();
            this.sortingBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.account.SuspendLayout();
            this.rankBox.SuspendLayout();
            this.emailBox.SuspendLayout();
            this.passwordBox.SuspendLayout();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorPages
            // 
            this.authorPages.Controls.Add(this.addNewImagePage);
            this.authorPages.Controls.Add(this.myImages);
            this.authorPages.Controls.Add(this.account);
            this.authorPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorPages.ItemSize = new System.Drawing.Size(300, 40);
            this.authorPages.Location = new System.Drawing.Point(0, 0);
            this.authorPages.Name = "authorPages";
            this.authorPages.Padding = new System.Drawing.Point(10, 5);
            this.authorPages.SelectedIndex = 0;
            this.authorPages.Size = new System.Drawing.Size(1384, 758);
            this.authorPages.TabIndex = 0;
            // 
            // addNewImagePage
            // 
            this.addNewImagePage.BackColor = System.Drawing.Color.DodgerBlue;
            this.addNewImagePage.Controls.Add(this.addTabImageSettings);
            this.addNewImagePage.Controls.Add(this.mainImage);
            this.addNewImagePage.Location = new System.Drawing.Point(4, 44);
            this.addNewImagePage.Name = "addNewImagePage";
            this.addNewImagePage.Padding = new System.Windows.Forms.Padding(3);
            this.addNewImagePage.Size = new System.Drawing.Size(1376, 710);
            this.addNewImagePage.TabIndex = 0;
            this.addNewImagePage.Text = "Додати зображення";
            this.addNewImagePage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // addTabImageSettings
            // 
            this.addTabImageSettings.BackColor = System.Drawing.Color.PapayaWhip;
            this.addTabImageSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addTabImageSettings.Controls.Add(this.addTabFiltersPannel);
            this.addTabImageSettings.Controls.Add(this.addTabImageFormat);
            this.addTabImageSettings.Controls.Add(this.addTabImageFormatTitle);
            this.addTabImageSettings.Controls.Add(this.addTabFiltersTitle);
            this.addTabImageSettings.Controls.Add(this.addTabImageAddDate);
            this.addTabImageSettings.Controls.Add(this.addTabAddDateTitle);
            this.addTabImageSettings.Controls.Add(this.addImageButton);
            this.addTabImageSettings.Controls.Add(this.addTabSizeFormat);
            this.addTabImageSettings.Controls.Add(this.addTabImageSize);
            this.addTabImageSettings.Controls.Add(this.addTabimagePixelsTitle);
            this.addTabImageSettings.Controls.Add(this.addTabImageHeigth);
            this.addTabImageSettings.Controls.Add(this.addTabImageWidth);
            this.addTabImageSettings.Controls.Add(this.addTabSizeTitle);
            this.addTabImageSettings.Controls.Add(this.addTabImageTitle);
            this.addTabImageSettings.Controls.Add(this.addTabTitle);
            this.addTabImageSettings.Location = new System.Drawing.Point(945, 7);
            this.addTabImageSettings.Name = "addTabImageSettings";
            this.addTabImageSettings.Size = new System.Drawing.Size(425, 690);
            this.addTabImageSettings.TabIndex = 1;
            // 
            // addTabFiltersPannel
            // 
            this.addTabFiltersPannel.AutoScroll = true;
            this.addTabFiltersPannel.BackColor = System.Drawing.Color.PeachPuff;
            this.addTabFiltersPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabFiltersPannel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.addTabFiltersPannel.Location = new System.Drawing.Point(30, 323);
            this.addTabFiltersPannel.Name = "addTabFiltersPannel";
            this.addTabFiltersPannel.Size = new System.Drawing.Size(370, 218);
            this.addTabFiltersPannel.TabIndex = 2;
            this.addTabFiltersPannel.WrapContents = false;
            // 
            // addTabImageFormat
            // 
            this.addTabImageFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabImageFormat.BackColor = System.Drawing.Color.White;
            this.addTabImageFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabImageFormat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabImageFormat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabImageFormat.Location = new System.Drawing.Point(149, 221);
            this.addTabImageFormat.Multiline = false;
            this.addTabImageFormat.Name = "addTabImageFormat";
            this.addTabImageFormat.ReadOnly = true;
            this.addTabImageFormat.Size = new System.Drawing.Size(201, 40);
            this.addTabImageFormat.TabIndex = 17;
            this.addTabImageFormat.Text = "";
            // 
            // addTabImageFormatTitle
            // 
            this.addTabImageFormatTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabImageFormatTitle.BackColor = System.Drawing.Color.PapayaWhip;
            this.addTabImageFormatTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTabImageFormatTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabImageFormatTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabImageFormatTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addTabImageFormatTitle.Location = new System.Drawing.Point(3, 221);
            this.addTabImageFormatTitle.Name = "addTabImageFormatTitle";
            this.addTabImageFormatTitle.ReadOnly = true;
            this.addTabImageFormatTitle.Size = new System.Drawing.Size(140, 40);
            this.addTabImageFormatTitle.TabIndex = 16;
            this.addTabImageFormatTitle.TabStop = false;
            this.addTabImageFormatTitle.Text = "Формат:";
            // 
            // addTabFiltersTitle
            // 
            this.addTabFiltersTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabFiltersTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.addTabFiltersTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabFiltersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabFiltersTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.addTabFiltersTitle.Location = new System.Drawing.Point(30, 277);
            this.addTabFiltersTitle.Name = "addTabFiltersTitle";
            this.addTabFiltersTitle.ReadOnly = true;
            this.addTabFiltersTitle.Size = new System.Drawing.Size(370, 40);
            this.addTabFiltersTitle.TabIndex = 15;
            this.addTabFiltersTitle.TabStop = false;
            this.addTabFiltersTitle.Text = "Фільтри";
            // 
            // addTabImageAddDate
            // 
            this.addTabImageAddDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabImageAddDate.BackColor = System.Drawing.Color.White;
            this.addTabImageAddDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabImageAddDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabImageAddDate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabImageAddDate.Location = new System.Drawing.Point(235, 561);
            this.addTabImageAddDate.Multiline = false;
            this.addTabImageAddDate.Name = "addTabImageAddDate";
            this.addTabImageAddDate.ReadOnly = true;
            this.addTabImageAddDate.Size = new System.Drawing.Size(174, 40);
            this.addTabImageAddDate.TabIndex = 14;
            this.addTabImageAddDate.Text = "";
            // 
            // addTabAddDateTitle
            // 
            this.addTabAddDateTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabAddDateTitle.BackColor = System.Drawing.Color.PapayaWhip;
            this.addTabAddDateTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTabAddDateTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabAddDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabAddDateTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addTabAddDateTitle.Location = new System.Drawing.Point(3, 561);
            this.addTabAddDateTitle.Name = "addTabAddDateTitle";
            this.addTabAddDateTitle.ReadOnly = true;
            this.addTabAddDateTitle.Size = new System.Drawing.Size(226, 40);
            this.addTabAddDateTitle.TabIndex = 13;
            this.addTabAddDateTitle.TabStop = false;
            this.addTabAddDateTitle.Text = "Дата додавання:";
            // 
            // addImageButton
            // 
            this.addImageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addImageButton.BackColor = System.Drawing.Color.Gold;
            this.addImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImageButton.ForeColor = System.Drawing.Color.Black;
            this.addImageButton.Location = new System.Drawing.Point(30, 633);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(370, 44);
            this.addImageButton.TabIndex = 12;
            this.addImageButton.Text = "Додати зображення";
            this.addImageButton.UseVisualStyleBackColor = false;
            this.addImageButton.Click += new System.EventHandler(this.ClickAddImageButton);
            // 
            // addTabSizeFormat
            // 
            this.addTabSizeFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabSizeFormat.BackColor = System.Drawing.Color.PapayaWhip;
            this.addTabSizeFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTabSizeFormat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabSizeFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabSizeFormat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addTabSizeFormat.Location = new System.Drawing.Point(356, 170);
            this.addTabSizeFormat.Name = "addTabSizeFormat";
            this.addTabSizeFormat.ReadOnly = true;
            this.addTabSizeFormat.Size = new System.Drawing.Size(53, 25);
            this.addTabSizeFormat.TabIndex = 9;
            this.addTabSizeFormat.TabStop = false;
            this.addTabSizeFormat.Text = "Кб";
            // 
            // addTabImageSize
            // 
            this.addTabImageSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabImageSize.BackColor = System.Drawing.Color.White;
            this.addTabImageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabImageSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabImageSize.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabImageSize.Location = new System.Drawing.Point(149, 160);
            this.addTabImageSize.Multiline = false;
            this.addTabImageSize.Name = "addTabImageSize";
            this.addTabImageSize.ReadOnly = true;
            this.addTabImageSize.Size = new System.Drawing.Size(201, 40);
            this.addTabImageSize.TabIndex = 8;
            this.addTabImageSize.Text = "";
            // 
            // addTabimagePixelsTitle
            // 
            this.addTabimagePixelsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabimagePixelsTitle.BackColor = System.Drawing.Color.PapayaWhip;
            this.addTabimagePixelsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTabimagePixelsTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabimagePixelsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabimagePixelsTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addTabimagePixelsTitle.Location = new System.Drawing.Point(3, 99);
            this.addTabimagePixelsTitle.Name = "addTabimagePixelsTitle";
            this.addTabimagePixelsTitle.ReadOnly = true;
            this.addTabimagePixelsTitle.Size = new System.Drawing.Size(140, 40);
            this.addTabimagePixelsTitle.TabIndex = 7;
            this.addTabimagePixelsTitle.TabStop = false;
            this.addTabimagePixelsTitle.Text = "Розширення:";
            // 
            // addTabImageHeigth
            // 
            this.addTabImageHeigth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabImageHeigth.BackColor = System.Drawing.Color.White;
            this.addTabImageHeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabImageHeigth.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabImageHeigth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabImageHeigth.Location = new System.Drawing.Point(289, 99);
            this.addTabImageHeigth.Multiline = false;
            this.addTabImageHeigth.Name = "addTabImageHeigth";
            this.addTabImageHeigth.ReadOnly = true;
            this.addTabImageHeigth.Size = new System.Drawing.Size(120, 40);
            this.addTabImageHeigth.TabIndex = 6;
            this.addTabImageHeigth.Text = "";
            // 
            // addTabImageWidth
            // 
            this.addTabImageWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabImageWidth.BackColor = System.Drawing.Color.White;
            this.addTabImageWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabImageWidth.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabImageWidth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabImageWidth.Location = new System.Drawing.Point(149, 99);
            this.addTabImageWidth.Multiline = false;
            this.addTabImageWidth.Name = "addTabImageWidth";
            this.addTabImageWidth.ReadOnly = true;
            this.addTabImageWidth.Size = new System.Drawing.Size(120, 40);
            this.addTabImageWidth.TabIndex = 5;
            this.addTabImageWidth.Text = "";
            // 
            // addTabSizeTitle
            // 
            this.addTabSizeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabSizeTitle.BackColor = System.Drawing.Color.PapayaWhip;
            this.addTabSizeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTabSizeTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabSizeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabSizeTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addTabSizeTitle.Location = new System.Drawing.Point(3, 160);
            this.addTabSizeTitle.Name = "addTabSizeTitle";
            this.addTabSizeTitle.ReadOnly = true;
            this.addTabSizeTitle.Size = new System.Drawing.Size(102, 40);
            this.addTabSizeTitle.TabIndex = 4;
            this.addTabSizeTitle.TabStop = false;
            this.addTabSizeTitle.Text = "Розмір:";
            // 
            // addTabImageTitle
            // 
            this.addTabImageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabImageTitle.BackColor = System.Drawing.Color.PapayaWhip;
            this.addTabImageTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTabImageTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTabImageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabImageTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addTabImageTitle.Location = new System.Drawing.Point(3, 13);
            this.addTabImageTitle.Name = "addTabImageTitle";
            this.addTabImageTitle.ReadOnly = true;
            this.addTabImageTitle.Size = new System.Drawing.Size(102, 40);
            this.addTabImageTitle.TabIndex = 2;
            this.addTabImageTitle.TabStop = false;
            this.addTabImageTitle.Text = "Назва:";
            // 
            // addTabTitle
            // 
            this.addTabTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTabTitle.BackColor = System.Drawing.Color.White;
            this.addTabTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTabTitle.Location = new System.Drawing.Point(149, 13);
            this.addTabTitle.Multiline = false;
            this.addTabTitle.Name = "addTabTitle";
            this.addTabTitle.Size = new System.Drawing.Size(260, 40);
            this.addTabTitle.TabIndex = 3;
            this.addTabTitle.Text = "";
            // 
            // mainImage
            // 
            this.mainImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.mainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainImage.Location = new System.Drawing.Point(6, 55);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(930, 593);
            this.mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            this.mainImage.Click += new System.EventHandler(this.ClickMainImage);
            // 
            // myImages
            // 
            this.myImages.BackColor = System.Drawing.Color.RoyalBlue;
            this.myImages.Controls.Add(this.imagesPanel);
            this.myImages.Controls.Add(this.searchFiltersBox);
            this.myImages.Controls.Add(this.sortingBox);
            this.myImages.Controls.Add(this.panel1);
            this.myImages.Location = new System.Drawing.Point(4, 44);
            this.myImages.Name = "myImages";
            this.myImages.Padding = new System.Windows.Forms.Padding(3);
            this.myImages.Size = new System.Drawing.Size(1376, 710);
            this.myImages.TabIndex = 1;
            this.myImages.Text = "Мої зображення";
            // 
            // imagesPanel
            // 
            this.imagesPanel.Location = new System.Drawing.Point(267, 108);
            this.imagesPanel.Name = "imagesPanel";
            this.imagesPanel.Size = new System.Drawing.Size(672, 589);
            this.imagesPanel.TabIndex = 23;
            // 
            // searchFiltersBox
            // 
            this.searchFiltersBox.Controls.Add(this.filtersLayuoutPanel);
            this.searchFiltersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFiltersBox.ForeColor = System.Drawing.Color.White;
            this.searchFiltersBox.Location = new System.Drawing.Point(8, 8);
            this.searchFiltersBox.Name = "searchFiltersBox";
            this.searchFiltersBox.Size = new System.Drawing.Size(253, 689);
            this.searchFiltersBox.TabIndex = 22;
            this.searchFiltersBox.TabStop = false;
            this.searchFiltersBox.Text = "Мітки";
            // 
            // filtersLayuoutPanel
            // 
            this.filtersLayuoutPanel.AutoScroll = true;
            this.filtersLayuoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.filtersLayuoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.filtersLayuoutPanel.Location = new System.Drawing.Point(0, 40);
            this.filtersLayuoutPanel.Name = "filtersLayuoutPanel";
            this.filtersLayuoutPanel.Size = new System.Drawing.Size(252, 649);
            this.filtersLayuoutPanel.TabIndex = 0;
            this.filtersLayuoutPanel.WrapContents = false;
            // 
            // sortingBox
            // 
            this.sortingBox.Controls.Add(this.sortParameters);
            this.sortingBox.Controls.Add(this.sortDown);
            this.sortingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingBox.ForeColor = System.Drawing.Color.White;
            this.sortingBox.Location = new System.Drawing.Point(488, 8);
            this.sortingBox.Name = "sortingBox";
            this.sortingBox.Size = new System.Drawing.Size(451, 81);
            this.sortingBox.TabIndex = 22;
            this.sortingBox.TabStop = false;
            this.sortingBox.Text = "Сортування";
            // 
            // sortParameters
            // 
            this.sortParameters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortParameters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortParameters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortParameters.Items.AddRange(new object[] {
            "Дата додавання",
            "Назва",
            "Розмір",
            "Розширення"});
            this.sortParameters.Location = new System.Drawing.Point(216, 30);
            this.sortParameters.Name = "sortParameters";
            this.sortParameters.Size = new System.Drawing.Size(224, 37);
            this.sortParameters.Sorted = true;
            this.sortParameters.TabIndex = 20;
            this.sortParameters.SelectedIndexChanged += new System.EventHandler(this.ChangeSortMethod);
            // 
            // sortDown
            // 
            this.sortDown.AutoSize = true;
            this.sortDown.ForeColor = System.Drawing.Color.White;
            this.sortDown.Location = new System.Drawing.Point(31, 30);
            this.sortDown.Name = "sortDown";
            this.sortDown.Size = new System.Drawing.Size(152, 33);
            this.sortDown.TabIndex = 19;
            this.sortDown.Text = "Спадання";
            this.sortDown.UseVisualStyleBackColor = true;
            this.sortDown.CheckedChanged += new System.EventHandler(this.ChangeSortMethod);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.deleteImageButton);
            this.panel1.Controls.Add(this.imagesPageFormat);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.imagePageAddDate);
            this.panel1.Controls.Add(this.richTextBox5);
            this.panel1.Controls.Add(this.kb);
            this.panel1.Controls.Add(this.imagesPageSize);
            this.panel1.Controls.Add(this.richTextBox8);
            this.panel1.Controls.Add(this.imagesPageHeight);
            this.panel1.Controls.Add(this.imagesPageWidth);
            this.panel1.Controls.Add(this.richTextBox11);
            this.panel1.Controls.Add(this.currentImageTitleTitle);
            this.panel1.Controls.Add(this.imagesPageTitle);
            this.panel1.Location = new System.Drawing.Point(945, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 689);
            this.panel1.TabIndex = 2;
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteImageButton.BackColor = System.Drawing.Color.Brown;
            this.deleteImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteImageButton.ForeColor = System.Drawing.Color.White;
            this.deleteImageButton.Location = new System.Drawing.Point(28, 593);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(370, 70);
            this.deleteImageButton.TabIndex = 18;
            this.deleteImageButton.Text = "Видалити з бази";
            this.deleteImageButton.UseVisualStyleBackColor = false;
            this.deleteImageButton.Click += new System.EventHandler(this.ClickDeleteImageButton);
            // 
            // imagesPageFormat
            // 
            this.imagesPageFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagesPageFormat.BackColor = System.Drawing.Color.White;
            this.imagesPageFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesPageFormat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imagesPageFormat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagesPageFormat.Location = new System.Drawing.Point(164, 333);
            this.imagesPageFormat.Multiline = false;
            this.imagesPageFormat.Name = "imagesPageFormat";
            this.imagesPageFormat.ReadOnly = true;
            this.imagesPageFormat.Size = new System.Drawing.Size(200, 40);
            this.imagesPageFormat.TabIndex = 17;
            this.imagesPageFormat.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(12, 334);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(140, 40);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "Формат:";
            // 
            // imagePageAddDate
            // 
            this.imagePageAddDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagePageAddDate.BackColor = System.Drawing.Color.White;
            this.imagePageAddDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePageAddDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imagePageAddDate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagePageAddDate.Location = new System.Drawing.Point(236, 439);
            this.imagePageAddDate.Multiline = false;
            this.imagePageAddDate.Name = "imagePageAddDate";
            this.imagePageAddDate.ReadOnly = true;
            this.imagePageAddDate.Size = new System.Drawing.Size(173, 40);
            this.imagePageAddDate.TabIndex = 14;
            this.imagePageAddDate.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox5.BackColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(3, 443);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(227, 40);
            this.richTextBox5.TabIndex = 13;
            this.richTextBox5.TabStop = false;
            this.richTextBox5.Text = "Дата додавання:";
            // 
            // kb
            // 
            this.kb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kb.BackColor = System.Drawing.Color.RoyalBlue;
            this.kb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kb.ForeColor = System.Drawing.Color.White;
            this.kb.Location = new System.Drawing.Point(371, 223);
            this.kb.Name = "kb";
            this.kb.ReadOnly = true;
            this.kb.Size = new System.Drawing.Size(48, 39);
            this.kb.TabIndex = 9;
            this.kb.TabStop = false;
            this.kb.Text = "Кб";
            // 
            // imagesPageSize
            // 
            this.imagesPageSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagesPageSize.BackColor = System.Drawing.Color.White;
            this.imagesPageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesPageSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imagesPageSize.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagesPageSize.Location = new System.Drawing.Point(163, 222);
            this.imagesPageSize.Multiline = false;
            this.imagesPageSize.Name = "imagesPageSize";
            this.imagesPageSize.ReadOnly = true;
            this.imagesPageSize.Size = new System.Drawing.Size(201, 40);
            this.imagesPageSize.TabIndex = 8;
            this.imagesPageSize.Text = "";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox8.BackColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox8.ForeColor = System.Drawing.Color.White;
            this.richTextBox8.Location = new System.Drawing.Point(4, 121);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(154, 40);
            this.richTextBox8.TabIndex = 7;
            this.richTextBox8.TabStop = false;
            this.richTextBox8.Text = "Розширення:";
            // 
            // imagesPageHeight
            // 
            this.imagesPageHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagesPageHeight.BackColor = System.Drawing.Color.White;
            this.imagesPageHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesPageHeight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imagesPageHeight.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagesPageHeight.Location = new System.Drawing.Point(289, 117);
            this.imagesPageHeight.Multiline = false;
            this.imagesPageHeight.Name = "imagesPageHeight";
            this.imagesPageHeight.ReadOnly = true;
            this.imagesPageHeight.Size = new System.Drawing.Size(120, 40);
            this.imagesPageHeight.TabIndex = 6;
            this.imagesPageHeight.Text = "";
            // 
            // imagesPageWidth
            // 
            this.imagesPageWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagesPageWidth.BackColor = System.Drawing.Color.White;
            this.imagesPageWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesPageWidth.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imagesPageWidth.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagesPageWidth.Location = new System.Drawing.Point(164, 117);
            this.imagesPageWidth.Multiline = false;
            this.imagesPageWidth.Name = "imagesPageWidth";
            this.imagesPageWidth.ReadOnly = true;
            this.imagesPageWidth.Size = new System.Drawing.Size(120, 40);
            this.imagesPageWidth.TabIndex = 5;
            this.imagesPageWidth.Text = "";
            // 
            // richTextBox11
            // 
            this.richTextBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox11.BackColor = System.Drawing.Color.RoyalBlue;
            this.richTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox11.ForeColor = System.Drawing.Color.White;
            this.richTextBox11.Location = new System.Drawing.Point(12, 222);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.ReadOnly = true;
            this.richTextBox11.Size = new System.Drawing.Size(140, 40);
            this.richTextBox11.TabIndex = 4;
            this.richTextBox11.TabStop = false;
            this.richTextBox11.Text = "Розмір:";
            // 
            // currentImageTitleTitle
            // 
            this.currentImageTitleTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentImageTitleTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.currentImageTitleTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentImageTitleTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.currentImageTitleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentImageTitleTitle.ForeColor = System.Drawing.Color.White;
            this.currentImageTitleTitle.Location = new System.Drawing.Point(12, 12);
            this.currentImageTitleTitle.Name = "currentImageTitleTitle";
            this.currentImageTitleTitle.ReadOnly = true;
            this.currentImageTitleTitle.Size = new System.Drawing.Size(102, 40);
            this.currentImageTitleTitle.TabIndex = 2;
            this.currentImageTitleTitle.TabStop = false;
            this.currentImageTitleTitle.Text = "Назва:";
            // 
            // imagesPageTitle
            // 
            this.imagesPageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagesPageTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesPageTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagesPageTitle.Location = new System.Drawing.Point(149, 12);
            this.imagesPageTitle.Multiline = false;
            this.imagesPageTitle.Name = "imagesPageTitle";
            this.imagesPageTitle.ReadOnly = true;
            this.imagesPageTitle.Size = new System.Drawing.Size(260, 40);
            this.imagesPageTitle.TabIndex = 3;
            this.imagesPageTitle.Text = "";
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.AliceBlue;
            this.account.Controls.Add(this.rankBox);
            this.account.Controls.Add(this.logout);
            this.account.Controls.Add(this.emailBox);
            this.account.Controls.Add(this.passwordBox);
            this.account.Controls.Add(this.loginBox);
            this.account.Controls.Add(this.saveChanges);
            this.account.Controls.Add(this.deleteAccount);
            this.account.Location = new System.Drawing.Point(4, 44);
            this.account.Name = "account";
            this.account.Padding = new System.Windows.Forms.Padding(3);
            this.account.Size = new System.Drawing.Size(1376, 710);
            this.account.TabIndex = 2;
            this.account.Text = "Аккаунт";
            this.account.Click += new System.EventHandler(this.AccountClick);
            // 
            // rankBox
            // 
            this.rankBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rankBox.BackColor = System.Drawing.Color.Azure;
            this.rankBox.Controls.Add(this.rank);
            this.rankBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rankBox.Location = new System.Drawing.Point(417, 33);
            this.rankBox.Name = "rankBox";
            this.rankBox.Size = new System.Drawing.Size(438, 97);
            this.rankBox.TabIndex = 17;
            this.rankBox.TabStop = false;
            this.rankBox.Text = "Ранг";
            // 
            // rank
            // 
            this.rank.BackColor = System.Drawing.Color.Gold;
            this.rank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rank.ForeColor = System.Drawing.Color.Crimson;
            this.rank.Location = new System.Drawing.Point(0, 37);
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Size = new System.Drawing.Size(438, 54);
            this.rank.TabIndex = 15;
            this.rank.Text = "";
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(417, 611);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(438, 57);
            this.logout.TabIndex = 21;
            this.logout.Text = "Вийти з аккаунту";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.ClickLogout);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.Azure;
            this.emailBox.Controls.Add(this.accountEmail);
            this.emailBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emailBox.Location = new System.Drawing.Point(417, 342);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(438, 97);
            this.emailBox.TabIndex = 18;
            this.emailBox.TabStop = false;
            this.emailBox.Text = "E-mail";
            // 
            // accountEmail
            // 
            this.accountEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountEmail.Location = new System.Drawing.Point(0, 37);
            this.accountEmail.Name = "accountEmail";
            this.accountEmail.Size = new System.Drawing.Size(438, 60);
            this.accountEmail.TabIndex = 15;
            this.accountEmail.Text = "";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Azure;
            this.passwordBox.Controls.Add(this.accountPassword);
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordBox.Location = new System.Drawing.Point(417, 239);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(438, 97);
            this.passwordBox.TabIndex = 17;
            this.passwordBox.TabStop = false;
            this.passwordBox.Text = "Пароль";
            // 
            // accountPassword
            // 
            this.accountPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountPassword.Location = new System.Drawing.Point(0, 37);
            this.accountPassword.Name = "accountPassword";
            this.accountPassword.Size = new System.Drawing.Size(438, 60);
            this.accountPassword.TabIndex = 15;
            this.accountPassword.Text = "";
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.Azure;
            this.loginBox.Controls.Add(this.accountLogin);
            this.loginBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginBox.Location = new System.Drawing.Point(417, 136);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(438, 97);
            this.loginBox.TabIndex = 16;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Логін";
            // 
            // accountLogin
            // 
            this.accountLogin.BackColor = System.Drawing.Color.White;
            this.accountLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountLogin.Location = new System.Drawing.Point(0, 37);
            this.accountLogin.Name = "accountLogin";
            this.accountLogin.Size = new System.Drawing.Size(438, 60);
            this.accountLogin.TabIndex = 15;
            this.accountLogin.Text = "";
            // 
            // saveChanges
            // 
            this.saveChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveChanges.BackColor = System.Drawing.Color.MidnightBlue;
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.ForeColor = System.Drawing.Color.White;
            this.saveChanges.Location = new System.Drawing.Point(417, 456);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(438, 57);
            this.saveChanges.TabIndex = 14;
            this.saveChanges.Text = "Зберегти зміни аккаунту";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.ChangeAccount);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteAccount.BackColor = System.Drawing.Color.Red;
            this.deleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAccount.ForeColor = System.Drawing.Color.White;
            this.deleteAccount.Location = new System.Drawing.Point(417, 534);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(438, 57);
            this.deleteAccount.TabIndex = 13;
            this.deleteAccount.Text = "Видалити аккаунт";
            this.deleteAccount.UseVisualStyleBackColor = false;
            this.deleteAccount.Click += new System.EventHandler(this.ClickDeleteAccount);
            // 
            // AuthorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.authorPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "AuthorForm";
            this.Text = "YourWallpaperFriend Автор";
            this.authorPages.ResumeLayout(false);
            this.addNewImagePage.ResumeLayout(false);
            this.addTabImageSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.myImages.ResumeLayout(false);
            this.searchFiltersBox.ResumeLayout(false);
            this.sortingBox.ResumeLayout(false);
            this.sortingBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.account.ResumeLayout(false);
            this.rankBox.ResumeLayout(false);
            this.emailBox.ResumeLayout(false);
            this.passwordBox.ResumeLayout(false);
            this.loginBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl authorPages;
        private System.Windows.Forms.TabPage addNewImagePage;
        private System.Windows.Forms.TabPage myImages;
        private System.Windows.Forms.TabPage account;
        private System.Windows.Forms.Panel addTabImageSettings;
        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.RichTextBox addTabImageTitle;
        private System.Windows.Forms.RichTextBox addTabTitle;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.RichTextBox addTabSizeFormat;
        private System.Windows.Forms.RichTextBox addTabImageSize;
        private System.Windows.Forms.RichTextBox addTabimagePixelsTitle;
        private System.Windows.Forms.RichTextBox addTabImageHeigth;
        private System.Windows.Forms.RichTextBox addTabImageWidth;
        private System.Windows.Forms.RichTextBox addTabSizeTitle;
        private System.Windows.Forms.RichTextBox addTabFiltersTitle;
        private System.Windows.Forms.RichTextBox addTabImageAddDate;
        private System.Windows.Forms.RichTextBox addTabAddDateTitle;
        private System.Windows.Forms.RichTextBox addTabImageFormat;
        private System.Windows.Forms.RichTextBox addTabImageFormatTitle;
        private System.Windows.Forms.FlowLayoutPanel addTabFiltersPannel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox imagesPageFormat;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox imagePageAddDate;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox kb;
        private System.Windows.Forms.RichTextBox imagesPageSize;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox imagesPageHeight;
        private System.Windows.Forms.RichTextBox imagesPageWidth;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.RichTextBox currentImageTitleTitle;
        private System.Windows.Forms.RichTextBox imagesPageTitle;
        private System.Windows.Forms.CheckBox sortDown;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.ComboBox sortParameters;
        private System.Windows.Forms.GroupBox sortingBox;
        private System.Windows.Forms.GroupBox searchFiltersBox;
        private System.Windows.Forms.FlowLayoutPanel filtersLayuoutPanel;
        private System.Windows.Forms.FlowLayoutPanel imagesPanel;
        private System.Windows.Forms.GroupBox emailBox;
        private System.Windows.Forms.RichTextBox accountEmail;
        private System.Windows.Forms.GroupBox passwordBox;
        private System.Windows.Forms.RichTextBox accountPassword;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.RichTextBox accountLogin;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.GroupBox rankBox;
        private System.Windows.Forms.RichTextBox rank;
    }
}