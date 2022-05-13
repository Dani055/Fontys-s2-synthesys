using BusinessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysDesktop
{
    public static class DesktopUtils
    {
        public static User loggedUser { get; set; } = null;

        public static bool UpdateContent { get; set; } = false;
        public static void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowConfirmation(string text)
        {
            return MessageBox.Show(text, caption: "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
