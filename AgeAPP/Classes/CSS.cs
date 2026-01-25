namespace AgeAPP.Styles
{
    internal class CSS
    {
        public static class HoverStyles
        {
            public static void CardHover(Control control)
            {
                Color defaultColor = control.BackColor;
                Color hoverColor = Color.FromArgb(48, 48, 48);

                control.MouseEnter += (_, _) =>
                {
                    control.BackColor = hoverColor;
                };

                control.MouseLeave += (_, _) =>
                {
                    control.BackColor = defaultColor;
                };
            }

            //  já deixa pronto pra crescer
            public static void SoftHover(Control control)
            {
                Color defaultColor = control.BackColor;
                Color hoverColor = Color.FromArgb(40, 40, 40);

                control.MouseEnter += (_, _) => control.BackColor = hoverColor;
                control.MouseLeave += (_, _) => control.BackColor = defaultColor;
            }
        }
    }
}
