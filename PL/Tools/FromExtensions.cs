
namespace PL
{
    public static class FromExtensions
    {
        public static void CreateRelativeForm<TForm>(this Form form) where TForm : Form, new()
        {
            TForm newForm = new();
            newForm.Owner = form;
            form.Hide();
            newForm.Show();
        }

        public static void BackToOwnerForm(this Form form)
        {
            if (form.Owner == null)
                throw null;

            form.Owner.Show();
            form.Close();
        }

        public static void CreateDialog<T>(this Form form) where T : Form, new()
        {
            T orderCreationMenu = new();
            orderCreationMenu.ShowDialog();
        }
    }
}
