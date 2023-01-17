using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Controllers.MainPart;
using Model.Entities;
using View.MainPart;

namespace View.MainPart.Author
{
    public partial class AuthorForm : Form
    {
        public AuthorForm(Int32 accountId)
        {
            InitializeComponent();
            this.FormClosing += AuthorFormClosing;

            _mainController = new AuthorController(accountId);

            SetAccountInfo();

            this.sortParameters.SelectedItem = sortParameters.Items[0];

            FillAddImageFilters();
            ClearAddPageFields();

            FillSearchImageFilters();

            MakeImagesFiltered();
        }

        private void AuthorFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FillAddImageFilters()
        {
            Panel examplePanel = new Panel()
            {
                BackColor = System.Drawing.Color.PeachPuff,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Location = new System.Drawing.Point(3, 3),
                Name = "currentFiler ",
                Size = new System.Drawing.Size(340, 60),
                TabIndex = 1,
                Visible = false
            };

            RichTextBox exampleFilterName = new RichTextBox()
            {
                Anchor = System.Windows.Forms.AnchorStyles.None,
                BackColor = System.Drawing.Color.White,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(46, 11),
                Multiline = false,
                Name = "filterName ",
                ReadOnly = true,
                Size = new System.Drawing.Size(265, 40),
                TabIndex = 13,
                SelectionAlignment = HorizontalAlignment.Center,
            };

            CheckBox exampleButton = new CheckBox()
            {
                BackColor = System.Drawing.Color.PeachPuff,
                Location = new System.Drawing.Point(13, 3),
                Name = "currentFiler ",
                Size = new System.Drawing.Size(315, 60),
                TabIndex = 1,
            };

            LabelsViewHelper.FillLabelPanel(examplePanel, exampleButton,
                exampleFilterName, addTabFiltersPannel,
                _mainController.GetLabelNames());
        }

        private void FillSearchImageFilters()
        {

            Panel examplePanel = new Panel()
            {
                Anchor = System.Windows.Forms.AnchorStyles.None,
                BackColor = System.Drawing.Color.RoyalBlue,
                Location = new System.Drawing.Point(5, 33),
                Name = "searchFilterPannel ",
                Size = new System.Drawing.Size(239, 47),
                TabIndex = 0
            };

            CheckBox exampleButton = new CheckBox()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(17, 13),
                BackColor = System.Drawing.Color.RoyalBlue,
                Name = "searchFilterApply ",
                Size = new System.Drawing.Size(18, 17),
                TabIndex = 1,
                UseVisualStyleBackColor = true,
            };

            RichTextBox exampleFilterName = new RichTextBox()
            {
                Anchor = System.Windows.Forms.AnchorStyles.None,
                BackColor = System.Drawing.Color.RoyalBlue,
                BorderStyle = System.Windows.Forms.BorderStyle.None,
                Cursor = System.Windows.Forms.Cursors.Default,
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Microsoft Sans Serif",
                16.2F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(58, 3),
                Multiline = false,
                Name = "searchFilterTitle ",
                ReadOnly = true,
                Size = new System.Drawing.Size(178, 41),
                SelectionAlignment = HorizontalAlignment.Center,
            };

            LabelsViewHelper.FillLabelPanel(examplePanel, exampleButton,
                exampleFilterName, filtersLayuoutPanel,
                _mainController.GetLabelNames());
            LabelsViewHelper.SetFiltersClickEvent(filtersLayuoutPanel, ChangeSortMethod);
        }

        private void ClickMainImage(object sender, EventArgs e)
        {
            DesktopImage tempImage = _mainController.GetImageFromFile();
            if (tempImage == null)
            {
                return;
            }

            ClearAddPageFields();
            
            using (MemoryStream ms = new MemoryStream(tempImage.MainImage))
            {
                mainImage.Image = Image.FromStream(ms);
            }

            addTabTitle.Text = tempImage.ImageTitle;
            addTabImageWidth.Text = tempImage.ImageWidth.ToString();
            addTabImageHeigth.Text = tempImage.ImageHeigth.ToString();
            addTabImageSize.Text = tempImage.ImageSize.ToString();
            addTabImageAddDate.Text = String.Concat
                (DateTime.Now.ToString().TakeWhile(c => c != ' '));
            addTabImageFormat.Text = tempImage.ImageFormat;

            foreach (Control filterPanel in addTabFiltersPannel.Controls)
            {
                filterPanel.Visible = true;
            }
            addTabTitle.ReadOnly = false;
        }

        private void ClickAddImageButton(object sender, EventArgs e)
        {
            if (mainImage.Image == null)
            {
                MessageBox.Show(caption: "Помилка при додаванні зображення", 
                    text: "Порожнє зображення");
                return;
            }

            AddResult result = _mainController.AddNewImage(addTabTitle.Text, mainImage.Image,
                Convert.ToInt32(addTabImageSize.Text),
                new Tuple<Int32, Int32>(Convert.ToInt32(addTabImageWidth.Text),
                Convert.ToInt32(addTabImageHeigth.Text)),
                Convert.ToDateTime(addTabImageAddDate.Text),
                addTabImageFormat.Text,
                LabelsViewHelper.GetEnabledLabels(addTabFiltersPannel));

            if (result == AddResult.Success)
            { 
                ClearAddPageFields();
                UpdateImageFields();

                rank.Text = _mainController.GetAuthorRank();

                MessageBox.Show(caption: "Повідомлення про додавання",
                   text: "Ви успішно додали нове зображення до загальної бази");
            }
            else if (result == AddResult.Entity_already_exists)
            {
                MessageBox.Show(caption: "Помилка при додаванні зображення",
                    text: "Таке зображення вже існує");
            }

        }

