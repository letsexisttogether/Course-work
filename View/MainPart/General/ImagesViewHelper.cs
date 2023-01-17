using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers.MainPart;


namespace View.MainPart
{
    public static class ImagesViewHelper
    {
        public static void SetImages(PictureBox pictureBoxExample, FlowLayoutPanel imagesPanel,
            IEnumerable<Image> images)
        {
            imagesPanel.Controls.Clear();

            foreach (Image img in images)
            {
                PictureBox pictureBox = new PictureBox()
                {
                    BorderStyle = pictureBoxExample.BorderStyle,
                    Location = pictureBoxExample.Location,
                    Name = pictureBoxExample.Name + imagesPanel.Controls.Count.ToString(),
                    Size = pictureBoxExample.Size,
                    TabIndex = pictureBoxExample.TabIndex,
                    TabStop = pictureBoxExample.TabStop,
                    Image = img,
                    SizeMode = pictureBoxExample.SizeMode,
                    Cursor = pictureBoxExample.Cursor
                };

                imagesPanel.Controls.Add(pictureBox);
            }
        }

        public static void SetImagesClickEvent(FlowLayoutPanel imagesPanel, EventHandler handler)
        {
            foreach (PictureBox pictureBox in imagesPanel.Controls)
            {
                pictureBox.Click -= handler;
                pictureBox.Click += handler;
            }
        }
        public static IEnumerable<Image> GetImages(FlowLayoutPanel imagesPanel)
        {
            ICollection<Image> images = new List<Image>();
            foreach(PictureBox pictureBox in imagesPanel.Controls)
            {
                images.Add(pictureBox.Image);
            }

            return images;
        }

        public static ICollection<String> GetEnabledFilters(FlowLayoutPanel filtersPanel)
        {
            ICollection<String> filterNames = new List<String>();
            foreach (Panel currentFilter in filtersPanel.Controls)
            {
                String filterName = (currentFilter.Controls[0] as RichTextBox).Text;

                if ((currentFilter.Controls[1] as CheckBox).Checked)
                {
                    filterNames.Add(filterName);
                }
            }

            return filterNames;
        }
    }
}
