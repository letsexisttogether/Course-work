using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers.MainPart;
using Model.Processors;

namespace View.MainPart.User
{
    public partial class UserForm : Form
    {
        public UserForm(Int32 id)
        {
            InitializeComponent();
            FormClosed += UserFormClosed;

            _mainController = new UserController(id);
        }

        // Form events
        private void LoadUserForm(object sender, EventArgs e)
        {
            SetAccountInfo();

            FillSearchFilterBox();
            SetAllImages();

            _mainController.UpdateUserOnlyImages();
            SetCurrentImage();

            this.sortParameters.SelectedItem = this.sortParameters.Items[1];
            this.imageSetStyle.SelectedItem = this.imageSetStyle.Items[1];
        }
        private void UserFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ClickNotAccountPage(object sender, EventArgs e)
        {
            SetAccountInfo();
        }

        // All images page
        private void SetAllImages()
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

            ImagesViewHelper.SetImages(pictureBoxExample, imagesPanel,
                _mainController.AllImagesController.GetImages());
            ImagesViewHelper.SetImagesClickEvent(imagesPanel, ImageClick);
        }
        private void SearchTitleChanged(object sender, EventArgs e)
        {
            RichTextBox searchTitlBox = (RichTextBox)sender;

            _mainController.AllImagesController.UpdateImagesByTitle(searchTitlBox.Text);
            SetAllImages();
        }
        private void FillSearchFilterBox()
        {
            Panel examplePannel = new Panel()
            {
                Location = new System.Drawing.Point(3, 3),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.BlueViolet,
                ForeColor = System.Drawing.Color.White,
                Name = "filterPanel ",
                Size = new System.Drawing.Size(244, 47),
                TabIndex = 0
            };
            RichTextBox exampleBox = new RichTextBox()
            {
                BackColor = System.Drawing.Color.BlueViolet,
                BorderStyle = System.Windows.Forms.BorderStyle.None,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(72, 3),
                Name = "filterTitle ",
                Size = new System.Drawing.Size(169, 38),
                TabIndex = 0,
                SelectionAlignment = HorizontalAlignment.Center
            };
            CheckBox exampleButton = new CheckBox()
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.BlueViolet,
                Location = new System.Drawing.Point(24, 17),
                Name = "checkButton ",
                Size = new System.Drawing.Size(18, 17),
                TabIndex = 0,
                UseVisualStyleBackColor = true,
                Cursor = System.Windows.Forms.Cursors.Hand,
            };
            exampleButton.CheckedChanged += FilterChanged;