        private void ClearAddPageFields()
        {
            mainImage.Image = null;
            addTabTitle.ReadOnly = true;
            addTabTitle.Clear();
            addTabImageWidth.Clear();
            addTabImageHeigth.Clear();
            addTabImageSize.Clear();
            addTabImageAddDate.Clear();
            addTabImageFormat.Clear();

            foreach (Control filterPanel in addTabFiltersPannel.Controls)
            {
                (filterPanel.Controls[1] as CheckBox).Checked = false;
                filterPanel.Visible = false;
            }
        }

        private void ChangeSortMethod(object sender, EventArgs e)
        {
            MakeImagesFiltered();
        }

        private void ImageClick(object sender, EventArgs e)
        {
            _mainController.ImagesController
                .UpdateIndex(Convert.ToInt32(String.Concat((sender as Control).Name
                .Where(c => Char.IsDigit(c)))));

            imagesPageTitle.Text = _mainController.ImagesController
                .GetCurrentTitle();
            imagesPageWidth.Text = _mainController.ImagesController
                .GetCurrentWidth().ToString();
            imagesPageHeight.Text = _mainController.ImagesController
                .GetCurrentHeight().ToString();
            imagesPageSize.Text = _mainController.ImagesController
                .GetCurrentSize().ToString();
            imagesPageFormat.Text = _mainController.ImagesController
                .GetCurrentFormat();
            imagePageAddDate.Text = String.Concat(
                _mainController.ImagesController
                .GetCurrentDateAddDB().ToString().TakeWhile(c => c != ' '));
        }

        private void ClickDeleteImageButton(object sender, EventArgs e)
        {
            DeleteResult result = _mainController.ImagesController
                .DeleteCurrent();

            rank.Text = _mainController.GetAuthorRank();

            if (result == DeleteResult.Failure)
            {
                MessageBox.Show(caption: "Помилка при видаленні", text: "Не було обрано " +
                    "зображення для видалення");
                return;
            }

            MessageBox.Show(caption: "Повідомлення про успіх", text: "Ви успішно " +
                    "видалили зображення із загальної бази");
            _mainController.ImagesController
                .MakeIndexBigger();

            MakeImagesFiltered();
        }

        private void MakeImagesFiltered()
        {
            ICollection<String> labels =
                        ImagesViewHelper.GetEnabledFilters(filtersLayuoutPanel);

            _mainController.MakeImagesSortedAndFiltered(labels,
                sortParameters.SelectedItem.ToString(),
                !sortDown.Checked);

            UpdateImageFields();
        }
        private void UpdateImageFields()
        {
            PictureBox pictureBoxExample = new PictureBox()
            {
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Location = new System.Drawing.Point(0, 0),
                Name = "pictureBox ",
                Size = new System.Drawing.Size(210, 140),
                TabIndex = 0,
                TabStop = false,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = System.Windows.Forms.Cursors.Hand
            };
            
            ImagesViewHelper.SetImages(pictureBoxExample,
                 imagesPanel,
                 _mainController.ImagesController.GetImages());
            ImagesViewHelper.SetImagesClickEvent(imagesPanel, ImageClick);
        }


        // Account 
        private void SetAccountInfo()
        {
            accountLogin.Text = _mainController.AccountController.GetLogin();
            accountPassword.Text = _mainController.AccountController.GetPassword();
            accountEmail.Text = _mainController.AccountController.GetEmail();
            rank.Text = _mainController.GetAuthorRank();
            rank.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ClickDeleteAccount(object sender, EventArgs e)
        {
            _mainController.AccountController.DeleteAccount();
            MessageBox.Show(caption: "Дія з аккаунтом", text: "Аккаунт було успішено видалено");

            Form loginForm = Application.OpenForms[0];
            loginForm.Show();
            this.Hide();
        }
        private void ClickLogout(object sender, EventArgs e)
        {
            Form loginForm = new Login.LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void AccountClick(object sender, EventArgs e)
        {
            SetAccountInfo();
        }


        private void ChangeAccount(object sender, EventArgs e)
        {
            AccountUpdateResult result = 
                _mainController.AccountController.
                    UpdateAccount(accountLogin.Text, accountPassword.Text,
                    accountEmail.Text);

            if (result == AccountUpdateResult.Login_busy)
            {
                MessageBox.Show(caption: "Помилка дії з аккаунтом", text: "Цей логін вже зайнятий");
                SetAccountInfo();
            }
            else if (result == AccountUpdateResult.Email_busy)
            {
                MessageBox.Show(caption: "Помилка дії з аккаунтом", text: "Цей email вже зайнятий");
            }
            else if (result == AccountUpdateResult.Empty_data)
            {
                MessageBox.Show(caption: "Помилка дії з аккаунтом", text: "Порожні дані");
            }
            else
            {
                MessageBox.Show(caption: "Дія з аккаунтом", text: "Поточні дані успішно змінені");
            }

            SetAccountInfo();
        }

        private AuthorController _mainController;
    }
}
