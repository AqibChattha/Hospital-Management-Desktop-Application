using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace HospitalManagementSystem
{
    class InputBox
    {
        public static String input { get; set; }
        public static DialogResult Show(string title, string promptText, string value="")
        {
            Form form = new Form();
            Label label = new Label();
            RichTextBox richTextBox = new RichTextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            richTextBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 18, 372, 13);
            richTextBox.SetBounds(12, 36, 372, 80);
            buttonOk.SetBounds(228, 132, 75, 23);
            buttonCancel.SetBounds(309, 132, 75, 23);

            label.AutoSize = true;
            richTextBox.Anchor = richTextBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 167);
            form.Controls.AddRange(new Control[] { label, richTextBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(450, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            input = richTextBox.Text;
            return dialogResult;
        }
    }
}
