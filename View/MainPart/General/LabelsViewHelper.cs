using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace View.MainPart
{
    public static class LabelsViewHelper
    {
        public static void FillLabelPanel(Panel panelExample, CheckBox checkBoxExaple,
            RichTextBox textBoxExample, FlowLayoutPanel filtersPanel, IEnumerable<String> filterNames)
        {
            filtersPanel.Controls.Clear();
            
            foreach(String filterName in filterNames)
            {
                Panel nFilterPanel = new Panel()
                {
                    BackColor = panelExample.BackColor,
                    BorderStyle = panelExample.BorderStyle,
                    Location = panelExample.Location,
                    Name = panelExample.Name + filtersPanel.Controls.Count.ToString(),
                    Size = panelExample.Size,
                    TabIndex = panelExample.TabIndex,
                    Visible = panelExample.Visible
                };

                RichTextBox nFilerName = new RichTextBox()
                {
                    Anchor = textBoxExample.Anchor,
                    BackColor = textBoxExample.BackColor,
                    BorderStyle = textBoxExample.BorderStyle,
                    Cursor = textBoxExample.Cursor,
                    Font = textBoxExample.Font,
                    ForeColor = textBoxExample.ForeColor,
                    Location = textBoxExample.Location,
                    Multiline = textBoxExample.Multiline,
                    Name = textBoxExample.Name + filtersPanel.Controls.Count.ToString(),
                    ReadOnly = textBoxExample.ReadOnly,
                    Size = textBoxExample.Size,
                    TabIndex = textBoxExample.TabIndex,
                    Text = filterName,
                    SelectionAlignment = textBoxExample.SelectionAlignment,
                };

                CheckBox nSelectCurrent = new CheckBox()
                {
                    BackColor = checkBoxExaple.BackColor,
                    Location = checkBoxExaple.Location,
                    Name = checkBoxExaple.Name + filtersPanel.Controls.Count.ToString(),
                    Size = checkBoxExaple.Size,
                    TabIndex = checkBoxExaple.TabIndex,
                    Cursor = checkBoxExaple.Cursor,
                };

                nFilterPanel.Controls.Add(nFilerName);
                nFilterPanel.Controls.Add(nSelectCurrent);

                filtersPanel.Controls.Add(nFilterPanel);
            }
        }

        public static void SetFiltersClickEvent(FlowLayoutPanel filtersPannel, EventHandler eventHandler)
        {
            foreach (Panel filterPanel in filtersPannel.Controls)
            {
                foreach(Control control in filterPanel.Controls)
                {
                    if (control.GetType() == typeof(CheckBox))
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.CheckedChanged += eventHandler;
                    }
                }
            }
        }

        public static ICollection<String> GetEnabledLabels (FlowLayoutPanel filtersPanel)
        {
            if (filtersPanel.Controls.Count == 0)
            {
                return new List<String>();
            }

            ICollection<String> filterNames = new List<String>();
            foreach (Panel filterPanel in filtersPanel.Controls)
            {

                try
                {
                    if ((filterPanel.Controls[1] as CheckBox).Checked)
                    {
                        RichTextBox richTextBox = (RichTextBox)filterPanel.Controls[0];
                        filterNames.Add(richTextBox.Text);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return filterNames;
        }
    }
}