            LabelsViewHelper.FillLabelPanel(examplePannel, exampleButton, exampleBox,
                filtersLayuoutPanel, _mainController.AllImagesController.GetAllLabels());
            LabelsViewHelper.SetFiltersClickEvent(filtersLayuoutPanel, FilterChanged);
        }
        private void FilterChanged(object sender, EventArgs e)
        {
            _mainController.MakeImagesSortedAndFiltered(
                LabelsViewHelper.GetEnabledLabels(filtersLayuoutPanel),
                sortParameters.SelectedItem.ToString(), !sortDown.Checked,
                titleSearch.Text);

            SetAllImages();
        }
        private void ImageClick(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            Int32 index = Convert.ToInt32
                (String.Concat(control.Name
                .Where(c => Char.IsDigit(c))));

            _mainController.AllImagesController.UpdateIndex(index);

            Image image = _mainController.AllImagesController
                .GetCurrentSelected();

            selectedPicture.Image = image;
            selectedImageTitle.Text = _mainController.AllImagesController
                .GetCurrentTitle();
            selectedImageFormat.Text = _mainController.AllImagesController
                .GetCurrentFormat();
            selectedImageWidth.Text = _mainController.AllImagesController
                .GetCurrentWidth().ToString();
            selectedImageHeight.Text = _mainController.AllImagesController
                .GetCurrentHeight().ToString();
            selectedImageAuthor.Text = _mainController.AllImagesController
                .GetCurrentAuthorLogin();
            selectedImageUpdateDate.Text = String.Concat(
                _mainController.AllImagesController
                .GetCurrentDateAddDB().ToString().TakeWhile(c => c != ' '));
            selectedImageRating.Text = _mainController.AllImagesController
                .GetCurrentAvgRating().ToString();
        }
        private void ClickAddToCollection(object sender, EventArgs e)
        {
            if (_mainController.AllImagesController
                .GetCurrentSelected() == null)
            {
                MessageBox.Show(caption: "Ошибка при додаванні", 
                    text: "Ви не обрали зображення");
                return;
            }

            AddResult result = _mainController.AddNewConnection();

            if (result == AddResult.Success)
            {
                MessageBox.Show(caption: "Повідомлення про успіх", 
                    text: "Ви додали обране зображення " +
                    "до своєї колекції");
                _mainController.UpdateUserOnlyImages();
                SetCurrentImage();
            }
            else
            {
                MessageBox.Show(caption: "Ошибка при додаванні", 
                    text: "У вашій колекції вже є таке зображення");
            }
        }

        // Single image page
        private void SetCurrentImage()
        {
            myCurrentImage.Image =
             _mainController.SingleImageController
                .GetCurrentSelected();

            currentImageTitle.Text = _mainController.SingleImageController
                .GetCurrentTitle();
            currentImageSize.Text = _mainController.SingleImageController
                .GetCurrentSize().ToString();
            currentImageWidth.Text = _mainController.SingleImageController
                .GetCurrentWidth().ToString();
            currentImageWidth.Text = _mainController.SingleImageController
                .GetCurrentWidth().ToString();
            currentImageHeight.Text = _mainController.SingleImageController
                .GetCurrentHeight().ToString();
            currentImageFormat.Text = _mainController.SingleImageController
                .GetCurrentFormat();
            currentImageAddDBDate.Text = String.Concat(
                _mainController.SingleImageController
                .GetCurrentDateAddDB().ToString().TakeWhile(c => c != ' '));
            currentImageAuthor.Text = _mainController.SingleImageController
                .GetCurrentAuthorLogin();
            addDate.Text = String.Concat(
                _mainController
                .GetImageAddDateForUser().ToString().TakeWhile(c => c != ' '));

            MakeStarShine();
        }
        private void ClickInstallImage(object sender, EventArgs e)
        {
            SetResult result =
                _mainController.SetCurrentAsImage(imageSetStyle.SelectedItem.ToString());

            if (result == SetResult.Style_not_found)
            {
                MessageBox.Show(caption: "Ошибка при встановленні", text: "Обраний стиль не знайдено");
            }
            else if (result == SetResult.Unrecognized_image)
            {
                MessageBox.Show(caption: "Ошибка при встановленні", text: "Немає зображення");
            }
            else
            {
                MessageBox.Show(caption: "Повідомлення про встановлення", text: "Зображення було успішно встановленне");

            }
        }
        private void ClickDeleteImage(object sender, EventArgs e)
        {
            DeleteResult result = _mainController.DeleteCurrentConnection();

            if (result == DeleteResult.Failure)
            {
                MessageBox.Show(caption: "Помилка при видалення", text: "Не вдалося видалити " +
                    "поточне зображення з коллекції");
                return;
            }

            _mainController.UpdateUserOnlyImages();
            _mainController.SingleImageController.MakeIndexSmaller();
            SetCurrentImage();

            MessageBox.Show(caption: "Повідомлення про успіх", text: "Зображення було успішно " +
                "видалено з вашої коллекції");
        }
        private void ClickLeft(object sender, EventArgs e)
        {
            _mainController.SingleImageController
                .MakeIndexSmaller();

            SetCurrentImage();
        }
        private void ClickRight(object sender, EventArgs e)
        {
            _mainController.SingleImageController
                .MakeIndexBigger();

            SetCurrentImage();
        }

        // Account page
        private void SetAccountInfo()
        {
            this.accountLogin.Text = _mainController.AccountController.GetLogin();
            this.Text += _mainController.AccountController.GetLogin();
            this.accountPassword.Text = _mainController.AccountController.GetPassword();
            this.accountEmail.Text = _mainController.AccountController.GetEmail();

            this.userName.Text = _mainController.GetName();
            this.surname.Text = _mainController.GetSurname();
            this.birthDate.SetDate(_mainController.GetBirthDate());
        }
        private void ClickLogout(object sender, EventArgs e)
        {
            Form loginForm = new Login.LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void ClickDeleteAccount(object sender, EventArgs e)
        {
            _mainController.AccountController.DeleteAccount();
            MessageBox.Show(caption: "Дія з аккаунтом", text: "Аккаунт було успішено видалено");

            Form loginForm = Application.OpenForms[0];
            loginForm.Show();
            this.Hide();
        }
        
        private void ClickUpdateAccount(object sender, EventArgs e)
        {
            AccountUpdateResult result = 
                _mainController.ChangeUser(accountLogin.Text, accountPassword.Text,
                    accountEmail.Text, userName.Text, surname.Text,
                    Convert.ToDateTime(birthDate.SelectionRange.Start.ToString()));

            if (result == AccountUpdateResult.Login_busy)
            {
                MessageBox.Show(caption: "Помилка дії з користувачем", text: "Цей логін вже зайнятий");
                SetAccountInfo();
            }
            else if (result == AccountUpdateResult.Email_busy)
            {
                MessageBox.Show(caption: "Помилка дії з користувачем", text: "Цей email вже зайнятий");
            }
            else if (result == AccountUpdateResult.Empty_data)
            {
                MessageBox.Show(caption: "Помилка дії з користувачем", text: "Порожні дані");
            }
            else
            {
                MessageBox.Show(caption: "Дія з користувачем", text: "Поточні дані успішно змінені");
            }

            SetAccountInfo();
        }

        private UserController _mainController;

        private void PickStar(object sender, EventArgs e)
        {
            _mainController.SetRating(Convert.ToInt32(String.Concat((sender as Control).Name
                    .Where(c => Char.IsDigit(c)))));

            MakeStarShine();
        }

        private void MakeStarShine()
        {
            Int32 rating = _mainController.GetImageRatingForUser();

            foreach (Control star in starsBox.Controls)
            {
                Int32 starValue = Convert.ToInt32(String.Concat(star.Name
                    .Where(c => Char.IsDigit(c))));

                star.BackColor = starValue > rating && rating != 0 ?
                    Color.White : Color.YellowGreen;
            }
        }
    }
}
